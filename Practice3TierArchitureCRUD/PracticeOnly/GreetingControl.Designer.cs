namespace PracticeOnly
{
    partial class GreetingControl
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
            this.textBoxGreating = new System.Windows.Forms.TextBox();
            this.buttonGreating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGreating
            // 
            this.textBoxGreating.Location = new System.Drawing.Point(59, 39);
            this.textBoxGreating.Name = "textBoxGreating";
            this.textBoxGreating.Size = new System.Drawing.Size(199, 26);
            this.textBoxGreating.TabIndex = 0;
            // 
            // buttonGreating
            // 
            this.buttonGreating.Location = new System.Drawing.Point(91, 90);
            this.buttonGreating.Name = "buttonGreating";
            this.buttonGreating.Size = new System.Drawing.Size(125, 53);
            this.buttonGreating.TabIndex = 1;
            this.buttonGreating.Text = "Greating";
            this.buttonGreating.UseVisualStyleBackColor = true;
            this.buttonGreating.Click += new System.EventHandler(this.buttonGreating_Click);
            // 
            // GreetingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGreating);
            this.Controls.Add(this.textBoxGreating);
            this.Name = "GreetingControl";
            this.Size = new System.Drawing.Size(311, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGreating;
        private System.Windows.Forms.Button buttonGreating;
    }
}
