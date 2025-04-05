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
            this.textBoxDataReturn = new System.Windows.Forms.TextBox();
            this.buttonSendBack = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxDataReturn
            // 
            this.textBoxDataReturn.Location = new System.Drawing.Point(28, 27);
            this.textBoxDataReturn.Name = "textBoxDataReturn";
            this.textBoxDataReturn.Size = new System.Drawing.Size(162, 24);
            this.textBoxDataReturn.TabIndex = 1;
            // 
            // buttonSendBack
            // 
            this.buttonSendBack.Location = new System.Drawing.Point(28, 77);
            this.buttonSendBack.Name = "buttonSendBack";
            this.buttonSendBack.Size = new System.Drawing.Size(162, 44);
            this.buttonSendBack.TabIndex = 2;
            this.buttonSendBack.Text = "Close and return Data";
            this.buttonSendBack.UseVisualStyleBackColor = true;
            this.buttonSendBack.Click += new System.EventHandler(this.buttonSendBack_Click);
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Location = new System.Drawing.Point(328, 39);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(187, 24);
            this.comboBoxOption.TabIndex = 3;
            this.comboBoxOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxOption_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonSendBack);
            this.Controls.Add(this.textBoxDataReturn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDataReturn;
        private System.Windows.Forms.Button buttonSendBack;
        private System.Windows.Forms.ComboBox comboBoxOption;
    }
}