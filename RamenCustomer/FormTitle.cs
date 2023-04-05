using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace RamenCustomer
{
    public partial class FormTitle : Form
    {
        TcpClient client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;
        Thread ReceiveThread;
        bool Connected;
        private delegate void SetTextDelegate(string s);

        public FormTitle()
        {
            InitializeComponent();
        }

        private void FormTitle_Load(object sender, EventArgs e)
        {
            string IP = "10.10.21.116"; // 연결할 target(Server) IP 주소, 필자는 루프백 주소인 127.0.0.1 사용함
            int port = 3000;

            client = new TcpClient();
            client.Connect(IP, port);

            stream = client.GetStream();
            Connected = true;

            textBox1.AppendText("Connected to Server" + "\r\n");
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);

            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
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
            Connected = false;

            Reader?.Close();
            Writer?.Close();
            client?.Close();
            ReceiveThread?.Abort();
        }

        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(textBox1.AppendText);

            while (Connected)
            {
                if (stream.CanRead)
                {
                    string ReceiveData = Reader.ReadLine();
                    if (ReceiveData != null && ReceiveData.Length > 0)
                        Invoke(AddText, "You: " + ReceiveData + "\r\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Me: " + textBox2.Text + "\r\n");
            Writer.WriteLine(textBox2.Text);
            Writer.Flush();
            textBox2.Clear();
        }
    }
}
