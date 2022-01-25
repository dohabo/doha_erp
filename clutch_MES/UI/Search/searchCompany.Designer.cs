﻿
namespace clutch_MES.UI.Search
{
    partial class searchCompany
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
            this.companyListView = new System.Windows.Forms.ListView();
            this.companyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.mini.Location = new System.Drawing.Point(299, 36);
            this.mini.MinimumSize = new System.Drawing.Size(1, 1);
            this.mini.Name = "mini";
            this.mini.RectColor = System.Drawing.Color.Transparent;
            this.mini.RectHoverColor = System.Drawing.Color.Black;
            this.mini.Size = new System.Drawing.Size(25, 25);
            this.mini.Style = Sunny.UI.UIStyle.Custom;
            this.mini.Symbol = 62161;
            this.mini.TabIndex = 78;
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
            this.close.Location = new System.Drawing.Point(333, 36);
            this.close.MinimumSize = new System.Drawing.Size(1, 1);
            this.close.Name = "close";
            this.close.RectColor = System.Drawing.Color.Transparent;
            this.close.RectHoverColor = System.Drawing.Color.Black;
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.Style = Sunny.UI.UIStyle.Custom;
            this.close.Symbol = 61453;
            this.close.TabIndex = 77;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.search.Location = new System.Drawing.Point(290, 110);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 40);
            this.search.TabIndex = 76;
            this.search.Text = "검색";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // companyListView
            // 
            this.companyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyNumber,
            this.companyName});
            this.companyListView.FullRowSelect = true;
            this.companyListView.GridLines = true;
            this.companyListView.HideSelection = false;
            this.companyListView.Location = new System.Drawing.Point(34, 158);
            this.companyListView.Name = "companyListView";
            this.companyListView.Size = new System.Drawing.Size(321, 254);
            this.companyListView.TabIndex = 74;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.View = System.Windows.Forms.View.Details;
            this.companyListView.DoubleClick += new System.EventHandler(this.companyListView_DoubleClick);
            // 
            // companyNumber
            // 
            this.companyNumber.Text = "사업장번호";
            this.companyNumber.Width = 120;
            // 
            // companyName
            // 
            this.companyName.Text = "사업장명";
            this.companyName.Width = 150;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(27, 36);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(256, 60);
            this.uiLabel1.TabIndex = 73;
            this.uiLabel1.Text = "사업장 검색";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.name.Location = new System.Drawing.Point(137, 110);
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
            this.uiLabel3.Location = new System.Drawing.Point(30, 110);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 40);
            this.uiLabel3.TabIndex = 79;
            this.uiLabel3.Text = "사업장명";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mini);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.companyListView);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.uiLabel3);
            this.Name = "searchCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchCompany";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton mini;
        private Sunny.UI.UISymbolButton close;
        private Sunny.UI.UIButton search;
        private System.Windows.Forms.ListView companyListView;
        private System.Windows.Forms.ColumnHeader companyNumber;
        private System.Windows.Forms.ColumnHeader companyName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UILabel uiLabel3;
    }
}