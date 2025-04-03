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

      
    }
}
