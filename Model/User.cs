using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Barbearia_console.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
    }
}