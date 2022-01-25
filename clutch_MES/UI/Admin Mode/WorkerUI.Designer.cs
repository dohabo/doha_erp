
namespace clutch_MES.UI.Details
{
    partial class WorkerUI
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
            this.workerGridView = new System.Windows.Forms.DataGridView();
            this.workerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchWorker = new Sunny.UI.UISymbolButton();
            this.deleteWorker = new Sunny.UI.UISymbolButton();
            this.addWorker = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.workerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workerGridView
            // 
            this.workerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerID,
            this.name,
            this.inCompany,
            this.etc});
            this.workerGridView.Location = new System.Drawing.Point(9, 87);
            this.workerGridView.Name = "workerGridView";
            this.workerGridView.RowTemplate.Height = 23;
            this.workerGridView.Size = new System.Drawing.Size(456, 150);
            this.workerGridView.TabIndex = 90;
            // 
            // workerID
            // 
            this.workerID.HeaderText = "사번";
            this.workerID.Name = "workerID";
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            // 
            // inCompany
            // 
            this.inCompany.HeaderText = "입사일";
            this.inCompany.Name = "inCompany";
            // 
            // etc
            // 
            this.etc.HeaderText = "특이사항";
            this.etc.Name = "etc";
            // 
            // searchWorker
            // 
            this.searchWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchWorker.Location = new System.Drawing.Point(9, 36);
            this.searchWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchWorker.Name = "searchWorker";
            this.searchWorker.Size = new System.Drawing.Size(45, 45);
            this.searchWorker.Symbol = 61442;
            this.searchWorker.TabIndex = 89;
            this.searchWorker.Click += new System.EventHandler(this.searchWorker_Click);
            // 
            // deleteWorker
            // 
            this.deleteWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteWorker.Location = new System.Drawing.Point(112, 36);
            this.deleteWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteWorker.Name = "deleteWorker";
            this.deleteWorker.Size = new System.Drawing.Size(45, 45);
            this.deleteWorker.Symbol = 61944;
            this.deleteWorker.TabIndex = 88;
            this.deleteWorker.Click += new System.EventHandler(this.deleteWorker_Click);
            // 
            // addWorker
            // 
            this.addWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorker.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorker.Location = new System.Drawing.Point(61, 36);
            this.addWorker.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(45, 45);
            this.addWorker.Symbol = 61639;
            this.addWorker.TabIndex = 87;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel2.TabIndex = 91;
            this.uiMarkLabel2.Text = "사원 정보 관리";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WorkerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.workerGridView);
            this.Controls.Add(this.searchWorker);
            this.Controls.Add(this.deleteWorker);
            this.Controls.Add(this.addWorker);
            this.Name = "WorkerUI";
            this.Size = new System.Drawing.Size(967, 751);
            ((System.ComponentModel.ISupportInitialize)(this.workerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn etc;
        private Sunny.UI.UISymbolButton searchWorker;
        private Sunny.UI.UISymbolButton deleteWorker;
        private Sunny.UI.UISymbolButton addWorker;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
    }
}
