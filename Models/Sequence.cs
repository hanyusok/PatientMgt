using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PatientMgt.Models
{
    public class Sequence
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public long Value { get; set; }
    }
}

// ## Reference ##
// https://stackoverflow.com/questions/50394800/how-to-use-auto-increment-field-in-mongo-c-sharp-driver-without-using-eval
