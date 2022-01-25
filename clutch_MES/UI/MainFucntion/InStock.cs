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
    partial class InStock : UserControl
    {
        BaseAdapter adapter;
        public InStock()
        {
            InitializeComponent();
        }
        public InStock(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void InStock_Load(object sender, EventArgs e)
        {
            dpicInDate.Text = DateTime.Now.ToString("yyyy-mm-dd");
            dpicPurchaseAddFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month); ;
            dpicPurchaseInFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month); ;
            dpicPurchaseAddTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
            dpicPurchaseInTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
        }

        private void InStockNotice_Click(object sender, EventArgs e)
        {

        }

        private void searchPurchase_Click(object sender, EventArgs e)
        {
            PurchaseListView.Items.Clear();

            string status = cbboxStatus.Text;
            if (cbboxStatus.Text == "전체")
            {
                status = string.Empty;
            }

            string[,] searchCondition = new string[,]
            {
                {"companyNum",tboxCompanyNum.Text},
                {"itemCode", tboxItemCode.Text},
                {"supplier",tboxSupplier.Text},
                {"workerID", tboxPurchaser.Text},
                {"status", status }
            };
            string[,] searchDate = new string[,]
            {
                {"purchase_add_date",dpicPurchaseAddFrom.Text,dpicPurchaseAddTo.Text},
                {"purchase_in_date",dpicPurchaseInFrom.Text,dpicPurchaseInTo.Text}
            };

            List<Purchase> list = adapter.getPurchaseDB(searchCondition, searchDate);
            initPurchaseListView(list);
        }

        public void initPurchaseListView(List<Purchase> purchaseList)
        {
            for (int i = 0; i < purchaseList.Count; i++)
            {
                PurchaseListView.Items.Add(new ListViewItem(new string[]
                {
                    purchaseList[i].PurchaseNum.ToString(),
                    purchaseList[i].CompanyNum.ToString(),
                    purchaseList[i].Supplier.ToString(),
                    purchaseList[i].Status,
                    purchaseList[i].ItemCode,
                    purchaseList[i].Quantity.ToString(),
                    purchaseList[i].PurchaseAddDate,
                    purchaseList[i].PurchaseInDate,
                    purchaseList[i].Note
                })); ;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (PurchaseListView.SelectedItems.Count == 0 )
            {
                MessageBox.Show("구매 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
            int n = PurchaseListView.SelectedItems[0].Index;
            if(PurchaseListView.Items[n].SubItems[3].Text == "입고완료")
            {
                MessageBox.Show("입고 처리 완료된 구매 오더 입니다. 입고 대상이 될 수 없습니다.");
                return;
            }
            InStockListView.Items.Add(new ListViewItem(new string[]
                {
                    PurchaseListView.Items[n].SubItems[0].Text,
                    PurchaseListView.Items[n].SubItems[1].Text,
                    PurchaseListView.Items[n].SubItems[2].Text,
                    PurchaseListView.Items[n].SubItems[4].Text,
                    PurchaseListView.Items[n].SubItems[5].Text,
                    dpicInDate.Text,
                    cbboxWarehouse.Text,
                    PurchaseListView.Items[n].SubItems[8].Text
                }));
        }
        private void changeWarehouse_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < InStockListView.Items.Count; i++)
            {
                InStockListView.Items[i].SubItems[6].Text = cbboxWarehouse.Text;
            }
        }

        private void changeInDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InStockListView.Items.Count; i++)
            {
                InStockListView.Items[i].SubItems[5].Text = dpicInDate.Text;
            }
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            string section;
            string purchaseNum;
            string companyNum;
            string itemCode;
            string quantity;
            string inDate;
            string warehouse;
            string note;

            // addWorkGridView에 입력된 값 각 변수에 저장
            for (int i = 0; i < InStockListView.Items.Count; i++)
            {
                section = "IN";
                purchaseNum = InStockListView.Items[i].SubItems[0].Text.ToString();
                companyNum = InStockListView.Items[i].SubItems[1].Text.ToString();
                itemCode = InStockListView.Items[i].SubItems[3].Text.ToString();
                quantity = InStockListView.Items[i].SubItems[4].Text.ToString();
                inDate = InStockListView.Items[i].SubItems[5].Text.ToString();
                warehouse = InStockListView.Items[i].SubItems[6].Text.ToString();
                note = InStockListView.Items[i].SubItems[7].Text.ToString();

                StockHistory stockhistory = new StockHistory(section, purchaseNum, 
                     companyNum, itemCode, quantity, inDate, warehouse, note);
                adapter.addInStockHistoryDB(stockhistory);
                adapter.updateDB(int.Parse(purchaseNum));
                Stock stock = new Stock(itemCode, int.Parse(quantity));
                adapter.updateStockDB(itemCode, int.Parse(quantity));
            }

            MessageBox.Show("입고 등록 완료");
            InStockListView.Items.Clear();
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            searchCompany searchcompany = new searchCompany(this, adapter);
            searchcompany.ShowDialog();
            tboxCompanyNum.Text = searchcompany.CompanyNum;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxItemCode.Text = searchitem.ItemCode;
        }

        private void searchSupplier_Click(object sender, EventArgs e)
        {
            searchSupplier searchsupplier = new searchSupplier(this, adapter);
            searchsupplier.ShowDialog();
            tboxSupplier.Text = searchsupplier.SupplierNum;
        }

        private void searchPurchaser_Click(object sender, EventArgs e)
        {
            searchWorker searchworker = new searchWorker(this, adapter);
            searchworker.ShowDialog();
            tboxPurchaser.Text = searchworker.WorkerID;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
