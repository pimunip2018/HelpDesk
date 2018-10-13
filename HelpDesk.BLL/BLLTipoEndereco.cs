using Helpdesk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.BLL
{
    public class BLLTipoEndereco
    {
        private DALConexao Conexao;


        public BLLTipoEndereco(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public DataTable CarregarCombo()
        {
            DALTipoEndereco DalObj = new DALTipoEndereco(Conexao);
            return DalObj.CarregarCombo();

        }
    }
}
