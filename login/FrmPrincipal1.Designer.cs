namespace Login
{
    partial class FrmPrincipal1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMISair = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISobre = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBForn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBCaixa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTabPreços = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBCadastro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBEstoque = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTrabalho = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBAgendamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBRelatorio1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::Login.Properties.Resources.Sem_Título_1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISair,
            this.TSMISobre,
            this.manualToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.slaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // TSMISair
            // 
            this.TSMISair.BackgroundImage = global::Login.Properties.Resources.home;
            this.TSMISair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMISair.Name = "TSMISair";
            this.TSMISair.Size = new System.Drawing.Size(37, 20);
            this.TSMISair.Text = "      ";
            this.TSMISair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TSMISobre
            // 
            this.TSMISobre.ForeColor = System.Drawing.Color.White;
            this.TSMISobre.Name = "TSMISobre";
            this.TSMISobre.Size = new System.Drawing.Size(49, 20);
            this.TSMISobre.Text = "Sobre";
            this.TSMISobre.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.calendarioToolStripMenuItem.Text = "Calendário";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // slaToolStripMenuItem
            // 
            this.slaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.slaToolStripMenuItem.Image = global::Login.Properties.Resources.Facebook;
            this.slaToolStripMenuItem.Name = "slaToolStripMenuItem";
            this.slaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.slaToolStripMenuItem.Text = "Facebook";
            this.slaToolStripMenuItem.Click += new System.EventHandler(this.slaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImage = global::Login.Properties.Resources.Sem_Título_11;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSlUsuario,
            this.TSSLHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // TSSlUsuario
            // 
            this.TSSlUsuario.ForeColor = System.Drawing.Color.White;
            this.TSSlUsuario.Name = "TSSlUsuario";
            this.TSSlUsuario.Size = new System.Drawing.Size(186, 17);
            this.TSSlUsuario.Text = "Bruno Henrique E Marcelo Thiago";
            // 
            // TSSLHora
            // 
            this.TSSLHora.ForeColor = System.Drawing.Color.White;
            this.TSSLHora.Name = "TSSLHora";
            this.TSSLHora.Size = new System.Drawing.Size(33, 17);
            this.TSSLHora.Text = "Hora";
            this.TSSLHora.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBCalc,
            this.toolStripSeparator1,
            this.TSBForn,
            this.toolStripSeparator2,
            this.TSBCaixa,
            this.toolStripSeparator3,
            this.TSBTabPreços,
            this.toolStripSeparator6,
            this.TSBCadastro,
            this.toolStripSeparator7,
            this.TSBEstoque,
            this.toolStripSeparator5,
            this.TSBTrabalho,
            this.toolStripSeparator8,
            this.TSBAgendamento,
            this.toolStripSeparator4,
            this.TSBBuscar,
            this.toolStripSeparator9,
            this.TSBRelatorio1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 340);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(820, 82);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // TSBCalc
            // 
            this.TSBCalc.ForeColor = System.Drawing.Color.White;
            this.TSBCalc.Image = global::Login.Properties.Resources.calc;
            this.TSBCalc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCalc.Name = "TSBCalc";
            this.TSBCalc.Size = new System.Drawing.Size(74, 79);
            this.TSBCalc.Text = "Calculadora";
            this.TSBCalc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSBCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCalc.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBForn
            // 
            this.TSBForn.ForeColor = System.Drawing.Color.White;
            this.TSBForn.Image = global::Login.Properties.Resources.forn1;
            this.TSBForn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBForn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBForn.Name = "TSBForn";
            this.TSBForn.Size = new System.Drawing.Size(82, 79);
            this.TSBForn.Text = "Fornecedores";
            this.TSBForn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBForn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBCaixa
            // 
            this.TSBCaixa.ForeColor = System.Drawing.Color.White;
            this.TSBCaixa.Image = global::Login.Properties.Resources.CAXAX;
            this.TSBCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCaixa.Name = "TSBCaixa";
            this.TSBCaixa.Size = new System.Drawing.Size(64, 79);
            this.TSBCaixa.Text = "Caixa";
            this.TSBCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCaixa.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBTabPreços
            // 
            this.TSBTabPreços.ForeColor = System.Drawing.Color.White;
            this.TSBTabPreços.Image = global::Login.Properties.Resources.preços;
            this.TSBTabPreços.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTabPreços.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTabPreços.Name = "TSBTabPreços";
            this.TSBTabPreços.Size = new System.Drawing.Size(64, 79);
            this.TSBTabPreços.Text = "Preços";
            this.TSBTabPreços.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTabPreços.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBCadastro
            // 
            this.TSBCadastro.ForeColor = System.Drawing.Color.White;
            this.TSBCadastro.Image = global::Login.Properties.Resources.cadastrar;
            this.TSBCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCadastro.Name = "TSBCadastro";
            this.TSBCadastro.Size = new System.Drawing.Size(64, 79);
            this.TSBCadastro.Text = "Cadastro";
            this.TSBCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCadastro.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBEstoque
            // 
            this.TSBEstoque.ForeColor = System.Drawing.Color.White;
            this.TSBEstoque.Image = global::Login.Properties.Resources.estoque;
            this.TSBEstoque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEstoque.Name = "TSBEstoque";
            this.TSBEstoque.Size = new System.Drawing.Size(64, 79);
            this.TSBEstoque.Text = "Estoque";
            this.TSBEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBEstoque.Click += new System.EventHandler(this.TSBEStoque_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBTrabalho
            // 
            this.TSBTrabalho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSBTrabalho.ForeColor = System.Drawing.Color.White;
            this.TSBTrabalho.Image = global::Login.Properties.Resources.addtrab;
            this.TSBTrabalho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTrabalho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTrabalho.Name = "TSBTrabalho";
            this.TSBTrabalho.Size = new System.Drawing.Size(82, 79);
            this.TSBTrabalho.Text = "Add Trabalho";
            this.TSBTrabalho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTrabalho.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBAgendamento
            // 
            this.TSBAgendamento.ForeColor = System.Drawing.Color.White;
            this.TSBAgendamento.Image = global::Login.Properties.Resources.agendamentnens;
            this.TSBAgendamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAgendamento.Name = "TSBAgendamento";
            this.TSBAgendamento.Size = new System.Drawing.Size(87, 79);
            this.TSBAgendamento.Text = "Agendamento";
            this.TSBAgendamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBAgendamento.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBBuscar
            // 
            this.TSBBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSBBuscar.ForeColor = System.Drawing.Color.White;
            this.TSBBuscar.Image = global::Login.Properties.Resources.buscar;
            this.TSBBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBuscar.Name = "TSBBuscar";
            this.TSBBuscar.Size = new System.Drawing.Size(64, 79);
            this.TSBBuscar.Text = "Buscar";
            this.TSBBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBBuscar.Click += new System.EventHandler(this.toolStripButton1_Click_3);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // TSBRelatorio1
            // 
            this.TSBRelatorio1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSBRelatorio1.Image = global::Login.Properties.Resources.Relat;
            this.TSBRelatorio1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBRelatorio1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBRelatorio1.Name = "TSBRelatorio1";
            this.TSBRelatorio1.Size = new System.Drawing.Size(64, 79);
            this.TSBRelatorio1.Text = "Relatório";
            this.TSBRelatorio1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBRelatorio1.Click += new System.EventHandler(this.toolStripButton1_Click_4);
            // 
            // FrmPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Desktopcerto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 444);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal1_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMISair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSlUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem TSMISobre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBCalc;
        private System.Windows.Forms.ToolStripButton TSBForn;
        private System.Windows.Forms.ToolStripButton TSBCaixa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBTabPreços;
        private System.Windows.Forms.ToolStripStatusLabel TSSLHora;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TSBCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TSBEstoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSBTrabalho;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSBAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton TSBBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton TSBRelatorio1;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slaToolStripMenuItem;

    }
}

