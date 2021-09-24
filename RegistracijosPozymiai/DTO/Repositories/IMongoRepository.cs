using System;
using System.Collections.Generic;

namespace RegistracijosPozymiai.DTO.Repositories
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        List<TDocument> Get();
    }
    
}
