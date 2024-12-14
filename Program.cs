namespace Projeto_Atlas
{
    internal class Program
    {

        public void MostrarLogo()
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Pessoas");
            Console.WriteLine("2. Locações");
            Console.WriteLine("3. Financeiro ");
            Console.WriteLine("4. Sair");
        }

        static void ExecutarEscolha(int Escolha)
        {
            switch (Escolha)
            {
                case 1:
                    // MenuPessoas();
                    break;
                case 2:
                    // MenuLocacoes();
                    break;
                case 3:
                    // Financeiro();
                    break;
                case 4:
                    // Sair();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
