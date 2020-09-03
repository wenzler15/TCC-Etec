using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class TabelaPreços : Form
    {
        public TabelaPreços()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabelaPreços_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (RBMasc.Checked)
            {
                total += 15.00;
                LBFinal.Items.Add("Corte Masculino");
            }
            if (RBFeminino.Checked)
            {
                total += 20.00;
                LBFinal.Items.Add("Corte Feminino");
            }
            if (RBEscovaP.Checked)
            {
                total += 25.00;
                LBFinal.Items.Add("Escova P");
            }
            if (RBEscovaM.Checked)
            {
                total += 35.00;
                LBFinal.Items.Add("Escova M");
            }
            if (RBEscovaG.Checked)
            {
                total += 45.00;
                LBFinal.Items.Add("Escova G");
            }
            if (RBEscovaGG.Checked)
            {
                total += 55.00;
                LBFinal.Items.Add("Escova GG");
            }
            if (CB1.Checked)
            {
                total += 10.00;
                LBFinal.Items.Add("Limpeza Sobrancelha");
            }
            if (CB2.Checked)
            {
                total += 10.00;
                LBFinal.Items.Add("Design Sobracelha");
            }
            if (CB3.Checked)
            {
                total += 60.00;
                LBFinal.Items.Add("Botox");
            }
            if (CB4.Checked)
            {
                total += 70.00;
                LBFinal.Items.Add("Selagem");
            }
            if (CB5.Checked)
            {
                total += 70.00;
                LBFinal.Items.Add("Progressiva");
            }
            if (CB6.Checked)
            {
                total += 50.00;
                LBFinal.Items.Add("Reconstrução");
            }
            if (CB7.Checked)
            {
                total += 40.00;
                LBFinal.Items.Add("Cauterização");
            }
            if (CB8.Checked)
            {
                total += 30.00;
                LBFinal.Items.Add("Hidratação");
            }
            if (CB12.Checked)
            {
                total += 50.00;
                LBFinal.Items.Add("Penteado");
            }
            if (CB13.Checked)
            {
                total += 120.00;
                LBFinal.Items.Add("Luzes touca");
            }
            if (CB14.Checked)
            {
                total += 130.00;
                LBFinal.Items.Add("Ombre Hair");
            }
            if (CB15.Checked)
            {
                total += 15.00;
                LBFinal.Items.Add("Mechas");
            }
            if (CB9.Checked)
            {
                total += 50.00;
                LBFinal.Items.Add("Coloração");
            }
            if (CB10.Checked)
            {
                total += 25.00;
                LBFinal.Items.Add("Lavagem");
            }
            if (CB11.Checked)
            {
                total += 50.00;
                LBFinal.Items.Add("Matização");
            }
            LBFinal.Items.Add("------------------------------------------");
            TXTBTotal.Text = Convert.ToString("R$ "+total+".00 ");
       }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TXTBTotal.Clear();
            LBFinal.Items.Clear();
            RBMasc.Checked = false;
            RBFeminino.Checked = false;
            RBEscovaP.Checked = false;
            RBEscovaM.Checked = false;
            RBEscovaG.Checked = false;
            RBEscovaGG.Checked = false;
            CB1.Checked = false;
            CB2.Checked = false;
            CB3.Checked = false;
            CB4.Checked = false;
            CB5.Checked = false;
            CB6.Checked = false;
            CB7.Checked = false;
            CB8.Checked = false;
            CB12.Checked = false;
            CB13.Checked = false;
            CB14.Checked = false;
            CB15.Checked = false;
            CB9.Checked = false;
            CB10.Checked = false;
            CB11.Checked = false;
             }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void RBMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}