using MongoDB.Driver;

namespace Barbearia_console.Data
{
    public class Database
    {
        public IMongoDatabase MongoDb { get; private set; }

        public Database()
        {
            var cliente = new MongoClient("mongodb://localhost:27017");
            MongoDb = cliente.GetDatabase("BarbeariaDB");
        }
    }
}