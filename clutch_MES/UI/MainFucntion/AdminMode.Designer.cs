
namespace clutch_MES.UI
{
    partial class AdminMode
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
            this.loginClose = new Sunny.UI.UISymbolButton();
            this.loginOK = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.PW = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.ID = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.centerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Controls.Add(this.loginClose);
            this.centerLayout.Controls.Add(this.loginOK);
            this.centerLayout.Controls.Add(this.uiSymbolLabel1);
            this.centerLayout.Controls.Add(this.PW);
            this.centerLayout.Controls.Add(this.uiSymbolLabel5);
            this.centerLayout.Controls.Add(this.ID);
            this.centerLayout.Controls.Add(this.uiLabel1);
            this.centerLayout.Controls.Add(this.uiLabel2);
            this.centerLayout.Location = new System.Drawing.Point(3, 3);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(1150, 751);
            this.centerLayout.TabIndex = 1;
            // 
            // loginClose
            // 
            this.loginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginClose.FillColor = System.Drawing.Color.DimGray;
            this.loginClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.loginClose.Location = new System.Drawing.Point(615, 409);
            this.loginClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginClose.Name = "loginClose";
            this.loginClose.RectColor = System.Drawing.Color.Black;
            this.loginClose.Size = new System.Drawing.Size(100, 35);
            this.loginClose.Style = Sunny.UI.UIStyle.Custom;
            this.loginClose.TabIndex = 17;
            this.loginClose.Text = "종료";
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // loginOK
            // 
            this.loginOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginOK.FillColor = System.Drawing.Color.DimGray;
            this.loginOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.loginOK.Location = new System.Drawing.Point(490, 409);
            this.loginOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginOK.Name = "loginOK";
            this.loginOK.RectColor = System.Drawing.Color.Black;
            this.loginOK.Size = new System.Drawing.Size(100, 35);
            this.loginOK.Style = Sunny.UI.UIStyle.Custom;
            this.loginOK.TabIndex = 16;
            this.loginOK.Text = "로그인";
            this.loginOK.Click += new System.EventHandler(this.loginOK_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(434, 485);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(242, 35);
            this.uiSymbolLabel1.TabIndex = 19;
            this.uiSymbolLabel1.Text = "admin 로그인 화면입니다.";
            // 
            // PW
            // 
            this.PW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PW.FillColor = System.Drawing.Color.White;
            this.PW.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PW.Location = new System.Drawing.Point(575, 340);
            this.PW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PW.Maximum = 2147483647D;
            this.PW.Minimum = -2147483648D;
            this.PW.MinimumSize = new System.Drawing.Size(1, 1);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '●';
            this.PW.RectColor = System.Drawing.Color.Black;
            this.PW.Size = new System.Drawing.Size(150, 29);
            this.PW.Style = Sunny.UI.UIStyle.Custom;
            this.PW.TabIndex = 15;
            this.PW.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(434, 216);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(271, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 61447;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.TabIndex = 18;
            this.uiSymbolLabel5.Text = "관리자 모드";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.FillColor = System.Drawing.Color.White;
            this.ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ID.Location = new System.Drawing.Point(575, 301);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID.Maximum = 2147483647D;
            this.ID.Minimum = -2147483648D;
            this.ID.MinimumSize = new System.Drawing.Size(1, 1);
            this.ID.Name = "ID";
            this.ID.RectColor = System.Drawing.Color.Black;
            this.ID.Size = new System.Drawing.Size(150, 29);
            this.ID.Style = Sunny.UI.UIStyle.Custom;
            this.ID.TabIndex = 14;
            this.ID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(457, 301);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 25);
            this.uiLabel1.TabIndex = 12;
            this.uiLabel1.Text = "아이디";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(457, 345);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 25);
            this.uiLabel2.TabIndex = 13;
            this.uiLabel2.Text = "비밀번호";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.centerLayout);
            this.Name = "AdminMode";
            this.Size = new System.Drawing.Size(1150, 751);
            this.Load += new System.EventHandler(this.AdminMode_Load);
            this.centerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton loginClose;
        private Sunny.UI.UISymbolButton loginOK;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox PW;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UITextBox ID;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}
