using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public bool Update()
        {
            return clsCountryD.UpdateCountry(this.CountryID, this.CountryName);
        }
    }
}
