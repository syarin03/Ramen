using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace RamenServer
{
    public partial class FormServer : Form
    {
        ServerManager manager;

        public FormServer()
        {
            InitializeComponent();
            manager = new ServerManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServerManager.AT += new ServerManager.AppendText(AppendText);
        }

        private void BtnServerStart_Click(object sender, EventArgs e)
        {
            manager.Start();
        }

        private void BtnServerStop_Click(object sender, EventArgs e)
        {
            manager.Stop();
        }

        private void AppendText(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                    LogHistory.AppendText("\r\n");
                }));
            }
            else
            {
                LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                LogHistory.AppendText("\r\n");
            }
        }

        private void BtnServerReboot_Click(object sender, EventArgs e)
        {
            manager.Reboot();
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            manager.Stop();
        }
    }
}
