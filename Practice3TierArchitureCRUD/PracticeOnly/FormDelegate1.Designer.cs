namespace PracticeOnly
{
    partial class FormDelegate1
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
            this.buttonOpenForm2 = new System.Windows.Forms.Button();
            this.listBoxForm1Card = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLastProcduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Location = new System.Drawing.Point(389, 27);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(102, 59);
            this.buttonOpenForm2.TabIndex = 0;
            this.buttonOpenForm2.Text = "Open form2";
            this.buttonOpenForm2.UseVisualStyleBackColor = true;
            this.buttonOpenForm2.Click += new System.EventHandler(this.buttonOpenForm2_Click);
            // 
            // listBoxForm1Card
            // 
            this.listBoxForm1Card.FormattingEnabled = true;
            this.listBoxForm1Card.ItemHeight = 16;
            this.listBoxForm1Card.Location = new System.Drawing.Point(35, 27);
            this.listBoxForm1Card.Name = "listBoxForm1Card";
            this.listBoxForm1Card.Size = new System.Drawing.Size(246, 180);
            this.listBoxForm1Card.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Product add is ";
            // 
            // labelLastProcduct
            // 
            this.labelLastProcduct.AutoSize = true;
            this.labelLastProcduct.Location = new System.Drawing.Point(32, 293);
            this.labelLastProcduct.Name = "labelLastProcduct";
            this.labelLastProcduct.Size = new System.Drawing.Size(22, 17);
            this.labelLastProcduct.TabIndex = 3;
            this.labelLastProcduct.Text = "??";
            // 
            // FormDelegate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLastProcduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxForm1Card);
            this.Controls.Add(this.buttonOpenForm2);
            this.Name = "FormDelegate1";
            this.Text = "FormDelegate1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.ListBox listBoxForm1Card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLastProcduct;
    }
}