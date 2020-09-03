namespace Login
{
    partial class AlterarFornecedor
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
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(440, 218);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(36, 33);
            this.BTNSair.TabIndex = 76;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(177, 100);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(140, 20);
            this.txtFornecedor.TabIndex = 77;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(177, 135);
            this.mkbTelefone.Mask = "0000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(61, 20);
            this.mkbTelefone.TabIndex = 78;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(177, 171);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(299, 20);
            this.txtProduto.TabIndex = 79;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(260, 129);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 80;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Location = new System.Drawing.Point(177, 74);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodFornecedor.TabIndex = 81;
            this.txtCodFornecedor.Visible = false;
            // 
            // AlterarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.yo;
            this.ClientSize = new System.Drawing.Size(488, 263);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.mkbTelefone);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.BTNSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarFornecedor";
            this.Text = "AlterarFornecedor";
            this.Load += new System.EventHandler(this.AlterarFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtCodFornecedor;
    }
}