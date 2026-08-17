CREATE TABLE [Disability]
(
	[Id]					INT IDENTITY(1,1)				NOT NULL,
	[StudentId]				INT								NOT NULL,
	[Description]			NVARCHAR(MAX)					NOT NULL,


	CONSTRAINT				[PK_Disability_Id]				PRIMARY KEY NONCLUSTERED		([Id]),
	CONSTRAINT				[FK_Disability_StudentId]		FOREIGN KEY ([StudentId]) REFERENCES [Student]([Id])

);
