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
    public class DALUsuario
    {
        private SqlDataReader da;

        private DALConexao Conexao;

        public DALUsuario(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }


        public SqlDataReader iniciaSessao(string cpf, string senha)
        {
            SqlCommand cmd = new SqlCommand("spIniciaSessao",Conexao.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@Senha", senha);
            da = cmd.ExecuteReader();
            return da;

        }

        public void AlterarUsuario(Usuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spUsuarioUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@bloqueado", modelo.Bloqueado);
            cmd.Parameters.AddWithValue("@tentativas", modelo.Tentativa);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void IncluirUsuario(Usuario model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spUsuarioInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cpf", model.CPF);
            cmd.Parameters.AddWithValue("@tipoUsuarioId", model.TipoUsuarioId);
            cmd.Parameters.AddWithValue("@senha", model.Senha);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable Localizar(string cpf, string nome)
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spUsuarioLocaliza]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@cpf", Convert.ToString(cpf));
            cm.Parameters.AddWithValue("@nome", Convert.ToString(nome));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }
    }
}
