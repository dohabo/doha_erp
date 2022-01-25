
namespace clutch_MES.UI.MainFucntion
{
    partial class PurchaseUI
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_purchaseStauts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedPurchaseListView = new System.Windows.Forms.ListView();
            this.list_purchaseEnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_purchaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_purchaseInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_etc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.searchPurchase = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.dpicPurchaseAddTo = new Sunny.UI.UIDatePicker();
            this.searchSupplier = new Sunny.UI.UISymbolButton();
            this.dpicPurchaseAddFrom = new Sunny.UI.UIDatePicker();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.dpicPurchaseInTo = new Sunny.UI.UIDatePicker();
            this.cbboxStatus = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.searchPurchaser = new Sunny.UI.UISymbolButton();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.dpicPurchaseInFrom = new Sunny.UI.UIDatePicker();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.tboxSupplier = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tboxItemCode = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tboxPurchaser = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tboxCompanyNum = new Sunny.UI.UITextBox();
            this.addPurchase = new Sunny.UI.UIButton();
            this.addPurchaseGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tboxSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPurchaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // list_purchaseStauts
            // 
            this.list_purchaseStauts.Text = "상태";
            this.list_purchaseStauts.Width = 80;
            // 
            // list_company
            // 
            this.list_company.Text = "사업장";
            this.list_company.Width = 100;
            // 
            // purchaseNum
            // 
            this.purchaseNum.Text = "구매 등록 번호";
            this.purchaseNum.Width = 120;
            // 
            // addedPurchaseListView
            // 
            this.addedPurchaseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.purchaseNum,
            this.list_company,
            this.list_purchaseEnt,
            this.list_purchaseStauts,
            this.list_Item,
            this.list_Quantity,
            this.list_purchaseDate,
            this.list_purchaseInDate,
            this.list_etc});
            this.addedPurchaseListView.GridLines = true;
            this.addedPurchaseListView.HideSelection = false;
            this.addedPurchaseListView.Location = new System.Drawing.Point(7, 224);
            this.addedPurchaseListView.Name = "addedPurchaseListView";
            this.addedPurchaseListView.Size = new System.Drawing.Size(1140, 231);
            this.addedPurchaseListView.TabIndex = 37;
            this.addedPurchaseListView.UseCompatibleStateImageBehavior = false;
            this.addedPurchaseListView.View = System.Windows.Forms.View.Details;
            this.addedPurchaseListView.SelectedIndexChanged += new System.EventHandler(this.addedWorkListView_SelectedIndexChanged);
            // 
            // list_purchaseEnt
            // 
            this.list_purchaseEnt.Text = "거래처";
            this.list_purchaseEnt.Width = 100;
            // 
            // list_Item
            // 
            this.list_Item.Text = "품목";
            this.list_Item.Width = 100;
            // 
            // list_Quantity
            // 
            this.list_Quantity.Text = "수량";
            this.list_Quantity.Width = 80;
            // 
            // list_purchaseDate
            // 
            this.list_purchaseDate.Text = "구매등록일";
            this.list_purchaseDate.Width = 120;
            // 
            // list_purchaseInDate
            // 
            this.list_purchaseInDate.Text = "구매 입고 요구일";
            this.list_purchaseInDate.Width = 180;
            // 
            // list_etc
            // 
            this.list_etc.Text = "특이사항";
            this.list_etc.Width = 150;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(6, 495);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel2.TabIndex = 42;
            this.uiMarkLabel2.Text = "구매 등록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPurchase
            // 
            this.searchPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPurchase.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchPurchase.Location = new System.Drawing.Point(3, 7);
            this.searchPurchase.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchPurchase.Name = "searchPurchase";
            this.searchPurchase.Size = new System.Drawing.Size(60, 60);
            this.searchPurchase.Symbol = 61442;
            this.searchPurchase.SymbolSize = 30;
            this.searchPurchase.TabIndex = 40;
            this.searchPurchase.Click += new System.EventHandler(this.searchPurchase_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 198);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel1.TabIndex = 41;
            this.uiMarkLabel1.Text = "구매 등록 내역";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 38;
            this.uiLabel1.Text = "구매 관리";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.uiLabel8);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.dpicPurchaseAddTo);
            this.panel1.Controls.Add(this.searchSupplier);
            this.panel1.Controls.Add(this.dpicPurchaseAddFrom);
            this.panel1.Controls.Add(this.uiLabel10);
            this.panel1.Controls.Add(this.dpicPurchaseInTo);
            this.panel1.Controls.Add(this.cbboxStatus);
            this.panel1.Controls.Add(this.uiLabel9);
            this.panel1.Controls.Add(this.searchPurchaser);
            this.panel1.Controls.Add(this.searchCompany);
            this.panel1.Controls.Add(this.dpicPurchaseInFrom);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.tboxSupplier);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.tboxItemCode);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.tboxPurchaser);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.tboxCompanyNum);
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 125);
            this.panel1.TabIndex = 44;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(955, 2);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(21, 35);
            this.uiLabel8.TabIndex = 30;
            this.uiLabel8.Text = "-";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(636, 4);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(154, 35);
            this.uiLabel3.TabIndex = 29;
            this.uiLabel3.Text = "구매 등록 일자";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpicPurchaseAddTo
            // 
            this.dpicPurchaseAddTo.FillColor = System.Drawing.Color.White;
            this.dpicPurchaseAddTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicPurchaseAddTo.Location = new System.Drawing.Point(977, 3);
            this.dpicPurchaseAddTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicPurchaseAddTo.MaxLength = 10;
            this.dpicPurchaseAddTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicPurchaseAddTo.Name = "dpicPurchaseAddTo";
            this.dpicPurchaseAddTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicPurchaseAddTo.Size = new System.Drawing.Size(161, 34);
            this.dpicPurchaseAddTo.SymbolDropDown = 61555;
            this.dpicPurchaseAddTo.SymbolNormal = 61555;
            this.dpicPurchaseAddTo.TabIndex = 29;
            this.dpicPurchaseAddTo.Text = "2021-08-11";
            this.dpicPurchaseAddTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicPurchaseAddTo.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // searchSupplier
            // 
            this.searchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchSupplier.Location = new System.Drawing.Point(225, 85);
            this.searchSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(34, 35);
            this.searchSupplier.Symbol = 61442;
            this.searchSupplier.TabIndex = 28;
            this.searchSupplier.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // dpicPurchaseAddFrom
            // 
            this.dpicPurchaseAddFrom.FillColor = System.Drawing.Color.White;
            this.dpicPurchaseAddFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicPurchaseAddFrom.Location = new System.Drawing.Point(797, 3);
            this.dpicPurchaseAddFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicPurchaseAddFrom.MaxLength = 10;
            this.dpicPurchaseAddFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicPurchaseAddFrom.Name = "dpicPurchaseAddFrom";
            this.dpicPurchaseAddFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicPurchaseAddFrom.Size = new System.Drawing.Size(161, 34);
            this.dpicPurchaseAddFrom.SymbolDropDown = 61555;
            this.dpicPurchaseAddFrom.SymbolNormal = 61555;
            this.dpicPurchaseAddFrom.TabIndex = 28;
            this.dpicPurchaseAddFrom.Text = "1988-01-01";
            this.dpicPurchaseAddFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicPurchaseAddFrom.Value = new System.DateTime(1988, 1, 1, 0, 0, 0, 0);
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(955, 43);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(21, 35);
            this.uiLabel10.TabIndex = 27;
            this.uiLabel10.Text = "-";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpicPurchaseInTo
            // 
            this.dpicPurchaseInTo.FillColor = System.Drawing.Color.White;
            this.dpicPurchaseInTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicPurchaseInTo.Location = new System.Drawing.Point(977, 44);
            this.dpicPurchaseInTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicPurchaseInTo.MaxLength = 10;
            this.dpicPurchaseInTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicPurchaseInTo.Name = "dpicPurchaseInTo";
            this.dpicPurchaseInTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicPurchaseInTo.Size = new System.Drawing.Size(161, 34);
            this.dpicPurchaseInTo.SymbolDropDown = 61555;
            this.dpicPurchaseInTo.SymbolNormal = 61555;
            this.dpicPurchaseInTo.TabIndex = 22;
            this.dpicPurchaseInTo.Text = "2021-08-11";
            this.dpicPurchaseInTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicPurchaseInTo.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // cbboxStatus
            // 
            this.cbboxStatus.DataSource = null;
            this.cbboxStatus.FillColor = System.Drawing.Color.White;
            this.cbboxStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbboxStatus.Items.AddRange(new object[] {
            "전체",
            "발주완료",
            "입고완료"});
            this.cbboxStatus.Location = new System.Drawing.Point(469, 45);
            this.cbboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxStatus.Name = "cbboxStatus";
            this.cbboxStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxStatus.Size = new System.Drawing.Size(102, 36);
            this.cbboxStatus.TabIndex = 26;
            this.cbboxStatus.Text = "전체";
            this.cbboxStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(356, 44);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(106, 35);
            this.uiLabel9.TabIndex = 25;
            this.uiLabel9.Text = "상태";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPurchaser
            // 
            this.searchPurchaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPurchaser.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchPurchaser.Location = new System.Drawing.Point(577, 5);
            this.searchPurchaser.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchPurchaser.Name = "searchPurchaser";
            this.searchPurchaser.Size = new System.Drawing.Size(34, 35);
            this.searchPurchaser.Symbol = 61442;
            this.searchPurchaser.TabIndex = 23;
            this.searchPurchaser.Click += new System.EventHandler(this.searchPurchaser_Click);
            // 
            // searchCompany
            // 
            this.searchCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCompany.Location = new System.Drawing.Point(225, 4);
            this.searchCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCompany.Name = "searchCompany";
            this.searchCompany.Size = new System.Drawing.Size(34, 35);
            this.searchCompany.Symbol = 61442;
            this.searchCompany.TabIndex = 22;
            this.searchCompany.Click += new System.EventHandler(this.searchCompany_Click);
            // 
            // dpicPurchaseInFrom
            // 
            this.dpicPurchaseInFrom.FillColor = System.Drawing.Color.White;
            this.dpicPurchaseInFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicPurchaseInFrom.Location = new System.Drawing.Point(797, 44);
            this.dpicPurchaseInFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicPurchaseInFrom.MaxLength = 10;
            this.dpicPurchaseInFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicPurchaseInFrom.Name = "dpicPurchaseInFrom";
            this.dpicPurchaseInFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicPurchaseInFrom.Size = new System.Drawing.Size(161, 34);
            this.dpicPurchaseInFrom.SymbolDropDown = 61555;
            this.dpicPurchaseInFrom.SymbolNormal = 61555;
            this.dpicPurchaseInFrom.TabIndex = 21;
            this.dpicPurchaseInFrom.Text = "1988-01-01";
            this.dpicPurchaseInFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicPurchaseInFrom.Value = new System.DateTime(1988, 1, 1, 0, 0, 0, 0);
            // 
            // searchItem
            // 
            this.searchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchItem.Location = new System.Drawing.Point(225, 45);
            this.searchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(34, 35);
            this.searchItem.Symbol = 61442;
            this.searchItem.TabIndex = 20;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(3, 86);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(106, 35);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "거래처";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxSupplier
            // 
            this.tboxSupplier.Controls.Add(this.uiTextBox1);
            this.tboxSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxSupplier.FillColor = System.Drawing.Color.White;
            this.tboxSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxSupplier.Location = new System.Drawing.Point(116, 85);
            this.tboxSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxSupplier.Maximum = 2147483647D;
            this.tboxSupplier.Minimum = -2147483648D;
            this.tboxSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxSupplier.Name = "tboxSupplier";
            this.tboxSupplier.Size = new System.Drawing.Size(102, 36);
            this.tboxSupplier.TabIndex = 14;
            this.tboxSupplier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(181, 3);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(161, 36);
            this.uiTextBox1.TabIndex = 26;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(3, 45);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(106, 35);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "품목";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxItemCode
            // 
            this.tboxItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxItemCode.FillColor = System.Drawing.Color.White;
            this.tboxItemCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxItemCode.Location = new System.Drawing.Point(116, 44);
            this.tboxItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxItemCode.Maximum = 2147483647D;
            this.tboxItemCode.Minimum = -2147483648D;
            this.tboxItemCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxItemCode.Name = "tboxItemCode";
            this.tboxItemCode.Size = new System.Drawing.Size(102, 36);
            this.tboxItemCode.TabIndex = 12;
            this.tboxItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(636, 45);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(154, 35);
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "구매 입고 요구 일자";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(356, 5);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(106, 35);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "담당자";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxPurchaser
            // 
            this.tboxPurchaser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPurchaser.FillColor = System.Drawing.Color.White;
            this.tboxPurchaser.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxPurchaser.Location = new System.Drawing.Point(468, 5);
            this.tboxPurchaser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPurchaser.Maximum = 2147483647D;
            this.tboxPurchaser.Minimum = -2147483648D;
            this.tboxPurchaser.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxPurchaser.Name = "tboxPurchaser";
            this.tboxPurchaser.Size = new System.Drawing.Size(103, 36);
            this.tboxPurchaser.TabIndex = 8;
            this.tboxPurchaser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(3, 3);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(106, 35);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "사업장";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxCompanyNum
            // 
            this.tboxCompanyNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxCompanyNum.FillColor = System.Drawing.Color.White;
            this.tboxCompanyNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxCompanyNum.Location = new System.Drawing.Point(115, 3);
            this.tboxCompanyNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxCompanyNum.Maximum = 2147483647D;
            this.tboxCompanyNum.Minimum = -2147483648D;
            this.tboxCompanyNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxCompanyNum.Name = "tboxCompanyNum";
            this.tboxCompanyNum.Size = new System.Drawing.Size(103, 36);
            this.tboxCompanyNum.TabIndex = 4;
            this.tboxCompanyNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addPurchase
            // 
            this.addPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPurchase.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addPurchase.Location = new System.Drawing.Point(1029, 478);
            this.addPurchase.MinimumSize = new System.Drawing.Size(1, 1);
            this.addPurchase.Name = "addPurchase";
            this.addPurchase.Size = new System.Drawing.Size(121, 40);
            this.addPurchase.TabIndex = 46;
            this.addPurchase.Text = "등록";
            this.addPurchase.Click += new System.EventHandler(this.addPurchase_Click);
            // 
            // addPurchaseGridView
            // 
            this.addPurchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPurchaseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.purchaseEnt,
            this.purchaseItem,
            this.purchaseQuantity,
            this.puchaseDate,
            this.purchaseInDate,
            this.purchaser,
            this.dataGridViewTextBoxColumn2});
            this.addPurchaseGridView.Location = new System.Drawing.Point(10, 521);
            this.addPurchaseGridView.Name = "addPurchaseGridView";
            this.addPurchaseGridView.RowTemplate.Height = 23;
            this.addPurchaseGridView.Size = new System.Drawing.Size(1137, 217);
            this.addPurchaseGridView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "사업장";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // purchaseEnt
            // 
            this.purchaseEnt.HeaderText = "거래처";
            this.purchaseEnt.Name = "purchaseEnt";
            // 
            // purchaseItem
            // 
            this.purchaseItem.HeaderText = "품목";
            this.purchaseItem.Name = "purchaseItem";
            // 
            // purchaseQuantity
            // 
            this.purchaseQuantity.HeaderText = "수량";
            this.purchaseQuantity.Name = "purchaseQuantity";
            this.purchaseQuantity.Width = 80;
            // 
            // puchaseDate
            // 
            this.puchaseDate.HeaderText = "구매일";
            this.puchaseDate.Name = "puchaseDate";
            this.puchaseDate.Width = 120;
            // 
            // purchaseInDate
            // 
            this.purchaseInDate.HeaderText = "구매입고요구일";
            this.purchaseInDate.Name = "purchaseInDate";
            this.purchaseInDate.Width = 160;
            // 
            // purchaser
            // 
            this.purchaser.HeaderText = "담당자";
            this.purchaser.Name = "purchaser";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "특이사항";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 195;
            // 
            // PurchaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPurchase);
            this.Controls.Add(this.addPurchaseGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addedPurchaseListView);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.searchPurchase);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "PurchaseUI";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.PurchaseUI_Load);
            this.panel1.ResumeLayout(false);
            this.tboxSupplier.ResumeLayout(false);
            this.tboxSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPurchaseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader list_purchaseStauts;
        private System.Windows.Forms.ColumnHeader list_company;
        private System.Windows.Forms.ColumnHeader purchaseNum;
        private System.Windows.Forms.ListView addedPurchaseListView;
        private System.Windows.Forms.ColumnHeader list_purchaseEnt;
        private System.Windows.Forms.ColumnHeader list_Item;
        private System.Windows.Forms.ColumnHeader list_Quantity;
        private System.Windows.Forms.ColumnHeader list_purchaseDate;
        private System.Windows.Forms.ColumnHeader list_purchaseInDate;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UISymbolButton searchPurchase;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIDatePicker dpicPurchaseInTo;
        private Sunny.UI.UIComboBox cbboxStatus;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UISymbolButton searchPurchaser;
        private Sunny.UI.UISymbolButton searchCompany;
        private Sunny.UI.UIDatePicker dpicPurchaseInFrom;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox tboxSupplier;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tboxItemCode;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox tboxPurchaser;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tboxCompanyNum;
        private Sunny.UI.UIButton addPurchase;
        private System.Windows.Forms.ColumnHeader list_etc;
        private System.Windows.Forms.DataGridView addPurchaseGridView;
        private Sunny.UI.UISymbolButton searchSupplier;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDatePicker dpicPurchaseAddTo;
        private Sunny.UI.UIDatePicker dpicPurchaseAddFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn puchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
