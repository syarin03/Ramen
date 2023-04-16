using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace RamenCustomer
{
    public partial class FormPay : UIForm
    {
        TcpClientManager clientManager;
        FormMain formMain;

        public FormPay(TcpClientManager clientManager, FormMain form)
        {
            InitializeComponent();
            this.clientManager = clientManager;
            formMain = form;
        }

        private void BtnPayToMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> sendDict = new Dictionary<string, object>();
            sendDict.Add("method", "Order");
            sendDict.Add("values", GetDataTable(TableMenuList));
            clientManager.SendData(sendDict);
            UIMessageBox.Show("주문이 완료되었습니다!");
            Close();
            formMain.TableMenuList.ClearAll();
            formMain.LabelTotal.Text = "₩ 0";
            formMain.TabMenu.SelectTab(0);
            formMain.BtnTitleToMain.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DataTable GetDataTable(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow newRow = dt.NewRow();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(newRow);
            }
            return dt;
        }
    }
}
