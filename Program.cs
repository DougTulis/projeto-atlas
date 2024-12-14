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

        static void MostrarMenu()
        {
            MostrarLogo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Pessoas");
            Console.WriteLine("2. Locações");
            Console.WriteLine("3. Financeiro ");
            Console.WriteLine("4. Sair");
            int Escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(Escolha);
        }

        static void ExecutarEscolha(int Escolha)
        {
            switch (Escolha)
            {
                case 1:
                    // MenuPessoas();
                    Console.Clear();
                    Console.WriteLine("Executando menu pessoas");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    MostrarMenu();
                    break;
                case 2:
                    // MenuLocacoes();
                    Console.Clear();
                    Console.WriteLine("Executando menu Locações");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    MostrarMenu();

                    break;
                case 3:
                    // Financeiro();
                    Console.Clear();
                    Console.WriteLine("Executando menu Financeiro");
                    Console.ReadKey();
                    Thread.Sleep(1000);
                    Console.Clear();
                    MostrarMenu();
                    break;
                case 4:
                    // Sair();
                    Console.Clear();
                    Console.WriteLine("Volte Logo!! :)");
                    return;
                    MostrarMenu();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }

        }

        static void Main(string[] args)
        {
            MostrarMenu();
        }
    }
}
