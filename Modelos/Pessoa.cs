using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Modelos
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }

        public Pessoa(string Nome, string Contato, string Cpf, DateTime Nascimento)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Contato = Contato;
            this.Cpf = Cpf;
            this.Nascimento = Nascimento;
        }

        public override string? ToString()
        {
            return "ID: " + Id + "\n" +
            "Nome: " + Nome + "\n" +
            "Contato: " + Contato + "\n" +
            "Nascimento " + Nascimento.ToString("dd/MM/yyyy") + "\n";
        }
    }
}
