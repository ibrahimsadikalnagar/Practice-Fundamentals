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
            this.labelFind.Location = new System.Drawing.Point(4, 10);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(75, 17);
            this.labelFind.TabIndex = 4;
            this.labelFind.Text = "Find By ID ";
            // 
            // UserControlCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.textBoxCountryID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Name = "UserControlCountry";
            this.Size = new System.Drawing.Size(334, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCountryID;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelFind;
    }
}
