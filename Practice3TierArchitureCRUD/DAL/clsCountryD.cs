using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class clsCountryD
    {
        public static DataTable GetAllCountry()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Select * from Countries"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        public static bool UpdateCountry(int CountryID , string CountryName)
        {
            int Reader = 0; 
            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Update Countries set CountryName =@CountryName" +
                              " where CountryID = @CountryID"; 
            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@CountryName" , CountryName);
            cmd.Parameters.AddWithValue("@CountryID" , CountryID);
            try
            {
                conn.Open();
                 Reader = cmd.ExecuteNonQuery();

                

            }
            catch (Exception ex) 
                { }
                finally {
                conn.Close();
            }
            return (Reader > 0);


        }
    }
}
