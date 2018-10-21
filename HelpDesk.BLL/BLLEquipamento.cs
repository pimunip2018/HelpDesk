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
    public class BLLEquipamento
    {

        private DALConexao Conexao;


        public BLLEquipamento(DALConexao dalConexao)
        {
            this.Conexao = dalConexao;
        }

        public void Incluir(Equipamento modelo)
        {
            DALEquipamento DalObj = new DALEquipamento(Conexao);
            DalObj.IncluirEquipamento(modelo);
        }

        public void Alterar(Equipamento modelo)
        {

            DALEquipamento DalObj = new DALEquipamento(Conexao);
            DalObj.AlterarEquipamento(modelo);
        }

        public DataTable Localizar(string CPF, string descricao, string identificacao, int marca, int tipo)
        {
            DALEquipamento DalObj = new DALEquipamento(Conexao);
            return DalObj.Localizar(CPF, descricao, identificacao, marca, tipo);

        }
    }
}
