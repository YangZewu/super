﻿using System;
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
        public static int getUser(string userICno,string userPwd)
        {
            string sql = string.Format("select count(*) from userTables where userICno='{0}' and userPwd='{1}'",userICno,userPwd);
            return (int)DBHelper.executeScalar(sql);
        }
        //用户注册
        public static int regUser(string userICno, string userPwd, string userTel, string userPhoto, string userName, System.DateTime userBbir, System.DateTime icStartTime, System.DateTime icEndTime, string email,string address,string postcode,string sex)
        {
            string sql = string.Format("INSERT INTO userTables(userICno, userPwd, userTel, userPhoto,userName,userBbir,icStartTime,icEndTime,email,address,postcode,sex)" +
                                             " VALUES('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                                               userICno,userPwd,userTel,userPhoto,userName,userBbir,icStartTime,icEndTime, email, address, postcode, sex);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
        public static SqlDataReader getDataReader(string icno)
        {
            string sqlstr = String.Format("select userICno,userName,userTel,userPhoto,address from BikeInfo where icNo='{0}'", icno);
            return DBHelper.executeReader(sqlstr);

        }
    }
}
