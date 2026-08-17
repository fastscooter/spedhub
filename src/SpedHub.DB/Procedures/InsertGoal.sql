
/*
========================================================================================================================



				Goal Status

				1 ----> Completed
				2 ----> In Progress
*/


CREATE PROCEDURE [InsertGoal]
	@StudentId INT,
	@StartDate DATE,
	@EndDate DATE,
	@Number INT,
	@Subject NVARCHAR(MAX),
	@IsAcademic BIT,
	@Timeframe NVARCHAR(MAX),
	@Conditions NVARCHAR(MAX),
	@Behavior NVARCHAR(MAX),
	@Measurement NVARCHAR(MAX),
	@Status INT
AS

	INSERT INTO [Goal](
	[StudentId],
	[StartDate],
	[EndDate],
	[Number],
	[Subject],
	[IsAcademic],
	[Timeframe],
	[Conditions],
	[Behavior],
	[Measurement],
	[Status]
	)
	VALUES (
	@StudentId,
	@StartDate,
	@EndDate,
	@Number,
	@Subject,
	@IsAcademic,
	@Timeframe,
	@Conditions,
	@Behavior,
	@Measurement,
	@Status);

GO
