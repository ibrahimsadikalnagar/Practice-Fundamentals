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
        public Dictionary<string, Action> searchMethod; 
        public Dictionary<string, Action> searchTypeAction;
        public UserControlCountry()
        {
            InitializeComponent();
            searchMethod = new Dictionary<string, Action> // initialize the dictionary 
            {
                { "ID", LoadCountryDataByID },
                { "Country Name", LoadCountryDataByName }

            };

            searchTypeAction = new Dictionary<string, Action>
            {
                {"ID" , () => setSearchMode(textBoxCountryID , textBoxCountryName) },
                {"Country Name" , () => setSearchMode(textBoxCountryName, textBoxCountryID) }
            };
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
           string selectedType = comboBoxSearchType.SelectedItem.ToString();
            if (searchMethod.ContainsKey(selectedType))
            {
                searchMethod[selectedType](); // Run the match method
            }
            else { MessageBox.Show("Please select  avalid search type "); } 
           
        }

        private void UserControlCountry_Load(object sender, EventArgs e)
        {
            comboBoxSearchType.Items.Add("ID");
            comboBoxSearchType.Items.Add("Country Name"); 
            comboBoxSearchType.SelectedIndex = 0;

           
            searchTypeAction["ID"](); 
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selectedtype = comboBoxSearchType.SelectedItem.ToString();
            if (searchTypeAction.ContainsKey(selectedtype))
            {
                searchTypeAction[selectedtype]();
            }
        }
        private void setSearchMode(TextBox enableTextbox , TextBox disableTextbox)
        {
            textBoxCountryID.Clear();
            textBoxCountryName.Clear();
            enableTextbox.Enabled = true; 
                 enableTextbox.Focus();

            disableTextbox.Enabled = false; 
        }
    }
}
