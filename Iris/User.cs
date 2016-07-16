using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Iris
{
    public class User
    {
        #region Connection
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con=new SqlConnection(cs);
            return con;
        }
        #endregion
        #region RoleLoad
        public static List<string> RoleLoad()
        {
            List<string>list=new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spGetRole",con);
                cmd.CommandType=CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   list.Add((string)dr["Role"]);
                }
            }
            return list;
        }
        #endregion
        #region RoldId
        public static int RoleId(string role)
        {
            int id=0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spGetRoleId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role", role);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = (int)dr["Id"];
                }
               
            }
            return id; 
        }
        #endregion
        #region AddUser
        public static void AddUser(UserPerson user)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spAddUser",con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_Name", user.User_Name);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@CNIC", user.CNIC);
                cmd.Parameters.AddWithValue("@Phone", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion 
        #region DataGridViewLoad
        public static DataSet UserLoad()
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("spUserLoad",con);
                da.SelectCommand.CommandType=CommandType.StoredProcedure;
                DataSet ds=new DataSet();
                da.Fill(ds, "User");
                return ds;
            }
        }
        #endregion

        public static void DeleteUser(int Id)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd=new SqlCommand("Delete from tblUser where Id=@Id",con);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
