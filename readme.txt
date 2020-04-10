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

https://github.com/dncuug/X.PagedList
paged list 만드는법
https://www.aspsnippets.com/Articles/Paging-Pagination-example-in-ASPNet-MVC.aspx

https://stackoverflow.com/questions/46269453/safely-insert-or-update-subdocument-in-mongodb
subdocument insert 하는 법 $addToSet, $each 사용법

https://stackoverflow.com/questions/53232771/mongodb-c-sharp-driver-return-only-matching-sub-documents-in-array

https://youtu.be/94tWuLUL4iE 
Relationships between models in ASP.NET Core MVC

https://stackoverflow.com/questions/15117030/how-to-filter-array-in-subdocument-with-mongodb
subdocument 가져오는 법

https://stackoverflow.com/questions/51937439/passing-id-to-url-asp-net-mvc
url id passing 하는 법

https://stackoverflow.com/questions/37180296/pass-an-id-independent-from-model-mvc-c
id passing 하는 법
https://stackoverflow.com/questions/24673292/get-id-from-url-in-an-action-from-a-controller-with-asp-net?rq=1
how to get id from url
https://stackoverflow.com/questions/979532/how-to-get-the-current-route-id-within-a-view-from-the-url-asp-net-mvc

https://weblog.west-wind.com/posts/2019/May/15/Accessing-RouteData-in-an-ASPNET-Core-Controller-Constructor

