using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txtStudentID.Text))
            {
                Common.ErrorMessage("StudentID cannot be empty");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                Common.ErrorMessage("Password cannot be empty");
            }
            else
            {
                DAL dal = new DAL();
                string status = dal.ValidateLogin(txtStudentID.Text, txtPassword.Text);
                if (string.IsNullOrEmpty(status))
                {
                    frmSubject sub = new frmSubject();
                    sub.StudentID = txtStudentID.Text;
                    sub.ShowDialog();
                }
                else
                    Common.ErrorMessage(status);
            }
            txtPassword.Text = String.Empty;
            txtStudentID.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
