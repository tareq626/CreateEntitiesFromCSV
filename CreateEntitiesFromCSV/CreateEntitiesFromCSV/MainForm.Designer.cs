namespace CreateEntitiesFromCSV
{
    partial class MainForm
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
            this.txtBoxFileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxConfirmation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxFileLocation
            // 
            this.txtBoxFileLocation.Location = new System.Drawing.Point(286, 68);
            this.txtBoxFileLocation.Name = "txtBoxFileLocation";
            this.txtBoxFileLocation.Size = new System.Drawing.Size(959, 38);
            this.txtBoxFileLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(75, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(175, 56);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(75, 168);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(321, 74);
            this.btnCreateClass.TabIndex = 2;
            this.btnCreateClass.Text = "Create Class";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(75, 508);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(1170, 583);
            this.txtBoxOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(69, 473);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(101, 32);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output";
            // 
            // txtBoxConfirmation
            // 
            this.txtBoxConfirmation.Location = new System.Drawing.Point(75, 287);
            this.txtBoxConfirmation.Multiline = true;
            this.txtBoxConfirmation.Name = "txtBoxConfirmation";
            this.txtBoxConfirmation.Size = new System.Drawing.Size(1170, 137);
            this.txtBoxConfirmation.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 1143);
            this.Controls.Add(this.txtBoxConfirmation);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxFileLocation);
            this.Name = "MainForm";
            this.Text = "Create Entities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFileLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBoxConfirmation;
    }
}

