using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class CustomerDetails
    {
        public int CId { get; set; }
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public Nullable<bool> CustomerType { get; set; }
        public Nullable<int> WaiterId { get; set; }
        public string WaiterName { get; set; }
        public Nullable<int> TableId { get; set; }
        public string TableName { get; set; }
        //public bool Completed { get; set; }
        public string Completed { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    }
}
