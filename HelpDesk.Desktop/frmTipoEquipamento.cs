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
    public partial class frmTipoEquipamento : Form
    {
        public frmTipoEquipamento()
        {
            InitializeComponent();
        }
        DALConexao dal = new DALConexao();

        public int ID;
        public int TipoEquipamentoId = 0;
        public void MostrarDados()
        {
            BLLTipoEquipamento bll = new BLLTipoEquipamento(dal);


            dtDados.DataSource = bll.CarregarCombo("", 0);

            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];
            }


        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            MostrarDados();
        }
        
        private void dtDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dtDados.CurrentRow.Cells["TipoEquipamentoId"].Value.ToString());
            this.Close();
        }

        private void frmTipoEquipamento_Load(object sender, EventArgs e)
        {
            MostrarDados();
            EsconderColuna();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoEquipamento modelo = new TipoEquipamento();

                BLLTipoEquipamento bll = new BLLTipoEquipamento(dal);
                modelo.Descricao = txtDescricaoEdit.Text;
                modelo.TipoEquipamentoId = TipoEquipamentoId;
                if (TipoEquipamentoId <= 0)
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Os dados foram cadastrados com sucesso.");
                    limpartela(tabPageCadastro.Controls);
                    tabControlTipoEquipamento.SelectedTab = tabPageBusca;
                    TipoEquipamentoId = 0;
                    MostrarDados();
                }
                else
                {
                    bll.Alterar(modelo);
                    MessageBox.Show("Os dados foram alterados com sucesso.");
                    limpartela(tabPageCadastro.Controls);
                    tabControlTipoEquipamento.SelectedTab = tabPageBusca;
                    TipoEquipamentoId = 0;
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
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpartela(tabPageCadastro.Controls);
            tabControlTipoEquipamento.SelectedTab = tabPageCadastro;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoEquipamentoId = Convert.ToInt32(dtDados.CurrentRow.Cells["TipoEquipamentoId"].Value.ToString());
            txtDescricaoEdit.Text = dtDados.CurrentRow.Cells["Descricao"].Value.ToString();
            tabControlTipoEquipamento.SelectedTab = tabPageCadastro;
        }

        public void EsconderColuna()
        {
            dtDados.Columns["TipoEquipamentoId"].Visible = false;
        }

        private void dtDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtDados.Columns["Descricao"].Width = 350;
        }
    }
}
