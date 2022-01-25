using clutch_MES.Adapter;
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
    partial class WareHouseUI : UserControl
    {
        BaseAdapter adapter;
        public WareHouseUI()
        {
            InitializeComponent();
        }
        public WareHouseUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
    }
}
