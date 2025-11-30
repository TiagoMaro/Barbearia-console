using System;
using Barbearia_console.Data;

namespace Barbearia_console.View
{
    public class DeletarView
    {
        private readonly UserRepository _repo;

        public DeletarView(UserRepository repo)
        {
            _repo = repo;
        }

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- EXCLUSÃO DE USUÁRIO ---");
            Console.WriteLine("Atenção: Essa ação não pode ser desfeita!");
            
            Console.Write("\nDigite o email do usuário a ser deletado: ");
            string email = Console.ReadLine();

            // Confirmação de segurança
            Console.Write($"Tem certeza que deseja apagar '{email}'? (S/N): ");
            var confirmacao = Console.ReadLine();

            if (confirmacao?.ToUpper() == "S")
            {
                bool deletou = _repo.DeleteUsuario(email);

                if (deletou)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nUsuário deletado com sucesso.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nErro: Usuário não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nOperação cancelada.");
            }

            Console.ResetColor();
            Console.WriteLine("Pressione Enter para voltar...");
            Console.ReadLine();
        }
    }
}