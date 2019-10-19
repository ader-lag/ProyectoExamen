using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    [BsonIgnoreExtraElements]
    public class Party
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("nameparty")]
        public string NameParty { get; set; }
        [BsonElement("voteinfavor")]
        public int VoteInFavor { get; set; }
        [BsonElement("candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}
