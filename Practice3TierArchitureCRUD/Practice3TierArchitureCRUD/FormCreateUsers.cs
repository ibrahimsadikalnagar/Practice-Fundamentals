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
      public  enum enMode { AddMode = 0 , UpdateMode =1 };
        private enMode _Mode; 
        int _UserID = 0;
        clsUsersB _User;
        public FormCreateUsers(int UserID)
        {
            
            InitializeComponent();
          _UserID = UserID;
            if (UserID == -1)
            {
                _Mode = enMode.AddMode;
            }
            else
            {
                _Mode = enMode.UpdateMode;
            }

        }
        MainForm mainForm = new MainForm();

        private void _AssignData()
        {
            clsUsersB users = new clsUsersB(textBoxUserName.Text, textBoxPassword.Text);
            if (_Mode == enMode.AddMode)
            {


                users.AddUsers();
            }
            else
            {
                users.UpdateData();
            }

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
        private void _LoadData()
        {
            if (_Mode == enMode.AddMode)
            {
                labelTitleAddEdit.Text = "Add New Users";
                _User = new clsUsersB();
                return; 
            }
            _User = clsUsersB.FindID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("The data is not in the system ");
                this.Close();
                return;
            }

            labelTitleAddEdit.Text = "Edit Users"; 
            labelUserNumber.Text = _UserID.ToString();
            textBoxUserName.Text = _User.UserName;
            textBoxPassword.Text = _User.Password;

        }

        private void FormCreateUsers_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
