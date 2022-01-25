
namespace clutch_MES.UI.MainFucntion
{
    partial class StockManage
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.searchWorker = new Sunny.UI.UISymbolButton();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tboxPurchaser = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxItemCode = new Sunny.UI.UITextBox();
            this.dpicHistoryAddTo = new Sunny.UI.UIDatePicker();
            this.cbboxStatus = new Sunny.UI.UIComboBox();
            this.dpicHistoryAddFrom = new Sunny.UI.UIDatePicker();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tboxCompanyNum = new Sunny.UI.UITextBox();
            this.addedworkNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedWarehouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workOrderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockHistoryListView = new System.Windows.Forms.ListView();
            this.section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchStockHistory = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.stockListView = new System.Windows.Forms.ListView();
            this.lviewNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchStock = new Sunny.UI.UISymbolButton();
            this.lbSearchContens = new Sunny.UI.UILabel();
            this.InStockNotice = new Sunny.UI.UILabel();
            this.cboxSearchCondi = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.tboxStockItemCode = new Sunny.UI.UITextBox();
            this.searchStockItem = new Sunny.UI.UISymbolButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 31;
            this.uiLabel1.Text = "재고 관리";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchWorker
            // 
            this.searchWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorker.Location = new System.Drawing.Point(225, 86);
            this.searchWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWorker.Name = "searchWorker";
            this.searchWorker.Size = new System.Drawing.Size(34, 35);
            this.searchWorker.Symbol = 61442;
            this.searchWorker.TabIndex = 23;
            this.searchWorker.Click += new System.EventHandler(this.searchWorker_Click);
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
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(282, 48);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(106, 35);
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "일자";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(3, 85);
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
            this.tboxPurchaser.Location = new System.Drawing.Point(115, 85);
            this.tboxPurchaser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPurchaser.Maximum = 2147483647D;
            this.tboxPurchaser.Minimum = -2147483648D;
            this.tboxPurchaser.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxPurchaser.Name = "tboxPurchaser";
            this.tboxPurchaser.Size = new System.Drawing.Size(103, 36);
            this.tboxPurchaser.TabIndex = 8;
            this.tboxPurchaser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(282, 4);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(106, 35);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "입출고";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.tboxItemCode);
            this.panel1.Controls.Add(this.dpicHistoryAddTo);
            this.panel1.Controls.Add(this.cbboxStatus);
            this.panel1.Controls.Add(this.searchWorker);
            this.panel1.Controls.Add(this.searchCompany);
            this.panel1.Controls.Add(this.dpicHistoryAddFrom);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.tboxPurchaser);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.tboxCompanyNum);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 125);
            this.panel1.TabIndex = 32;
            // 
            // tboxItemCode
            // 
            this.tboxItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxItemCode.FillColor = System.Drawing.Color.White;
            this.tboxItemCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxItemCode.Location = new System.Drawing.Point(115, 43);
            this.tboxItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxItemCode.Maximum = 2147483647D;
            this.tboxItemCode.Minimum = -2147483648D;
            this.tboxItemCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxItemCode.Name = "tboxItemCode";
            this.tboxItemCode.Size = new System.Drawing.Size(103, 36);
            this.tboxItemCode.TabIndex = 5;
            this.tboxItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpicHistoryAddTo
            // 
            this.dpicHistoryAddTo.FillColor = System.Drawing.Color.White;
            this.dpicHistoryAddTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicHistoryAddTo.Location = new System.Drawing.Point(569, 46);
            this.dpicHistoryAddTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicHistoryAddTo.MaxLength = 10;
            this.dpicHistoryAddTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicHistoryAddTo.Name = "dpicHistoryAddTo";
            this.dpicHistoryAddTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicHistoryAddTo.Size = new System.Drawing.Size(161, 34);
            this.dpicHistoryAddTo.SymbolDropDown = 61555;
            this.dpicHistoryAddTo.SymbolNormal = 61555;
            this.dpicHistoryAddTo.TabIndex = 22;
            this.dpicHistoryAddTo.Text = "2021-08-11";
            this.dpicHistoryAddTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicHistoryAddTo.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // cbboxStatus
            // 
            this.cbboxStatus.DataSource = null;
            this.cbboxStatus.FillColor = System.Drawing.Color.White;
            this.cbboxStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbboxStatus.Items.AddRange(new object[] {
            "전체",
            "입고",
            "출고"});
            this.cbboxStatus.Location = new System.Drawing.Point(395, 5);
            this.cbboxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbboxStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbboxStatus.Name = "cbboxStatus";
            this.cbboxStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbboxStatus.Size = new System.Drawing.Size(125, 36);
            this.cbboxStatus.TabIndex = 24;
            this.cbboxStatus.Text = "전체";
            this.cbboxStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpicHistoryAddFrom
            // 
            this.dpicHistoryAddFrom.FillColor = System.Drawing.Color.White;
            this.dpicHistoryAddFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicHistoryAddFrom.Location = new System.Drawing.Point(395, 47);
            this.dpicHistoryAddFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicHistoryAddFrom.MaxLength = 10;
            this.dpicHistoryAddFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicHistoryAddFrom.Name = "dpicHistoryAddFrom";
            this.dpicHistoryAddFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicHistoryAddFrom.Size = new System.Drawing.Size(166, 34);
            this.dpicHistoryAddFrom.SymbolDropDown = 61555;
            this.dpicHistoryAddFrom.SymbolNormal = 61555;
            this.dpicHistoryAddFrom.TabIndex = 21;
            this.dpicHistoryAddFrom.Text = "2021-08-11";
            this.dpicHistoryAddFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicHistoryAddFrom.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // searchItem
            // 
            this.searchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchItem.Location = new System.Drawing.Point(225, 43);
            this.searchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(34, 35);
            this.searchItem.Symbol = 61442;
            this.searchItem.TabIndex = 20;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(3, 44);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(106, 35);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "품목";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // addedworkNote
            // 
            this.addedworkNote.Text = "특이사항";
            this.addedworkNote.Width = 180;
            // 
            // addedInDate
            // 
            this.addedInDate.Text = "입출고일";
            this.addedInDate.Width = 120;
            // 
            // addedworkQuantity
            // 
            this.addedworkQuantity.Text = "수량";
            this.addedworkQuantity.Width = 80;
            // 
            // addedWarehouse
            // 
            this.addedWarehouse.Text = "창고";
            this.addedWarehouse.Width = 80;
            // 
            // addedCompany
            // 
            this.addedCompany.Text = "사업장";
            this.addedCompany.Width = 100;
            // 
            // workOrderNum
            // 
            this.workOrderNum.Text = "작업 지시 번호";
            this.workOrderNum.Width = 120;
            // 
            // stockHistoryListView
            // 
            this.stockHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.section,
            this.purchaseNum,
            this.workOrderNum,
            this.addedCompany,
            this.addedworkItem,
            this.addedworkQuantity,
            this.addedInDate,
            this.addedWarehouse,
            this.addedworkNote});
            this.stockHistoryListView.GridLines = true;
            this.stockHistoryListView.HideSelection = false;
            this.stockHistoryListView.Location = new System.Drawing.Point(7, 227);
            this.stockHistoryListView.Name = "stockHistoryListView";
            this.stockHistoryListView.Size = new System.Drawing.Size(1140, 189);
            this.stockHistoryListView.TabIndex = 30;
            this.stockHistoryListView.UseCompatibleStateImageBehavior = false;
            this.stockHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // section
            // 
            this.section.Text = "구분";
            // 
            // purchaseNum
            // 
            this.purchaseNum.Text = "구매오더번호";
            this.purchaseNum.Width = 100;
            // 
            // addedworkItem
            // 
            this.addedworkItem.Text = "품번";
            this.addedworkItem.Width = 100;
            // 
            // searchStockHistory
            // 
            this.searchStockHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStockHistory.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchStockHistory.Location = new System.Drawing.Point(3, 7);
            this.searchStockHistory.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchStockHistory.Name = "searchStockHistory";
            this.searchStockHistory.Size = new System.Drawing.Size(60, 60);
            this.searchStockHistory.Symbol = 61442;
            this.searchStockHistory.SymbolSize = 30;
            this.searchStockHistory.TabIndex = 33;
            this.searchStockHistory.Click += new System.EventHandler(this.searchStockHistory_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 201);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel1.TabIndex = 34;
            this.uiMarkLabel1.Text = "입출고 목록";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stockListView
            // 
            this.stockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviewNum,
            this.lviewItemCode,
            this.lviewStockQuantity});
            this.stockListView.GridLines = true;
            this.stockListView.HideSelection = false;
            this.stockListView.Location = new System.Drawing.Point(3, 562);
            this.stockListView.Name = "stockListView";
            this.stockListView.Size = new System.Drawing.Size(315, 186);
            this.stockListView.TabIndex = 35;
            this.stockListView.UseCompatibleStateImageBehavior = false;
            this.stockListView.View = System.Windows.Forms.View.Details;
            // 
            // lviewNum
            // 
            this.lviewNum.Text = "순번";
            // 
            // lviewItemCode
            // 
            this.lviewItemCode.Text = "품번";
            this.lviewItemCode.Width = 120;
            // 
            // lviewStockQuantity
            // 
            this.lviewStockQuantity.Text = "수량";
            this.lviewStockQuantity.Width = 120;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(-1, 536);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel2.TabIndex = 36;
            this.uiMarkLabel2.Text = "재고 목록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.uiCheckBox1);
            this.panel2.Controls.Add(this.btnSearchStock);
            this.panel2.Controls.Add(this.lbSearchContens);
            this.panel2.Controls.Add(this.InStockNotice);
            this.panel2.Controls.Add(this.cboxSearchCondi);
            this.panel2.Controls.Add(this.uiLabel7);
            this.panel2.Controls.Add(this.tboxStockItemCode);
            this.panel2.Controls.Add(this.searchStockItem);
            this.panel2.Controls.Add(this.uiLabel8);
            this.panel2.Location = new System.Drawing.Point(3, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 105);
            this.panel2.TabIndex = 33;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSearchStock.Location = new System.Drawing.Point(286, 50);
            this.btnSearchStock.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(150, 36);
            this.btnSearchStock.Symbol = 361498;
            this.btnSearchStock.TabIndex = 42;
            this.btnSearchStock.Text = "재고 검색";
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // lbSearchContens
            // 
            this.lbSearchContens.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lbSearchContens.Location = new System.Drawing.Point(624, 6);
            this.lbSearchContens.Name = "lbSearchContens";
            this.lbSearchContens.Size = new System.Drawing.Size(515, 99);
            this.lbSearchContens.TabIndex = 41;
            this.lbSearchContens.Text = "검색 형태 요약";
            this.lbSearchContens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InStockNotice
            // 
            this.InStockNotice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InStockNotice.Location = new System.Drawing.Point(476, 6);
            this.InStockNotice.Name = "InStockNotice";
            this.InStockNotice.Size = new System.Drawing.Size(142, 37);
            this.InStockNotice.TabIndex = 40;
            this.InStockNotice.Text = "※ 검색 기능 설명";
            this.InStockNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxSearchCondi
            // 
            this.cboxSearchCondi.DataSource = null;
            this.cboxSearchCondi.FillColor = System.Drawing.Color.White;
            this.cboxSearchCondi.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cboxSearchCondi.Location = new System.Drawing.Point(115, 10);
            this.cboxSearchCondi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxSearchCondi.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboxSearchCondi.Name = "cboxSearchCondi";
            this.cboxSearchCondi.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboxSearchCondi.Size = new System.Drawing.Size(103, 36);
            this.cboxSearchCondi.TabIndex = 25;
            this.cboxSearchCondi.Text = "전체";
            this.cboxSearchCondi.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(3, 13);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(106, 35);
            this.uiLabel7.TabIndex = 25;
            this.uiLabel7.Text = "검색 형태";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxStockItemCode
            // 
            this.tboxStockItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxStockItemCode.FillColor = System.Drawing.Color.White;
            this.tboxStockItemCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxStockItemCode.Location = new System.Drawing.Point(115, 50);
            this.tboxStockItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxStockItemCode.Maximum = 2147483647D;
            this.tboxStockItemCode.Minimum = -2147483648D;
            this.tboxStockItemCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxStockItemCode.Name = "tboxStockItemCode";
            this.tboxStockItemCode.Size = new System.Drawing.Size(103, 36);
            this.tboxStockItemCode.TabIndex = 5;
            this.tboxStockItemCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchStockItem
            // 
            this.searchStockItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStockItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchStockItem.Location = new System.Drawing.Point(225, 51);
            this.searchStockItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchStockItem.Name = "searchStockItem";
            this.searchStockItem.Size = new System.Drawing.Size(34, 35);
            this.searchStockItem.Symbol = 61442;
            this.searchStockItem.TabIndex = 20;
            this.searchStockItem.Click += new System.EventHandler(this.searchStockItem_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(3, 51);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(106, 35);
            this.uiLabel8.TabIndex = 11;
            this.uiLabel8.Text = "품목";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiCheckBox1.Location = new System.Drawing.Point(286, 15);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(150, 29);
            this.uiCheckBox1.TabIndex = 37;
            this.uiCheckBox1.Text = "재고\'0\' 표시여부";
            // 
            // StockManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stockListView);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stockHistoryListView);
            this.Controls.Add(this.searchStockHistory);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "StockManage";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.StockManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton searchWorker;
        private Sunny.UI.UISymbolButton searchCompany;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox tboxPurchaser;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIDatePicker dpicHistoryAddFrom;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox tboxCompanyNum;
        private System.Windows.Forms.ColumnHeader addedworkNote;
        private System.Windows.Forms.ColumnHeader addedInDate;
        private System.Windows.Forms.ColumnHeader addedworkQuantity;
        private System.Windows.Forms.ColumnHeader addedWarehouse;
        private System.Windows.Forms.ColumnHeader addedCompany;
        private System.Windows.Forms.ColumnHeader workOrderNum;
        private System.Windows.Forms.ListView stockHistoryListView;
        private System.Windows.Forms.ColumnHeader addedworkItem;
        private Sunny.UI.UISymbolButton searchStockHistory;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIComboBox cbboxStatus;
        private Sunny.UI.UIDatePicker dpicHistoryAddTo;
        private System.Windows.Forms.ColumnHeader section;
        private System.Windows.Forms.ColumnHeader purchaseNum;
        private System.Windows.Forms.ListView stockListView;
        private System.Windows.Forms.ColumnHeader lviewNum;
        private System.Windows.Forms.ColumnHeader lviewItemCode;
        private System.Windows.Forms.ColumnHeader lviewStockQuantity;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UITextBox tboxItemCode;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UITextBox tboxStockItemCode;
        private Sunny.UI.UISymbolButton searchStockItem;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox cboxSearchCondi;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel lbSearchContens;
        private Sunny.UI.UILabel InStockNotice;
        private Sunny.UI.UISymbolButton btnSearchStock;
        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}
