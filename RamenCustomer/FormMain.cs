using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamenCustomer
{
    public partial class FormMain : Form
    {
        readonly Socket clientSocket;
        readonly FormTitle formTitle;

        public FormMain(FormTitle form)
        {
            InitializeComponent();
            formTitle = form;
            formTitle.Hide();
            clientSocket = form.clientSocket;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formTitle.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> sendData = new Dictionary<string, object>
            {
                { "method", "FormMain_Load" },
                { "price", 1500 }
            };

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, sendData);
            byte[] bytes = ms.ToArray();

            clientSocket.Send(bytes);
        }
    }
}
