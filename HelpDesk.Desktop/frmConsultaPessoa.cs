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
    public partial class frmConsultaPessoa : Form
    {


        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        public string operacao = "";
        DALConexao dal = new DALConexao();

        public void MostrarDados(string cpf, string nome, int bloquado, string cargo, int tipousuario, int sexo)
        {

            DALConexao dal = new DALConexao();
            BLLPessoa bll = new BLLPessoa(dal);
            dtDados.DataSource = null;
            if (cpf == "")
            {
                cpf = null;
            }

            if (nome == "")
            {
                nome = null;
            }

            if (cargo == "")
            {
                cargo = null;
            }

            dtDados.DataSource = bll.Localizar(cpf, nome, bloquado, cargo, tipousuario, sexo);
            EsconderColuna();
            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];
            }


        }

        public void EsconderColuna()
        {
            dtDados.Columns["SexoId"].Visible = false;
            dtDados.Columns["TelefoneCelular"].Visible = false;
            dtDados.Columns["Sexo"].Visible = false;
            dtDados.Columns["EstadoCivilId"].Visible = false;
            dtDados.Columns["EstadoCivil"].Visible = false;
        }
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedIndex), cmbCargo.SelectedText, Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedIndex), cmbCargo.SelectedText, Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));
        }

        private void dtDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            dtDados.DefaultCellStyle.Font = new Font("Tohoma", 10);
            dtDados.Columns["Nome"].Width = 250;
            dtDados.Columns["CPF"].Width = 100;
            dtDados.Columns["DtNasc"].Width = 100;
            dtDados.Columns["DtNasc"].HeaderText = "Dt.Nascimento";
            dtDados.Columns["Telefone"].Width = 100;
            dtDados.Columns["Email"].Width = 160;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = "editar";

            desabilitarCampo();

            if (cmbSexo.SelectedValue == null)
            {
                CarregarSexo();
            }

            if (dtDados.SelectedRows.Count > 0)
            {
                tabControlBusca.SelectedTab = tabPageCadastro;

                txtNomeEdit.Text = dtDados.CurrentRow.Cells["Nome"].Value.ToString();
                txtCpfEdit.Text = dtDados.CurrentRow.Cells["CPF"].Value.ToString();
                cmbSexoEdit.SelectedValue = Convert.ToInt32(dtDados.CurrentRow.Cells["SexoId"].Value.ToString());
                cmbEstadoCivil.SelectedValue = Convert.ToInt32(dtDados.CurrentRow.Cells["EstadoCivilId"].Value.ToString());
                txtDtNascEdit.Text = dtDados.CurrentRow.Cells["DtNasc"].Value.ToString();
                txtRamalEdit.Text = dtDados.CurrentRow.Cells["Ramal"].Value.ToString();
                txtTelefoneEdit.Text = dtDados.CurrentRow.Cells["Telefone"].Value.ToString();
                txtCelularEdit.Text = dtDados.CurrentRow.Cells["TelefoneCelular"].Value.ToString();
                txtEmailEdit.Text = dtDados.CurrentRow.Cells["Email"].Value.ToString();
                txtRazaoSocialEdit.Text = dtDados.CurrentRow.Cells["RazaoSocial"].Value.ToString();
                txtCNPJEdit.Text = dtDados.CurrentRow.Cells["CNPJ"].Value.ToString();
                txtDtFundacaoEdit.Text = dtDados.CurrentRow.Cells["DtFundacao"].Value.ToString();
                txtCargoEdit.Text = dtDados.CurrentRow.Cells["Cargo"].Value.ToString();

                this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedValue), cmbCargo.SelectedText, Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));

                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];

                CarregarTipoEndereco();
                CarregarEndereco();


            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro!");
            }
        }

        private void CarregarEndereco()
        {
            BLLEndereco bll = new BLLEndereco(dal);
            dtEndereco.DataSource = bll.CarregaEndereco(txtCpfEdit.Text);
            dtEndereco.Refresh();
            dtEndereco.Update();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            operacao = "novo";
        }

        public void CarregarCombos()
        {
            CarregarTipoUsuario();
            CarregarAtivo();
            CarregarSexo();
            CarregarEstadoCivil();
        }

        public void CarregarAtivo()
        {
            cmbAtivo.Items.Insert(0, "Ativo");
            cmbAtivo.Items.Insert(1, "Bloqueado");
            cmbAtivo.SelectedIndex = 0;
        }
        public void CarregarTipoUsuario()
        {
            DALConexao dal = new DALConexao();
            BLLTipoUsuario bll = new BLLTipoUsuario(dal);
            cmbTipoUsuario.DataSource = bll.CarregarCombo("");
            cmbTipoUsuario.DisplayMember = "Descricao";
            cmbTipoUsuario.ValueMember = "TipoUsuarioId";
        }

        public void CarregarTipoEndereco()
        {
            DALConexao dal = new DALConexao();
            BLLTipoEndereco bll = new BLLTipoEndereco(dal);
            cmbTipo.DataSource = bll.CarregarCombo();
            cmbTipo.DisplayMember = "Descricao";
            cmbTipo.ValueMember = "TipoEnderecoId";
        }
        public void CarregarEstadoCivil()
        {


            BLLEstadoCivil bll = new BLLEstadoCivil(dal);
            cmbEstadoCivil.DataSource = bll.CarregarCombo();
            cmbEstadoCivil.DisplayMember = "Descricao";
            cmbEstadoCivil.ValueMember = "EstadoCivilId";
        }

        private void tabControlBusca_Click(object sender, EventArgs e)
        {
            if (tabControlBusca.SelectedTab == tabPageCadastro)
            {
                if (operacao == "")
                {
                    tabControlBusca.SelectedTab = tabPageBusca;
                }

            }

            if (tabControlBusca.SelectedTab == tabPageBusca)
            {
                if (operacao != "novo")
                {
                    operacao = "";
                }

            }


        }
        public void ApenasNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        public void habilitarCampo()
        {
            txtCpfEdit.Enabled = true;
            txtDtNascEdit.Enabled = true;
        }

        public void desabilitarCampo()
        {
            txtCpfEdit.Enabled = false;
            txtDtNascEdit.Enabled = false;
        }

        public void CarregarSexo()
        {
            DALConexao dal = new DALConexao();
            BLLSexo bll = new BLLSexo(dal);
            cmbSexoEdit.DataSource = bll.CarregarCombo();
            cmbSexoEdit.DisplayMember = "Descricao";
            cmbSexoEdit.ValueMember = "SexoId";
            cmbSexo.DataSource = bll.CarregarCombo();
            cmbSexo.DisplayMember = "Descricao";
            cmbSexo.ValueMember = "SexoId";

        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + txtCEPEdit.Text.Replace("-", "").Trim() + "&formato=xml");

                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEstadoEdit.Text = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                        txtCidadeEdit.Text = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                        txtBairroEdit.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                        txtEnderecoEdit.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() + ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
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

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }

            }
        }

        private void txtCpfEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void txtDtNAsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ApenasNumero(sender, e);
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            operacao = "inserir";
            limpartela(tabPageCadastro.Controls);
            habilitarCampo();


            if (cmbSexo.SelectedValue == null)
            {
                CarregarSexo();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            //try
            //{

            //    DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            //    if (d.ToString() == "Yes")
            //    {
            //        DALConexao dal = new DALConexao();
            //        BLLUSuario bll = new BLLUSuario(dal);

            //        bll.Desativar(Convert.ToInt32(dtDados.CurrentRow.Cells["CPF"].Value.ToString()));
            //        this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedValue), cmbCargo.SelectedText, Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));
            //    }
            //}
            //catch
            //{

            //    MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outra operação");

            //}
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa modelo = new Pessoa();

                modelo.CPF = txtCpfEdit.Text;
                modelo.Nome = txtNomeEdit.Text;
                modelo.DtNasc = Convert.ToDateTime(txtDtNascEdit.Text);
                modelo.Telefone = txtTelefoneEdit.Text;
                modelo.Ramal = Convert.ToInt32(txtRamalEdit.Text == "" ? 0 : Convert.ToInt32(txtRamalEdit.Text));
                modelo.TelefoneCelular = txtCelularEdit.Text;
                modelo.Email = txtEmailEdit.Text;
                modelo.SexoId = Convert.ToInt32(cmbSexoEdit.SelectedValue);
                modelo.EstadoCivilId = Convert.ToInt32(cmbEstadoCivil.SelectedValue);
                modelo.RazaoSocial = txtRazaoSocialEdit.Text;
                modelo.CNPJ = txtCNPJEdit.Text;
                modelo.DtFundacao = Convert.ToDateTime(txtDtFundacaoEdit.Text);
                modelo.Cargo = txtCargoEdit.Text;
                DALConexao dal = new DALConexao();
                BLLPessoa bll = new BLLPessoa(dal);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Dados cadastrados com sucesso!");
                }
                else
                {

                    bll.Alterar(modelo);
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
                dtEndereco.DataSource = "";
                dtEndereco.Refresh();
                dtEndereco.Update();
                tabControlBusca.SelectedTab = tabPageBusca;
                limpartela(tabPageCadastro.Controls);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void dtEndereco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            operacao = "editarEndereco";
            if (dtEndereco.SelectedRows.Count > 0)
            {
                btnNovoEndereco.Enabled = false;
                btnAdicionar.Enabled = true;
                cmbTipo.SelectedValue = Convert.ToInt32(dtEndereco.CurrentRow.Cells["TipoEnderecoId"].Value.ToString());
                txtCEPEdit.Text = dtEndereco.CurrentRow.Cells["CEP"].Value.ToString();
                txtEnderecoEdit.Text = dtEndereco.CurrentRow.Cells["Logradouro"].Value.ToString();
                txtNumeroEdit.Text = dtEndereco.CurrentRow.Cells["Numero"].Value.ToString();
                txtComplementoEdit.Text = dtEndereco.CurrentRow.Cells["Complemento"].Value.ToString();
                txtBairroEdit.Text = dtEndereco.CurrentRow.Cells["Bairro"].Value.ToString();
                txtCidadeEdit.Text = dtEndereco.CurrentRow.Cells["Cidade"].Value.ToString();
                txtEstadoEdit.Text = dtEndereco.CurrentRow.Cells["UF"].Value.ToString();
                btnAdicionar.Enabled = true;
                btnNovoEndereco.Enabled = true;
                btnExcluirEndereco.Enabled = true;
            }
        }

        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {
            operacao = "InserirEndereco";
            limpartelaEndereco(panelEndereco.Controls);
            btnAdicionar.Enabled = false;
            btnNovoEndereco.Enabled = true;
        }


        private void limpartelaEndereco(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco modelo = new Endereco();
                modelo.EnderecoId = Convert.ToInt32(dtEndereco.CurrentRow.Cells["EnderecoId"].Value);
                modelo.CPF = Convert.ToString(txtCpfEdit.Text);
                modelo.TipoEnderecoId = Convert.ToInt32(cmbTipo.SelectedValue);
                modelo.CEP = Convert.ToString(txtCEPEdit.Text);
                modelo.Logradouro = Convert.ToString(txtEnderecoEdit.Text);
                modelo.Numero = Convert.ToInt32(txtNumeroEdit.Text);
                modelo.Complemento = Convert.ToString(txtComplementoEdit.Text);
                modelo.Bairro = Convert.ToString(txtBairroEdit.Text);
                modelo.Cidade = Convert.ToString(txtCidadeEdit.Text);
                modelo.UF = Convert.ToString(txtEstadoEdit.Text);

                DALConexao dal = new DALConexao();
                BLLEndereco bll = new BLLEndereco(dal);

                if (this.operacao == "inserirEndereco")
                {
                    bll.Incluir(modelo);
                    limpartelaEndereco(panelEndereco.Controls);
                    CarregarEndereco();

                    MessageBox.Show("Dados cadastrados com sucesso!");
                }
                else if (this.operacao == "editarEndereco")
                {
                    bll.Alterar(modelo);
                    limpartelaEndereco(panelEndereco.Controls);
                    CarregarEndereco();
                    MessageBox.Show("Dados atualizados com sucesso!");
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

            finally
            {
                btnAdicionar.Enabled = false;
                btnNovoEndereco.Enabled = true;
                dtDados.Enabled = true;
            }

        }

        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            limpartelaEndereco(panelEndereco.Controls);
            btnAdicionar.Enabled = false;
            btnNovoEndereco.Enabled = true;
        }

        private void btnExcluirEndereco_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    BLLEndereco bll = new BLLEndereco(dal);

                    limpartelaEndereco(panelEndereco.Controls);
                    bll.Excluir(Convert.ToInt32(dtEndereco.CurrentRow.Cells["EnderecoId"].Value.ToString()));
                    CarregarEndereco();
                    btnExcluirEndereco.Enabled = false;

                }
            }
            catch
            {

                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outra operação");

            }
        }
    }
}
