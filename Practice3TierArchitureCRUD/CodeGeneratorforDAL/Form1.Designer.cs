namespace CodeGeneratorforDAL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTableName = new System.Windows.Forms.Label();
            this.labelColoums = new System.Windows.Forms.Label();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.textBoxTableColoumn = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopyCode = new System.Windows.Forms.Button();
            this.checkedListBoxCRUD = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.Location = new System.Drawing.Point(17, 94);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(104, 22);
            this.labelTableName.TabIndex = 0;
            this.labelTableName.Text = "Table Name";
            // 
            // labelColoums
            // 
            this.labelColoums.AutoSize = true;
            this.labelColoums.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColoums.Location = new System.Drawing.Point(17, 126);
            this.labelColoums.Name = "labelColoums";
            this.labelColoums.Size = new System.Drawing.Size(127, 22);
            this.labelColoums.TabIndex = 1;
            this.labelColoums.Text = "Table Columns";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(169, 96);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(246, 24);
            this.textBoxTableName.TabIndex = 4;
            // 
            // textBoxTableColoumn
            // 
            this.textBoxTableColoumn.Location = new System.Drawing.Point(169, 134);
            this.textBoxTableColoumn.Name = "textBoxTableColoumn";
            this.textBoxTableColoumn.Size = new System.Drawing.Size(406, 24);
            this.textBoxTableColoumn.TabIndex = 5;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(169, 292);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(91, 47);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate Code";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopyCode
            // 
            this.buttonCopyCode.Location = new System.Drawing.Point(274, 292);
            this.buttonCopyCode.Name = "buttonCopyCode";
            this.buttonCopyCode.Size = new System.Drawing.Size(91, 47);
            this.buttonCopyCode.TabIndex = 7;
            this.buttonCopyCode.Text = "Copy Code";
            this.buttonCopyCode.UseVisualStyleBackColor = true;
            this.buttonCopyCode.Click += new System.EventHandler(this.buttonCopyCode_Click);
            // 
            // checkedListBoxCRUD
            // 
            this.checkedListBoxCRUD.FormattingEnabled = true;
            this.checkedListBoxCRUD.Items.AddRange(new object[] {
            "Insert",
            "Delete   ",
            "Update   ",
            "Select"});
            this.checkedListBoxCRUD.Location = new System.Drawing.Point(169, 172);
            this.checkedListBoxCRUD.Name = "checkedListBoxCRUD";
            this.checkedListBoxCRUD.Size = new System.Drawing.Size(246, 99);
            this.checkedListBoxCRUD.TabIndex = 8;
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.Location = new System.Drawing.Point(613, 75);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.Size = new System.Drawing.Size(397, 352);
            this.richTextBoxCode.TabIndex = 9;
            this.richTextBoxCode.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(484, 292);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 47);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(379, 292);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(91, 47);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxCode);
            this.Controls.Add(this.checkedListBoxCRUD);
            this.Controls.Add(this.buttonCopyCode);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxTableColoumn);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.labelColoums);
            this.Controls.Add(this.labelTableName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Label labelColoums;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.TextBox textBoxTableColoumn;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopyCode;
        private System.Windows.Forms.CheckedListBox checkedListBoxCRUD;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
    }
}

