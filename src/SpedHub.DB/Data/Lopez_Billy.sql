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

EXEC [InsertStudent]		@Id = 736123,
							@FirstName='Billy',
							@LastName='Lopez',
							@OtherName='Billy',
							@Gender='M',
							@GradeLevel=8,
							@PrimaryDisabilityCode='08',
							@SecondaryDisabilityCode='00',
							@TertiaryDisabilityCode='00',
							@Oral_Expression = 0,
							@Listening_Comprehension = 0,
							@Written_Expression = 1,
							@Basic_Reading_Skills = 1,
							@Mathmatics_Calculation = 1,
							@Dyslexia = 0,
							@Reading_Fluency_Skills=0,
							@Reading_Comprehension=0,
							@Mathmatics_Problem_Solving=0;

GO

EXEC [InsertService] 		@StudentId=736123,
							@Type=3,
							@Subject=1,
							@Minutes=225,
							@Frequency='W',
							@StartDate='12/02/2025',
							@EndDate='12/01/2026';

GO


EXEC [InsertService] 		@StudentId=736123,
							@Type=3,
							@Subject=2,
							@Minutes=225,
							@Frequency='W',
							@StartDate='12/02/2025',
							@EndDate='12/01/2026';
GO

EXEC [InsertService] 		@StudentId=736123,
							@Type=1,
							@Subject=3,
							@Minutes=200,
							@Frequency='W',
							@StartDate='12/02/2025',
							@EndDate='12/01/2026';
GO

EXEC [InsertService] 		@StudentId=736123,
							@Type=1,
							@Subject=4,
							@Minutes=225,
							@Frequency='W',
							@StartDate='12/02/2025',
							@EndDate='12/01/2026';

GO
