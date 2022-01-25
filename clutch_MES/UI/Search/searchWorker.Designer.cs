
namespace clutch_MES.UI.Search
{
    partial class searchWorker
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
            this.workerListView = new System.Windows.Forms.ListView();
            this.worker_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.worker_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.workerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.worker_inCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.mini.Location = new System.Drawing.Point(296, 38);
            this.mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.mini.Name = "mini";
            this.mini.RectColor = System.Drawing.Color.Transparent;
            this.mini.RectHoverColor = System.Drawing.Color.Black;
            this.mini.Size = new System.Drawing.Size(25, 25);
            this.mini.Style = Sunny.UI.UIStyle.Custom;
            this.mini.Symbol = 62161;
            this.mini.TabIndex = 71;
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
            this.close.Location = new System.Drawing.Point(330, 38);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.RectColor = System.Drawing.Color.Transparent;
            this.close.RectHoverColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.Style = Sunny.UI.UIStyle.Custom;
            this.close.Symbol = 61453;
            this.close.TabIndex = 70;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.search.Location = new System.Drawing.Point(287, 110);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 40);
            this.search.TabIndex = 69;
            this.search.Text = "검색";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(27, 110);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 40);
            this.uiLabel2.TabIndex = 68;
            this.uiLabel2.Text = "사원명";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(134, 110);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Maximum = 2147483647D;
            this.name.Minimum = -2147483648D;
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(146, 40);
            this.name.TabIndex = 67;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workerListView
            // 
            this.workerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workerNumber,
            this.worker_ID,
            this.worker_name,
            this.worker_inCompany,
            this.etc});
            this.workerListView.FullRowSelect = true;
            this.workerListView.GridLines = true;
            this.workerListView.HideSelection = false;
            this.workerListView.Location = new System.Drawing.Point(31, 158);
            this.workerListView.Name = "workerListView";
            this.workerListView.Size = new System.Drawing.Size(334, 254);
            this.workerListView.TabIndex = 66;
            this.workerListView.UseCompatibleStateImageBehavior = false;
            this.workerListView.View = System.Windows.Forms.View.Details;
            this.workerListView.DoubleClick += new System.EventHandler(this.workerListView_DoubleClick);
            // 
            // worker_ID
            // 
            this.worker_ID.Text = "사번";
            // 
            // worker_name
            // 
            this.worker_name.Text = "사원명";
            this.worker_name.Width = 80;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(24, 38);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 65;
            this.uiLabel1.Text = "사원 검색";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workerNumber
            // 
            this.workerNumber.Text = "번호";
            // 
            // worker_inCompany
            // 
            this.worker_inCompany.Text = "입사일";
            // 
            // etc
            // 
            this.etc.Text = "특이사항";
            // 
            // searchWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mini);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.workerListView);
            this.Controls.Add(this.uiLabel1);
            this.Name = "searchWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchWorker";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton mini;
        private Sunny.UI.UISymbolButton close;
        private Sunny.UI.UIButton search;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox name;
        private System.Windows.Forms.ListView workerListView;
        private System.Windows.Forms.ColumnHeader worker_ID;
        private System.Windows.Forms.ColumnHeader worker_name;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ColumnHeader workerNumber;
        private System.Windows.Forms.ColumnHeader worker_inCompany;
        private System.Windows.Forms.ColumnHeader etc;
    }
}