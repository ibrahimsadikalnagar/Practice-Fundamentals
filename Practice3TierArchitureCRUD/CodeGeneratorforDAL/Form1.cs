using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratorforDAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string TableName = textBoxTableName.Text.Trim();
            string TableColumn = textBoxTableColoumn.Text.Trim();
            if (string.IsNullOrEmpty(TableName) || string.IsNullOrEmpty(TableColumn))
            {
                MessageBox.Show("Please enter Table name and table coloumn names ");
                return;
            }
            string[] coloums = TableColumn.Split(',');
            StringBuilder ClassBuilder = new StringBuilder();
            ClassBuilder.AppendLine($"public class {TableName}DAL");
            ClassBuilder.AppendLine("{");

            foreach (var item in checkedListBoxCRUD.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Insert":
                        ClassBuilder.AppendLine(GenerateInsertCode(TableName,coloums));
                        break;
                    case "Delete":
                        ClassBuilder.AppendLine();
                        break;
                    case "Update":
                        ClassBuilder.AppendLine();
                        break;
                    case "Find":
                        ClassBuilder.AppendLine();
                        break;
                    case "View":
                        ClassBuilder.AppendLine();
                        break;
                }
            }
            ClassBuilder.AppendLine("}");
            richTextBoxCode.Text = ClassBuilder.ToString();
        }
        private string GenerateInsertCode(string tableName, string[] columns)
        {
            StringBuilder Method = new StringBuilder();
            string ColumnNames = string.Join(",", Array.ConvertAll(columns, c => c.Split(':')[0]));
            string Values = string.Join(",", Array.ConvertAll(columns, c => "@" + c.Split(':')[0]));

            Method.AppendLine($@"
public void Insert{tableName}({tableName} entity)
{{
    using (SqlConnection conn = new SqlConnection(""Server=.;Database=ContactsDB;User Id=sa;Password=123456"");
    {{
        string query = ""INSERT INTO {tableName} ({ColumnNames}) VALUES ({Values})"";
        SqlCommand cmd = new SqlCommand(query, conn);
        {GenerateParameterAssignments(columns, "entity")}

        conn.Open();
        cmd.ExecuteNonQuery();
    }}
}}");
            return Method.ToString();
        }
        private string GenerateParameterAssignments(string[] columns, string objectName)
        {
            StringBuilder assignments = new StringBuilder();

            foreach (var column in columns)
            {
                string columnName = column.Split(':')[0]; // Extract column name
                assignments.AppendLine($"        cmd.Parameters.AddWithValue(\"@{columnName}\", {objectName}.{columnName});");
            }

            return assignments.ToString();
        }

        private void buttonCopyCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxCode.Text))
            {
                Clipboard.SetText(richTextBoxCode.Text);
                MessageBox.Show("Code copied to clipboard ! ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No code to copy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

       
                
    



 
