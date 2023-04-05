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

namespace RamenAdmin
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();

        public Form1()
        {
            InitializeComponent();

            new Thread(delegate ()
            {
                InitSocket();
            }).Start();
        }

        private void InitSocket()
        {
            try
            {
                clientSocket.Connect("10.10.21.116", 9999);
                DisplayText("Client Started");
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        label1.Text = "Client Socket Program - Server Connected ...";
                    }));
                }
                else
                {
                    label1.Text = "Client Socket Program - Server Connected ...";
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FormTitle_Click(object sender, EventArgs e)
        {
            //string sendData = "hello";  // testBox3 의 내용을 sendData1 변수에 저장
            //Writer.WriteLine(sendData);  // 스트림라이터를 통해 데이타를 전송
            //FormMain formMain = new FormMain(this);
            //formMain.Show();
        }

        private void FormTitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientSocket?.Close();
        }

        private void DisplayText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(Environment.NewLine + " >> " + text);
                }));
            }
            else
                richTextBox1.AppendText(Environment.NewLine + " >> " + text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkStream stream = clientSocket.GetStream();
            byte[] sbuffer = Encoding.Unicode.GetBytes(richTextBox2.Text + "$");
            stream.Write(sbuffer, 0, sbuffer.Length);
            stream.Flush();

            byte[] rbuffer = new byte[1024];
            stream.Read(rbuffer, 0, rbuffer.Length);
            string msg = Encoding.Unicode.GetString(rbuffer);
            msg = "Data from Server : " + msg;
            DisplayText(msg);

            richTextBox2.Text = "";
            richTextBox2.Focus();
        }
    }
}
