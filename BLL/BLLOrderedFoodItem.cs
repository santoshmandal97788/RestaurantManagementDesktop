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
    public class BLLOrderedFoodItem : IOrderedFood
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddOrderedItem(ItemDetails cd)
        {
            tbl_orderedfooditem tc = new tbl_orderedfooditem();
            //tc.CId = cd.CId;
            tc.OrderNo = cd.OrderNo;
            tc.FoodId = cd.FoodId;
            tc.Qty = cd.Qty;
            tc.Total = cd.Total;
            _db.tbl_orderedfooditem.Add(tc);
            return _db.SaveChanges();
        }

        public int DeleteOrderedItem(string orderNo)
        {
            var tc = _db.tbl_orderedfooditem.Where(c => c.OrderNo == orderNo).ToList();
            foreach (var item in tc)
            {
                _db.tbl_orderedfooditem.Remove(item);
                _db.SaveChanges();
            }

            return 0;
        }

        public List<OrderedFoodDetails> GetAllOrderedFoodItem()
        {
            List<OrderedFoodDetails> lstOrderedItems = new List<OrderedFoodDetails>();
            var orderedItem = _db.tbl_orderedfooditem.ToList();
            foreach (var item in orderedItem)
            {
                lstOrderedItems.Add(new OrderedFoodDetails() {Id=item.Id,  OrderNo = item.OrderNo, FoodId=item.FoodId, Qty=item.Qty, Total=item.Total });

            }
            return lstOrderedItems;
        }

        public int UpdateOrderItem(ItemDetails cd)
        {
            tbl_orderedfooditem tc = _db.tbl_orderedfooditem.Where(c => c.Id == cd.Id).FirstOrDefault();
            //tc.CId = cd.CId;
            tc.OrderNo = cd.OrderNo;
            tc.FoodId = cd.FoodId;
            tc.Qty = cd.Qty;
            tc.Total = cd.Total;
            return _db.SaveChanges();
        }
    }
}
