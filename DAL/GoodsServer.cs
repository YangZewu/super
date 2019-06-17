using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodsServer
    {
        public static int GetGoods(string icNo,string goodsName,string price,string goodsPhoto)
        {
            string sql = string.Format("select count(*) from goodsData where icNo='{0}'",icNo);
            return (int)DBHelper.executeScalar(sql);
        }
        public static int AddGoods(string icNo, string goodsName, string price, string goodsPhoto)
        {
            string sql = string.Format("INSERT INTO goodsData(icNo,goodsName,price,goodsPhoto)" +
                "values('{0}','{1}','{2}','{3}')",icNo,goodsName,price,goodsPhoto);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
