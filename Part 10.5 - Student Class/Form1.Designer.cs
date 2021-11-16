
namespace Part_10._5___Student_Class
{
    partial class frmStudentForms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnStudentDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(13, 12);
            this.lstStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(216, 228);
            this.lstStudents.TabIndex = 0;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(239, 59);
            this.btnRemoveStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(149, 37);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(239, 15);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(149, 37);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnStudentDetails
            // 
            this.btnStudentDetails.Location = new System.Drawing.Point(239, 104);
            this.btnStudentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentDetails.Name = "btnStudentDetails";
            this.btnStudentDetails.Size = new System.Drawing.Size(149, 37);
            this.btnStudentDetails.TabIndex = 3;
            this.btnStudentDetails.Text = "Student Details";
            this.btnStudentDetails.UseVisualStyleBackColor = true;
            this.btnStudentDetails.Click += new System.EventHandler(this.btnStudentDetails_Click);
            // 
            // frmStudentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 260);
            this.Controls.Add(this.btnStudentDetails);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.lstStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentForms";
            this.Text = "Student Forms";
            this.Load += new System.EventHandler(this.frmStudentForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnStudentDetails;
    }
}

