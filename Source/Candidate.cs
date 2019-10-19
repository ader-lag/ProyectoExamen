using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{

    [BsonIgnoreExtraElements]
    public class Candidate
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("imgPath")]
        public string ImgPath { get; set; }
        [BsonElement("chargeto")]
        public string ChargeTo { get; set; }
    }
}
