using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL; 

namespace Practice3TierArchitureCRUD
{
    public partial class FormCreateUsers : Form
    {
        public FormCreateUsers()
        {
            
            InitializeComponent();
          

        }
        MainForm mainForm = new MainForm();

        private void _AssignData()
        {
            clsUsersB users = new clsUsersB(textBoxUserName.Text , textBoxPassword.Text);

            users.AddUsers(); 

            labelUserNumber.Text = users.UserID.ToString();
            if (users.UserID != 0)
            {
                MessageBox.Show("Data saved sucssefully");
            }
            else
            {
                MessageBox.Show("Data not saved");
            }


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
             mainForm.LoadUsers();
            
           

        }
        private bool _CheckUserExist()
        {
            if (clsUsersB.find(textBoxUserName.Text))
            {
                return true; 
               
            }
            else
            {
                return false;
                MessageBox.Show("Data is not in the system you can use it ");
            }
        }
        public event Action UserAdded; 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            
                _AssignData();
            UserAdded?.Invoke(); 
            




        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (_CheckUserExist())
            {
                labelWorningUsers.Text = "This username is already taken!"; 
                labelWorningUsers.ForeColor = Color.Red;
                labelWorningUsers.Visible = true;
                TimerFlashWarning.Start();
                /*MessageBox.Show("The user that you entered is used please enter another users ");
                textBoxUserName.Clear();
                textBoxUserName.Focus();*/

            }   
            else
            {
                labelWorningUsers.Text = ""; 
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(clsUsersB.Delete(textBoxUserName.Text))
            {
                MessageBox.Show("User " + textBoxUserName.Text + " is successfully  Deleted");
                textBoxUserName.Clear();
                textBoxUserName.Focus();    
            }
        }
        public  void Delete()
        {
            MessageBox.Show("User " + textBoxUserName.Text + " is successfully  Deleted");
            textBoxUserName.Clear();
            textBoxUserName.Focus();
        }
    }
}
