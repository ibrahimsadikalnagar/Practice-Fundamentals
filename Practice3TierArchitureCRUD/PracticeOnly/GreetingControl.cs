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
    public partial class GreetingControl : UserControl
    {
        public event EventHandler<GreatingEventArgs> Greated;
        public GreetingControl()
        {
            InitializeComponent();
        }

        private void buttonGreating_Click(object sender, EventArgs e)
        {
            string name = textBoxGreating.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                MessageBox.Show($"Hello {textBoxGreating.Text}");

                Greated?.Invoke(this, new GreatingEventArgs(name));
            }
            else
            {
                MessageBox.Show("Please enter your name "); 
            }
        
        }
    }
}
