using System;
using System.Collections.Generic;

namespace RegistracijosPozymiai.DAL.Repositories
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        List<TDocument> Get();
    }
    
}
