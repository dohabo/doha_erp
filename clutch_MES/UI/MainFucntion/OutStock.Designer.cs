
namespace clutch_MES.UI.MainFucntion
{
    partial class OutStock
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
            this.addWorkDateTo = new Sunny.UI.UIDatePicker();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addWorkNote = new Sunny.UI.UITextBox();
            this.searchSupplier = new Sunny.UI.UISymbolButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.searchMachine = new Sunny.UI.UISymbolButton();
            this.addWorkMachine = new Sunny.UI.UITextBox();
            this.searchWorker = new Sunny.UI.UISymbolButton();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.addWorkDateFrom = new Sunny.UI.UIDatePicker();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.addWorkQuantity = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.addWorkItem = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.addWorkPerson = new Sunny.UI.UITextBox();
            this.addedWorkListView = new System.Windows.Forms.ListView();
            this.workOrderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkMachine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchWork = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeOutDate = new Sunny.UI.UISymbolButton();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.dpicOutDate = new Sunny.UI.UIDatePicker();
            this.addOutStockItems = new Sunny.UI.UISymbolButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.subtractionStock = new Sunny.UI.UISymbolButton();
            this.InStockNotice = new Sunny.UI.UILabel();
            this.outStockGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.addCompany = new Sunny.UI.UITextBox();
            this.panel1.SuspendLayout();
            this.addWorkQuantity.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outStockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addWorkDateTo
            // 
            this.addWorkDateTo.FillColor = System.Drawing.Color.White;
            this.addWorkDateTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkDateTo.Location = new System.Drawing.Point(550, 89);
            this.addWorkDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkDateTo.MaxLength = 10;
            this.addWorkDateTo.MinimumSize = new System.Drawing.Size(63, 0);
            this.addWorkDateTo.Name = "addWorkDateTo";
            this.addWorkDateTo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.addWorkDateTo.Size = new System.Drawing.Size(161, 34);
            this.addWorkDateTo.SymbolDropDown = 61555;
            this.addWorkDateTo.SymbolNormal = 61555;
            this.addWorkDateTo.TabIndex = 22;
            this.addWorkDateTo.Text = "2021-08-11";
            this.addWorkDateTo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorkDateTo.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(287, 48);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(106, 35);
            this.uiLabel9.TabIndex = 25;
            this.uiLabel9.Text = "설비라인";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.addCompany);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.addWorkNote);
            this.panel1.Controls.Add(this.searchSupplier);
            this.panel1.Controls.Add(this.uiLabel8);
            this.panel1.Controls.Add(this.searchMachine);
            this.panel1.Controls.Add(this.addWorkMachine);
            this.panel1.Controls.Add(this.addWorkDateTo);
            this.panel1.Controls.Add(this.uiLabel9);
            this.panel1.Controls.Add(this.searchWorker);
            this.panel1.Controls.Add(this.searchCompany);
            this.panel1.Controls.Add(this.addWorkDateFrom);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.addWorkQuantity);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.addWorkItem);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.addWorkPerson);
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 125);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addWorkNote
            // 
            this.addWorkNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkNote.FillColor = System.Drawing.Color.White;
            this.addWorkNote.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkNote.Location = new System.Drawing.Point(796, 36);
            this.addWorkNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkNote.Maximum = 2147483647D;
            this.addWorkNote.Minimum = -2147483648D;
            this.addWorkNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkNote.Multiline = true;
            this.addWorkNote.Name = "addWorkNote";
            this.addWorkNote.Size = new System.Drawing.Size(336, 86);
            this.addWorkNote.TabIndex = 56;
            this.addWorkNote.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchSupplier
            // 
            this.searchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchSupplier.Location = new System.Drawing.Point(225, 86);
            this.searchSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(34, 35);
            this.searchSupplier.Symbol = 61442;
            this.searchSupplier.TabIndex = 28;
            this.searchSupplier.Click += new System.EventHandler(this.searchSupplier_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(796, 5);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(106, 35);
            this.uiLabel8.TabIndex = 57;
            this.uiLabel8.Text = "특이사항";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchMachine
            // 
            this.searchMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchMachine.Location = new System.Drawing.Point(508, 47);
            this.searchMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchMachine.Name = "searchMachine";
            this.searchMachine.Size = new System.Drawing.Size(34, 35);
            this.searchMachine.Symbol = 61442;
            this.searchMachine.TabIndex = 25;
            this.searchMachine.Click += new System.EventHandler(this.searchMachine_Click);
            // 
            // addWorkMachine
            // 
            this.addWorkMachine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkMachine.FillColor = System.Drawing.Color.White;
            this.addWorkMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkMachine.Location = new System.Drawing.Point(399, 47);
            this.addWorkMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkMachine.Maximum = 2147483647D;
            this.addWorkMachine.Minimum = -2147483648D;
            this.addWorkMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkMachine.Name = "addWorkMachine";
            this.addWorkMachine.Size = new System.Drawing.Size(103, 36);
            this.addWorkMachine.TabIndex = 24;
            this.addWorkMachine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchWorker
            // 
            this.searchWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorker.Location = new System.Drawing.Point(508, 5);
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
            // addWorkDateFrom
            // 
            this.addWorkDateFrom.FillColor = System.Drawing.Color.White;
            this.addWorkDateFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkDateFrom.Location = new System.Drawing.Point(395, 89);
            this.addWorkDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkDateFrom.MaxLength = 10;
            this.addWorkDateFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.addWorkDateFrom.Name = "addWorkDateFrom";
            this.addWorkDateFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.addWorkDateFrom.Size = new System.Drawing.Size(147, 34);
            this.addWorkDateFrom.SymbolDropDown = 61555;
            this.addWorkDateFrom.SymbolNormal = 61555;
            this.addWorkDateFrom.TabIndex = 21;
            this.addWorkDateFrom.Text = "2021-08-11";
            this.addWorkDateFrom.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorkDateFrom.Value = new System.DateTime(2021, 8, 11, 16, 26, 56, 591);
            // 
            // searchItem
            // 
            this.searchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchItem.Location = new System.Drawing.Point(225, 44);
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
            this.uiLabel7.Location = new System.Drawing.Point(3, 84);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(106, 35);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "거래처";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkQuantity
            // 
            this.addWorkQuantity.Controls.Add(this.uiTextBox1);
            this.addWorkQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkQuantity.FillColor = System.Drawing.Color.White;
            this.addWorkQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkQuantity.Location = new System.Drawing.Point(116, 83);
            this.addWorkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkQuantity.Maximum = 2147483647D;
            this.addWorkQuantity.Minimum = -2147483648D;
            this.addWorkQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkQuantity.Name = "addWorkQuantity";
            this.addWorkQuantity.Size = new System.Drawing.Size(102, 36);
            this.addWorkQuantity.TabIndex = 14;
            this.addWorkQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // addWorkItem
            // 
            this.addWorkItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkItem.FillColor = System.Drawing.Color.White;
            this.addWorkItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkItem.Location = new System.Drawing.Point(116, 43);
            this.addWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkItem.Maximum = 2147483647D;
            this.addWorkItem.Minimum = -2147483648D;
            this.addWorkItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkItem.Name = "addWorkItem";
            this.addWorkItem.Size = new System.Drawing.Size(102, 36);
            this.addWorkItem.TabIndex = 12;
            this.addWorkItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(282, 88);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(106, 35);
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "생산 요구일";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(287, 5);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(106, 35);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "담당자";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkPerson
            // 
            this.addWorkPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkPerson.FillColor = System.Drawing.Color.White;
            this.addWorkPerson.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkPerson.Location = new System.Drawing.Point(399, 5);
            this.addWorkPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkPerson.Maximum = 2147483647D;
            this.addWorkPerson.Minimum = -2147483648D;
            this.addWorkPerson.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkPerson.Name = "addWorkPerson";
            this.addWorkPerson.Size = new System.Drawing.Size(103, 36);
            this.addWorkPerson.TabIndex = 8;
            this.addWorkPerson.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addedWorkListView
            // 
            this.addedWorkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workOrderNum,
            this.addedCompany,
            this.addedworkMachine,
            this.addedworkPerson,
            this.addedworkItem,
            this.addedworkQuantity,
            this.addedworkDate,
            this.addedworkNote});
            this.addedWorkListView.FullRowSelect = true;
            this.addedWorkListView.GridLines = true;
            this.addedWorkListView.HideSelection = false;
            this.addedWorkListView.Location = new System.Drawing.Point(10, 227);
            this.addedWorkListView.Name = "addedWorkListView";
            this.addedWorkListView.Size = new System.Drawing.Size(1140, 130);
            this.addedWorkListView.TabIndex = 42;
            this.addedWorkListView.UseCompatibleStateImageBehavior = false;
            this.addedWorkListView.View = System.Windows.Forms.View.Details;
            // 
            // workOrderNum
            // 
            this.workOrderNum.Text = "작업 지시 번호";
            this.workOrderNum.Width = 120;
            // 
            // addedCompany
            // 
            this.addedCompany.Text = "사업장";
            this.addedCompany.Width = 100;
            // 
            // addedworkMachine
            // 
            this.addedworkMachine.Text = "설비라인";
            this.addedworkMachine.Width = 100;
            // 
            // addedworkPerson
            // 
            this.addedworkPerson.Text = "작업자";
            this.addedworkPerson.Width = 80;
            // 
            // addedworkItem
            // 
            this.addedworkItem.Text = "생산품번";
            this.addedworkItem.Width = 100;
            // 
            // addedworkQuantity
            // 
            this.addedworkQuantity.Text = "생산수량";
            this.addedworkQuantity.Width = 80;
            // 
            // addedworkDate
            // 
            this.addedworkDate.Text = "생산요구일";
            this.addedworkDate.Width = 120;
            // 
            // addedworkNote
            // 
            this.addedworkNote.Text = "특이사항";
            this.addedworkNote.Width = 180;
            // 
            // searchWork
            // 
            this.searchWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWork.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWork.Location = new System.Drawing.Point(3, 7);
            this.searchWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWork.Name = "searchWork";
            this.searchWork.Size = new System.Drawing.Size(60, 60);
            this.searchWork.Symbol = 61442;
            this.searchWork.SymbolSize = 30;
            this.searchWork.TabIndex = 44;
            this.searchWork.Click += new System.EventHandler(this.searchWork_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 43;
            this.uiLabel1.Text = "재고 출고 관리";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 507);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel2.TabIndex = 46;
            this.uiMarkLabel2.Text = "출고 목록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 201);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel1.TabIndex = 45;
            this.uiMarkLabel1.Text = "작업지시서";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.changeOutDate);
            this.panel2.Controls.Add(this.uiLabel11);
            this.panel2.Controls.Add(this.dpicOutDate);
            this.panel2.Controls.Add(this.addOutStockItems);
            this.panel2.Controls.Add(this.uiLabel12);
            this.panel2.Controls.Add(this.subtractionStock);
            this.panel2.Controls.Add(this.InStockNotice);
            this.panel2.Location = new System.Drawing.Point(11, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 141);
            this.panel2.TabIndex = 55;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // changeOutDate
            // 
            this.changeOutDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeOutDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.changeOutDate.Location = new System.Drawing.Point(486, 93);
            this.changeOutDate.MinimumSize = new System.Drawing.Size(1, 1);
            this.changeOutDate.Name = "changeOutDate";
            this.changeOutDate.Size = new System.Drawing.Size(180, 33);
            this.changeOutDate.Symbol = 61473;
            this.changeOutDate.SymbolSize = 30;
            this.changeOutDate.TabIndex = 53;
            this.changeOutDate.Text = "출고일 일괄 변경";
            this.changeOutDate.Click += new System.EventHandler(this.changeOutDate_Click);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel11.Location = new System.Drawing.Point(3, 42);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(605, 37);
            this.uiLabel11.TabIndex = 51;
            this.uiLabel11.Text = "※ 매칭되는 작업지시서가 없을 시에 \'작업 지시 번호\'를 공란으로 비워두십시오.";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpicOutDate
            // 
            this.dpicOutDate.FillColor = System.Drawing.Color.White;
            this.dpicOutDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dpicOutDate.Location = new System.Drawing.Point(344, 93);
            this.dpicOutDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpicOutDate.MaxLength = 10;
            this.dpicOutDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpicOutDate.Name = "dpicOutDate";
            this.dpicOutDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpicOutDate.Size = new System.Drawing.Size(135, 34);
            this.dpicOutDate.SymbolDropDown = 61555;
            this.dpicOutDate.SymbolNormal = 61555;
            this.dpicOutDate.TabIndex = 22;
            this.dpicOutDate.Text = "1988-01-01";
            this.dpicOutDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpicOutDate.Value = new System.DateTime(1988, 1, 1, 0, 0, 0, 0);
            // 
            // addOutStockItems
            // 
            this.addOutStockItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOutStockItems.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOutStockItems.Location = new System.Drawing.Point(7, 93);
            this.addOutStockItems.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOutStockItems.Name = "addOutStockItems";
            this.addOutStockItems.Size = new System.Drawing.Size(147, 33);
            this.addOutStockItems.Symbol = 61694;
            this.addOutStockItems.SymbolSize = 30;
            this.addOutStockItems.TabIndex = 42;
            this.addOutStockItems.Text = "출고 대상 추가";
            this.addOutStockItems.Click += new System.EventHandler(this.addOutStockItems_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel12.Location = new System.Drawing.Point(252, 94);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(85, 33);
            this.uiLabel12.TabIndex = 50;
            this.uiLabel12.Text = "출고일";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtractionStock
            // 
            this.subtractionStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtractionStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.subtractionStock.Location = new System.Drawing.Point(1025, 94);
            this.subtractionStock.MinimumSize = new System.Drawing.Size(1, 1);
            this.subtractionStock.Name = "subtractionStock";
            this.subtractionStock.Size = new System.Drawing.Size(106, 33);
            this.subtractionStock.Symbol = 361874;
            this.subtractionStock.SymbolSize = 30;
            this.subtractionStock.TabIndex = 38;
            this.subtractionStock.Text = "출고";
            this.subtractionStock.Click += new System.EventHandler(this.subtractionStock_Click);
            // 
            // InStockNotice
            // 
            this.InStockNotice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InStockNotice.Location = new System.Drawing.Point(3, 5);
            this.InStockNotice.Name = "InStockNotice";
            this.InStockNotice.Size = new System.Drawing.Size(571, 37);
            this.InStockNotice.TabIndex = 39;
            this.InStockNotice.Text = "※ 출고 처리 할 항목의 라인을 선택 후 \'출고 대상 추가\'버튼을 클릭하세요.";
            this.InStockNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outStockGridView
            // 
            this.outStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outStockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.purchaseItem,
            this.purchaseQuantity,
            this.puchaseDate,
            this.dataGridViewTextBoxColumn2});
            this.outStockGridView.Location = new System.Drawing.Point(10, 531);
            this.outStockGridView.Name = "outStockGridView";
            this.outStockGridView.RowTemplate.Height = 23;
            this.outStockGridView.Size = new System.Drawing.Size(1132, 217);
            this.outStockGridView.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "작업 지시 번호";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "사업장";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.puchaseDate.HeaderText = "출고일";
            this.puchaseDate.Name = "puchaseDate";
            this.puchaseDate.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "특이사항";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(3, 3);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(106, 35);
            this.uiLabel2.TabIndex = 58;
            this.uiLabel2.Text = "사업장";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addCompany
            // 
            this.addCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCompany.FillColor = System.Drawing.Color.White;
            this.addCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCompany.Location = new System.Drawing.Point(116, 5);
            this.addCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCompany.Maximum = 2147483647D;
            this.addCompany.Minimum = -2147483648D;
            this.addCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(102, 36);
            this.addCompany.TabIndex = 13;
            this.addCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outStockGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addedWorkListView);
            this.Controls.Add(this.searchWork);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "OutStock";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.OutStock_Load);
            this.panel1.ResumeLayout(false);
            this.addWorkQuantity.ResumeLayout(false);
            this.addWorkQuantity.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outStockGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDatePicker addWorkDateTo;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton searchWorker;
        private Sunny.UI.UISymbolButton searchCompany;
        private Sunny.UI.UIDatePicker addWorkDateFrom;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox addWorkQuantity;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox addWorkItem;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox addWorkPerson;
        private System.Windows.Forms.ListView addedWorkListView;
        private System.Windows.Forms.ColumnHeader workOrderNum;
        private System.Windows.Forms.ColumnHeader addedCompany;
        private System.Windows.Forms.ColumnHeader addedworkMachine;
        private System.Windows.Forms.ColumnHeader addedworkPerson;
        private System.Windows.Forms.ColumnHeader addedworkItem;
        private System.Windows.Forms.ColumnHeader addedworkQuantity;
        private System.Windows.Forms.ColumnHeader addedworkDate;
        private System.Windows.Forms.ColumnHeader addedworkNote;
        private Sunny.UI.UISymbolButton searchWork;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIDatePicker dpicOutDate;
        private Sunny.UI.UISymbolButton addOutStockItems;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UISymbolButton subtractionStock;
        private Sunny.UI.UILabel InStockNotice;
        private Sunny.UI.UILabel uiLabel11;
        private System.Windows.Forms.DataGridView outStockGridView;
        private Sunny.UI.UISymbolButton changeOutDate;
        private Sunny.UI.UISymbolButton searchMachine;
        private Sunny.UI.UITextBox addWorkMachine;
        private Sunny.UI.UISymbolButton searchSupplier;
        private Sunny.UI.UITextBox addWorkNote;
        private Sunny.UI.UILabel uiLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn puchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Sunny.UI.UITextBox addCompany;
        private Sunny.UI.UILabel uiLabel2;
    }
}
