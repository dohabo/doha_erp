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
    partial class OutStock : UserControl
    {
        BaseAdapter adapter;
        public OutStock()
        {
            InitializeComponent();
        }

        public OutStock(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OutStock_Load(object sender, EventArgs e)
        {
            dpicOutDate.Text = DateTime.Now.ToString("yyyy-mm-dd");
            addWorkDateFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            addWorkDateTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
        }

        private void changeOutDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < outStockGridView.Rows.Count-1; i++)
            {
                outStockGridView.Rows[i].Cells[4].Value = dpicOutDate.Text;
            }
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            searchCompany searchcompany = new searchCompany(this, adapter);
            searchcompany.ShowDialog();
            addCompany.Text = searchcompany.CompanyNum;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            addWorkItem.Text = searchitem.ItemCode;
        }

        private void searchSupplier_Click(object sender, EventArgs e)
        {
            searchSupplier searchsupplier = new searchSupplier(this, adapter);
            searchsupplier.ShowDialog();
            addWorkQuantity.Text = searchsupplier.SupplierNum;
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            searchWorker searchworker = new searchWorker(this, adapter);
            searchworker.ShowDialog();
            addWorkPerson.Text = searchworker.WorkerID;
        }

        private void searchMachine_Click(object sender, EventArgs e)
        {
            searchMachine searchmachine = new searchMachine(this, adapter);
            searchmachine.ShowDialog();
            addWorkMachine.Text = searchmachine.MachineLineNum;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchWork_Click(object sender, EventArgs e)
        {
            addedWorkListView.Items.Clear();
            string[,] searchCondition = new string[,]{
            {"companyNum",addCompany.Text },{"machineLine",addWorkMachine.Text},
            {"workerID", addWorkPerson.Text},{"itemCode", addWorkItem.Text},
            {"workQuantity",addWorkQuantity.Text},{"workNote",addWorkNote.Text}};

            string[,] searchDate = new string[,]
            {
                {"workdate",addWorkDateFrom.Text,addWorkDateTo.Text}
            };

            List<Work> list = adapter.getWorkDB(searchCondition, searchDate);
            initWorkListView(list);
        }

        public void initWorkListView(List<Work> worklist)
        {
            for (int i = 0; i < worklist.Count; i++)
            {
                addedWorkListView.Items.Add(new ListViewItem(new string[]
                {
                    worklist[i].WorkOrderNum.ToString(),
                    worklist[i].CompanyNum.ToString(),
                    worklist[i].MachineLine,
                    worklist[i].WorkerID.ToString(),
                    worklist[i].ItemCode,
                    worklist[i].WorkQuantity.ToString(),
                    worklist[i].WorkDate,
                    worklist[i].WorkNote
                }));
            }
        }

        private void addOutStockItems_Click(object sender, EventArgs e)
        {
            if (addedWorkListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("작업지시서 목록에 해당 항목을 선택 후 버튼을 클릭 하세요.");
                return;
            }
            int n = addedWorkListView.SelectedItems[0].Index;
            if (addedWorkListView.Items[n].SubItems[0].Text == "입고완료")
            {
                MessageBox.Show("작업 완료된 작업지시서 입니다. 출고 대상이 될 수 없습니다.");
                return;
            }
            outStockGridView.Rows.Add(new string[]
                {
                    addedWorkListView.Items[n].SubItems[0].Text,
                    addedWorkListView.Items[n].SubItems[1].Text,
                    addedWorkListView.Items[n].SubItems[4].Text,
                    addedWorkListView.Items[n].SubItems[5].Text,
                    dpicOutDate.Text,
                    addedWorkListView.Items[n].SubItems[7].Text
                });
        }

        private void subtractionStock_Click(object sender, EventArgs e)
        {
            string section;
            string workOrderNum;
            string companyNum;
            string itemCode;
            string quantity;
            string outDate;
            string note;

            // addWorkGridView에 입력된 값 각 변수에 저장
            for (int i = 0; i < outStockGridView.Rows.Count-1; i++)
            {
                section = "OT";
                workOrderNum = outStockGridView.Rows[i].Cells[0].Value.ToString();
                companyNum = outStockGridView.Rows[i].Cells[1].Value.ToString();
                itemCode = outStockGridView.Rows[i].Cells[2].Value.ToString();
                quantity = outStockGridView.Rows[i].Cells[3].Value.ToString();
                outDate = outStockGridView.Rows[i].Cells[4].Value.ToString();
                note = outStockGridView.Rows[i].Cells[5].Value.ToString();

                StockHistory stockhistory = new StockHistory(section, workOrderNum,
                    companyNum, itemCode, quantity, outDate, note);
                Stock stock = new Stock(itemCode, int.Parse(quantity));
                int check = adapter.checkStock(itemCode, int.Parse(quantity));
                Console.WriteLine("check :" + check);
                if(check == 0)
                {
                    MessageBox.Show("현재 재고가 부족 합니다.");
                    return;
                }
                adapter.addOutStockHistoryDB(stockhistory);
                adapter.updateStockSubDB(itemCode, int.Parse(quantity));
            }

            MessageBox.Show("출고 등록 완료");
            outStockGridView.Rows.Clear();
        }
    }
}
