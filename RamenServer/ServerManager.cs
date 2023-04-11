using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RamenServer
{
    public class ServerManager
    {
        Socket clientSocket;
        List<Socket> connectedClients = new List<Socket>();
        IPAddress thisAddress;
        int port = 3000;
        public delegate void AppendText(string str);
        bool isClosed;

        public ServerManager()
        {

        }

        public void Start()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
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

            IPEndPoint serverEP = new IPEndPoint(thisAddress, port);

            clientSocket.Bind(serverEP);
            clientSocket.Listen(10);
            clientSocket.BeginAccept(AcceptCallback, null);

            AddLog("Server Start");
            isClosed = false;
        }

        void AcceptCallback(IAsyncResult ar)
        {
            if (!isClosed)
            {
                Socket client = clientSocket.EndAccept(ar);

                AsyncObject obj = new AsyncObject(4096)
                {
                    WorkingSocket = client
                };

                connectedClients.Add(client);
                foreach (Socket c in connectedClients)
                {
                    AddLog($"Client \"{c.RemoteEndPoint}\" Connect");
                }

                client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
            }
        }

        void DataReceived(IAsyncResult ar)
        {
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            int received = 0;

            try
            {
                received = obj.WorkingSocket.EndReceive(ar);
            }
            catch (SocketException)
            {
                AddLog($"Client \"{obj.WorkingSocket.RemoteEndPoint}\" Disconnect");
                obj.WorkingSocket.Close();
                connectedClients.Remove(obj.WorkingSocket);
                clientSocket.BeginAccept(AcceptCallback, null);
                return;
            }
            catch (Exception)
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
            AddLog($"Client Send \"{receivedData["method"]}\" Method");

            //if (receivedData["method"].ToString() == "button1")
            //{
                
            //}

            foreach (Socket s in connectedClients)
            {
                if (s.Handle != obj.WorkingSocket.Handle)
                {
                    s.Send(obj.Buffer);
                    AddLog($"Server Send \"{obj.Buffer}\"");
                }
            }

            obj.ClearBuffer();

            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        public void Stop()
        {
            isClosed = true;
            clientSocket?.Close();
            clientSocket?.Dispose();
            AddLog("Server Close");
        }

        public void Reboot()
        {
            Stop();
            Start();
        }

        public static event AppendText AT;

        public static void AddLog(string log)
        {
            AT(log);
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
