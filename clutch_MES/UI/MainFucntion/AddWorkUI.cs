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
    partial class AddWorkUI : UserControl
    {
        BaseAdapter adapter;
        MainUI mainUI;

        public AddWorkUI()
        {
            InitializeComponent();
        }

        public AddWorkUI(MainUI mainUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.mainUI = mainUI;
            this.adapter = adapter;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            addWorkItem.Text = searchitem.ItemCode;
        }

        private void AddWorkUI_Load(object sender, EventArgs e)
        {
            addWorkDateFrom.Text = String.Format("{0}-{1}-01", DateTime.Now.Year, DateTime.Now.Month);
            addWorkDateTo.Text = String.Format("{0}-{1}-{2}",DateTime.Now.Year, DateTime.Now.Month,
                (DateTime.DaysInMonth((DateTime.Now.Year),(DateTime.Now.Month))).ToString());
            List<Machine> machineList = adapter.getMachineList();
            DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn();
            addWorkGridView.Columns.Insert(1, newColumn);
            newColumn.HeaderText = "설비라인";
            for (int i = 0; i < machineList.Count; i++)
            {
                newColumn.Items.AddRange(machineList[i].MachineLine);
            }
        }

        // 작업지시 등록 버튼
        private void addWork_Click(object sender, EventArgs e)
        {
            int companyNum;
            string machineLine;
            int workerID;
            string itemCode;
            int workQuantity;
            string workDate;
            string workNote;

            // addWorkGridView에 입력된 값 각 변수에 저장
            for (int i = 0; i < addWorkGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < addWorkGridView.Columns.Count; j++)
                {
                    if (addWorkGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(addWorkGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                companyNum = int.Parse(addWorkGridView.Rows[i].Cells[0].Value.ToString());
                machineLine = addWorkGridView.Rows[i].Cells[1].Value.ToString();
                workerID = int.Parse(addWorkGridView.Rows[i].Cells[2].Value.ToString());
                itemCode = addWorkGridView.Rows[i].Cells[3].Value.ToString();
                workQuantity = int.Parse(addWorkGridView.Rows[i].Cells[4].Value.ToString());
                workDate = addWorkGridView.Rows[i].Cells[5].Value.ToString();
                workNote = addWorkGridView.Rows[i].Cells[6].Value.ToString();

                Work work = new Work(companyNum, machineLine, workerID, itemCode,
                    workQuantity, workDate, workNote);
                adapter.addToList(work);
            }

            MessageBox.Show("작업 지시(계획) 등록 완료");
            addWorkGridView.Rows.Clear();
        }

        // 기 등록된 작업지시 검색(돋보기 버튼)
        private void searchWork_Click(object sender, EventArgs e)
        {
            addedWorkListView.Items.Clear();
            Dictionary<string, string> searchCondi = new Dictionary<string, string>();
            searchCondi.Add("companyNum", addCompany.Text);
            searchCondi.Add("machineLine", addWorkMachine.Text);
            searchCondi.Add("workerID", addWorkPerson.Text);
            searchCondi.Add("itemCode", addWorkItem.Text);
            searchCondi.Add("workQuantity", addWorkQuantity.Text);
            searchCondi.Add("workDate", addWorkDateFrom.Text);
            searchCondi.Add("workNote", addWorkNote.Text);

            string[,] searchCondition = new string[,]{
            {"companyNum",addCompany.Text },{"machineLine",addWorkMachine.Text},
            {"workerID", addWorkPerson.Text},{"itemCode", addWorkItem.Text},
            {"workQuantity",addWorkQuantity.Text}, {"workNote",addWorkNote.Text}
            };

            string[,] searchDate = new string[,]
            {
                {"workdate",addWorkDateFrom.Text,addWorkDateTo.Text}
            };

            List<Work> list = adapter.getWorkDB(searchCondition, searchDate);
            initWorkListView(list);
        }

        // 기 등록된 작업지시 참조하여 신규 정보로 땡겨오는 메쏘드
        private void newWork_Click(object sender, EventArgs e)
        {
            int n = addedWorkListView.SelectedItems[0].Index;
            string workordernum = addedWorkListView.Items[n].SubItems[0].Text;
            List<Work> workList = adapter.getWorkOrderDB(workordernum);

            if (addedWorkListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("등록된 작업 계획의 라인을 선택해 주세요.");
            }

            else if (addedWorkListView.SelectedItems.Count != 0)
            {
                selectLine(workList);
            }
        }

        // 기 등록된 작업지시 리스트뷰에 표현하는 메쏘드
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

        // ListView 라인 선택값 가져오는 메쏘드
        public void selectLine(List<Work> workList)
        {
            int n = addedWorkListView.SelectedItems[0].Index;
            addWorkGridView.Rows.Add(new string[]
            {
                    workList[0].CompanyNum.ToString(),
                    workList[0].MachineLine,
                    workList[0].WorkerID.ToString(),
                    workList[0].ItemCode,
                    workList[0].WorkQuantity.ToString(),
                    workList[0].WorkDate,
                    workList[0].WorkNote
            });
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
    }
}
