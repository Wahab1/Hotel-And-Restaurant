using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Iris
{
    public class Verification
    {
         public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }
        public static int verify(string userName,string password)
        {
            int verify = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * from tblUser where" +
                                                " User_Name=@UserName And Password=@Password",con);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    verify =(int)dr["RoleId"];
                }
            }
            return verify;
        }
    }
}
