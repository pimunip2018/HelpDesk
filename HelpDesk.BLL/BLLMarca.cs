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
    public class BLLMarca
    {
        private DALConexao Conexao;


        public BLLMarca(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Incluir(Marca modelo)
        {
            DALMarca DalObj = new DALMarca(Conexao);
            DalObj.Incluir(modelo);
        }

        public void Alterar(Marca modelo)
        {
            DALMarca DalObj = new DALMarca(Conexao);
            DalObj.Alterar(modelo);
        }

        public DataTable CarregarCombo(string descricao, int MarcaId)
        {
            DALMarca DalObj = new DALMarca(Conexao);
            return DalObj.Localizar(descricao, MarcaId);

        }
    }
}
