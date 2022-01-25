
namespace clutch_MES.UI
{
    partial class UIHome
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.noticeListView = new System.Windows.Forms.ListView();
            this.noticeNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noticeTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noticeMakeBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noticeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemListView = new System.Windows.Forms.ListView();
            this.itemNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemWorkedQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.record = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LineListView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.machineLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workedQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.line_record = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.items = new Sunny.UI.UIComboBox();
            this.line = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(43, 75);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(126, 35);
            this.uiSymbolLabel1.TabIndex = 1;
            this.uiSymbolLabel1.Text = "공지사항";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(524, 470);
            this.uiSymbolLabel4.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(269, 35);
            this.uiSymbolLabel4.TabIndex = 6;
            this.uiSymbolLabel4.Text = "계획대비 생산 현황(라인별)";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.Location = new System.Drawing.Point(528, 75);
            this.uiSymbolLabel5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(165, 35);
            this.uiSymbolLabel5.TabIndex = 5;
            this.uiSymbolLabel5.Text = "불량유형 TOP";
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.White;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.Location = new System.Drawing.Point(43, 470);
            this.uiSymbolLabel6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(275, 35);
            this.uiSymbolLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel6.TabIndex = 4;
            this.uiSymbolLabel6.Text = "계획대비 생산 현황(ITEM별)";
            // 
            // noticeListView
            // 
            this.noticeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.noticeNumber,
            this.noticeTitle,
            this.noticeMakeBy,
            this.noticeDate});
            this.noticeListView.GridLines = true;
            this.noticeListView.HideSelection = false;
            this.noticeListView.Location = new System.Drawing.Point(43, 118);
            this.noticeListView.Name = "noticeListView";
            this.noticeListView.Size = new System.Drawing.Size(475, 259);
            this.noticeListView.TabIndex = 7;
            this.noticeListView.UseCompatibleStateImageBehavior = false;
            this.noticeListView.View = System.Windows.Forms.View.Details;
            // 
            // noticeNumber
            // 
            this.noticeNumber.Text = "번호";
            // 
            // noticeTitle
            // 
            this.noticeTitle.Text = "제목";
            this.noticeTitle.Width = 200;
            // 
            // noticeMakeBy
            // 
            this.noticeMakeBy.Text = "작성자";
            this.noticeMakeBy.Width = 100;
            // 
            // noticeDate
            // 
            this.noticeDate.Text = "작성일";
            this.noticeDate.Width = 100;
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemNumber,
            this.itemItem,
            this.itemName,
            this.itemQuantity,
            this.itemWorkedQuantity,
            this.record});
            this.itemListView.GridLines = true;
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(43, 557);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(425, 174);
            this.itemListView.TabIndex = 10;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // itemNumber
            // 
            this.itemNumber.Text = "번호";
            this.itemNumber.Width = 50;
            // 
            // itemItem
            // 
            this.itemItem.Text = "품번";
            this.itemItem.Width = 80;
            // 
            // itemName
            // 
            this.itemName.Text = "품명";
            this.itemName.Width = 100;
            // 
            // itemQuantity
            // 
            this.itemQuantity.Text = "계획수량";
            // 
            // itemWorkedQuantity
            // 
            this.itemWorkedQuantity.Text = "실적수량";
            // 
            // record
            // 
            this.record.Text = "생산실적";
            // 
            // LineListView
            // 
            this.LineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.machineLine,
            this.quantity,
            this.workedQuantity,
            this.line_record});
            this.LineListView.GridLines = true;
            this.LineListView.HideSelection = false;
            this.LineListView.Location = new System.Drawing.Point(524, 557);
            this.LineListView.Name = "LineListView";
            this.LineListView.Size = new System.Drawing.Size(423, 174);
            this.LineListView.TabIndex = 11;
            this.LineListView.UseCompatibleStateImageBehavior = false;
            this.LineListView.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "번호";
            this.number.Width = 50;
            // 
            // machineLine
            // 
            this.machineLine.Text = "설비라인";
            this.machineLine.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "계획수량";
            this.quantity.Width = 100;
            // 
            // workedQuantity
            // 
            this.workedQuantity.Text = "실적수량";
            this.workedQuantity.Width = 100;
            // 
            // line_record
            // 
            this.line_record.Text = "생산실적";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clutch_MES.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1137, 751);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(43, 510);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(118, 39);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "품목명";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // items
            // 
            this.items.DataSource = null;
            this.items.FillColor = System.Drawing.Color.White;
            this.items.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.items.Items.AddRange(new object[] {
            "전체"});
            this.items.Location = new System.Drawing.Point(168, 510);
            this.items.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.items.MinimumSize = new System.Drawing.Size(63, 0);
            this.items.Name = "items";
            this.items.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.items.Size = new System.Drawing.Size(150, 40);
            this.items.TabIndex = 14;
            this.items.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.items.TextChanged += new System.EventHandler(this.items_TextChanged);
            // 
            // line
            // 
            this.line.DataSource = null;
            this.line.FillColor = System.Drawing.Color.White;
            this.line.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.line.Items.AddRange(new object[] {
            "전체"});
            this.line.Location = new System.Drawing.Point(657, 509);
            this.line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.line.MinimumSize = new System.Drawing.Size(63, 0);
            this.line.Name = "line";
            this.line.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.line.Size = new System.Drawing.Size(136, 40);
            this.line.TabIndex = 16;
            this.line.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.line.TextChanged += new System.EventHandler(this.line_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(524, 510);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(126, 39);
            this.uiLabel2.TabIndex = 15;
            this.uiLabel2.Text = "설비라인";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiPieChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiPieChart1.Location = new System.Drawing.Point(528, 118);
            this.uiPieChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.Size = new System.Drawing.Size(419, 259);
            this.uiPieChart1.TabIndex = 17;
            this.uiPieChart1.Text = "uiPieChart1";
            // 
            // UIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPieChart1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.items);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.LineListView);
            this.Controls.Add(this.itemListView);
            this.Controls.Add(this.noticeListView);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "UIHome";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.UIHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private System.Windows.Forms.ListView noticeListView;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ListView LineListView;
        private System.Windows.Forms.ColumnHeader noticeNumber;
        private System.Windows.Forms.ColumnHeader noticeTitle;
        private System.Windows.Forms.ColumnHeader noticeMakeBy;
        private System.Windows.Forms.ColumnHeader itemNumber;
        private System.Windows.Forms.ColumnHeader itemItem;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemQuantity;
        private System.Windows.Forms.ColumnHeader itemWorkedQuantity;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader machineLine;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader workedQuantity;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox items;
        private Sunny.UI.UIComboBox line;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.ColumnHeader noticeDate;
        private Sunny.UI.UIPieChart uiPieChart1;
        private System.Windows.Forms.ColumnHeader record;
        private System.Windows.Forms.ColumnHeader line_record;
    }
}
