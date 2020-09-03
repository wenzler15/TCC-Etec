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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double v1, v2, div; //Definindo variaveis
            v1 = Convert.ToDouble(TXTBValor1.Text); //Atribuindo txt a variavel
            v2 = Convert.ToDouble(TXTBValor2.Text); //Atribuindo txt a variavel
            div = v1 / v2; //Operação lógica

            TXTBTotal.Text = Convert.ToString(div); //Exibindo total
            TXTBValor1.Clear(); //Limpar txt
            TXTBValor2.Clear(); //Limpar txt
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double v1, v2,soma; //Definindo variaveis
            v1 = Convert.ToDouble(TXTBValor1.Text); //Atribuindo txt a variavel
            v2 = Convert.ToDouble(TXTBValor2.Text); //Atribuindo txt a variavel
            soma = v1 + v2; //Operação logica

            TXTBTotal.Text = Convert.ToString(soma); //Exibindo total
            TXTBValor1.Clear(); //Limpar txt
            TXTBValor2.Clear(); //Limpar txt
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, v2, mult; //Definindo variaveis
            v1 = Convert.ToDouble(TXTBValor1.Text); //Atribuindo txt a variavel
            v2 = Convert.ToDouble(TXTBValor2.Text); //Atribuindo txt a variavel
            mult = v1 * v2; //Operação logica
            
            TXTBTotal.Text = Convert.ToString(mult); //Exibindo total
            TXTBValor1.Clear(); //Limpar txt
            TXTBValor2.Clear(); //Limpar txt
        }

        private void button3_Click_1(object sender, EventArgs e) 
        {
            double v1, v2, sub; //Declarando variaveis
            v1 = Convert.ToDouble(TXTBValor1.Text); //Atribuindo txt a variavel
            v2 = Convert.ToDouble(TXTBValor2.Text); //Atribuindo txt a variavel
            sub = v1 - v2; //Operação logica

            TXTBTotal.Text = Convert.ToString(sub); //Exibir total
            TXTBValor1.Clear(); //Limpar txt
            TXTBValor2.Clear(); //Limpar txt
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TXTBValor1.Clear(); //Limpar caixa 
            TXTBValor2.Clear(); //Limpar caixa
            TXTBTotal.Clear(); //Limpar caixa
            TXTBTotalPorcentagem.Clear(); //Limpar caixa
            TXTBTotalDesconto.Clear(); //Limpar caixa
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double v1, v2, soma,porc,total; //Declarando variaveis
            v1 = Convert.ToDouble(TXTBTotal.Text); //Atribuindo txt a variavel
            v2 = Convert.ToDouble(TXTBTotalPorcentagem.Text); //Atribuindo txt a variavel
            soma = v1/100; //Operação logica
            porc = soma * v2; //Operação logica
            total = v1 - porc; //Operação logica
            TXTBTotalDesconto.Text = Convert.ToString(total); //Exibir total
            TXTBValor1.Clear(); //Limpar caixa
            TXTBValor2.Clear(); //Limpar caixa
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void button8_Click(object sender, EventArgs e)
        {
           FrmPrincipal1 Voltar = new FrmPrincipal1(); //Instancia
            Voltar.Show();
            }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void lblvalor1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
    }

