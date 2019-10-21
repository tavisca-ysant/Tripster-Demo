﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Tripster.Data.Models
{
    public class Trip
    {
        [BsonIgnoreIfDefault]
        [BsonElement("_id")]
        [BsonId(IdGenerator = typeof(GuidGenerator))]
        public Guid Id { get; set; }
        public Stop Source { get; set; }
        public Stop Destination { get; set; }

        public List<Stop> Stops { get; set; }

        public int Mileage { get; set; }

        //hh:mm-PM
        //parsing logic - split 

        //date , time 
        
    }
}
