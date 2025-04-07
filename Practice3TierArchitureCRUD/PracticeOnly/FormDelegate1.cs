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
    public partial class FormDelegate1 : Form
    {
        public FormDelegate1()
        {
            InitializeComponent();
        }
      

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            FormDelegate2 frmDelgate = new FormDelegate2();
            frmDelgate.delgPAdd = AddProductToList;
            frmDelgate.delgLABLELAdd = LastProductAdd;
            frmDelgate.Show();
          

        }
        private void AddProductToList(string productName) 
        {
            listBoxForm1Card.Items.Add(productName);
        }
        private void LastProductAdd(string productName)
        {
            labelLastProcduct.Text = productName;
        }
    }
}
