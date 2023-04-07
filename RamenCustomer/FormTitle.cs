using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RamenCustomer
{
    public partial class FormTitle : Form
    {
        public Socket clientSocket;

        public FormTitle()
        {
            InitializeComponent();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

        }

        static void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            int received = 0;

            try
            {
                received = obj.WorkingSocket.EndReceive(ar);
            }
            catch (Exception)
            {
                return;
            }

            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }

            byte[] receivedBytes = new byte[received];
            Array.Copy(obj.Buffer, receivedBytes, received);

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(receivedBytes);
            Dictionary<string, object> receivedData = (Dictionary<string, object>)bf.Deserialize(ms);

            if (receivedData["method"].ToString() == "button1")
            {
                Console.WriteLine("button1");
            }

            obj.ClearBuffer();
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        private void FormTitle_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(this);
            formMain.Show();
        }

        private void FormTitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //clientSocket?.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clientSocket == null || !clientSocket.Connected)
            {
                MessageBox.Show("서버와 연결되어 있지 않습니다!");
                return;
            }

            if (!clientSocket.IsBound)
            {
                MessageBox.Show("서버가 실행되고 있지 않습니다!");
                return;
            }

            Dictionary<string, object> sendData = new Dictionary<string, object>
            {
                { "method", "button1" },
                { "price", 1500 }
            };

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, sendData);
            byte[] bytes = ms.ToArray();

            try
            {
                clientSocket.Send(bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("소켓이 폐기되었습니다! 오류 내용: " + ex.Message);
            }
        }

        private void FormTitle_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            IPAddress defaultHostAddress = null;
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    defaultHostAddress = addr;
                    break;
                }
            }

            if (defaultHostAddress == null)
                _ = IPAddress.Loopback;

            try { clientSocket.Connect(defaultHostAddress, 3000); }
            catch (Exception ex)
            {
                MessageBox.Show("연결에 실패했습니다!\n오류 내용: {0}", ex.Message);
                return;
            }

            AsyncObject obj = new AsyncObject(4096)
            {
                WorkingSocket = clientSocket
            };
            clientSocket.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
        }
    }

    public class AsyncObject
    {
        public byte[] Buffer;
        public Socket WorkingSocket;
        public readonly int BufferSize;
        public AsyncObject(int bufferSize)
        {
            BufferSize = bufferSize;
            Buffer = new byte[BufferSize];
        }

        public void ClearBuffer()
        {
            Array.Clear(Buffer, 0, BufferSize);
        }
    }
}
