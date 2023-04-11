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
using Sunny.UI;

namespace RamenServer
{
    public partial class FormServer : UIForm
    {
        TcpServerManager serverManager;

        public FormServer()
        {
            InitializeComponent();
            serverManager = new TcpServerManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpServerManager.Append += new TcpServerManager.AppendText(AppendText);
        }

        private void BtnServerStart_Click(object sender, EventArgs e)
        {
            serverManager.ServerStart();
        }

        private void BtnServerStop_Click(object sender, EventArgs e)
        {
            serverManager.ServerStop();
        }

        private void AppendText(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                    LogHistory.AppendText("\r\n");
                    LogHistory.ScrollToCaret();
                }));
            }
            else
            {
                LogHistory.AppendText(DateTime.Now.ToString() + ": " + s);
                LogHistory.AppendText("\r\n");
                LogHistory.ScrollToCaret();
            }
        }

        private void BtnServerReboot_Click(object sender, EventArgs e)
        {
            serverManager.ServerStop();
            Thread.Sleep(1000);
            serverManager.ServerStart();
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }   
    }
}
