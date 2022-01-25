using clutch_MES.Adapter;
using clutch_MES.Model;
using clutch_MES.UI.Admin_Mode;
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
    partial class searchItem : Form
    {
        string itemCode;
        AddWorkUI addworkUI;
        CheckWorkedUI checkworkedUI;
        PurchaseUI purchaseUI;
        BomManageUI bommanageUI;
        BaseAdapter adapter;
        InStock instock;
        OutStock outstock;
        StockManage stockmanage;

        public string ItemCode { get => itemCode; set => itemCode = value; }

        public searchItem()
        {
            InitializeComponent();
        }
        public searchItem(AddWorkUI addworkUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.addworkUI = addworkUI;
            this.adapter = adapter;
        }
        public searchItem(StockManage stockmanage, BaseAdapter adapter)
        {
            InitializeComponent();
            this.stockmanage = stockmanage;
            this.adapter = adapter;
        }
        public searchItem(BomManageUI bommanageUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.bommanageUI = bommanageUI;
            this.adapter = adapter;
        }
        public searchItem(OutStock outstock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.outstock = outstock;
            this.adapter = adapter;
        }
        public searchItem(PurchaseUI purchaseUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.purchaseUI = purchaseUI;
            this.adapter = adapter;
        }
        public searchItem(InStock instock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.instock = instock;
            this.adapter = adapter;
        }
        public searchItem(CheckWorkedUI checkworkedUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.checkworkedUI = checkworkedUI;
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
            itemListView.Items.Clear();
            string itemCode = name.Text;
            List<Items> list = adapter.getItemsList(itemCode);
            initItemListView(list);
        }
        public void initItemListView(List<Items> itemsList)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                itemListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    itemsList[i].ItemCode,
                    itemsList[i].ItemName
                }));
            }
        }

        private void itemListView_DoubleClick(object sender, EventArgs e)
        {
            int n = itemListView.SelectedItems[0].Index;
            this.itemCode = itemListView.Items[n].SubItems[1].Text;
            Close();
        }
    }
}
