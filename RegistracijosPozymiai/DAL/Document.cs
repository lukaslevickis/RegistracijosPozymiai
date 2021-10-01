using System;
using MongoDB.Bson;

namespace RegistracijosPozymiai.DAL
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
