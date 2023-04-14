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

        public TcpServerManager()
        {
            listener = new TcpListener(IPAddress.Any, 2869); // 아무 아이피나 2869포트를 통해서 접속 가능한 리스너
            DatabaseManager.ConnectTest();
        }

        public void ServerStart()
        {
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
        }

        public void ServerStop()
        {
            foreach (TcpClient client in clientList)
            {
                client.Close();
            }
            listener.Stop();

            AddLog("Server Stop");
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
                        List<string> menuList = LoadMenu();
                        sendDataDict.Add("result", menuList);
                        break;
                    case "what":
                        AddLog("what");
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

        public List<string> LoadMenu()
        {
            List<string> menuList = new List<string>();
            string sqlStr = "SELECT name FROM table_menu";
            DataTable selectResult = DatabaseManager.GetDataTable(sqlStr);
            foreach (DataRow row in selectResult.Rows)
            {
                menuList.Add(row[0].ToString());
            }

            return menuList;
        }
    }
}
