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
    public class DALEquipamento
    {

        private DALConexao Conexao;

        public DALEquipamento(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void AlterarEquipamento(Equipamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spEquipamentoUpdate]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", modelo.EquipamentoId);
            cmd.Parameters.AddWithValue("@Cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@Identificacao", modelo.Identificacao);
            cmd.Parameters.AddWithValue("@TipoEquipamentoId", modelo.TipoEquipamentoId);
            cmd.Parameters.AddWithValue("@MarcaId", modelo.MarcaId);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public void IncluirEquipamento(Equipamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexao.ObjetoConexao;
            cmd.CommandText = "[dbo].[spEquipamentoInsert]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cpf", modelo.CPF);
            cmd.Parameters.AddWithValue("@Descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@Identificacao", modelo.Identificacao);
            cmd.Parameters.AddWithValue("@TipoEquipamentoId", modelo.TipoEquipamentoId);
            cmd.Parameters.AddWithValue("@MarcaId", modelo.MarcaId);
            Conexao.Conectar();
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

        public DataTable Localizar(string CPF, string descricao, string identificacao, int marca, int tipo)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand("[dbo].[spEquipamentoLocaliza]", Conexao.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cpf", CPF);
            cmd.Parameters.AddWithValue("@Descricao", descricao);
            cmd.Parameters.AddWithValue("@Identificacao", identificacao);
            cmd.Parameters.AddWithValue("@TipoEquipamentoId", tipo);
            cmd.Parameters.AddWithValue("@MarcaId", marca);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;
        }
    }
}
