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
    partial class searchSupplier : Form
    {
        PurchaseUI purchaseui;
        BaseAdapter adapter;
        InStock instock;
        OutStock outstock;
        StockManage stockmanage;
        string supplierNum;

        public searchSupplier()
        {
            InitializeComponent();
        }
        public searchSupplier(PurchaseUI purchaseui, BaseAdapter adapter)
        {
            InitializeComponent();
            this.purchaseui = purchaseui;
            this.adapter = adapter;
        }
        public searchSupplier(StockManage stockmanage, BaseAdapter adapter)
        {
            InitializeComponent();
            this.stockmanage = stockmanage;
            this.adapter = adapter;
        }
        public searchSupplier(InStock instock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.instock = instock;
            this.adapter = adapter;
        }
        public searchSupplier(OutStock outstock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.outstock = outstock;
            this.adapter = adapter;
        }

        public string SupplierNum { get => supplierNum; set => supplierNum = value; }

        private void search_Click(object sender, EventArgs e)
        {
            supplierListView.Items.Clear();
            string supplierName = name.Text;
            List<Supplier> list = adapter.getSupplierList(supplierName);
            initSupplierListView(list);
        }

        public void initSupplierListView(List<Supplier> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                supplierListView.Items.Add(new ListViewItem(new string[]
                {
                    list[i].SupplierNum.ToString(),
                    list[i].SupplierName,
                    list[i].SellingItem,
                    list[i].CeoName,
                    list[i].Adress
                }));
            }
        }
    }
}
