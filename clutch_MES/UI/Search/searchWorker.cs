using clutch_MES.Adapter;
using clutch_MES.Model;
using clutch_MES.UI.MainFucntion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.UI.Search
{
    partial class searchWorker : Form
    {
        BaseAdapter adapter;
        AddWorkUI addworkUI;
        CheckWorkedUI checkworkedUI;
        PurchaseUI purchaseUI;
        InStock instock;
        OutStock outstock;
        StockManage stockmanage;
        string workerID;
        string workerName;

        public string WorkerName { get => workerName; set => workerName = value; }
        public string WorkerID { get => workerID; set => workerID = value; }

        public searchWorker()
        {
            InitializeComponent();
        }
        public searchWorker(AddWorkUI addworkUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.addworkUI = addworkUI;
        }

        public searchWorker(StockManage stockmanage, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.stockmanage = stockmanage;
        }
        public searchWorker(InStock instock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.instock = instock;
        }
        public searchWorker(OutStock outstock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.outstock = outstock;
        }
        public searchWorker(PurchaseUI purchaseUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.purchaseUI = purchaseUI;
        }
        public searchWorker(CheckWorkedUI checkworkedUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            this.checkworkedUI = checkworkedUI;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void search_Click(object sender, EventArgs e)
        {
            workerListView.Items.Clear();
            string workerName = name.Text;
            List<Worker> list = adapter.getWorkerList(workerName);
            initWorkerListView(list);
        }

        public void initWorkerListView(List<Worker> workerList)
        {
            for (int i = 0; i < workerList.Count; i++)
            {
                workerListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    workerList[i].WorkerID.ToString(),
                    workerList[i].WorkerName
                }));
            }
        }

        private void workerListView_DoubleClick(object sender, EventArgs e)
        {
            int n = workerListView.SelectedItems[0].Index;
            this.workerID = workerListView.Items[n].SubItems[1].Text;
            Close();
        }
    }
}
