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

namespace clutch_MES.UI.Details
{
    partial class DefectUI : UserControl
    {
        BaseAdapter adapter;
        public DefectUI()
        {
            InitializeComponent();
        }

        public DefectUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void addDefect_Click(object sender, EventArgs e)
        {
            string defectCode;
            string defectName;
            for (int i = 0; i < defectGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < defectGridView.Columns.Count; j++)
                {
                    if (defectGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(defectGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                defectCode = defectGridView.Rows[i].Cells[0].Value.ToString();
                defectName = defectGridView.Rows[i].Cells[1].Value.ToString();

                Defect defect = new Defect(defectCode, defectName);
                adapter.addToDB(defect);
            }
            MessageBox.Show("불량유형 등록 완료");
            defectGridView.Rows.Clear();
        }

        private void searchDefect_Click(object sender, EventArgs e)
        {
            defectGridView.Rows.Clear();
            List<Defect> defectlist = adapter.getDefectList();
            initGridView(defectlist);
        }

        void initGridView(List<Defect> defectlist)
        {
            for (int i = 0; i < defectlist.Count; i++)
            {
                defectGridView.Rows.Add(new string[]
                {
                    defectlist[i].DefectCode,
                    defectlist[i].DefectName
                });
            }
        }

        private void DeleteDefect_Click(object sender, EventArgs e)
        {
            if (defectGridView.SelectedRows.Count != 0)
            {
                int n = defectGridView.SelectedRows[0].Index;
                string defectCode = defectGridView.Rows[n].Cells[0].Value.ToString();
                adapter.deleteDefectDB(defectCode);
                MessageBox.Show("선택된 불량유형 관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            defectGridView.Rows.Clear();
        }
    }
}
