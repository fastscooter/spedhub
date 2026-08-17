CREATE TABLE [Service]
(
	[Id]								INT IDENTITY(1,1)								NOT NULL,
	[StudentId]							INT												NOT NULL,
	[Type]								INT												NOT NULL,
	[Subject]							INT												NOT NULL,
	[Minutes]							INT												NOT NULL,
	[Frequency]							NVARCHAR(1)										NOT NULL,
	[StartDate]							DATE,
	[EndDate]							DATE,


	CONSTRAINT							[PK_Service_Id]									PRIMARY KEY NONCLUSTERED					([Id]),
	CONSTRAINT							[FK_Service_StudentId]							FOREIGN KEY ([StudentId])					REFERENCES [Student]([Id]),
);
