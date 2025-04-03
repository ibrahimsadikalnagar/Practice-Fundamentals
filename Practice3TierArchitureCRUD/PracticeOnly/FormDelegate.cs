using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOnly
{
    public partial class FormDelegate : Form
    {
        UserControlCountry UserControlCountry1;
        

        public FormDelegate()
        {
            InitializeComponent();

            UserControlCountry1 = new UserControlCountry(); 
            this.Controls.Add(UserControlCountry1);
        }
        private void buttonDelegate_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Delegate2 += form2_Getdata; 
            form2.ShowDialog();


        }
        private void form2_Getdata(string Name )
        {
            textBoxForm1.Text = Name;
        }

        private void FormDelegate_Load(object sender, EventArgs e)
        {
            UserControlCountry1.LoadCountryData(); 
        }
    }
}
