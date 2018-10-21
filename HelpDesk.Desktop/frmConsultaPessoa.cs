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
        public int tipoPessoa;
        DALConexao dal = new DALConexao();

        public void MostrarDados(string cpf, string nome, int bloquado, int tipousuario, int sexo)
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

            dtDados.DataSource = bll.Localizar(cpf, nome, bloquado, tipousuario, sexo);
            EsconderColunaPessoa();
            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];
            }


        }
        public void EsconderColunaPessoa()
        {
            dtDados.Columns["SexoId"].Visible = false;
            dtDados.Columns["TelefoneCelular"].Visible = false;
            dtDados.Columns["Sexo"].Visible = false;
            dtDados.Columns["EstadoCivilId"].Visible = false;
            dtDados.Columns["EstadoCivil"].Visible = false;

        }

        public void EsconderColunaEndereco()
        {
            dtEndereco.Columns["EnderecoId"].Visible = false;
            dtEndereco.Columns["CPF"].Visible = false;
            dtEndereco.Columns["TipoEnderecoId"].Visible = false;
        }
        private void CarregarEndereco()
        {
            BLLEndereco bll = new BLLEndereco(dal);
            dtEndereco.DataSource = bll.CarregaEndereco(txtCpfEdit.Text);
            dtEndereco.Refresh();
            dtEndereco.Update();
            EsconderColunaEndereco();
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


        private void ValidarCampos(object obj)
        {
            var erros = ValidacaoCampos.getValidationErros(obj);
            foreach (var error in erros)
            {
                throw new Exception(error.ErrorMessage);
            }
        }

        private string GeraSenha()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "");

            Random clsRan = new Random();
            Int32 tamanhoSenha = clsRan.Next(6, 18);

            string senha = "";
            for (Int32 i = 0; i <= tamanhoSenha; i++)
            {
                senha += guid.Substring(clsRan.Next(1, guid.Length), 1);
            }

            return senha;
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedIndex), Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));

        }
        private void tabControlBusca_Click(object sender, EventArgs e)
        {
            
            if (tabControlBusca.SelectedTab == tabPageBusca)
            {
                btnNovo_Click(sender, e);

            }


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
        
        #region Botões da Busca
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
                txtTelefoneEmpresa.Text = dtDados.CurrentRow.Cells["TelefoneEmpresa"].Value.ToString();
                txtCelularEdit.Text = dtDados.CurrentRow.Cells["TelefoneCelular"].Value.ToString();
                txtEmailEdit.Text = dtDados.CurrentRow.Cells["Email"].Value.ToString();
                txtRazaoSocialEdit.Text = dtDados.CurrentRow.Cells["RazaoSocial"].Value.ToString();
                txtCNPJEdit.Text = dtDados.CurrentRow.Cells["CNPJ"].Value.ToString();
                txtDtFundacaoEdit.Text = dtDados.CurrentRow.Cells["DtFundacao"].Value.ToString();
                txtCargoEdit.Text = dtDados.CurrentRow.Cells["Cargo"].Value.ToString();

                this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedValue), Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));

                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];

                CarregarTipoEndereco();
                CarregarEndereco();
                if (dtEndereco.SelectedRows.Count > 0)
                {
                    btnSalvar.Enabled = true;
                }

                else
                {
                    btnSalvar.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro!");
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmTipoPessoa frm = new frmTipoPessoa();
            frm.ShowDialog();
            tipoPessoa = frm.tipoPessoa;
            operacao = "inserir";
            if (dtEndereco.SelectedRows.Count > 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
            tabControlBusca.SelectedTab = tabPageCadastro;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.MostrarDados(txtCpf.Text, txtNome.Text, Convert.ToInt32(cmbAtivo.SelectedIndex), Convert.ToInt32(cmbTipoUsuario.SelectedValue), Convert.ToInt32(cmbSexo.SelectedValue));
        }
        #endregion
        #region Carregar_Combos
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
        #endregion
        #region txt Somente Números
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
                        txtEnderecoEdit.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString().Trim() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();

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

        #endregion
        #region Botões do Cadastro
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa modelo = new Pessoa();

                modelo.CPF = txtCpfEdit.Text;
                modelo.Nome = txtNomeEdit.Text;
                modelo.DtNasc = Convert.ToDateTime(txtDtNascEdit.Text);
                modelo.Telefone = txtTelefoneEdit.Text;
                modelo.TelefoneEmpresa = txtTelefoneEmpresa.Text;
                modelo.Ramal = string.IsNullOrEmpty(txtRamalEdit.Text) ? default(int?) : Convert.ToInt32(txtRamalEdit.Text);
                modelo.TelefoneCelular = txtCelularEdit.Text;
                modelo.Email = txtEmailEdit.Text;
                modelo.SexoId = Convert.ToInt32(cmbSexoEdit.SelectedValue);
                modelo.EstadoCivilId = Convert.ToInt32(cmbEstadoCivil.SelectedValue);
                modelo.RazaoSocial = txtRazaoSocialEdit.Text;
                modelo.CNPJ = txtCNPJEdit.Text;
                modelo.DtFundacao = Convert.ToDateTime(txtDtFundacaoEdit.Text);
                modelo.Cargo = txtCargoEdit.Text;
                BLLPessoa bll = new BLLPessoa(dal);

                ValidarCampos(modelo);

                Usuario modelUser = new Usuario();

                modelUser.CPF = txtCpfEdit.Text;
                modelUser.TipoUsuarioId = tipoPessoa;
                modelUser.Senha = GeraSenha();

                BLLUSuario bllUser = new BLLUSuario(dal);

                if (this.operacao == "InserirEndereco")
                {
                    bll.Incluir(modelo);
                    bllUser.IncluirUsuario(modelUser);
                    this.operacao = "editar";
                }


                else if (this.operacao == "inserir")
                {
                    if (dtEndereco.SelectedRows.Count > 0)
                    {
                        bll.Incluir(modelo);
                        bllUser.IncluirUsuario(modelUser);
                        MessageBox.Show("Dados cadastrados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Cadastre pelo menos um endereço");
                        tabDados.SelectedTab =tabPageEndereco;
                    }
                    tabControlBusca.SelectedTab = tabPageBusca;
                    limpartela(tabPageCadastro.Controls);

                }
                else
                {
                    if (this.operacao == "editar" || this.operacao == "editarEndereco")
                    {
                        bll.Alterar(modelo);
                        MessageBox.Show("Dados atualizados com sucesso!");
                        tabControlBusca.SelectedTab = tabPageBusca;
                        limpartela(tabPageCadastro.Controls);
                    }

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco modelo = new Endereco();
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

                ValidarCampos(modelo);

                if (this.operacao == "InserirEndereco")
                {
                    btnSalvar_Click(sender, e);
                    bll.Incluir(modelo);
                    limpartelaEndereco(panelEndereco.Controls);
                    CarregarEndereco();
                    btnSalvar.Enabled = true;
                    MessageBox.Show("Dados cadastrados com sucesso!");
                }
                else if (this.operacao == "editarEndereco")
                {
                    modelo.EnderecoId = Convert.ToInt32(dtEndereco.CurrentRow.Cells["EnderecoId"].Value);
                    bll.Alterar(modelo);
                    limpartelaEndereco(panelEndereco.Controls);
                    CarregarEndereco();
                    btnSalvar.Enabled = true;
                    MessageBox.Show("Dados atualizados com sucesso!");
                }
                btnAdicionar.Enabled = false;
                btnNovoEndereco.Enabled = true;
                dtDados.Enabled = true;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }



        }
        private void btnCancelarEndereco_Click(object sender, EventArgs e)
        {
            limpartelaEndereco(panelEndereco.Controls);
            btnAdicionar.Enabled = false;
            btnNovoEndereco.Enabled = true;
        }
        private void btnNovoEndereco_Click(object sender, EventArgs e)
        {
            operacao = "InserirEndereco";
            limpartelaEndereco(panelEndereco.Controls);
            btnAdicionar.Enabled = true;
            btnNovoEndereco.Enabled = true;
            CarregarTipoEndereco();
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
        #endregion
        private void txtCpfEdit_Leave(object sender, EventArgs e)
        {
            if (txtCpfEdit != null)
            {
                if (ValidacaoCampos.IsCpf(txtCpfEdit.Text))
                {

                }
                else
                {
                    MessageBox.Show("CPF inválido.");
                }
            }

        }

        private void txtCNPJEdit_Leave(object sender, EventArgs e)
        {
            if (txtCNPJEdit != null)
            {
                if (ValidacaoCampos.IsCnpj(txtCNPJEdit.Text))
                {

                }
                else
                {
                    MessageBox.Show("CNPJ inválido.");
                }
            }
        }

        private void dtEndereco_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtEndereco.DefaultCellStyle.Font = new Font("Tohoma", 10);
            dtEndereco.Columns["CEP"].Width = 70;
            dtEndereco.Columns["Logradouro"].Width = 200;
            dtEndereco.Columns["Numero"].Width = 50;
            dtEndereco.Columns["Numero"].HeaderText = "Nº";
            dtEndereco.Columns["Complemento"].Width = 100;
            dtEndereco.Columns["Bairro"].Width = 100;
            dtEndereco.Columns["Cidade"].Width = 160;
            dtEndereco.Columns["UF"].Width = 30;
        }
    }

}
