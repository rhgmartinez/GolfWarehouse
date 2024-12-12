# GolfWarehouse

Here are the things I did to make this Project.

I. Install the Visual Studio and SQL Server Express
II. Created a web project following the necessary requirement of the project for .NET Core Web API
Reference: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio

    a. Added the following to NuGet Package:
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.InMemory

    b. Started creating the Models to represent the database tables. 
        b.1. Open table description to know the datatype of each field.
        b.2. Evaluate field names for better identification of their purpose and for Naming Structure. 
        b.3. Tried using Database table conversion to C# models tools but some fields are unidentified so i had to manually update most of the fields. 

    c. List of Tables completed: 
        - AR_CUST – Customers
        - AR_SHIP_ADRS – Customers shipping address
        - IM_ITEM – Item/Products
        - IM_BARCOD – Item barcodes
        - IM_LOC – Item stocking locations
        - IM_INV – Item stocking location values
        - IM_INV_CELL – Item stocking locations grid dimension values
        - IM_SER – Item serial numbers
        - IM_CATEG_COD – Item category
        - IM_SUBCATEG_COD – Item subcategory
        - PS_DOC_HDR – Point of sale header
        - PS_DOC_LIN – Point of sale line items
        - PS_DOC_PMT – Point of sale payments
    
    d. Added a database context in the project named GolfWarehouseContext
        d.1. Added the DbSets based on the Models created
        d.1. For more DBSets, add it following the alphabetical order to easily locate items. 

    e. Register the database context
        e.1. Update Program.cs and add DBContext
        e.2. Add the necessary directives like Models and Microsoft.EntityFrameworkCore

    f. Created a controller named POSController
        f.1. Create a POS Transaction

    g. Add the database connection string to the appsettings.json file
        g.1. Copy the connection string from SQL Server Express
            ex. Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

    h. Adjusted codes and added error handling and checker. 

    i. Found useful packages and added in NuGet
        API Rate Limiting - dotnet add package AspNetCoreRateLimit
        API Logging - dotnet add package Serilog
        
