using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace csharp_mongo
{
    public class PersonModel
    {
        [BsonId] // Hey mongo, this is your id!
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }
        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }
}
