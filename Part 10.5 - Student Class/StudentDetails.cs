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
    public partial class frmStudentDetails : Form
    {
        int index;

        public frmStudentDetails(int index)
        {
            InitializeComponent();
            this.index = index;

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name: " + frmStudentForms.students[index];
            lblStudentNumber.Text = "Student Number: " + frmStudentForms.students[index].StudentNumber;
            lblEmail.Text = "Email: " + frmStudentForms.students[index].Email;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
