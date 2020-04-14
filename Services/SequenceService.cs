using PatientMgt.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace PatientMgt.Services
{
    public class SequenceService
    {
        private readonly IMongoCollection<Sequence> counters;

        public SequenceService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("PatientDb"));
            IMongoDatabase db = client.GetDatabase("PatientDb");
            counters = db.GetCollection<Sequence>("Counters");     
        } 

        public Sequence Insert(Sequence s)
        {
            counters.InsertOne(s);
            return s;
        }
        internal long GetNextSeq(string seqName)
        {            
            var flr = Builders<Sequence>.Filter.Eq(a => a.Name, seqName);
            var upd = Builders<Sequence>.Update.Inc(a => a.Value, 1);
            var seq = counters.FindOneAndUpdate(flr, upd);
            return seq.Value;
        }

    
    }
}