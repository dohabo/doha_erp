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
    partial class CompanyUI : UserControl
    {
        BaseAdapter adapter;
        public CompanyUI()
        {
            InitializeComponent();
        }
        public CompanyUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            string companyNum;
            string companyName;
            for (int i = 0; i < companyGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < companyGridView.Columns.Count; j++)
                {
                    if (companyGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(companyGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                companyNum = companyGridView.Rows[i].Cells[0].Value.ToString();
                companyName = companyGridView.Rows[i].Cells[1].Value.ToString();

                Company company = new Company(companyNum, companyName);
                adapter.addToDB(company);
            }
            MessageBox.Show("작업 지시(계획) 등록 완료");
            companyGridView.Rows.Clear();
        }

        private void searchCompany_Click(object sender, EventArgs e)
        {
            companyGridView.Rows.Clear();
            List<Company> companylist = adapter.getCompanyList();
            initGridView(companylist);
        }

        void initGridView(List<Company> companylist)
        {
            for (int i = 0; i < companylist.Count; i++)
            {
                companyGridView.Rows.Add(new string[]
                {
                    companylist[i].CompanyNum,
                    companylist[i].CompanyName
                });
            }
        }

        private void DeleteCompany_Click(object sender, EventArgs e)
        {
            if (companyGridView.SelectedRows.Count != 0)
            {
                int n = companyGridView.SelectedRows[0].Index;
                int companyNum = int.Parse(companyGridView.Rows[n].Cells[0].Value.ToString());
                adapter.deleteCompanyDB(companyNum);
                MessageBox.Show("선택된 사업장 관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            companyGridView.Rows.Clear();
        }
    }
}
