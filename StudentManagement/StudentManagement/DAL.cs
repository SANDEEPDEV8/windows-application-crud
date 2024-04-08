using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Entity;

namespace StudentManagement
{
     class  DAL
    {
        public string ValidateLogin(string studentID, string pwd)
        {
            try
            {

                using (SongEntities1 db = new SongEntities1())
                {
                    int Status = (from student in db.Logins
                                  where student.StudentID == studentID &&
                                  student.Password == pwd
                                  select student).Count();

                    if (Status > 0)
                        return (string.Empty);
                    else
                        return ("StudentID or Password is incorrect");


                }
            }
            catch(Exception ex)
            {
                return (ex.Message);
            }
        }

        public string AddSubject (int SubjectID, string StudentID)
        {
            try
            {

                using (SongEntities1 db = new SongEntities1())
                {
                    var Status = (from  s in db.StudentSubjects
                                  where s.StudentID == StudentID &&
                                  s.SubjectID == SubjectID
                                  select s).Count();

                    if (Status > 0)
                        return ("Subject Already exits");
                    else
                    {
                        StudentSubject sb = new StudentSubject();
                        sb.SubjectID = SubjectID;
                        sb.StudentID = StudentID;
                        db.StudentSubjects.Add(sb);
                        db.SaveChanges();
                        return string.Empty;
                    }


                }
            }
            catch (Exception ex)

            {
                return (ex.Message);
            }
        }

        public string RemoveSubject(int StudentSubjectID)
        {
            try
            {

                using (SongEntities1 db = new SongEntities1())
                {
                    var Status = (from s in db.StudentSubjects
                                  where s.StudentSubjectID == StudentSubjectID 
                                  select s).Count();

                    if (Status <= 0)
                        return ("Subject does not exits");
                    else
                    {
                        StudentSubject sub = new StudentSubject();
                        sub=(from s in db.StudentSubjects
                                      where s.StudentSubjectID == StudentSubjectID 
                                      select s).Single();
                   
                        db.StudentSubjects.Remove(sub);
                        db.SaveChanges();
                        return string.Empty;
                    }


                }
            }
            catch (Exception ex)

            {
                return (ex.Message);
            }
        }
    }
}
