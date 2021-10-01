using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RegistracijosPozymiai.DAL.Collections
{
    public class Option: Document
    {
    //    [BsonId]
    //    [BsonRepresentation(BsonType.ObjectId)]
    //    public string Id { get; set; }
        public string Name { get; set; }
    }
}
