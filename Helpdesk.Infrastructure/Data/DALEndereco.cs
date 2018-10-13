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
    public class DALEndereco
    {
        private DALConexao Conexao;

        public DALEndereco(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public DataTable CarregaEndereco(string Cpf)
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spEnderecoPorCpf]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@cpf", Convert.ToString(Cpf));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }

        public void Incluir(Endereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spEnderecoInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Logradouro", modelo.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@Complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@UF", modelo.UF);
            cmd.Parameters.AddWithValue("@CEP", modelo.CEP);
            cmd.Parameters.AddWithValue("@TipoEnderecoId", modelo.TipoEnderecoId);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Alterar(Endereco modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spEnderecoUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", modelo.EnderecoId);
            cmd.Parameters.AddWithValue("@cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Logradouro", modelo.Logradouro);
            cmd.Parameters.AddWithValue("@Numero", modelo.Numero);
            cmd.Parameters.AddWithValue("@Complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@Bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@UF", modelo.UF);
            cmd.Parameters.AddWithValue("@CEP", modelo.CEP);
            cmd.Parameters.AddWithValue("@TipoEnderecoId", modelo.TipoEnderecoId);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spEnderecoDelete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }
    }
}
