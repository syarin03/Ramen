namespace RamenCustomer
{
    partial class FormMenuDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDetailCancel = new Sunny.UI.UIButton();
            this.BtnAddMenu = new Sunny.UI.UIButton();
            this.LabelMenuName = new Sunny.UI.UILabel();
            this.LabelMenuPrice = new Sunny.UI.UILabel();
            this.ImageMenu = new System.Windows.Forms.PictureBox();
            this.CountMenu = new Sunny.UI.UIIntegerUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDetailCancel
            // 
            this.BtnDetailCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetailCancel.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnDetailCancel.Location = new System.Drawing.Point(535, 3);
            this.BtnDetailCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnDetailCancel.Name = "BtnDetailCancel";
            this.BtnDetailCancel.Size = new System.Drawing.Size(63, 35);
            this.BtnDetailCancel.TabIndex = 0;
            this.BtnDetailCancel.Text = "X";
            this.BtnDetailCancel.Click += new System.EventHandler(this.BtnOptionRamenCancel_Click);
            // 
            // BtnAddMenu
            // 
            this.BtnAddMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnAddMenu.Location = new System.Drawing.Point(498, 162);
            this.BtnAddMenu.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddMenu.Name = "BtnAddMenu";
            this.BtnAddMenu.Size = new System.Drawing.Size(100, 35);
            this.BtnAddMenu.TabIndex = 1;
            this.BtnAddMenu.Text = "추가";
            this.BtnAddMenu.Click += new System.EventHandler(this.BtnAddMenu_Click);
            // 
            // LabelMenuName
            // 
            this.LabelMenuName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LabelMenuName.Location = new System.Drawing.Point(202, 9);
            this.LabelMenuName.Name = "LabelMenuName";
            this.LabelMenuName.Size = new System.Drawing.Size(100, 23);
            this.LabelMenuName.TabIndex = 3;
            this.LabelMenuName.Text = "메뉴 이름";
            this.LabelMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelMenuPrice
            // 
            this.LabelMenuPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LabelMenuPrice.Location = new System.Drawing.Point(202, 45);
            this.LabelMenuPrice.Name = "LabelMenuPrice";
            this.LabelMenuPrice.Size = new System.Drawing.Size(100, 23);
            this.LabelMenuPrice.TabIndex = 3;
            this.LabelMenuPrice.Text = "메뉴 가격";
            this.LabelMenuPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImageMenu
            // 
            this.ImageMenu.Location = new System.Drawing.Point(2, 3);
            this.ImageMenu.Name = "ImageMenu";
            this.ImageMenu.Size = new System.Drawing.Size(194, 194);
            this.ImageMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageMenu.TabIndex = 4;
            this.ImageMenu.TabStop = false;
            // 
            // CountMenu
            // 
            this.CountMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CountMenu.Location = new System.Drawing.Point(206, 83);
            this.CountMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountMenu.Minimum = 1;
            this.CountMenu.MinimumSize = new System.Drawing.Size(100, 0);
            this.CountMenu.Name = "CountMenu";
            this.CountMenu.ShowText = false;
            this.CountMenu.Size = new System.Drawing.Size(100, 30);
            this.CountMenu.TabIndex = 5;
            this.CountMenu.Text = "Count";
            this.CountMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountMenu.Value = 1;
            // 
            // FormMenuDetail
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.CountMenu);
            this.Controls.Add(this.ImageMenu);
            this.Controls.Add(this.LabelMenuPrice);
            this.Controls.Add(this.LabelMenuName);
            this.Controls.Add(this.BtnAddMenu);
            this.Controls.Add(this.BtnDetailCancel);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.Name = "FormMenuDetail";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FormMenuDetail";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnDetailCancel;
        private Sunny.UI.UIButton BtnAddMenu;
        private Sunny.UI.UILabel LabelMenuName;
        private Sunny.UI.UILabel LabelMenuPrice;
        private System.Windows.Forms.PictureBox ImageMenu;
        private Sunny.UI.UIIntegerUpDown CountMenu;
    }
}