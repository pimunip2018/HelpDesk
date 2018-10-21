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
    public partial class frmEquipamento : Form
    {
        public frmEquipamento()
        {
            InitializeComponent();
        }

        DALConexao dal = new DALConexao();
        public int EquipamentoId = 0;

        public void MostrarDados()
        {
            string descricao, cpf, identificacao;
            DALConexao dal = new DALConexao();
            BLLEquipamento bll = new BLLEquipamento(dal);
            Equipamento modelo = new Equipamento();

            cpf = string.IsNullOrEmpty(txtCPF.Text) ? default(string) : null;
            descricao = string.IsNullOrEmpty(txtDescricao.Text) ? default(string) : null;
            identificacao = string.IsNullOrEmpty(txtIdentificacao.Text) ? default(string) : null;
            modelo.MarcaId = Convert.ToInt32(cmbMarca.SelectedValue);
            modelo.TipoEquipamentoId = Convert.ToInt32(cmbTipo.SelectedValue);

            dtDados.DataSource = bll.Localizar(cpf, descricao, identificacao, Convert.ToInt32(cmbMarca.SelectedValue), Convert.ToInt32(cmbTipo.SelectedValue));


            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells["descricao"];
            }

        }

        private void frmEquipamento_Load(object sender, EventArgs e)
        {
            CarregarMarca(cmbMarca, 0);
            CarregarTipoEquipamento(cmbTipo, 0);
            MostrarDados();
            EsconderColuna();
        }

        public void EsconderColuna()
        {
            dtDados.Columns["EquipamentoId"].Visible = false;
            dtDados.Columns["TipoEquipamentoId"].Visible = false;
            dtDados.Columns["MarcaId"].Visible = false;

        }

        private void dtDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtDados.DefaultCellStyle.Font = new Font("Tohoma", 10);
            dtDados.Columns["TipoEquipamento"].Width = 150;
            dtDados.Columns["TipoEquipamento"].HeaderText = "Tipo";
            dtDados.Columns["Marca"].Width = 100;
            dtDados.Columns["Descricao"].Width = 250;
            dtDados.Columns["Identificacao"].Width = 250;
        }

        public void CarregarTipoEquipamento(ComboBox cmb, int id)
        {
            BLLTipoEquipamento bll = new BLLTipoEquipamento(dal);
            cmb.DataSource = bll.CarregarCombo("", id);
            cmb.DisplayMember = "Descricao";
            cmb.ValueMember = "TipoEquipamentoId";

        }

        public void CarregarMarca(ComboBox cmb, int id)
        {
            BLLMarca bll = new BLLMarca(dal);
            cmb.DataSource = bll.CarregarCombo("", id);
            cmb.DisplayMember = "Descricao";
            cmb.ValueMember = "MarcaId";
        }

        public void CarregarPessoa(ComboBox cmb, string cpf)
        {
            BLLUSuario bll = new BLLUSuario(dal);
            cmb.DataSource = bll.Localizar(cpf,"");
            cmb.DisplayMember = "Nome";
            cmb.ValueMember = "CPF";
        }

        private void btnTipoEquipamento_Click(object sender, EventArgs e)
        {
            frmTipoEquipamento frm = new frmTipoEquipamento();
            frm.ShowDialog();
            CarregarTipoEquipamento(cmbTipoEquipemantoEdit, frm.ID);
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.ShowDialog();
            CarregarMarca(cmbMarcaEdit, frm.ID);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Equipamento modelo = new Equipamento();

                BLLEquipamento bll = new BLLEquipamento(dal);
                modelo.TipoEquipamentoId = Convert.ToInt32(cmbTipoEquipemantoEdit.SelectedValue);
                modelo.MarcaId = Convert.ToInt32(cmbMarcaEdit.SelectedValue);
                modelo.Descricao = txtDescricaoEdit.Text;
                modelo.Identificacao = txtIdentificacaoEdit.Text;
                modelo.EquipamentoId = EquipamentoId;
                if (cmbPessoa.SelectedValue != null)
                {
                    modelo.CPF = cmbPessoa.SelectedValue.ToString();
                }


                if (EquipamentoId <= 0)
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Os dados foram cadastrados com sucesso.");
                    limpartela(tabPageEditar.Controls);
                    tabControlEquipamento.SelectedTab = tabPageBusca;
                    EquipamentoId = 0;
                    MostrarDados();
                }
                else
                {
                    bll.Alterar(modelo);
                    MessageBox.Show("Os dados foram alterados com sucesso.");
                    limpartela(tabPageEditar.Controls);
                    tabControlEquipamento.SelectedTab = tabPageBusca;
                    EquipamentoId = 0;
                    MostrarDados();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
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

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControlEquipamento.SelectedTab = tabPageBusca;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpartela(tabPageEditar.Controls);
            cmbPessoa.DataSource = null;
            cmbMarcaEdit.DataSource = null;
            cmbTipoEquipemantoEdit.DataSource = null;
            tabControlEquipamento.SelectedTab = tabPageEditar;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            EquipamentoId = Convert.ToInt32(dtDados.CurrentRow.Cells["EquipamentoId"].Value.ToString());
            txtDescricaoEdit.Text = dtDados.CurrentRow.Cells["Descricao"].Value.ToString();
            txtIdentificacaoEdit.Text = dtDados.CurrentRow.Cells["Identificacao"].Value.ToString();
            CarregarMarca(cmbMarcaEdit, Convert.ToInt32(dtDados.CurrentRow.Cells["MarcaId"].Value.ToString()));
            CarregarTipoEquipamento(cmbTipoEquipemantoEdit, Convert.ToInt32(dtDados.CurrentRow.Cells["TipoEquipamentoId"].Value.ToString()));
            cmbPessoa.SelectedValue = dtDados.CurrentRow.Cells["Usuario"].Value.ToString();
            tabControlEquipamento.SelectedTab = tabPageEditar;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            MostrarDados();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            frmUsuarioBusca frm = new frmUsuarioBusca();
            frm.ShowDialog();
            CarregarPessoa(cmbPessoa, frm.CPF);

        }
    }
}
