using Projeto_Atlas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public static class CadastroPessoas
    {
        public static Pessoa Cadastrar()
        {
            Console.Clear();
            Console.Write("Nome completo: ");
            string Nome = Console.ReadLine();
            Console.Write("Numero contato: ");
            string Contato = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Data de nascimento (dd/MM/yyyy): ");
            DateTime Nascimento = DateTime.Parse(Console.ReadLine());
            var Pessoa = new Pessoa(Nome, Contato, Cpf, Nascimento);
            return Pessoa;
        }
    }
}
