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
    public class BookingRoom
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }
        #region GetCustomer
        public static List<string> GetCustomer()
        {
            List<string>list=new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Cust_Name from tblCustomer",con);
                cmd.CommandType=CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["Cust_Name"]);
                }
            }
            return list;
        }
        #endregion
        #region GetReception
        public static List<string> GetReception()
        {
            List<string> list = new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select User_Name from tblUser where RoleId=2", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["User_Name"]);
                }
            }
            return list;
        }
        #endregion
        #region GetAdmin
        public static List<string> GetAdmin()
        {
            List<string> list = new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select User_Name from tblUser where RoleId=1", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["User_Name"]);
                }
            }
            return list;
        }
        #endregion
        #region GetRoomNumber
        public static List<int> GetRoomNumber()
        {
            List<int> list = new List<int>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select RoomNumber from tblRoom", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((int)dr["RoomNumber"]);
                }
            }
            return list;
        }
        #endregion
#region CustomerId
        public static int GetCustomerId(string customer)
        {
            int id = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Id from tblCustomer " +
                                                "where Cust_Name=@CustomerName",con);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@CustomerName", customer);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id =(int) dr["Id"];
                }
            }
            return id;
        }
#endregion
#region ReceptionId
        public static int GetReceptionId(string Reception)
        {
            int id = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Id from tblUser " +
                                                "where User_Name=@UserName", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserName", Reception);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = (int)dr["Id"];
                }
            }
            return id;
        }
#endregion
#region RoomId
          public static int GetRoomId(string Room)
        {
            int id = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Id from tblRoom " +
                                                "where RoomNumber=@Room", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Room",Room);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = (int)dr["Id"];
                }
            }
            return id;
        }
#endregion

        public static void AddBookingRoom(BookingRoomMember book)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spAddBookingRoom",con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomId", book.RoomId);
                cmd.Parameters.AddWithValue("@CustId", book.CustomerId);
                cmd.Parameters.AddWithValue("@Date",book.Date);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static DataSet DatLoad()
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from vwRecipesLaundryBill" +
                                                       " Where RoomNumber is not null", con);
                DataSet ds=new DataSet();
                da.Fill(ds, "Booking");
                return ds;
            }
        }

        public static List<BookingRoomMember> Preview(DateTime date)
        {
            List<BookingRoomMember> list=new List<BookingRoomMember>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * from vwRecipesLaundryBill " +
                                                "where Date=@Date ", con);
                cmd.Parameters.AddWithValue("@Date", date.ToShortDateString());
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    BookingRoomMember booking=new BookingRoomMember();
                    booking.CustomerName =(string) dr["Cust_Name"];
                    booking.CustomerCNIC = (string)dr["CNIC"];
                    booking.RoomNo = (int) dr["RoomNumber"];
                    booking.RoomRent = (int) dr["RoomRent"];
                    booking.LaundryBill = (int) dr["Laundry Bill"];
                    booking.ResturantBill =(int) dr["Recipes Bill"];
                    list.Add(booking);
                }
            }
            return list;
        }
        #region RemoveCustomer
        public static List<string> RemoveCustomer()
        {
            List<string> list = new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select * from CustomerBooking", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((string)dr["Name"]);
                }
            }
            return list;
        }
        #endregion
        #region
        public static List<int> RemoveRoomNumber()
        {
            List<int> list = new List<int>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select RoomNumber from vwRecipesLaundryBill" +
                                                " Where RoomNumber is not null", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add((int)dr["RoomNumber"]);
                }
            }
            return list;
        }
        #endregion
    }
    }

