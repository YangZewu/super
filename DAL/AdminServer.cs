using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AdminServer
    {
        public static int GetAdmin(string GoodName, string Supplier, string Stock)
        {
            string sql = string.Format("select count(*) from admin where GoodName='{0}'", GoodName);
            return (int)DBHelper.executeScalar(sql);
        }
        public static int AddAdmin(string GoodName, string Supplier, string Stock)
        {
            string sql = string.Format("INSERT INTO admin(GoodName,Supplier,Stock)" +
                " values('{0}','{1}','{2}')", GoodName, Supplier, Stock);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
