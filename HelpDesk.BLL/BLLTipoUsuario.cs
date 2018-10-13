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
    public class BLLTipoUsuario
    {
       
            private DALConexao Conexao;


            public BLLTipoUsuario(DALConexao dalConexao)
            {
                this.Conexao = dalConexao;
            }

            public void Incluir(TipoUsuario modelo)
            {
                if (modelo.Descricao.Trim().Length == 0)
                {
                    throw new Exception("O nome do Tipo de Pessoa é obrigatório");
                }

                DALTipoUsuario DalObj = new DALTipoUsuario(Conexao);
                DalObj.Incluir(modelo);
            }

            public void Alterar(TipoUsuario modelo)
            {
                if (modelo.TipoUsuarioId < 0)
                {
                    throw new Exception("O código do Tipo de Pessoa é obrigatório");
                }
                if (modelo.Descricao.Trim().Length == 0)
                {
                    throw new Exception("O nome do Tipo de Pessoa é obrigatório");
                }

                DALTipoUsuario DalObj = new DALTipoUsuario(Conexao);
                DalObj.Alterar(modelo);
            }

            public void Excluir(int id)
            {
                DALTipoUsuario DalObj = new DALTipoUsuario(Conexao);
                DalObj.Excluir(id);
            }

            public DataTable CarregarCombo(string valor)
            {
                DALTipoUsuario DalObj = new DALTipoUsuario(Conexao);
                return DalObj.CarregarCombo(valor);

            }
            public TipoUsuario CarregaTipoUsuario(int id)
            {
                DALTipoUsuario DalObj = new DALTipoUsuario(Conexao);
                return DalObj.CarregaTipoUsuario(id);
            }


        
    }
}
