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
    public class BLLPessoa
    {
        private DALConexao Conexao;


        public BLLPessoa(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Incluir(Pessoa modelo)
        {
            if (modelo.CPF == "")
            {
                throw new Exception("O CPF é obrigatório");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de Pessoa é obrigatório");
            }

            DALPessoa DalObj = new DALPessoa(Conexao);
            DalObj.Incluir(modelo);
        }

        public void Alterar(Pessoa modelo)
        {
           
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do Tipo de Pessoa é obrigatório");
            }

            DALPessoa DalObj = new DALPessoa(Conexao);
            DalObj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALPessoa DalObj = new DALPessoa(Conexao);
            DalObj.Excluir(id);
        }

        public DataTable Localizar(string cpf, string nome, int bloquado, string cargo, int tipousuario, int sexo)
        {
            DALPessoa DalObj = new DALPessoa(Conexao);
            return DalObj.Localizar(cpf, nome, bloquado, cargo, tipousuario, sexo);

        }
        public TipoUsuario CarregaPessoaPF(int id)
        {
            DALPessoa DalObj = new DALPessoa(Conexao);
            return DalObj.CarregaPessoaPF(id);
        }
    }
}
