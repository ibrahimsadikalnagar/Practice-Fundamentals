﻿namespace PracticeOnly
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
            this.comboBoxDic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Location = new System.Drawing.Point(500, 34);
            this.buttonOpenForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(131, 74);
            this.buttonOpenForm2.TabIndex = 0;
            this.buttonOpenForm2.Text = "Open form2";
            this.buttonOpenForm2.UseVisualStyleBackColor = true;
            this.buttonOpenForm2.Click += new System.EventHandler(this.buttonOpenForm2_Click);
            // 
            // listBoxForm1Card
            // 
            this.listBoxForm1Card.FormattingEnabled = true;
            this.listBoxForm1Card.ItemHeight = 20;
            this.listBoxForm1Card.Location = new System.Drawing.Point(45, 34);
            this.listBoxForm1Card.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxForm1Card.Name = "listBoxForm1Card";
            this.listBoxForm1Card.Size = new System.Drawing.Size(315, 224);
            this.listBoxForm1Card.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Product add is ";
            // 
            // labelLastProcduct
            // 
            this.labelLastProcduct.AutoSize = true;
            this.labelLastProcduct.Location = new System.Drawing.Point(41, 366);
            this.labelLastProcduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastProcduct.Name = "labelLastProcduct";
            this.labelLastProcduct.Size = new System.Drawing.Size(27, 20);
            this.labelLastProcduct.TabIndex = 3;
            this.labelLastProcduct.Text = "??";
            // 
            // comboBoxDic
            // 
            this.comboBoxDic.FormattingEnabled = true;
            this.comboBoxDic.Location = new System.Drawing.Point(695, 267);
            this.comboBoxDic.Name = "comboBoxDic";
            this.comboBoxDic.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDic.TabIndex = 4;
            this.comboBoxDic.SelectedIndexChanged += new System.EventHandler(this.comboBoxDic_SelectedIndexChanged);
            // 
            // FormDelegate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 562);
            this.Controls.Add(this.comboBoxDic);
            this.Controls.Add(this.labelLastProcduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxForm1Card);
            this.Controls.Add(this.buttonOpenForm2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDelegate1";
            this.Text = "FormDelegate1";
            this.Load += new System.EventHandler(this.FormDelegate1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.ListBox listBoxForm1Card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLastProcduct;
        private System.Windows.Forms.ComboBox comboBoxDic;
    }
}