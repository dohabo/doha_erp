
namespace clutch_MES.UI.Details
{
    partial class CompanyUI
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
            this.companyGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.DeleteCompany = new Sunny.UI.UISymbolButton();
            this.addCompany = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyGridView
            // 
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.companyName});
            this.companyGridView.Location = new System.Drawing.Point(9, 87);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.RowTemplate.Height = 23;
            this.companyGridView.Size = new System.Drawing.Size(280, 474);
            this.companyGridView.TabIndex = 85;
            // 
            // number
            // 
            this.number.HeaderText = "사업장번호";
            this.number.Name = "number";
            // 
            // companyName
            // 
            this.companyName.HeaderText = "사업장명";
            this.companyName.Name = "companyName";
            this.companyName.Width = 120;
            // 
            // searchCompany
            // 
            this.searchCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchCompany.Location = new System.Drawing.Point(9, 36);
            this.searchCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchCompany.Name = "searchCompany";
            this.searchCompany.Size = new System.Drawing.Size(45, 45);
            this.searchCompany.Symbol = 61442;
            this.searchCompany.TabIndex = 84;
            this.searchCompany.Click += new System.EventHandler(this.searchCompany_Click);
            // 
            // DeleteCompany
            // 
            this.DeleteCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteCompany.Location = new System.Drawing.Point(112, 36);
            this.DeleteCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteCompany.Name = "DeleteCompany";
            this.DeleteCompany.Size = new System.Drawing.Size(45, 45);
            this.DeleteCompany.Symbol = 61944;
            this.DeleteCompany.TabIndex = 83;
            this.DeleteCompany.Click += new System.EventHandler(this.DeleteCompany_Click);
            // 
            // addCompany
            // 
            this.addCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCompany.Location = new System.Drawing.Point(61, 36);
            this.addCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(45, 45);
            this.addCompany.Symbol = 61639;
            this.addCompany.TabIndex = 82;
            this.addCompany.Click += new System.EventHandler(this.addCompany_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 81;
            this.uiMarkLabel1.Text = "사업장 등록 관리";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.searchCompany);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "CompanyUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView companyGridView;
        private Sunny.UI.UISymbolButton searchCompany;
        private Sunny.UI.UISymbolButton DeleteCompany;
        private Sunny.UI.UISymbolButton addCompany;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
    }
}
