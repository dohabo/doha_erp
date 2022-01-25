
namespace clutch_MES.UI
{
    partial class MachineLine
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
            this.machineGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiMarkLabel2 = new Sunny.UI.UIMarkLabel();
            this.searchMachine = new Sunny.UI.UISymbolButton();
            this.DeleteMachine = new Sunny.UI.UISymbolButton();
            this.addMachine = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.machineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // machineGridView
            // 
            this.machineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.machineLine1,
            this.machineName1});
            this.machineGridView.Location = new System.Drawing.Point(9, 87);
            this.machineGridView.Name = "machineGridView";
            this.machineGridView.RowTemplate.Height = 23;
            this.machineGridView.Size = new System.Drawing.Size(375, 483);
            this.machineGridView.TabIndex = 74;
            // 
            // number
            // 
            this.number.HeaderText = "번호";
            this.number.Name = "number";
            // 
            // machineLine1
            // 
            this.machineLine1.HeaderText = "설비라인";
            this.machineLine1.Name = "machineLine1";
            // 
            // machineName1
            // 
            this.machineName1.HeaderText = "설비라인명";
            this.machineName1.Name = "machineName1";
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiMarkLabel2.Location = new System.Drawing.Point(5, 5);
            this.uiMarkLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(162, 23);
            this.uiMarkLabel2.TabIndex = 70;
            this.uiMarkLabel2.Text = "설비 라인 기준정보";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchMachine
            // 
            this.searchMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchMachine.Location = new System.Drawing.Point(9, 36);
            this.searchMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchMachine.Name = "searchMachine";
            this.searchMachine.Size = new System.Drawing.Size(45, 45);
            this.searchMachine.Symbol = 61442;
            this.searchMachine.TabIndex = 77;
            this.searchMachine.Click += new System.EventHandler(this.searchMachine_Click);
            // 
            // DeleteMachine
            // 
            this.DeleteMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteMachine.Location = new System.Drawing.Point(112, 36);
            this.DeleteMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteMachine.Name = "DeleteMachine";
            this.DeleteMachine.Size = new System.Drawing.Size(45, 45);
            this.DeleteMachine.Symbol = 61944;
            this.DeleteMachine.TabIndex = 76;
            this.DeleteMachine.Click += new System.EventHandler(this.DeleteMachine_Click);
            // 
            // addMachine
            // 
            this.addMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMachine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addMachine.Location = new System.Drawing.Point(61, 36);
            this.addMachine.MinimumSize = new System.Drawing.Size(1, 1);
            this.addMachine.Name = "addMachine";
            this.addMachine.Size = new System.Drawing.Size(45, 45);
            this.addMachine.Symbol = 61639;
            this.addMachine.TabIndex = 75;
            this.addMachine.Click += new System.EventHandler(this.addMachine_Click);
            // 
            // MachineLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchMachine);
            this.Controls.Add(this.DeleteMachine);
            this.Controls.Add(this.addMachine);
            this.Controls.Add(this.machineGridView);
            this.Controls.Add(this.uiMarkLabel2);
            this.Name = "MachineLine";
            this.Size = new System.Drawing.Size(967, 751);
            this.Load += new System.EventHandler(this.MachineLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machineGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView machineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineName1;
        private Sunny.UI.UIMarkLabel uiMarkLabel2;
        private Sunny.UI.UISymbolButton searchMachine;
        private Sunny.UI.UISymbolButton DeleteMachine;
        private Sunny.UI.UISymbolButton addMachine;
    }
}
