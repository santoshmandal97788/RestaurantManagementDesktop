using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class OngoingOrderDetails
    {
       
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
      
       
        public string WaiterName { get; set; }
      
        public string TableName { get; set; }
        public bool Completed { get; set; }
       
        public Nullable<decimal> Total { get; set; }
       
    }
}
