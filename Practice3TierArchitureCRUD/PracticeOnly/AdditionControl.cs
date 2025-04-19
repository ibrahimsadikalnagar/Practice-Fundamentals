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
    public partial class AdditionControl : UserControl
    {
        public event EventHandler<AdditionEventArgs1> AdditionCompleted;
        public AdditionControl()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBoxfirstNumber.Text);
                int num2 = int.Parse(textBoxSecondNumber.Text);
                int Result = num1 + num2;
                label1.Text = Result.ToString();
                MessageBox.Show($"Result = {Result}");
                AdditionCompleted?.Invoke(this, new AdditionEventArgs1(Result));

                    
            }
            catch (Exception ex) { 
                MessageBox.Show("Invalid input " + ex.Message );
            }
        }
    }
}
