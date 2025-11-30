using System;
using Barbearia_console.Data;
using Barbearia_console.Model;

namespace Barbearia_console.View
{
    public class CadastroView
    {
        private readonly UserRepository _repo;

        public CadastroView(UserRepository repo)
        {
            _repo = repo; // Recebe o repositório já pronto
        }

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("\n--- NOVO CADASTRO ---");
            var user = new User();

            Console.Write("Digite o Nome: ");
            user.Nome = Console.ReadLine();

            Console.Write("Digite o Email: ");
            user.Email = Console.ReadLine();

            Console.Write("Digite a Senha: ");
            user.Senha = Console.ReadLine();

            _repo.CriarUsuario(user);
            
            Console.WriteLine("Sucesso! Pressione Enter.");
            Console.ReadLine();
        }
    }
}