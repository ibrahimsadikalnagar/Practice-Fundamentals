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

namespace Practice3TierArchitureCRUD
{
    public partial class FormCountry : Form
    {
        public FormCountry()
        {
            InitializeComponent();
        }

        private void _RefreshDataGride()
        {
            dataGridView1.DataSource = clsCountryB.GetAllCountries();
        }

        private void FormCountry_Load(object sender, EventArgs e)
        {
            _RefreshDataGride();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    labelCountryTitle.Text = "Edit Mode";
                    labelCountryNo.Text = row.Cells["CountryID"].Value.ToString();
                    textBoxCountryName.Text = row.Cells["CountryName"].Value.ToString();
                }
                
            
        }
        private void _AssignSelectedDataFromGrid()
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            clsCountryB clsCountryB = new clsCountryB
            {
                CountryID = Convert.ToInt32(row.Cells["CountryID"].Value),
                CountryName = textBoxCountryName.Text,
            };
            if (clsCountryB.Update())
            {
                MessageBox.Show("Update sucssefull");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            _AssignSelectedDataFromGrid();
            _RefreshDataGride() ;
        }
    }
}
