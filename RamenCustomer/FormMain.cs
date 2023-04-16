using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace RamenCustomer
{
    public partial class FormMain : UIForm
    {
        TcpClientManager clientManager;

        public FormMain()
        {
            InitializeComponent();
            clientManager = new TcpClientManager(this);

            Dictionary<string, object> sendData = new Dictionary<string, object>
            {
                { "method", "LoadMenu" }
            };
            clientManager.SendData(sendData);

            BtnTitleToMain.Size = this.Size;

            UILocalizeHelper.SetEN();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void BtnMainToTitle_Click(object sender, EventArgs e)
        {
            BtnTitleToMain.Visible = true;
        }

        public void menuAdd(string name, string category, int price, string image)
        {
            MenuImageButton btn = new MenuImageButton();
            btn.text = name + "\n₩ " + price;
            btn.image = Image.FromFile("./Images/" + image);
            btn.Font = new Font("나눔바른고딕", 12f);
            btn.MenuImageClick += SelectMenu;

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    switch (category)
                    {
                        case "라면":
                            LayoutSelectRamen.Controls.Add(btn);
                            break;
                        case "만두":
                            LayoutSelectMandu.Controls.Add(btn);
                            break;
                        case "밥":
                            LayoutSelectRice.Controls.Add(btn);
                            break;
                        case "음료":
                            LayoutSelectDrink.Controls.Add(btn);
                            break;
                        default:
                            break;
                    }
                }));
            }
            else
            {
                switch (category)
                {
                    case "라면":
                        LayoutSelectRamen.Controls.Add(btn);
                        break;
                    case "만두":
                        LayoutSelectMandu.Controls.Add(btn);
                        break;
                    case "밥":
                        LayoutSelectRice.Controls.Add(btn);
                        break;
                    case "음료":
                        LayoutSelectDrink.Controls.Add(btn);
                        break;
                    default:
                        break;
                }
            }
        }

        private void SelectMenu(object sender, EventArgs e)
        {
            MenuImageButton btn = (MenuImageButton)sender;
            string[] data = btn.text.Split("\n₩ ");
            string name = data[0];
            int price = int.Parse(data[1]);
            Image image = btn.image;
            FormMenuDetail formMenuDetail = new FormMenuDetail(this, name, price, image);
            formMenuDetail.ShowDialog();
        }

        private void BtnTitleToMain_Click(object sender, EventArgs e)
        {
            BtnTitleToMain.Visible = false;
        }

        public void TotalPrice()
        {
            int total = 0;
            foreach (DataGridViewRow row in TableMenuList.Rows)
            {
                total += (int)row.Cells["menuPrice"].Value;
            }
            LabelTotal.Text = "₩ " + total.ToString();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            FormPay formPay = new FormPay(clientManager, this);
            foreach (DataGridViewRow row in TableMenuList.Rows)
            {
                formPay.TableMenuList.AddRow(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
            }
            int total = 0;
            foreach (DataGridViewRow row in TableMenuList.Rows)
            {
                total += (int)row.Cells["menuPrice"].Value;
            }
            formPay.LabelTotal.Text = "₩ " + total.ToString();
            formPay.ShowDialog();
        }
    }
}
