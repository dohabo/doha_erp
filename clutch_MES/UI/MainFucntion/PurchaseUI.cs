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
    partial class PurchaseUI : UserControl
    {
        BaseAdapter adapter;
        public PurchaseUI()
        {
            InitializeComponent();
        }
        public PurchaseUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void addedWorkListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPurchase_Click(object sender, EventArgs e)
        {
            int companyNum;
            int supplier;
            string status;
            string itemCode;
            int quantity;
            string purchaseAddDate;
            string purchaseInDate;
            int purchaser;
            string note;

            // addWorkGridView에 입력된 값 각 변수에 저장
            for (int i = 0; i < addPurchaseGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < addPurchaseGridView.Columns.Count; j++)
                {
                    if (addPurchaseGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(addPurchaseGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                companyNum = int.Parse(addPurchaseGridView.Rows[i].Cells[0].Value.ToString());
                supplier = int.Parse(addPurchaseGridView.Rows[i].Cells[1].Value.ToString());
                status = "발주완료";
                itemCode = addPurchaseGridView.Rows[i].Cells[2].Value.ToString();
                quantity = int.Parse(addPurchaseGridView.Rows[i].Cells[3].Value.ToString());
                purchaseAddDate = addPurchaseGridView.Rows[i].Cells[4].Value.ToString();
                purchaseInDate = addPurchaseGridView.Rows[i].Cells[5].Value.ToString();
                purchaser = int.Parse(addPurchaseGridView.Rows[i].Cells[6].Value.ToString());
                note = addPurchaseGridView.Rows[i].Cells[7].Value.ToString();

                Purchase purchase = new Purchase(companyNum, supplier, status, itemCode,
                    quantity, purchaseAddDate, purchaseInDate, purchaser, note);
                adapter.addToDB(purchase);
            }

            MessageBox.Show("구매 등록 완료");
            addPurchaseGridView.Rows.Clear();
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxItemCode.Text = searchitem.ItemCode;
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            searchCompany searchcompany = new searchCompany(this, adapter);
            searchcompany.ShowDialog();
            tboxCompanyNum.Text = searchcompany.CompanyNum;
        }

        private void searchPurchaser_Click(object sender, EventArgs e)
        {
            searchWorker searchworker = new searchWorker(this, adapter);
            searchworker.ShowDialog();
            tboxPurchaser.Text = searchworker.WorkerID;
        }

        private void searchPurchase_Click(object sender, EventArgs e)
        {
            addedPurchaseListView.Items.Clear();

            string status = cbboxStatus.Text;
            if(cbboxStatus.Text == "전체")
            {
                status = string.Empty;
            }
            string[,] searchCondition = new string[,]
            {
                {"companyNum",tboxCompanyNum.Text},
                {"itemCode", tboxItemCode.Text},
                {"supplier",tboxSupplier.Text},
                {"workerID", tboxPurchaser.Text},
                {"Status", status }
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
                addedPurchaseListView.Items.Add(new ListViewItem(new string[]
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

        private void PurchaseUI_Load(object sender, EventArgs e)
        {
            dpicPurchaseAddFrom.Text = DateTime.Now.ToString("yyyy-MM-01");
            dpicPurchaseAddTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
            dpicPurchaseInFrom.Text = DateTime.Today.ToString("yyyy-MM-01");
            dpicPurchaseInTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            searchSupplier searchsupplier = new searchSupplier(this, adapter);
            searchsupplier.ShowDialog();
            tboxSupplier.Text = searchsupplier.SupplierNum;
        }
    }
}
