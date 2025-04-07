namespace PracticeOnly
{
    partial class UserControlUseDictionary
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
            this.labelDic = new System.Windows.Forms.Label();
            this.comboBoxDic = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelResult = new System.Windows.Forms.Label();
            this.ButtonGroetjes = new System.Windows.Forms.Button();
            this.textBoxDic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDic
            // 
            this.labelDic.AutoSize = true;
            this.labelDic.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDic.Location = new System.Drawing.Point(26, 31);
            this.labelDic.Name = "labelDic";
            this.labelDic.Size = new System.Drawing.Size(85, 28);
            this.labelDic.TabIndex = 0;
            this.labelDic.Text = "Choose";
            // 
            // comboBoxDic
            // 
            this.comboBoxDic.FormattingEnabled = true;
            this.comboBoxDic.Location = new System.Drawing.Point(117, 35);
            this.comboBoxDic.Name = "comboBoxDic";
            this.comboBoxDic.Size = new System.Drawing.Size(164, 24);
            this.comboBoxDic.TabIndex = 1;
            this.comboBoxDic.SelectedIndexChanged += new System.EventHandler(this.comboBoxDic_SelectedIndexChanged);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(26, 81);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(34, 28);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "??";
            // 
            // ButtonGroetjes
            // 
            this.ButtonGroetjes.Location = new System.Drawing.Point(117, 133);
            this.ButtonGroetjes.Name = "ButtonGroetjes";
            this.ButtonGroetjes.Size = new System.Drawing.Size(164, 41);
            this.ButtonGroetjes.TabIndex = 3;
            this.ButtonGroetjes.Text = "Groetjes";
            this.ButtonGroetjes.UseVisualStyleBackColor = true;
            this.ButtonGroetjes.Click += new System.EventHandler(this.ButtonGroetjes_Click);
            // 
            // textBoxDic
            // 
            this.textBoxDic.Location = new System.Drawing.Point(117, 81);
            this.textBoxDic.Name = "textBoxDic";
            this.textBoxDic.Size = new System.Drawing.Size(164, 24);
            this.textBoxDic.TabIndex = 4;
            // 
            // UserControlUseDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDic);
            this.Controls.Add(this.ButtonGroetjes);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxDic);
            this.Controls.Add(this.labelDic);
            this.Name = "UserControlUseDictionary";
            this.Size = new System.Drawing.Size(344, 218);
            this.Load += new System.EventHandler(this.UserControlUseDictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDic;
        private System.Windows.Forms.ComboBox comboBoxDic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button ButtonGroetjes;
        private System.Windows.Forms.TextBox textBoxDic;
    }
}
