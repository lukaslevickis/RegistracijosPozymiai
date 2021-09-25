using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using RegistracijosPozymiai.DTO.Repositories;

namespace RegistracijosPozymiai.DTO
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : IDocument
    {
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IMongoDbSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TDocument>(typeof(TDocument).Name);
        }

        public List<TDocument> Get()
        {
            var aa = _collection.Find(new BsonDocument()).ToList();
            return aa;
        }
    }
}
