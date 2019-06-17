using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class AdminManag
    {
        public static int GetAdmin(string GoodName, string Supplier, string Stock)
        {
            return AdminServer.GetAdmin(GoodName,Supplier,Stock);
        }
        public static int AddAdmin(string GoodName, string Supplier, string Stock)
        {
            return AdminServer.AddAdmin(GoodName,Supplier,Stock);
        }
    }
}
