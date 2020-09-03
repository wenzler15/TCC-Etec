using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Login
{
    public partial class FrmPrincipal1 : Form
    {
        public FrmPrincipal1()
        {
            InitializeComponent();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora Calculadora1 = new Calculadora(); //Instancia
            Calculadora1.MdiParent = this; //Declarando como form filho
            Calculadora1.Show(); //Abrir form
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users us = new Users(); //instancia
            this.Hide(); //Fechando form
            us.ShowDialog(); //Exibindo form         
            }

        private void FrmPrincipal1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult click; //Evento se clicar
            click = MessageBox.Show("Deseja sair?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop); //exibir mensagem e botões
            if (click == DialogResult.No) //laço de decisão
            {
                e.Cancel = true; //cancelando o fechamento
            }
                         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora Calculadora1 = new Calculadora();
            Calculadora1.MdiParent = this;
            Calculadora1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TSSLHora.Text = DateTime.Now.ToString("dddd',dia ' d 'de' MMMM ' de ' yyyy - HH:mm:ss");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fornecedor o = new Fornecedor();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculadora Calculadora1 = new Calculadora();
            Calculadora1.MdiParent = this;
            Calculadora1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.MdiParent = this;
            caixa.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TabelaPreços o = new TabelaPreços();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Fornecedor o = new Fornecedor();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\ManualAdm.pdf");
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Cadastrar o = new Cadastrar();
            o.MdiParent = this;
            o.Show();
        }

        private void TSBEStoque_Click(object sender, EventArgs e)
        {
            Estoque o = new Estoque();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            Trabalho o = new Trabalho();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Agendamento o = new Agendamento();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            Buscar o = new Buscar();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton1_Click_4(object sender, EventArgs e)
        {
            Relatorio o = new Relatorio();
            o.MdiParent = this;
            o.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendario o = new Calendario();
            o.MdiParent = this;
            o.Show();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("notepad.exe");
            p.Start();
        }

        private void slaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://www.facebook.com/movv.hair.5?fref=ts");
            pStart.Start();
        }
    }
}
