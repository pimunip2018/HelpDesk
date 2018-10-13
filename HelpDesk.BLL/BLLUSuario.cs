using Helpdesk.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.BLL
{
    public class BLLUSuario
    {
        private DALConexao Conexao;


        public BLLUSuario(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }
        public string usuario { get; set; }
        public string senha { get; set; }

        
        public SqlDataReader IniciaSessao()
        {
            SqlDataReader Logar;
            DALUsuario DalObj = new DALUsuario(Conexao);
            Logar = DalObj.iniciaSessao(usuario, senha);
            return Logar;
        }

        public void Desativar(int cpf)
        {
            DALUsuario DalObj = new DALUsuario(Conexao);
            DalObj.Desativar(cpf);
        }
    }
}
