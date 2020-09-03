namespace Login
{
    partial class AlterarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCaixa));
            this.BTNSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.mkbDia = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(449, 253);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(36, 33);
            this.BTNSair.TabIndex = 75;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Login.Properties.Resources.SalvarBranco;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Location = new System.Drawing.Point(200, 194);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 31);
            this.btnAlterar.TabIndex = 76;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(102, 123);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(151, 20);
            this.txtFinal.TabIndex = 77;
            // 
            // mkbDia
            // 
            this.mkbDia.Location = new System.Drawing.Point(102, 159);
            this.mkbDia.Mask = "00/00/0000";
            this.mkbDia.Name = "mkbDia";
            this.mkbDia.Size = new System.Drawing.Size(71, 20);
            this.mkbDia.TabIndex = 78;
            this.mkbDia.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 79;
            this.txtID.Visible = false;
            // 
            // AlterarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 304);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.mkbDia);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BTNSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterarCaixa";
            this.Text = "AlterarCaixa";
            this.Load += new System.EventHandler(this.AlterarCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.MaskedTextBox mkbDia;
        private System.Windows.Forms.TextBox txtID;
    }
}