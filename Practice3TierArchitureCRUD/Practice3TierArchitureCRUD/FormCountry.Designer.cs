namespace Practice3TierArchitureCRUD
{
    partial class FormCountry
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountryNo = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.labelCountryTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripCountry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CountryNo.";
            // 
            // labelCountryNo
            // 
            this.labelCountryNo.AutoSize = true;
            this.labelCountryNo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryNo.Location = new System.Drawing.Point(98, 25);
            this.labelCountryNo.Name = "labelCountryNo";
            this.labelCountryNo.Size = new System.Drawing.Size(18, 21);
            this.labelCountryNo.TabIndex = 1;
            this.labelCountryNo.Text = "?";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryName.Location = new System.Drawing.Point(27, 123);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(115, 21);
            this.lblCountryName.TabIndex = 2;
            this.lblCountryName.Text = "Country Name";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(161, 120);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(173, 24);
            this.textBoxCountryName.TabIndex = 3;
            // 
            // labelCountryTitle
            // 
            this.labelCountryTitle.AutoSize = true;
            this.labelCountryTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryTitle.Location = new System.Drawing.Point(290, 15);
            this.labelCountryTitle.Name = "labelCountryTitle";
            this.labelCountryTitle.Size = new System.Drawing.Size(31, 34);
            this.labelCountryTitle.TabIndex = 4;
            this.labelCountryTitle.Text = "?";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(522, 87);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(68, 57);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(695, 87);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 57);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripCountry;
            this.dataGridView1.Location = new System.Drawing.Point(15, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(755, 251);
            this.dataGridView1.TabIndex = 7;
            // 
            // contextMenuStripCountry
            // 
            this.contextMenuStripCountry.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripCountry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripCountry.Name = "contextMenuStripCountry";
            this.contextMenuStripCountry.Size = new System.Drawing.Size(123, 52);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(607, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 57);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // FormCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCountryTitle);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.labelCountryNo);
            this.Controls.Add(this.label1);
            this.Name = "FormCountry";
            this.Text = "FormCountry";
            this.Load += new System.EventHandler(this.FormCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripCountry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountryNo;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label labelCountryTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCountry;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}