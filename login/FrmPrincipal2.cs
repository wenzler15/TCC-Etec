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
    public partial class FrmPrincipal2 : Form
    {
        public FrmPrincipal2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculadora Calculadora1 = new Calculadora();

            Calculadora1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabelaPreços preços = new TabelaPreços();

            preços.Show();
        }

        private void LBLhora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TSSLHora.Text = DateTime.Now.ToString("dddd',dia ' d 'de' MMMM ' de ' yyyy - HH:mm:ss");
        }

        private void FrmPrincipal2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult click;
            click = MessageBox.Show("Deseja sair?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            Application.Exit();
            if (click == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cadastrar o = new Cadastrar();
            o.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Calculadora o = new Calculadora();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Cadastrar o = new Cadastrar();
            o.MdiParent = this;
            o.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TabelaPreços o = new TabelaPreços();
            o.MdiParent = this;
            o.Show();
        }

        private void TSMISobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void TSMISair_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            this.Hide();
            us.ShowDialog();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\ManualFunc.pdf");
        }

        private void TSBAgendamento_Click(object sender, EventArgs e)
        {
            Agendamento o = new Agendamento();
            o.MdiParent = this;
            o.Show();
    }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void TSSLHora_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Buscar2 o = new Buscar2(); 
            o.MdiParent = this;
            o.Show();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}