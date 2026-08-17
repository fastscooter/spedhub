CREATE PROCEDURE [InsertStudent]
	@Id								INT,
	@FirstName						NVARCHAR(MAX),
	@LastName						NVARCHAR(MAX),
	@DateOfBirth					DATE			=						NULL,
	@Gender							NVARCHAR(1),
	@GradeLevel						INT,
	@PrimaryDisability				NVARCHAR(MAX),
	@PrimaryDisabilityAreas			NVARCHAR(MAX)			= 						NULL,
	@SecondaryDisability			NVARCHAR(MAX)			=						NULL,
	@SecondaryDisabilityAreas		NVARCHAR(MAX)			=						NULL
AS

BEGIN TRY
	DECLARE @FullName NVARCHAR(MAX);
	SET @FullName = CONCAT(@FirstName, ' ', @LastName);
	INSERT INTO [Student] (
					[Id],
					[FirstName],
					[LastName],
					[DateOfBirth],
					[Gender],
					[GradeLevel]
				) VALUES (
					@Id,
					@FirstName,
					@LastName,
					@DateOfBirth,
					@Gender,
					@GradeLevel
				);
	PRINT('Student ''' + @FullName + ''' entered successfully.');
END TRY
BEGIN CATCH
	PRINT('Error entereing Student ''' + @FullName + '''. ' + ERROR_MESSAGE())
END CATCH


INSERT INTO [Disability] (
				[StudentId],
				[Description]
			) VALUES (
				@Id,
				@PrimaryDisability
			);



IF @PrimaryDisabilityAreas IS NOT NULL
BEGIN TRY
INSERT INTO [Area] (
				[DisabilityId],
				[Description]
			) SELECT
				D.Id,
				value
			FROM [Disability] D
			CROSS APPLY STRING_SPLIT(@PrimaryDisabilityAreas, ',')
			WHERE D.Description= @PrimaryDisability AND D.StudentId = @Id ;
END TRY
BEGIN CATCH
END CATCH
IF @SecondaryDisability IS NOT NULL
BEGIN
	INSERT INTO [Disability] (
				[StudentId],
				[Description]
			) VALUES (
				@Id,
				@SecondaryDisability
			);

END

IF @SecondaryDisabilityAreas IS NOT NULL
BEGIN
	DECLARE @SecondaryDisabilityId INT = (SELECT TOP 1 Id FROM [Disability] WHERE StudentId = @Id AND Description = @SecondaryDisability)

	INSERT INTO [Area] (
				[DisabilityId],
				[Description]
			) SELECT
				D.Id,
				value
			FROM [Disability] D
			CROSS APPLY STRING_SPLIT(@SecondaryDisabilityAreas, ',')
			WHERE D.Description= @SecondaryDisability AND D.StudentId = @Id;
END


GO


