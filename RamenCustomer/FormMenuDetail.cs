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

        public FormMenuDetail(string name)
        {
            InitializeComponent();
            menuName = name;
            uiLabel1.Text = menuName;
        }

        private void BtnOptionRamenCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
