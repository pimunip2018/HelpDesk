using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk.Infrastructure.Data
{
    public class DALTipoEndereco
    {

        private DALConexao Conexao;

        public DALTipoEndereco(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }
        public DataTable CarregarCombo()
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spTipoEndereco]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }
    }
}
