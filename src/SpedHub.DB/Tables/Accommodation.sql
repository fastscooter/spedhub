CREATE TABLE [Accommodation]
(
	[Id]					INT IDENTITY(1,1) NOT NULL,
	[StudentId]				INT NOT NULL,
	[StartDate]				DATE NULL,
	[EndDate]				DATE NULL,
	[Category]				NVARCHAR(MAX) NULL,
	[Description]			NVARCHAR(MAX) NOT NULL,
	[Elar]					BIT NOT NULL CONSTRAINT [DF_Accommodation_Elar] DEFAULT 1,
	[Math]					BIT NOT NULL CONSTRAINT [DF_Accommodation_Math] DEFAULT 1,
	[Science]				BIT NOT NULL CONSTRAINT [DF_Accommodation_Science] DEFAULT 1,
	[SocialStudies]			BIT NOT NULL CONSTRAINT [DF_Accommodation_SocialStudies] DEFAULT 1,
	CONSTRAINT				[PK_Accommodation_Id]			PRIMARY KEY NONCLUSTERED		([Id]),
	CONSTRAINT				[FK_Accommodation_StudentId]	FOREIGN KEY ([StudentId])		REFERENCES [Student]([Id])
);
