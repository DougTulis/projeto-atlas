using Projeto_Atlas.Menus;

namespace Projeto_Atlas
{
    internal class Program
    {

        static void MostrarLogo()
        {
            Console.WriteLine(@"
 █████╗ ████████╗██╗      █████╗ ███████╗
██╔══██╗╚══██╔══╝██║     ██╔══██╗██╔════╝
███████║   ██║   ██║     ███████║███████╗
██╔══██║   ██║   ██║     ██╔══██║╚════██║
██║  ██║   ██║   ███████╗██║  ██║███████║
╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚══════");
        }


        static void ExecutarEscolha(int Escolha)
        {
            switch (Escolha)
            {
                case 1:
                    CadastroPessoas.Cadastrar();
                    break;
                case 2:
                    // MenuLocacoes();
                    Console.Clear();
                    Console.WriteLine("Executando menu Locações");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 3:
                    // Financeiro();
                    Console.Clear();
                    Console.WriteLine("Executando menu Financeiro");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 0:
                    // Sair();
                    Console.Clear();
                    Console.WriteLine("Volte Logo!! :)");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida!!");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    
                    break;

            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                MenuPrincipal.Menu();
                int Escolha = int.Parse(Console.ReadLine());
                ExecutarEscolha(Escolha);
            }
        }
    }
}
