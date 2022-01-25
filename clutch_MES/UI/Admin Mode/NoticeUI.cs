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
    partial class NoticeUI : UserControl
    {
        BaseAdapter adapter;
        public NoticeUI()
        {
            InitializeComponent();
        }

        public NoticeUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void addNotice_Click(object sender, EventArgs e)
        {
            int contentsNum;
            string contents;
            string writeName;
            string writeDate;
            for (int i = 0; i < noticeGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < noticeGridView.Columns.Count; j++)
                {
                    if (noticeGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show(noticeGridView.Columns[j].HeaderText.ToString()
                            + "정보가 누락됐습니다. 확인 바랍니다.");
                        return;
                    }
                }
                contentsNum = int.Parse(noticeGridView.Rows[i].Cells[0].Value.ToString());
                contents = noticeGridView.Rows[i].Cells[1].Value.ToString();
                writeName = noticeGridView.Rows[i].Cells[2].Value.ToString();
                writeDate = noticeGridView.Rows[i].Cells[3].Value.ToString();

                Notice notice = new Notice(contentsNum, contents, writeName, writeDate);
                adapter.addToDB(notice);
            }
            MessageBox.Show("작업 지시(계획) 등록 완료");
            noticeGridView.Rows.Clear();
        }

        private void searcNotice_Click(object sender, EventArgs e)
        {
            noticeGridView.Rows.Clear();
            List<Notice> noticelist = adapter.getNoticeList();
            initGridView(noticelist);
        }

        void initGridView(List<Notice> noticelist)
        {
            for (int i = 0; i < noticelist.Count; i++)
            {
                noticeGridView.Rows.Add(new string[]
                {
                    noticelist[i].ContensNum.ToString(),
                    noticelist[i].Contents,
                    noticelist[i].WriteName,
                    noticelist[i].WriteDate
                });
            }
        }

        private void DeleteNotice_Click(object sender, EventArgs e)
        {
            if (noticeGridView.SelectedRows.Count != 0)
            {
                int n = noticeGridView.SelectedRows[0].Index;
                int cotentsNum = int.Parse(noticeGridView.Rows[n].Cells[0].Value.ToString());
                adapter.deleteFromDB(cotentsNum);
                MessageBox.Show("선택된 설비관련 정보 삭제 완료");
            }
            else
            {
                MessageBox.Show("삭제할 정보의 라인을 선택하세요");
            }
            noticeGridView.Rows.Clear();
        }
    }
}
