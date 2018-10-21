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
    public class BLLTipoEquipamento
    {
        private DALConexao Conexao;


        public BLLTipoEquipamento(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }
        public void Incluir(TipoEquipamento modelo)
        {
            DALTipoEquipamento DalObj = new DALTipoEquipamento(Conexao);
            DalObj.Incluir(modelo);
        }

        public void Alterar(TipoEquipamento modelo)
        {
            DALTipoEquipamento DalObj = new DALTipoEquipamento(Conexao);
            DalObj.Alterar(modelo);
        }

        public DataTable CarregarCombo(string descricao, int id)
        {
            DALTipoEquipamento DalObj = new DALTipoEquipamento(Conexao);
            return DalObj.Localizar(descricao, id);

        }
    }
}
