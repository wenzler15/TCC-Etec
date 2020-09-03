namespace Login
{
    partial class AlterarTrabalho
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
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.mkbPreco = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(90, 63);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(182, 20);
            this.txtServico.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(90, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(177, 87);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 77;
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
            this.BTNSair.Location = new System.Drawing.Point(419, 120);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(36, 33);
            this.BTNSair.TabIndex = 78;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // mkbPreco
            // 
            this.mkbPreco.Location = new System.Drawing.Point(90, 90);
            this.mkbPreco.Mask = "$000.00";
            this.mkbPreco.Name = "mkbPreco";
            this.mkbPreco.Size = new System.Drawing.Size(63, 20);
            this.mkbPreco.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Valor";
            // 
            // AlterarTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.AdicionarCert;
            this.ClientSize = new System.Drawing.Size(467, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mkbPreco);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarTrabalho";
            this.Text = "AlterarTrabalho";
            this.Load += new System.EventHandler(this.AlterarTrabalho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.MaskedTextBox mkbPreco;
        private System.Windows.Forms.Label label1;
    }
}