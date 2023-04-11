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
            this.BtnOptionRamenCancel = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiImageButton2 = new Sunny.UI.UIImageButton();
            this.uiImageButton3 = new Sunny.UI.UIImageButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOptionRamenCancel
            // 
            this.BtnOptionRamenCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOptionRamenCancel.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnOptionRamenCancel.Location = new System.Drawing.Point(535, 3);
            this.BtnOptionRamenCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnOptionRamenCancel.Name = "BtnOptionRamenCancel";
            this.BtnOptionRamenCancel.Size = new System.Drawing.Size(63, 35);
            this.BtnOptionRamenCancel.TabIndex = 0;
            this.BtnOptionRamenCancel.Text = "X";
            this.BtnOptionRamenCancel.Click += new System.EventHandler(this.BtnOptionRamenCancel_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(498, 562);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "추가";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uiImageButton1);
            this.flowLayoutPanel1.Controls.Add(this.uiImageButton2);
            this.flowLayoutPanel1.Controls.Add(this.uiImageButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 512);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(13, 14);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "메뉴 이름";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiImageButton1.Location = new System.Drawing.Point(3, 3);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(186, 186);
            this.uiImageButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiImageButton1.TabIndex = 1;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "uiImageButton1";
            this.uiImageButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // uiImageButton2
            // 
            this.uiImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton2.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiImageButton2.Location = new System.Drawing.Point(195, 3);
            this.uiImageButton2.Name = "uiImageButton2";
            this.uiImageButton2.Size = new System.Drawing.Size(186, 186);
            this.uiImageButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiImageButton2.TabIndex = 1;
            this.uiImageButton2.TabStop = false;
            this.uiImageButton2.Text = "uiImageButton1";
            this.uiImageButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // uiImageButton3
            // 
            this.uiImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton3.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.uiImageButton3.Location = new System.Drawing.Point(387, 3);
            this.uiImageButton3.Name = "uiImageButton3";
            this.uiImageButton3.Size = new System.Drawing.Size(186, 186);
            this.uiImageButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiImageButton3.TabIndex = 1;
            this.uiImageButton3.TabStop = false;
            this.uiImageButton3.Text = "uiImageButton1";
            this.uiImageButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormMenuDetail
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.BtnOptionRamenCancel);
            this.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.Name = "FormMenuDetail";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "FormMenuDetail";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnOptionRamenCancel;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton uiImageButton2;
        private Sunny.UI.UIImageButton uiImageButton3;
    }
}