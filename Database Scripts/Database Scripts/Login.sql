
Create Table Login (
StudentID char(8) Not NULL primary key,
Password char(8) NOT NULL,
  
)
insert into dbo.Login values('admin','admin')
insert into dbo.subjects values('Advance programming C#','CS5001','Computer Science',3)
insert into dbo.subjects values('Complier Design','CS5002','Computer Science',3)
insert into dbo.subjects values('Advance programming java','CS5003','Computer Science',3)
insert into dbo.subjects values('Ethical Hacking','Cy5005','Cyber Security',3)
insert into dbo.subjects values('Advance Operating System','CS5004','Computer Science',3)
insert into dbo.subjects values('Software Enginnering','SE5004','Software Engineering',3)

insert into dbo.StudentSubject values(1,'admin')
insert into dbo.StudentSubject values(2,'admin')
insert into dbo.StudentSubject values(4,'admin')
insert into dbo.StudentSubject values(5,'admin')


select * from dbo.Login
select * from dbo.subjects
select * from dbo.StudentSubject
delete from dbo.StudentSubject where studentsubjectID=2

--drop table subjects
--drop table StudentSubject
--drop table StudentSubject
--drop table Login
Create Table Subjects (

SubjectID int identity primary key ,
SubjectName varchar(100) Not NULL,
SubjectCode varchar(10) Not Null,
SubjectType varchar(50) not null,
Credit int Not Null,

)


Create Table StudentSubject (
StudentSubjectID int identity primary Key,
SubjectID int not null,
StudentID char(8) not null
)


