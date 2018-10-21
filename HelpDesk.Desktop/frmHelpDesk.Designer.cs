namespace HelpDesk.Desktop
{
    partial class frmHelpDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpDesk));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonUpDown1 = new System.Windows.Forms.RibbonUpDown();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelPessoa = new System.Windows.Forms.RibbonPanel();
            this.btnPessoa = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelEquipamento = new System.Windows.Forms.RibbonPanel();
            this.btnEquipamentos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelFuncao = new System.Windows.Forms.RibbonPanel();
            this.btnFuncao = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonTabHelpDesk = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelAbertura = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelGerenciamento = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonGerenciamento = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelHistorico = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonHistorico = new System.Windows.Forms.RibbonButton();
            this.ribbonTabSobre = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelSair = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonsair = new System.Windows.Forms.RibbonButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Name = "ribbonItemGroup1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = null;
            // 
            // ribbonUpDown1
            // 
            this.ribbonUpDown1.Name = "ribbonUpDown1";
            this.ribbonUpDown1.TextBoxText = "";
            this.ribbonUpDown1.TextBoxWidth = 50;
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItems.Add(this.ribbonOrbRecentItem1);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 92);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(894, 90);
            this.ribbon1.TabIndex = 5;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTabHelpDesk);
            this.ribbon1.Tabs.Add(this.ribbonTabSobre);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.ribbon1.TabSpacing = 4;
            this.ribbon1.Text = "ribbonMenu";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.LargeImage")));
            this.ribbonOrbRecentItem1.Name = "ribbonOrbRecentItem1";
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "ribbonOrbRecentItem1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanelPessoa);
            this.ribbonTab1.Panels.Add(this.ribbonPanelEquipamento);
            this.ribbonTab1.Panels.Add(this.ribbonPanelFuncao);
            this.ribbonTab1.Text = "Cadastro";
            // 
            // ribbonPanelPessoa
            // 
            this.ribbonPanelPessoa.Items.Add(this.btnPessoa);
            this.ribbonPanelPessoa.Name = "ribbonPanelPessoa";
            this.ribbonPanelPessoa.Text = "PESSOA";
            // 
            // btnPessoa
            // 
            this.btnPessoa.Image = ((System.Drawing.Image)(resources.GetObject("btnPessoa.Image")));
            this.btnPessoa.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPessoa.LargeImage")));
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPessoa.SmallImage")));
            this.btnPessoa.Text = "Pessoa";
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // ribbonPanelEquipamento
            // 
            this.ribbonPanelEquipamento.Items.Add(this.btnEquipamentos);
            this.ribbonPanelEquipamento.Name = "ribbonPanelEquipamento";
            this.ribbonPanelEquipamento.Text = "Equipamentos";
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.Image")));
            this.btnEquipamentos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.LargeImage")));
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.SmallImage")));
            this.btnEquipamentos.Text = "ribbonButton1";
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // ribbonPanelFuncao
            // 
            this.ribbonPanelFuncao.Items.Add(this.btnFuncao);
            this.ribbonPanelFuncao.Name = "ribbonPanelFuncao";
            this.ribbonPanelFuncao.Text = "Função";
            // 
            // btnFuncao
            // 
            this.btnFuncao.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncao.Image")));
            this.btnFuncao.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFuncao.LargeImage")));
            this.btnFuncao.Name = "btnFuncao";
            this.btnFuncao.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFuncao.SmallImage")));
            this.btnFuncao.Text = "ribbonButton2";
            this.btnFuncao.Click += new System.EventHandler(this.btnFuncao_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Consulta";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Relatório";
            // 
            // ribbonTabHelpDesk
            // 
            this.ribbonTabHelpDesk.Name = "ribbonTabHelpDesk";
            this.ribbonTabHelpDesk.Panels.Add(this.ribbonPanelAbertura);
            this.ribbonTabHelpDesk.Panels.Add(this.ribbonPanelGerenciamento);
            this.ribbonTabHelpDesk.Panels.Add(this.ribbonPanelHistorico);
            this.ribbonTabHelpDesk.Text = "HelpDesk";
            // 
            // ribbonPanelAbertura
            // 
            this.ribbonPanelAbertura.Items.Add(this.ribbonButton1);
            this.ribbonPanelAbertura.Name = "ribbonPanelAbertura";
            this.ribbonPanelAbertura.Text = "Abertura";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonPanelGerenciamento
            // 
            this.ribbonPanelGerenciamento.Items.Add(this.ribbonButtonGerenciamento);
            this.ribbonPanelGerenciamento.Name = "ribbonPanelGerenciamento";
            this.ribbonPanelGerenciamento.Text = "Gerenciamento";
            // 
            // ribbonButtonGerenciamento
            // 
            this.ribbonButtonGerenciamento.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGerenciamento.Image")));
            this.ribbonButtonGerenciamento.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGerenciamento.LargeImage")));
            this.ribbonButtonGerenciamento.Name = "ribbonButtonGerenciamento";
            this.ribbonButtonGerenciamento.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGerenciamento.SmallImage")));
            this.ribbonButtonGerenciamento.Text = "ribbonButton2";
            // 
            // ribbonPanelHistorico
            // 
            this.ribbonPanelHistorico.Items.Add(this.ribbonButtonHistorico);
            this.ribbonPanelHistorico.Name = "ribbonPanelHistorico";
            this.ribbonPanelHistorico.Text = "Histórico";
            // 
            // ribbonButtonHistorico
            // 
            this.ribbonButtonHistorico.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHistorico.Image")));
            this.ribbonButtonHistorico.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHistorico.LargeImage")));
            this.ribbonButtonHistorico.Name = "ribbonButtonHistorico";
            this.ribbonButtonHistorico.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHistorico.SmallImage")));
            this.ribbonButtonHistorico.Text = "Histórico";
            // 
            // ribbonTabSobre
            // 
            this.ribbonTabSobre.Name = "ribbonTabSobre";
            this.ribbonTabSobre.Panels.Add(this.ribbonPanelSair);
            this.ribbonTabSobre.Text = "Sobre";
            // 
            // ribbonPanelSair
            // 
            this.ribbonPanelSair.Items.Add(this.ribbonButtonsair);
            this.ribbonPanelSair.Name = "ribbonPanelSair";
            this.ribbonPanelSair.Text = "Sair";
            // 
            // ribbonButtonsair
            // 
            this.ribbonButtonsair.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonsair.Image")));
            this.ribbonButtonsair.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonsair.LargeImage")));
            this.ribbonButtonsair.Name = "ribbonButtonsair";
            this.ribbonButtonsair.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonsair.SmallImage")));
            this.ribbonButtonsair.Text = "Sair";
            this.ribbonButtonsair.Click += new System.EventHandler(this.ribbonButtonsair_Click);
            // 
            // frmHelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 601);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHelpDesk";
            this.Text = "HELP-DESK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHelpDesk_Load);
            this.Resize += new System.EventHandler(this.frmHelpDesk_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonUpDown ribbonUpDown1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonPanel ribbonPanelPessoa;
        private System.Windows.Forms.RibbonButton btnPessoa;
        private System.Windows.Forms.RibbonPanel ribbonPanelEquipamento;
        private System.Windows.Forms.RibbonButton btnEquipamentos;
        private System.Windows.Forms.RibbonPanel ribbonPanelFuncao;
        private System.Windows.Forms.RibbonButton btnFuncao;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTabHelpDesk;
        private System.Windows.Forms.RibbonPanel ribbonPanelAbertura;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanelGerenciamento;
        private System.Windows.Forms.RibbonButton ribbonButtonGerenciamento;
        private System.Windows.Forms.RibbonPanel ribbonPanelHistorico;
        private System.Windows.Forms.RibbonButton ribbonButtonHistorico;
        private System.Windows.Forms.RibbonTab ribbonTabSobre;
        private System.Windows.Forms.RibbonPanel ribbonPanelSair;
        private System.Windows.Forms.RibbonButton ribbonButtonsair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}