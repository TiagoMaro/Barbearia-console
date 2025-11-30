using Barbearia_console.Model;
using MongoDB.Driver;

namespace Barbearia_console.Data
{
    public class UserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository()
        {
            var database = new Database();
            _users = database.MongoDb.GetCollection<User>("Usuarios");
        }

        public void CriarUsuario(User user)
        {
            _users.InsertOne(user);
        }

        public bool DeleteUsuario(string email)
        {
            var DelUsuario = _users.DeleteOne(u => u.Email.ToLower() == email.ToLower());

            return DelUsuario.DeletedCount > 0;
        }

        public User BuscarPorEmail(string email)
        {
            return _users.Find(u => u.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public User Login(string email, string senha)
        {
            var usuarioEncontrado = _users.Find(u => u.Email.ToLower() == email.ToLower()).FirstOrDefault();

            if (usuarioEncontrado == null)
            {
                return null;
            }

            if (usuarioEncontrado.Senha == senha)
            {
                return usuarioEncontrado;
            }
            else
            {
                return null;
            }
        }
    }
}