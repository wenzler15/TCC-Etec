namespace Login
{
    partial class FrmPrincipal2
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
            this.TSMISair = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSLFunc = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBForn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTabPreços = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBAgendamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBBuscar = new System.Windows.Forms.ToolStripButton();
            this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMISair
            // 
            this.TSMISair.BackgroundImage = global::Login.Properties.Resources.home1;
            this.TSMISair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMISair.Name = "TSMISair";
            this.TSMISair.Size = new System.Drawing.Size(37, 20);
            this.TSMISair.Text = "      ";
            this.TSMISair.Click += new System.EventHandler(this.TSMISair_Click);
            // 
            // TSMISobre
            // 
            this.TSMISobre.ForeColor = System.Drawing.Color.White;
            this.TSMISobre.Name = "TSMISobre";
            this.TSMISobre.Size = new System.Drawing.Size(49, 20);
            this.TSMISobre.Text = "Sobre";
            this.TSMISobre.Click += new System.EventHandler(this.TSMISobre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::Login.Properties.Resources.Sem_Título_12;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMISair,
            this.TSMISobre,
            this.manualToolStripMenuItem,
            this.calendárioToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // TSSLFunc
            // 
            this.TSSLFunc.ForeColor = System.Drawing.Color.White;
            this.TSSLFunc.Name = "TSSLFunc";
            this.TSSLFunc.Size = new System.Drawing.Size(70, 17);
            this.TSSLFunc.Text = "Funcionário";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImage = global::Login.Properties.Resources.Sem_Título_12;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLFunc,
            this.TSSLHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // TSSLHora
            // 
            this.TSSLHora.ForeColor = System.Drawing.Color.White;
            this.TSSLHora.Name = "TSSLHora";
            this.TSSLHora.Size = new System.Drawing.Size(33, 17);
            this.TSSLHora.Text = "Hora";
            this.TSSLHora.Click += new System.EventHandler(this.TSSLHora_Click);
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
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBCalc,
            this.toolStripSeparator1,
            this.TSBForn,
            this.toolStripSeparator2,
            this.TSBTabPreços,
            this.toolStripSeparator3,
            this.TSBAgendamento,
            this.toolStripSeparator4,
            this.TSBBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 290);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(718, 82);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBCalc
            // 
            this.TSBCalc.Image = global::Login.Properties.Resources.azul;
            this.TSBCalc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCalc.Name = "TSBCalc";
            this.TSBCalc.Size = new System.Drawing.Size(74, 79);
            this.TSBCalc.Text = "Calculadora";
            this.TSBCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBCalc.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 82);
            // 
            // TSBForn
            // 
            this.TSBForn.Image = global::Login.Properties.Resources.Cadastazul;
            this.TSBForn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBForn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBForn.Name = "TSBForn";
            this.TSBForn.Size = new System.Drawing.Size(64, 79);
            this.TSBForn.Text = "Cadastro";
            this.TSBForn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBForn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 82);
            // 
            // TSBTabPreços
            // 
            this.TSBTabPreços.Image = global::Login.Properties.Resources.preços1;
            this.TSBTabPreços.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTabPreços.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTabPreços.Name = "TSBTabPreços";
            this.TSBTabPreços.Size = new System.Drawing.Size(99, 79);
            this.TSBTabPreços.Text = "Tabela de Preços";
            this.TSBTabPreços.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTabPreços.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 82);
            // 
            // TSBAgendamento
            // 
            this.TSBAgendamento.Image = global::Login.Properties.Resources.agendaaazul;
            this.TSBAgendamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAgendamento.Name = "TSBAgendamento";
            this.TSBAgendamento.Size = new System.Drawing.Size(87, 79);
            this.TSBAgendamento.Text = "Agendamento";
            this.TSBAgendamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBAgendamento.Click += new System.EventHandler(this.TSBAgendamento_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 82);
            // 
            // TSBBuscar
            // 
            this.TSBBuscar.Image = global::Login.Properties.Resources.buscarazul;
            this.TSBBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBuscar.Name = "TSBBuscar";
            this.TSBBuscar.Size = new System.Drawing.Size(64, 79);
            this.TSBBuscar.Text = "Buscar";
            this.TSBBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBBuscar.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // calendárioToolStripMenuItem
            // 
            this.calendárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
            this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.calendárioToolStripMenuItem.Text = "Calendário";
            this.calendárioToolStripMenuItem.Click += new System.EventHandler(this.calendárioToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // FrmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Desktop2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 394);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal2_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal2_Load);
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

        private System.Windows.Forms.ToolStripMenuItem TSMISair;
        private System.Windows.Forms.ToolStripMenuItem TSMISobre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLFunc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBForn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBTabPreços;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSBBuscar;
        private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
    }
}