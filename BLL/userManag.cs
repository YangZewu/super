using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class userManag
    {
        public static int getUser(string userICno, string userPwd)
        {
            return userServer.getUser(userICno,userPwd);
        }
        public static int regUser(string userICno, string userPwd, string userTel, string userPhoto, string userName, System.DateTime userBbir, System.DateTime icStartTime, System.DateTime icEndTime, string email, string address, string postcode, string sex)
        {
            return userServer.regUser(userICno,userPwd,userTel,userPhoto,userName,userBbir,icStartTime,icEndTime, email, address, postcode, sex);

        }
        public static SqlDataReader getDataReader(string icno)
        {
            return userServer.getDataReader(icno);
        }

        public static object DELECT(string icno)
        {
            return userServer.SQLDELECT(icno);
        }
        public static object XGQDJF(string QD, int jf, string icno)
        {
            
            return userServer.XGQDJF(QD,jf,icno);
        }
        public static object CZJF(int ye, int jf, string icno)
        {
            return userServer.CZJF(ye,jf,icno);
        }
        public static SqlDataReader getJF(string icno)
        {
            return userServer.getJF(icno);
        }
        public static object CZYE(int ye, string icno)
        {
            return userServer.CZYE(ye,icno);
        }
        public static object XGMM(string pwd, string icno)
        {
            return userServer.XGMM(pwd,icno);
        }
        public static object XGXX(string userTel, string userPhoto, string userName, System.DateTime userBbir, string email, string address, string postcode, string sex, string icno)
        {
            return userServer.XGXX(userTel, userPhoto, userName, userBbir, email, address, postcode, sex,icno);
        }
        public static string icNo= "20193029023017";
        public static string Name;
    }
}
