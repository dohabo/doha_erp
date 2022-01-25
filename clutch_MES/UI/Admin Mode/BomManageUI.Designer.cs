
namespace clutch_MES.UI.Admin_Mode
{
    partial class BomManageUI
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
            this.bomGridView = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBOM = new Sunny.UI.UISymbolButton();
            this.DeleteBOM = new Sunny.UI.UISymbolButton();
            this.addBOM = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.searchParentsCode = new Sunny.UI.UISymbolButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.tboxParentsCode = new Sunny.UI.UITextBox();
            this.tboxParentsName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.searchChildCode = new Sunny.UI.UISymbolButton();
            this.tboxChildCode = new Sunny.UI.UITextBox();
            this.tboxChildName = new Sunny.UI.UITextBox();
            this.AddParentsCode = new Sunny.UI.UISymbolButton();
            this.AddChildeCode = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.bomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bomGridView
            // 
            this.bomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bomGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.parentscode,
            this.childCode,
            this.quantity});
            this.bomGridView.Location = new System.Drawing.Point(9, 172);
            this.bomGridView.Name = "bomGridView";
            this.bomGridView.RowTemplate.Height = 23;
            this.bomGridView.Size = new System.Drawing.Size(604, 474);
            this.bomGridView.TabIndex = 85;
            this.bomGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bomGridView_RowEnter);
            this.bomGridView.Enter += new System.EventHandler(this.defectGridView_Enter);
            this.bomGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bomGridView_KeyDown);
            // 
            // num
            // 
            this.num.HeaderText = "순번";
            this.num.Name = "num";
            this.num.Width = 120;
            // 
            // parentscode
            // 
            this.parentscode.HeaderText = "모품번";
            this.parentscode.Name = "parentscode";
            this.parentscode.Width = 150;
            // 
            // childCode
            // 
            this.childCode.HeaderText = "자품번";
            this.childCode.Name = "childCode";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "수량";
            this.quantity.Name = "quantity";
            // 
            // searchBOM
            // 
            this.searchBOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBOM.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchBOM.Location = new System.Drawing.Point(9, 35);
            this.searchBOM.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchBOM.Name = "searchBOM";
            this.searchBOM.Size = new System.Drawing.Size(45, 45);
            this.searchBOM.Symbol = 61442;
            this.searchBOM.TabIndex = 84;
            this.searchBOM.Click += new System.EventHandler(this.searchBOM_Click);
            // 
            // DeleteBOM
            // 
            this.DeleteBOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBOM.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteBOM.Location = new System.Drawing.Point(112, 35);
            this.DeleteBOM.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteBOM.Name = "DeleteBOM";
            this.DeleteBOM.Size = new System.Drawing.Size(45, 45);
            this.DeleteBOM.Symbol = 61944;
            this.DeleteBOM.TabIndex = 83;
            this.DeleteBOM.Click += new System.EventHandler(this.DeleteBOM_Click);
            // 
            // addBOM
            // 
            this.addBOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBOM.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addBOM.Location = new System.Drawing.Point(61, 35);
            this.addBOM.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBOM.Name = "addBOM";
            this.addBOM.Size = new System.Drawing.Size(45, 45);
            this.addBOM.Symbol = 61639;
            this.addBOM.TabIndex = 82;
            this.addBOM.Click += new System.EventHandler(this.addBOM_Click);
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
            this.uiMarkLabel1.Text = "BOM 기준 정보";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchParentsCode
            // 
            this.searchParentsCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchParentsCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchParentsCode.Location = new System.Drawing.Point(225, 87);
            this.searchParentsCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchParentsCode.Name = "searchParentsCode";
            this.searchParentsCode.Size = new System.Drawing.Size(34, 35);
            this.searchParentsCode.Symbol = 61442;
            this.searchParentsCode.TabIndex = 88;
            this.searchParentsCode.Click += new System.EventHandler(this.searchParentsCode_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(3, 86);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 35);
            this.uiLabel2.TabIndex = 86;
            this.uiLabel2.Text = "모품목";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxParentsCode
            // 
            this.tboxParentsCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxParentsCode.FillColor = System.Drawing.Color.White;
            this.tboxParentsCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxParentsCode.Location = new System.Drawing.Point(84, 86);
            this.tboxParentsCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxParentsCode.Maximum = 2147483647D;
            this.tboxParentsCode.Minimum = -2147483648D;
            this.tboxParentsCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxParentsCode.Name = "tboxParentsCode";
            this.tboxParentsCode.Size = new System.Drawing.Size(134, 36);
            this.tboxParentsCode.TabIndex = 87;
            this.tboxParentsCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tboxParentsCode.TextChanged += new System.EventHandler(this.tboxParentsCode_TextChanged);
            // 
            // tboxParentsName
            // 
            this.tboxParentsName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxParentsName.Enabled = false;
            this.tboxParentsName.FillColor = System.Drawing.Color.White;
            this.tboxParentsName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxParentsName.Location = new System.Drawing.Point(287, 87);
            this.tboxParentsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxParentsName.Maximum = 2147483647D;
            this.tboxParentsName.Minimum = -2147483648D;
            this.tboxParentsName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxParentsName.Name = "tboxParentsName";
            this.tboxParentsName.Size = new System.Drawing.Size(134, 36);
            this.tboxParentsName.TabIndex = 88;
            this.tboxParentsName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(5, 127);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 35);
            this.uiLabel1.TabIndex = 89;
            this.uiLabel1.Text = "자품목";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchChildCode
            // 
            this.searchChildCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchChildCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchChildCode.Location = new System.Drawing.Point(225, 128);
            this.searchChildCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchChildCode.Name = "searchChildCode";
            this.searchChildCode.Size = new System.Drawing.Size(34, 35);
            this.searchChildCode.Symbol = 61442;
            this.searchChildCode.TabIndex = 90;
            this.searchChildCode.Click += new System.EventHandler(this.searchChildCode_Click);
            // 
            // tboxChildCode
            // 
            this.tboxChildCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxChildCode.FillColor = System.Drawing.Color.White;
            this.tboxChildCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxChildCode.Location = new System.Drawing.Point(84, 127);
            this.tboxChildCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxChildCode.Maximum = 2147483647D;
            this.tboxChildCode.Minimum = -2147483648D;
            this.tboxChildCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxChildCode.Name = "tboxChildCode";
            this.tboxChildCode.Size = new System.Drawing.Size(134, 36);
            this.tboxChildCode.TabIndex = 89;
            this.tboxChildCode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tboxChildCode.TextChanged += new System.EventHandler(this.tboxChildCode_TextChanged);
            // 
            // tboxChildName
            // 
            this.tboxChildName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxChildName.Enabled = false;
            this.tboxChildName.FillColor = System.Drawing.Color.White;
            this.tboxChildName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tboxChildName.Location = new System.Drawing.Point(287, 128);
            this.tboxChildName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxChildName.Maximum = 2147483647D;
            this.tboxChildName.Minimum = -2147483648D;
            this.tboxChildName.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxChildName.Name = "tboxChildName";
            this.tboxChildName.Size = new System.Drawing.Size(134, 36);
            this.tboxChildName.TabIndex = 89;
            this.tboxChildName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddParentsCode
            // 
            this.AddParentsCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddParentsCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddParentsCode.Location = new System.Drawing.Point(428, 87);
            this.AddParentsCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddParentsCode.Name = "AddParentsCode";
            this.AddParentsCode.Size = new System.Drawing.Size(35, 35);
            this.AddParentsCode.Symbol = 363620;
            this.AddParentsCode.TabIndex = 91;
            this.AddParentsCode.Click += new System.EventHandler(this.AddParentsCode_Click);
            // 
            // AddChildeCode
            // 
            this.AddChildeCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddChildeCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AddChildeCode.Location = new System.Drawing.Point(428, 129);
            this.AddChildeCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.AddChildeCode.Name = "AddChildeCode";
            this.AddChildeCode.Size = new System.Drawing.Size(35, 35);
            this.AddChildeCode.Symbol = 363620;
            this.AddChildeCode.TabIndex = 92;
            this.AddChildeCode.Click += new System.EventHandler(this.AddChildeCode_Click);
            // 
            // BomManageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddChildeCode);
            this.Controls.Add(this.AddParentsCode);
            this.Controls.Add(this.tboxChildName);
            this.Controls.Add(this.searchChildCode);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.tboxChildCode);
            this.Controls.Add(this.tboxParentsName);
            this.Controls.Add(this.searchParentsCode);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.tboxParentsCode);
            this.Controls.Add(this.bomGridView);
            this.Controls.Add(this.searchBOM);
            this.Controls.Add(this.DeleteBOM);
            this.Controls.Add(this.addBOM);
            this.Controls.Add(this.uiMarkLabel1);
            this.Name = "BomManageUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.bomGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bomGridView;
        private Sunny.UI.UISymbolButton searchBOM;
        private Sunny.UI.UISymbolButton DeleteBOM;
        private Sunny.UI.UISymbolButton addBOM;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UISymbolButton searchParentsCode;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tboxParentsCode;
        private Sunny.UI.UITextBox tboxParentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn childCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton searchChildCode;
        private Sunny.UI.UITextBox tboxChildCode;
        private Sunny.UI.UITextBox tboxChildName;
        private Sunny.UI.UISymbolButton AddParentsCode;
        private Sunny.UI.UISymbolButton AddChildeCode;
    }
}
