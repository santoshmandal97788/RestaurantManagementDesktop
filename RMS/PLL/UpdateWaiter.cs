
using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.PLL
{
    public partial class UpdateWaiter : Form
    {
   
        public UpdateWaiter()
        {
            InitializeComponent();
        }
        BLLWaiter blw = new BLLWaiter();
        private void UpdateWaiter_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateData();

        }

        private void PopulateData()
        {
            var waiter = blw.GetAllWaiters().Where(s => s.WaiterID == Convert.ToInt32(txtWaiterID.Text)).FirstOrDefault();
            if (waiter != null)
            {
                txtWaiterName.Text = waiter.WaiterName;
                txtAddress.Text = waiter.WaiterAddress;
                txtContact.Text = waiter.WaiterContact;
                txtWaiterID.Enabled=false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtWaiterName.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWaiterName.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Contact Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            WaiterDetails wd = new WaiterDetails();
            wd.WaiterID = Convert.ToInt32(txtWaiterID.Text);
            wd.WaiterName = txtWaiterName.Text;
            wd.WaiterContact = txtContact.Text;
            wd.WaiterAddress = txtAddress.Text;

      
                int i = blw.UpdateWaiter(wd);
                if (i > 0)
                {

                    MessageBox.Show("Waiter Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Waiter From Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int i = blw.DeleteWaiter(Convert.ToInt32(txtWaiterID.Text));
                if (i > 0)
                {

                    MessageBox.Show("Waiter Deleted Successfully");
                    this.Dispose();
                }
            }
        }
      

    } 
}

