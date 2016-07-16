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
    public class Room
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }
        #region RoomNumber
        public static int RoomNumber()
        {
            int roomNumber = 1;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Count(Id) from tblRoom",con);
                cmd.CommandType=CommandType.Text;
                con.Open();
                roomNumber+=(int)cmd.ExecuteScalar();
            }
            return roomNumber;
        }
        #endregion
        #region Owner
        public static List<string> Owner()
        {
            List<string> list=new List<string>();
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select User_Name from tblUser where RoleId=1", con);
                cmd.CommandType=CommandType.Text;
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
        #region OwnerId
        public static int OwnerId(string owner)
        {
            int id = 0;
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Select Id from tblUser where" +
                                                " tblUser.User_Name=@user_name",con);
                cmd.CommandType=CommandType.Text;
                cmd.Parameters.AddWithValue("@user_name", owner);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id=(int)dr["Id"];
                }
            }
            return id;
        }
        #endregion
        #region AddRoom
        public static void AddRoom(RoomMember room)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into tblRoom values" +
                                                "(@RoomType,@RoomNumber,@RoomRent,@UserId)",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                cmd.Parameters.AddWithValue("@RoomRent", room.RoomRent);
                cmd.Parameters.AddWithValue("@UserId", room.OwnerId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region UpdateRoom
        public static void UpdateRoom(RoomMember room)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("spUpdateRoom",con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.Parameters.AddWithValue("@RoomRent", room.RoomRent);
                cmd.Parameters.AddWithValue("@Id", room.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region DataLoad
        public static DataSet DataLoad()
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetRoom",con);
                da.SelectCommand.CommandType=CommandType.StoredProcedure;
                DataSet ds=new DataSet();
                da.Fill(ds, "Room");
                return ds;
            }
        }
        #endregion
    }
}
