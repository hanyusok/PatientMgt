https://medium.com/net-core/build-a-web-app-with-asp-net-core-and-mongodb-f9fcd61cb04f

mongo
use PatientDb
db.createCollection('Patients')
db.createCollection('Charts')

One Patient has many Charts ; join aggregation solution 찾아야,


db.createCollection('Ultrasounds')

