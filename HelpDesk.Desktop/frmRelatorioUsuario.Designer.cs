namespace HelpDesk.Desktop
{
    partial class frmRelatorioUsuario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.help_deskDataSet = new HelpDesk.Desktop.help_deskDataSet();
            this.PessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PessoaTableAdapter = new HelpDesk.Desktop.help_deskDataSetTableAdapters.PessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.help_deskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PessoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HelpDesk.Desktop.rptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(960, 524);
            this.reportViewer1.TabIndex = 0;
            // 
            // help_deskDataSet
            // 
            this.help_deskDataSet.DataSetName = "help_deskDataSet";
            this.help_deskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PessoaBindingSource
            // 
            this.PessoaBindingSource.DataMember = "Pessoa";
            this.PessoaBindingSource.DataSource = this.help_deskDataSet;
            // 
            // PessoaTableAdapter
            // 
            this.PessoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioUsuario";
            this.Text = "frmRelatorioUsuario";
            this.Load += new System.EventHandler(this.frmRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.help_deskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PessoaBindingSource;
        private help_deskDataSet help_deskDataSet;
        private help_deskDataSetTableAdapters.PessoaTableAdapter PessoaTableAdapter;
    }
}