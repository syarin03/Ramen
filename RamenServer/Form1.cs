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
    public partial class Form1 : Form
    {
        public Socket clientSocket;
        List<Socket> connectedClients = new List<Socket>();
        IPAddress thisAddress;

        public Form1()
        {
            InitializeComponent();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        }

        void AcceptCallback(IAsyncResult ar)
        {
            Socket client = clientSocket.EndAccept(ar);

            AsyncObject obj = new AsyncObject(4096)
            {
                WorkingSocket = client
            };

            connectedClients.Add(client);
            foreach (Socket c in connectedClients)
            {
                Console.WriteLine(c.RemoteEndPoint.ToString());
            }

            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            int received = 0;
            try
            {
                received = obj.WorkingSocket.EndReceive(ar);
            }
            catch (SocketException ex)
            {
                obj.WorkingSocket.Close();
                connectedClients.Remove(obj.WorkingSocket);
                clientSocket.BeginAccept(AcceptCallback, null);
                return;
            }
            catch (Exception ex)
            {
                obj.WorkingSocket.Close();
                connectedClients.Remove(obj.WorkingSocket);
                clientSocket.BeginAccept(AcceptCallback, null);
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

            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];

                if (socket.Handle != obj.WorkingSocket.Handle)
                {
                    socket.Send(obj.Buffer);
                }
            }

            obj.ClearBuffer();

            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            if (thisAddress == null)
                thisAddress = IPAddress.Loopback;

            IPEndPoint serverEP = new IPEndPoint(thisAddress, 3000);
            clientSocket.Bind(serverEP);
            clientSocket.Listen(10);

            clientSocket.BeginAccept(AcceptCallback, null);
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
