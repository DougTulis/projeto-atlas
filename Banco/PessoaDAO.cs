using Microsoft.Data.SqlClient;
using Projeto_Atlas.Interfaces;
using Projeto_Atlas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Banco
{
    public class PessoaDAO : DAO
    {
        private readonly Conexao Conexao;
        public PessoaDAO(Conexao Conexao)
        {
            this.Conexao = Conexao;
        }
        public IEnumerable<Pessoa> Listar()
        {
            using var Conexao = new Conexao().ObterConexao();
            Conexao.Open();
            var Lista = new List<Pessoa>();
            string Sql = "SELECT * FROM Pessoa";
            SqlCommand Cmd = new SqlCommand(Sql, Conexao);
            using SqlDataReader DataReader = Cmd.ExecuteReader();

            while (DataReader.Read())
            {
                Int16 IdPessoa = Convert.ToInt16(DataReader["IdPessoa"]);
                string NomePessoa = Convert.ToString(DataReader["Nome"]);
                string Contato = Convert.ToString(DataReader["Contato"]);
                DateTime Nascimento = Convert.ToDateTime(DataReader["Nascimento"]);
                string Cpf = Convert.ToString(DataReader["Cpf"]);
                var Pessoa = new Pessoa(NomePessoa, Contato, Cpf, Nascimento);
                Lista.Add(Pessoa);
            }
            return Lista;
        }

        public void AdicionarPessoa(Pessoa Pessoa)
        {
            using var Conexao = new Conexao().ObterConexao();
            Conexao.Open();

            string Sql = "INSERT INTO Pessoa (Nome, Contato, Nascimento, Cpf) VALUES (@nome, @Contato, @Nascimento, @Cpf)";

            SqlCommand Cmd = new SqlCommand(Sql, Conexao);
            Cmd.Parameters.AddWithValue("@Nome", Pessoa.Nome);
            Cmd.Parameters.AddWithValue("@Contato", Pessoa.Contato);
            Cmd.Parameters.AddWithValue("@Nascimento", Pessoa.Nascimento);
            Cmd.Parameters.AddWithValue("@Cpf", Pessoa.Cpf);
        }
        public void DeletarPessoa(Pessoa Pessoa)
        {
            using var Conexao = new Conexao().ObterConexao();
            Conexao.Open();
            string Sql = "$DELETE FROM Pessoa WHERE IdPessoa = @id";
            SqlCommand Cmd = new SqlCommand(Sql, Conexao);
            Cmd.Parameters.AddWithValue("@Id", Pessoa.Id);
        }

        public void AtualizarPessoa(Pessoa Pessoa)
        {
            using var Conexao = new Conexao().ObterConexao();
            Conexao.Open();
            string Sql = $"UPDATE Pessoa SET Nome = @nome, Contato = @contato, Nascimento = @nascimento, Cpf = @cpf WHERE Id = @id)";
            SqlCommand Cmd = new SqlCommand(Sql, Conexao);
            Cmd.Parameters.AddWithValue("@nome", Pessoa.Nome);
            Cmd.Parameters.AddWithValue("@contato", Pessoa.Contato);
            Cmd.Parameters.AddWithValue("@nascimento", Pessoa.Nascimento);
            Cmd.Parameters.AddWithValue("@cpf", Pessoa.Cpf);
            Cmd.Parameters.AddWithValue("@id", Pessoa.Id);
        }
    }
}
