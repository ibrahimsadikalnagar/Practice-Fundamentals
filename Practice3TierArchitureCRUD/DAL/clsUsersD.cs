using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsUsersD
    {
        public static int AddUser(string  username , string password)
        {
            int UserID = 0; 
           SqlConnection Conn = new SqlConnection(ClassConnections.ConnectDataUser );
            string query = "Insert into Users(UserName , Password) values (@username , @password)" +
                "  SELECT SCOPE_IDENTITY()"; 
            SqlCommand cmd = new SqlCommand(query, Conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue ("@password", password);
            try
            {
                Conn.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                   UserID = insertedID;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            { Conn.Close(); }

            return UserID;
               
        }
        public static bool FindUser(string username)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Select * from Users where UserName = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { conn.Close(); }

            return isFound;
        }

        public static bool DeleteUser(string username)
        {

            int rowEffected = 0;
            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Delete Users where UserName = @username";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", username);
            try
            {
                conn.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            { conn.Close(); }
            return rowEffected > 0;
        }
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Select * from Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }

            finally { conn.Close(); }
            return dt;
        }

        public static bool UpdateUsers(int UserID , string UserName , string Password)
        {
            int RowEffected =  0;   

            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Update Users set UserName = @UserName , Password = @Password " +
                "where UserID = @UserID"; 
            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue("@UserID" , UserID);
            cmd.Parameters.AddWithValue("@UserName", UserName); 
            cmd.Parameters.AddWithValue("@Password" , Password);
            try
            {
                conn.Open();
                RowEffected = cmd.ExecuteNonQuery();
                
              
            }
            catch (Exception ex)
            { }
            finally
            { conn.Close(); }
            return RowEffected > 0;

        }
        public static bool GetUserById(int UserID, ref string UserName, ref string Password)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(ClassConnections.ConnectDataUser);
            string query = "Select * from Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(@query, conn);
            command.Parameters.AddWithValue("@UserID" , UserID );   
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                }
                else
                {
                    isFound = false;
                }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return isFound;

        }

    }
    
}
