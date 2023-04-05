using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamenCustomer
{
    public partial class FormMain : Form
    {
        FormTitle formTitle;
        public FormMain(FormTitle form)
        {
            InitializeComponent();
            formTitle = form;
            formTitle.Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formTitle.Show();
        }
    }
}
