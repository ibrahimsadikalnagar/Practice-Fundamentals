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
    public partial class UserControlUseDictionary : UserControl
    {
        public Dictionary<string,Action> dicComboChoose = new Dictionary<string,Action>();

        public UserControlUseDictionary()
        {
            InitializeComponent();
        }
      

        private void UserControlUseDictionary_Load(object sender, EventArgs e)
        {
            comboBoxDic.Items.Add("ID");
            comboBoxDic.Items.Add("Name");
            dicComboChoose.Add("ID", () => MessageBox.Show("get the Id"));
            dicComboChoose.Add("Name", () => MessageBox.Show("get the Name ")); 

        }

        private void comboBoxDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboSelected = comboBoxDic.SelectedItem.ToString(); 
            if(dicComboChoose.ContainsKey(comboSelected))
            {
                 dicComboChoose[comboSelected]();
                labelResult.Text = "you selected " + comboSelected; ;
            }
        }

        private void ButtonGroetjes_Click(object sender, EventArgs e)
        {
           

        }
    }
}
