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
        // private readonly IMongoCollection<Chart> charts;

        // private readonly Builders<PatientChart> patientchart;
        
        public PatientService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PatientDb"));
            IMongoDatabase db = client.GetDatabase("PatientDb");
            patients = db.GetCollection<Patient>("Patients");
            // charts = db.GetCollection<Chart>("Charts");              
        }

        public List<Patient> Inquiry(string pname)
        {
            FilterDefinition<Patient> filter = Builders<Patient>.Filter.Empty;
            pname = pname.Trim();
            
            if (pname.Length > 0)
            {
                filter = filter & Builders<Patient>.Filter.Regex(p => p.Name,
                            new BsonRegularExpression(string.Format("{0}", pname), "i"));            
            }

            var filteredpatients = patients.Find(filter).Project(p => new {
                p.Id,   p.Name,  p.DOB,    p.Address,   p.Phone,  p.Status,   
                p.Email,  p.Bill,      p.Notice,    p.Message,  p.Doctor,  
                p.Procedure,  p.Examination, p.Diagnosis, p.ImageUrl
            }).ToList();

            List<Patient> pts = new List<Patient>();
            foreach (var item in filteredpatients)
            {
                Patient p = new Patient();
                p.Id = item.Id;  p.Name = item.Name;    p.DOB = item.DOB;
                p.Address = item.Address;   p.Phone = item.Phone;   p.Status = item.Status;
                p.Email = item.Email;       p.Bill = item.Bill;     p.Notice = item.Notice;
                p.Message = item.Message;   p.Doctor = item.Doctor; p.Procedure = item.Procedure;
                p.Examination = item.Examination;   p.Diagnosis = item.Diagnosis;
                p.ImageUrl = item.ImageUrl;
                pts.Add(p);
            }
            return pts;       
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
            patients.InsertOne(p);
            return p;
        }

        public void Update(string id, Patient up)
        {
            patients.ReplaceOne(p => p.Id == id, up);
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