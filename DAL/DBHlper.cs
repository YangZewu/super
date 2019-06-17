using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class DBHelper
    {
        //private static string constring;//= "Data Source=.;Initial Catalog=Parking;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                // 分析和处理数据库连接可能出现在不同状态
                string connectionstring = "Data Source=112.74.60.134;Initial Catalog=Supermarket;User ID=sa password=yzw0219.";

                if (connection == null)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }

        }
        //验证用户

        public static object executeScalar(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Connection);
            return com.ExecuteScalar();

        }
        //非查询
        public static object ExecuteNonQuery(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Connection);
            return com.ExecuteNonQuery();
        }
        public static SqlDataReader executeReader(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Connection);
            SqlDataReader sdr = com.ExecuteReader();
            return sdr;
        }
    }
}
