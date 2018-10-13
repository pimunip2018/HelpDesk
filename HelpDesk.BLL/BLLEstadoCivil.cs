using Helpdesk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.BLL
{
    public class BLLEstadoCivil
    {
        private DALConexao Conexao;


        public BLLEstadoCivil(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public DataTable CarregarCombo()
        {
            DALEstadoCivil DalObj = new DALEstadoCivil(Conexao);
            return DalObj.CarregarCombo();

        }
    }
}
