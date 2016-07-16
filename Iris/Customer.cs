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
    public class Customer
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }
        #region ReceptionLoad
        public static List<string> ReceptionLoad()
        {
            List<string> list = new List<string>();
            using (SqlConnection con = GetConnection())
            {
              
                SqlCommand cmd = new SqlCommand("Select User_Name from tblUser where RoleId=2",con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                   list.Add((string)dr["User_Name"]); 
                }
                
              }
            return list;
            }
        #endregion
        #region ReceptionId
        public static int ReceptionId(string Reception)
        { 
            using (SqlConnection con = GetConnection())
            {
                int id = 0;
                SqlCommand cmd = new SqlCommand("spUserId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Reception", Reception);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id =(int) dr["Id"];
                }
                return id;
            } 
        }
        #endregion
        #region AddCustomer
        public static void AddCustomer(CustomerPerson customer)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spInsertCustomer",con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@CNIC", customer.CNIC);
                cmd.Parameters.AddWithValue("@Mobile", customer.Mobile);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        public static DataSet GetCustomer()
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetCustomer",con);
                da.SelectCommand.CommandType=CommandType.StoredProcedure;
                DataSet ds=new DataSet();
                da.Fill(ds, "Customer");
                return ds;
            }
        }

        public static bool ReceptionVerification(string customer,string password)
        {
            bool ret = false;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(" Select Id from tblUser where" +
                                                " User_Name=@user_name And Password=@password",con);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@user_name", customer);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    ret = true;
                }

            }
            return ret;
        }
        #region UpdateCustomer
        public static void UpdateCustomer(CustomerPerson person,string id)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomer", con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@CustomerName", person.CustomerName);
                cmd.Parameters.AddWithValue("@CNIC", person.CNIC);
                cmd.Parameters.AddWithValue("@Mobile", person.Mobile);
                cmd.Parameters.AddWithValue("@Email", person.Email);
                cmd.Parameters.AddWithValue("@City", person.City);
                cmd.Parameters.AddWithValue("@Address", person.Address);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region DeleteCustomer
        public static void DeleteCustomer(string id)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Delete from tblCustomer where Id=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
    }
    }

