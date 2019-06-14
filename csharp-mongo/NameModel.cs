using MongoDB.Bson.Serialization.Attributes;

namespace csharp_mongo
{
    [BsonIgnoreExtraElements]
    public class NameModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
