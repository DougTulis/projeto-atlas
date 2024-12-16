using Projeto_Atlas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Interfaces
{
   public  interface DAO
    {

        public IEnumerable<Pessoa> Listar();
        public void AdicionarPessoa(Pessoa Pessoa);
        public void DeletarPessoa(Pessoa Pessoa);
        public void AtualizarPessoa(Pessoa Pessoa);

    }
}
