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

namespace RMS
{
    public partial class CategoryUpdateDelete : Form
    {
        public CategoryUpdateDelete()
        {
            InitializeComponent();
        }
        BLLCategory blc = new BLLCategory();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }
            CategoryDetails cd = new CategoryDetails();
            cd.Id = Convert.ToInt32(txtId.Text);
            cd.CategoryName = txtCategoryName.Text;
            cd.AddedDate = System.DateTime.Now;

            bool isexists = blc.CheckCategory(txtCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Category Already Exists in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
            }
            else
            {
                int i = blc.UpdateCategory(cd);
                if (i > 0)
                {

                    MessageBox.Show("Category Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                    
                }
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Category Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                int i = blc.DeleteCategory(Convert.ToInt32(txtId.Text));
                if (i > 0)
                {
                   
                    MessageBox.Show("Category Deleted Successfully");
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                }
            }
        }
    }
}
