
namespace clutch_MES.UI
{
    partial class AdminUI
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
            this.centerLayout = new System.Windows.Forms.Panel();
            this.wareHouse = new Sunny.UI.UISymbolButton();
            this.company = new Sunny.UI.UISymbolButton();
            this.defect = new Sunny.UI.UISymbolButton();
            this.machine = new Sunny.UI.UISymbolButton();
            this.item = new Sunny.UI.UISymbolButton();
            this.workTime = new Sunny.UI.UISymbolButton();
            this.notice = new Sunny.UI.UISymbolButton();
            this.bomManage = new Sunny.UI.UISymbolButton();
            this.supplierManage = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // centerLayout
            // 
            this.centerLayout.Location = new System.Drawing.Point(183, 0);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(967, 751);
            this.centerLayout.TabIndex = 5;
            // 
            // wareHouse
            // 
            this.wareHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wareHouse.FillColor = System.Drawing.Color.Transparent;
            this.wareHouse.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.wareHouse.ForeColor = System.Drawing.Color.Black;
            this.wareHouse.ForeHoverColor = System.Drawing.Color.Gray;
            this.wareHouse.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.wareHouse.Location = new System.Drawing.Point(3, 306);
            this.wareHouse.MinimumSize = new System.Drawing.Size(1, 1);
            this.wareHouse.Name = "wareHouse";
            this.wareHouse.RectColor = System.Drawing.Color.Transparent;
            this.wareHouse.Size = new System.Drawing.Size(174, 45);
            this.wareHouse.Style = Sunny.UI.UIStyle.Custom;
            this.wareHouse.Symbol = 362612;
            this.wareHouse.SymbolSize = 30;
            this.wareHouse.TabIndex = 7;
            this.wareHouse.Text = "창고 기준정보";
            this.wareHouse.Click += new System.EventHandler(this.wareHouse_Click);
            // 
            // company
            // 
            this.company.Cursor = System.Windows.Forms.Cursors.Hand;
            this.company.FillColor = System.Drawing.Color.Transparent;
            this.company.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.company.ForeColor = System.Drawing.Color.Black;
            this.company.ForeHoverColor = System.Drawing.Color.Gray;
            this.company.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.company.Image = global::clutch_MES.Properties.Resources.company;
            this.company.Location = new System.Drawing.Point(3, 105);
            this.company.MinimumSize = new System.Drawing.Size(1, 1);
            this.company.Name = "company";
            this.company.RectColor = System.Drawing.Color.Transparent;
            this.company.Size = new System.Drawing.Size(174, 45);
            this.company.Style = Sunny.UI.UIStyle.Custom;
            this.company.TabIndex = 6;
            this.company.Text = "사업장 등록 관리";
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // defect
            // 
            this.defect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defect.FillColor = System.Drawing.Color.Transparent;
            this.defect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.defect.ForeColor = System.Drawing.Color.Black;
            this.defect.ForeHoverColor = System.Drawing.Color.Gray;
            this.defect.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.defect.Image = global::clutch_MES.Properties.Resources.defect;
            this.defect.Location = new System.Drawing.Point(3, 255);
            this.defect.MinimumSize = new System.Drawing.Size(1, 1);
            this.defect.Name = "defect";
            this.defect.RectColor = System.Drawing.Color.Transparent;
            this.defect.Size = new System.Drawing.Size(174, 45);
            this.defect.Style = Sunny.UI.UIStyle.Custom;
            this.defect.TabIndex = 4;
            this.defect.Text = "불량유형 기준정보";
            this.defect.Click += new System.EventHandler(this.defect_Click);
            // 
            // machine
            // 
            this.machine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.machine.FillColor = System.Drawing.Color.Transparent;
            this.machine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.machine.ForeColor = System.Drawing.Color.Black;
            this.machine.ForeHoverColor = System.Drawing.Color.Gray;
            this.machine.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.machine.Image = global::clutch_MES.Properties.Resources.machine;
            this.machine.Location = new System.Drawing.Point(3, 204);
            this.machine.MinimumSize = new System.Drawing.Size(1, 1);
            this.machine.Name = "machine";
            this.machine.RectColor = System.Drawing.Color.Transparent;
            this.machine.Size = new System.Drawing.Size(174, 45);
            this.machine.Style = Sunny.UI.UIStyle.Custom;
            this.machine.TabIndex = 3;
            this.machine.Text = "설비라인 기준정보";
            this.machine.Click += new System.EventHandler(this.machine_Click);
            // 
            // item
            // 
            this.item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item.FillColor = System.Drawing.Color.Transparent;
            this.item.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.item.ForeColor = System.Drawing.Color.Black;
            this.item.ForeHoverColor = System.Drawing.Color.Gray;
            this.item.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.item.Image = global::clutch_MES.Properties.Resources.item;
            this.item.Location = new System.Drawing.Point(0, 153);
            this.item.MinimumSize = new System.Drawing.Size(1, 1);
            this.item.Name = "item";
            this.item.RectColor = System.Drawing.Color.Transparent;
            this.item.Size = new System.Drawing.Size(174, 45);
            this.item.Style = Sunny.UI.UIStyle.Custom;
            this.item.TabIndex = 2;
            this.item.Text = "품목 기준정보";
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // workTime
            // 
            this.workTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workTime.FillColor = System.Drawing.Color.Transparent;
            this.workTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workTime.ForeColor = System.Drawing.Color.Black;
            this.workTime.ForeHoverColor = System.Drawing.Color.Gray;
            this.workTime.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.workTime.Image = global::clutch_MES.Properties.Resources.worker;
            this.workTime.Location = new System.Drawing.Point(3, 54);
            this.workTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.workTime.Name = "workTime";
            this.workTime.RectColor = System.Drawing.Color.Transparent;
            this.workTime.Size = new System.Drawing.Size(174, 45);
            this.workTime.Style = Sunny.UI.UIStyle.Custom;
            this.workTime.TabIndex = 1;
            this.workTime.Text = "사원 관리    ";
            this.workTime.Click += new System.EventHandler(this.workTime_Click);
            // 
            // notice
            // 
            this.notice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notice.FillColor = System.Drawing.Color.Transparent;
            this.notice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.notice.ForeColor = System.Drawing.Color.Black;
            this.notice.ForeHoverColor = System.Drawing.Color.Gray;
            this.notice.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.notice.Image = global::clutch_MES.Properties.Resources.notice;
            this.notice.Location = new System.Drawing.Point(3, 3);
            this.notice.MinimumSize = new System.Drawing.Size(1, 1);
            this.notice.Name = "notice";
            this.notice.RectColor = System.Drawing.Color.Transparent;
            this.notice.Size = new System.Drawing.Size(174, 45);
            this.notice.Style = Sunny.UI.UIStyle.Custom;
            this.notice.TabIndex = 0;
            this.notice.Text = "공지사항 관리";
            this.notice.Click += new System.EventHandler(this.notice_Click);
            // 
            // bomManage
            // 
            this.bomManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bomManage.FillColor = System.Drawing.Color.Transparent;
            this.bomManage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bomManage.ForeColor = System.Drawing.Color.Black;
            this.bomManage.ForeHoverColor = System.Drawing.Color.Gray;
            this.bomManage.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.bomManage.Location = new System.Drawing.Point(3, 357);
            this.bomManage.MinimumSize = new System.Drawing.Size(1, 1);
            this.bomManage.Name = "bomManage";
            this.bomManage.RectColor = System.Drawing.Color.Transparent;
            this.bomManage.Size = new System.Drawing.Size(174, 45);
            this.bomManage.Style = Sunny.UI.UIStyle.Custom;
            this.bomManage.Symbol = 361672;
            this.bomManage.SymbolSize = 30;
            this.bomManage.TabIndex = 9;
            this.bomManage.Text = "BOM 관리";
            this.bomManage.Click += new System.EventHandler(this.bomManage_Click);
            // 
            // supplierManage
            // 
            this.supplierManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierManage.FillColor = System.Drawing.Color.Transparent;
            this.supplierManage.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.supplierManage.ForeColor = System.Drawing.Color.Black;
            this.supplierManage.ForeHoverColor = System.Drawing.Color.Gray;
            this.supplierManage.ForeSelectedColor = System.Drawing.Color.Gainsboro;
            this.supplierManage.Location = new System.Drawing.Point(3, 408);
            this.supplierManage.MinimumSize = new System.Drawing.Size(1, 1);
            this.supplierManage.Name = "supplierManage";
            this.supplierManage.RectColor = System.Drawing.Color.Transparent;
            this.supplierManage.Size = new System.Drawing.Size(174, 45);
            this.supplierManage.Style = Sunny.UI.UIStyle.Custom;
            this.supplierManage.Symbol = 357448;
            this.supplierManage.SymbolSize = 30;
            this.supplierManage.TabIndex = 10;
            this.supplierManage.Text = "거래처 관리";
            this.supplierManage.Click += new System.EventHandler(this.supplierManage_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.supplierManage);
            this.Controls.Add(this.bomManage);
            this.Controls.Add(this.wareHouse);
            this.Controls.Add(this.company);
            this.Controls.Add(this.defect);
            this.Controls.Add(this.machine);
            this.Controls.Add(this.item);
            this.Controls.Add(this.workTime);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.centerLayout);
            this.Name = "AdminUI";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton notice;
        private Sunny.UI.UISymbolButton workTime;
        private Sunny.UI.UISymbolButton item;
        private Sunny.UI.UISymbolButton machine;
        private Sunny.UI.UISymbolButton defect;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton company;
        private Sunny.UI.UISymbolButton wareHouse;
        private Sunny.UI.UISymbolButton bomManage;
        private Sunny.UI.UISymbolButton supplierManage;
    }
}
