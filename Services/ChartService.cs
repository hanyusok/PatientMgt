using MongoDB.Driver;
using PatientMgt.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace PatientMgt.Services
{
    public class ChartService
    {
        private readonly IMongoCollection<Chart> charts;

        public ChartService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PatientDb"));
            IMongoDatabase db = client.GetDatabase("PatientDb");
            charts = db.GetCollection<Chart>("Charts");                         
            
            // patients = db.GetCollection<Patient>("Patients");
                

            
        }

        public List<Chart> Get()
        {
            return charts.Find(c => true).ToList();
        }

        public Chart Get(string id)
        {
            return charts.Find(c => c.Id == id).FirstOrDefault();
        }

        public Chart Create(Chart c)
        {
            charts.InsertOne(c);
            return c;
        }

        public void Update(string id, Chart next)
        {
            charts.ReplaceOne(c => c.Id == id, next);
        }

        public void Remove(Chart ct)
        {
            charts.DeleteOne(c => c.Id == ct.Id);
        }

        public void Remove(string id)
        {
            charts.DeleteOne(c => c.Id == id);
        }
    }
}