using System;
using System.Collections.Generic;
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
            if (username != "" && password != "" )
            {
                return UserID = 10;
            }
            else
            {
               return  UserID = 0;
            }
               
        }
    }
}
