using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.IO;
using BLL;
using BO;
using System.Drawing.Imaging;

namespace RMS.User_Controls
{
    public partial class NewFoodItem : UserControl
    {

        public NewFoodItem()
        {
            InitializeComponent();
        }
       
        BLLFoodItem bft = new BLLFoodItem();
        BLLCategory blc = new BLLCategory();
        private void LoadCategory()
        {
            List<CategoryDetails> lstcat = blc.GetAllCategory();
            CategoryDetails pro = new CategoryDetails();
            pro.CategoryName = "Choose Category";
            lstcat.Insert(0, pro);

            cmbCategoryName.DataSource = lstcat;
            cmbCategoryName.DisplayMember = "CategoryName";
            //cmbCategoryName.ValueMember = "Id";
        }
        private void LoadDataGrid()
        {
           /* List<FoodItemDetails> lstfoodItem = bft.GetAllFoodItems();
            foodGridView.DataSource = lstfoodItem;*/
        }
        private void NewFoodItem_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadGrid();
           // LoadDataGrid();
        }


        private void btnAddFoodItems_Click(object sender, EventArgs e)
        {
            if (cmbCategoryName.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Category", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategoryName.Focus();
                return;
            }
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
            FoodItemDetails fd = new FoodItemDetails();
            fd.CategoryName = cmbCategoryName.Text;
            fd.FoodName = txtFoodName.Text;
            fd.Price = txtPrice.Text;

            if (btnRadioActive.Checked)
            {
                fd.Status = 1.ToString();
            }
           
            else
            {
                fd.Status = 0.ToString();
            }
            if (isSpecialCheckBox.Checked)
            {
                fd.IsSpecial = 1.ToString();
            }
            else
            {
                fd.IsSpecial = 0.ToString();
            }
            if (txtDiscount.Text=="")
            {
                fd.Discount = 0.ToString();
            }
            else
            {
                fd.Discount = txtDiscount.Text;
            }
           
            
            fd.Image = img;
            int i = bft.AddNewFoodItem(fd);
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show("New Food Item Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }


        }
      
        private void Clear()
        {
            cmbCategoryName.SelectedIndex = 0;
            txtFoodName.Text = "";
            txtPrice.Text = "";
            btnRadioActive.Checked = true;
            isSpecialCheckBox.Checked = true;
            txtDiscount.Text = "";
            pictureBox1.ImageLocation = Application.StartupPath + "\\add-user.png";
            btnUploadImage.Visible = true;
            btnRemoveImage.Visible = false;
            cmbCategoryName.Focus();

        }

        private void LoadGrid()
        {
            BLLFoodItem blf = new BLLFoodItem();
            List<FoodItemDetails> lstcd = blf.GetAllFoodItems();
            foodGridView.DataSource = lstcd;
            for (int i = 0; i < foodGridView.Columns.Count; i++)
                if (foodGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)foodGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            DataGridViewRow row = foodGridView.RowTemplate;
            row.Height = 50;
        }
        //string filename = "";
        //string defaultfilename = "";
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Please Choose FoodItem Image";
            //ofd.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
            //ofd.Multiselect = false;
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{

            //    filename = ofd.FileName;
            //    pictureBox1.ImageLocation = ofd.FileName;
            //    btnRemoveImage.Visible = true;
            //    btnUploadImage.Visible = false;
            //}


            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
            btnRemoveImage.Visible = true;
            btnUploadImage.Visible = false;
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            // pictureBox1.ImageLocation = Application.StartupPath + "\\NoImage.jpg";
            pictureBox1.ImageLocation =Application.StartupPath + "\\add-user.png";
            btnUploadImage.Visible = true;
            btnRemoveImage.Visible = false;
        }
    }
}
