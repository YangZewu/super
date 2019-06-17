using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class GoodsManag
    {
        public static int GetGoods(string icNo, string goodsName, string price, string goodsPhoto)
        {
            return GoodsServer.GetGoods(icNo,goodsName,price,goodsPhoto);
        }
        public static int AddGoods(string icNo, string goodsName, string price, string goodsPhoto)
        {
            return GoodsServer.AddGoods(icNo, goodsName, price, goodsPhoto);
        }
    }
}
