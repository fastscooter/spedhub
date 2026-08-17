CREATE TABLE [Student]
(
	[Id]					INT 						NOT NULL,
	[FirstName]				NVARCHAR(max)				NOT NULL,
	[LastName]				NVARCHAR(max)				NOT NULL,
	[DateOfBirth]			DATE						NULL,
	[Gender]				NVARCHAR(1)					NULL,
	[GradeLevel]			INT							NOT NULL,

	CONSTRAINT				[PK_Student_Id]				PRIMARY KEY NONCLUSTERED			([Id]),


);
