namespace HelpDesk.Desktop
{
    partial class frmTipoPessoa
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelarTipo = new System.Windows.Forms.Button();
            this.btnOkTipo = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tipo de Pessoa:";
            // 
            // btnCancelarTipo
            // 
            this.btnCancelarTipo.Location = new System.Drawing.Point(170, 94);
            this.btnCancelarTipo.Name = "btnCancelarTipo";
            this.btnCancelarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarTipo.TabIndex = 2;
            this.btnCancelarTipo.Text = "Cancelar";
            this.btnCancelarTipo.UseVisualStyleBackColor = true;
            this.btnCancelarTipo.Click += new System.EventHandler(this.btnCancelarTipo_Click);
            // 
            // btnOkTipo
            // 
            this.btnOkTipo.Location = new System.Drawing.Point(74, 94);
            this.btnOkTipo.Name = "btnOkTipo";
            this.btnOkTipo.Size = new System.Drawing.Size(75, 23);
            this.btnOkTipo.TabIndex = 2;
            this.btnOkTipo.Text = "OK";
            this.btnOkTipo.UseVisualStyleBackColor = true;
            this.btnOkTipo.Click += new System.EventHandler(this.btnOkTipo_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(124, 31);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUsuario.TabIndex = 1;
            // 
            // frmTipoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.btnCancelarTipo);
            this.Controls.Add(this.btnOkTipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Name = "frmTipoPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipoi de Pessoa";
            this.Load += new System.EventHandler(this.frmTipoPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelarTipo;
        private System.Windows.Forms.Button btnOkTipo;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
    }
}