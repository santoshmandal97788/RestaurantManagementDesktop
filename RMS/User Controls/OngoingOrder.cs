using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BO;
using BLL;

namespace RMS.User_Controls
{
    public partial class OngoingOrder : UserControl
    {
        public OngoingOrder()
        {
            InitializeComponent();
        }
        RMSDBEntities _db = new RMSDBEntities();
        BLLCustomer blc = new BLLCustomer();
        public void populateOngoingOrder()
        {

            OngoingOrderUserControl[] listItems = new OngoingOrderUserControl[1];
            // FoodItemDetails fd = new FoodItemDetails();
            var tb = _db.tbl_customer.Where(a => a.Completed == false).ToList();
            foreach (var item in tb)
            {
                for (int i = 0; i < listItems.Length; i++)
                {
                    listItems[i] = new OngoingOrderUserControl();
                    listItems[i].TableNo = item.tbl_table.TableNumber;
                    listItems[i].OrderNo = item.OrderNo;
                    listItems[i].Waiter = item.tbl_waiter.WaiterName;
                    listItems[i].Total =item.Total.ToString();
                    listItems[i].Id = item.CId;

                    //add to flow layout
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else

                        flowLayoutPanel1.Controls.Add(listItems[i]);

                }
            }
        }
        private void LoadGrid()
        {
            List<OngoingOrderDetails> lstorder = blc.GetAllOngoingOrder();
            ongoingOrderGridView.DataSource = lstorder;
        }
            public void OngoingOrder_Load(object sender, EventArgs e)
             {
              populateOngoingOrder();
          //LoadGrid();
             }

        
    }
}
