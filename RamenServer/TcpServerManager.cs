using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using MySql.Data.MySqlClient;
using System.Management;
using System.Data;
using MySqlX.XDevAPI;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace RamenServer
{
    internal class TcpServerManager
    {
        public delegate void AppendText(string str);
        TcpListener listener;
        List<TcpClient> clientList = new List<TcpClient>();
        Queue<Dictionary<string, object>> ReceiveDataQueue = new Queue<Dictionary<string, object>>();
        Thread listenerThread;
        Thread processThread;
        public bool isRun = false;

        public TcpServerManager()
        {
            listener = new TcpListener(IPAddress.Any, 2869); // 아무 아이피나 2869포트를 통해서 접속 가능한 리스너
            DatabaseManager.ConnectTest();
        }

        public void ServerStart()
        {
            if (isRun)
            {
                AddLog("Server is already running");
                return;
            }
            listener.Start();

            listenerThread = new Thread(ServerThread)
            {
                IsBackground = true
            };
            listenerThread.Start();

            processThread = new Thread(ProcessReceiveData)
            {
                IsBackground = true
            };
            processThread.Start();

            AddLog("Server Start");

            isRun = true;
        }

        public void ServerStop()
        {
            if (!isRun)
            {
                AddLog("Server is not running");
                return;
            }
            foreach (TcpClient client in clientList)
            {
                client.Close();
            }
            listener.Stop();

            AddLog("Server Stop");

            isRun = false;
        }

        private void ServerThread()
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clientList.Add(client);
                    AddLog($"Client \"{client.Client.RemoteEndPoint}\" Connect");

                    Thread clientThread = new Thread(() => ReceiveData(client))
                    {   
                        IsBackground = true
                    };
                    clientThread.Start();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void ReceiveData(TcpClient client)
        {
            while (true)
            {
                try
                {
                    NetworkStream networkStream = client.GetStream();
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        byte[] buffer = new byte[client.ReceiveBufferSize];
                        int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
                        memoryStream.Write(buffer, 0, bytesRead);
                        memoryStream.Position = 0;

                        Dictionary<string, object> receiveDataDict = (Dictionary<string, object>)binaryFormatter.Deserialize(memoryStream);

                        ReceiveDataQueue.Enqueue(receiveDataDict);
                    }
                }
                catch (Exception)
                {
                    AddLog($"Client \"{client.Client.RemoteEndPoint}\" Disconnect");
                    clientList.Remove(client);
                    client.Close();
                    client.Dispose();
                    return;
                }
            }
        }
            
        private void ProcessReceiveData()
        {
            while (true)
            {
                if (ReceiveDataQueue.Count <= 0) continue;

                Dictionary<string, object> receiveDataDict = ReceiveDataQueue.Dequeue();
                string method = receiveDataDict["method"].ToString();
                AddLog($"Client Send \"{method}\" Method");
                Dictionary<string, object> sendDataDict = new Dictionary<string, object>();

                // 받은 데이터 처리하는 코드
                switch (method)
                {
                    case "LoadMenu":
                        sendDataDict.Add("method", "LoadMenuResult");
                        DataTable menuTable = LoadMenu();
                        sendDataDict.Add("result", menuTable);
                        break;
                    case "Order":
                        sendDataDict.Add("method", "OrderResult");
                        DataTable orderTable = (DataTable)receiveDataDict["values"];
                        InsertOrder(orderTable);
                        sendDataDict.Add("method", "LoadOrderDataResult");
                        DataTable loadOrderTable = LoadOrderData();
                        sendDataDict.Add("result", loadOrderTable);
                        break;
                    case "RequestStockData":
                        sendDataDict.Add("method", "StockDataResult");
                        DataTable stockTable = LoadStockData();
                        sendDataDict.Add("result", stockTable);
                        break;
                    case "RequestAddStock":
                        List<string> addingStocks = (List<string>)receiveDataDict["addingStocks"];
                        AddStocks(addingStocks);
                        sendDataDict.Add("method", "StockDataResult");
                        DataTable stockTable2 = LoadStockData();
                        sendDataDict.Add("result", stockTable2);
                        break;
                    case "RequestOrderData":
                        sendDataDict.Add("method", "LoadOrderDataResult");
                        DataTable loadOrderTable2 = LoadOrderData();
                        sendDataDict.Add("result", loadOrderTable2);
                        break;
                    default:
                        break;
                }

                foreach (TcpClient client in clientList)
                {
                    SendData(client, sendDataDict);
                }
            }
        }

        public void SendData(TcpClient client, Dictionary<string, object> sendDataDict)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, sendDataDict);
            byte[] sendData = memoryStream.ToArray();
            NetworkStream networkStream = client.GetStream();

            try
            {
                networkStream.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static event AppendText Append;

        public static void AddLog(string log)
        {
            Append(log);
        }

        public void AddStocks(List<string> stocks)
        {
            foreach (string stock in stocks)
            {
                string sql = $"UPDATE table_stock SET menu_stock = menu_stock + 10 WHERE num = (SELECT num FROM table_menu WHERE name = '{stock}')";
                DatabaseManager.CommitData(sql);
            }
        }

        public DataTable LoadOrderData()
        {
            StringBuilder sql = new StringBuilder(1024);
            sql.AppendLine($"SELECT                      ");
            sql.AppendLine($"    a.order_date,           ");
            sql.AppendLine($"    b.name,                 ");
            sql.AppendLine($"    a.count,                ");
            sql.AppendLine($"    b.price                 ");
            sql.AppendLine($"FROM table_order a          ");
            sql.AppendLine($"LEFT JOIN table_menu b      ");
            sql.AppendLine($"ON a.menu_num = b.num       ");
            sql.AppendLine($"                            ");
            sql.AppendLine($"UNION                       ");
            sql.AppendLine($"                            ");
            sql.AppendLine($"SELECT                      ");
            sql.AppendLine($"    '합계',                  ");
            sql.AppendLine($"    '',                     ");
            sql.AppendLine($"    SUM(a.count) AS count,  ");
            sql.AppendLine($"    SUM(b.price) as price   ");
            sql.AppendLine($"FROM table_order a          ");
            sql.AppendLine($"LEFT JOIN table_menu b      ");
            sql.AppendLine($"ON a.menu_num = b.num       ");
            DataTable dataTable = DatabaseManager.GetDataTable(sql.ToString());
            return dataTable;
        }

        public DataTable LoadStockData()
        {
            StringBuilder sql = new StringBuilder(1024);
            sql.AppendLine($"SELECT                     ");
            sql.AppendLine($"    B.name, a.menu_stock   ");
            sql.AppendLine($"FROM table_stock a         ");
            sql.AppendLine($"LEFT JOIN table_menu b     ");
            sql.AppendLine($"ON a.menu_num = b.num      ");
            DataTable dataTable = DatabaseManager.GetDataTable(sql.ToString());
            return dataTable;
        }

        public DataTable LoadMenu()
        {
            string sqlStr = "SELECT name, price, category, image FROM table_menu";
            DataTable selectResult = DatabaseManager.GetDataTable(sqlStr);

            return selectResult;
        }

        public void InsertOrder(DataTable orderTable)
        {
            string sqlStr = "SELECT MAX(order_num) FROM table_order";
            DataTable selectResult = DatabaseManager.GetDataTable(sqlStr);
            int order_num;
            if (string.IsNullOrEmpty(selectResult.Rows[0][0].ToString()))
            {
                order_num = 0;
            }
            else
            {
                order_num = (int)selectResult.Rows[0][0] + 1;
            }

            foreach (DataRow row in orderTable.Rows)
            {
                sqlStr = $"INSERT INTO table_order (order_num, menu_num, count, order_date) " +
                    $"VALUES ({order_num}, (SELECT num FROM table_menu WHERE name = \"{row[0]}\"), {row[1]}, now())";
                DatabaseManager.CommitData(sqlStr);
                sqlStr = $"UPDATE table_stock SET menu_stock = menu_stock - {row[1]} WHERE menu_num = (SELECT num FROM table_menu WHERE name = \"{row[0]}\")";
                DatabaseManager.CommitData(sqlStr);
            }
        }
    }
}
