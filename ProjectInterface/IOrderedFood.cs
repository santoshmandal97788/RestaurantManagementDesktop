using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface IOrderedFood
    {
        List<OrderedFoodDetails> GetAllOrderedFoodItem();
        int AddOrderedItem(ItemDetails cd);
        int UpdateOrderItem(ItemDetails cd);
        int DeleteOrderedItem(string orderNo);

    }
}
