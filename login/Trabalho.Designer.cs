namespace Login
{
    partial class Trabalho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabalho));
            this.txtServico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mkbPreco = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(61, 51);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(198, 20);
            this.txtServico.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mkbPreco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTNSair);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtServico);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(404, 101);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(30, 24);
            this.BTNSair.TabIndex = 76;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::Login.Properties.Resources.addbtn;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Location = new System.Drawing.Point(184, 101);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Valor";
            // 
            // mkbPreco
            // 
            this.mkbPreco.Location = new System.Drawing.Point(61, 79);
            this.mkbPreco.Mask = "$000.00";
            this.mkbPreco.Name = "mkbPreco";
            this.mkbPreco.Size = new System.Drawing.Size(60, 20);
            this.mkbPreco.TabIndex = 78;
            // 
            // Trabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 150);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trabalho";
            this.ShowInTaskbar = false;
            this.Text = "Trabalho";
            this.Load += new System.EventHandler(this.Trabalho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.MaskedTextBox mkbPreco;
        private System.Windows.Forms.Label label1;
    }
}