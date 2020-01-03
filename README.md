# EDU-ASP.NET-Core-Authentication
Project devoted for the most essential functionality regarding authentication mechanism in ASP.NET Core framework

## Prequisites
- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)
- [Postgres](https://www.postgresql.org/)

## Installation
- Clone repository via command: "git clone https://github.com/Mikhail-Vilms/EDU-ASP.NET-Core-Authentication.git"
- Execute command from repository root folder: "dotnet restore"
- Execute command from repository root folder: "dotnet Add-Migration "InitialCreate""
- Assign appropriate value for database connection string in "appsettings.json" file
- Execute command from repository root folder: "dotnet Update-Database"
- Verify that database with next tables were created: 
  - AspNetUsers
  - AspNetRoles
  - AspNetUserRoles
  - AspNetUserClaims
  - AspNetRoleClaims
  - AspUserLogins
  - AspNetUserTokens
  - {Table related to migration history}

## Testing
- Launch application via command executed from repository root folder: "dotnet run"
- Create new user's record by executing POST request with next parameters:
```json
{
	"UserName": "Mikhail_Vilms",
	"Email": "mikhail.vilms@mymail.com",
	"Password": "S0mePaa$$w0rd"
}
```
- Check "AspNetUsers" in database: new record has to be added