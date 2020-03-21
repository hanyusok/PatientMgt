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

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-3.1
search-box만드는법