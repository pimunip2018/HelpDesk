using Helpdesk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.BLL
{
    public class BLLSexo
    {
        private DALConexao Conexao;


        public BLLSexo(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }
        public DataTable CarregarCombo()
        {
            DALSexo DalObj = new DALSexo(Conexao);
            return DalObj.CarregarCombo();

        }

    }
}
