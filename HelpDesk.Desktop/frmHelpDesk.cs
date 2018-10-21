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
            if (Application.OpenForms.OfType<frmUsuarios>().Count() > 0)
            {
                frm.Focus();
            }
            else
            {

                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void ribbonButtonsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            frmEquipamento frm = new frmEquipamento();
            if (Application.OpenForms.OfType<frmUsuarios>().Count() > 0)
            {
                frm.Focus();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void frmHelpDesk_Resize(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Help_Manager;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmHelpDesk_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();

            if (Application.OpenForms.OfType<frmUsuarios>().Count() > 0)
            {
                frm.Focus();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }

        }
    }
}
