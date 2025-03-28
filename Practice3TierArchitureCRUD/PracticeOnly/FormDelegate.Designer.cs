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
            this.labelDelegate = new System.Windows.Forms.Label();
            this.buttonDelegate = new System.Windows.Forms.Button();
            this.comboBoxDelegate = new System.Windows.Forms.ComboBox();
            this.textBoxForm1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDelegate
            // 
            this.labelDelegate.AutoSize = true;
            this.labelDelegate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelegate.Location = new System.Drawing.Point(152, 92);
            this.labelDelegate.Name = "labelDelegate";
            this.labelDelegate.Size = new System.Drawing.Size(19, 24);
            this.labelDelegate.TabIndex = 0;
            this.labelDelegate.Text = "?";
            // 
            // buttonDelegate
            // 
            this.buttonDelegate.Location = new System.Drawing.Point(328, 150);
            this.buttonDelegate.Name = "buttonDelegate";
            this.buttonDelegate.Size = new System.Drawing.Size(144, 93);
            this.buttonDelegate.TabIndex = 1;
            this.buttonDelegate.Text = "Delegate";
            this.buttonDelegate.UseVisualStyleBackColor = true;
            this.buttonDelegate.Click += new System.EventHandler(this.buttonDelegate_Click);
            // 
            // comboBoxDelegate
            // 
            this.comboBoxDelegate.FormattingEnabled = true;
            this.comboBoxDelegate.Location = new System.Drawing.Point(136, 271);
            this.comboBoxDelegate.Name = "comboBoxDelegate";
            this.comboBoxDelegate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDelegate.TabIndex = 2;
            // 
            // textBoxForm1
            // 
            this.textBoxForm1.Location = new System.Drawing.Point(542, 137);
            this.textBoxForm1.Name = "textBoxForm1";
            this.textBoxForm1.Size = new System.Drawing.Size(100, 24);
            this.textBoxForm1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send to Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxForm1);
            this.Controls.Add(this.comboBoxDelegate);
            this.Controls.Add(this.buttonDelegate);
            this.Controls.Add(this.labelDelegate);
            this.Name = "FormDelegate";
            this.Text = "FormDelegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelegate;
        private System.Windows.Forms.Button buttonDelegate;
        private System.Windows.Forms.ComboBox comboBoxDelegate;
        private System.Windows.Forms.TextBox textBoxForm1;
        private System.Windows.Forms.Button button1;
    }
}