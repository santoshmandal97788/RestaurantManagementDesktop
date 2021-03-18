
using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.PLL
{
    public partial class UpdateItems : Form
    {
        
        public UpdateItems()
        {
            InitializeComponent();
        }

        BLLFoodItem bft = new BLLFoodItem();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void PopulateData()
        {
            var foodItem = bft.GetAllFoodItems().Where(s => s.Id == Convert.ToInt32(txtItemID.Text)).FirstOrDefault();
            if (foodItem != null)
            {
                txtCategoryName.Text = foodItem.CategoryName;
                txtFoodName.Text = foodItem.FoodName;
                txtPrice.Text = foodItem.Price;
                if (foodItem.Status == "Active")
                {
                    radioBtnActive.Checked = true;
                }
               
                else
                {
                    radioBtnInactive.Checked = true;
                }
                if (foodItem.IsSpecial=="Yes")
                {
                    chkIsSpecial.Checked = true;
                }
                else
                {
                    chkIsSpecial.Checked = false;
                }
                txtDiscount.Text = foodItem.Discount;

                Byte[] img = (Byte[])foodItem.Image;

                MemoryStream ms = new MemoryStream(img);

                pictureBox1.Image = Image.FromStream(ms);
                btnDeleteFoodItem.Visible = true;
                btnUpdateFoodItem.Visible = true;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateData();
        }
       
        private void btnUpdateFoodItem_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("Please Enter Food Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFoodName.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please Enter Food Price", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
           
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            FoodItemDetails wd = new FoodItemDetails();
            wd.Id = Convert.ToInt32(txtItemID.Text);
            wd.CategoryName = txtCategoryName.Text;
            wd.FoodName = txtFoodName.Text;
            wd.Price = txtPrice.Text;
            if (radioBtnActive.Checked)
            {
                wd.Status = 1.ToString();
            }

            else
            {
                wd.Status = 0.ToString();
            }
            if (chkIsSpecial.Checked)
            {
                wd.IsSpecial = 1.ToString();
            }
            else
            {
                wd.IsSpecial = 0.ToString();
            }
            wd.Discount = txtDiscount.Text;
          
            wd.Image = img;
            int i = bft.UpdateFoodItem(wd);
            if (i > 0)
            {
                //LoadGrid();
                MessageBox.Show(" Fooditem updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clear();
               

            }

        }

        private void btnDeleteFoodItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Delete Food Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int i = bft.DeleteFoodItem(Convert.ToInt32(txtItemID.Text));
                if (i > 0)
                {

                    MessageBox.Show("Food Item Deleted Successfully");
                    //Clear();
                }
            }
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {
            btnUpdateFoodItem.Enabled = false;
            btnDeleteFoodItem.Enabled = false;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
            btnRemoveImage.Visible = true;
            btnUploadImage.Visible = false;
        }
    }
}
