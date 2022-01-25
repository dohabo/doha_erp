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

namespace clutch_MES.UI
{
    partial class CheckWorkedUI : UserControl
    {
        BaseAdapter adapter;
        public CheckWorkedUI()
        {
            InitializeComponent();
        }

        public CheckWorkedUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void searchWorked_Click(object sender, EventArgs e)
        {
            addWorkedListView.Items.Clear();
            string[,] searchCondition = new string[,]{
            {"companyNum",addCompany.Text },
            {"machineLine",addWorkMachine.Text},
            {"workerID", addWorkPerson.Text},
            {"itemCode", addWorkItem.Text},
            {"workQuantity",addWorkQuantity.Text},
            {"workNote",addWorkNote.Text}
            };

            string[,] searchDate = new string[,]
            {
                {"workdate",addWorkDateFrom.Text,addWorkDateTo.Text}
            };

            List<workJoinVo> list = adapter.getWorkJoinDB(searchCondition, searchDate);
            initWorkedListView(list);
        }

        public void initWorkedListView(List<workJoinVo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                addWorkedListView.Items.Add(new ListViewItem(new string[]
                {
                    list[i].WorkedNum.ToString(),
                    list[i].CompanyNum.ToString(),
                    list[i].MachineLine,
                    list[i].WorkerID.ToString(),
                    list[i].ItemCode,
                    list[i].WorkQuantity.ToString(),
                    list[i].WorkDate,
                    list[i].WorkedDate,
                    list[i].Workedquantity.ToString(),
                    list[i].DefectQuantity.ToString(),
                    list[i].DefectCode,
                    list[i].WorkNote
                }));
            }
        }

        private void CheckWorkedUI_Load(object sender, EventArgs e)
        {
            addWorkDateFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            addWorkDateTo.Text = String.Format("{0}-{1}-{2}", DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToString());
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            searchCompany searchcompany = new searchCompany(this, adapter);
            searchcompany.ShowDialog();
            addCompany.Text = searchcompany.CompanyNum;
        }

        private void searchMachine_Click(object sender, EventArgs e)
        {
            searchMachine searchmachine = new searchMachine(this, adapter);
            searchmachine.ShowDialog();
            addWorkMachine.Text = searchmachine.MachineLineNum;
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            searchWorker searchworker = new searchWorker(this, adapter);
            searchworker.ShowDialog();
            addWorkPerson.Text = searchworker.WorkerID;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            addWorkItem.Text = searchitem.ItemCode;
        }

        private void addWorkNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
