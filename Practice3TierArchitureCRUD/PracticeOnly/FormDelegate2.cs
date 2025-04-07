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
    public partial class FormDelegate2 : Form
    {
        public delegate void delgateProductAdd(string ProductName);
        public delgateProductAdd delgPAdd; 
        public delgateProductAdd delgLABLELAdd;


        public FormDelegate2()
        {
            InitializeComponent();
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            delgPAdd(textBoxAddCardForm2.Text);
            delgLABLELAdd(textBoxAddCardForm2.Text);
        }
    }
}
