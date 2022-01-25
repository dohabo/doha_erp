
namespace clutch_MES.UI
{
    partial class CheckWorkedUI
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
            this.searchWorked = new Sunny.UI.UISymbolButton();
            this.addWorkedListView = new System.Windows.Forms.ListView();
            this.workedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workMachine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workedQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defectQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addWorkDateFrom = new Sunny.UI.UIDatePicker();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.searchMachine = new Sunny.UI.UISymbolButton();
            this.addWorkNote = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.addCompany = new Sunny.UI.UITextBox();
            this.addWorkQuantity = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.addWorkItem = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.addWorkPerson = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchWorker = new Sunny.UI.UISymbolButton();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.addWorkMachine = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.addWorkDateTo = new Sunny.UI.UIDatePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchWorked
            // 
            this.searchWorked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorked.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorked.Location = new System.Drawing.Point(3, 3);
            this.searchWorked.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWorked.Name = "searchWorked";
            this.searchWorked.Size = new System.Drawing.Size(60, 60);
            this.searchWorked.Symbol = 61442;
            this.searchWorked.SymbolSize = 30;
            this.searchWorked.TabIndex = 49;
            this.searchWorked.Click += new System.EventHandler(this.searchWorked_Click);
            // 
            // addWorkedListView
            // 
            this.addWorkedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workedNum,
            this.workCompany,
            this.workMachine,
            this.workPerson,
            this.workItem,
            this.workQuantity,
            this.workDate,
            this.workedDate,
            this.workedQuantity,
            this.defectQuantity,
            this.defectType,
            this.workNote});
            this.addWorkedListView.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addWorkedListView.GridLines = true;
            this.addWorkedListView.HideSelection = false;
            this.addWorkedListView.Location = new System.Drawing.Point(7, 223);
            this.addWorkedListView.Name = "addWorkedListView";
            this.addWorkedListView.Size = new System.Drawing.Size(1140, 377);
            this.addWorkedListView.TabIndex = 50;
            this.addWorkedListView.UseCompatibleStateImageBehavior = false;
            this.addWorkedListView.View = System.Windows.Forms.View.Details;
            // 
            // workedNum
            // 
            this.workedNum.Text = "작업 번호";
            // 
            // workCompany
            // 
            this.workCompany.Text = "작업장";
            this.workCompany.Width = 50;
            // 
            // workMachine
            // 
            this.workMachine.Text = "설비라인";
            this.workMachine.Width = 80;
            // 
            // workPerson
            // 
            this.workPerson.Text = "작업자";
            this.workPerson.Width = 80;
            // 
            // workItem
            // 
            this.workItem.Text = "생산품목";
            this.workItem.Width = 80;
            // 
            // workQuantity
            // 
            this.workQuantity.Text = "생산수량";
            this.workQuantity.Width = 80;
            // 
            // workDate
            // 
            this.workDate.Text = "생산요구일";
            this.workDate.Width = 100;
            // 
            // workedDate
            // 
            this.workedDate.Text = "작업 일자";
            this.workedDate.Width = 100;
            // 
            // workedQuantity
            // 
            this.workedQuantity.Text = "작업수량";
            this.workedQuantity.Width = 80;
            // 
            // defectQuantity
            // 
            this.defectQuantity.Text = "불량수량";
            this.defectQuantity.Width = 80;
            // 
            // defectType
            // 
            this.defectType.Text = "불량 유형";
            this.defectType.Width = 80;
            // 
            // workNote
            // 
            this.workNote.Text = "특이사항";
            this.workNote.Width = 80;
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
            this.addWorkNote.Location = new System.Drawing.Point(801, 34);
            this.addWorkNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addWorkNote.Maximum = 2147483647D;
            this.addWorkNote.Minimum = -2147483648D;
            this.addWorkNote.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkNote.Multiline = true;
            this.addWorkNote.Name = "addWorkNote";
            this.addWorkNote.Size = new System.Drawing.Size(336, 86);
            this.addWorkNote.TabIndex = 16;
            this.addWorkNote.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorkNote.TextChanged += new System.EventHandler(this.addWorkNote_TextChanged);
            // 
            // uiLabel8
            // 
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel8.Location = new System.Drawing.Point(801, 3);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(106, 35);
            this.uiLabel8.TabIndex = 16;
            this.uiLabel8.Text = "특이사항";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.Click += new System.EventHandler(this.uiLabel8_Click);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 197);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel2.TabIndex = 51;
            this.uiMarkLabel2.Text = "작업 내역";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.TabIndex = 47;
            // 
            // searchWorker
            // 
            this.searchWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorker.Location = new System.Drawing.Point(224, 86);
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
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(135, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 46;
            this.uiLabel1.Text = "작업 내역 검색";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addWorkDateTo
            // 
            this.addWorkDateTo.FillColor = System.Drawing.Color.White;
            this.addWorkDateTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkDateTo.Location = new System.Drawing.Point(569, 85);
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
            // CheckWorkedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchWorked);
            this.Controls.Add(this.addWorkedListView);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiLabel1);
            this.Name = "CheckWorkedUI";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.CheckWorkedUI_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton searchWorked;
        private System.Windows.Forms.ListView addWorkedListView;
        private System.Windows.Forms.ColumnHeader workMachine;
        private System.Windows.Forms.ColumnHeader workPerson;
        private System.Windows.Forms.ColumnHeader workItem;
        private System.Windows.Forms.ColumnHeader workQuantity;
        private System.Windows.Forms.ColumnHeader workedQuantity;
        private System.Windows.Forms.ColumnHeader workDate;
        private System.Windows.Forms.ColumnHeader workedDate;
        private System.Windows.Forms.ColumnHeader workNote;
        private Sunny.UI.UIDatePicker addWorkDateFrom;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UISymbolButton searchMachine;
        private Sunny.UI.UITextBox addWorkNote;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox addCompany;
        private Sunny.UI.UITextBox addWorkQuantity;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox addWorkItem;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox addWorkPerson;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UITextBox addWorkMachine;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton searchWorker;
        private Sunny.UI.UISymbolButton searchCompany;
        private System.Windows.Forms.ColumnHeader workedNum;
        private System.Windows.Forms.ColumnHeader defectQuantity;
        private System.Windows.Forms.ColumnHeader defectType;
        private System.Windows.Forms.ColumnHeader workCompany;
        private Sunny.UI.UIDatePicker addWorkDateTo;
    }
}
