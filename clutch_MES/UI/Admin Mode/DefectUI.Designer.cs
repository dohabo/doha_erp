
namespace clutch_MES.UI.Details
{
    partial class DefectUI
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
            this.defectGridView = new System.Windows.Forms.DataGridView();
            this.defectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchDefect = new Sunny.UI.UISymbolButton();
            this.DeleteDefect = new Sunny.UI.UISymbolButton();
            this.addDefect = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.defectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // defectGridView
            // 
            this.defectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defectGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.defectCode,
            this.defectName});
            this.defectGridView.Location = new System.Drawing.Point(9, 86);
            this.defectGridView.Name = "defectGridView";
            this.defectGridView.RowTemplate.Height = 23;
            this.defectGridView.Size = new System.Drawing.Size(339, 474);
            this.defectGridView.TabIndex = 80;
            // 
            // defectCode
            // 
            this.defectCode.HeaderText = "불량유형코드";
            this.defectCode.Name = "defectCode";
            this.defectCode.Width = 120;
            // 
            // defectName
            // 
            this.defectName.HeaderText = "불량 유형명";
            this.defectName.Name = "defectName";
            this.defectName.Width = 150;
            // 
            // searchDefect
            // 
            this.searchDefect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchDefect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchDefect.Location = new System.Drawing.Point(9, 35);
            this.searchDefect.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchDefect.Name = "searchDefect";
            this.searchDefect.Size = new System.Drawing.Size(45, 45);
            this.searchDefect.Symbol = 61442;
            this.searchDefect.TabIndex = 79;
            this.searchDefect.Click += new System.EventHandler(this.searchDefect_Click);
            // 
            // DeleteDefect
            // 
            this.DeleteDefect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDefect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteDefect.Location = new System.Drawing.Point(112, 35);
            this.DeleteDefect.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteDefect.Name = "DeleteDefect";
            this.DeleteDefect.Size = new System.Drawing.Size(45, 45);
            this.DeleteDefect.Symbol = 61944;
            this.DeleteDefect.TabIndex = 78;
            this.DeleteDefect.Click += new System.EventHandler(this.DeleteDefect_Click);
            // 
            // addDefect
            // 
            this.addDefect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDefect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDefect.Location = new System.Drawing.Point(61, 35);
            this.addDefect.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDefect.Name = "addDefect";
            this.addDefect.Size = new System.Drawing.Size(45, 45);
            this.addDefect.Symbol = 61639;
            this.addDefect.TabIndex = 77;
            this.addDefect.Click += new System.EventHandler(this.addDefect_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 76;
            this.uiMarkLabel1.Text = "불량 유형 기준정보";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DefectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defectGridView);
            this.Controls.Add(this.searchDefect);
            this.Controls.Add(this.DeleteDefect);
            this.Controls.Add(this.addDefect);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "DefectUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.defectGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView defectGridView;
        private Sunny.UI.UISymbolButton searchDefect;
        private Sunny.UI.UISymbolButton DeleteDefect;
        private Sunny.UI.UISymbolButton addDefect;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn defectName;
    }
}
