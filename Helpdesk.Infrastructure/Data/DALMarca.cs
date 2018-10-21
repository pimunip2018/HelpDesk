using HelpDesk.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk.Infrastructure.Data
{
    public class DALMarca
    {
        private DALConexao Conexao;

        public DALMarca(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Incluir(Marca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spMarcaInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Alterar(Marca modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spMarcaUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", modelo.MarcaId);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable Localizar(string descricao, int MarcaId)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand("[dbo].[spMarcaLocaliza]", Conexao.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@MarcaId", MarcaId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
    }
}
