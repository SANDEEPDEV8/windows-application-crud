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
    public partial class frmSubject : Form
    {
        public string StudentID;
        public frmSubject()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (DGVSubject.SelectedRows.Count == 1)
            {
                int SubjectID = Convert.ToInt32(DGVSubject.Rows[DGVSubject.CurrentRow.Index].Cells[0].Value);

                DAL dal = new DAL();
                string Error = dal.AddSubject(SubjectID, StudentID);
                if (!string.IsNullOrEmpty(Error))
                {
                    Common.ErrorMessage(Error);
                }
                   // TODO: This line of code loads data into the 'studentDataSet1.GetStudentSubject' table. You can move, or remove it, as needed.
                this.getStudentSubjectTableAdapter1.Fill(this.studentDataSet1.GetStudentSubject);
                DGVStudentSubject.Update();
                DGVStudentSubject.Refresh();
            }
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet11.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.studentDataSet11.Song);
            // TODO: This line of code loads data into the 'studentDataSet1.GetStudentSubject' table. You can move, or remove it, as needed.
            this.getStudentSubjectTableAdapter1.Fill(this.studentDataSet1.GetStudentSubject);
       

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
          
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            if (DGVStudentSubject.SelectedRows.Count == 1)
            {
                int StudentSubjectID = Convert.ToInt32(DGVStudentSubject.Rows[DGVStudentSubject.CurrentRow.Index].Cells[0].Value);

                DAL dal = new DAL();
                string Error = dal.RemoveSubject(StudentSubjectID);
                // TODO: This line of code loads data into the 'studentDataSet1.GetStudentSubject' table. You can move, or remove it, as needed.
                this.getStudentSubjectTableAdapter1.Fill(this.studentDataSet1.GetStudentSubject);
                DGVStudentSubject.Update();
                DGVStudentSubject.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Close();
            
        }

        private void DGVSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
