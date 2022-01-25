using clutch_MES.Adapter;
using clutch_MES.DAO;
using clutch_MES.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.UI.Details
{
    partial class WorkerUI : UserControl
    {
        BaseAdapter adapter = new BaseAdapter();
        public WorkerUI()
        {
            InitializeComponent();
        }

        public WorkerUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void addWorker_Click(object sender, EventArgs e)
        {
            int workerID;
            string workerName;
            string inCompany;
            string etc;
            for (int i = 0; i < workerGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < workerGridView.Columns.Count; j++)
                {
                    if (workerGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(workerGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                workerID = int.Parse(workerGridView.Rows[i].Cells[0].Value.ToString());
                workerName = workerGridView.Rows[i].Cells[1].Value.ToString();
                inCompany = workerGridView.Rows[i].Cells[2].Value.ToString();
                etc = workerGridView.Rows[i].Cells[3].Value.ToString();

                Worker worker = new Worker(workerID, workerName, inCompany, etc);
                OraMgr.Instance.insertDB(worker);
            }
            MessageBox.Show("사원 등록 완료");
            workerGridView.Rows.Clear();
        }

        private void searchWorker_Click(object sender, EventArgs e)
        {
            workerGridView.Rows.Clear();
            List<Worker> workerlist = adapter.getWorkerList();
            initGridView(workerlist);
        }

        void initGridView(List<Worker> workerlist)
        {
            for (int i = 0; i < workerlist.Count; i++)
            {
                workerGridView.Rows.Add(new string[]
                {
                    workerlist[i].WorkerID.ToString(),
                    workerlist[i].WorkerName,
                    workerlist[i].InCompany,
                    workerlist[i].Etc
                });
            }
        }

        private void deleteWorker_Click(object sender, EventArgs e)
        {
            if (workerGridView.SelectedRows.Count != 0)
            {
                int n = workerGridView.SelectedRows[0].Index;
                int workerID = int.Parse(workerGridView.Rows[n].Cells[0].Value.ToString());
                adapter.deleteWorkerDB(workerID);
                MessageBox.Show("선택된 설비관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            workerGridView.Rows.Clear();
        }
    }
}
