using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamenCustomer
{
    public partial class MenuImageButton : UserControl
    {
        public MenuImageButton()
        {
            InitializeComponent();
            InitializeClickEvent();
        }

        public string text
        {
            set
            {
                uiLabel1.Text = value;
            }
            get
            {
                return uiLabel1.Text;
            }
        }

        public Image image
        {
            set
            {
                pictureBox1.Image = value;
            }
            get
            {
                return pictureBox1.Image;
            }
        }

        public event EventHandler MenuImageClick;

        private void InitializeClickEvent()
        {
            Click += MenuImageButton_Click;
            uiLabel1.Click += MenuImageButton_Click;
            pictureBox1.Click += MenuImageButton_Click;
        }

        private void MenuImageButton_Click(object sender, EventArgs e)
        {
            MenuImageClick?.Invoke(this, e);
        }
    }
}
