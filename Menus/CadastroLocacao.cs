using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public static class CadastroLocacao
    {
        public static void Cadastrar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Cadastro de locação");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White;

            // Preenchendo o formulário de locação de veículos

            Console.Write("CPF do locatário: ");
            string CpfLocatario = Console.ReadLine();

            Console.Write("CPF do Condutor do veículo: ");
            string CpfCondutor = Console.ReadLine();

            MenuTipoLocacao.Exibir();
            MenuTipoLocacao.Contrato();
            MenuPagamentos.Exibir();

            



            
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
