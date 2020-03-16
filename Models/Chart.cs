using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;




namespace PatientMgt.Models
{
    public class Chart
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("PatientName")]
        [BsonRequired]
        public string PatientName { get; set; }

        [BsonElement("VisitDate")]
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }

        [BsonElement("DoctorName")]
        public string DoctorName { get; set; }

        [BsonElement("ChiefComplaint")]        
        public string ChiefComplaint { get; set; }

        [BsonElement("PresentIllness")]
        public string PresentIllness { get; set; }

        [BsonElement("PastHistory")]                
        public string PastHistory { get; set; }        

        [BsonElement("PhysicalExam")]
        public string PhysicalExam { get; set; } 

        [BsonElement("Medication")]
        public string Medication { get; set; } 

        [BsonElement("Impression")]
        public string Impression { get; set; }

        [BsonElement("DxPlan")]
        public string DxPlan { get; set; }          

        [BsonElement("TxPlan")]
        public string TxPlan { get; set; } 

        [BsonElement("UltrasoundExam")]
        public string UltrasoundExam { get; set; }      

    }
}