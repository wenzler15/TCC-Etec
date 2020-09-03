namespace Login
{
    partial class Alterar
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.BTNSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(115, 75);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(212, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(115, 112);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            this.txtID.Visible = false;
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(432, 169);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 33;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(221, 101);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.EstoqueTela;
            this.ClientSize = new System.Drawing.Size(490, 205);
            this.Controls.Add(this.BTNSair);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alterar";
            this.ShowIcon = false;
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.Click += new System.EventHandler(this.Alterar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.Button btnAlterar;
    }
}