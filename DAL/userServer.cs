using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class userServer
    {
        //验证登录
        public static int getUser(string userICno,string userPwd)
        {
            string sql = string.Format("select count(*) from userTables where userICno='{0}' and userPwd='{1}'",userICno,userPwd);
            return (int)DBHelper.executeScalar();
        }
        //用户注册
        public static int regUser(string userICno, string userPwd, string userTel, string userPhoto, string userName, string userBbir, string icStartTime, string icEndTime)
        {
            string sql = string.Format("INSERT INTO userTables(userICno, userPwd, userTel, userPhoto,userName,userBbir,icStartTime,icEndTime)" +
                                             " VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}')",
                                               userICno,userPwd,userTel,userPhoto,userName,userBbir,icStartTime,icEndTime);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
