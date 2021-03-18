using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class SalesDetaiils
    {
        public int SN { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? Date { get; set; }
        public double Amount { get; set; }
        //public double Total { get; set; }
    }
}
