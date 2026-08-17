CREATE TABLE [dbo].[Area]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[DisabilityId] INT NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,


	CONSTRAINT [PK_Area_Id] PRIMARY KEY NONCLUSTERED ([Id]),
	CONSTRAINT [FK_Area_DisabilityId] FOREIGN KEY ([DisabilityId]) REFERENCES [Disability]([Id])
);
