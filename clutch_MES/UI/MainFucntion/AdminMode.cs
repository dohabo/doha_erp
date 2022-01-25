using clutch_MES.Adapter;
using clutch_MES.DAO;
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
    public partial class AdminMode : UserControl
    {
        const string UC_NAME_ADMINUI = "AdminUI";

        public AdminMode()
        {
            InitializeComponent();
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {
            
        }
        public void controllView(UserControl uc, string viewName)
        {
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }
        private void loginOK_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI();
            controllView(adminUI, UC_NAME_ADMINUI);
        }
        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
