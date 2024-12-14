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
            this.Nome = Nome;
            this.Contato = Contato;
            this.Cpf = Cpf;
            this.Nascimento = Nascimento;
        }
    }
}
