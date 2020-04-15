using MongoDB.Driver;
using MongoDB.Bson;
using PatientMgt.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace PatientMgt.Services
{
    public class ChartService 
    {        
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
            return pt.Charts.AsEnumerable();            
        }

        public Patient.Chart Get(string id, int cid)
        {
            var pt = patients.Find(p => p.Id == id).FirstOrDefault();
            var chts = pt.Charts.ToArray();
            var ct = new Patient.Chart();
            foreach (var c in chts.AsEnumerable())
            {
                if ( c.Cn == cid)
                {
                    ct = c;                    
                }           
            }       

            // ct = chts[cid];
            // cid 0에 고정???
            return ct;   
                                  
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


        // public void Update(string id, Patient.Chart next)
        // {
        //     charts.ReplaceOne(c => c.Id == id, next);
        // }
        public void Update(string id, int cid, Patient.Chart up)
        {         
            var flt = Builders<Patient.Chart>.Filter.Where(c => c.Cn == cid);                      
            var upd = Builders<Patient.Chart>.Update
                        .Set(c => c.Cn, up.Cn)
                        .Set(c => c.PatientName, up.PatientName)
                        .Set(c => c.VisitDate, up.VisitDate)
                        .Set(c => c.DoctorName, up.DoctorName)
                        .Set(c => c.ChiefComplaint, up.ChiefComplaint)
                        .Set(c => c.PresentIllness, up.PresentIllness)
                        .Set(c => c.PastHistory, up.PastHistory)
                        .Set(c => c.PhysicalExam, up.PhysicalExam)
                        .Set(c => c.Medication, up.Medication)
                        .Set(c => c.Impression, up.Impression)
                        .Set(c => c.DxPlan, up.DxPlan)
                        .Set(c => c.TxPlan, up.TxPlan)
                        .Set(c => c.UltrasoundExam, up.UltrasoundExam);                        
            charts.FindOneAndUpdate(flt, upd);
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