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

        public void Desativar(int cpf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spUsuarioDelete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cpf", cpf);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

       

    }
}
