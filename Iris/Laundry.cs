using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Iris
{
   public class Laundry
    {
       public static SqlConnection GetConnection()
       {
           string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
           SqlConnection con = new SqlConnection(cs);
           return con;
       }
       #region AddItem
       public static void AddItem(LaundryMember laundry)
       {
           using (SqlConnection con = GetConnection())
           {
               SqlCommand cmd = new SqlCommand
                   ("insert into tblCloth values(@Item_Name,@Item_Price)",con);
               cmd.CommandType=CommandType.Text;
               cmd.Parameters.AddWithValue("@Item_Name", laundry.ItemName);
               cmd.Parameters.AddWithValue("@Item_Price", laundry.ItemPrice);
               con.Open();
               cmd.ExecuteNonQuery();
           }
       }
       #endregion
       #region GetLaundryItem
       public static DataSet GetLaudryItem()
       {
           using (SqlConnection con=GetConnection())
           {
               SqlDataAdapter da = new SqlDataAdapter("Select Id,Item_Name," +
                                                      "Item_Price from tblCloth",con);
               da.SelectCommand.CommandType=CommandType.Text;
               DataSet ds=new DataSet();
               da.Fill(ds, "LaundryItem");
               return ds;
           }
       }
       #endregion
       #region LaundryItem
       public static List<string> LaundryItem()
       {
           List<string>list=new List<string>();
           using (SqlConnection con = GetConnection())
           {
               SqlCommand cmd=new SqlCommand("Select Item_Name from tblCloth",con);
               cmd.CommandType=CommandType.Text;
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   list.Add((string)dr["Item_Name"]);
               }
           }
           return list;
       }
       #endregion
       #region UpdateRate
       public static void UpdateRate(LaundryMember laundry)
       {
           using (SqlConnection con=GetConnection())
           {
               SqlCommand cmd = new SqlCommand("Update tblCloth set " +
                                               "Item_Price=@Item_Price where Item_Name=@Item_Name",con);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.AddWithValue("@Item_Name", laundry.ItemName);
               cmd.Parameters.AddWithValue("@Item_Price", laundry.ItemPrice);
               con.Open();
               cmd.ExecuteNonQuery();
           }
       }
       #endregion
       #region ItemRate
       public static int ItemRate(string item)
       {
           int rate = 0;
           using (SqlConnection con=GetConnection())
           {
               SqlCommand cmd = new SqlCommand("Select Item_Price from tblCloth" +
                                               " where Item_Name=@Item",con);
               cmd.CommandType=CommandType.Text;
               cmd.Parameters.AddWithValue("@Item", item);
               con.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                   rate = (int) dr["Item_Price"];
               }
           }
           return rate;
       }
       #endregion
        #region ClothId
       public static int ItemId(string item)
       {
           int id = 0;
           using (SqlConnection con = GetConnection())
           {
               SqlCommand cmd = new SqlCommand("Select Id from tblCloth" +
                                               " where Item_Name=@Item", con);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.AddWithValue("@Item", item);
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
       #region AddLaundryRecord
       public static void AddLaunderyRecord(LaundryMember laundry)
       {
           using (SqlConnection con=GetConnection())
           {
               SqlCommand cmd = new SqlCommand("insert into tblLaundry values" +
                                               "(@Item_Description,@ClothId,@Quantity," +
                                               "@Price,@CustId)",con);
               cmd.CommandType=CommandType.Text;
               cmd.Parameters.AddWithValue("@Item_Description", laundry.ItemDescription);
               cmd.Parameters.AddWithValue("@ClothId", laundry.ItemNameId);
               cmd.Parameters.AddWithValue("@Quantity", laundry.Quantity);
               cmd.Parameters.AddWithValue("@Price", laundry.ItemPrice);
               cmd.Parameters.AddWithValue("@CustId", laundry.CustomerId);
               con.Open();
               cmd.ExecuteNonQuery();
           }
       }
       #endregion
       #region GetLaundryRecord
       public static DataSet GetLaundryRecord()
       {
           using (SqlConnection con = GetConnection())
           {
               SqlDataAdapter da = new SqlDataAdapter("spGetLaundry",con);
               da.SelectCommand.CommandType = CommandType.StoredProcedure;
               DataSet ds=new DataSet();
               da.Fill(ds, "Laundry");
               return ds;
           }
       }
       #endregion

        
    }
}
