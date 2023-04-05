namespace RamenServer
{
    partial class Form1
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
            this.myConsole = new System.Windows.Forms.RichTextBox();
            this.ControllInput = new System.Windows.Forms.TextBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(13, 13);
            this.myConsole.Name = "myConsole";
            this.myConsole.Size = new System.Drawing.Size(649, 343);
            this.myConsole.TabIndex = 0;
            this.myConsole.Text = "";
            // 
            // ControllInput
            // 
            this.ControllInput.Location = new System.Drawing.Point(13, 417);
            this.ControllInput.Name = "ControllInput";
            this.ControllInput.Size = new System.Drawing.Size(649, 21);
            this.ControllInput.TabIndex = 1;
            this.ControllInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControllInput_KeyDown);
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 12;
            this.ClientList.Location = new System.Drawing.Point(668, 12);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(120, 88);
            this.ClientList.TabIndex = 2;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(668, 415);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(120, 23);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "button1";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.ControllInput);
            this.Controls.Add(this.myConsole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox myConsole;
        private System.Windows.Forms.TextBox ControllInput;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Button Enter;
    }
}

