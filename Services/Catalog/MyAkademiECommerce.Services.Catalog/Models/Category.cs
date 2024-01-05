using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MyAkademiECommerce.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
