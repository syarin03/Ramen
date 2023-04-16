using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace RamenCustomer
{
    public partial class FormMenuDetail : UIForm
    {
        string menuName;
        int menuPrice;
        FormMain form;

        public FormMenuDetail(FormMain form, string name, int price, Image image)
        {
            InitializeComponent();
            menuName = name;
            menuPrice = price;
            LabelMenuName.Text = menuName;
            LabelMenuPrice.Text = menuPrice.ToString();
            ImageMenu.Image = image;
            this.form = form;
        }

        private void BtnDetailClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddMenu_Click(object sender, EventArgs e)
        {
            int count = CountMenu.Value;
            foreach (DataGridViewRow row in form.TableMenuList.Rows)
            {
                if (row.Cells["menuName"].Value.ToString() == menuName)
                {
                    row.Cells["menuCount"].Value = int.Parse(row.Cells["menuCount"].Value.ToString()) + count;
                    row.Cells["menuPrice"].Value = int.Parse(menuPrice.ToString()) * int.Parse(row.Cells["menuCount"].Value.ToString());
                    form.TotalPrice();
                    Close();
                    return;
                }
            }
            form.TableMenuList.AddRow(menuName, count, int.Parse(menuPrice.ToString()) * count);
            form.TotalPrice();
            Close();
        }
    }
}
