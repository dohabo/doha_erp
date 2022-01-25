
namespace clutch_MES.UI
{
    partial class AddWorkUI
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
            this.addedWorkListView = new System.Windows.Forms.ListView();
            this.addedworkNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkMachine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.addCompany = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addWorkDateTo = new Sunny.UI.UIDatePicker();
            this.searchWorker = new Sunny.UI.UISymbolButton();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.addWorkDateFrom = new Sunny.UI.UIDatePicker();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.searchMachine = new Sunny.UI.UISymbolButton();
            this.addWorkNote = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.addWorkQuantity = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.addWorkItem = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.addWorkPerson = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.addWorkMachine = new Sunny.UI.UITextBox();
            this.searchWork = new Sunny.UI.UISymbolButton();
            this.newWork = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.addWork = new Sunny.UI.UIButton();
            this.addWorkGridView = new System.Windows.Forms.DataGridView();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addWorkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addedWorkListView
            // 
            this.addedWorkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addedworkNumber,
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
            this.addedWorkListView.Location = new System.Drawing.Point(3, 223);
            this.addedWorkListView.Name = "addedWorkListView";
            this.addedWorkListView.Size = new System.Drawing.Size(1144, 325);
            this.addedWorkListView.TabIndex = 0;
            this.addedWorkListView.UseCompatibleStateImageBehavior = false;
            this.addedWorkListView.View = System.Windows.Forms.View.Details;
            // 
            // addedworkNumber
            // 
            this.addedworkNumber.Text = "작업 지시 번호";
            this.addedworkNumber.Width = 100;
            // 
            // addedCompany
            // 
            this.addedCompany.Text = "사업장";
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
            this.addedworkNote.Width = 190;
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
            // addCompany
            // 
            this.addCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCompany.FillColor = System.Drawing.Color.White;
            this.addCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCompany.Location = new System.Drawing.Point(115, 3);
            this.addCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCompany.Maximum = 2147483647D;
            this.addCompany.Minimum = -2147483648D;
            this.addCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(103, 36);
            this.addCompany.TabIndex = 4;
            this.addCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "작업 지시 등록";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.addWorkDateTo);
            this.panel1.Controls.Add(this.searchWorker);
            this.panel1.Controls.Add(this.searchCompany);
            this.panel1.Controls.Add(this.addWorkDateFrom);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.searchMachine);
            this.panel1.Controls.Add(this.addWorkNote);
            this.panel1.Controls.Add(this.uiLabel8);
            this.panel1.Controls.Add(this.uiLabel7);
            this.panel1.Controls.Add(this.addWorkQuantity);
            this.panel1.Controls.Add(this.uiLabel6);
            this.panel1.Controls.Add(this.addWorkItem);
            this.panel1.Controls.Add(this.uiLabel5);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.addWorkPerson);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.addWorkMachine);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.addCompany);
            this.panel1.Location = new System.Drawing.Point(3, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 125);
            this.panel1.TabIndex = 14;
            // 
            // addWorkDateTo
            // 
            this.addWorkDateTo.FillColor = System.Drawing.Color.White;
            this.addWorkDateTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkDateTo.Location = new System.Drawing.Point(567, 84);
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
            // searchWorker
            // 
            this.searchWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorker.Location = new System.Drawing.Point(224, 87);
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
            this.searchCompany.Location = new System.Drawing.Point(224, 4);
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
            this.addWorkDateFrom.Location = new System.Drawing.Point(400, 85);
            this.addWorkDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkDateFrom.MaxLength = 10;
            this.addWorkDateFrom.MinimumSize = new System.Drawing.Size(63, 0);
            this.addWorkDateFrom.Name = "addWorkDateFrom";
            this.addWorkDateFrom.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.addWorkDateFrom.Size = new System.Drawing.Size(161, 34);
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
            this.searchItem.Location = new System.Drawing.Point(567, 3);
            this.searchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(34, 35);
            this.searchItem.Symbol = 61442;
            this.searchItem.TabIndex = 20;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // searchMachine
            // 
            this.searchMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchMachine.Location = new System.Drawing.Point(224, 45);
            this.searchMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchMachine.Name = "searchMachine";
            this.searchMachine.Size = new System.Drawing.Size(34, 35);
            this.searchMachine.Symbol = 61442;
            this.searchMachine.TabIndex = 18;
            this.searchMachine.Click += new System.EventHandler(this.searchMachine_Click);
            // 
            // addWorkNote
            // 
            this.addWorkNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkNote.FillColor = System.Drawing.Color.White;
            this.addWorkNote.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkNote.Location = new System.Drawing.Point(805, 35);
            this.addWorkNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkNote.Maximum = 2147483647D;
            this.addWorkNote.Minimum = -2147483648D;
            this.addWorkNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkNote.Multiline = true;
            this.addWorkNote.Name = "addWorkNote";
            this.addWorkNote.Size = new System.Drawing.Size(336, 86);
            this.addWorkNote.TabIndex = 16;
            this.addWorkNote.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(805, 4);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(106, 35);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "특이사항";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(287, 43);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(106, 35);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "생산수량";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkQuantity
            // 
            this.addWorkQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkQuantity.FillColor = System.Drawing.Color.White;
            this.addWorkQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkQuantity.Location = new System.Drawing.Point(400, 42);
            this.addWorkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkQuantity.Maximum = 2147483647D;
            this.addWorkQuantity.Minimum = -2147483648D;
            this.addWorkQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkQuantity.Name = "addWorkQuantity";
            this.addWorkQuantity.Size = new System.Drawing.Size(161, 36);
            this.addWorkQuantity.TabIndex = 14;
            this.addWorkQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(287, 3);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(106, 35);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "생산품목";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkItem
            // 
            this.addWorkItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkItem.FillColor = System.Drawing.Color.White;
            this.addWorkItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkItem.Location = new System.Drawing.Point(400, 2);
            this.addWorkItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkItem.Maximum = 2147483647D;
            this.addWorkItem.Minimum = -2147483648D;
            this.addWorkItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkItem.Name = "addWorkItem";
            this.addWorkItem.Size = new System.Drawing.Size(161, 36);
            this.addWorkItem.TabIndex = 12;
            this.addWorkItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(287, 84);
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
            this.uiLabel4.Location = new System.Drawing.Point(3, 85);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(106, 35);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "작업자";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkPerson
            // 
            this.addWorkPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkPerson.FillColor = System.Drawing.Color.White;
            this.addWorkPerson.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkPerson.Location = new System.Drawing.Point(115, 85);
            this.addWorkPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkPerson.Maximum = 2147483647D;
            this.addWorkPerson.Minimum = -2147483648D;
            this.addWorkPerson.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkPerson.Name = "addWorkPerson";
            this.addWorkPerson.Size = new System.Drawing.Size(103, 36);
            this.addWorkPerson.TabIndex = 8;
            this.addWorkPerson.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(3, 44);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(106, 35);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "설비라인";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkMachine
            // 
            this.addWorkMachine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addWorkMachine.FillColor = System.Drawing.Color.White;
            this.addWorkMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkMachine.Location = new System.Drawing.Point(115, 44);
            this.addWorkMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkMachine.Maximum = 2147483647D;
            this.addWorkMachine.Minimum = -2147483648D;
            this.addWorkMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkMachine.Name = "addWorkMachine";
            this.addWorkMachine.Size = new System.Drawing.Size(103, 36);
            this.addWorkMachine.TabIndex = 6;
            this.addWorkMachine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchWork
            // 
            this.searchWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWork.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWork.Location = new System.Drawing.Point(3, 3);
            this.searchWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWork.Name = "searchWork";
            this.searchWork.Size = new System.Drawing.Size(60, 60);
            this.searchWork.Symbol = 61442;
            this.searchWork.SymbolSize = 30;
            this.searchWork.TabIndex = 16;
            this.searchWork.Click += new System.EventHandler(this.searchWork_Click);
            // 
            // newWork
            // 
            this.newWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newWork.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.newWork.Location = new System.Drawing.Point(69, 3);
            this.newWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.newWork.Name = "newWork";
            this.newWork.Size = new System.Drawing.Size(60, 60);
            this.newWork.Symbol = 61543;
            this.newWork.SymbolSize = 30;
            this.newWork.TabIndex = 17;
            this.newWork.Click += new System.EventHandler(this.newWork_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 197);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(142, 23);
            this.uiMarkLabel1.TabIndex = 19;
            this.uiMarkLabel1.Text = "등록된 작업계획";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 554);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel2.TabIndex = 20;
            this.uiMarkLabel2.Text = "신규 작업계획 등록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWork
            // 
            this.addWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWork.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWork.Location = new System.Drawing.Point(1026, 554);
            this.addWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWork.Name = "addWork";
            this.addWork.Size = new System.Drawing.Size(121, 23);
            this.addWork.TabIndex = 21;
            this.addWork.Text = "등록";
            this.addWork.Click += new System.EventHandler(this.addWork_Click);
            // 
            // addWorkGridView
            // 
            this.addWorkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addWorkGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company,
            this.workPerson,
            this.workItem,
            this.workQuantity,
            this.WorkDate,
            this.workNote});
            this.addWorkGridView.Location = new System.Drawing.Point(7, 583);
            this.addWorkGridView.Name = "addWorkGridView";
            this.addWorkGridView.RowTemplate.Height = 23;
            this.addWorkGridView.Size = new System.Drawing.Size(1140, 165);
            this.addWorkGridView.TabIndex = 22;
            // 
            // company
            // 
            this.company.HeaderText = "사업장";
            this.company.Name = "company";
            // 
            // workPerson
            // 
            this.workPerson.HeaderText = "작업자";
            this.workPerson.Name = "workPerson";
            this.workPerson.Width = 80;
            // 
            // workItem
            // 
            this.workItem.HeaderText = "생산품목";
            this.workItem.Name = "workItem";
            // 
            // workQuantity
            // 
            this.workQuantity.HeaderText = "생산수량";
            this.workQuantity.Name = "workQuantity";
            this.workQuantity.Width = 80;
            // 
            // WorkDate
            // 
            this.WorkDate.HeaderText = "생산요구일";
            this.WorkDate.Name = "WorkDate";
            this.WorkDate.Width = 120;
            // 
            // workNote
            // 
            this.workNote.HeaderText = "특이사항";
            this.workNote.Name = "workNote";
            this.workNote.Width = 195;
            // 
            // AddWorkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addWorkGridView);
            this.Controls.Add(this.addWork);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.newWork);
            this.Controls.Add(this.searchWork);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.addedWorkListView);
            this.DoubleBuffered = true;
            this.Name = "AddWorkUI";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.AddWorkUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addWorkGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView addedWorkListView;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox addCompany;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIDatePicker addWorkDateFrom;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UISymbolButton searchMachine;
        private Sunny.UI.UITextBox addWorkNote;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox addWorkQuantity;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox addWorkItem;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox addWorkPerson;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox addWorkMachine;
        private Sunny.UI.UISymbolButton searchWork;
        private Sunny.UI.UISymbolButton newWork;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UIButton addWork;
        private System.Windows.Forms.ColumnHeader addedworkNumber;
        private System.Windows.Forms.ColumnHeader addedCompany;
        private System.Windows.Forms.ColumnHeader addedworkMachine;
        private System.Windows.Forms.ColumnHeader addedworkPerson;
        private System.Windows.Forms.ColumnHeader addedworkItem;
        private System.Windows.Forms.ColumnHeader addedworkQuantity;
        private System.Windows.Forms.ColumnHeader addedworkDate;
        private System.Windows.Forms.ColumnHeader addedworkNote;
        private System.Windows.Forms.DataGridView addWorkGridView;
        private Sunny.UI.UISymbolButton searchWorker;
        private Sunny.UI.UISymbolButton searchCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn workItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn workQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNote;
        private Sunny.UI.UIDatePicker addWorkDateTo;
    }
}
