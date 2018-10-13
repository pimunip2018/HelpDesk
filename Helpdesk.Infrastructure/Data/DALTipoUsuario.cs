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
    public class DALTipoUsuario
    {
        private DALConexao Conexao;

        public DALTipoUsuario(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }


        public void Incluir(TipoUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoUsuarioInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Alterar(TipoUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoUsuarioUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", modelo.TipoUsuarioId);
            cmd.Parameters.AddWithValue("@nome", modelo.Descricao);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoUsuarioDelete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable CarregarCombo(string valor)
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spTipoUsuarioLocaliza]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@valor", Convert.ToString(valor));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }

        public TipoUsuario CarregaTipoUsuario(int id)
        {
            TipoUsuario modelo = new TipoUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spTipoUsuarioLocalizaPorId] ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            Conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TipoUsuarioId = Convert.ToInt32(registro["TipoUsuarioId"]);
                modelo.Descricao = Convert.ToString(registro["Descricao"]);
            }
            return modelo;
        }
    }
}
