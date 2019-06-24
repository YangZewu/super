using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
