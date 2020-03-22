https://medium.com/net-core/build-a-web-app-with-asp-net-core-and-mongodb-f9fcd61cb04f

mongo
use PatientDb
db.createCollection('Patients')
db.createCollection('Charts')

1) One Patient has many Charts ; join aggregation solution 찾아야,
db.createCollection('Ultrasounds')

https://www.codeproject.com/Articles/1368325/Test-Driving-MongoDB-with-NET-Core-2

Product -> Chart,
Order -> Patient,
OrderDetail ->PatientChart, 

A basic patient-chart application. The sample application will have the following requirements:

- Run patient searches against patient information by patient name.
- ? Return results of a patient search in paged data sets of a maximum 20 rows per page.
- ? Sort the patient results by various columns in either ascending or descending order.
- Create a chart with a unique sequentially generated order number.
- Generate a list of charts and perform a join to patient information for display purposes




https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1
search-box만드는법
