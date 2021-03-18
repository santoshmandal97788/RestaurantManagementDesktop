using BO;
using DAL;
using ProjectInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCustomer : IOrder
    {
        RMSDBEntities _db = new RMSDBEntities();

        public int AddCustomer(CustomerDetails cd)
        {
            tbl_customer tc = new tbl_customer();
            tc.OrderNo = cd.OrderNo;
            tc.CustomerName = cd.CustomerName;
            tc.CustomerType = cd.CustomerType;
            tc.WaiterId = cd.WaiterId;
            tc.TableId = cd.TableId;
            tc.Completed = Convert.ToBoolean(cd.Completed);
            tc.Total = cd.Total;
            tc.OrderDate = cd.OrderDate;
            _db.tbl_customer.Add(tc);
            return _db.SaveChanges();


        }

      
        public int DeleteCustomer(int orderid)
        {
            tbl_customer tc = _db.tbl_customer.Where(c => c.CId == orderid).FirstOrDefault();
            _db.tbl_customer.Remove(tc);
            return _db.SaveChanges();
        }

    
        public List<CustomerDetails> GetAllCustomer()
        {
            List<CustomerDetails> lstcustomer = new List<CustomerDetails>();
            var customer = _db.tbl_customer.ToList();
            foreach (var item in customer)
            {
                if (item.Completed == true)
                {
                    lstcustomer.Add(new CustomerDetails() { CId = item.CId, OrderNo = item.OrderNo, CustomerName = item.CustomerName, CustomerType = item.CustomerType, WaiterName = item.tbl_waiter.WaiterName, TableName = item.tbl_table.TableNumber, Completed = "Yes", Total = item.Total, OrderDate = item.OrderDate });

                }
                else
                {
                    lstcustomer.Add(new CustomerDetails() { CId = item.CId, OrderNo = item.OrderNo, CustomerName = item.CustomerName, CustomerType = item.CustomerType, WaiterName = item.tbl_waiter.WaiterName, TableName = item.tbl_table.TableNumber, Completed = "No", Total = item.Total, OrderDate = item.OrderDate });

                }
            }
            return lstcustomer;
        }

        public List<OngoingOrderDetails> GetAllOngoingOrder()
        {
            List<OngoingOrderDetails> lstorder = new List<OngoingOrderDetails>();
            var ongoingOrder = _db.tbl_customer.Where(a => a.Completed == false).ToList();
          
            foreach (var item in ongoingOrder)
            {
              
                lstorder.Add(new OngoingOrderDetails() { OrderNo = item.OrderNo, CustomerName = item.CustomerName,  WaiterName = item.tbl_waiter.WaiterName, TableName = item.tbl_table.TableNumber,  Total = item.Total });

                
            }
            return lstorder;
        }

        public List<SalesDetaiils> GetAllSales()
        {
            int Sn = 0;
            List<SalesDetaiils> lstSales = new List<SalesDetaiils>();
            var sales = _db.tbl_customer.Where(a => a.Completed == true).ToList();
            foreach (var item in sales)
            {
                Sn++;

                lstSales.Add(new SalesDetaiils() { SN = Sn, InvoiceNumber = item.OrderNo, Date = item.OrderDate, Amount = Convert.ToDouble(item.Total) });

            }
            return lstSales;
        }

        public List<SalesDetaiils> GetDailySales(DateTime date)
        {
            int Sn = 0;
            List<SalesDetaiils> lstSales = new List<SalesDetaiils>();
            var completedOrder = _db.tbl_customer.Where(a => a.Completed == true).ToList();
            var sales = completedOrder.Where(a => a.OrderDate == date).ToList();
           // double total = 0;
            //var sales = _db.tbl_customer.Where(a => a.OrderDate == date).ToList();
            foreach (var item in sales)
            {
                Sn++;
                //total = Convert.ToDouble(item.Total);
                    lstSales.Add(new SalesDetaiils() { SN=Sn, InvoiceNumber = item.OrderNo, Date = item.OrderDate, Amount = Convert.ToDouble(item.Total)});

            }
            return lstSales;
        
        }

        public List<SalesDetaiils> GetMonthlySales(DateTime from, DateTime to)
        {
            int Sn = 0;
            List<SalesDetaiils> lstSales = new List<SalesDetaiils>();
            var completedOrder = _db.tbl_customer.Where(a => a.Completed == true).ToList();

            DateTime DT1 = System.DateTime.Today;
            DateTime DT2 = DT1.AddDays(-30);


            var sales = from l in completedOrder
                        where l.OrderDate >= DT2 && l.OrderDate <= DT1
                        select l;
            foreach (var item in sales)
            {
                Sn++;

                lstSales.Add(new SalesDetaiils() { SN = Sn, InvoiceNumber = item.OrderNo, Date = item.OrderDate, Amount = Convert.ToDouble(item.Total) });

            }
            return lstSales;
        }

        public List<SalesDetaiils> GetuserManualSales(DateTime frm, DateTime to)
        {
            int Sn = 0;
            List<SalesDetaiils> lstSales = new List<SalesDetaiils>();
            var completedOrder = _db.tbl_customer.Where(a => a.Completed == true).ToList();

            //DateTime DT1 = System.DateTime.Today;
            //DateTime DT2 = DT1.AddDays(-30);


            var sales = from l in completedOrder
                        where l.OrderDate >= frm && l.OrderDate <= to
                        select l;
            foreach (var item in sales)
            {
                Sn++;

                lstSales.Add(new SalesDetaiils() { SN = Sn, InvoiceNumber = item.OrderNo, Date = item.OrderDate, Amount = Convert.ToDouble(item.Total) });

            }
            return lstSales;
        }

        public List<SalesDetaiils> GetWeeklySales(DateTime from, DateTime to)
        {
            int Sn = 0;
            List<SalesDetaiils> lstSales = new List<SalesDetaiils>();
            var completedOrder = _db.tbl_customer.Where(a => a.Completed == true).ToList();

            DateTime DT1 = System.DateTime.Today;
            DateTime DT2 = DT1.AddDays(-7);


            var sales = from l in completedOrder
                        where l.OrderDate >= DT2 && l.OrderDate <= DT1
                        select l;
            foreach (var item in sales)
            {
                Sn++;

                lstSales.Add(new SalesDetaiils() { SN = Sn, InvoiceNumber = item.OrderNo, Date = item.OrderDate, Amount = Convert.ToDouble(item.Total) });

            }
            return lstSales;
        }

        public int UpdateCustomer(CustomerDetails cd)
        {
            tbl_customer tc = _db.tbl_customer.Where(c => c.CId == cd.CId).FirstOrDefault();
            //tc.CId = cd.CId;
            tc.OrderNo = cd.OrderNo;
            tc.CustomerName = cd.CustomerName;
            tc.CustomerType = cd.CustomerType;
            tc.WaiterId = cd.WaiterId;
            tc.TableId = cd.TableId;
            tc.Completed = Convert.ToBoolean(cd.Completed);
            tc.Total = cd.Total;
            tc.OrderDate = cd.OrderDate;
            return _db.SaveChanges();
        }
    }
}
