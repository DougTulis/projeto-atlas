using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public class MenuTipoLocacao
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+---------------------+");
            Console.WriteLine("|      1. MENSAL      |");
            Console.WriteLine("|      2. DIÁRIA      |");
            Console.WriteLine("|      3. ANUAL       |");
            Console.WriteLine("+---------------------+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Escolha uma das opções: ");
        }
        public static bool Contrato()
        {
            bool Contratual = false;
            int Escolha = int.Parse(Console.ReadLine());
            if (Escolha == 1 || Escolha == 3)
            {
                Console.WriteLine("Deseja promover para contrato? ");
                Console.WriteLine("1. Sim");
                Console.WriteLine("2. Não");
                int EscolhaContrato = int.Parse(Console.ReadLine());
                if (EscolhaContrato == 1)
                {
                    Contratual = true;
                }
            }
            if (Contratual)
            {
                return true;
            }
            return false;
        }



    }
}
