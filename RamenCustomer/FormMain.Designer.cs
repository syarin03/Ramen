namespace RamenCustomer
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabMenu = new Sunny.UI.UITabControl();
            this.PageSelectRamen = new System.Windows.Forms.TabPage();
            this.LayoutSelectRamen = new System.Windows.Forms.FlowLayoutPanel();
            this.TabSelectMandu = new System.Windows.Forms.TabPage();
            this.LayoutSelectMandu = new System.Windows.Forms.FlowLayoutPanel();
            this.TabSelectRice = new System.Windows.Forms.TabPage();
            this.LayoutSelectRice = new System.Windows.Forms.FlowLayoutPanel();
            this.TabSelectDrink = new System.Windows.Forms.TabPage();
            this.LayoutSelectDrink = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMainToTitle = new Sunny.UI.UIButton();
            this.BtnOrder = new Sunny.UI.UIButton();
            this.BtnTitleToMain = new Sunny.UI.UILabel();
            this.TableMenuList = new Sunny.UI.UIDataGridView();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotal = new Sunny.UI.UILabel();
            this.TabMenu.SuspendLayout();
            this.PageSelectRamen.SuspendLayout();
            this.TabSelectMandu.SuspendLayout();
            this.TabSelectRice.SuspendLayout();
            this.TabSelectDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.PageSelectRamen);
            this.TabMenu.Controls.Add(this.TabSelectMandu);
            this.TabMenu.Controls.Add(this.TabSelectRice);
            this.TabMenu.Controls.Add(this.TabSelectDrink);
            this.TabMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabMenu.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.TabMenu.ItemSize = new System.Drawing.Size(150, 40);
            this.TabMenu.Location = new System.Drawing.Point(3, 74);
            this.TabMenu.MainPage = "";
            this.TabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TabMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(794, 709);
            this.TabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabMenu.Style = Sunny.UI.UIStyle.Custom;
            this.TabMenu.StyleCustomMode = true;
            this.TabMenu.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.TabMenu.TabIndex = 0;
            this.TabMenu.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TabMenu.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TabMenu.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TabMenu.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            // 
            // PageSelectRamen
            // 
            this.PageSelectRamen.Controls.Add(this.LayoutSelectRamen);
            this.PageSelectRamen.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.PageSelectRamen.Location = new System.Drawing.Point(0, 40);
            this.PageSelectRamen.Margin = new System.Windows.Forms.Padding(0);
            this.PageSelectRamen.Name = "PageSelectRamen";
            this.PageSelectRamen.Size = new System.Drawing.Size(794, 669);
            this.PageSelectRamen.TabIndex = 0;
            this.PageSelectRamen.Text = "라면";
            this.PageSelectRamen.UseVisualStyleBackColor = true;
            // 
            // LayoutSelectRamen
            // 
            this.LayoutSelectRamen.AutoScroll = true;
            this.LayoutSelectRamen.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutSelectRamen.Location = new System.Drawing.Point(0, 2);
            this.LayoutSelectRamen.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutSelectRamen.Name = "LayoutSelectRamen";
            this.LayoutSelectRamen.Size = new System.Drawing.Size(794, 669);
            this.LayoutSelectRamen.TabIndex = 0;
            // 
            // TabSelectMandu
            // 
            this.TabSelectMandu.Controls.Add(this.LayoutSelectMandu);
            this.TabSelectMandu.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.TabSelectMandu.Location = new System.Drawing.Point(0, 40);
            this.TabSelectMandu.Name = "TabSelectMandu";
            this.TabSelectMandu.Size = new System.Drawing.Size(200, 60);
            this.TabSelectMandu.TabIndex = 1;
            this.TabSelectMandu.Text = "만두";
            this.TabSelectMandu.UseVisualStyleBackColor = true;
            // 
            // LayoutSelectMandu
            // 
            this.LayoutSelectMandu.AutoScroll = true;
            this.LayoutSelectMandu.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutSelectMandu.Location = new System.Drawing.Point(0, 2);
            this.LayoutSelectMandu.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutSelectMandu.Name = "LayoutSelectMandu";
            this.LayoutSelectMandu.Size = new System.Drawing.Size(794, 669);
            this.LayoutSelectMandu.TabIndex = 1;
            // 
            // TabSelectRice
            // 
            this.TabSelectRice.Controls.Add(this.LayoutSelectRice);
            this.TabSelectRice.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.TabSelectRice.Location = new System.Drawing.Point(0, 40);
            this.TabSelectRice.Name = "TabSelectRice";
            this.TabSelectRice.Size = new System.Drawing.Size(200, 60);
            this.TabSelectRice.TabIndex = 2;
            this.TabSelectRice.Text = "밥";
            this.TabSelectRice.UseVisualStyleBackColor = true;
            // 
            // LayoutSelectRice
            // 
            this.LayoutSelectRice.AutoScroll = true;
            this.LayoutSelectRice.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutSelectRice.Location = new System.Drawing.Point(0, 2);
            this.LayoutSelectRice.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutSelectRice.Name = "LayoutSelectRice";
            this.LayoutSelectRice.Size = new System.Drawing.Size(794, 669);
            this.LayoutSelectRice.TabIndex = 1;
            // 
            // TabSelectDrink
            // 
            this.TabSelectDrink.Controls.Add(this.LayoutSelectDrink);
            this.TabSelectDrink.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.TabSelectDrink.Location = new System.Drawing.Point(0, 40);
            this.TabSelectDrink.Name = "TabSelectDrink";
            this.TabSelectDrink.Size = new System.Drawing.Size(200, 60);
            this.TabSelectDrink.TabIndex = 3;
            this.TabSelectDrink.Text = "음료";
            this.TabSelectDrink.UseVisualStyleBackColor = true;
            // 
            // LayoutSelectDrink
            // 
            this.LayoutSelectDrink.AutoScroll = true;
            this.LayoutSelectDrink.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutSelectDrink.Location = new System.Drawing.Point(0, 2);
            this.LayoutSelectDrink.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutSelectDrink.Name = "LayoutSelectDrink";
            this.LayoutSelectDrink.Size = new System.Drawing.Size(794, 669);
            this.LayoutSelectDrink.TabIndex = 1;
            // 
            // BtnMainToTitle
            // 
            this.BtnMainToTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMainToTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnMainToTitle.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnMainToTitle.Location = new System.Drawing.Point(3, 3);
            this.BtnMainToTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnMainToTitle.Name = "BtnMainToTitle";
            this.BtnMainToTitle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(245)))));
            this.BtnMainToTitle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMainToTitle.Size = new System.Drawing.Size(100, 35);
            this.BtnMainToTitle.Style = Sunny.UI.UIStyle.Custom;
            this.BtnMainToTitle.StyleCustomMode = true;
            this.BtnMainToTitle.TabIndex = 1;
            this.BtnMainToTitle.Text = "주문 취소";
            this.BtnMainToTitle.Click += new System.EventHandler(this.BtnMainToTitle_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrder.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.BtnOrder.Location = new System.Drawing.Point(597, 843);
            this.BtnOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(200, 45);
            this.BtnOrder.Style = Sunny.UI.UIStyle.Custom;
            this.BtnOrder.StyleCustomMode = true;
            this.BtnOrder.TabIndex = 2;
            this.BtnOrder.Text = "주문하기";
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnTitleToMain
            // 
            this.BtnTitleToMain.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnTitleToMain.Location = new System.Drawing.Point(0, 0);
            this.BtnTitleToMain.Name = "BtnTitleToMain";
            this.BtnTitleToMain.Size = new System.Drawing.Size(10, 10);
            this.BtnTitleToMain.Style = Sunny.UI.UIStyle.Custom;
            this.BtnTitleToMain.TabIndex = 4;
            this.BtnTitleToMain.Text = "아무 곳이나 클릭해주세요";
            this.BtnTitleToMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnTitleToMain.Click += new System.EventHandler(this.BtnTitleToMain_Click);
            // 
            // TableMenuList
            // 
            this.TableMenuList.AllowUserToAddRows = false;
            this.TableMenuList.AllowUserToDeleteRows = false;
            this.TableMenuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TableMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.TableMenuList.BackgroundColor = System.Drawing.Color.White;
            this.TableMenuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TableMenuList.ColumnHeadersHeight = 20;
            this.TableMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TableMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuName,
            this.menuCount,
            this.menuPrice});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableMenuList.DefaultCellStyle = dataGridViewCellStyle13;
            this.TableMenuList.EnableHeadersVisualStyles = false;
            this.TableMenuList.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TableMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.TableMenuList.Location = new System.Drawing.Point(3, 788);
            this.TableMenuList.Name = "TableMenuList";
            this.TableMenuList.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableMenuList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TableMenuList.RowHeadersWidth = 40;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.TableMenuList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TableMenuList.RowTemplate.Height = 23;
            this.TableMenuList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.TableMenuList.SelectedIndex = -1;
            this.TableMenuList.Size = new System.Drawing.Size(588, 100);
            this.TableMenuList.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TableMenuList.Style = Sunny.UI.UIStyle.Custom;
            this.TableMenuList.TabIndex = 5;
            // 
            // menuName
            // 
            this.menuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuName.HeaderText = "메뉴명";
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            // 
            // menuCount
            // 
            this.menuCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuCount.HeaderText = "수량";
            this.menuCount.Name = "menuCount";
            this.menuCount.ReadOnly = true;
            // 
            // menuPrice
            // 
            this.menuPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuPrice.HeaderText = "가격";
            this.menuPrice.Name = "menuPrice";
            this.menuPrice.ReadOnly = true;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.LabelTotal.Location = new System.Drawing.Point(597, 788);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(200, 45);
            this.LabelTotal.Style = Sunny.UI.UIStyle.Custom;
            this.LabelTotal.TabIndex = 6;
            this.LabelTotal.Text = "₩ 0";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.BtnTitleToMain);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.TableMenuList);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnMainToTitle);
            this.Controls.Add(this.TabMenu);
            this.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 784, 951);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.TabMenu.ResumeLayout(false);
            this.PageSelectRamen.ResumeLayout(false);
            this.TabSelectMandu.ResumeLayout(false);
            this.TabSelectRice.ResumeLayout(false);
            this.TabSelectDrink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage PageSelectRamen;
        private System.Windows.Forms.TabPage TabSelectMandu;
        private System.Windows.Forms.TabPage TabSelectRice;
        private System.Windows.Forms.TabPage TabSelectDrink;
        private Sunny.UI.UIButton BtnMainToTitle;
        private Sunny.UI.UIButton BtnOrder;
        public System.Windows.Forms.FlowLayoutPanel LayoutSelectRamen;
        public System.Windows.Forms.FlowLayoutPanel LayoutSelectMandu;
        public System.Windows.Forms.FlowLayoutPanel LayoutSelectRice;
        public System.Windows.Forms.FlowLayoutPanel LayoutSelectDrink;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPrice;
        public Sunny.UI.UIDataGridView TableMenuList;
        public Sunny.UI.UILabel LabelTotal;
        public Sunny.UI.UILabel BtnTitleToMain;
        public Sunny.UI.UITabControl TabMenu;
    }
}