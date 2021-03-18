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
    public partial class TableUpdateDelete : Form
    {
        public TableUpdateDelete()
        {
            InitializeComponent();
        }
        BLLTable blt = new BLLTable();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTableNumber.Text == "")
            {
                MessageBox.Show("Please Enter Table Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTableNumber.Focus();
                return;
            }
            TableDetails td = new TableDetails();
            td.Id = Convert.ToInt32(txtId.Text);
            td.TableNumber = txtTableNumber.Text;
            td.AddedDate = System.DateTime.Now;

            bool isexists = blt.CheckTable(txtTableNumber.Text);
            if (isexists)
            {
                MessageBox.Show("Table Number Already Exists in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
            else
            {
                int i = blt.UpdateTable(td);
                if (i > 0)
                {

                    MessageBox.Show("Table Number Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
        }

        private void Clear()
        {
            txtTableNumber.Text = "";
            txtTableNumber.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Table Number?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int i = blt.DeleteTable(Convert.ToInt32(txtId.Text));
                if (i > 0)
                {

                    MessageBox.Show("Category Deleted Successfully");
                    Clear();
                }
            }
        }
    }
}
