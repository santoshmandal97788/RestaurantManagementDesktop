using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class OrderedFoodDetails
    {
        public int Id { get; set; }
        public Nullable<int> CId { get; set; }
       // public string CustomerName { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> FoodId { get; set; }
        //public string FoodCategory { get; set; }
        //public string FoodName { get; set; }
        //public string Price { get; set; }
        //public string Discount { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
