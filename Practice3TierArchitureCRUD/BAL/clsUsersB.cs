using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsUsersB
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

       /* public clsUsersB() 
        {
            UserID = 0;
            UserName = "";
            Password = ""; 

        }*/
        public clsUsersB( string userName, string password)
        {
           
            UserName = userName;
            Password = password;
        }

        public void AddUsers()
        {
            this.UserID = clsUsersD.AddUser(this.UserName, this.Password);
        }

    }

}
