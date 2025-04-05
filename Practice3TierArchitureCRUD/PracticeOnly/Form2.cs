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
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxOption.Items.Add("Hello");
            comboBoxOption.Items.Add("Goedby"); 
            action = new Dictionary<string, Action>();
            action.Add("Hello" , sayHi);
            action.Add("Goedby" , sayGoedgy);
            
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
            string selected = comboBoxOption.SelectedItem.ToString();
            if (action.ContainsKey(selected))
            {
                action[selected]();
            }
        }
    }
}
