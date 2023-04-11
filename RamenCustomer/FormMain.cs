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
using Sunny.UI;

namespace RamenCustomer
{
    public partial class FormMain : UIForm
    {
        TcpClientManager clientManager;
        FormTitle formTitle;

        public FormMain(FormTitle form, object tcm)
        {
            InitializeComponent();
            formTitle = form;
            formTitle.Hide();
            clientManager = (TcpClientManager)tcm;
            Dictionary<string, object> d = new Dictionary<string, object>
            {
                { "method", "FormMainLoad" }
            };
            clientManager.SendData(d);

            //TabMenu.ItemSize = new Size((TabMenu.Width / TabMenu.TabPages.Count) - 1, TabMenu.ItemSize.Height);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formTitle.Show();
        }

        private void BtnMainToTitle_Click(object sender, EventArgs e)
        {
            Close();
            formTitle.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            UIImageButton btn = new UIImageButton
            {
                Size = new Size(258, 258),
                Parent = this,
                Name = "newbtn",
                Text = "newbtn",
                TextAlign = ContentAlignment.BottomCenter,
                Image = Image.FromFile(@"C:\Users\user\Downloads\image.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            btn.Click += SelectRamen;
            LayoutSelectRamen.Controls.Add(btn);
        }

        private void SelectRamen(object sender, EventArgs e)
        {
            UIImageButton btn = (UIImageButton)sender;
            FormMenuDetail formMenuDetail = new FormMenuDetail(btn.Text);
            formMenuDetail.Show();
        }
    }
}
