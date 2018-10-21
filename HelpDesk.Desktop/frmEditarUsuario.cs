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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        DALConexao dal = new DALConexao();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario modelo = new Usuario();

                modelo.CPF = lblCPFPessoa.Text;
                modelo.Senha = txtSenha.Text;
                modelo.Bloqueado = chkBloqueado.Checked;
                if (chkBloqueado.Checked == true)
                {
                    modelo.Tentativa = 0;
                }
                BLLUSuario bll = new BLLUSuario(dal);
                if (txtSenha.Text.Trim() == txtConfirmarSenha.Text.Trim())
                {

                    bll.AlterarUsuario(modelo);
                    MessageBox.Show("Os dados foram atualizados.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A duas senhas tem que ser iguais.");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            if (chkBloqueado.Checked)
            {
                txtSenha.Enabled = false;
                txtConfirmarSenha.Enabled = false;
            }
            else
            {
                txtSenha.Enabled = true;
                txtConfirmarSenha.Enabled = true;
            }
        }

        private void chkBloqueado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBloqueado.Checked)
            {
                txtSenha.Enabled = false;
                txtConfirmarSenha.Enabled = false;
            }
            else
            {
                txtSenha.Enabled = true;
                txtConfirmarSenha.Enabled = true;
            }
        }
    }
}
