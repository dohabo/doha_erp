using clutch_MES.Adapter;
using clutch_MES.Model;
using clutch_MES.UI.MainFucntion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.UI.Search
{
    partial class searchCompany : Form
    {
        BaseAdapter adapter;
        AddWorkUI addworkUI;
        CheckWorkedUI checkworkedUI;
        PurchaseUI purchaseUI;
        InStock instock;
        OutStock outstock;
        StockManage stockmanage;
        string companyNum;

        public string CompanyNum { get => companyNum; set => companyNum = value; }

        public searchCompany()
        {
            InitializeComponent();
        }

        public searchCompany(AddWorkUI addworkUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.addworkUI = addworkUI;
            this.adapter = adapter;
        }

        public searchCompany(StockManage stockmanage, BaseAdapter adapter)
        {
            InitializeComponent();
            this.stockmanage = stockmanage;
            this.adapter = adapter;
        }
        public searchCompany(OutStock outstock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.outstock = outstock;
            this.adapter = adapter;
        }
        public searchCompany(PurchaseUI purchaseUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.purchaseUI = purchaseUI;
            this.adapter = adapter;
        }
        public searchCompany(CheckWorkedUI checkworkedUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.checkworkedUI = checkworkedUI;
            this.adapter = adapter;
        }

        public searchCompany(InStock instock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.instock = instock;
            this.adapter = adapter;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void search_Click(object sender, EventArgs e)
        {
            companyListView.Items.Clear();
            string companyName = name.Text;
            List<Company> list = adapter.getCompanyList(companyName);
            initCompanyListView(list);
        }

        public void initCompanyListView(List<Company> companyList)
        {
            for (int i = 0; i < companyList.Count; i++)
            {
                companyListView.Items.Add(new ListViewItem(new string[]
                {
                    companyList[i].CompanyNum,
                    companyList[i].CompanyName
                }));
            }
        }

        private void companyListView_DoubleClick(object sender, EventArgs e)
        {
            int n = companyListView.SelectedItems[0].Index;
            this.companyNum = companyListView.Items[n].SubItems[0].Text;
            Close();
        }
    }
}
