﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Tripster.Data.Models
{
    public class Place
    {
        [BsonIgnoreIfDefault]
        [BsonElement("_id")]
        public string PlaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public string PlaceType { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
        public string Arrival { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
        public string Departure { get; set; }
    }
}
