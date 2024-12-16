using Microsoft.Data.SqlClient;
using Projeto_Atlas.Banco;
using Projeto_Atlas.Interfaces;
using Projeto_Atlas.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Menus
{
    public class CadastroPessoas
    {
        private readonly DAO PessoaDAO;
        public CadastroPessoas(DAO PessoaDAO)
        {
            this.PessoaDAO = PessoaDAO; // Fazendo a injeção de dependencia
        }

        public void Cadastrar()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Cadastro de pessoas");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                Console.Write("Nome completo: ");
                string Nome = Console.ReadLine();
                Console.Write("Numero contato: ");
                string Contato = Console.ReadLine();
                Console.Write("CPF: ");
                string Cpf = Console.ReadLine();
                Console.Write("Data de nascimento (dd/MM/yyyy): ");
                DateTime Nascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
             
                PessoaDAO.AdicionarPessoa(new Pessoa(Nome, Contato, Cpf, Nascimento));

                Console.Write("Pessoa cadastrada com sucesso!");

            }
            catch (SqlException e) { Console.WriteLine(e.StackTrace); }
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
