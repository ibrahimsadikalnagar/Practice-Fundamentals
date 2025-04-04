namespace PracticeOnly
{
    partial class UserControlCountry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCountryID = new System.Windows.Forms.TextBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 49);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(77, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Country ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Country Name";
            // 
            // textBoxCountryID
            // 
            this.textBoxCountryID.Location = new System.Drawing.Point(108, 42);
            this.textBoxCountryID.Name = "textBoxCountryID";
            this.textBoxCountryID.Size = new System.Drawing.Size(87, 24);
            this.textBoxCountryID.TabIndex = 2;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(108, 72);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(189, 24);
            this.textBoxCountryName.TabIndex = 3;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(15, 17);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(53, 17);
            this.labelFind.TabIndex = 4;
            this.labelFind.Text = "Find by";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(108, 102);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 37);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "ID",
            "Country Name"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(108, 10);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(189, 24);
            this.comboBoxSearchType.TabIndex = 6;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // UserControlCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.textBoxCountryID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "UserControlCountry";
            this.Size = new System.Drawing.Size(334, 158);
            this.Load += new System.EventHandler(this.UserControlCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCountryID;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
    }
}
