namespace RamenCustomer
{
    partial class FormTitle
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
            this.BtnTitleToMain = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // BtnTitleToMain
            // 
            this.BtnTitleToMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnTitleToMain.Location = new System.Drawing.Point(0, 0);
            this.BtnTitleToMain.Name = "BtnTitleToMain";
            this.BtnTitleToMain.Size = new System.Drawing.Size(800, 900);
            this.BtnTitleToMain.Style = Sunny.UI.UIStyle.Custom;
            this.BtnTitleToMain.TabIndex = 0;
            this.BtnTitleToMain.Text = "아무 곳이나 클릭해주세요";
            this.BtnTitleToMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnTitleToMain.Click += new System.EventHandler(this.BtnTitleToMain_Click);
            // 
            // FormTitle
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.ControlBox = false;
            this.Controls.Add(this.BtnTitleToMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTitle";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 784, 761);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTitle_FormClosing);
            this.Load += new System.EventHandler(this.FormTitle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel BtnTitleToMain;
    }
}

