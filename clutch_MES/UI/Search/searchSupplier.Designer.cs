
namespace clutch_MES.UI.Search
{
    partial class searchSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mini = new Sunny.UI.UISymbolButton();
            this.close = new Sunny.UI.UISymbolButton();
            this.search = new Sunny.UI.UIButton();
            this.supplierListView = new System.Windows.Forms.ListView();
            this.listSupplierNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSupplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSupplierItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCEOName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // mini
            // 
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini.FillColor = System.Drawing.Color.Transparent;
            this.mini.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mini.ForeColor = System.Drawing.Color.Black;
            this.mini.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.mini.Location = new System.Drawing.Point(499, 9);
            this.mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.mini.Name = "mini";
            this.mini.RectColor = System.Drawing.Color.Transparent;
            this.mini.RectHoverColor = System.Drawing.Color.Black;
            this.mini.Size = new System.Drawing.Size(25, 25);
            this.mini.Style = Sunny.UI.UIStyle.Custom;
            this.mini.Symbol = 62161;
            this.mini.TabIndex = 78;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.close.Location = new System.Drawing.Point(533, 9);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.RectColor = System.Drawing.Color.Transparent;
            this.close.RectHoverColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.Style = Sunny.UI.UIStyle.Custom;
            this.close.Symbol = 61453;
            this.close.TabIndex = 77;
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.search.Location = new System.Drawing.Point(276, 83);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 40);
            this.search.TabIndex = 76;
            this.search.Text = "검색";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // supplierListView
            // 
            this.supplierListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listSupplierNumber,
            this.listSupplierName,
            this.listSupplierItem,
            this.listCEOName,
            this.listAddress});
            this.supplierListView.FullRowSelect = true;
            this.supplierListView.GridLines = true;
            this.supplierListView.HideSelection = false;
            this.supplierListView.Location = new System.Drawing.Point(19, 131);
            this.supplierListView.Name = "supplierListView";
            this.supplierListView.Size = new System.Drawing.Size(529, 254);
            this.supplierListView.TabIndex = 74;
            this.supplierListView.UseCompatibleStateImageBehavior = false;
            this.supplierListView.View = System.Windows.Forms.View.Details;
            // 
            // listSupplierNumber
            // 
            this.listSupplierNumber.Text = "거래처번호";
            this.listSupplierNumber.Width = 100;
            // 
            // listSupplierName
            // 
            this.listSupplierName.Text = "거래처명";
            this.listSupplierName.Width = 80;
            // 
            // listSupplierItem
            // 
            this.listSupplierItem.Text = "취급품목";
            this.listSupplierItem.Width = 100;
            // 
            // listCEOName
            // 
            this.listCEOName.Text = "대표자명";
            this.listCEOName.Width = 100;
            // 
            // listAddress
            // 
            this.listAddress.Text = "주소";
            this.listAddress.Width = 150;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 73;
            this.uiLabel1.Text = "거래처 검색";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(122, 83);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Maximum = 2147483647D;
            this.name.Minimum = -2147483648D;
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 40);
            this.name.TabIndex = 75;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(15, 83);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 40);
            this.uiLabel3.TabIndex = 79;
            this.uiLabel3.Text = "거래처명";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 427);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.supplierListView);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.uiLabel3);
            this.Name = "searchSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchSupplier";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton mini;
        private Sunny.UI.UISymbolButton close;
        private Sunny.UI.UIButton search;
        private System.Windows.Forms.ListView supplierListView;
        private System.Windows.Forms.ColumnHeader listSupplierNumber;
        private System.Windows.Forms.ColumnHeader listSupplierName;
        private System.Windows.Forms.ColumnHeader listSupplierItem;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.ColumnHeader listCEOName;
        private System.Windows.Forms.ColumnHeader listAddress;
    }
}