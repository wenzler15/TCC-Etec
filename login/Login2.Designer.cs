namespace Login
{
    partial class Login2
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
            this.TXTBUsuario = new System.Windows.Forms.TextBox();
            this.TXTBSenha = new System.Windows.Forms.TextBox();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.BTNSair = new System.Windows.Forms.Button();
            this.BTNVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTBUsuario
            // 
            this.TXTBUsuario.Location = new System.Drawing.Point(251, 198);
            this.TXTBUsuario.Name = "TXTBUsuario";
            this.TXTBUsuario.Size = new System.Drawing.Size(133, 20);
            this.TXTBUsuario.TabIndex = 16;
            // 
            // TXTBSenha
            // 
            this.TXTBSenha.Location = new System.Drawing.Point(251, 235);
            this.TXTBSenha.Name = "TXTBSenha";
            this.TXTBSenha.Size = new System.Drawing.Size(133, 20);
            this.TXTBSenha.TabIndex = 18;
            this.TXTBSenha.UseSystemPasswordChar = true;
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.BackColor = System.Drawing.Color.Transparent;
            this.BTNEntrar.BackgroundImage = global::Login.Properties.Resources.Entrar2;
            this.BTNEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNEntrar.Location = new System.Drawing.Point(181, 273);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(75, 28);
            this.BTNEntrar.TabIndex = 19;
            this.BTNEntrar.UseVisualStyleBackColor = false;
            this.BTNEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.SAER2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.Location = new System.Drawing.Point(262, 273);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(75, 28);
            this.BTNSair.TabIndex = 20;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNVoltar
            // 
            this.BTNVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BTNVoltar.BackgroundImage = global::Login.Properties.Resources.voltar3;
            this.BTNVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNVoltar.Location = new System.Drawing.Point(343, 273);
            this.BTNVoltar.Name = "BTNVoltar";
            this.BTNVoltar.Size = new System.Drawing.Size(75, 28);
            this.BTNVoltar.TabIndex = 21;
            this.BTNVoltar.UseVisualStyleBackColor = false;
            this.BTNVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.LOGIN2CERTO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 324);
            this.Controls.Add(this.BTNVoltar);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.BTNEntrar);
            this.Controls.Add(this.TXTBSenha);
            this.Controls.Add(this.TXTBUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login2";
            this.Load += new System.EventHandler(this.Login2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBUsuario;
        private System.Windows.Forms.TextBox TXTBSenha;
        private System.Windows.Forms.Button BTNEntrar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.Button BTNVoltar;
    }
}