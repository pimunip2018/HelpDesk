namespace HelpDesk.Desktop
{
    partial class frmEquipamento
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
            this.tabControlEquipamento = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtDados = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabPageEditar = new System.Windows.Forms.TabPage();
            this.cmbMarcaEdit = new System.Windows.Forms.ComboBox();
            this.cmbTipoEquipemantoEdit = new System.Windows.Forms.ComboBox();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnTipoEquipamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacaoEdit = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblIdentificacao = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTpEquipamento = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlEquipamento.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDados)).BeginInit();
            this.tabPageEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CADASTRO DE EQUIPAMENTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControlEquipamento
            // 
            this.tabControlEquipamento.Controls.Add(this.tabPageBusca);
            this.tabControlEquipamento.Controls.Add(this.tabPageEditar);
            this.tabControlEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEquipamento.Location = new System.Drawing.Point(12, 145);
            this.tabControlEquipamento.Name = "tabControlEquipamento";
            this.tabControlEquipamento.SelectedIndex = 0;
            this.tabControlEquipamento.Size = new System.Drawing.Size(776, 284);
            this.tabControlEquipamento.TabIndex = 1;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.btnEditar);
            this.tabPageBusca.Controls.Add(this.dtDados);
            this.tabPageBusca.Controls.Add(this.btnNovo);
            this.tabPageBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBusca.Location = new System.Drawing.Point(4, 25);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(768, 255);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
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
            this.btnEditar.Location = new System.Drawing.Point(688, 225);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 24);
            this.btnEditar.TabIndex = 34;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDados.Location = new System.Drawing.Point(-1, 0);
            this.dtDados.MultiSelect = false;
            this.dtDados.Name = "dtDados";
            this.dtDados.ReadOnly = true;
            this.dtDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDados.Size = new System.Drawing.Size(769, 219);
            this.dtDados.TabIndex = 40;
            this.dtDados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtDados_CellFormatting);
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
            this.btnNovo.Location = new System.Drawing.Point(596, 225);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 24);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabPageEditar
            // 
            this.tabPageEditar.Controls.Add(this.cmbMarcaEdit);
            this.tabPageEditar.Controls.Add(this.cmbTipoEquipemantoEdit);
            this.tabPageEditar.Controls.Add(this.cmbPessoa);
            this.tabPageEditar.Controls.Add(this.btnCancelar);
            this.tabPageEditar.Controls.Add(this.btnSalvar);
            this.tabPageEditar.Controls.Add(this.btnPessoa);
            this.tabPageEditar.Controls.Add(this.btnMarca);
            this.tabPageEditar.Controls.Add(this.btnTipoEquipamento);
            this.tabPageEditar.Controls.Add(this.label5);
            this.tabPageEditar.Controls.Add(this.label1);
            this.tabPageEditar.Controls.Add(this.label4);
            this.tabPageEditar.Controls.Add(this.label2);
            this.tabPageEditar.Controls.Add(this.txtDescricaoEdit);
            this.tabPageEditar.Controls.Add(this.label3);
            this.tabPageEditar.Controls.Add(this.txtIdentificacaoEdit);
            this.tabPageEditar.Controls.Add(this.pictureBox1);
            this.tabPageEditar.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditar.Name = "tabPageEditar";
            this.tabPageEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditar.Size = new System.Drawing.Size(768, 255);
            this.tabPageEditar.TabIndex = 1;
            this.tabPageEditar.Text = "Cadastro";
            this.tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // cmbMarcaEdit
            // 
            this.cmbMarcaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaEdit.FormattingEnabled = true;
            this.cmbMarcaEdit.Location = new System.Drawing.Point(345, 35);
            this.cmbMarcaEdit.Name = "cmbMarcaEdit";
            this.cmbMarcaEdit.Size = new System.Drawing.Size(226, 24);
            this.cmbMarcaEdit.TabIndex = 31;
            // 
            // cmbTipoEquipemantoEdit
            // 
            this.cmbTipoEquipemantoEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEquipemantoEdit.FormattingEnabled = true;
            this.cmbTipoEquipemantoEdit.Location = new System.Drawing.Point(6, 36);
            this.cmbTipoEquipemantoEdit.Name = "cmbTipoEquipemantoEdit";
            this.cmbTipoEquipemantoEdit.Size = new System.Drawing.Size(226, 24);
            this.cmbTipoEquipemantoEdit.TabIndex = 30;
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Location = new System.Drawing.Point(6, 144);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(571, 24);
            this.cmbPessoa.TabIndex = 29;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(532, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 24);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(437, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 24);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(583, 144);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(29, 23);
            this.btnPessoa.TabIndex = 11;
            this.btnPessoa.Text = "...";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(583, 36);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(29, 23);
            this.btnMarca.TabIndex = 10;
            this.btnMarca.Text = "...";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnTipoEquipamento
            // 
            this.btnTipoEquipamento.Location = new System.Drawing.Point(238, 36);
            this.btnTipoEquipamento.Name = "btnTipoEquipamento";
            this.btnTipoEquipamento.Size = new System.Drawing.Size(29, 23);
            this.btnTipoEquipamento.TabIndex = 7;
            this.btnTipoEquipamento.Text = "...";
            this.btnTipoEquipamento.UseVisualStyleBackColor = true;
            this.btnTipoEquipamento.Click += new System.EventHandler(this.btnTipoEquipamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pessoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Equipamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identificacao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // txtDescricaoEdit
            // 
            this.txtDescricaoEdit.Location = new System.Drawing.Point(6, 91);
            this.txtDescricaoEdit.Name = "txtDescricaoEdit";
            this.txtDescricaoEdit.Size = new System.Drawing.Size(311, 23);
            this.txtDescricaoEdit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descricao";
            // 
            // txtIdentificacaoEdit
            // 
            this.txtIdentificacaoEdit.Location = new System.Drawing.Point(345, 90);
            this.txtIdentificacaoEdit.Name = "txtIdentificacaoEdit";
            this.txtIdentificacaoEdit.Size = new System.Drawing.Size(232, 23);
            this.txtIdentificacaoEdit.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 110);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(226, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(280, 110);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(226, 21);
            this.cmbMarca.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(310, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.Location = new System.Drawing.Point(361, 62);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(232, 20);
            this.txtIdentificacao.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(632, 62);
            this.txtCPF.Mask = "000,000,00-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(152, 20);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblIdentificacao
            // 
            this.lblIdentificacao.AutoSize = true;
            this.lblIdentificacao.Location = new System.Drawing.Point(358, 46);
            this.lblIdentificacao.Name = "lblIdentificacao";
            this.lblIdentificacao.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificacao.TabIndex = 6;
            this.lblIdentificacao.Text = "Identificacao";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(629, 46);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // lblTpEquipamento
            // 
            this.lblTpEquipamento.AutoSize = true;
            this.lblTpEquipamento.Location = new System.Drawing.Point(13, 94);
            this.lblTpEquipamento.Name = "lblTpEquipamento";
            this.lblTpEquipamento.Size = new System.Drawing.Size(108, 13);
            this.lblTpEquipamento.TabIndex = 6;
            this.lblTpEquipamento.Text = "Tipo de Equipamento";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(277, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // btnBusca
            // 
            this.btnBusca.Image = global::HelpDesk.Desktop.Properties.Resources.localizar_pq_fw;
            this.btnBusca.Location = new System.Drawing.Point(745, 102);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(39, 29);
            this.btnBusca.TabIndex = 33;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelpDesk.Desktop.Properties.Resources.Novo;
            this.pictureBox1.Location = new System.Drawing.Point(618, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblIdentificacao);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTpEquipamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtIdentificacao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.tabControlEquipamento);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamento";
            this.Load += new System.EventHandler(this.frmEquipamento_Load);
            this.tabControlEquipamento.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDados)).EndInit();
            this.tabPageEditar.ResumeLayout(false);
            this.tabPageEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlEquipamento;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.TabPage tabPageEditar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblIdentificacao;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTpEquipamento;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnTipoEquipamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacaoEdit;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtDados;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cmbTipoEquipemantoEdit;
        private System.Windows.Forms.ComboBox cmbMarcaEdit;
        public System.Windows.Forms.TextBox txtDescricaoEdit;
    }
}