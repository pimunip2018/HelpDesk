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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

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


        private void button1_Click(object sender, EventArgs e)
        {
            MostrarDados(txtCPF.Text, txtNome.Text);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarDados(txtCPF.Text, txtNome.Text);
            EscondeColuna();
        }

        private void dtDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditarUsuario frm = new frmEditarUsuario();
            if (e.ColumnIndex == dtDados.Columns["bloqueado"].Index)
            {
                
                    
                //desabilitarCampo();

                if (dtDados.SelectedRows.Count > 0)
                {
                   

                    frm.lblCPFPessoa.Text= dtDados.CurrentRow.Cells["CPF"].Value.ToString();
                    frm.chkBloqueado.Checked= Convert.ToBoolean(dtDados.CurrentRow.Cells["Bloqueado"].Value.ToString());
                                        
                    dtDados.CurrentCell = dtDados.Rows[0].Cells[1];

                }

                frm.ShowDialog();
                MostrarDados(txtCPF.Text, txtNome.Text);
            }
        }

        public void EscondeColuna()
        {
            dtDados.Columns["Senha"].Visible = false;
        }
        private void dtDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dtDados.DefaultCellStyle.Font = new Font("Tohoma", 10);
            dtDados.Columns["Nome"].Width = 355;
            dtDados.Columns["CPF"].Width = 180;
            dtDados.Columns["bloqueado"].HeaderText="Bloqueado";
            
        }
    }
}
