using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atlas.Banco
{
    public class Conexao
    {
        private string StringConexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AtlasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(StringConexao);
        }
    }
}
