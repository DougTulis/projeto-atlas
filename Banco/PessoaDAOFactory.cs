using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Banco
{
    public class PessoaDAOFactory
    {
        public PessoaDAO InstanciarPessoaDAO()
        {
            return new PessoaDAO();
        }

    }
}
