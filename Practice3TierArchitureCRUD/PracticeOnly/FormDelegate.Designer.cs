namespace PracticeOnly
{
    partial class FormDelegate
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
            this.textBoxForm1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControlCountry1 = new PracticeOnly.UserControlCountry();
            this.SuspendLayout();
            // 
            // textBoxForm1
            // 
            this.textBoxForm1.Location = new System.Drawing.Point(359, 22);
            this.textBoxForm1.Name = "textBoxForm1";
            this.textBoxForm1.Size = new System.Drawing.Size(123, 24);
            this.textBoxForm1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send to Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlCountry1
            // 
            this.userControlCountry1.Location = new System.Drawing.Point(82, 144);
            this.userControlCountry1.Name = "userControlCountry1";
            this.userControlCountry1.Size = new System.Drawing.Size(317, 85);
            this.userControlCountry1.TabIndex = 5;
            // 
            // FormDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlCountry1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxForm1);
            this.Name = "FormDelegate";
            this.Text = "FormDelegate";
            this.Load += new System.EventHandler(this.FormDelegate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxForm1;
        private System.Windows.Forms.Button button1;
        private UserControlCountry userControlCountry1;
    }
}