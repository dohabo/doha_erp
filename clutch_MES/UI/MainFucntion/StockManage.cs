using clutch_MES.Adapter;
using clutch_MES.Model;
using clutch_MES.UI.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.UI.MainFucntion
{
    partial class StockManage : UserControl
    {
        BaseAdapter adapter;
        string[] searchCondi = { "전체", "모품번 검색", "자품번 검색", "재고 부족 품번" };

        public StockManage()
        {
            InitializeComponent();
        }
        public StockManage(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            searchCompany searchcompany = new searchCompany(this, adapter);
            searchcompany.ShowDialog();
            tboxCompanyNum.Text = searchcompany.CompanyNum;
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            searchWorker searchworker = new searchWorker(this, adapter);
            searchworker.ShowDialog();
            tboxPurchaser.Text = searchworker.WorkerID;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxItemCode.Text = searchitem.ItemCode;
        }

        private void searchStockHistory_Click(object sender, EventArgs e)
        {
            stockHistoryListView.Items.Clear();

            string status = cbboxStatus.Text;
            if (cbboxStatus.Text == "전체")
            {
                status = string.Empty;
            }

            string[,] searchCondition = new string[,]
            {
                {"companyNum",tboxCompanyNum.Text},
                {"itemCode", tboxItemCode.Text},
                {"workerID", tboxPurchaser.Text},
                {"status", status }
            };
            string[,] searchDate = new string[,]
            {
                {"indate",dpicHistoryAddFrom.Text,dpicHistoryAddTo.Text}
            };

            List<StockHistory> list = adapter.getStockHistoryDB(searchCondition, searchDate);
            initStockHistoryListView(list);
        }
        public void initStockHistoryListView(List<StockHistory> stockhistory)
        {
            for (int i = 0; i < stockhistory.Count; i++)
            {
                stockHistoryListView.Items.Add(new ListViewItem(new string[]
                {
                    stockhistory[i].Section,
                    stockhistory[i].PurchaseNum.ToString(),
                    stockhistory[i].WorkOrderNum.ToString(),
                    stockhistory[i].CompanyNum.ToString(),
                    stockhistory[i].ItemCode,
                    stockhistory[i].StockQuantity.ToString(),
                    stockhistory[i].InDate,
                    stockhistory[i].Warehouse,
                    stockhistory[i].Note
                })); ;
            }
        }

        private void StockManage_Load(object sender, EventArgs e)
        {
            dpicHistoryAddFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            dpicHistoryAddTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
            lbSearchContens.Text = "전체 => 전체 품번 및 수량 검색" + "\n" +
                "모품번 검색 => 검색품번의 자품번 및 수량 검색" + "\n" +
                "자품번 검색 => 검색품번의 모품번 및 수량 검색" + "\n" +
                "재고 부족 품번 => 재고수량 0인 품번 검색";
            
            cboxSearchCondi.Items.AddRange(searchCondi);
        }

        private void searchStockItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxStockItemCode.Text = searchitem.ItemCode;
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            stockListView.Items.Clear();
            List<Stock> list = new List<Stock>();
            string status = cboxSearchCondi.Text;

            if (cboxSearchCondi.Text == searchCondi[0])//전체
            {
                list = adapter.getAllStock();
            }


            initStockListView(list);
        }
        public void initStockListView(List<Stock> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                stockListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    list[i].ItemCode,
                    list[i].StockQuantity.ToString()
                }));
            }
        }
    }
}
