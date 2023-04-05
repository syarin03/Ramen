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

namespace RamenServer
{
    public partial class Form1 : Form
    {
        public string bufferedList;
        public List<string> users = new List<string>();
        TcpListener server;

        public void AddText(string text)
        {
            myConsole.AppendText(text);
            myConsole.Select(myConsole.Text.Length, 0);
            myConsole.ScrollToCaret();
        }

        void ControlEnter(object sender, EventArgs e)
        {
            string input = ControllInput.Text;
            Controller(input);
            ControllInput.Text = string.Empty;
            ControllInput.Focus();
        }

        void RefreshChatters()
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                bufferedList = "**userlist** ";
                ClientList.Items.Clear();
                foreach (string user in users)
                {
                    ClientList.Items.Add(user);
                    bufferedList += (user + " ");
                }
                Thread.Sleep(1000);
            }
        }
        void OpenServer(object s)
        {
            string serverIP = s.ToString().Substring("/open ".Length);
            TcpClient client = new TcpClient();
            const int Port = 10203;
            IPEndPoint serverAddr = new IPEndPoint(IPAddress.Parse(serverIP), Port);
            server = new TcpListener(serverAddr);

            try
            {
                server.Start();
            }
            catch (SocketException e)
            {
                MessageBox.Show("올바르지 않은 주소입니다.");
                return;
            }

            AddText(String.Format("Server Opened. [{0}]\r\n", serverAddr.ToString()));
            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userID = Encoding.Default.GetString(buffer, 0, bytes);
                    users.Add(userID);
                    MyChatServer mychat = new MyChatServer(client, userID, this);
                    Thread serverThread = new Thread(new ThreadStart(mychat.Listen));
                    serverThread.IsBackground = true;
                    serverThread.Start();
                }
                catch (Exception e) { break; }
            }
            client.Close();
            server.Stop();
        }

        void CloseServer()
        {
            // 서버 닫는 처리
        }

        void Controller(string s)
        {
            if (s.Equals(string.Empty)) return;
            else if (s.Equals("/close"))
            {
                CloseServer();
                AddText("[Server] Closed.\r\n");
            }
            else if (s.StartsWith("/open "))
            {
                Thread open = new Thread(OpenServer);
                open.IsBackground = true;
                open.Start(s);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread refresher = new Thread(RefreshChatters);
            refresher.IsBackground = true;
            refresher.Start();
        }

        private void Listen()
        {
            AddTextDelegate addText = new AddTextDelegate(ControllInput.AppendText);

            IPAddress addr = IPAddress.Parse("127.0.0.1");
            int port = 3000;
            server = new TcpListener(addr, port);
            server.Start();

            Invoke(addText, "Server Start\r\n");

            client = server.AcceptTcpClient();
            Connected = true;

            Invoke(addText, "Connected to Client\r\n");

            stream = client.GetStream();
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);

            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
        }

        private void Receive()
        {
            AddTextDelegate AddText = new AddTextDelegate(ControllInput.AppendText);

            while (Connected)
            {
                // stream에 data 있을 경우 
                if (stream.CanRead)
                {
                    string receiveChat = Reader.ReadLine();
                    if (receiveChat != null && receiveChat.Length > 0)
                        Invoke(AddText, "You: " + receiveChat + "\r\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //char room에 sender message 추가
            ControllInput.AppendText("Me: " + textBox2.Text + "\r\n");

            //Client에 chat send
            Writer.WriteLine(textBox2.Text);
            Writer.Flush();

            textBox2.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            Reader?.Close();
            Writer?.Close();
            server?.Stop();
            client?.Close();
            ReceiveThread?.Abort();
        }

        private void ControllInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) ControlEnter(sender, e);
        }
    }
}
