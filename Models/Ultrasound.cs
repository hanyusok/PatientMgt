using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
// using Microsoft.AspNetCore.Razor.TagHelpers;
// using MongoDB.Driver;



namespace PatientMgt.Models
{
    public class Ultrasound
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("StudyArea")]
        [BsonRequired]
        public string StudyArea { get; set; }

        [BsonElement("StudyDate")]
        [DataType(DataType.Date)]
        public DateTime StudyDate { get; set; }

        [BsonElement("StudyDoctorName")]
        public string StudyDoctorName { get; set; }

        [BsonElement("StudyChiefComplaint")]        
        public string StudyChiefComplaint { get; set; }

        [BsonElement("StudyCode")]
        public string StudyCode { get; set; }

        [BsonElement("StudyPosition")]                
        public string StudyPosition { get; set; }        

        [BsonElement("FindingOne")]
        public string FindingOne { get; set; } 

        [BsonElement("FindingTwo")]
        public string FindingTwo { get; set; } 

        [BsonElement("FindingThree")]
        public string FindingThree { get; set; }

        [BsonElement("DxImpression")]
        public string DxImpression { get; set; }          

        [BsonElement("TxPlan")]
        public string TxPlan { get; set; } 

        [BsonElement("StudySummary")]
        public string StudySummary { get; set; }   

        [BsonElement("ImageOneUrl")]
        [Display(Name = "USCapture")]
        [DataType(DataType.ImageUrl)]
        public string ImageOneUrl { get; set; }   

        [BsonElement("ImageTwoUrl")]
        [Display(Name = "USCapture")]
        [DataType(DataType.ImageUrl)]
        public string ImageTwoUrl { get; set; }  

        [BsonElement("ImageThreeUrl")]
        [Display(Name = "USCapture")]
        [DataType(DataType.ImageUrl)]
        public string ImageThreeUrl { get; set; }  
    }
}