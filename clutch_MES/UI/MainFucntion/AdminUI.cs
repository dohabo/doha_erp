using clutch_MES.Adapter;
using clutch_MES.Model;
using clutch_MES.UI.Admin_Mode;
using clutch_MES.UI.Details;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.UI
{
    partial class AdminUI : UserControl
    {
        const string UC_NAME_MACHINELINE = "MachineLine";
        const string UC_NAME_ITEM = "Item";
        const string UC_NAME_DEFECTUI = "DefectUI";
        const string UC_NAME_WORKERUI = "WorkerUI";
        const string UC_NAME_COMPANYUI = "CompanyUI";
        const string UC_NAME_NOTICEUI = "NoticeUI";
        const string UC_NAME_WAREHOUSEUI = "WareHouseUI";
        const string UC_NAME_OPENINGSTOCKUI = "OpeningStokcUI";
        const string UC_NAME_BOMMANAGEUI = "BomManageUI";
        const string UC_NAME_SUPPLIERUI = "SupplierUI";
        
        BaseAdapter adapter = new BaseAdapter();
        public AdminUI()
        {
            InitializeComponent();
        }

        public AdminUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            
        }

        private void machine_Click(object sender, EventArgs e)
        {
            MachineLine machineline = new MachineLine(adapter);
            controllView(machineline, UC_NAME_MACHINELINE);
        }

        private void item_Click(object sender, EventArgs e)
        {
            Item item = new Item(adapter);
            controllView(item, UC_NAME_ITEM);
        }

        private void workTime_Click(object sender, EventArgs e)
        {
            WorkerUI workerUI = new WorkerUI(adapter);
            controllView(workerUI, UC_NAME_WORKERUI);
        }

        private void defect_Click(object sender, EventArgs e)
        {
            DefectUI defectUI = new DefectUI(adapter);
            controllView(defectUI, UC_NAME_DEFECTUI);
        }

        private void company_Click(object sender, EventArgs e)
        {
            CompanyUI companyUI = new CompanyUI(adapter);
            controllView(companyUI, UC_NAME_COMPANYUI);
        }
        private void notice_Click(object sender, EventArgs e)
        {
            NoticeUI noticeUI = new NoticeUI(adapter);
            controllView(noticeUI, UC_NAME_NOTICEUI);
        }

        private void wareHouse_Click(object sender, EventArgs e)
        {
            WareHouseUI warehouseUI = new WareHouseUI(adapter);
            controllView(warehouseUI, UC_NAME_WAREHOUSEUI);
        }

        private void openingStock_Click(object sender, EventArgs e)
        {
            OpeningStokcUI openingstockUI = new OpeningStokcUI(adapter);
            controllView(openingstockUI, UC_NAME_OPENINGSTOCKUI);
        }

        private void bomManage_Click(object sender, EventArgs e)
        {
            BomManageUI bommanageUI = new BomManageUI(adapter);
            controllView(bommanageUI, UC_NAME_BOMMANAGEUI);
        }

        private void supplierManage_Click(object sender, EventArgs e)
        {
            SupplierUI supplierUI = new SupplierUI(adapter);
            controllView(supplierUI, UC_NAME_SUPPLIERUI);
        }

        public void controllView(UserControl uc, string viewName)
        {
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }

        
    }
}
