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
    partial class OpeningStokcUI : UserControl
    {
        BaseAdapter adapter;
        public OpeningStokcUI()
        {
            InitializeComponent();
        }
        public OpeningStokcUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }
    }
}
