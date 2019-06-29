using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class userServer
    {
        //验证登录
        public static int getUser(string userICno, string userPwd)
        {
            string sql = string.Format("select count(*) from userTables where userICno='{0}' and userPwd='{1}'", userICno, userPwd);
            return (int)DBHelper.executeScalar(sql);
        }
        //用户注册
        public static int regUser(string userICno, string userPwd, string userTel, string userPhoto, string userName, System.DateTime userBbir, System.DateTime icStartTime, System.DateTime icEndTime, string email, string address, string postcode, string sex)
        {
            string sql = string.Format("INSERT INTO userTables(userICno, userPwd, userTel, userPhoto,userName,userBbir,icStartTime,icEndTime,email,address,postcode,sex)" +
                                             " VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                                               userICno, userPwd, userTel, userPhoto, userName, userBbir, icStartTime, icEndTime, email, address, postcode, sex);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
        //读取操作
        public static SqlDataReader getDataReader(string icno)
        {
            string sqlstr = String.Format("select userPwd,postcode,userName,email,sex,userTel,userPhoto,address,icStartTime,userBbir,integral,JF,QDTime from userTables where userICno='{0}'", icno);
            return DBHelper.executeReader(sqlstr);

        }
        //删除用户信息，注销会员卡
        public static object SQLDELECT(string icno)
        {
            string sqlstr = String.Format("DELETE FROM userTables WHERE userICno = {0}", icno);
            return DBHelper.ExecuteNonQuery(sqlstr);

        }


        public static object XGQDJF(string QD, int jf, string icno)
        {
            string sql = String.Format("UPDATE userTables SET QDTime = '{0}',JF={1} WHERE userICno = '{2}'", QD,jf,icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static object CZJF(int ye, int jf, string icno)
        {
            string sql = String.Format("UPDATE userTables SET JF = JF+{0},YE=YE-{1} WHERE userICno = '{2}'",  jf,ye,icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static SqlDataReader getJF(string icno)
        {
            string sqlstr = String.Format("select userPhoto,userName,JF,YE from userTables where userICno='{0}'", icno);
            return DBHelper.executeReader(sqlstr);

        }
        public static object CZYE(int ye, string icno)
        {
            string sql = String.Format("UPDATE userTables SET YE=YE+{0} WHERE userICno = '{1}'", ye, icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static object XGMM(string pwd, string icno)
        {
            string sql = String.Format("UPDATE userTables SET userPwd='{0}' WHERE userICno = '{1}'", pwd, icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static object XGXX(string userTel, string userPhoto, string userName, System.DateTime userBbir, string email, string address, string postcode, string sex,string icno)
        {
            string sql = String.Format("UPDATE userTables SET userTel='{0}',userPhoto='{1}',userName='{2}'," +
                "userBbir='{3}',email='{4}',address='{5}',postcode='{6}',sex='{7}' WHERE userICno = '{8}'", userTel, userPhoto, userName, userBbir, email, address, postcode, sex,icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public static object dhsp(int ye, int jf, string icno)
        {
            string sql = String.Format("UPDATE userTables SET JF = JF-{0},YE=YE-{1} WHERE userICno = '{2}'", jf, ye, icno);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static object JQJF(int jf, string icno)
        {
            string sql = String.Format("UPDATE userTables SET JF=JF-0} WHERE userICno = '{1}'", jf, icno);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
