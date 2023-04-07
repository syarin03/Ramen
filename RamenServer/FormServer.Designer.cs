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
            this.LogHistory = new System.Windows.Forms.RichTextBox();
            this.BtnServerStart = new System.Windows.Forms.Button();
            this.BtnServerStop = new System.Windows.Forms.Button();
            this.BtnServerReboot = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogHistory
            // 
            this.LogHistory.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LogHistory.Location = new System.Drawing.Point(12, 13);
            this.LogHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogHistory.Name = "LogHistory";
            this.LogHistory.ReadOnly = true;
            this.LogHistory.Size = new System.Drawing.Size(760, 467);
            this.LogHistory.TabIndex = 0;
            this.LogHistory.Text = "";
            // 
            // BtnServerStart
            // 
            this.BtnServerStart.AutoSize = true;
            this.BtnServerStart.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnServerStart.Location = new System.Drawing.Point(3, 4);
            this.BtnServerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServerStart.Name = "BtnServerStart";
            this.BtnServerStart.Size = new System.Drawing.Size(247, 50);
            this.BtnServerStart.TabIndex = 1;
            this.BtnServerStart.Text = "서버 가동";
            this.BtnServerStart.UseVisualStyleBackColor = true;
            this.BtnServerStart.Click += new System.EventHandler(this.BtnServerStart_Click);
            // 
            // BtnServerStop
            // 
            this.BtnServerStop.AutoSize = true;
            this.BtnServerStop.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnServerStop.Location = new System.Drawing.Point(256, 4);
            this.BtnServerStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServerStop.Name = "BtnServerStop";
            this.BtnServerStop.Size = new System.Drawing.Size(247, 50);
            this.BtnServerStop.TabIndex = 2;
            this.BtnServerStop.Text = "서버 중단";
            this.BtnServerStop.UseVisualStyleBackColor = true;
            this.BtnServerStop.Click += new System.EventHandler(this.BtnServerStop_Click);
            // 
            // BtnServerReboot
            // 
            this.BtnServerReboot.AutoSize = true;
            this.BtnServerReboot.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnServerReboot.Location = new System.Drawing.Point(509, 4);
            this.BtnServerReboot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnServerReboot.Name = "BtnServerReboot";
            this.BtnServerReboot.Size = new System.Drawing.Size(247, 50);
            this.BtnServerReboot.TabIndex = 3;
            this.BtnServerReboot.Text = "서버 재가동";
            this.BtnServerReboot.UseVisualStyleBackColor = true;
            this.BtnServerReboot.Click += new System.EventHandler(this.BtnServerReboot_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.BtnServerStart);
            this.flowLayoutPanel1.Controls.Add(this.BtnServerStop);
            this.flowLayoutPanel1.Controls.Add(this.BtnServerReboot);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 488);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 60);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LogHistory);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormServer";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogHistory;
        private System.Windows.Forms.Button BtnServerStart;
        private System.Windows.Forms.Button BtnServerStop;
        private System.Windows.Forms.Button BtnServerReboot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

