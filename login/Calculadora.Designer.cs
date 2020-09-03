namespace Login
{
    partial class Calculadora
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
            this.BTNDividir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNSair = new System.Windows.Forms.Button();
            this.TXTBTotalDesconto = new System.Windows.Forms.TextBox();
            this.TXTBTotalPorcentagem = new System.Windows.Forms.TextBox();
            this.BTNPorcentagem = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.TXTBTotal = new System.Windows.Forms.TextBox();
            this.TXTBValor2 = new System.Windows.Forms.TextBox();
            this.TXTBValor1 = new System.Windows.Forms.TextBox();
            this.BTNSubtrair = new System.Windows.Forms.Button();
            this.BTNMultiplicar = new System.Windows.Forms.Button();
            this.BTNSomar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNDividir
            // 
            this.BTNDividir.BackgroundImage = global::Login.Properties.Resources.preto3;
            this.BTNDividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNDividir.Location = new System.Drawing.Point(194, 68);
            this.BTNDividir.Name = "BTNDividir";
            this.BTNDividir.Size = new System.Drawing.Size(35, 31);
            this.BTNDividir.TabIndex = 13;
            this.BTNDividir.UseVisualStyleBackColor = true;
            this.BTNDividir.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTNSair);
            this.groupBox1.Controls.Add(this.TXTBTotalDesconto);
            this.groupBox1.Controls.Add(this.TXTBTotalPorcentagem);
            this.groupBox1.Controls.Add(this.BTNPorcentagem);
            this.groupBox1.Controls.Add(this.BTNLimpar);
            this.groupBox1.Controls.Add(this.TXTBTotal);
            this.groupBox1.Controls.Add(this.TXTBValor2);
            this.groupBox1.Controls.Add(this.TXTBValor1);
            this.groupBox1.Controls.Add(this.BTNSubtrair);
            this.groupBox1.Controls.Add(this.BTNMultiplicar);
            this.groupBox1.Controls.Add(this.BTNSomar);
            this.groupBox1.Controls.Add(this.BTNDividir);
            this.groupBox1.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(32, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(270, 408);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(46, 33);
            this.BTNSair.TabIndex = 30;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.button7_Click);
            // 
            // TXTBTotalDesconto
            // 
            this.TXTBTotalDesconto.Location = new System.Drawing.Point(94, 294);
            this.TXTBTotalDesconto.Name = "TXTBTotalDesconto";
            this.TXTBTotalDesconto.Size = new System.Drawing.Size(145, 28);
            this.TXTBTotalDesconto.TabIndex = 29;
            // 
            // TXTBTotalPorcentagem
            // 
            this.TXTBTotalPorcentagem.Location = new System.Drawing.Point(94, 225);
            this.TXTBTotalPorcentagem.Name = "TXTBTotalPorcentagem";
            this.TXTBTotalPorcentagem.Size = new System.Drawing.Size(145, 28);
            this.TXTBTotalPorcentagem.TabIndex = 26;
            // 
            // BTNPorcentagem
            // 
            this.BTNPorcentagem.BackgroundImage = global::Login.Properties.Resources.preto4;
            this.BTNPorcentagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNPorcentagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNPorcentagem.Location = new System.Drawing.Point(273, 25);
            this.BTNPorcentagem.Name = "BTNPorcentagem";
            this.BTNPorcentagem.Size = new System.Drawing.Size(43, 74);
            this.BTNPorcentagem.TabIndex = 1;
            this.BTNPorcentagem.UseVisualStyleBackColor = true;
            this.BTNPorcentagem.Click += new System.EventHandler(this.button6_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.BackgroundImage = global::Login.Properties.Resources.limpar2;
            this.BTNLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNLimpar.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpar.Location = new System.Drawing.Point(213, 114);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(81, 28);
            this.BTNLimpar.TabIndex = 23;
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // TXTBTotal
            // 
            this.TXTBTotal.Location = new System.Drawing.Point(94, 114);
            this.TXTBTotal.Name = "TXTBTotal";
            this.TXTBTotal.Size = new System.Drawing.Size(94, 28);
            this.TXTBTotal.TabIndex = 22;
            this.TXTBTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TXTBValor2
            // 
            this.TXTBValor2.Location = new System.Drawing.Point(94, 70);
            this.TXTBValor2.Name = "TXTBValor2";
            this.TXTBValor2.Size = new System.Drawing.Size(94, 28);
            this.TXTBValor2.TabIndex = 19;
            // 
            // TXTBValor1
            // 
            this.TXTBValor1.Location = new System.Drawing.Point(94, 27);
            this.TXTBValor1.Name = "TXTBValor1";
            this.TXTBValor1.Size = new System.Drawing.Size(94, 28);
            this.TXTBValor1.TabIndex = 18;
            // 
            // BTNSubtrair
            // 
            this.BTNSubtrair.BackgroundImage = global::Login.Properties.Resources.preto2;
            this.BTNSubtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSubtrair.Location = new System.Drawing.Point(235, 68);
            this.BTNSubtrair.Name = "BTNSubtrair";
            this.BTNSubtrair.Size = new System.Drawing.Size(35, 31);
            this.BTNSubtrair.TabIndex = 16;
            this.BTNSubtrair.UseVisualStyleBackColor = true;
            this.BTNSubtrair.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BTNMultiplicar
            // 
            this.BTNMultiplicar.BackgroundImage = global::Login.Properties.Resources.preto5;
            this.BTNMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNMultiplicar.Location = new System.Drawing.Point(235, 26);
            this.BTNMultiplicar.Name = "BTNMultiplicar";
            this.BTNMultiplicar.Size = new System.Drawing.Size(35, 31);
            this.BTNMultiplicar.TabIndex = 15;
            this.BTNMultiplicar.UseVisualStyleBackColor = true;
            this.BTNMultiplicar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNSomar
            // 
            this.BTNSomar.BackgroundImage = global::Login.Properties.Resources.preto1;
            this.BTNSomar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSomar.Location = new System.Drawing.Point(194, 27);
            this.BTNSomar.Name = "BTNSomar";
            this.BTNSomar.Size = new System.Drawing.Size(35, 31);
            this.BTNSomar.TabIndex = 14;
            this.BTNSomar.UseVisualStyleBackColor = true;
            this.BTNSomar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.CALCMDS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 20);
            this.Name = "Calculadora";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculadora_FormClosing);
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNDividir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTBTotal;
        private System.Windows.Forms.TextBox TXTBValor2;
        private System.Windows.Forms.TextBox TXTBValor1;
        private System.Windows.Forms.Button BTNSubtrair;
        private System.Windows.Forms.Button BTNMultiplicar;
        private System.Windows.Forms.Button BTNSomar;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNPorcentagem;
        private System.Windows.Forms.TextBox TXTBTotalPorcentagem;
        private System.Windows.Forms.TextBox TXTBTotalDesconto;
        private System.Windows.Forms.Button BTNSair;

    }
}