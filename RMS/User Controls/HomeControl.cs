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
using System.IO;

namespace RMS.User_Controls
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }
        RMSDBEntities _db = new RMSDBEntities();
        private void HomeControl_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {

            ListItem[] listItems = new ListItem[14];
            //FoodItemDetails fd = new FoodItemDetails();
            var tb = _db.tbl_fooditems.ToList();

            foreach (var item in tb)
            {
                for (int i = 0; i < listItems.Length; i++)
                {

                    listItems[i] = new ListItem();
                    Byte[] img = (Byte[])item.Image;
                    MemoryStream ms = new MemoryStream(img);
                    listItems[i].Icon = Image.FromStream(ms);
                    listItems[i].IconBackground = Color.Silver;
                    listItems[i].Message =/* "NPR: " +*/ item.Price;
                    listItems[i].Id = item.Id;
                    listItems[i].Title = item.FoodName;

                    // add to flow layout
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else

                        flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }


        }
    }
}
