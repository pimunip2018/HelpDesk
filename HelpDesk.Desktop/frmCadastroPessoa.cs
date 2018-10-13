using Correios.Net;
using Helpdesk.Infrastructure.Data;
using HelpDesk.BLL;
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
    public partial class frmCadastroPessoa : Form
    {

        public string operacao;
        public frmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            limpartela(this.Controls);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpartela(this.Controls);
            this.Close();

        }

        private void limpartela(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + txtCEP.Text.Replace("-", "").Trim() + "&formato=xml");

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                        txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                        txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                        txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() + ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            pessoaFisica();
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            pessoaJuridica();
        }


        public void pessoaFisica()
        {
            if (rdbFisica.Checked == true)
            {
                rdbJuridica.Checked = false;
                lblNome.Text = "Nome";
                lblDataNascimento.Text = "Data de Nascimento";
                cmbSexo.Enabled = true;
                lblCPF.Text = "CPF";
                txtCPF.Mask = "000,000,000-00";
            }
        }

        public void pessoaJuridica()
        {
            if (rdbJuridica.Checked == true)
            {
                rdbFisica.Checked = false;
                lblNome.Text = "Razão Social";
                lblDataNascimento.Text = "Data de Fundação";
                cmbSexo.Enabled = false;
                lblCPF.Text = "CNPJ";
                txtCPF.Mask = "00,000,000/0000-00";
            }
        }

        public void CarregarSexo()
        {
            DALConexao dal = new DALConexao();
            BLLSexo bll = new BLLSexo(dal);
            cmbSexo.DataSource = bll.CarregarCombo();
            cmbSexo.DisplayMember = "Descricao";
            cmbSexo.ValueMember = "SexoId";

        }

        private void frmCadastroPessoa_Load(object sender, EventArgs e)
        {
            
            if(operacao=="editar")
            {
                desabilitarCampo();
            }
            else
            {
                limpartela(this.Controls);
                habilitarCampo();
            }

            if (cmbSexo.SelectedValue == null)
            {
                CarregarSexo();
            }
            
        }

        public void habilitarCampo()
        {
            txtCPF.Enabled = true;
            txtDtNAsc.Enabled = true;
        }

        public void desabilitarCampo()
        {
            txtCPF.Enabled = false;
            txtDtNAsc.Enabled = false;
        }

        private void txtDtNAsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApenasNumero(sender, e);
        }

        public void ApenasNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
