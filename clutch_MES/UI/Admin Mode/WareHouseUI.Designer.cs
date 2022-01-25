
namespace clutch_MES.UI.Admin_Mode
{
    partial class WareHouseUI
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
            this.searchWarehouse = new Sunny.UI.UISymbolButton();
            this.DeleteWarehouse = new Sunny.UI.UISymbolButton();
            this.addWarehouse = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.warehouseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyGridView
            // 
            this.companyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseNum,
            this.warehouseName});
            this.companyGridView.Location = new System.Drawing.Point(9, 87);
            this.companyGridView.Name = "companyGridView";
            this.companyGridView.RowTemplate.Height = 23;
            this.companyGridView.Size = new System.Drawing.Size(280, 474);
            this.companyGridView.TabIndex = 90;
            // 
            // searchWarehouse
            // 
            this.searchWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWarehouse.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWarehouse.Location = new System.Drawing.Point(9, 36);
            this.searchWarehouse.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWarehouse.Name = "searchWarehouse";
            this.searchWarehouse.Size = new System.Drawing.Size(45, 45);
            this.searchWarehouse.Symbol = 61442;
            this.searchWarehouse.TabIndex = 89;
            // 
            // DeleteWarehouse
            // 
            this.DeleteWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWarehouse.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteWarehouse.Location = new System.Drawing.Point(112, 36);
            this.DeleteWarehouse.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteWarehouse.Name = "DeleteWarehouse";
            this.DeleteWarehouse.Size = new System.Drawing.Size(45, 45);
            this.DeleteWarehouse.Symbol = 61944;
            this.DeleteWarehouse.TabIndex = 88;
            // 
            // addWarehouse
            // 
            this.addWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWarehouse.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWarehouse.Location = new System.Drawing.Point(61, 36);
            this.addWarehouse.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWarehouse.Name = "addWarehouse";
            this.addWarehouse.Size = new System.Drawing.Size(45, 45);
            this.addWarehouse.Symbol = 61639;
            this.addWarehouse.TabIndex = 87;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 86;
            this.uiMarkLabel1.Text = "창고 등록 관리";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // warehouseNum
            // 
            this.warehouseNum.HeaderText = "창고번호";
            this.warehouseNum.Name = "warehouseNum";
            // 
            // warehouseName
            // 
            this.warehouseName.HeaderText = "창고";
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.Width = 120;
            // 
            // WareHouseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyGridView);
            this.Controls.Add(this.searchWarehouse);
            this.Controls.Add(this.DeleteWarehouse);
            this.Controls.Add(this.addWarehouse);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "WareHouseUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView companyGridView;
        private Sunny.UI.UISymbolButton searchWarehouse;
        private Sunny.UI.UISymbolButton DeleteWarehouse;
        private Sunny.UI.UISymbolButton addWarehouse;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseName;
    }
}
