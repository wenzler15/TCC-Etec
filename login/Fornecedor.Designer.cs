namespace Login
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.BTNSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(254, 119);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 28);
            this.btnSalvar.TabIndex = 74;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(132, 87);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(187, 20);
            this.txtFornecedor.TabIndex = 73;
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(390, 19);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 75;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.mkbTelefone);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.BTNSair);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 236);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Location = new System.Drawing.Point(132, 124);
            this.mkbTelefone.Mask = "0000-0000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(62, 20);
            this.mkbTelefone.TabIndex = 77;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(132, 162);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(285, 20);
            this.txtProduto.TabIndex = 76;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fornecedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.TextBox txtProduto;
    }
}