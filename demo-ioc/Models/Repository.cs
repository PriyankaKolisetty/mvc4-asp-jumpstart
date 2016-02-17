using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading.Tasks;

namespace demo_ioc.Models {
    public class Repository {
        public MongoClient Client{ get; set; }
        public IMongoDatabase Database { get; set; }

        public Repository() {
            this.Client = new MongoClient("mongodb://localhost:27017");
            this.Database = this.Client.GetDatabase("skillmaze");
        }
        public async Task<IEnumerable<Skill>> getSkills(string genre) {
            var filter = Builders<Skill>.Filter.Eq(x => x.genre, genre);
            return await this.Database.GetCollection<Skill>("skills").Find(filter).ToListAsync();
        }
    }
}