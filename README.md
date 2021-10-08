## Application purpose
This application will show user, list of Azure certifications with the different properties. User can get details for individual certificate as well as edit the record.

There is a button "Try JS Function" which will fire a custom js - a static file.

## Application Architecture
DemoWebsite solution contains two projects 

1. Demo.Micro : Built using ASP.NET Core Web API template (.net 5.0). It contains three HTTP methods. Two HttpGet methods and one HttpPut method.

2. Demo.Web : Built using ASP.NET Core MVC (.net 5.0) website template. This will call API using httpclient.


## How to build and test website on your local machine.
***Note:* This project is build on net 5.0 so make sure you have the required SDK, if not then [Download](https://www.microsoft.com/net/download) and install the required .NET Core SDK**

### Build the application
1. Open appsettings.json file in Demo.Micro project and update the ConnectionStrings by updating Server, Username and Password.

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Initial Catalog=CertificationDB;User ID=xxxxx;Password=xxxxx;"
  },
```

2. Run EF Migration : This migration will create a database name "CertificationDB" and a table "Certifications".

### In Visual Studio, select the Tools -> NuGet Package Manager -> Package Manager Console

Run the following commands in the Package Manager Console
   ```console   
   Update-Database
   ```

   or 

### Command line

Run the following commands in the command prompt:
```console   
   dotnet build    
    dotnet ef database update
   ```
    

3. Insert records to database table "Certifications". 
***Note:* Run InsertData.sql available on this path Demo.Micro\DatabaseScript**

4. Go to Visual Studio and clean the solution first, and build it again.
5. Right click on the solution proprty and go to startup project and set multiple startup projects. Make sure both Demo.Micro and Demo.Web action are "start".
6. Run the appliaction.
7. This will open up two browsers one with API swagger page and one with the website.

### Test the application
When you run this application, first page you should be seeing with "List of certificates".

You can try clicking Edit, Details and try JS Function buttons.
