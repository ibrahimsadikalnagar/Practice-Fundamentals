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
    public partial class UserControlCalculate : UserControl
    {
        public UserControlCalculate()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            labelResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }
    }
}
