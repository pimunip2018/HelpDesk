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
    public partial class frmHelpDesk : Form
    {
        public frmHelpDesk()
        {
            InitializeComponent();
        }
        private void btnPessoa_Click(object sender, EventArgs e)
        {
            frmConsultaPessoa frm = new frmConsultaPessoa();
            frm.ShowDialog();
        }

        private void ribbonButtonsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
