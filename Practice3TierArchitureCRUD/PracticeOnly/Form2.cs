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
        Dictionary<string, Action> action; 
        public delegate void  GetDataBackDelegate(object sender , int PersonID);
       public event GetDataBackDelegate Delegate1;
        public delegate void anotherDataBackDelegate(string PersonName); 
        public event anotherDataBackDelegate Delegate2;

        public delegate void SendMessegeDelegate(string message);
        public SendMessegeDelegate onMessageSend;

        public delegate void delegAddCard(string AddCardDeleg);
        public event delegAddCard delACard; 
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }
        private void sayHi()
        {
            MessageBox.Show("Hello , User"); 
        }
        private void sayGoedgy()
        {
            MessageBox.Show("good , User ");
        }

        private void buttonSendBack_Click(object sender, EventArgs e)
        {
            /*int PersonID = 0;
            if (int.TryParse(textBoxDataReturn.Text, out PersonID))
            {
                Delegate1?.Invoke(this, PersonID);
            }*/

            Delegate2?.Invoke(textBoxDataReturn.Text);
            
            Close();
;
        }

        private void comboBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void userControlUseDictionary2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onMessageSend != null)
            {
                onMessageSend("Hello from form2");
            }
        }

        private void ButtonAddCard_Click(object sender, EventArgs e)
        {
            delACard(textBoxAddCard.Text);  
        }
    }
}
