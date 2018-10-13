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
    public class BLLEndereco
    {
        private DALConexao Conexao;


        public BLLEndereco(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public DataTable CarregaEndereco(string cpf)
        {
            DALEndereco DalObj = new DALEndereco(Conexao);
            return DalObj.CarregaEndereco(cpf);
        }

        public void Incluir(Endereco modelo)
        {
            if (modelo.CPF == "")
            {
                throw new Exception("O CPF é obrigatório");
            }
            if (modelo.Logradouro.Trim().Length == 0)
            {
                throw new Exception("O Logradouro é obrigatório");
            }

            DALEndereco DalObj = new DALEndereco(Conexao);
            DalObj.Incluir(modelo);
        }

        public void Alterar(Endereco modelo)
        {

            if (modelo.Logradouro.Trim().Length == 0)
            {
                throw new Exception("O Endereço é obrigatório");
            }

            DALEndereco DalObj = new DALEndereco(Conexao);
            DalObj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DALEndereco DalObj = new DALEndereco(Conexao);
            DalObj.Excluir(id);
        }
    }
}
