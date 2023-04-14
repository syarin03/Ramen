using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace RamenCustomer
{
    public partial class FormTitle : UIForm
    {
        TcpClientManager clientManager;

        public FormTitle()
        {
            InitializeComponent();
            clientManager = new TcpClientManager();
        }

        private void FormTitle_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormTitle_Load(object sender, EventArgs e)
        {

        }

        private void BtnTitleToMain_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(this, clientManager);
            formMain.Show();
        }
    }
}
