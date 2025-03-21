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
            

            clsCountryB clsCountryB = new clsCountryB
            {
                CountryID = Convert.ToInt32(SelectedRow.Cells["CountryID"].Value),
                CountryName = textBoxCountryName.Text,
            };
            if (clsCountryB.Update())
            {
                MessageBox.Show("Update sucssefull");
            }
            else
            {
                MessageBox.Show("Update is not successfully ");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            _AssignSelectedDataFromGrid();
            _RefreshDataGride() ;
        }
    }
}
