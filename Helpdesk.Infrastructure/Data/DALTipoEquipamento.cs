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
    public class DALTipoEquipamento
    {
        private DALConexao Conexao;

        public DALTipoEquipamento(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Alterar(TipoEquipamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoEquipamentoUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", modelo.TipoEquipamentoId);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Incluir(TipoEquipamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoEquipamentoInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable Localizar(string descricao, int id)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand("[dbo].[spTipoEquipamentoLocaliza]", Conexao.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@TipoEquipamentoId", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
    }
}
