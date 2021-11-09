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
     partial class frmStudentForms : Form
    {
        public static List<Student> students = new List<Student>();


        public frmStudentForms()
        {
            InitializeComponent();
        }


        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentForms_Load(object sender, EventArgs e)
        {
            students.Add(new Student("Mitchel", "Gough"));
            students.Add(new Student("Seth", "Fisher"));
            students.Add(new Student("Evan", "Pisano"));
            students.Add(new Student("Felipe", "Gonzalez"));
            students.Add(new Student("Ethan", "Ledgley"));

            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex >= 0)
            {
                students.RemoveAt(lstStudents.SelectedIndex);
                lstStudents.DataSource = null;
                lstStudents.DataSource = students;
            }
            else
            {

            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent();
            frmAddStudent.ShowDialog();

        }
    }
}
