using Helpdesk.Infrastructure.Data;
using HelpDesk.BLL;
using HelpDesk.Domain.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk.Desktop
{
    public partial class frmCadastroTipoUsuario : Form
    {
        public frmCadastroTipoUsuario()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               
                TipoUsuario modelo = new TipoUsuario();
                modelo.Descricao = txtDescricao.Text;
                DALConexao dal = new DALConexao();
                BLLTipoPessoa bll = new BLLTipoPessoa(dal);

                if (txtCodigo.Text == "")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Tipo de Pessoa cadastrado com sucesso!");

                }
                else
                {
                    modelo.TipoUsuarioId = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Tipo de Pessoa atualizado com sucesso!");
                }
               
                LimpaTela();
                this.Close();
                

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
    }
}
