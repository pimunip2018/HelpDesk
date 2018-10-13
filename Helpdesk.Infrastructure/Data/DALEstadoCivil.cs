using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk.Infrastructure.Data
{
    public class DALEstadoCivil
    {
        private DALConexao Conexao;

        public DALEstadoCivil(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public DataTable CarregarCombo()
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spEstadoCivil]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }

    }
}
