# EDU-ASP.NET-Core-Authentication
Project devoted for the most essential functionality regarding authentication mechanism in ASP.NET Core framework

## Prequisites
- [.NET Core 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0)

- [Postgres](https://www.postgresql.org/)

- [Entity Framework Core Tools for the .NET Command-Line Interface](https://www.nuget.org/packages/dotnet-ef/)
     >dotnet tool install --global dotnet-ef --version 3.0.0-preview8.19405.11

## Installation

1) Clone repository via command:
     >git clone https://github.com/Mikhail-Vilms/EDU-ASP.NET-Core-Authentication.git

2) Execute command from repository root folder:
     >dotnet build

3) Execute command from repository root folder:
     >dotnet ef migrations add InitialCreate

4) Assign appropriate value for database connection string in "appsettings.json" file

5) Execute command from repository root folder:
   >dotnet ef database update InitialCreate

6) Verify that database with next tables has been created: 
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
- Check "AspNetUsers" table in database: new record has to be added