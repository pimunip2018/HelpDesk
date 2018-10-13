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
    public partial class frmRelatorioUsuario : Form
    {
        public frmRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'help_deskDataSet.Pessoa' table. You can move, or remove it, as needed.
            this.PessoaTableAdapter.Fill(this.help_deskDataSet.Pessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
