
namespace Part_10._5___Student_Class
{
    partial class frmAddStudent
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(276, 61);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(77, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(9, 10);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(168, 186);
            this.lstStudents.TabIndex = 4;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(189, 22);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(173, 13);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Enter a Name Below and Click Add";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(194, 38);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(161, 20);
            this.txtAddName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 212);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnDone);
            this.Name = "frmAddStudent";
            this.Text = " Add Name";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Button btnAdd;
    }
}