using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;

namespace RMS.User_Controls
{
    public partial class SalesReport : UserControl
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        BLLCustomer blc = new BLLCustomer();

       
        private void SalesReport_Load(object sender, EventArgs e)
        {
            salesDataGridView.Columns["InvoiceNumber"].Visible = false;
            salesDataGridView.Columns["Date"].Visible = false;
            salesDataGridView.Columns["Amount"].Visible = false;
            LoadSales();
        }

        private void LoadSales()
        {
            List<SalesDetaiils> lstSales = blc.GetAllSales();
            salesDataGridView.DataSource = lstSales;
            PopulateTotalRS();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            //string opLast7Days = GetLast7DateString();
            // string date = System.DateTime.Today.ToShortDateString();
            //List<SalesDetaiils> lstSales = blc.GetDailySales(Convert.ToDateTime(date));
            //DateTime currentDate = System.DateTime.Today;
            //DateTime dateWeekBefore = currentDate.AddDays(-7);


            List<SalesDetaiils> lstSales = blc.GetDailySales(System.DateTime.Today);
            salesDataGridView.DataSource = lstSales;
            PopulateTotalRS();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSales();
        }
        public static string GetLast7DateString()
        {
            DateTime currentDate = DateTime.Now;
            return String.Join(",", Enumerable.Range(0, 7)
                                             .Select(x => currentDate.AddDays(-x).ToString("dd-MM-yyyy"))
                                             .ToList());
        }

        private void btnSalesWeekly_Click(object sender, EventArgs e)
        {
            //string opLast7Days = GetLast7DateString();
         
            DateTime currentDate = System.DateTime.Today;
            DateTime dateWeekBefore = currentDate.AddDays(-7);


            List<SalesDetaiils> lstSales = blc.GetWeeklySales( currentDate, dateWeekBefore);
            salesDataGridView.DataSource = lstSales;
            PopulateTotalRS();
        }


       

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            DateTime currentDate = System.DateTime.Today;
            DateTime dateMonthBefore = currentDate.AddDays(-30);


            List<SalesDetaiils> lstSales = blc.GetMonthlySales(currentDate, dateMonthBefore);
            salesDataGridView.DataSource = lstSales;
            PopulateTotalRS();
        }

        private void btnUserInputSales_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromDatepicker.Value;
            DateTime toDate = toDatepicker.Value;
            List<SalesDetaiils> lstSales = blc.GetuserManualSales(fromDate, toDate);
            salesDataGridView.DataSource = lstSales;
            PopulateTotalRS();
        }

        private void PopulateTotalRS()
        {
            double sum = 0;
            for (int j = 0; j < salesDataGridView.Rows.Count; j++)
            {
                sum = sum + Convert.ToDouble(salesDataGridView.Rows[j].Cells[6].Value);
            }

            lblTotal.Visible = true;
            txtTotal.Visible = true;
            txtTotal.Text = sum.ToString();
        }
    }
}
