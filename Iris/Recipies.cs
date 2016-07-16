using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Iris
{
    public class Recipies
    {
        public static SqlConnection GetConnection()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBIris"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }
        #region Recipes
        public static List<RecipesMember> Recipes()
        {
            using (SqlConnection con = GetConnection())
            {
                List<RecipesMember>list=new List<RecipesMember>();
                SqlCommand cmd = new SqlCommand("Select * from tblRecipesRate",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new RecipesMember()
                        {
                            Name=(string)dr["item_Name"],
                            ItemRate = (int)dr["ItemRate"]
                        });
                }
                return list;
            }
        }
        #endregion
        #region ChangeRate
        public static void ChangeRate(string itemName, int itemPrice)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("update tblRecipesRate set ItemRate=@ItemRate " +
                                                "where Item_Name=@Item_Name",con);
                cmd.Parameters.AddWithValue("@ItemRate",itemPrice );
                cmd.Parameters.AddWithValue("@Item_Name", itemName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        public static void AddResturantRecord(int custId,DateTime date,int amount)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("insert into tblRecipies values" +
                                                "(@CustId,@Date,@Amount)",con);
                cmd.Parameters.AddWithValue("@CustId", custId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Amount", amount);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
