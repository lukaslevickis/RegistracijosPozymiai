using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;

namespace RegistracijosPozymiai.DTO.Collections
{
    public class Registration
    {
        public ObjectId Id { get; set; }
        public List<ObjectId> QuestionsIds { get; set; }
    }
}
