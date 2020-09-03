namespace Login
{
    partial class AlterarCadastrar
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.mkbData = new System.Windows.Forms.MaskedTextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkbCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.mkbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(158, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // mkbData
            // 
            this.mkbData.Location = new System.Drawing.Point(154, 66);
            this.mkbData.Mask = "00/00/0000";
            this.mkbData.Name = "mkbData";
            this.mkbData.Size = new System.Drawing.Size(70, 20);
            this.mkbData.TabIndex = 1;
            this.mkbData.ValidatingType = typeof(System.DateTime);
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(91, 103);
            this.mkbTelefone.Mask = "0000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(62, 20);
            this.mkbTelefone.TabIndex = 2;
            // 
            // mkbCelular
            // 
            this.mkbCelular.Location = new System.Drawing.Point(82, 139);
            this.mkbCelular.Mask = "00000-0000";
            this.mkbCelular.Name = "mkbCelular";
            this.mkbCelular.Size = new System.Drawing.Size(71, 20);
            this.mkbCelular.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(73, 174);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(163, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(73, 210);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(151, 20);
            this.txtRua.TabIndex = 5;
            // 
            // mkbCEP
            // 
            this.mkbCEP.Location = new System.Drawing.Point(73, 236);
            this.mkbCEP.Mask = "00000-000";
            this.mkbCEP.Name = "mkbCEP";
            this.mkbCEP.Size = new System.Drawing.Size(63, 20);
            this.mkbCEP.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(144, 269);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(245, 258);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 8;
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
            this.BTNSair.Location = new System.Drawing.Point(492, 275);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 34;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(351, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 35;
            this.txtID.Visible = false;
            // 
            // AlterarCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.CADASTROTELA;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.mkbCEP);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.mkbCelular);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.mkbData);
            this.Controls.Add(this.txtCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarCadastrar";
            this.ShowIcon = false;
            this.Text = "AlterarCadastrar";
            this.Load += new System.EventHandler(this.AlterarCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.MaskedTextBox mkbData;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbCelular;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox mkbCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.TextBox txtID;
    }
}