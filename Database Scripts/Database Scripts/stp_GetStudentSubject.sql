USE [Student]
GO

/****** Object:  StoredProcedure [dbo].[GetStudentSubject]    Script Date: 11/19/2022 4:58:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[GetStudentSubject] 
----@StudentID char(8)
AS 
Begin
select sub.SubjectName,s.StudentSubjectID, sub.SubjectCode, sub.SubjectType, sub.Credit
from dbo.StudentSubject s inner join
     dbo.Subjects sub on sub.subjectID  = s.subjectID
	 inner join Login st on st.studentID = s.studentID
   where s.StudentID='admin'
end







GO


