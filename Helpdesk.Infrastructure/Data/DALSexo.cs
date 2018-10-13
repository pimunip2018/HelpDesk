using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk.Infrastructure.Data
{
    public class DALSexo
    {
        private DALConexao Conexao;

        public DALSexo(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }
        public DataTable CarregarCombo()
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spSexo]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }
        
    }
}
