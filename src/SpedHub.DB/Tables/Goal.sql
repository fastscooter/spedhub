CREATE TABLE [Goal]
(
	[Id]					INT IDENTITY(1,1)			NOT NULL,
	[StudentId]				INT							NOT NULL,
	[Number]				DECIMAL(2,1)				NOT NULL,
	[StartDate]				DATE						NULL,
	[EndDate]				DATE						NULL,
	[Subject]				NVARCHAR(MAX)				NULL,
	[IsAcademic]			BIT							NULL,
	[Timeframe]				NVARCHAR(MAX)				NULL,
	[Conditions]			NVARCHAR(MAX)				NULL,
	[Behavior]				NVARCHAR(MAX)				NULL,
	[Measurement]			NVARCHAR(MAX)				NULL,
	[Status]				INT							NULL,

	CONSTRAINT				[PK_Goal_Id]				PRIMARY KEY NONCLUSTERED			([Id]),

	CONSTRAINT				[FK_Goal_StudentId]			FOREIGN KEY ([StudentId])			REFERENCES [Student]([Id])
);
