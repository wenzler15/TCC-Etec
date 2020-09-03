namespace Login
{
    partial class Cadastrar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNSair = new System.Windows.Forms.Button();
            this.txtNCasa = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.mskTele = new System.Windows.Forms.MaskedTextBox();
            this.mkbData = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BTNSair);
            this.groupBox2.Controls.Add(this.txtNCasa);
            this.groupBox2.Controls.Add(this.mskCEP);
            this.groupBox2.Controls.Add(this.txtRua);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.mskCel);
            this.groupBox2.Controls.Add(this.mskTele);
            this.groupBox2.Controls.Add(this.mkbData);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.btnCadastrar);
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(448, 248);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 31;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click_1);
            // 
            // txtNCasa
            // 
            this.txtNCasa.Location = new System.Drawing.Point(107, 258);
            this.txtNCasa.Name = "txtNCasa";
            this.txtNCasa.Size = new System.Drawing.Size(48, 20);
            this.txtNCasa.TabIndex = 25;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(49, 223);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(74, 20);
            this.mskCEP.TabIndex = 24;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(61, 197);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(177, 20);
            this.txtRua.TabIndex = 23;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(61, 162);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(173, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // mskCel
            // 
            this.mskCel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCel.Location = new System.Drawing.Point(64, 127);
            this.mskCel.Mask = "00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(82, 20);
            this.mskCel.TabIndex = 21;
            // 
            // mskTele
            // 
            this.mskTele.Location = new System.Drawing.Point(72, 92);
            this.mskTele.Mask = "0000-0000";
            this.mskTele.Name = "mskTele";
            this.mskTele.Size = new System.Drawing.Size(74, 20);
            this.mskTele.TabIndex = 20;
            // 
            // mkbData
            // 
            this.mkbData.Location = new System.Drawing.Point(130, 56);
            this.mkbData.Mask = "00/00/0000";
            this.mkbData.Name = "mkbData";
            this.mkbData.Size = new System.Drawing.Size(74, 20);
            this.mkbData.TabIndex = 19;
            this.mkbData.ValidatingType = typeof(System.DateTime);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(98, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(136, 20);
            this.txtCliente.TabIndex = 18;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::Login.Properties.Resources.CADASTRARbtn;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(173, 258);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(65, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.CADASTROTELA;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastrar";
            this.ShowInTaskbar = false;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.TextBox txtNCasa;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.MaskedTextBox mskTele;
        private System.Windows.Forms.MaskedTextBox mkbData;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCadastrar;

    }
}