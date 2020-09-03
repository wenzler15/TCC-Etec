namespace Login
{
    partial class AlterarAgendamento
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.mkbData = new System.Windows.Forms.MaskedTextBox();
            this.mkbHora = new System.Windows.Forms.MaskedTextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(287, 27);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(296, 111);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(558, 185);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 35;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // mkbData
            // 
            this.mkbData.Location = new System.Drawing.Point(106, 49);
            this.mkbData.Mask = "00/00/0000";
            this.mkbData.Name = "mkbData";
            this.mkbData.Size = new System.Drawing.Size(70, 20);
            this.mkbData.TabIndex = 36;
            this.mkbData.ValidatingType = typeof(System.DateTime);
            // 
            // mkbHora
            // 
            this.mkbHora.Location = new System.Drawing.Point(106, 85);
            this.mkbHora.Mask = "00:00";
            this.mkbHora.Name = "mkbHora";
            this.mkbHora.Size = new System.Drawing.Size(38, 20);
            this.mkbHora.TabIndex = 37;
            this.mkbHora.ValidatingType = typeof(System.DateTime);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(106, 111);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 38;
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(106, 149);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(121, 21);
            this.cboServico.TabIndex = 39;
            // 
            // AlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.AgendamentoCerto;
            this.ClientSize = new System.Drawing.Size(616, 230);
            this.Controls.Add(this.cboServico);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.mkbHora);
            this.Controls.Add(this.mkbData);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarAgendamento";
            this.Text = "AlterarAgendamento";
            this.Load += new System.EventHandler(this.AlterarAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.MaskedTextBox mkbData;
        private System.Windows.Forms.MaskedTextBox mkbHora;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboServico;
    }
}