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
using System.Data.SqlClient;
using System.Configuration;

namespace RMS.User_Controls
{
    public partial class AllFoodItems : UserControl
    {
        
        public AllFoodItems()
        {
            InitializeComponent();
        }
        BLLFoodItem bft = new BLLFoodItem();
        DataTable dt = new DataTable("tbl_fooditems");
        private void AllFoodItems_Load(object sender, EventArgs e)
        {
           
            LoadGrid();
        }

        private void LoadGrid()
        {
            List<FoodItemDetails> lstfd = bft.GetAllFoodItems();
            foodGridView.DataSource = lstfd;
            for (int i = 0; i < foodGridView.Columns.Count; i++)
                if (foodGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)foodGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            DataGridViewRow row = foodGridView.RowTemplate;
            row.Height = 40;
        }

        private void bunifuMetroSearchBox_OnValueChanged(object sender, EventArgs e)
        {
            List<FoodItemDetails> lstfd = bft.GetAllFoodItems().Where(s => s.FoodName.StartsWith(bunifuMetroSearchBox.Text)).ToList();
            foodGridView.DataSource = lstfd;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItems frm = new UpdateItems();
            frm.Show();
        }

        private void bunifuMetroSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
