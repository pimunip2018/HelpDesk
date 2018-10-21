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
    public partial class frmUsuarioBusca : Form
    {
        public frmUsuarioBusca()
        {
            InitializeComponent();
        }

        public string CPF = null;

        public void MostrarDados(string cpf, string nome)
        {

            DALConexao dal = new DALConexao();
            BLLUSuario bll = new BLLUSuario(dal);
            dtDados.DataSource = null;

            if (cpf == "")
            {
                cpf = null;
            }

            if (nome == "")
            {
                nome = null;
            }

            dtDados.DataSource = bll.Localizar(cpf, nome);


            if (dtDados.RowCount > 0)
            {
                dtDados.CurrentCell = dtDados.Rows[0].Cells[1];
            }


        }
        private void frmUsuarioBusca_Load(object sender, EventArgs e)
        {
            MostrarDados(txtCPF.Text, txtNome.Text);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            MostrarDados(txtCPF.Text, txtNome.Text);
        }

        private void dtDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CPF = dtDados.CurrentRow.Cells["CPF"].Value.ToString();
            this.Close();
        }
    }
}
