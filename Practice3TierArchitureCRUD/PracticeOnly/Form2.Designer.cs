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
            this.userControlUseDictionary2 = new PracticeOnly.UserControlUseDictionary();
            this.textBoxAddCard = new System.Windows.Forms.TextBox();
            this.ButtonAddCard = new System.Windows.Forms.Button();
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
            // userControlUseDictionary2
            // 
            this.userControlUseDictionary2.Location = new System.Drawing.Point(12, 161);
            this.userControlUseDictionary2.Name = "userControlUseDictionary2";
            this.userControlUseDictionary2.Size = new System.Drawing.Size(327, 204);
            this.userControlUseDictionary2.TabIndex = 5;
            this.userControlUseDictionary2.Load += new System.EventHandler(this.userControlUseDictionary2_Load);
            // 
            // textBoxAddCard
            // 
            this.textBoxAddCard.Location = new System.Drawing.Point(713, 67);
            this.textBoxAddCard.Name = "textBoxAddCard";
            this.textBoxAddCard.Size = new System.Drawing.Size(162, 24);
            this.textBoxAddCard.TabIndex = 6;
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.Location = new System.Drawing.Point(891, 67);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.Size = new System.Drawing.Size(133, 44);
            this.ButtonAddCard.TabIndex = 7;
            this.ButtonAddCard.Text = "Add Card";
            this.ButtonAddCard.UseVisualStyleBackColor = true;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddCard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.ButtonAddCard);
            this.Controls.Add(this.textBoxAddCard);
            this.Controls.Add(this.userControlUseDictionary2);
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
        private UserControlUseDictionary userControlUseDictionary2;
        private System.Windows.Forms.TextBox textBoxAddCard;
        private System.Windows.Forms.Button ButtonAddCard;
    }
}