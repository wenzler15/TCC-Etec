namespace Login
{
    partial class Agendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendamento));
            this.BTNSair = new System.Windows.Forms.Button();
            this.mkbHorario = new System.Windows.Forms.MaskedTextBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.btnAdcAgendamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkbData = new System.Windows.Forms.MaskedTextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSair
            // 
            this.BTNSair.BackColor = System.Drawing.Color.Transparent;
            this.BTNSair.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.BTNSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSair.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSair.Location = new System.Drawing.Point(542, 157);
            this.BTNSair.Name = "BTNSair";
            this.BTNSair.Size = new System.Drawing.Size(36, 33);
            this.BTNSair.TabIndex = 74;
            this.BTNSair.UseVisualStyleBackColor = false;
            this.BTNSair.Click += new System.EventHandler(this.BTNSair_Click);
            // 
            // mkbHorario
            // 
            this.mkbHorario.Location = new System.Drawing.Point(71, 72);
            this.mkbHorario.Mask = "00:00";
            this.mkbHorario.Name = "mkbHorario";
            this.mkbHorario.Size = new System.Drawing.Size(37, 20);
            this.mkbHorario.TabIndex = 2;
            this.mkbHorario.ValidatingType = typeof(System.DateTime);
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(71, 132);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(182, 21);
            this.cboServico.TabIndex = 7;
            // 
            // btnAdcAgendamento
            // 
            this.btnAdcAgendamento.BackgroundImage = global::Login.Properties.Resources.addbtn;
            this.btnAdcAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdcAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcAgendamento.Location = new System.Drawing.Point(152, 68);
            this.btnAdcAgendamento.Name = "btnAdcAgendamento";
            this.btnAdcAgendamento.Size = new System.Drawing.Size(101, 24);
            this.btnAdcAgendamento.TabIndex = 9;
            this.btnAdcAgendamento.UseVisualStyleBackColor = true;
            this.btnAdcAgendamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.mkbData);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.BTNSair);
            this.groupBox1.Controls.Add(this.btnAdcAgendamento);
            this.groupBox1.Controls.Add(this.cboServico);
            this.groupBox1.Controls.Add(this.mkbHorario);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mkbData
            // 
            this.mkbData.Location = new System.Drawing.Point(71, 39);
            this.mkbData.Mask = "00/00/0000";
            this.mkbData.Name = "mkbData";
            this.mkbData.Size = new System.Drawing.Size(70, 20);
            this.mkbData.TabIndex = 77;
            this.mkbData.ValidatingType = typeof(System.DateTime);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(71, 98);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(182, 21);
            this.cboCliente.TabIndex = 75;
            // 
            // Agendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 220);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendamento";
            this.ShowInTaskbar = false;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Agendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSair;
        private System.Windows.Forms.MaskedTextBox mkbHorario;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.Button btnAdcAgendamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.MaskedTextBox mkbData;
    }
}