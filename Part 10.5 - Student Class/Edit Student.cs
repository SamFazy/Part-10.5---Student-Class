using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10._5___Student_Class
{
    public partial class frmEditStudents : Form
    {
        int index;

        public frmEditStudents(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {
            lblStudentName.Text = "The Students Name You Are Editing: " + frmStudentForms.students[index];
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {

            }
            else
            {
                frmStudentForms.students.RemoveAt(index);
                frmStudentForms.students.Add(new Student(txtFirstName.Text, txtLastName.Text));
                this.Dispose();
            }

        }
    }
}
