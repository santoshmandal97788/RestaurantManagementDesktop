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
    public class BLLFoodItem : IFoodItem
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewFoodItem(FoodItemDetails fd)
        {
            tbl_fooditems tf = new tbl_fooditems();
            tf.CategoryName = fd.CategoryName;
            tf.Price = fd.Price;
            tf.Status = Convert.ToByte(fd.Status);
            tf.IsSpecial = Convert.ToByte(fd.IsSpecial);
            tf.Discount = fd.Discount;
            tf.Image = fd.Image;
            tf.FoodName = fd.FoodName;
            _db.tbl_fooditems.Add(tf);
            return _db.SaveChanges();
        }

        public bool CheckFoodItem(string foodName)
        {
            var food = _db.tbl_fooditems.Where(c => c.FoodName == foodName).FirstOrDefault();

            if (food != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteFoodItem(int foodid)
        {
            tbl_fooditems tf = _db.tbl_fooditems.Where(c => c.Id == foodid).FirstOrDefault();
            _db.tbl_fooditems.Remove(tf);
            return _db.SaveChanges();
        }

        public void FoodList()
        {
            var food = _db.tbl_fooditems.ToList();
        }

        public List<FoodItemDetails> GetAllFoodItems()
        {
            //string status = "Active";
            List<FoodItemDetails> lstfood = new List<FoodItemDetails>();
            var food = _db.tbl_fooditems.ToList();
            foreach (var item in food)
            {
                if (item.Status==1 && item.IsSpecial==1)
                {
                    lstfood.Add(new FoodItemDetails() { Id = item.Id, CategoryName = item.CategoryName, Price = item.Price, Status = "Active", IsSpecial = "Yes", Discount = item.Discount, Image = item.Image, FoodName = item.FoodName });

                }
                else
                {
                    lstfood.Add(new FoodItemDetails() { Id = item.Id, CategoryName = item.CategoryName, Price = item.Price, Status = "InActive", IsSpecial = "No", Discount = item.Discount, Image = item.Image, FoodName = item.FoodName });

                }
            }
            return lstfood;
        }
        public List<FIlterFoodDetails> GetFilterFoodItems()
        {
            //string status = "Active";
            List<FIlterFoodDetails> lstfood1 = new List<FIlterFoodDetails>();
            var food = _db.tbl_fooditems.ToList();
            foreach (var item in food)
            {                
                    lstfood1.Add(new FIlterFoodDetails() { Id=item.Id, FoodName=item.FoodName, CategoryName= item .CategoryName, Price=item.Price,Discount=item.Discount, Image = item.Image });
                
            }
            return lstfood1;
        }
        public int UpdateFoodItem(FoodItemDetails fd)
        {
            tbl_fooditems tf = _db.tbl_fooditems.Where(c => c.Id == fd.Id).FirstOrDefault();
            tf.CategoryName = fd.CategoryName;
            tf.Price = fd.Price;
            tf.Status = Convert.ToByte(fd.Status);
            tf.IsSpecial = Convert.ToByte(fd.IsSpecial);
            tf.Discount = fd.Discount;
            tf.Image = fd.Image;
            tf.FoodName = fd.FoodName;
            return _db.SaveChanges();
        }
    }
}
