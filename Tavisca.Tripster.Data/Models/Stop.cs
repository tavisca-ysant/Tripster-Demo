using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Tripster.Data.Models
{
    public class Stop
    {
        [BsonIgnoreIfDefault]
        [BsonElement("_id")]
        public string StopId { get; set; }
        public string name { get; set; }
        public Location Location { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
        public string Arrival { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
        public string Departure { get; set; }

        public List<Place> Places { get; set; }
    }
}
