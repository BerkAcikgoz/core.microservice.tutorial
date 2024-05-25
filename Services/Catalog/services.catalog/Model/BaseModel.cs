using MongoDB.Bson.Serialization.Attributes;

namespace services.catalog.Model
{
    public abstract class BaseModel
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
