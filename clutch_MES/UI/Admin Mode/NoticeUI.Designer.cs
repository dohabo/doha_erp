
namespace clutch_MES.UI
{
    partial class NoticeUI
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
            this.noticeGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searcNotice = new Sunny.UI.UISymbolButton();
            this.DeleteNotice = new Sunny.UI.UISymbolButton();
            this.addNotice = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.noticeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noticeGridView
            // 
            this.noticeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noticeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.title,
            this.name,
            this.date});
            this.noticeGridView.Location = new System.Drawing.Point(9, 87);
            this.noticeGridView.Name = "noticeGridView";
            this.noticeGridView.RowTemplate.Height = 23;
            this.noticeGridView.Size = new System.Drawing.Size(860, 150);
            this.noticeGridView.TabIndex = 75;
            // 
            // number
            // 
            this.number.HeaderText = "번호";
            this.number.Name = "number";
            // 
            // title
            // 
            this.title.HeaderText = "내용";
            this.title.Name = "title";
            this.title.Width = 350;
            // 
            // name
            // 
            this.name.HeaderText = "작성자";
            this.name.Name = "name";
            // 
            // date
            // 
            this.date.HeaderText = "작성일";
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // searcNotice
            // 
            this.searcNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searcNotice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searcNotice.Location = new System.Drawing.Point(9, 36);
            this.searcNotice.MinimumSize = new System.Drawing.Size(1, 1);
            this.searcNotice.Name = "searcNotice";
            this.searcNotice.Size = new System.Drawing.Size(45, 45);
            this.searcNotice.Symbol = 61442;
            this.searcNotice.TabIndex = 80;
            this.searcNotice.Click += new System.EventHandler(this.searcNotice_Click);
            // 
            // DeleteNotice
            // 
            this.DeleteNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNotice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteNotice.Location = new System.Drawing.Point(112, 36);
            this.DeleteNotice.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteNotice.Name = "DeleteNotice";
            this.DeleteNotice.Size = new System.Drawing.Size(45, 45);
            this.DeleteNotice.Symbol = 61944;
            this.DeleteNotice.TabIndex = 79;
            this.DeleteNotice.Click += new System.EventHandler(this.DeleteNotice_Click);
            // 
            // addNotice
            // 
            this.addNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNotice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addNotice.Location = new System.Drawing.Point(61, 36);
            this.addNotice.MinimumSize = new System.Drawing.Size(1, 1);
            this.addNotice.Name = "addNotice";
            this.addNotice.Size = new System.Drawing.Size(45, 45);
            this.addNotice.Symbol = 61639;
            this.addNotice.TabIndex = 78;
            this.addNotice.Click += new System.EventHandler(this.addNotice_Click);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel2.TabIndex = 81;
            this.uiMarkLabel2.Text = "공지사항 관리";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoticeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.searcNotice);
            this.Controls.Add(this.DeleteNotice);
            this.Controls.Add(this.addNotice);
            this.Controls.Add(this.noticeGridView);
            this.Name = "NoticeUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.noticeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView noticeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private Sunny.UI.UISymbolButton searcNotice;
        private Sunny.UI.UISymbolButton DeleteNotice;
        private Sunny.UI.UISymbolButton addNotice;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
    }
}
