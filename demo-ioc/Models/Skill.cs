using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo_ioc.Models {
   public class Skill {
       public BsonObjectId _id{ get; set; }
       public string genre { get; set; }
       public string group { get; set; }
       public string title { get; set; }
       public string url { get; set; }
   }
}
