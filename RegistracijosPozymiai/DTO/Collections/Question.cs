using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace RegistracijosPozymiai.DTO.Collections
{
    public class Question
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public Option Answer { get; set; }

        //public ICollection<Option> Options { get; set; }

        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public ObjectId AnswerId { get; set; }

        public List<ObjectId> OptionIds { get; set; }
    }
}
