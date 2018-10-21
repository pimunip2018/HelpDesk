using Helpdesk.Infrastructure.Data;
using HelpDesk.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void AlterarUsuario(Usuario modelo)
        {
            DALUsuario DalObj = new DALUsuario(Conexao);
            DalObj.AlterarUsuario(modelo);
        }

        public void IncluirUsuario(Usuario model)
        {
            DALUsuario DalObj = new DALUsuario(Conexao);
            DalObj.IncluirUsuario(model);
        }

        
        public DataTable Localizar(string cpf, string nome)
        { 
            DALUsuario DalObj = new DALUsuario(Conexao);
            return DalObj.Localizar(cpf, nome);

        }
    }
}
