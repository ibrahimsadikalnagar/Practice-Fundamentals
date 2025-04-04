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
        public void LoadCountryDataByID()
        {
           int countryID = 0;
            if (int.TryParse(textBoxCountryID.Text, out countryID))
            {
                string CountryName = clsCountryB.FindCounty(countryID);
                if (CountryName != "")
                {
                    textBoxCountryName.Text = CountryName;
                }
                else
                {
                    MessageBox.Show("the country ID is not available "); 
                }
            }
        }
        private void LoadCountryDataByName()
        {
            int countryID = clsCountryB.FindCounty(textBoxCountryName.Text);
            if (countryID != 0)
            {
                textBoxCountryID.Text = countryID.ToString();
            }
            else
            {
                MessageBox.Show("Country that you entered is not avalable ");
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchType.SelectedItem == "ID")
            {
                LoadCountryDataByID();
            }
            else
            {
                LoadCountryDataByName();    
            }
           
        }

        private void UserControlCountry_Load(object sender, EventArgs e)
        {
            comboBoxSearchType.SelectedIndex = 0;
            textBoxCountryID.Enabled = true;
            textBoxCountryName.Enabled = false; 
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCountryID.Clear();
            textBoxCountryName.Clear();
            if(comboBoxSearchType.SelectedItem.ToString() ==  "ID")
            {
                comboBoxSearchType.SelectedIndex = 0;
                textBoxCountryID.Enabled = true;
                textBoxCountryName.Enabled = false;
                textBoxCountryID.Focus();
            }
            else
            {
                comboBoxSearchType.SelectedIndex = 1;
                textBoxCountryID.Enabled = false;
                textBoxCountryName.Enabled = true;
                textBoxCountryName.Focus();
            }
        }
    }
}
