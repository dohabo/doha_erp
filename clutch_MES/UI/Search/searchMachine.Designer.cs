
namespace clutch_MES.UI.Search
{
    partial class searchMachine
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.name = new Sunny.UI.UITextBox();
            this.machineListView = new System.Windows.Forms.ListView();
            this.lineNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.machineLineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
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
            this.mini.Location = new System.Drawing.Point(298, 28);
            this.mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.mini.Name = "mini";
            this.mini.RectColor = System.Drawing.Color.Transparent;
            this.mini.RectHoverColor = System.Drawing.Color.Black;
            this.mini.Size = new System.Drawing.Size(25, 25);
            this.mini.Style = Sunny.UI.UIStyle.Custom;
            this.mini.Symbol = 62161;
            this.mini.TabIndex = 64;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.ForeHoverColor = System.Drawing.Color.DarkGray;
            this.close.Location = new System.Drawing.Point(332, 28);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.RectColor = System.Drawing.Color.Transparent;
            this.close.RectHoverColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.Style = Sunny.UI.UIStyle.Custom;
            this.close.Symbol = 61453;
            this.close.TabIndex = 63;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.search.Location = new System.Drawing.Point(289, 100);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 40);
            this.search.TabIndex = 62;
            this.search.Text = "검색";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(29, 100);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 40);
            this.uiLabel2.TabIndex = 61;
            this.uiLabel2.Text = "설비 라인명";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(136, 100);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Maximum = 2147483647D;
            this.name.Minimum = -2147483648D;
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 40);
            this.name.TabIndex = 60;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // machineListView
            // 
            this.machineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lineNum,
            this.machineLineName});
            this.machineListView.FullRowSelect = true;
            this.machineListView.GridLines = true;
            this.machineListView.HideSelection = false;
            this.machineListView.Location = new System.Drawing.Point(33, 148);
            this.machineListView.Name = "machineListView";
            this.machineListView.Size = new System.Drawing.Size(321, 254);
            this.machineListView.TabIndex = 59;
            this.machineListView.UseCompatibleStateImageBehavior = false;
            this.machineListView.View = System.Windows.Forms.View.Details;
            this.machineListView.DoubleClick += new System.EventHandler(this.machineListView_DoubleClick_1);
            // 
            // lineNum
            // 
            this.lineNum.Text = "설비라인번호";
            this.lineNum.Width = 100;
            // 
            // machineLineName
            // 
            this.machineLineName.Text = "설비라인명";
            this.machineLineName.Width = 200;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(26, 28);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 58;
            this.uiLabel1.Text = "설비 라인 검색";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mini);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.machineListView);
            this.Controls.Add(this.uiLabel1);
            this.Name = "searchMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchMachine";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton mini;
        private Sunny.UI.UISymbolButton close;
        private Sunny.UI.UIButton search;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox name;
        private System.Windows.Forms.ListView machineListView;
        private System.Windows.Forms.ColumnHeader machineLine;
        private System.Windows.Forms.ColumnHeader machineLineName;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ColumnHeader lineNum;
    }
}