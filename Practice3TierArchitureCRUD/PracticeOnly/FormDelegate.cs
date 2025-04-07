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
        Dictionary<string , string > FriutsDiction = new Dictionary<string , string >();    
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
        private void showMessage(string message)
        {
            MessageBox.Show("form1 got message " + message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.onMessageSend = showMessage;
            frm2.Show(); 

        }
        private void form2_Getdata(string Name )
        {
            textBoxForm1.Text = Name;
        }

        private void FormDelegate_Load(object sender, EventArgs e)
        {
            comboBoxTryDic.Items.Add("Apple");
            comboBoxTryDic.Items.Add("Bananen");
            comboBoxTryDic.Items.Add("Orange");
            comboBoxTryDic.Items.Add("gruips"); 

            FriutsDiction.Add("Apple", "Green Appel");
            FriutsDiction.Add("Banane", "Geel bananen");
            FriutsDiction.Add("Orange", "Heel vetemiena C"); 
        }

        private void userControlCalculate1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTryDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxTryDic.SelectedItem.ToString();

           if(FriutsDiction.TryGetValue(selected , out string description))
            {
                MessageBox.Show(description); 
            }
           else
            {
                labelMetCombo.Text = "That fruit is not found"; 
            }
        }

        private void userControlCountry2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFrm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.delACard += AddCardToList;
            frm2.Show();
        }
        private void AddCardToList(string productName)
        {
            listBox1.Items.Add(productName);
        }
    }
}
