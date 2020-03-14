using MongoDB.Driver;
using MongoDB.Bson;
using PatientMgt.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace PatientMgt.Services
{
    public class PatientService
    {
        private readonly IMongoCollection<Patient> patients;
        
        public PatientService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PatientDb"));
            IMongoDatabase db = client.GetDatabase("PatientDb");
            patients = db.GetCollection<Patient>("Patients");  
        }

        
        public void startchart(Patient p) //Insert subdocument(Charts objectId) into Patient
        {
            Chart ct = new Chart();
            ct.Id = ObjectId.GenerateNewId().ToString();
            ct.PatientName = p.Name;
            p.Charts = ct;       
        }

        public List<Patient> Get()
        {
            return patients.Find(p => true).ToList();
        }

        public Patient Get(string id)
        {
            return patients.Find(p => p.Id == id).FirstOrDefault();
        }


        public Patient Create(Patient p)
        {            
            startchart(p);
            patients.InsertOne(p);
            return p;
        }

        public void Update(string id, Patient nextp)
        {
            patients.ReplaceOne(p => p.Id == id, nextp);
        }

        public void Remove(Patient pt)
        {
            patients.DeleteOne(p => p.Id == pt.Id);
        }

        public void Remove(string id)
        {
            patients.DeleteOne(p => p.Id == id);
        }
    }
}