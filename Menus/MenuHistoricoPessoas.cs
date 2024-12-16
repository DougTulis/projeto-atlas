using Projeto_Atlas.Banco;
using Projeto_Atlas.Interfaces;
using Projeto_Atlas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public class MenuHistoricoPessoas
    {
        private readonly DAO PessoaDAO;
        public MenuHistoricoPessoas(DAO PessoaDAO)
        {
            this.PessoaDAO = PessoaDAO;
        }
        public void Exibir()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Historico de pessoas cadastradas");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************************************");
            Console.ForegroundColor = ConsoleColor.White;

            foreach(Pessoa P in PessoaDAO.Listar())
            {
                Console.WriteLine(P);
            }
        }
    }
}
