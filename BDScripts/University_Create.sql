USE master
GO

DROP DATABASE IF EXISTS University;
CREATE DATABASE University;
GO

USE University
GO

CREATE TABLE dbo.COURSES
(
	COURSE_ID int IDENTITY(0,1) NOT NULL,
	[NAME] nvarchar(50) NOT NULL,
	[DESCRIPTION] nvarchar(50) NULL,
	CONSTRAINT PK_COURSES_COURSE_ID PRIMARY KEY(COURSE_ID),
	CONSTRAINT UQ_COURSES_NAME UNIQUE([NAME]),
	CONSTRAINT CK_COURSES_NAME CHECK([NAME] != '')
) 
GO

CREATE TABLE dbo.GROUPS
(
	GROUP_ID int NOT NULL,
	COURSE_ID int NOT NULL,
	[NAME] nvarchar(50) NOT NULL,
	CONSTRAINT PK_GROUPS_GROUP_ID PRIMARY KEY(GROUP_ID),
	CONSTRAINT FK_GROUPS_TO_COURSES FOREIGN KEY (COURSE_ID)  REFERENCES COURSES (COURSE_ID) ON DELETE CASCADE,
	CONSTRAINT UQ_GROUPS_COURSE_ID UNIQUE(COURSE_ID),
	CONSTRAINT UQ_GROUPS_NAME UNIQUE([NAME]),
	CONSTRAINT CK_GROUPS_NAME CHECK([NAME] != '')
)
GO

CREATE TABLE dbo.STUDENTS
(
	STUDENT_ID int NOT NULL,
	GROUP_ID int NOT NULL,
	FIRST_NAME nvarchar(50) NOT NULL,
	LAST_NAME nvarchar(50) NOT NULL,
	CONSTRAINT PK_STUDENTS_STUDENT_ID PRIMARY KEY(STUDENT_ID),
	CONSTRAINT FK_STUDENTS_TO_GROUPS FOREIGN KEY (GROUP_ID)  REFERENCES GROUPS (GROUP_ID) ON DELETE CASCADE,
	CONSTRAINT UQ_STUDENTS_GROUP_ID UNIQUE(GROUP_ID),
	CONSTRAINT CK_STUDENTS_LAST_NAME_AND_FIRST_NAME CHECK(FIRST_NAME != '' AND LAST_NAME != '')
)
GO

USE master
GO