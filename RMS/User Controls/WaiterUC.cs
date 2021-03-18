using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.PLL;
using BO;
using BLL;

namespace RMS.User_Controls
{
    public partial class WaiterUC : UserControl
    {
       
        public WaiterUC()
        {
            InitializeComponent();
        }
        BLLWaiter blw = new BLLWaiter();
        private void btnAddNewWaiter_Click(object sender, EventArgs e)
        {
            using (AddWaiter foodcat = new AddWaiter())
            {
                if (foodcat.ShowDialog() == DialogResult.OK)
                {
                    LoadGrid();
                }
            }
        }
       
        private void LoadGrid()
        {
            List<WaiterDetails> lstwaiter = blw.GetAllWaiters();
            grdWaiterList.DataSource = lstwaiter;
        }

        private void WaiterUC_Load_1(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateWaiter frm = new UpdateWaiter();
            frm.Show();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadGrid();
        }

       
    }
}
