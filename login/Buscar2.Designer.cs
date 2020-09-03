namespace Login
{
    partial class Buscar2
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.dgCadastro = new System.Windows.Forms.DataGridView();
            this.CTMSCadastro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.mkbBuscar2 = new System.Windows.Forms.MaskedTextBox();
            this.dgAgendamento = new System.Windows.Forms.DataGridView();
            this.CTMSAgendamento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).BeginInit();
            this.CTMSCadastro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamento)).BeginInit();
            this.CTMSAgendamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Location = new System.Drawing.Point(921, 474);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(45, 39);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.btnBuscar1);
            this.tabPage1.Controls.Add(this.txtBuscar1);
            this.tabPage1.Controls.Add(this.dgCadastro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar1.Location = new System.Drawing.Point(258, 7);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar1.TabIndex = 2;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(6, 9);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar1.TabIndex = 1;
            // 
            // dgCadastro
            // 
            this.dgCadastro.AllowUserToAddRows = false;
            this.dgCadastro.AllowUserToDeleteRows = false;
            this.dgCadastro.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadastro.ContextMenuStrip = this.CTMSCadastro;
            this.dgCadastro.Location = new System.Drawing.Point(0, 35);
            this.dgCadastro.Name = "dgCadastro";
            this.dgCadastro.ReadOnly = true;
            this.dgCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCadastro.Size = new System.Drawing.Size(944, 403);
            this.dgCadastro.TabIndex = 0;
            this.dgCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadastro_CellContentClick);
            // 
            // CTMSCadastro
            // 
            this.CTMSCadastro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.eToolStripMenuItem});
            this.CTMSCadastro.Name = "contextMenuStrip1";
            this.CTMSCadastro.Size = new System.Drawing.Size(110, 48);
            this.CTMSCadastro.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.eToolStripMenuItem.Text = "Excluir";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnBuscar2);
            this.tabPage2.Controls.Add(this.mkbBuscar2);
            this.tabPage2.Controls.Add(this.dgAgendamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agendamento";
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar2.Location = new System.Drawing.Point(82, 4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar2.TabIndex = 2;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // mkbBuscar2
            // 
            this.mkbBuscar2.Location = new System.Drawing.Point(6, 6);
            this.mkbBuscar2.Mask = "00/00/0000";
            this.mkbBuscar2.Name = "mkbBuscar2";
            this.mkbBuscar2.Size = new System.Drawing.Size(70, 20);
            this.mkbBuscar2.TabIndex = 1;
            this.mkbBuscar2.ValidatingType = typeof(System.DateTime);
            // 
            // dgAgendamento
            // 
            this.dgAgendamento.AllowUserToAddRows = false;
            this.dgAgendamento.AllowUserToDeleteRows = false;
            this.dgAgendamento.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendamento.ContextMenuStrip = this.CTMSAgendamento;
            this.dgAgendamento.Location = new System.Drawing.Point(0, 32);
            this.dgAgendamento.Name = "dgAgendamento";
            this.dgAgendamento.ReadOnly = true;
            this.dgAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAgendamento.Size = new System.Drawing.Size(944, 396);
            this.dgAgendamento.TabIndex = 0;
            // 
            // CTMSAgendamento
            // 
            this.CTMSAgendamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem1,
            this.excluirToolStripMenuItem});
            this.CTMSAgendamento.Name = "contextMenuStrip2";
            this.CTMSAgendamento.Size = new System.Drawing.Size(110, 48);
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.alterarToolStripMenuItem1.Text = "Alterar";
            this.alterarToolStripMenuItem1.Click += new System.EventHandler(this.alterarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // Buscar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar2";
            this.ShowIcon = false;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadastro)).EndInit();
            this.CTMSCadastro.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamento)).EndInit();
            this.CTMSAgendamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgCadastro;
        private System.Windows.Forms.DataGridView dgAgendamento;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.MaskedTextBox mkbBuscar2;
        private System.Windows.Forms.ContextMenuStrip CTMSCadastro;
        private System.Windows.Forms.ContextMenuStrip CTMSAgendamento;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}