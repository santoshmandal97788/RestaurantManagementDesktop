using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ItemDetails
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int FoodId { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
    }
}
