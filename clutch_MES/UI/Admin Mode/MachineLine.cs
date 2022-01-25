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

namespace clutch_MES.UI
{
    partial class MachineLine : UserControl
    {
        BaseAdapter adapter;
        public MachineLine()
        {
            InitializeComponent();
        }

        public MachineLine(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void searchMachine_Click(object sender, EventArgs e)
        {
            machineGridView.Rows.Clear();
            List<Machine> machinelist = adapter.getMachineList();
            initGridView(machinelist);
        }

        private void MachineLine_Load(object sender, EventArgs e)
        {
        }

        private void addMachine_Click(object sender, EventArgs e)
        {
            string machineLine;
            string machineName;
            for (int i = 0; i < machineGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < machineGridView.Columns.Count; j++)
                {
                    if (machineGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(machineGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                machineLine = machineGridView.Rows[i].Cells[1].Value.ToString();
                machineName = machineGridView.Rows[i].Cells[2].Value.ToString();

                Machine machine = new Machine(machineLine, machineName);
                adapter.addToDB(machine);
                OraMgr.Instance.insertDB(machine);
            }
            MessageBox.Show("작업 지시(계획) 등록 완료");
            machineGridView.Rows.Clear();
        }

        private void DeleteMachine_Click(object sender, EventArgs e)
        {
            if (machineGridView.SelectedRows.Count != 0)
            {
                int n = machineGridView.SelectedRows[0].Index;
                string machineLine = machineGridView.Rows[n].Cells[1].Value.ToString();
                adapter.deleteFromDB(machineLine);
                MessageBox.Show("선택된 설비관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            machineGridView.Rows.Clear();
        }

        void initGridView(List<Machine> machinelist)
        {
            for (int i = 0; i < machinelist.Count; i++)
            {
                machineGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),
                    machinelist[i].MachineLine,
                    machinelist[i].MachineName
                });
            }
        }
    }
}
