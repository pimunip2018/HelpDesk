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
    public class DALPessoa
    {
        private DALConexao Conexao;

        public DALPessoa(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }


        public void Incluir(Pessoa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spPessoaInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@DtNasc", modelo.DtNasc);
            cmd.Parameters.AddWithValue("@Telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@TelefoneEmpresa", modelo.TelefoneEmpresa);
            cmd.Parameters.AddWithValue("@Ramal", modelo.Ramal);
            cmd.Parameters.AddWithValue("@TelefoneCelular", modelo.TelefoneCelular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@sexoId", modelo.SexoId);
            cmd.Parameters.AddWithValue("@EstadoCivilId", modelo.EstadoCivilId);
            cmd.Parameters.AddWithValue("@RazaoSocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@CNPJ", modelo.CNPJ);
            cmd.Parameters.AddWithValue("@DtFundacao", modelo.DtFundacao);
            cmd.Parameters.AddWithValue("@Cargo", modelo.Cargo);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Alterar(Pessoa modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spPessoaUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@DtNasc", modelo.DtNasc);
            cmd.Parameters.AddWithValue("@Telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@TelefoneEmpresa", modelo.TelefoneEmpresa);
            cmd.Parameters.AddWithValue("@Ramal", modelo.Ramal);
            cmd.Parameters.AddWithValue("@TelefoneCelular", modelo.TelefoneCelular);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@sexoId", modelo.SexoId);
            cmd.Parameters.AddWithValue("@EstadoCivilId", modelo.EstadoCivilId);
            cmd.Parameters.AddWithValue("@RazaoSocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@CNPJ", modelo.CNPJ);
            cmd.Parameters.AddWithValue("@DtFundacao", modelo.DtFundacao);
            cmd.Parameters.AddWithValue("@Cargo", modelo.Cargo);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void Desativar(string cpf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spUsuarioDesativar]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cpf", cpf);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable Localizar(string cpf, string nome, int bloqueado, int tipousuario, int sexoId)
        {

            DataTable tabela = new DataTable();
            SqlCommand cm = new SqlCommand("[dbo].[spPessoaLocaliza]", Conexao.Conectar());
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@cpf", Convert.ToString(cpf));
            cm.Parameters.AddWithValue("@nome", Convert.ToString(nome));
            cm.Parameters.AddWithValue("@bloqueado", Convert.ToInt32(bloqueado));
            cm.Parameters.AddWithValue("@tipousuario", Convert.ToInt32(tipousuario));
            cm.Parameters.AddWithValue("@sexo", Convert.ToInt32(sexoId));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(tabela);
            return tabela;
        }

       
    }
}
