
namespace clutch_MES.UI
{
    partial class Item
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.itemNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchItem = new Sunny.UI.UISymbolButton();
            this.DeleteItem = new Sunny.UI.UISymbolButton();
            this.addItem = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumber1,
            this.itemCode1,
            this.itemName1});
            this.itemGridView.Location = new System.Drawing.Point(9, 87);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 23;
            this.itemGridView.Size = new System.Drawing.Size(445, 474);
            this.itemGridView.TabIndex = 75;
            // 
            // itemNumber1
            // 
            this.itemNumber1.HeaderText = "번호";
            this.itemNumber1.Name = "itemNumber1";
            // 
            // itemCode1
            // 
            this.itemCode1.HeaderText = "품번";
            this.itemCode1.Name = "itemCode1";
            // 
            // itemName1
            // 
            this.itemName1.HeaderText = "품명";
            this.itemName1.Name = "itemName1";
            // 
            // searchItem
            // 
            this.searchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchItem.Location = new System.Drawing.Point(9, 36);
            this.searchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(45, 45);
            this.searchItem.Symbol = 61442;
            this.searchItem.TabIndex = 74;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteItem.Location = new System.Drawing.Point(112, 36);
            this.DeleteItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(45, 45);
            this.DeleteItem.Symbol = 61944;
            this.DeleteItem.TabIndex = 73;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // addItem
            // 
            this.addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addItem.Location = new System.Drawing.Point(61, 36);
            this.addItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(45, 45);
            this.addItem.Symbol = 61639;
            this.addItem.TabIndex = 72;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel1.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel1.TabIndex = 71;
            this.uiMarkLabel1.Text = "생산 품목 기준정보";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private Sunny.UI.UISymbolButton searchItem;
        private Sunny.UI.UISymbolButton DeleteItem;
        private Sunny.UI.UISymbolButton addItem;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName1;
    }
}
