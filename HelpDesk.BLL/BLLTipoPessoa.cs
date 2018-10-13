using Helpdesk.Infrastructure.Data;
using HelpDesk.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.BLL
{
    public class BLLTipoPessoa
    {
        private DALConexao Conexao;


        public BLLTipoPessoa(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Incluir(TipoUsuario modelo)
        {
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de Pessoa é obrigatório");
            }

            DALTipoPessoa DalObj = new DALTipoPessoa(Conexao);
            DalObj.Incluir(modelo);
        }

        public void Alterar(TipoUsuario modelo)
        {
            if (modelo.TipoUsuarioId < 0)
            {
                throw new Exception("O código do Tipo de Pessoa é obrigatório");
            }
            if (modelo.Descricao.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de Pessoa é obrigatório");
            }

            DALTipoPessoa DalObj = new DALTipoPessoa(Conexao);
            DalObj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALTipoPessoa DalObj = new DALTipoPessoa(Conexao);
            DalObj.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DALTipoPessoa DalObj = new DALTipoPessoa(Conexao);
            return DalObj.Localizar(valor);

        }
        public TipoUsuario CarregaTipoPessoa(int id)
        {
            DALTipoPessoa DalObj = new DALTipoPessoa(Conexao);
            return DalObj.CarregaTipoPessoa(id);
        }


    }
}
