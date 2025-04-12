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
        private DataGridViewRow SelectedRow;
        clsCountryB clsCountryB = new clsCountryB();
        public FormCountry(int CountryID)
        {
            
            InitializeComponent();
            clsCountryB.CountryID = CountryID;
            labelCountryNo.Text = clsCountryB.CountryID.ToString();
            labelCountryTitle.Text = "Insert Mode"; 
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
                    SelectedRow = dataGridView1.SelectedRows[0];
                   
                    labelCountryTitle.Text = "Edit Mode";
                    labelCountryNo.Text = SelectedRow.Cells["CountryID"].Value.ToString();
                    textBoxCountryName.Text = SelectedRow.Cells["CountryName"].Value.ToString();
                }
                else
            {
                MessageBox.Show("Please Select the Complate row to be able to Edit or Delete the record"); 
            }
                
            
        }
        private void _AssignSelectedDataFromGrid()
        {



            if (clsCountryB.CountryID > 0)
            {
               /* clsCountryB.CountryID = Convert.ToInt32(SelectedRow.Cells["CountryID"].Value);
                clsCountryB.CountryName = textBoxCountryName.Text;*/

                if (clsCountryB.Update())
                {
                    MessageBox.Show("Update sucssefull");
                }
                else
                {
                    MessageBox.Show("Update is not successfully ");
                }
            }
            else
            {
                
                if (clsCountryB.AddCountry(clsCountryB.CountryName))
                {
                    MessageBox.Show("Saved successfully");
                }

                   
                else
                    MessageBox.Show("Not saved "); 
            }
        }
       
        private void buttonSave_Click(object sender, EventArgs e)
        {
           clsCountryB.CountryID = Convert.ToInt32( labelCountryNo.Text);
            clsCountryB.CountryName = textBoxCountryName.Text;
                _AssignSelectedDataFromGrid();
                _RefreshDataGride();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
