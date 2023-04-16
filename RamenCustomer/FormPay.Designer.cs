namespace RamenCustomer
{
    partial class FormPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnPayToMain = new Sunny.UI.UIButton();
            this.menuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableMenuList = new Sunny.UI.UIDataGridView();
            this.BtnBack = new Sunny.UI.UIButton();
            this.BtnPay = new Sunny.UI.UIButton();
            this.LabelTotal = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPayToMain
            // 
            this.BtnPayToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPayToMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnPayToMain.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnPayToMain.Location = new System.Drawing.Point(3, 3);
            this.BtnPayToMain.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPayToMain.Name = "BtnPayToMain";
            this.BtnPayToMain.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnPayToMain.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPayToMain.Size = new System.Drawing.Size(100, 35);
            this.BtnPayToMain.Style = Sunny.UI.UIStyle.Custom;
            this.BtnPayToMain.StyleCustomMode = true;
            this.BtnPayToMain.TabIndex = 2;
            this.BtnPayToMain.Text = "주문 취소";
            this.BtnPayToMain.Click += new System.EventHandler(this.BtnPayToMain_Click);
            // 
            // menuPrice
            // 
            this.menuPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuPrice.HeaderText = "가격";
            this.menuPrice.Name = "menuPrice";
            this.menuPrice.ReadOnly = true;
            // 
            // menuCount
            // 
            this.menuCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuCount.HeaderText = "수량";
            this.menuCount.Name = "menuCount";
            this.menuCount.ReadOnly = true;
            // 
            // menuName
            // 
            this.menuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuName.HeaderText = "메뉴명";
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            // 
            // TableMenuList
            // 
            this.TableMenuList.AllowUserToAddRows = false;
            this.TableMenuList.AllowUserToDeleteRows = false;
            this.TableMenuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TableMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TableMenuList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TableMenuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.TableMenuList.ColumnHeadersHeight = 40;
            this.TableMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuName,
            this.menuCount,
            this.menuPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableMenuList.DefaultCellStyle = dataGridViewCellStyle8;
            this.TableMenuList.EnableHeadersVisualStyles = false;
            this.TableMenuList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TableMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.TableMenuList.Location = new System.Drawing.Point(12, 150);
            this.TableMenuList.Name = "TableMenuList";
            this.TableMenuList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMenuList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TableMenuList.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TableMenuList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TableMenuList.RowTemplate.Height = 23;
            this.TableMenuList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.TableMenuList.SelectedIndex = -1;
            this.TableMenuList.Size = new System.Drawing.Size(776, 500);
            this.TableMenuList.TabIndex = 6;
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnBack.Location = new System.Drawing.Point(12, 788);
            this.BtnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(380, 100);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "뒤로가기";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPay
            // 
            this.BtnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPay.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnPay.Location = new System.Drawing.Point(408, 788);
            this.BtnPay.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(380, 100);
            this.BtnPay.TabIndex = 7;
            this.BtnPay.Text = "결제하기";
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.Font = new System.Drawing.Font("나눔바른고딕", 20F);
            this.LabelTotal.Location = new System.Drawing.Point(12, 700);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(776, 50);
            this.LabelTotal.TabIndex = 8;
            this.LabelTotal.Text = "₩ 0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("나눔바른고딕", 20F);
            this.uiLabel1.Location = new System.Drawing.Point(12, 70);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(776, 50);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "주문 내역 확인";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPay
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TableMenuList);
            this.Controls.Add(this.BtnPayToMain);
            this.Name = "FormPay";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton BtnPayToMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        public Sunny.UI.UIDataGridView TableMenuList;
        private Sunny.UI.UIButton BtnBack;
        private Sunny.UI.UIButton BtnPay;
        public Sunny.UI.UILabel LabelTotal;
        public Sunny.UI.UILabel uiLabel1;
    }
}