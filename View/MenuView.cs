using System;
using Barbearia_console.Data;

namespace Barbearia_console.View
{
    public class Menu
    {
        private readonly UserRepository _repo;

        public Menu()
        {
            _repo = new UserRepository();
        }

        public void ExibirMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("1. Cadastro");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Deletar Usuário");
                Console.WriteLine("4. Sair");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        var telaCadastro = new CadastroView(_repo);
                        telaCadastro.Executar();
                        break;
                    case "2":
                        var telaLogin = new LoginView(_repo);
                        telaLogin.Executar();
                        break;
                    case "3":
                        var telaDeletar = new DeletarView(_repo);
                        telaDeletar.Executar();
                        break;
                    case "4":
                        continuar = false;
                        break;
                }
            }
        }
    }
}