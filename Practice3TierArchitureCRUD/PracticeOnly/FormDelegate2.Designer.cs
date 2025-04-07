namespace PracticeOnly
{
    partial class FormDelegate2
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
            this.textBoxAddCardForm2 = new System.Windows.Forms.TextBox();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddCardForm2
            // 
            this.textBoxAddCardForm2.Location = new System.Drawing.Point(54, 40);
            this.textBoxAddCardForm2.Name = "textBoxAddCardForm2";
            this.textBoxAddCardForm2.Size = new System.Drawing.Size(195, 24);
            this.textBoxAddCardForm2.TabIndex = 0;
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Location = new System.Drawing.Point(327, 40);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(131, 38);
            this.buttonAddCard.TabIndex = 1;
            this.buttonAddCard.Text = "Add Card";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // FormDelegate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddCard);
            this.Controls.Add(this.textBoxAddCardForm2);
            this.Name = "FormDelegate2";
            this.Text = "FormDelegate2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddCardForm2;
        private System.Windows.Forms.Button buttonAddCard;
    }
}