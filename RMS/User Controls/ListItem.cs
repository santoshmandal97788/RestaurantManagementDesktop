using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;
using RMS.PLL;

namespace RMS.User_Controls
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
           
        }
        public event EventHandler pictureBoxClick;
      

        BLLFoodItem blf = new BLLFoodItem();
        #region Properties
        private int _id;
        private Color _iconBack;
        private string _title;
        private string _message;
        private Image _icon;

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; lblId.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        [Category("Custom Props")]


        #endregion

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        NewOrder frm = new NewOrder();
       
     
        

        private void LoadGridView()
        {
            int id = Convert.ToInt32(lblId.Text);
            //row = Convert.ToInt32(foodGridView.CurrentRow.Index.ToString());

            FIlterFoodDetails foodItem1 = blf.GetFilterFoodItems().Where(sc => sc.Id == id).FirstOrDefault();
            int i = frm.dataGridView1.Rows.Count;
            ////dataGridView1.Rows.Clear();
            frm.dataGridView1.Rows.Add();
            frm.dataGridView1.Rows[i].Cells["ColSN"].Value = frm.dataGridView1.Rows.Count;
            frm.dataGridView1.Rows[i].Cells["ColItem"].Value = foodItem1.FoodName;
            frm.dataGridView1.Rows[i].Cells["ColQty"].Value = 1;
            ////dataGridView1.Rows[i].Cells["ColQty"].Value = (dataGridView1.Rows[i].Cells["ColQty"] as DataGridViewComboBoxCell).Items[0];
            int Qty = Convert.ToInt32(frm.dataGridView1.Rows[i].Cells["ColQty"].Value);
            frm.dataGridView1.Rows[i].Cells["ColRate"].Value = foodItem1.Price;
            int Rate = Convert.ToInt32(frm.dataGridView1.Rows[i].Cells["ColRate"].Value);
            int Total = Qty * Rate;
            frm.dataGridView1.Rows[i].Cells["ColTotal"].Value = Total;
            //// foodGridView.Rows[e.RowIndex].Visible = false;

            //CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[foodGridView.DataSource];
            //currencyManager1.SuspendBinding();
            //foodGridView.Rows[row].Visible = false;
            //currencyManager1.ResumeBinding();



            //// foodGridView.Rows[row].Visible = false;
            ////foodGridView.CurrentRow.Visible = false;
            frm.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = default;
        }
        protected virtual void OnPictureBoxClick(EventArgs e)
        {
            pictureBoxClick?.Invoke(this, e);
        }
    }
        //int id = 0;
        ////int foodid = 0;
        //int row = 0;
        //private void foodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    
        //    //dataGridView1.Visible = true;





        //    id = Convert.ToInt32(foodGridView.CurrentRow.Cells[0].Value.ToString());
        //    row = Convert.ToInt32(foodGridView.CurrentRow.Index.ToString());

        //    FoodItemDetails foodItem1 = blf.GetFilterFoodItems().Where(sc => sc.Id == id).FirstOrDefault();
        //    int i = dataGridView1.Rows.Count ;
        //    //dataGridView1.Rows.Clear();
        //    dataGridView1.Rows.Add();
        //    dataGridView1.Rows[i].Cells["ColSN"].Value = dataGridView1.Rows.Count ;
        //    dataGridView1.Rows[i].Cells["ColItem"].Value = foodItem1.FoodName;
        //    dataGridView1.Rows[i].Cells["ColQty"].Value = 1;
        //    //dataGridView1.Rows[i].Cells["ColQty"].Value = (dataGridView1.Rows[i].Cells["ColQty"] as DataGridViewComboBoxCell).Items[0];
        //    int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColQty"].Value);
        //    dataGridView1.Rows[i].Cells["ColRate"].Value = foodItem1.Price;
        //    int Rate = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColRate"].Value);
        //    int Total = Qty * Rate;
        //    dataGridView1.Rows[i].Cells["ColTotal"].Value = Total;
        //    // foodGridView.Rows[e.RowIndex].Visible = false;

        //    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[foodGridView.DataSource];
        //    currencyManager1.SuspendBinding();
        //    foodGridView.Rows[row].Visible = false;
        //    currencyManager1.ResumeBinding();



        //   // foodGridView.Rows[row].Visible = false;
        //    //foodGridView.CurrentRow.Visible = false;
        //    this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = default;
        //}
}

