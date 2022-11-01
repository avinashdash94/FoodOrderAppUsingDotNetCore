# FoodOrderAppUsingDotNetCore
This is a basic Food order project using DotNet Core
Dependencies:
Microsoft.EntityFrameworkCore(5.0.17)
Microsoft.EntityFrameworkCore.SqlServer(5.0.17)
Microsoft.EntityFrameworkCore.Design(5.0.17)


****Entity Frame Work few Commands to use***
Run the folloing command on Developer PowerShell(Tool -> Command Line -> Developer PowerShell):
Entity Framework few comand to get Db info:
 dotnet ef dbcontext list
 dotnet ef dbcontext info 
 
Use this : Goto Directory OdeToFood.Data and run the following command to get the Data base details 
  dotnet ef dbcontext info -s ..\OdeToFood\OdeToFood.csproj

When  we made any change in C# schima or model to reflet that change in Db we need to run migration command as bellow:
  dotnet ef migrations add initialcreate -s ..\OdeToFood\OdeToFood.csproj
