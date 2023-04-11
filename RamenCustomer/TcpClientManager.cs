using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace RamenCustomer
{
    class TcpClientManager
    {
        TcpClient client;
        NetworkStream networkStream;

        public TcpClientManager()
        {
            Thread thread = new Thread(() => ThreadProc())
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void ThreadProc()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 2869);
                networkStream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            while (true)
            {
                try
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        byte[] buffer = new byte[client.ReceiveBufferSize];
                        int bytesRead = networkStream.Read(buffer, 0, client.ReceiveBufferSize);
                        memoryStream.Write(buffer, 0, bytesRead);
                        memoryStream.Position = 0;

                        Dictionary<string, object> receiveDataDict =
                            (Dictionary<string, object>)binaryFormatter.Deserialize(memoryStream);

                        Console.WriteLine(receiveDataDict["method"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        public void SendData(Dictionary<string, object> sendDataDict)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, sendDataDict);
            byte[] sendData = memoryStream.ToArray();

            try
            {
                networkStream.Write(sendData, 0, sendData.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
