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
    partial class searchMachine : Form
    {
        AddWorkUI addworkUI;
        CheckWorkedUI checkworkedUI;
        BaseAdapter adapter;
        OutStock outstock;
        string machineLineNum;

        public string MachineLineNum { get => machineLineNum; set => machineLineNum = value; }

        public searchMachine()
        {
            InitializeComponent();
        }

        public searchMachine(AddWorkUI addworkUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.addworkUI = addworkUI;
            this.adapter = adapter;
        }

        public searchMachine(CheckWorkedUI checkworkedUI, BaseAdapter adapter)
        {
            InitializeComponent();
            this.checkworkedUI = checkworkedUI;
            this.adapter = adapter;
        }
        public searchMachine(OutStock outstock, BaseAdapter adapter)
        {
            InitializeComponent();
            this.outstock = outstock;
            this.adapter = adapter;
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
            machineListView.Items.Clear();
            string machineName = name.Text;
            List<Machine> list = adapter.getMachineList(machineName);
            initMachineListView(list);
        }

        public void initMachineListView(List<Machine> machineList)
        {
            for (int i = 0; i < machineList.Count; i++)
            {
                machineListView.Items.Add(new ListViewItem(new string[]
                {
                    machineList[i].MachineLine,
                    machineList[i].MachineName
                }));
            }
        }

        private void machineListView_DoubleClick_1(object sender, EventArgs e)
        {
            int n = machineListView.SelectedItems[0].Index;
            this.machineLineNum = machineListView.Items[n].SubItems[0].Text;
            Close();
        }
    }
}
