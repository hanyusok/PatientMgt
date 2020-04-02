using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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

        public IEnumerable<Chart> Charting(string id)
        {   
            if (id == null)
            {
                return 
            }
            var pid = ObjectId.Parse(id);      
            Patient p = patients.Find(p => p.Id == id).FirstOrDefault();
            // var filter = new BsonDocument(); 
            if (p.Charts == null)
            {

            } else 
            {
                p.Charts = Builders<Patient>.Filter.Where(pt => pt.Charts, "Charts");
            }
            var chts = p.Charts.ToList();
            // Chart cht = new Chart();
            // var chts = patients.Distinct<Chart>("Charts", filter).ToList();            
            
            foreach(Chart item in chts)
            {
                Chart ct = new Chart();
                // ct.Id = ObjectId.GenerateNewId.ToString();
                ct.PatientName = item.PatientName;
                ct.VisitDate = item.VisitDate;
                ct.DoctorName = item.DoctorName;
                ct.ChiefComplaint = item.ChiefComplaint;
                ct.PresentIllness = item.PresentIllness;
                ct.PastHistory = item.PastHistory;
                ct.PhysicalExam = item.PhysicalExam;
                ct.Medication = item.Medication;
                ct.Impression = item.Impression;
                ct.DxPlan = item.DxPlan;
                ct.TxPlan = item.TxPlan;
                ct.UltrasoundExam = item.UltrasoundExam;
                chts.Append(ct);                
            }
            return chts;
            
        }

        // public Patient AddChart(string id, Patient p)
        // {   
            // var chtid = ObjectId.Parse(id);
            // var builder = Builders<Patient>.Filter.AnyEq(p => p.Charts, "Charts");
            // var upd = Builders<Patient>.Update.AddToSet(c => c.Charts, new Chart(){
            //     Id = ObjectId.GenerateNewId().ToString(),             

            // });
            
            // var result = patients.UpdateOne<Patient>(builder, upd);
            // return result;               
        
        // }

    }
}