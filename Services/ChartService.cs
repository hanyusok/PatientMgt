using MongoDB.Driver;
using MongoDB.Bson;
using PatientMgt.Models;
using PatientMgt.Services;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace PatientMgt.Services
{
    public class ChartService 
    {
        // private readonly IMongoCollection<Patient.Chart> charts;
        private readonly IMongoCollection<Patient> patients;    
        private readonly IMongoCollection<Patient.Chart> charts;    
        
        public ChartService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PatientDb"));
            IMongoDatabase db = client.GetDatabase("PatientDb");            
            patients = db.GetCollection<Patient>("Patients"); 
            charts = db.GetCollection<Patient.Chart>("Charts");                                             
        }

        public IEnumerable<Patient.Chart> Get(string id)
        {            
            var pt = patients.Find(p => p.Id == id ).FirstOrDefault();
            var ptchts = pt.Charts;
            return ptchts;
            // return charts.Find(c => true).ToList();
        }
      

        public List<Patient.Chart> Inquiry(string ptName)
        {
            FilterDefinition<Patient.Chart> filter = Builders<Patient.Chart>.Filter.Empty;
            ptName = ptName.Trim();
            
            if (ptName.Length > 0)
            {
                filter = filter & Builders<Patient.Chart>.Filter.Regex(c => c.PatientName,
                            new BsonRegularExpression(string.Format("{0}", ptName), "i"));            
            }

            var filteredcharts = charts.Find(filter).Project(c => new {
                c.Id,   c.PatientName,  c.VisitDate,    c.DoctorName,   c.ChiefComplaint,
                c.PresentIllness,       c.PastHistory,  c.PhysicalExam, c.Medication,
                c.Impression,           c.DxPlan,       c.TxPlan,       c.UltrasoundExam
            }).ToList();

            List<Patient.Chart> pcharts = new List<Patient.Chart>();
            foreach (var item in filteredcharts)
            {
                Patient.Chart c = new Patient.Chart();
                c.Id = item.Id;
                c.PatientName = item.PatientName;
                c.VisitDate = item.VisitDate;
                c.DoctorName = item.DoctorName;
                c.ChiefComplaint = item.ChiefComplaint;
                c.PresentIllness = item.PresentIllness;
                c.PastHistory = item.PastHistory;
                c.PhysicalExam = item.PhysicalExam;
                c.Medication = item.Medication;
                c.Impression = item.Impression;
                c.DxPlan = item.DxPlan;
                c.TxPlan = item.TxPlan;
                c.UltrasoundExam = item.UltrasoundExam;
                pcharts.Add(c);
            }
            return pcharts;            
        }

          public Patient.Chart Create(string id, Patient.Chart chart)
        {            
            var fltr = Builders<Patient>.Filter.Eq(p =>p.Id, id);
            var upd = Builders<Patient>.Update.AddToSet(p => p.Charts, chart);                
            patients.UpdateOne(fltr, upd);
            return chart;
        }


        public void Update(string id, Patient.Chart next)
        {
            charts.ReplaceOne(c => c.Id == id, next);
        }

        public void Remove(Patient.Chart ct)
        {
            charts.DeleteOne(c => c.Id == ct.Id);
        }

        public void Remove(string id)
        {
            charts.DeleteOne(c => c.Id == id);
        }
    }
}