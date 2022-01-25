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

namespace clutch_MES.UI.Admin_Mode
{
    partial class SupplierUI : UserControl
    {
        BaseAdapter adapter;

        public SupplierUI()
        {
            InitializeComponent();
        }

        public SupplierUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            supplierGridView.Rows.Clear();
            List<Supplier> supplierlist = adapter.getSupplierList();
            initGridView(supplierlist);
        }
        void initGridView(List<Supplier> supplierlist)
        {
            for (int i = 0; i < supplierlist.Count; i++)
            {
                supplierGridView.Rows.Add(new string[]
                {
                    supplierlist[i].SupplierNum.ToString(),
                    supplierlist[i].SupplierName,
                    supplierlist[i].SellingItem,
                    supplierlist[i].CeoName,
                    supplierlist[i].Adress,
                });
            }
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            int supplierNum;
            string supplierName;
            string sellingItem;
            string ceoName;
            string Adress;

            for (int i = 0; i < supplierGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < supplierGridView.Columns.Count; j++)
                {
                    if (supplierGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(supplierGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                supplierNum = int.Parse(supplierGridView.Rows[i].Cells[0].Value.ToString());
                supplierName = supplierGridView.Rows[i].Cells[1].Value.ToString();
                sellingItem = supplierGridView.Rows[i].Cells[2].Value.ToString();
                ceoName = supplierGridView.Rows[i].Cells[3].Value.ToString();
                Adress = supplierGridView.Rows[i].Cells[4].Value.ToString();

                Supplier supplier = new Supplier(supplierNum, supplierName, sellingItem, ceoName, Adress);
                adapter.addToDB(supplier);
            }
            MessageBox.Show("거래채 등록 완료");
            supplierGridView.Rows.Clear();
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            if (supplierGridView.SelectedRows.Count != 0)
            {
                int n = supplierGridView.SelectedRows[0].Index;
                int supplierNum = int.Parse(supplierGridView.Rows[n].Cells[0].Value.ToString());
                string supplierName = supplierGridView.Rows[n].Cells[1].Value.ToString();
                string sellingItem = supplierGridView.Rows[n].Cells[2].Value.ToString();
                string ceoName = supplierGridView.Rows[n].Cells[3].Value.ToString();
                string Adress = supplierGridView.Rows[n].Cells[4].Value.ToString();
                Supplier supplier = new Supplier(supplierNum, supplierName, sellingItem, ceoName, Adress);
                adapter.deleteSupplierDB(supplier);
                MessageBox.Show("선택된 거래처 관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            supplierGridView.Rows.Clear();
        }
    }
}
