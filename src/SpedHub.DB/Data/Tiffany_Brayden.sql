
/*
	Service Type Codes
    ------------------
	1	-->		In-Class Support
	2	-->		Co-Teach
	3	-->		Modified


	Service Subject Codes
	---------------------
	1	-->		ELAR
	2	-->		MATH
	3	-->		Science
	4   -->		Social Studies

	Service Frequency Codes
	-----------------------
	D	-->     Daily
	W   -->		Weekly
	M   -->		Monthly
	Q   -->		Quarterly

*/

USE [SpedHubDb];
GO

EXEC [InsertStudent]	@Id=806970,
						@FirstName='Brayden',
						@LastName='Tiffany',
						@OtherName='Brayden',
						@Gender='M',
						@GradeLevel=8,
						@PrimaryDisabilityCode='07',
						@SecondaryDisabilityCode='08',
						@TertiaryDisabilityCode='00',
						@Oral_Expression = 0,
						@Listening_Comprehension = 0,
						@Written_Expression = 0,
						@Basic_Reading_Skills = 0,
						@Mathmatics_Calculation = 0,
						@Dyslexia = 0,
						@Reading_Fluency_Skills=1,
						@Reading_Comprehension=1,
						@Mathmatics_Problem_Solving=1;
GO

EXEC [InsertService] 		@StudentId=806970,
							@Type=3,
							@Subject=1,
							@Minutes=45,
							@Frequency='D',
							@StartDate='12/12/2025',
							@EndDate='12/11/2026';
GO

EXEC [InsertService] 		@StudentId=806970,
							@Type=3,
							@Subject=2,
							@Minutes=45,
							@Frequency='D',
							@StartDate='12/12/2025',
							@EndDate='12/11/2026';
GO

EXEC [InsertService] 		@StudentId=806970,
							@Type=1,
							@Subject=3,
							@Minutes=200,
							@Frequency='W',
							@StartDate='12/12/2025',
							@EndDate='12/11/2026';
GO

EXEC [InsertService] 		@StudentId=806970,
							@Type=1,
							@Subject=4,
							@Minutes=200,
							@Frequency='W',
							@StartDate='12/12/2025',
							@EndDate='12/11/2026';
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Clarification or rewording of vocabulary, complex sentences, and concepts',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Direct student attention to specific information (e.g., parts of a graphic, parts of an answer choice)',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Directions given in a variety of ways/simplified vocabulary',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Feedback provided frequently',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Limit instructions to one- or two-steps at a time',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Adapt Classroom Instruction',
						   @Description='Scaffold steps in a process (i.e., bullet each step, space out each step)',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Alter Assignments or Testing',
						   @Description='Test: Small-Group Administration',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Alter Assignments or Testing',
						   @Description='Extra time for completing assignments up to one class day',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO


EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Calculation Aids',
						   @Description='Basic Handheld Calculator (i.e., four function)',
						   @Elar=0,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=0
GO


EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Manage Behavior',
						   @Description='Access to a cool-down zone either by teacher direction or self selection for self-regulation, sensory breaks etc.',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Manage Behavior',
						   @Description='Clearly defined/consistent limits',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Manage Behavior',
						   @Description='Follow Behavior Intervention Plan',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Manage Behavior',
						   @Description='Reminders to stay on task',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Manage Behavior',
						   @Description='Private discussion about behavior',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO


EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Oral Administration',
						   @Description='Online Assignments: Access to text-to-speech (TTS)',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Oral Administration',
						   @Description='Online Test Administration: Access to Text-to-Speech (TTS)',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Oral Administration',
						   @Description='Paper Assignments: Read parts of the assignment at student request',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1
GO

EXEC [InsertAccommodation] @StudentId=806970,
						   @StartDate='12/12/2025',
						   @EndDate='12/11/2026',
						   @Category='Oral Administration',
						   @Description='Paper Test Administration: Read parts of test questions and answer choices at student request',
						   @Elar=1,
						   @Math=1,
						   @Science=1,
						   @SocialStudies=1

GO