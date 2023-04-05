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

namespace RamenServer
{
    public partial class Form1 : Form
    {
        TcpListener server;
        TcpClient client;
        static int counter = 0;
        Thread t;

        public Form1()
        {
            InitializeComponent();

            t = new Thread(InitSocket)
            {
                IsBackground = true
            };
            t.Start();
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999);
            client = default;
            server.Start();
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++;
                    client = server.AcceptTcpClient();
                    DisplayText(">> Accept connection from client");

                    handleClient h_client = new handleClient();
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(DisplayText);
                    h_client.OnCalculated += new handleClient.CalculateClientCounter(CalculateCounter);
                    h_client.startClient(client, counter);
                }
                catch (SocketException se)
                {
                    Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                    break;  // while loop 종료
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                }
            }
        }

        private void CalculateCounter()
        {
            counter--;
        }

        private void DisplayText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(text + Environment.NewLine);
                }));
            }
            else
                richTextBox1.AppendText(text + Environment.NewLine);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }

            if (server != null)
            {
                server.Stop();
                server = null;
            }

            t.Join();  // 스레드 중지 대기

            // 새로운 스레드 시작
            t = new Thread(InitSocket)
            {
                IsBackground = true
            };
            t.Start();
        }
    }
}
