using Barbearia_console.View; // <--- Importante: Importar a View

namespace Barbearia_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // O programa apenas cria o menu e manda ele rodar
            var menu = new Menu();
            menu.ExibirMenu();
        }
    }
}