using clutch_MES.Adapter;
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
    partial class AddWorkedUI : UserControl
    {
        BaseAdapter adapter;

        public AddWorkedUI()
        {
            InitializeComponent();
        }

        public AddWorkedUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter; 
        }


        private void searchWork_Click(object sender, EventArgs e)
        {
            if (machineCombo.Text == "")
            {
                MessageBox.Show("설비라인을 선택하세요");
                return;
            }
            addedWorkListView.Items.Clear();
            string machineLine = machineCombo.Text;

            if (machineCombo.Text != "전체")
            {
                machineLine = machineCombo.Text.Substring(0, 4);
            }
            List<Work> worklist = adapter.getWorkDB(machineLine);
            initWorkListView(worklist);
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

        private void workedQuantity_TextChanged(object sender, EventArgs e)
        {
            int temp = int.Parse(workedQuantity.Text) - int.Parse(quantity.Text);
            if (temp > 0)
            {
                MessageBox.Show("생산지시된 수량보다 많습니다. 수량을 확인 해주세요");
                return;
            }
            else
            {
                defectQuantity.Text =
                (int.Parse(quantity.Text) - int.Parse(workedQuantity.Text)).ToString();
            }
        }

        private void addWork_Click(object sender, EventArgs e)
        {
            Worked worked = new Worked(
                int.Parse(workOrderNum.Text), workedDate.Text,
                int.Parse(defectQuantity.Text), defectCode.Text.Substring(0, 9),
                int.Parse(workedQuantity.Text)
                );
            adapter.addToDB(worked);

            MessageBox.Show("작업 내역 등록 완료");
            
        }

        private void AddWorkedUI_Load(object sender, EventArgs e)
        {
            workedDate.Value = DateTime.Now;
            List<Machine> machineList = adapter.getMachineList();
            for (int i = 0; i < machineList.Count; i++)
            {
                machineCombo.Items.Add(machineList[i].MachineLine + "   " +
                    machineList[i].MachineName);
            }

            List<Defect> defectList = adapter.getDefectList();
            for (int i = 0; i < defectList.Count; i++)
            {
                defectCode.Items.Add(defectList[i].DefectCode + "   " +
                    defectList[i].DefectName);
            }
        }

        private void addedWorkListView_DoubleClick(object sender, EventArgs e)
        {
            int n = addedWorkListView.SelectedItems[0].Index;
            workOrderNum.Text = addedWorkListView.Items[n].SubItems[0].Text;
            machinLine.Text = addedWorkListView.Items[n].SubItems[2].Text;
            person.Text = addedWorkListView.Items[n].SubItems[3].Text;
            item.Text = addedWorkListView.Items[n].SubItems[4].Text;
            quantity.Text = addedWorkListView.Items[n].SubItems[5].Text;

            lviewBOM.Items.Clear();
            List<BOM> bomlist = adapter.getBOMList(item.Text);
            if(bomlist.Count == 0)
            {
                MessageBox.Show("등록된 BOM이 없습니다.");
            }
            BOMListView(bomlist);
        }

        public void BOMListView(List<BOM> bomlist)
        {
            for (int i = 0; i < bomlist.Count; i++)
            {
                lviewBOM.Items.Add(new ListViewItem(new string[]
                {
                    bomlist[i].PNum.ToString(),
                    bomlist[i].CNum.ToString(),
                    bomlist[i].Quantity.ToString()
                }));
            }
        }

        private void defectQuantity_TextChanged(object sender, EventArgs e)
        {
            if (defectQuantity.Text == "0")
            {
                defectCode.Text = "0-000-000   해당사항 없음";
            }
        }
    }
}
