using Helpdesk.Infrastructure.Data;
using HelpDesk.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public void Desativar(string cpf)
        {
            DALPessoa DalObj = new DALPessoa(Conexao);
            DalObj.Desativar(cpf);
        }

        public DataTable Localizar(string cpf, string nome, int bloquado,int tipousuario, int sexo)
        {
            DALPessoa DalObj = new DALPessoa(Conexao);
            return DalObj.Localizar(cpf, nome, bloquado, tipousuario, sexo);

        }

       
    }
}
