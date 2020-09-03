namespace Login
{
    partial class FrmLogin1
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
            this.BTNSair = new System.Windows.Forms.Button();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BTNVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.saer;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.Location = new System.Drawing.Point(264, 274);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(75, 28);
            this.BTNSair.TabIndex = 12;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.BackColor = System.Drawing.Color.Transparent;
            this.BTNEntrar.BackgroundImage = global::Login.Properties.Resources.Entrar1;
            this.BTNEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNEntrar.Location = new System.Drawing.Point(183, 274);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(75, 28);
            this.BTNEntrar.TabIndex = 11;
            this.BTNEntrar.UseVisualStyleBackColor = false;
            this.BTNEntrar.Click += new System.EventHandler(this.BtnEntrar_Click_1);
            this.BTNEntrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnEntrar_KeyPress);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(260, 235);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(143, 20);
            this.TxtSenha.TabIndex = 8;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(260, 195);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(143, 20);
            this.TxtUsuario.TabIndex = 7;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // BTNVoltar
            // 
            this.BTNVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BTNVoltar.BackgroundImage = global::Login.Properties.Resources.VOLTAR;
            this.BTNVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNVoltar.Location = new System.Drawing.Point(345, 274);
            this.BTNVoltar.Name = "BTNVoltar";
            this.BTNVoltar.Size = new System.Drawing.Size(75, 28);
            this.BTNVoltar.TabIndex = 14;
            this.BTNVoltar.UseVisualStyleBackColor = false;
            this.BTNVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.DESKTOPCERTO2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 324);
            this.Controls.Add(this.BTNVoltar);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.BTNEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.Button BTNEntrar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BTNVoltar;

    }
}