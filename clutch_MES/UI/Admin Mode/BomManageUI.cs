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

namespace clutch_MES.UI.Admin_Mode
{
    partial class BomManageUI : UserControl
    {
        BaseAdapter adapter;
        public BomManageUI()
        {
            InitializeComponent();
        }
        public BomManageUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void defectGridView_Enter(object sender, EventArgs e)
        {
            
        }

        private void bomGridView_KeyDown(object sender, KeyEventArgs e)
        {
            bomGridView.Rows.Add();
        }

        private void bomGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void AddParentsCode_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < bomGridView.Rows.Count; i++)
            {
                bomGridView.Rows[i].Cells[1].Value = tboxParentsCode.Text;
            }
        }

        private void AddChildeCode_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bomGridView.Rows.Count; i++)
            {
                bomGridView.Rows[i].Cells[2].Value = tboxChildCode.Text;
            }
        }

        private void tboxParentsCode_TextChanged(object sender, EventArgs e)
        {
            tboxParentsName.Text = adapter.getItemCodeName(tboxParentsCode.Text);
        }

        private void tboxChildCode_TextChanged(object sender, EventArgs e)
        {
            tboxChildName.Text = adapter.getItemCodeName(tboxChildCode.Text);
        }

        private void searchParentsCode_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxParentsCode.Text = searchitem.ItemCode;
        }

        private void searchChildCode_Click(object sender, EventArgs e)
        {
            searchItem searchitem = new searchItem(this, adapter);
            searchitem.ShowDialog();
            tboxChildCode.Text = searchitem.ItemCode;
        }

        private void searchBOM_Click(object sender, EventArgs e)
        {
            bomGridView.Rows.Clear();
            List<BOM> bomlist = adapter.getBOMList();
            initGridView(bomlist);
        }

        void initGridView(List<BOM> BOMlist)
        {
            for (int i = 0; i < BOMlist.Count; i++)
            {
                bomGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),
                    BOMlist[i].PNum,
                    BOMlist[i].CNum,
                    BOMlist[i].Quantity.ToString()
                });
            }
        }

        void initGridView(List<Company> companylist)
        {
            for (int i = 0; i < companylist.Count; i++)
            {
                bomGridView.Rows.Add(new string[]
                {
                    companylist[i].CompanyNum,
                    companylist[i].CompanyName
                });
            }
        }

        private void addBOM_Click(object sender, EventArgs e)
        {
            string pNum;
            string cName;
            int quantity;
            for (int i = 0; i < bomGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < bomGridView.Columns.Count; j++)
                {
                    if (bomGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(bomGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                pNum = bomGridView.Rows[i].Cells[1].Value.ToString();
                cName = bomGridView.Rows[i].Cells[2].Value.ToString();
                quantity = int.Parse(bomGridView.Rows[i].Cells[3].Value.ToString());

                BOM bom = new BOM(pNum, cName, quantity);
                adapter.addToDB(bom);
            }
            MessageBox.Show("작업 지시(계획) 등록 완료");
            bomGridView.Rows.Clear();
        }

        private void DeleteBOM_Click(object sender, EventArgs e)
        {
            if (bomGridView.SelectedRows.Count != 0)
            {
                int n = bomGridView.SelectedRows[0].Index;
                string pnum = bomGridView.Rows[n].Cells[1].Value.ToString();
                string qnum = bomGridView.Rows[n].Cells[2].Value.ToString();
                int quantity = int.Parse(bomGridView.Rows[n].Cells[3].Value.ToString());
                adapter.deleteBOMDB(pnum,qnum,quantity);
                MessageBox.Show("선택된 사업장 관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            bomGridView.Rows.Clear();
        }
    }
}
