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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstStudents.DataSource = frmStudentForms.students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddName.Text == "")
            {

            }

            else
            {
                frmStudentForms.students.Add(txtAddName.Text);
                lstStudents.DataSource = null;
                lstStudents.DataSource = frmStudentForms.students;
            }

            txtAddName.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
