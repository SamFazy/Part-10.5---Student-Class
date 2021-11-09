
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
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(10, 10);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(163, 186);
            this.lstStudents.TabIndex = 0;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(179, 48);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(112, 30);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(179, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(112, 30);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmStudentForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 226);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.lstStudents);
            this.Name = "frmStudentForms";
            this.Text = "Student Forms";
            this.Load += new System.EventHandler(this.frmStudentForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
    }
}

