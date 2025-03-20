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

        private void FormCountry_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsCountryB.GetAllCountries();
        }
    }
}
