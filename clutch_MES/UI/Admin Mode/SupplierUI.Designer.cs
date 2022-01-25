
namespace clutch_MES.UI.Admin_Mode
{
    partial class SupplierUI
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
            this.supplierGridView = new System.Windows.Forms.DataGridView();
            this.gridSupplierNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSellItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCEOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSupplier = new Sunny.UI.UISymbolButton();
            this.DeleteSupplier = new Sunny.UI.UISymbolButton();
            this.addSupplier = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierGridView
            // 
            this.supplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridSupplierNum,
            this.gridSupplierName,
            this.gridSellItem,
            this.gridCEOName,
            this.gridAddress});
            this.supplierGridView.Location = new System.Drawing.Point(14, 92);
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.RowTemplate.Height = 23;
            this.supplierGridView.Size = new System.Drawing.Size(683, 474);
            this.supplierGridView.TabIndex = 80;
            // 
            // gridSupplierNum
            // 
            this.gridSupplierNum.HeaderText = "거래처 번호";
            this.gridSupplierNum.Name = "gridSupplierNum";
            // 
            // gridSupplierName
            // 
            this.gridSupplierName.HeaderText = "거래처 이름";
            this.gridSupplierName.Name = "gridSupplierName";
            // 
            // gridSellItem
            // 
            this.gridSellItem.HeaderText = "취급품목";
            this.gridSellItem.Name = "gridSellItem";
            // 
            // gridCEOName
            // 
            this.gridCEOName.HeaderText = "대표이름";
            this.gridCEOName.Name = "gridCEOName";
            // 
            // gridAddress
            // 
            this.gridAddress.HeaderText = "주소";
            this.gridAddress.Name = "gridAddress";
            this.gridAddress.Width = 200;
            // 
            // searchSupplier
            // 
            this.searchSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchSupplier.Location = new System.Drawing.Point(14, 41);
            this.searchSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchSupplier.Name = "searchSupplier";
            this.searchSupplier.Size = new System.Drawing.Size(45, 45);
            this.searchSupplier.Symbol = 61442;
            this.searchSupplier.TabIndex = 79;
            this.searchSupplier.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // DeleteSupplier
            // 
            this.DeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteSupplier.Location = new System.Drawing.Point(117, 41);
            this.DeleteSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteSupplier.Name = "DeleteSupplier";
            this.DeleteSupplier.Size = new System.Drawing.Size(45, 45);
            this.DeleteSupplier.Symbol = 61944;
            this.DeleteSupplier.TabIndex = 78;
            this.DeleteSupplier.Click += new System.EventHandler(this.DeleteSupplier_Click);
            // 
            // addSupplier
            // 
            this.addSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSupplier.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addSupplier.Location = new System.Drawing.Point(66, 41);
            this.addSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(45, 45);
            this.addSupplier.Symbol = 61639;
            this.addSupplier.TabIndex = 77;
            this.addSupplier.Click += new System.EventHandler(this.addSupplier_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(10, 10);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 76;
            this.uiMarkLabel1.Text = "거래처 기준정보";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SupplierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierGridView);
            this.Controls.Add(this.searchSupplier);
            this.Controls.Add(this.DeleteSupplier);
            this.Controls.Add(this.addSupplier);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "SupplierUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierGridView;
        private Sunny.UI.UISymbolButton searchSupplier;
        private Sunny.UI.UISymbolButton DeleteSupplier;
        private Sunny.UI.UISymbolButton addSupplier;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSupplierNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSellItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCEOName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAddress;
    }
}
