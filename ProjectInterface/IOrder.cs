using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public interface IOrder
    {
        List<CustomerDetails> GetAllCustomer();
        List<OngoingOrderDetails> GetAllOngoingOrder();
        int AddCustomer(CustomerDetails cd);
        int UpdateCustomer(CustomerDetails cd);
        int DeleteCustomer(int orderid);
        List<SalesDetaiils> GetDailySales(DateTime date);
        List<SalesDetaiils> GetWeeklySales(DateTime from, DateTime to);
        List<SalesDetaiils> GetMonthlySales(DateTime from, DateTime to);
        List<SalesDetaiils> GetuserManualSales(DateTime frm, DateTime to);
        List<SalesDetaiils> GetAllSales();
    }
}
