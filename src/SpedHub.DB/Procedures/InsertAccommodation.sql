CREATE PROCEDURE [InsertAccommodation]
	@StudentId INT,
	@StartDate DATE,
	@EndDate DATE,
	@Category NVARCHAR(MAX),
	@Description NVARCHAR(MAX),
	@Elar BIT = 1,
	@Math BIT = 1,
	@Science BIT = 1,
	@SocialStudies BIT = 1
AS

	BEGIN TRY
		INSERT INTO [Accommodation] (
			[StudentId],
			[StartDate],
			[EndDate],
			[Category],
			[Description],
			[Elar],
			[Math],
			[Science],
			[SocialStudies]
		) VALUES (
			@StudentId,
			@StartDate,
			@EndDate,
			@Category,
			@Description,
			@Elar,
			@Math,
			@Science,
			@SocialStudies
		);
		PRINT ('Entered accommodation [ ' + @Category + ', ' + @Description + ' ] for Student ' + CAST(@StudentId as NVARCHAR(MAX)) + ' successfully.');
	END TRY

	BEGIN CATCH
		PRINT('Error entering accommodation [ ' + @Category + ', ' + @Description + ' ] for Student' + CAST(@StudentId as NVARCHAR(MAX)) + '. ' + ERROR_MESSAGE());
	END CATCH


GO
