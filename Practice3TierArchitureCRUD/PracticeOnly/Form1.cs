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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdditionControl addionControl = new AdditionControl();
            addionControl.Location = new Point(10,10);
            this.Controls.Add(addionControl);
            addionControl.AdditionCompleted += AdditionControl_AdditionCompleted;
        }
        private void AdditionControl_AdditionCompleted(object sender , AdditionEventArgs1 e )
        {
            MessageBox.Show($"Additon complete the result is {e.Result}");
        }
    }
}
