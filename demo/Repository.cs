using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Core;
using demo.Models;
using System.Threading.Tasks;

namespace demo {
    public interface IRepository {
         MongoClient client { get;}
         IMongoDatabase database { get; }
         Task<List<Skill>> getSkillsLike(string genre);
    }
    public class Repository :IRepository {

        protected MongoClient _client;
        protected IMongoDatabase _database;

        public Repository(string dbname) {
            this._client = new MongoClient("mongodb://localhost:27017");
            this._database = client.GetDatabase(dbname);
        }

         
        public MongoClient client {
            get {
                return this._client;
            }
        }

        public IMongoDatabase database {
            get {
                return this._database;
            }
        }


        public async Task<List<Skill>> getSkillsLike(string genre) {
            var filter = Builders<Skill>.Filter.Eq(x => x.genre, genre);
            return await this._database.GetCollection<Skill>("skills").Find(filter).ToListAsync();
        }
    }
}