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
        public delegate void UpdateLabelDelegate(string text);
        public delegate void DelegateMessage(); 

        public FormDelegate()
        {
            InitializeComponent();
            comboBoxDelegate.Items.Add("Say Hello");
            comboBoxDelegate.Items.Add("Say Goodbye");
            comboBoxDelegate.Items.Add("Say tot ziens");
            comboBoxDelegate.Items.Add("Try"); 
            comboBoxDelegate.SelectedIndex = 0;
        }
        public void UpdateLabel1(string newText)
        {
            labelDelegate.Text = newText;
        }
        public void showHello()
        {
          MessageBox.Show("Hello , Delegate"); 
        }
        public void showgoodbye()
        {
            MessageBox.Show("Goedbye , Delegate"); 
        }
        public void showbadbye()
        {
            MessageBox.Show("totzins , Delegate laar");
        }

        private void buttonDelegate_Click(object sender, EventArgs e)
        {
            
            DelegateMessage[] delegateMessage = {showHello, showgoodbye , showbadbye};
          
         int selectedIndex = comboBoxDelegate.SelectedIndex;
            int teuuu = delegateMessage.Length;
            if (selectedIndex >= 0 && selectedIndex < delegateMessage.Length)
            {
                delegateMessage[selectedIndex]();
            }
          
        }
    }
}
