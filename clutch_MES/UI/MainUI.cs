using clutch_MES.Adapter;
using clutch_MES.DAO;
using clutch_MES.Model;
using clutch_MES.UI.MainFucntion;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winForm0727_2.Util;

namespace clutch_MES.UI
{
    public partial class MainUI : MaterialForm
    {
        BaseAdapter adapter = new BaseAdapter();

        // 상단 패널 드래그 가능하도록 
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108

        UIHome uihome;
        AddWorkUI addworkUI;
        AddWorkedUI addworkedUI;
        CheckWorkedUI checkworkedUI;
        AdminMode adminmode;

        const string UC_NAME_HOME = "UIHome";
        const string UC_NAME_ADDWORK = "AddWorkUI";
        const string UC_NAME_ADDWORKED = "AddWorkedUI";
        const string UC_NAME_CHECKWORKED = "CheckWorkedUI";
        const string UC_NAME_LOGIN = "AdminLogin";
        const string UC_NAME_ADMINMODE = "AdminMode";
        const string UC_NAME_INSTOCK = "InStock";
        const string UC_NAME_STOCKMANAGE = "StockManage";
        const string UC_NAME_PURCHASEUI = "PurchaseUI";
        const string UC_NAME_OUTSTOCK = "OutStock";
        

        public MainUI()
        {
            InitializeComponent();
            uihome = new UIHome(adapter);
            addworkUI = new AddWorkUI();
            addworkedUI = new AddWorkedUI();
            checkworkedUI = new CheckWorkedUI();
            adminmode = new AdminMode();
            OraMgr.Instance.connectDB();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            // MaterialForm 테마 적용
            Common.initTheme(this);

            // 센터 패널에 사용자 정의 컨트롤(Form) 적용
            controllView(uihome, UC_NAME_HOME);
        }

        

        // 상단 패널 드래그 가능하도록 상단 패널 이벤트에 적용
        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // 종료 버튼
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 최소화 버튼
        private void mini(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Common.initTheme(this);
            }
        }

        // 홈화면 가기
        private void goHome_Click(object sender, EventArgs e)
        {
            controllView(uihome, UC_NAME_HOME);
        }

        // 작업지시 등록
        private void goAddWork_Click(object sender, EventArgs e)
        {
            AddWorkUI addworkUI = new AddWorkUI(this,adapter);
            controllView(addworkUI, UC_NAME_ADDWORK);
        }

        // 작업내역 등록
        private void goAddWorked_Click(object sender, EventArgs e)
        {
            AddWorkedUI addworkedUI = new AddWorkedUI(adapter);
            controllView(addworkedUI, UC_NAME_ADDWORKED);
        }

        // 작업내역 확인
        private void goCheckWorked_Click(object sender, EventArgs e)
        {
            CheckWorkedUI checkworkedUI = new CheckWorkedUI(adapter);
            controllView(checkworkedUI, UC_NAME_CHECKWORKED);
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
        }

        private void goAdmin_Click(object sender, EventArgs e)
        {
            controllView(adminmode, UC_NAME_ADMINMODE);
        }

        private void centerLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        // 센터 패널에 사용자 정의 컨트롤(Form) 적용 메쏘드
        public void controllView(UserControl uc, string viewName)
        {
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }

        private void goInStock_Click(object sender, EventArgs e)
        {
            InStock instock = new InStock(adapter);
            controllView(instock, UC_NAME_INSTOCK);
        }

        private void goItemManage_Click(object sender, EventArgs e)
        {
            StockManage stockmanage = new StockManage(adapter);
            controllView(stockmanage, UC_NAME_STOCKMANAGE);
        }

        private void goPurchase_Click(object sender, EventArgs e)
        {
            PurchaseUI purchaseUI = new PurchaseUI(adapter);
            controllView(purchaseUI, UC_NAME_PURCHASEUI);
        }

        private void goOutStock_Click(object sender, EventArgs e)
        {
            OutStock outstock = new OutStock(adapter);
            controllView(outstock, UC_NAME_OUTSTOCK);
        }
    }
}
