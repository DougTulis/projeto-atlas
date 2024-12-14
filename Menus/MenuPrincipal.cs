using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    static class MenuPrincipal
    {

        public static void Menu() {

            MostrarLogo.Logo();
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Registrar Pessoa");
            Console.WriteLine("2. Histórico de pessoas");
            Console.WriteLine("3. Nova Locação");
            Console.WriteLine("4. Historico de Locação");
            Console.WriteLine("5. Baixar Locação");
            Console.WriteLine("6. Plano de Contas");
            Console.WriteLine("7. Listar Pendencias Financeiras");
            Console.WriteLine("8. Baixar Pendência Financeira");
            Console.WriteLine("0. Sair");
        }
    }
}
