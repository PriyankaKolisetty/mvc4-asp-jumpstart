using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization.Attributes;

namespace demo.Models {
    [BsonIgnoreExtraElements]
    public class Skill {
        public BsonObjectId _id { get; set; }
        public string title { get; set; }
        public string group { get; set; }
        public string genre { get; set; }
    }
}