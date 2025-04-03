using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOnly
{
    public partial class UserControlCountry : UserControl
    {
        public UserControlCountry()
        {
            InitializeComponent();
        }
        public void LoadCountryData()
        {
           int countryID = 0;
            if (int.TryParse(textBoxCountryID.Text, out countryID))
            {
                string CountryName = clsCountryB.FindCounty(countryID);
                textBoxCountryName.Text = CountryName;
            }
        }
        
    }
}
