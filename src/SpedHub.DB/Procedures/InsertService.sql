CREATE PROCEDURE [InsertService]
	@StudentId INT,
	@Type INT,
	@Subject INT,
	@Minutes INT,
	@Frequency NVARCHAR(1),
	@StartDate DATE,
	@EndDate DATE
AS
	BEGIN TRY

		INSERT INTO [Service] (
			[StudentId],
			[Type],
			[Subject],
			[Minutes],
			[Frequency],
			[StartDate],
			[EndDate])
		VALUES (
			@StudentId,
			@Type,
			@Subject,
			@Minutes,
			@Frequency,
			@StartDate,
			@EndDate
		);

		PRINT('Service for ' + CAST( @StudentId AS NVARCHAR(MAX)) + ' entered successfully.');

	END TRY
	BEGIN CATCH
		
		PRINT('Error inserting service for ' + CAST( @StudentId AS NVARCHAR(MAX)) + ' with subject(' + CAST( @Subject AS NVARCHAR(MAX)) + ') minutes (' + CAST( @Minutes AS NVARCHAR(MAX)) + ') type(' + CAST( @Type AS NVARCHAR(MAX)) + '). ' + ERROR_MESSAGE());

	END CATCH

GO
