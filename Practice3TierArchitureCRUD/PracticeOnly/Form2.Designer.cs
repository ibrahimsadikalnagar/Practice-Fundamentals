namespace PracticeOnly
{
    partial class Form2
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
            this.labelForm2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSendBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm2
            // 
            this.labelForm2.AutoSize = true;
            this.labelForm2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm2.Location = new System.Drawing.Point(368, 60);
            this.labelForm2.Name = "labelForm2";
            this.labelForm2.Size = new System.Drawing.Size(64, 24);
            this.labelForm2.TabIndex = 0;
            this.labelForm2.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSendBack
            // 
            this.buttonSendBack.Location = new System.Drawing.Point(548, 116);
            this.buttonSendBack.Name = "buttonSendBack";
            this.buttonSendBack.Size = new System.Drawing.Size(118, 81);
            this.buttonSendBack.TabIndex = 2;
            this.buttonSendBack.Text = "button1";
            this.buttonSendBack.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSendBack;
    }
}