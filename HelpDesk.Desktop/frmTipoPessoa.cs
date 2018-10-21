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
    public partial class frmTipoPessoa : Form
    {
        DALConexao dal = new DALConexao();

        public void CarregarTipoUsuario()
        {
            DALConexao dal = new DALConexao();
            BLLTipoUsuario bll = new BLLTipoUsuario(dal);
            cmbTipoUsuario.DataSource = bll.CarregarCombo("");
            cmbTipoUsuario.DisplayMember = "Descricao";
            cmbTipoUsuario.ValueMember = "TipoUsuarioId";
        }
        public frmTipoPessoa()
        {
            InitializeComponent();
        }
        public int tipoPessoa;

        private void btnCancelarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkTipo_Click(object sender, EventArgs e)
        {
            tipoPessoa = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
            this.Close();
        }

        private void frmTipoPessoa_Load(object sender, EventArgs e)
        {
            CarregarTipoUsuario();
        }
    }
}
