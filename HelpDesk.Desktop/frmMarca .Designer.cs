namespace HelpDesk.Desktop
{
    partial class frmMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabControlMarca = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtDados = new System.Windows.Forms.DataGridView();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.btnCancelarEdit = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricaoEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tabControlMarca.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDados)).BeginInit();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(506, 42);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MARCA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 59);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 76);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(432, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // tabControlMarca
            // 
            this.tabControlMarca.Controls.Add(this.tabPageBusca);
            this.tabControlMarca.Controls.Add(this.tabPageCadastro);
            this.tabControlMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMarca.Location = new System.Drawing.Point(16, 116);
            this.tabControlMarca.Name = "tabControlMarca";
            this.tabControlMarca.SelectedIndex = 0;
            this.tabControlMarca.Size = new System.Drawing.Size(478, 201);
            this.tabControlMarca.TabIndex = 4;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.btnNovo);
            this.tabPageBusca.Controls.Add(this.btnEditar);
            this.tabPageBusca.Controls.Add(this.dtDados);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 25);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(470, 172);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(288, 145);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 24);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(387, 145);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 24);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtDados
            // 
            this.dtDados.AllowUserToAddRows = false;
            this.dtDados.AllowUserToDeleteRows = false;
            this.dtDados.AllowUserToResizeColumns = false;
            this.dtDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDados.Location = new System.Drawing.Point(0, 0);
            this.dtDados.MultiSelect = false;
            this.dtDados.Name = "dtDados";
            this.dtDados.ReadOnly = true;
            this.dtDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDados.Size = new System.Drawing.Size(467, 139);
            this.dtDados.TabIndex = 41;
            this.dtDados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDados_CellContentDoubleClick);
            this.dtDados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtDados_CellFormatting);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.btnCancelarEdit);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Controls.Add(this.txtDescricaoEdit);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(470, 172);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEdit
            // 
            this.btnCancelarEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelarEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelarEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEdit.Location = new System.Drawing.Point(384, 142);
            this.btnCancelarEdit.Name = "btnCancelarEdit";
            this.btnCancelarEdit.Size = new System.Drawing.Size(80, 24);
            this.btnCancelarEdit.TabIndex = 29;
            this.btnCancelarEdit.Text = "Cancelar";
            this.btnCancelarEdit.UseVisualStyleBackColor = false;
            this.btnCancelarEdit.Click += new System.EventHandler(this.btnCancelarEdit_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(289, 142);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 24);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricaoEdit
            // 
            this.txtDescricaoEdit.Location = new System.Drawing.Point(6, 35);
            this.txtDescricaoEdit.Name = "txtDescricaoEdit";
            this.txtDescricaoEdit.Size = new System.Drawing.Size(458, 23);
            this.txtDescricaoEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descricao";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::HelpDesk.Desktop.Properties.Resources.localizar_pq_fw;
            this.btnBusca.Location = new System.Drawing.Point(451, 67);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(39, 29);
            this.btnBusca.TabIndex = 34;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 329);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.tabControlMarca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Equipamento";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.tabControlMarca.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDados)).EndInit();
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TabControl tabControlMarca;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.DataGridView dtDados;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TextBox txtDescricaoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnCancelarEdit;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
    }
}