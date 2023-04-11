namespace RamenServer
{
    partial class FormServer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogHistory = new Sunny.UI.UIRichTextBox();
            this.BtnServerStart = new Sunny.UI.UIButton();
            this.BtnServerStop = new Sunny.UI.UIButton();
            this.BtnServerReboot = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogHistory
            // 
            this.LogHistory.FillColor = System.Drawing.Color.White;
            this.LogHistory.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogHistory.Location = new System.Drawing.Point(3, 39);
            this.LogHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogHistory.MinimumSize = new System.Drawing.Size(1, 1);
            this.LogHistory.Name = "LogHistory";
            this.LogHistory.Padding = new System.Windows.Forms.Padding(2);
            this.LogHistory.ReadOnly = true;
            this.LogHistory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogHistory.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LogHistory.ShowText = false;
            this.LogHistory.Size = new System.Drawing.Size(870, 517);
            this.LogHistory.Style = Sunny.UI.UIStyle.Custom;
            this.LogHistory.StyleCustomMode = true;
            this.LogHistory.TabIndex = 0;
            this.LogHistory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnServerStart
            // 
            this.BtnServerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServerStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStart.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStart.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnServerStart.Location = new System.Drawing.Point(3, 3);
            this.BtnServerStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnServerStart.Name = "BtnServerStart";
            this.BtnServerStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStart.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerStart.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStart.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStart.Size = new System.Drawing.Size(284, 50);
            this.BtnServerStart.Style = Sunny.UI.UIStyle.Custom;
            this.BtnServerStart.StyleCustomMode = true;
            this.BtnServerStart.TabIndex = 0;
            this.BtnServerStart.Text = "서버 가동";
            this.BtnServerStart.Click += new System.EventHandler(this.BtnServerStart_Click);
            // 
            // BtnServerStop
            // 
            this.BtnServerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServerStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerStop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStop.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnServerStop.Location = new System.Drawing.Point(293, 3);
            this.BtnServerStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnServerStop.Name = "BtnServerStop";
            this.BtnServerStop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerStop.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerStop.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStop.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerStop.Size = new System.Drawing.Size(284, 50);
            this.BtnServerStop.Style = Sunny.UI.UIStyle.Custom;
            this.BtnServerStop.StyleCustomMode = true;
            this.BtnServerStop.TabIndex = 0;
            this.BtnServerStop.Text = "서버 중지";
            this.BtnServerStop.Click += new System.EventHandler(this.BtnServerStop_Click);
            // 
            // BtnServerReboot
            // 
            this.BtnServerReboot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServerReboot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerReboot.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnServerReboot.Location = new System.Drawing.Point(583, 3);
            this.BtnServerReboot.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnServerReboot.Name = "BtnServerReboot";
            this.BtnServerReboot.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnServerReboot.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnServerReboot.Size = new System.Drawing.Size(284, 50);
            this.BtnServerReboot.Style = Sunny.UI.UIStyle.Custom;
            this.BtnServerReboot.StyleCustomMode = true;
            this.BtnServerReboot.TabIndex = 0;
            this.BtnServerReboot.Text = "서버 재가동";
            this.BtnServerReboot.Click += new System.EventHandler(this.BtnServerReboot_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnServerStart);
            this.flowLayoutPanel1.Controls.Add(this.BtnServerStop);
            this.flowLayoutPanel1.Controls.Add(this.BtnServerReboot);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 560);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 623);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LogHistory);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormServer";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Ramen Server";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 784, 561);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox LogHistory;
        private Sunny.UI.UIButton BtnServerStart;
        private Sunny.UI.UIButton BtnServerStop;
        private Sunny.UI.UIButton BtnServerReboot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

