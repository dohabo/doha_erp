using clutch_MES.Adapter;
using clutch_MES.Model;
using Sunny.UI;
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
    partial class UIHome : UserControl
    {
        BaseAdapter adapter;
        public UIHome()
        {
            InitializeComponent();
        }

        public UIHome(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void UIHome_Load(object sender, EventArgs e)
        {
            
            noticeListView.Items.Clear();
            List<Notice> noticelist = adapter.getNoticeList();
            initNoticeListView(noticelist);

            List<Machine> machineList = adapter.getMachineList();
            List<Items> itemsList = adapter.getItemsList();
            items.Text = "전체";
            line.Text = "전체";

            for(int i = 0; i < machineList.Count; i++)
            {
                line.Items.Add(machineList[i].MachineLine);
            }
            for (int i = 0; i < itemsList.Count; i++)
            {
                items.Items.Add(itemsList[i].ItemCode);
            }
            initPieChart();
        }

        void initNoticeListView(List<Notice> noticelist)
        {
            for (int i = 0; i < noticelist.Count; i++)
            {
                noticeListView.Items.Add(new ListViewItem(new string[]
                {
                    noticelist[i].ContensNum.ToString(),
                    noticelist[i].Contents,
                    noticelist[i].WriteName,
                    noticelist[i].WriteDate
                }));
            }
        }

        private void items_TextChanged(object sender, EventArgs e)
        {
            itemListView.Items.Clear();
            string item = items.Text;
            List<workJoinVo> list = adapter.getItemJoinList(item);
            initItemListView(list);
        }

        void initItemListView(List<workJoinVo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                double workq = list[i].WorkQuantity;
                double workedq = list[i].Workedquantity;
                string record = ((workedq / workq) * 100).ToString(".00");

                itemListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    list[i].ItemCode,
                    list[i].ItemName,
                    list[i].WorkQuantity.ToString(),
                    list[i].Workedquantity.ToString(),
                    record + "%"
                }));
            }
        }

        private void line_TextChanged(object sender, EventArgs e)
        {
            LineListView.Items.Clear();
            string machine = line.Text;
            List<workJoinVo> list = adapter.getMachineJoinList(machine);
            initMachineListView(list);
        }

        void initMachineListView(List<workJoinVo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                double workq = list[i].WorkQuantity;
                double workedq = list[i].Workedquantity;
                string record = ((workedq / workq) * 100).ToString(".00");

                LineListView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    list[i].MachineLine,
                    list[i].WorkQuantity.ToString(),
                    list[i].Workedquantity.ToString(),
                    record + "%"
                }));
            }
        }

        void initPieChart()
        {
            var option = new UIPieOption();
            option.Title = new UITitle();
            option.Title.Text = "유형별 불량율";
            //option.Title.SubText = "부제목";
            option.Title.Left = UILeftAlignment.Center;
            option.ToolTip = new UIPieToolTip();

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;


            List<workJoinVo> defectList = adapter.getDefectJoinList();
            var series = new UIPieSeries();
            for (int i = 0; i < defectList.Count; i++)
            {
                option.Legend.AddData(defectList[i].DefectName);
                series.AddData(defectList[i].DefectName,
                    defectList[i].DefectQuantity);
            }
            //series.Name = defectList[i].DefectName;
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            option.Series.Add(series);
            uiPieChart1.SetOption(option);
        }
    }
}
