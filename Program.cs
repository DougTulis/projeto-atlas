using Microsoft.Data.SqlClient;
using Projeto_Atlas.Banco;
using Projeto_Atlas.Menus;
using System.Linq.Expressions;


try
{
    using var Conexao = new Conexao().ObterConexao();
    Conexao.Open();
    Console.WriteLine("Conexao Aberta!");
}
catch(SqlException e){
    Console.WriteLine(e.StackTrace);
}
return;
namespace Projeto_Atlas
{
    internal class Program
    {
       static void ExecutarEscolha(int Escolha)
        {
            switch (Escolha)
            {
                case 1:
                    CadastroPessoas.Cadastrar();
                    break;
                case 2:
                    // Historico de pessoas (quando implementar o banco de dados irei fazer)
                    break;
                case 3:
                    CadastroLocacao.Cadastrar(); 
                    break;
                case 4:
                    // Historico de Locação
                    break;
                case 5:
                    // Baixa de Locação
                    break;
                case 6:
                    // Plano De Contas
                    break;
                case 7:
                    // Pendencias Financeiras
                    break;
                case 8:
                    // Baixar Pendencias Financeiras
                    break;
                case 0:
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
        /*  Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Registrar Pessoa");
            Console.WriteLine("2. Histórico de pessoas");
            Console.WriteLine("3. Nova Locação");
            Console.WriteLine("4. Historico de Locação");
            Console.WriteLine("5. Baixar Locação");
            Console.WriteLine("6. Plano de Contas");
            Console.WriteLine("7. Listar Pendencias Financeiras");
            Console.WriteLine("8. Baixar Pendência Financeira");
            Console.WriteLine("0. Sair");*/
    }
}
