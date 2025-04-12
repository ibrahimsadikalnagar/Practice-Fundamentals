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
    public partial class FormDelegate1 : Form
    {
        public Dictionary<string, Action> CountryAction; 
        public FormDelegate1()
        {
            InitializeComponent();
           
            CountryAction = new Dictionary<string, Action>
            {
                { "NL" , NL },
                {  "AR" , () => MessageBox.Show("Hello in Arabic world") },
                {"EN" , () => MessageBox.Show("Hello in english")}
            };
            comboBoxDic.Items.AddRange(new string[] { "NL", "AR", "EN" });
            //comboBoxDic.SelectedIndex = 0;


        }
        public void NL()
        {
            MessageBox.Show("hallo nederland");
        }


        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            FormDelegate2 frmDelgate = new FormDelegate2();
            frmDelgate.delgPAdd = AddProductToList;
            frmDelgate.delgLABLELAdd = LastProductAdd;
            frmDelgate.Show();
          

        }
        private void AddProductToList(string productName) 
        {
            listBoxForm1Card.Items.Add(productName);
        }
        private void LastProductAdd(string productName)
        {
            labelLastProcduct.Text = productName;
        }

        private void FormDelegate1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCode = comboBoxDic.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCode) && CountryAction.TryGetValue(selectedCode, out Action action))
            {
                action.Invoke();
            }
            else
            {
                MessageBox.Show("Onbekende code.");
            }
        }
    }
}
