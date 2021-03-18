using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using DAL;
using BO;
using BLL;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using DGVPrinterHelper;

namespace RMS.User_Controls
{
    public partial class NewOrder : UserControl
    {


        public NewOrder()
        {
            InitializeComponent();
        }
       
        
        RMSDBEntities _db = new RMSDBEntities();
        BLLCustomer blc = new BLLCustomer();
        BLLFoodItem blf = new BLLFoodItem();
        BLLTable blt = new BLLTable();
        BLLWaiter blw = new BLLWaiter();
        BLLCustomer blcus = new BLLCustomer();
        BLLCategory blcat = new BLLCategory();
        BLLOrderedFoodItem blofi = new BLLOrderedFoodItem();

        private void NewOrder_Load(object sender, EventArgs e)
        {
            showData();
            LoadOrderNo();
            txtOrderNo.ReadOnly = true;
            LoadTableNumber();
            LoadWaiter();
            LoadCategory();
            dataGridView1.Columns["ColId"].Visible = false;
        }

        private void showData()
        {
            BLLFoodItem blf = new BLLFoodItem();
            List<FIlterFoodDetails> lstcd = blf.GetFilterFoodItems();
            foodGridView.DataSource = lstcd;
            foodGridView.Columns["Id"].Visible = false;
            foodGridView.Columns["Discount"].Visible = false;
            for (int i = 0; i < foodGridView.Columns.Count; i++)
                if (foodGridView.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)foodGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            DataGridViewRow row = foodGridView.RowTemplate;
            row.Height = 60;
        }

        private void LoadOrderNo()
        {
               var order = blc.GetAllCustomer().OrderByDescending(c => c.CId).Take(1).FirstOrDefault();
            if (order != null)
            {
                string orderNo = order.OrderNo;
                string[] str = orderNo.Split('-');
                int maxno = Convert.ToInt32(str[1].ToString()) + 1;
                txtOrderNo.Text = "SCR-" + maxno.ToString();
            }
            else
            {
                txtOrderNo.Text = "SCR-1";
            }
        }
        private void LoadTableNumber()
        {
             List<TableDetails> lsttb = blt.GetAllTables();
            TableDetails pro = new TableDetails();
            pro.TableNumber = "Choose Table";
            lsttb.Insert(0, pro);

            cmbTable.DataSource = lsttb;
            cmbTable.DisplayMember = "TableNumber";
            cmbTable.ValueMember = "Id";
        }
        private void LoadCategory()
        {
            List<CategoryDetails> lsttb = blcat.GetAllCategory();
            CategoryDetails pro = new CategoryDetails();
            pro.CategoryName = "Choose Category";
            lsttb.Insert(0, pro);

            cmbCategory.DataSource = lsttb;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
        }
        private void LoadWaiter()
        {
             List<WaiterDetails> lstwt = blw.GetAllWaiters();
            WaiterDetails pro = new WaiterDetails();
            pro.WaiterName = "Choose Waiter";
            lstwt.Insert(0, pro);

            cmbWaiter.DataSource = lstwt;
            cmbWaiter.DisplayMember = "WaiterName";
            cmbWaiter.ValueMember = "WaiterID";

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            //foodGridView.DataSource = _db.tbl_fooditems.Where(fooditem => fooditem.FoodName.Contains(SearchBox.Text) || fooditem.CategoryName.Contains(SearchBox.Text)).ToList();

        }
        
        int sn = 0;
        int id1 = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FIlterFoodDetails foodItem1 = blf.GetFilterFoodItems().Where(sc => sc.Id == id1).FirstOrDefault();
            sn = Convert.ToInt32(dataGridView1.CurrentRow.Index.ToString());
            int i=dataGridView1.Rows.Count;
            int num = Convert.ToInt32(dataGridView1.Rows[sn].Cells["ColQty"].Value);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add")
            {
                //int num= Convert.ToInt32(dataGridView1.Rows[sn].Cells["ColQty"].Value);

                //count++;

                num++;
                dataGridView1.Rows[sn].Cells["ColQty"].Value =num;
                int Qty = Convert.ToInt32(dataGridView1.Rows[sn].Cells["ColQty"].Value);
                double Rate = Convert.ToDouble(dataGridView1.Rows[sn].Cells["ColRate"].Value);

                double Total = Qty * Rate;
                double discountPercentage = Convert.ToDouble(foodItem1.Discount);
                double discountAmount = (discountPercentage / 100) * Total;
                dataGridView1.Rows[sn].Cells["ColDiscount"].Value = discountAmount;
                
                dataGridView1.Rows[sn].Cells["ColTotal"].Value = Total;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                
                if (num==1)
                {
                    num = 1;
                }
                else
                {
                    num--;
                }
                dataGridView1.Rows[sn].Cells["ColQty"].Value = num;
                int Qty = Convert.ToInt32(dataGridView1.Rows[sn].Cells["ColQty"].Value);
                double Rate = Convert.ToDouble(dataGridView1.Rows[sn].Cells["ColRate"].Value);
               
                double Total = Qty * Rate;
                double discountPercentage = Convert.ToDouble(foodItem1.Discount);
                double discountAmount = (discountPercentage / 100) * Total;
                dataGridView1.Rows[sn].Cells["ColDiscount"].Value = discountAmount;
                dataGridView1.Rows[sn].Cells["ColTotal"].Value = Total;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
            {
                //if (i==1)
                //{
                    if (MessageBox.Show("Are You Sure Want to Remove ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(sn);
                     // dataGridView1.Rows[sn].Cells["ColSN"].Value = dataGridView1.Rows.Count;

                    }

            }
            double sum = 0;
            double discount = 0;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {

                sum = Convert.ToDouble(dataGridView1.Rows[j].Cells["ColTotal"].Value) + sum;
                discount = Convert.ToDouble(dataGridView1.Rows[j].Cells["ColDiscount"].Value) + discount;

            }
          

            labelSubTotal.Text = sum.ToString();
            lblDiscount.Text = discount.ToString();
            double subTotalAfterGettingDiscount = sum - discount;
            double vatPercentage = Properties.Settings.Default.VAT;
            double vatAMt = (vatPercentage / 100);
            lblVat.Text = (vatAMt * subTotalAfterGettingDiscount).ToString();
            double subTotal = subTotalAfterGettingDiscount;
            double vat = Convert.ToDouble(lblVat.Text);
            double serviceCharge = Properties.Settings.Default.ServiceCharge;
            //double discountAmt = discount;
            //double total1 = (subTotal - discount);
            double total = (subTotalAfterGettingDiscount + vat + serviceCharge);
            lblTotal.Text = total.ToString();

        }
        int id = 0;
        int row = 0;
        private void foodGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(foodGridView.CurrentRow.Cells[0].Value.ToString());
            row = Convert.ToInt32(foodGridView.CurrentRow.Index.ToString());
            FIlterFoodDetails foodItem1 = blf.GetFilterFoodItems().Where(sc => sc.Id == id).FirstOrDefault();
            int i = dataGridView1.Rows.Count;

            if (i == 0)
            {
                //dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["ColId"].Value = id;
                // dataGridView1.Columns["ColId"].Visible = false;
                dataGridView1.Rows[i].Cells["ColItem"].Value = foodItem1.FoodName;
                dataGridView1.Rows[i].Cells["ColQty"].Value = 1;
                //dataGridView1.Rows[i].Cells["ColQty"].Value = (dataGridView1.Rows[i].Cells["ColQty"] as DataGridViewComboBoxCell).Items[0];
                int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColQty"].Value);
                dataGridView1.Rows[i].Cells["ColRate"].Value = foodItem1.Price;
                double discountPercentage = Convert.ToDouble(foodItem1.Discount);
                double discountAmount = (discountPercentage / 100) * Convert.ToDouble(foodItem1.Price);
                dataGridView1.Rows[i].Cells["ColDiscount"].Value = discountAmount;
                double Rate = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColRate"].Value);
                double Total = Qty * Rate;

                dataGridView1.Rows[i].Cells["ColTotal"].Value = Total;
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[foodGridView.DataSource];
                currencyManager1.SuspendBinding();
                foodGridView.Rows[row].Visible = false;
                currencyManager1.ResumeBinding();
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = default;
                // code for Bill 
                lblServiceCharge.Text = Properties.Settings.Default.ServiceCharge.ToString();
                double sum = 0;
                double discount = 0;
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {

                    sum = Convert.ToDouble(dataGridView1.Rows[k].Cells["ColTotal"].Value) + sum;
                    discount = Convert.ToDouble(dataGridView1.Rows[k].Cells["ColDiscount"].Value) + discount;
                }
                
                labelSubTotal.Text = sum.ToString();
                lblDiscount.Text = discount.ToString();
                double subTotalAfterGettingDiscount = sum - discount;
                double vatPercentage = Properties.Settings.Default.VAT;
                double vatAMt = (vatPercentage / 100);
                lblVat.Text = (vatAMt * subTotalAfterGettingDiscount).ToString();
                double subTotal = subTotalAfterGettingDiscount;
                double vat = Convert.ToDouble(lblVat.Text);
                double serviceCharge = Properties.Settings.Default.ServiceCharge;
                //double discountAmt = discount;
                //double total1 = (subTotal - discount);
                double total = (subTotalAfterGettingDiscount + vat + serviceCharge);
                lblTotal.Text = total.ToString();
            }
            else
            {

                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[j].Cells["ColId"].Value) == id)
                    {
                        MessageBox.Show("FoodItem Already Ordered");
                        // break;
                        return;
                    }
                }
                    //else
                    //{
                        //dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["ColId"].Value = id;
                        // dataGridView1.Columns["ColId"].Visible = false;
                        dataGridView1.Rows[i].Cells["ColItem"].Value = foodItem1.FoodName;
                        dataGridView1.Rows[i].Cells["ColQty"].Value = 1;
                        //dataGridView1.Rows[i].Cells["ColQty"].Value = (dataGridView1.Rows[i].Cells["ColQty"] as DataGridViewComboBoxCell).Items[0];
                        int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColQty"].Value);
                        dataGridView1.Rows[i].Cells["ColRate"].Value = foodItem1.Price;
                        double discountPercentage = Convert.ToDouble(foodItem1.Discount);
                        double discountAmount = (discountPercentage / 100) * Convert.ToDouble(foodItem1.Price);
                        dataGridView1.Rows[i].Cells["ColDiscount"].Value = discountAmount;
                        double Rate = Convert.ToInt32(dataGridView1.Rows[i].Cells["ColRate"].Value);
                        double Total = Qty * Rate;

                        dataGridView1.Rows[i].Cells["ColTotal"].Value = Total;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[foodGridView.DataSource];
                        currencyManager1.SuspendBinding();
                        foodGridView.Rows[row].Visible = false;
                        currencyManager1.ResumeBinding();
                        this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = default;
                        // code for Bill 
                        lblServiceCharge.Text = Properties.Settings.Default.ServiceCharge.ToString();
                        double sum = 0;
                        double discount = 0;
                        for (int k = 0; k < dataGridView1.Rows.Count; k++)
                        {

                            sum = Convert.ToDouble(dataGridView1.Rows[k].Cells["ColTotal"].Value) + sum;
                            discount = Convert.ToDouble(dataGridView1.Rows[k].Cells["ColDiscount"].Value) + discount;
                        }

                        labelSubTotal.Text = sum.ToString();
                        lblDiscount.Text = discount.ToString();
                        double subTotalAfterGettingDiscount = sum - discount;
                        double vatPercentage = Properties.Settings.Default.VAT;
                        double vatAMt = (vatPercentage / 100);
                        lblVat.Text = (vatAMt * subTotalAfterGettingDiscount).ToString();
                        double subTotal = subTotalAfterGettingDiscount;
                        double vat = Convert.ToDouble(lblVat.Text);
                        double serviceCharge = Properties.Settings.Default.ServiceCharge;
                        //double discountAmt = discount;
                        //double total1 = (subTotal - discount);
                        double total = (subTotalAfterGettingDiscount + vat + serviceCharge);
                        lblTotal.Text = total.ToString();
                        //break;
                    //}
               // }
            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCustomerName.Text = "";
            radioButtonIn.Checked = true;
            cmbWaiter.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            LoadOrderNo();
            showData();
            dataGridView1.Rows.Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Please Order Food Items", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }
            if (cmbWaiter.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Wiater", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbWaiter.Focus();
                return;
            }
            if (cmbTable.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Table", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTable.Focus();
                return;
            }
            CustomerDetails cd = new CustomerDetails();
            cd.OrderNo = txtOrderNo.Text;
            cd.CustomerName = txtCustomerName.Text;
            if (radioButtonIn.Checked==true)
            {
                cd.CustomerType = true;
            }
            else
            {
                cd.CustomerType = false;
            }
            cd.WaiterId= Convert.ToInt32(cmbWaiter.SelectedValue);
            cd.TableId= Convert.ToInt32(cmbTable.SelectedValue);
            cd.Completed = false.ToString();
            cd.Total = Convert.ToDecimal(lblTotal.Text);
            cd.OrderDate = System.DateTime.Now;

           
            ItemDetails itemDetail = new ItemDetails();
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                itemDetail.OrderNo = txtOrderNo.Text;
                itemDetail.FoodId = Convert.ToInt32(dataGridView1.Rows[j].Cells["ColId"].Value);
                itemDetail.Qty= Convert.ToInt32(dataGridView1.Rows[j].Cells["ColQty"].Value);
                itemDetail.Total= Convert.ToInt32(dataGridView1.Rows[j].Cells["ColTotal"].Value);
                int k = blofi.AddOrderedItem(itemDetail);
            }
            int i = blcus.AddCustomer(cd);
            if (i > 0)
            {
                //Code to Print Bill
                DGVPrinter printer = new DGVPrinter();
                string title = Properties.Settings.Default.Name;
                //string logo= Application.StartupPath + "\\Logo.bmp";
                
                printer.Title = "\r\n\r\n"  + title + " Restaurant";
                printer.SubTitle = "Kathmandu, Nepal \r\n Phone: 9816815884 \r\n";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Discount: " + lblDiscount.Text + "% \r\n" + "VAT: " + lblVat.Text + "% \r\n" + "Service Charge: " + lblServiceCharge.Text + " \r\n" + "Grand Total: " + lblTotal.Text + " \r\n" + "Thankyou Visit Again!";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
                    MessageBox.Show("New Order Placed Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }

        }
        string name;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string name;
            if (cmbCategory.SelectedIndex==0)
            {
                showData();
            }
            else
            {
                name = cmbCategory.Text;
               var lstfd = blf.GetFilterFoodItems().Where(s => s.CategoryName == name).ToList();
                foodGridView.DataSource = lstfd;
            }

        }

        private void bunifuMetroSearchBox_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMetroSearchBox.Text=="")
            {
                lblSearch.Visible = true;

            }
            else
            {
                lblSearch.Visible = false;
            }
            
            if (cmbCategory.SelectedIndex == 0)
            {
                var lstfd = blf.GetFilterFoodItems().Where(s => s.FoodName.Contains(bunifuMetroSearchBox.Text)|| s.CategoryName.Contains(bunifuMetroSearchBox.Text) ).ToList();
                foodGridView.DataSource = lstfd;
            }
            else
            {
               var lstfd = blf.GetFilterFoodItems().Where(s => s.CategoryName == name).ToList();
             var lstfood1 = lstfd.Where(s => s.FoodName.StartsWith(bunifuMetroSearchBox.Text)).ToList();
                foodGridView.DataSource = lstfood1;
            }
        }

        

       
    }
}
