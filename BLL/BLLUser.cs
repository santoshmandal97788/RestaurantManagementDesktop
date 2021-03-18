using BO;
using DAL;
using ProjectInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUser : IUser
    {
        RMSDBEntities _db = new RMSDBEntities();
        public int AddNewUser(UserDetails ud)
        {
            Userdetail td = new Userdetail();
            td.FirstName = ud.FirstName;
            td.LastName = ud.LastName;
            td.Email = ud.Email;
            td.Username = ud.Username;
            td.Password = ud.Password;
            td.Usertype = ud.Usertype;
            _db.Userdetails.Add(td);
            return _db.SaveChanges();
        }

        public bool CheckEmail(string email)
        {
            var Email = _db.Userdetails.Where(c => c.Email == email).FirstOrDefault();

            if (Email != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserDetails CheckUserLogin(string username, string password)
        {
            UserDetails ud = new UserDetails();
            var user = _db.Userdetails.Where(r => r.Username == username && r.Password == password).FirstOrDefault();
            if (user != null)
            {

                ud.Username = user.Username;
                ud.Password = user.Password;
                ud.Usertype = user.Usertype;

            }
            return ud;
        }

        public int DeleteUser(int userid)
        {
            Userdetail td = _db.Userdetails.Where(c => c.id == userid).FirstOrDefault();
            _db.Userdetails.Remove(td);
            return _db.SaveChanges();
        }

        public List<UserDetails> GetAllUsers()
        {
            List<UserDetails> lstusers = new List<UserDetails>();
            var users = _db.Userdetails.ToList();
            foreach (var item in users)
            {
                lstusers.Add(new UserDetails() { id = item.id, FirstName = item.FirstName, LastName=item.LastName, Username=item.Username, Email=item.Email, Usertype=item.Usertype });
            }
            return lstusers;
        }

        //public int UpdatePassword(string username, string password)
        //{
        //    Userdetail td = _db.Userdetails.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
        //    td.FirstName = td.FirstName;
        //    td.LastName = td.LastName;
        //    td.Email = td.Email;


        //    td.Usertype = td.Usertype;
        //    td.Username = username;
        //    td.Password = password;
        //    return _db.SaveChanges();
        //}
        public int UpdatePassword(string username, string password)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BRE9TRN\SQLEXPRESS; Integrated Security= true; Database=RMSDB;");
            SqlCommand cmd = new SqlCommand("update Userdetails set Password=@b where Username=@a", conn);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }


        public int UpdateUser(UserDetails ud)
        {
            Userdetail td = _db.Userdetails.Where(c => c.id == ud.id).FirstOrDefault();
            td.FirstName = ud.FirstName;
            td.LastName = ud.LastName;
            td.Email = ud.Email;
            td.Username = ud.Username;
            td.Password = ud.Password;
            td.Usertype = ud.Usertype;
            return _db.SaveChanges();
        }
    }
}
