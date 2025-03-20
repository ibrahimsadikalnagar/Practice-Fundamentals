using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
