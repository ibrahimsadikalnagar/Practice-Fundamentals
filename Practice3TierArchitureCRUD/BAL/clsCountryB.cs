using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL; 


namespace BAL
{
    public class clsCountryB
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

       public static DataTable GetAllCountries()
        {
            return clsCountryD.GetAllCountry();
        }
    }
}
