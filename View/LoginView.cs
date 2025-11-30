using System;
using Barbearia_console.Data;

namespace Barbearia_console.View
{
    public class LoginView
    {
        private readonly UserRepository _repo;

        public LoginView(UserRepository repo)
        {
            _repo = repo;
        }

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("\n--- TELA DE LOGIN ---");

            Console.Write("Digite o email: ");
            string email = Console.ReadLine();
            
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            var usuario = _repo.Login(email, senha);

            if (usuario != null)
            {
                Console.WriteLine($"Bem-vindo de volta, {usuario.Nome}!");
            }
            else
            {
                Console.WriteLine("Email ou senha incorreto.");
            }
            Console.ReadLine();
        }
    }
}