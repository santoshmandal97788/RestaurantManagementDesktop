using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
  public  class FIlterFoodDetails
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public byte[] Image { get; set; }
        public string FoodName { get; set; }
    }
}
