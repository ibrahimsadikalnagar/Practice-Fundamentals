using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void _AssignData()
        {
            clsUsersB users = new clsUsersB(textBoxUserName.Text , textBoxPassword.Text);
            users.AddUsers(); 
            labelUserNumber.Text = users.UserID.ToString();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

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
    }
}
