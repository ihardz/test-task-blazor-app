# Test Task for Developer

## Deployed instance (will be actual for about 1 month): 
http://ihardz.somee.com/

## Run on local

* Make sure you have dotnet 8.* installed and VS 2022 (any edition)
* Create a database (Ms Sql Server )
* Replace connection string in appsettings.json (./BlazorApp.Server/appsettings.json) with actual one
* In VisualStudio open Package Manager Console and run the following command (to apply EF Core migrations): 
  ```Update-Database```

## Task Description

Create a web app, for managing sales order data.

## Requirements

1. Create new database tables Using Code First In Entity Framework.
2. Blazor WebAssembly app with an interface to show data from DB.
3. Make an ability to change and save data in the application: state, name, and dimensions.
4. Add the ability to create and delete orders, windows and elements.
5. Optional: Interface validations. DTO. Separated BLL and DAL projects.

Provide source code with all necessary information to run and test the application.

## Test data for storing into the database:

```
<Orders>
  <Order Name="New York Building 1" State="NY">
    <Windows>
      <Window Name="A51" QuantityOfWindows="4" TotalSubElements="3">
        <SubElements>
          <SubElement Element="1" Type="Doors" Width="1200" Height="1850" />
          <SubElement Element="2" Type="Window" Width="800" Height="1850" />
          <SubElement Element="3" Type="Window" Width="700" Height="1850" />
        </SubElements>
      </Window>
      <Window Name="C Zone 5" QuantityOfWindows="2" TotalSubElements="1">
        <SubElements>
          <SubElement Element="1" Type="Window" Width="1500" Height="2000" />
        </SubElements>
      </Window>
    </Windows>
  </Order>
  <Order Name="California Hotel AJK" State="CA">
    <Windows>
      <Window Name="GLB" QuantityOfWindows="3" TotalSubElements="2">
        <SubElements>
          <SubElement Element="1" Type="Doors" Width="1400" Height="2200" />
          <SubElement Element="2" Type="Window" Width="600" Height="2200" />
        </SubElements>
      </Window>
      <Window Name="OHF" QuantityOfWindows="10" TotalSubElements="2">
        <SubElements>
          <SubElement Element="1" Type="Window" Width="1500" Height="2000" />
          <SubElement Element="1" Type="Window" Width="1500" Height="2000" />
        </SubElements>
      </Window>
    </Windows>
  </Order>
</Orders>
```
