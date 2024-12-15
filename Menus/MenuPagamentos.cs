using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public class MenuPagamentos
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|         1. DINHEIRO        |");
            Console.WriteLine("|    2. CARTÃO CRÉDITO 10X   |");
            Console.WriteLine("|      3. CARTÃO DÉBITO      |");
            Console.WriteLine("|           4. PIX           |");
            Console.WriteLine("+----------------------------+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Escolha uma das opções: ");
        }

    }
}
