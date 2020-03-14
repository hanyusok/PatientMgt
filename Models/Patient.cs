using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
// using Microsoft.AspNetCore.Razor.TagHelpers;
// using MongoDB.Driver;



namespace PatientMgt.Models
{
    public class Patient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [BsonRequired]
        public string Name { get; set; }

        [BsonElement("DOB")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }

        [BsonElement("Phone")]
        [Phone]
        public string Phone { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("Email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }        

        [BsonElement("Bill")]
        public string Bill { get; set; } 

        [BsonElement("Notice")]
        public string Notice { get; set; } 

        [BsonElement("Message")]
        public string Message { get; set; }

        [BsonElement("Doctor")]
        public string Doctor { get; set; }          

        [BsonElement("Procedure")]
        public string Procedure { get; set; } 

        [BsonElement("Examination")]
        public string Examination { get; set; } 

        [BsonElement("Diagnosis")]
        public string Diagnosis { get; set; }                    

        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }        
         

        [BsonElement("Cost")]
        [Display(Name = "Cost($)")]
        [DisplayFormat(DataFormatString = "{0:#,0}")]
        public decimal Cost { get; set; } 

        //One patient to Many charts
        [BsonElement("Charts")]
        public Chart Charts { get; set; } 
        
    }
}