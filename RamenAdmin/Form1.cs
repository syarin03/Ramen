using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace RamenAdmin
{
    public partial class Form1 : UIForm
    {
        TcpClientManager clientManager;

        public Form1()
        {
            InitializeComponent();
            clientManager = new TcpClientManager(this);

            RequestStockData();
            RequestOrderData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RequestStockData();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            RequestAddStock();
        }

        private void RequestStockData()
        {
            Dictionary<string, object> sendData = new Dictionary<string, object>();
            sendData.Add("method", "RequestStockData");
            clientManager.SendData(sendData);
        }

        private void RequestOrderData()
        {
            Dictionary<string, object> sendData = new Dictionary<string, object>();
            sendData.Add("method", "RequestOrderData");
            clientManager.SendData(sendData);
        }

        private void RequestAddStock()
        {
            Dictionary<string, object> sendData = new Dictionary<string, object>();
            List<string> addingStocks = new List<string>();
            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    addingStocks.Add((string)row.Cells[1].Value);
                }
            }
            sendData.Add("method", "RequestAddStock");
            sendData.Add("addingStocks", addingStocks);
            clientManager.SendData(sendData);
        }

        public void UpdateStock(DataTable dataTable)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                uiDataGridView1.ClearRows();
                foreach (DataRow row in dataTable.Rows)
                {
                    string name = (string)row["name"];
                    int stock = (int)row["menu_stock"];
                    uiDataGridView1.AddRow(false, name, stock);
                }
            }));
        }

        public void LoadOrder(DataTable dataTable)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                TableMenuList.ClearRows();
                foreach (DataRow row in dataTable.Rows)
                {
                    string orderDatetime = (string)row["order_date"];
                    string name = (string)row["name"];
                    decimal count = (decimal)row["count"];
                    decimal price = (decimal)row["price"] * count;
                    if (orderDatetime == "합계")
                        price = (decimal)row["price"];
                    TableMenuList.AddRow(orderDatetime, name, count, price);
                }
            }));
        }
    }
}
