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
    public partial class Form2 : Form
    {
        public delegate void DelegateBackHandler(object sender, int PersonID);

        public event DelegateBackHandler DelegateBack;
        public int Numbers { get; set; }    
        public Form2(int numbers)
        {
            InitializeComponent();
            Numbers = numbers;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelForm2.Text = Numbers.ToString();
        }
    }
}
