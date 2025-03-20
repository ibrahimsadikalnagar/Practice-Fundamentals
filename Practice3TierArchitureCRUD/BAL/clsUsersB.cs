using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BAL
{
    public class clsUsersB
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public clsUsersB() 
        {
            UserID = -1;
            UserName = "";
            Password = ""; 

        }
        public clsUsersB( string userName, string password)
        {
           
            UserName = userName;
            Password = password;
        }

        public void AddUsers()
        {
            this.UserID = clsUsersD.AddUser(this.UserName, this.Password);
        }

        public static bool  find(string UserName)
        {
            return clsUsersD.FindUser(UserName); 
        }
        public static bool Delete(string UserName)
        {
            return clsUsersD.DeleteUser(UserName);
        }

        public static DataTable GetUsers()
        {
            return clsUsersD.GetAllUsers();
        }

        public  bool UpdateData()
        {
            return clsUsersD.UpdateUsers(this.UserID, this.UserName, this.Password); 
        }
        public static clsUsersB FindID(int UserID)
        {
            string UserName = "", Password = "";
            if (clsUsersD.GetUserById(UserID, ref UserName, ref Password))
                return new clsUsersB(UserName, Password);
            else return null;
        }


    }

}
