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
using DAL;
using DGVPrinterHelper;

namespace RMS.User_Controls
{
    public partial class OngoingOrderUserControl : UserControl
    {
        public OngoingOrderUserControl()
        {
            InitializeComponent();
        }
        BLLCustomer blc = new BLLCustomer();
        BLLOrderedFoodItem blofi = new BLLOrderedFoodItem();
       
        RMSDBEntities _db = new RMSDBEntities();
        #region Properties
        private string _tableNo;
        private string _orderNo;
        private string _waiter;
        private string _total;
        private int _id;

        //Custom property for ongoing order
        [Category("Custom Props")]
        public string TableNo
        {
            get { return _tableNo; }
            set { _tableNo = value; lblTable.Text = value; }
        }
        [Category("Custom Props")]
        public string OrderNo
        {
            get { return _orderNo; }
            set { _orderNo = value; lblOrder.Text = value; }
        }

        [Category("Custom Props")]
        public string Waiter
        {
            get { return _waiter; }
            set { _waiter = value; lblWaiter.Text = value; }
        }

        [Category("Custom Props")]
        public string Total
        {
            get { return _total; }
            set { _total = value; lblTotal.Text = value; }
        }
        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; lblId.Text = value.ToString(); }
        }
        #endregion

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        public void btnComplete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked Complete Button");
            int id = Convert.ToInt32(lblId.Text);

            CustomerDetails cd1 = new CustomerDetails();
            tbl_customer cd = _db.tbl_customer.Where(c => c.CId == id).FirstOrDefault();
           
            cd1.CId = cd.CId;
            cd1.OrderNo = cd.OrderNo;
            cd1.CustomerName = cd.CustomerName;
            cd1.CustomerType = cd.CustomerType;
            cd1.WaiterId = cd.WaiterId;
            cd1.TableId = cd.TableId;
            cd1.Completed = true.ToString();
            cd1.Total = cd.Total;
            cd1.OrderDate = cd.OrderDate;
                int i = blc.UpdateCustomer(cd1);


                if (i > 0)
                {
                    OngoingOrder od = new OngoingOrder();
                    MessageBox.Show("Order Completed Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   od. populateOngoingOrder();
                }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Cancel Ordered Food Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(lblId.Text);
                string orderNo = lblOrder.Text;
                int i = blc.DeleteCustomer(Convert.ToInt32(id));
                int j = blofi.DeleteOrderedItem(orderNo);
                if (i > 0)
                {

                    MessageBox.Show("Ordered Cancelled Successfully");
                   
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewOrder frm = new NewOrder();
            frm.Show();
        }
        //public void populateOngoingOrder()
        //{

        //    OngoingOrderUserControl[] listItems = new OngoingOrderUserControl[1];
        //    // FoodItemDetails fd = new FoodItemDetails();
        //    var tb = _db.tbl_customer.Where(a => a.Completed == false).ToList();
        //    foreach (var item in tb)
        //    {
        //        for (int i = 0; i < listItems.Length; i++)
        //        {
        //            listItems[i] = new OngoingOrderUserControl();
        //            listItems[i].TableNo = item.tbl_table.TableNumber;
        //            listItems[i].OrderNo = item.OrderNo;
        //            listItems[i].Waiter = item.tbl_waiter.WaiterName;
        //            listItems[i].Total = item.Total.ToString();
        //            listItems[i].Id = item.CId;

        //            // add to flow layout
        //            OngoingOrder order = new OngoingOrder();
        //            if (order.flowLayoutPanel1.Controls.Count < 0)
        //            {
        //                order.flowLayoutPanel1.Controls.Clear();
        //            }
        //            else

        //                order.flowLayoutPanel1.Controls.Add(listItems[i]);
        //        }
        //    }
        //}
    }
}
