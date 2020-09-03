namespace Login
{
    partial class Relatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Caixa = new Login.DS_Caixa();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // CaixaBindingSource
            // 
            this.CaixaBindingSource.DataMember = "Caixa";
            this.CaixaBindingSource.DataSource = this.DS_Caixa;
            // 
            // DS_Caixa
            // 
            this.DS_Caixa.DataSetName = "DS_Caixa";
            this.DS_Caixa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CaixaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Login.RptCaixa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(54, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(621, 343);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::Login.Properties.Resources.CasaBranca2;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Location = new System.Drawing.Point(672, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(41, 38);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Relatório;
            this.ClientSize = new System.Drawing.Size(725, 430);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Caixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CaixaBindingSource;
        private DS_Caixa DS_Caixa;
        private System.Windows.Forms.Button btnVoltar;
    }
}