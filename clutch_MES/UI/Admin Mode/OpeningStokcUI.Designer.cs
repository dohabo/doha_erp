
namespace clutch_MES.UI.Admin_Mode
{
    partial class OpeningStokcUI
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
            this.searchCompany = new Sunny.UI.UISymbolButton();
            this.DeleteCompany = new Sunny.UI.UISymbolButton();
            this.addCompany = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyGridView
            // 
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCode,
            this.quantity,
            this.warehouseNum});
            this.companyGridView.Location = new System.Drawing.Point(9, 87);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.RowTemplate.Height = 23;
            this.companyGridView.Size = new System.Drawing.Size(369, 474);
            this.companyGridView.TabIndex = 95;
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
            this.searchCompany.TabIndex = 94;
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
            this.DeleteCompany.TabIndex = 93;
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
            this.addCompany.TabIndex = 92;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 91;
            this.uiMarkLabel1.Text = "기초 재고 등록";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "품번";
            this.itemCode.Name = "itemCode";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "수량";
            this.quantity.Name = "quantity";
            // 
            // warehouseNum
            // 
            this.warehouseNum.HeaderText = "입고 창고번호";
            this.warehouseNum.Name = "warehouseNum";
            this.warehouseNum.Width = 120;
            // 
            // OpeningStokcUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.searchCompany);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "OpeningStokcUI";
            this.Size = new System.Drawing.Size(858, 661);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView companyGridView;
        private Sunny.UI.UISymbolButton searchCompany;
        private Sunny.UI.UISymbolButton DeleteCompany;
        private Sunny.UI.UISymbolButton addCompany;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNum;
    }
}
