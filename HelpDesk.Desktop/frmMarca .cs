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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        DALConexao dal = new DALConexao();

        public int ID;
        public int marcaId=0;
        public void MostrarDados()
        {
            BLLMarca bll = new BLLMarca(dal);


            dtDados.DataSource = bll.CarregarCombo("", 0);

            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];
            }


        }

        private void dtDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dtDados.CurrentRow.Cells["MarcaId"].Value.ToString());
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            MostrarDados();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            MostrarDados();
            EsconderColuna();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca modelo = new Marca();

                BLLMarca bll = new BLLMarca(dal);
                modelo.Descricao = txtDescricaoEdit.Text;
                modelo.MarcaId = marcaId;
                if(marcaId <=0)
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Os dados foram cadastrados com sucesso.");
                    limpartela(tabPageCadastro.Controls);
                    tabControlMarca.SelectedTab = tabPageBusca;
                    marcaId = 0;
                    MostrarDados();
                }
                else
                {
                    bll.Alterar(modelo);
                    MessageBox.Show("Os dados foram alterados com sucesso.");
                    limpartela(tabPageCadastro.Controls);
                    tabControlMarca.SelectedTab = tabPageBusca;
                    marcaId = 0;
                    MostrarDados();
                }
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            tabControlMarca.SelectedTab = tabPageBusca;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            marcaId= Convert.ToInt32(dtDados.CurrentRow.Cells["MarcaId"].Value.ToString());
            txtDescricaoEdit.Text = dtDados.CurrentRow.Cells["Descricao"].Value.ToString();
            tabControlMarca.SelectedTab = tabPageCadastro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpartela(tabPageCadastro.Controls);
            tabControlMarca.SelectedTab = tabPageCadastro;
        }

        public void EsconderColuna()
        {
            dtDados.Columns["MarcaId"].Visible = false;
        }

        private void dtDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtDados.Columns["Descricao"].Width = 350;
        }
    }
}
