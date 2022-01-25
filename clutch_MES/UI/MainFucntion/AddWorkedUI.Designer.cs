
namespace clutch_MES.UI
{
    partial class AddWorkedUI
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
            this.addedworkMachine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addWorked = new Sunny.UI.UIButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.addedworkQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedworkNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.searchWork = new Sunny.UI.UISymbolButton();
            this.addedworkPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedWorkListView = new System.Windows.Forms.ListView();
            this.addedworkNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.machinLine = new Sunny.UI.UITextBox();
            this.person = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.item = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.quantity = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.workedQuantity = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.workedDate = new Sunny.UI.UIDatePicker();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.defectQuantity = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.defectCode = new Sunny.UI.UIComboBox();
            this.workOrderNum = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiMarkLabel3 = new Sunny.UI.UIMarkLabel();
            this.lviewBOM = new System.Windows.Forms.ListView();
            this.lviewNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewPNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewCNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviewQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.machineCombo = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // addedworkMachine
            // 
            this.addedworkMachine.Text = "설비라인";
            this.addedworkMachine.Width = 100;
            // 
            // addedworkItem
            // 
            this.addedworkItem.Text = "생산품번";
            this.addedworkItem.Width = 100;
            // 
            // addWorked
            // 
            this.addWorked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorked.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorked.Location = new System.Drawing.Point(628, 542);
            this.addWorked.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorked.Name = "addWorked";
            this.addWorked.Size = new System.Drawing.Size(164, 199);
            this.addWorked.TabIndex = 40;
            this.addWorked.Text = "작업등록";
            this.addWorked.Click += new System.EventHandler(this.addWork_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 133);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(210, 38);
            this.uiMarkLabel1.TabIndex = 38;
            this.uiMarkLabel1.Text = "등록된 작업계획";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.addedworkNote.Width = 250;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 501);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(210, 38);
            this.uiMarkLabel2.TabIndex = 39;
            this.uiMarkLabel2.Text = "작업 내역 등록";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.searchWork.TabIndex = 36;
            this.searchWork.Click += new System.EventHandler(this.searchWork_Click);
            // 
            // addedworkPerson
            // 
            this.addedworkPerson.Text = "작업자";
            this.addedworkPerson.Width = 80;
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
            this.addedWorkListView.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addedWorkListView.FullRowSelect = true;
            this.addedWorkListView.GridLines = true;
            this.addedWorkListView.HideSelection = false;
            this.addedWorkListView.Location = new System.Drawing.Point(6, 174);
            this.addedWorkListView.Name = "addedWorkListView";
            this.addedWorkListView.Size = new System.Drawing.Size(1141, 129);
            this.addedWorkListView.TabIndex = 32;
            this.addedWorkListView.UseCompatibleStateImageBehavior = false;
            this.addedWorkListView.View = System.Windows.Forms.View.Details;
            this.addedWorkListView.DoubleClick += new System.EventHandler(this.addedWorkListView_DoubleClick);
            // 
            // addedworkNumber
            // 
            this.addedworkNumber.Text = "번호";
            this.addedworkNumber.Width = 80;
            // 
            // addedCompany
            // 
            this.addedCompany.Text = "사업장";
            this.addedCompany.Width = 100;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 33;
            this.uiLabel1.Text = "작업 내역 등록";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(3, 69);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(142, 61);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "설비라인";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(14, 583);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(135, 35);
            this.uiLabel2.TabIndex = 41;
            this.uiLabel2.Text = "설비라인";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // machinLine
            // 
            this.machinLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.machinLine.FillColor = System.Drawing.Color.White;
            this.machinLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.machinLine.Location = new System.Drawing.Point(156, 583);
            this.machinLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.machinLine.Maximum = 2147483647D;
            this.machinLine.Minimum = -2147483648D;
            this.machinLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.machinLine.Name = "machinLine";
            this.machinLine.Size = new System.Drawing.Size(135, 35);
            this.machinLine.TabIndex = 42;
            this.machinLine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // person
            // 
            this.person.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.person.FillColor = System.Drawing.Color.White;
            this.person.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.person.Location = new System.Drawing.Point(156, 665);
            this.person.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.person.Maximum = 2147483647D;
            this.person.Minimum = -2147483648D;
            this.person.MinimumSize = new System.Drawing.Size(1, 1);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(135, 35);
            this.person.TabIndex = 44;
            this.person.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(14, 665);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(135, 35);
            this.uiLabel4.TabIndex = 43;
            this.uiLabel4.Text = "작업자";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // item
            // 
            this.item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.item.FillColor = System.Drawing.Color.White;
            this.item.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.item.Location = new System.Drawing.Point(156, 706);
            this.item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.item.Maximum = 2147483647D;
            this.item.Minimum = -2147483648D;
            this.item.MinimumSize = new System.Drawing.Size(1, 1);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(135, 35);
            this.item.TabIndex = 46;
            this.item.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(10, 706);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(135, 35);
            this.uiLabel5.TabIndex = 45;
            this.uiLabel5.Text = "생산 품목명";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantity
            // 
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.FillColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.quantity.Location = new System.Drawing.Point(156, 624);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity.Maximum = 2147483647D;
            this.quantity.Minimum = -2147483648D;
            this.quantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(135, 35);
            this.quantity.TabIndex = 48;
            this.quantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(14, 624);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(135, 35);
            this.uiLabel6.TabIndex = 47;
            this.uiLabel6.Text = "생산 수량";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workedQuantity
            // 
            this.workedQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workedQuantity.FillColor = System.Drawing.Color.White;
            this.workedQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workedQuantity.Location = new System.Drawing.Point(472, 624);
            this.workedQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workedQuantity.Maximum = 2147483647D;
            this.workedQuantity.Minimum = -2147483648D;
            this.workedQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.workedQuantity.Name = "workedQuantity";
            this.workedQuantity.RectColor = System.Drawing.Color.Red;
            this.workedQuantity.Size = new System.Drawing.Size(135, 35);
            this.workedQuantity.Style = Sunny.UI.UIStyle.Custom;
            this.workedQuantity.TabIndex = 49;
            this.workedQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.workedQuantity.TextChanged += new System.EventHandler(this.workedQuantity_TextChanged);
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel7.Location = new System.Drawing.Point(330, 624);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(135, 35);
            this.uiLabel7.TabIndex = 50;
            this.uiLabel7.Text = "작업수량";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(330, 583);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(135, 35);
            this.uiLabel8.TabIndex = 51;
            this.uiLabel8.Text = "작업 일자";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workedDate
            // 
            this.workedDate.FillColor = System.Drawing.Color.White;
            this.workedDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workedDate.Location = new System.Drawing.Point(472, 583);
            this.workedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workedDate.MaxLength = 10;
            this.workedDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.workedDate.Name = "workedDate";
            this.workedDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.workedDate.RectColor = System.Drawing.Color.Red;
            this.workedDate.Size = new System.Drawing.Size(135, 35);
            this.workedDate.Style = Sunny.UI.UIStyle.Custom;
            this.workedDate.SymbolDropDown = 61555;
            this.workedDate.SymbolNormal = 61555;
            this.workedDate.TabIndex = 2;
            this.workedDate.Text = "2021-08-13";
            this.workedDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.workedDate.Value = new System.DateTime(2021, 8, 13, 13, 8, 35, 771);
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.Location = new System.Drawing.Point(330, 665);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(135, 35);
            this.uiLabel9.TabIndex = 54;
            this.uiLabel9.Text = "불량수량";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // defectQuantity
            // 
            this.defectQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.defectQuantity.FillColor = System.Drawing.Color.White;
            this.defectQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.defectQuantity.Location = new System.Drawing.Point(472, 665);
            this.defectQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defectQuantity.Maximum = 2147483647D;
            this.defectQuantity.Minimum = -2147483648D;
            this.defectQuantity.MinimumSize = new System.Drawing.Size(1, 1);
            this.defectQuantity.Name = "defectQuantity";
            this.defectQuantity.RectColor = System.Drawing.Color.Red;
            this.defectQuantity.Size = new System.Drawing.Size(135, 35);
            this.defectQuantity.Style = Sunny.UI.UIStyle.Custom;
            this.defectQuantity.TabIndex = 53;
            this.defectQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.defectQuantity.TextChanged += new System.EventHandler(this.defectQuantity_TextChanged);
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.Location = new System.Drawing.Point(330, 706);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(135, 35);
            this.uiLabel10.TabIndex = 56;
            this.uiLabel10.Text = "불량유형";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // defectCode
            // 
            this.defectCode.DataSource = null;
            this.defectCode.FillColor = System.Drawing.Color.White;
            this.defectCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.defectCode.Location = new System.Drawing.Point(472, 706);
            this.defectCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defectCode.MinimumSize = new System.Drawing.Size(63, 0);
            this.defectCode.Name = "defectCode";
            this.defectCode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.defectCode.RectColor = System.Drawing.Color.Red;
            this.defectCode.Size = new System.Drawing.Size(135, 35);
            this.defectCode.Style = Sunny.UI.UIStyle.Custom;
            this.defectCode.TabIndex = 53;
            this.defectCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workOrderNum
            // 
            this.workOrderNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workOrderNum.FillColor = System.Drawing.Color.White;
            this.workOrderNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workOrderNum.Location = new System.Drawing.Point(156, 542);
            this.workOrderNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workOrderNum.Maximum = 2147483647D;
            this.workOrderNum.Minimum = -2147483648D;
            this.workOrderNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.workOrderNum.Name = "workOrderNum";
            this.workOrderNum.Size = new System.Drawing.Size(135, 35);
            this.workOrderNum.TabIndex = 59;
            this.workOrderNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.Location = new System.Drawing.Point(14, 542);
            this.uiLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(135, 35);
            this.uiLabel11.TabIndex = 58;
            this.uiLabel11.Text = "작업지시번호";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(3, 315);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(278, 38);
            this.uiMarkLabel3.TabIndex = 60;
            this.uiMarkLabel3.Text = "소요 자재(BOM) 확인";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lviewBOM
            // 
            this.lviewBOM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lviewNum,
            this.lviewPNum,
            this.lviewCNum,
            this.lviewQuantity});
            this.lviewBOM.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lviewBOM.FullRowSelect = true;
            this.lviewBOM.GridLines = true;
            this.lviewBOM.HideSelection = false;
            this.lviewBOM.Location = new System.Drawing.Point(6, 356);
            this.lviewBOM.Name = "lviewBOM";
            this.lviewBOM.Size = new System.Drawing.Size(459, 134);
            this.lviewBOM.TabIndex = 61;
            this.lviewBOM.UseCompatibleStateImageBehavior = false;
            this.lviewBOM.View = System.Windows.Forms.View.Details;
            // 
            // lviewNum
            // 
            this.lviewNum.Text = "번호";
            this.lviewNum.Width = 80;
            // 
            // lviewPNum
            // 
            this.lviewPNum.Text = "모품번";
            this.lviewPNum.Width = 120;
            // 
            // lviewCNum
            // 
            this.lviewCNum.Text = "자품번";
            this.lviewCNum.Width = 120;
            // 
            // lviewQuantity
            // 
            this.lviewQuantity.Text = "수량";
            this.lviewQuantity.Width = 80;
            // 
            // machineCombo
            // 
            this.machineCombo.DataSource = null;
            this.machineCombo.FillColor = System.Drawing.Color.White;
            this.machineCombo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.machineCombo.Location = new System.Drawing.Point(131, 89);
            this.machineCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.machineCombo.MinimumSize = new System.Drawing.Size(63, 0);
            this.machineCombo.Name = "machineCombo";
            this.machineCombo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.machineCombo.Size = new System.Drawing.Size(210, 39);
            this.machineCombo.TabIndex = 62;
            this.machineCombo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddWorkedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.machineCombo);
            this.Controls.Add(this.lviewBOM);
            this.Controls.Add(this.uiMarkLabel3);
            this.Controls.Add(this.workOrderNum);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.defectQuantity);
            this.Controls.Add(this.defectCode);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.workedDate);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.workedQuantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.item);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.person);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.machinLine);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.addWorked);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.searchWork);
            this.Controls.Add(this.addedWorkListView);
            this.Controls.Add(this.uiLabel1);
            this.Name = "AddWorkedUI";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.AddWorkedUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader addedworkMachine;
        private System.Windows.Forms.ColumnHeader addedworkItem;
        private Sunny.UI.UIButton addWorked;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.ColumnHeader addedworkQuantity;
        private System.Windows.Forms.ColumnHeader addedworkDate;
        private System.Windows.Forms.ColumnHeader addedworkNote;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UISymbolButton searchWork;
        private System.Windows.Forms.ColumnHeader addedworkPerson;
        private System.Windows.Forms.ListView addedWorkListView;
        private System.Windows.Forms.ColumnHeader addedCompany;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox machinLine;
        private Sunny.UI.UITextBox person;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox item;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox quantity;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox workedQuantity;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIDatePicker workedDate;
        private System.Windows.Forms.ColumnHeader addedworkNumber;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox defectQuantity;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox defectCode;
        private Sunny.UI.UITextBox workOrderNum;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIMarkLabel uiMarkLabel3;
        private System.Windows.Forms.ListView lviewBOM;
        private System.Windows.Forms.ColumnHeader lviewNum;
        private System.Windows.Forms.ColumnHeader lviewPNum;
        private System.Windows.Forms.ColumnHeader lviewCNum;
        private System.Windows.Forms.ColumnHeader lviewQuantity;
        private Sunny.UI.UIComboBox machineCombo;
    }
}
