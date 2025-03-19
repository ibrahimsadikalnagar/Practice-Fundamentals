using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3TierArchitureCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormCreateUsers formCreateUsers = new FormCreateUsers();
            formCreateUsers.UserAdded += LoadUsers;
            formCreateUsers.ShowDialog();
        }
        public void LoadUsers()
        {
            dataGridViewUsers.DataSource = clsUsersB.GetUsers();
            
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                string userName = selectedRow.Cells["UserName"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {userName}?",
                                              "Confirm Deletion",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    clsUsersB.Delete(userName);
                    LoadUsers(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadUsers();
        }
    }
}
