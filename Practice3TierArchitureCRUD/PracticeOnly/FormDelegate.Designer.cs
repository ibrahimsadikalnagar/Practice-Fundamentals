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
            this.buttonOpenForm2 = new System.Windows.Forms.Button();
            this.comboBoxTryDic = new System.Windows.Forms.ComboBox();
            this.labelMetCombo = new System.Windows.Forms.Label();
            this.userControlCountry2 = new PracticeOnly.UserControlCountry();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonOpenFrm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForm1
            // 
            this.textBoxForm1.Location = new System.Drawing.Point(412, 28);
            this.textBoxForm1.Name = "textBoxForm1";
            this.textBoxForm1.Size = new System.Drawing.Size(123, 24);
            this.textBoxForm1.TabIndex = 3;
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Location = new System.Drawing.Point(92, 368);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(147, 46);
            this.buttonOpenForm2.TabIndex = 4;
            this.buttonOpenForm2.Text = "Send to Form2";
            this.buttonOpenForm2.UseVisualStyleBackColor = true;
            this.buttonOpenForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTryDic
            // 
            this.comboBoxTryDic.FormattingEnabled = true;
            this.comboBoxTryDic.Location = new System.Drawing.Point(34, 232);
            this.comboBoxTryDic.Name = "comboBoxTryDic";
            this.comboBoxTryDic.Size = new System.Drawing.Size(218, 24);
            this.comboBoxTryDic.TabIndex = 7;
            this.comboBoxTryDic.SelectedIndexChanged += new System.EventHandler(this.comboBoxTryDic_SelectedIndexChanged);
            // 
            // labelMetCombo
            // 
            this.labelMetCombo.AutoSize = true;
            this.labelMetCombo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetCombo.Location = new System.Drawing.Point(109, 287);
            this.labelMetCombo.Name = "labelMetCombo";
            this.labelMetCombo.Size = new System.Drawing.Size(54, 21);
            this.labelMetCombo.TabIndex = 8;
            this.labelMetCombo.Text = "label1";
            // 
            // userControlCountry2
            // 
            this.userControlCountry2.Location = new System.Drawing.Point(19, 51);
            this.userControlCountry2.Name = "userControlCountry2";
            this.userControlCountry2.Size = new System.Drawing.Size(334, 158);
            this.userControlCountry2.TabIndex = 6;
            this.userControlCountry2.Load += new System.EventHandler(this.userControlCountry2_Load);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(730, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 228);
            this.listBox1.TabIndex = 9;
            // 
            // buttonOpenFrm2
            // 
            this.buttonOpenFrm2.Location = new System.Drawing.Point(990, 148);
            this.buttonOpenFrm2.Name = "buttonOpenFrm2";
            this.buttonOpenFrm2.Size = new System.Drawing.Size(75, 61);
            this.buttonOpenFrm2.TabIndex = 10;
            this.buttonOpenFrm2.Text = "Open form2";
            this.buttonOpenFrm2.UseVisualStyleBackColor = true;
            this.buttonOpenFrm2.Click += new System.EventHandler(this.buttonOpenFrm2_Click);
            // 
            // FormDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 492);
            this.Controls.Add(this.buttonOpenFrm2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMetCombo);
            this.Controls.Add(this.comboBoxTryDic);
            this.Controls.Add(this.userControlCountry2);
            this.Controls.Add(this.buttonOpenForm2);
            this.Controls.Add(this.textBoxForm1);
            this.Name = "FormDelegate";
            this.Text = "FormDelegate";
            this.Load += new System.EventHandler(this.FormDelegate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxForm1;
        private System.Windows.Forms.Button buttonOpenForm2;
        private UserControlCountry userControlCountry2;
        private System.Windows.Forms.ComboBox comboBoxTryDic;
        private System.Windows.Forms.Label labelMetCombo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonOpenFrm2;
    }
}