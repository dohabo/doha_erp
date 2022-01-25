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
    partial class Item : UserControl
    {
        BaseAdapter adapter;
        public Item()
        {
            InitializeComponent();
        }

        public Item(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            itemGridView.Rows.Clear();
            List<Items> itemsList = adapter.getItemsList();
            initGridView(itemsList);
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string itemCode;
            string itemName;
            for (int i = 0; i < itemGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < itemGridView.Columns.Count; j++)
                {
                    if (itemGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(itemGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                itemCode = itemGridView.Rows[i].Cells[1].Value.ToString();
                itemName = itemGridView.Rows[i].Cells[2].Value.ToString();

                Items items = new Items(itemCode,itemName);
                adapter.addToDB(items);
            }
            MessageBox.Show("품목 정보 등록 완료");
            itemGridView.Rows.Clear();
        }

        void initGridView(List<Items> itemsList)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                itemGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(),
                    itemsList[i].ItemCode,
                    itemsList[i].ItemName,
                });
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (itemGridView.SelectedRows.Count != 0)
            {
                int n = itemGridView.SelectedRows[0].Index;
                string itemCode = itemGridView.Rows[n].Cells[1].Value.ToString();
                adapter.deleteItemDB(itemCode);
                MessageBox.Show("선택된 품목 관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            itemGridView.Rows.Clear();
        }
    }
}
