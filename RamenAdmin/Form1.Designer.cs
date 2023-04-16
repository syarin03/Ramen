namespace RamenAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabManage = new Sunny.UI.UITabControl();
            this.PageStock = new System.Windows.Forms.TabPage();
            this.PageSales = new System.Windows.Forms.TabPage();
            this.LayoutStock = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutSales = new System.Windows.Forms.FlowLayoutPanel();
            this.TableMenuList = new Sunny.UI.UIDataGridView();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.BtnAddStock = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRefresh = new Sunny.UI.UIButton();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStockMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockMenuStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesOrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesMenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesMenuCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabManage.SuspendLayout();
            this.PageStock.SuspendLayout();
            this.PageSales.SuspendLayout();
            this.LayoutStock.SuspendLayout();
            this.LayoutSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabManage
            // 
            this.TabManage.Controls.Add(this.PageStock);
            this.TabManage.Controls.Add(this.PageSales);
            this.TabManage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabManage.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.TabManage.ItemSize = new System.Drawing.Size(150, 40);
            this.TabManage.Location = new System.Drawing.Point(3, 40);
            this.TabManage.MainPage = "";
            this.TabManage.Margin = new System.Windows.Forms.Padding(0);
            this.TabManage.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.TabManage.Name = "TabManage";
            this.TabManage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabManage.SelectedIndex = 0;
            this.TabManage.Size = new System.Drawing.Size(794, 709);
            this.TabManage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabManage.Style = Sunny.UI.UIStyle.Custom;
            this.TabManage.StyleCustomMode = true;
            this.TabManage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.TabManage.TabIndex = 1;
            this.TabManage.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TabManage.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TabManage.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TabManage.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            // 
            // PageStock
            // 
            this.PageStock.Controls.Add(this.LayoutStock);
            this.PageStock.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.PageStock.Location = new System.Drawing.Point(0, 40);
            this.PageStock.Margin = new System.Windows.Forms.Padding(0);
            this.PageStock.Name = "PageStock";
            this.PageStock.Size = new System.Drawing.Size(794, 669);
            this.PageStock.TabIndex = 0;
            this.PageStock.Text = "재고 관리";
            this.PageStock.UseVisualStyleBackColor = true;
            // 
            // PageSales
            // 
            this.PageSales.Controls.Add(this.LayoutSales);
            this.PageSales.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.PageSales.Location = new System.Drawing.Point(0, 40);
            this.PageSales.Name = "PageSales";
            this.PageSales.Size = new System.Drawing.Size(794, 669);
            this.PageSales.TabIndex = 1;
            this.PageSales.Text = "주문 내역 / 매출";
            this.PageSales.UseVisualStyleBackColor = true;
            // 
            // LayoutStock
            // 
            this.LayoutStock.AutoScroll = true;
            this.LayoutStock.Controls.Add(this.uiDataGridView1);
            this.LayoutStock.Controls.Add(this.flowLayoutPanel1);
            this.LayoutStock.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutStock.Location = new System.Drawing.Point(0, 2);
            this.LayoutStock.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutStock.Name = "LayoutStock";
            this.LayoutStock.Size = new System.Drawing.Size(794, 669);
            this.LayoutStock.TabIndex = 1;
            // 
            // LayoutSales
            // 
            this.LayoutSales.AutoScroll = true;
            this.LayoutSales.Controls.Add(this.TableMenuList);
            this.LayoutSales.Font = new System.Drawing.Font("나눔바른고딕", 12F);
            this.LayoutSales.Location = new System.Drawing.Point(0, 2);
            this.LayoutSales.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutSales.Name = "LayoutSales";
            this.LayoutSales.Size = new System.Drawing.Size(794, 669);
            this.LayoutSales.TabIndex = 2;
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
            this.colSalesOrderNum,
            this.colSalesMenuName,
            this.colSalesMenuCount,
            this.price});
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
            this.TableMenuList.Location = new System.Drawing.Point(3, 3);
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
            this.TableMenuList.Size = new System.Drawing.Size(788, 500);
            this.TableMenuList.TabIndex = 7;
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            this.uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 40;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.colStockMenuName,
            this.colStockMenuStock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(788, 500);
            this.uiDataGridView1.TabIndex = 7;
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnAddStock.Location = new System.Drawing.Point(659, 3);
            this.BtnAddStock.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(126, 35);
            this.BtnAddStock.TabIndex = 8;
            this.BtnAddStock.Text = "재고추가(+10)";
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnAddStock);
            this.flowLayoutPanel1.Controls.Add(this.BtnRefresh);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 509);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 100);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.BtnRefresh.Location = new System.Drawing.Point(553, 3);
            this.BtnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(100, 35);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "새로고침";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.select.HeaderText = "";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.Width = 5;
            // 
            // colStockMenuName
            // 
            this.colStockMenuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockMenuName.HeaderText = "메뉴명";
            this.colStockMenuName.Name = "colStockMenuName";
            this.colStockMenuName.ReadOnly = true;
            this.colStockMenuName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStockMenuStock
            // 
            this.colStockMenuStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStockMenuStock.HeaderText = "재고";
            this.colStockMenuStock.Name = "colStockMenuStock";
            this.colStockMenuStock.ReadOnly = true;
            this.colStockMenuStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSalesOrderNum
            // 
            this.colSalesOrderNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSalesOrderNum.HeaderText = "주문 번호";
            this.colSalesOrderNum.Name = "colSalesOrderNum";
            this.colSalesOrderNum.ReadOnly = true;
            // 
            // colSalesMenuName
            // 
            this.colSalesMenuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSalesMenuName.HeaderText = "메뉴명";
            this.colSalesMenuName.Name = "colSalesMenuName";
            this.colSalesMenuName.ReadOnly = true;
            // 
            // colSalesMenuCount
            // 
            this.colSalesMenuCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSalesMenuCount.HeaderText = "수량";
            this.colSalesMenuCount.Name = "colSalesMenuCount";
            this.colSalesMenuCount.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "가격";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.TabManage);
            this.Name = "Form1";
            this.Text = "관리";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 784, 761);
            this.TabManage.ResumeLayout(false);
            this.PageStock.ResumeLayout(false);
            this.PageSales.ResumeLayout(false);
            this.LayoutStock.ResumeLayout(false);
            this.LayoutSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Sunny.UI.UITabControl TabManage;
        private System.Windows.Forms.TabPage PageStock;
        private System.Windows.Forms.TabPage PageSales;
        public System.Windows.Forms.FlowLayoutPanel LayoutStock;
        public System.Windows.Forms.FlowLayoutPanel LayoutSales;
        public Sunny.UI.UIDataGridView TableMenuList;
        public Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIButton BtnAddStock;
        private Sunny.UI.UIButton BtnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMenuStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesOrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesMenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesMenuCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

