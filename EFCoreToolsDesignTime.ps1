

$ConnectionString = "Server=.;Database=SpedHub.DB;Trusted_Connection=True;TrustServerCertificate=True"

# The target project. If this parameter is omitted, the Default project for Package Manager Console is used as the target project.
$Project = "SpedHub.Domain"

# The startup project. If this parameter is omitted, the Startup project in Solution properties is used as the target project.
$StartupProject = "SpedHub.API"

# The directory to put the DbContext file in. Paths are relative to the project directory.
$ContextDir = "D:\code\github\spedhub\src\SpedHub.Data\"

# The name of the output folder in the Project where the generated files are placed
$OutputDir = "D:\code\github\spedhub\src\SpedHub.Domain\Entities\"

# The provider to use. Typically this is the name of the NuGet package, for example: Microsoft.EntityFrameworkCore.SqlServer. This is a positional parameter and is required.
$Provider = "Microsoft.EntityFrameworkCore.SqlServer"

# The name of the DbContext class to generate.
$Context = "SpedHubDbContext"

$Namespace = "SpedHub.Domain.Entities"

$ContextNamespace = "SpedHub.Data"






Import-Module "C:\Users\bmars\.nuget\packages\microsoft.entityframeworkcore.tools\11.0.0-preview.7.26366.102\tools\EntityFrameworkCore.psm1" -Verbose


Function Generate-DbContext
{

	Scaffold-DbContext	-Connection $ConnectionString `
						-Provider $Provider `
						-Project $Project `
						-StartupProject $StartupProject `
						-OutputDir $OutputDir `
						-ContextDir $ContextDir `
						-Context $Context `
						-Namespace $Namespace `
						-ContextNamespace $ContextNamespace `
						-Force


}


Generate-DbContext