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
    public partial class FrmLogin1 : Form
    {
        public FrmLogin1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fechando form
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fechando form
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
int erros=0; //declarando variavel de erro
        private void BtnEntrar_Click_1(object sender, EventArgs e)
        {

            string login,senha; //declarando variaveis login e senh
            

            login =Convert.ToString(TxtUsuario.Text); //ligando as variaveis a textbox
            senha = Convert.ToString(TxtSenha.Text);  //ligando as variaveis a textbox


            if (erros == 4) { //laço de decisão

                Application.Exit(); //fechando prog

            }

            if (login == "Bruno" && senha == "adm123") //laço de decisão
            {
                
                this.Close(); //fechando form
                FrmPrincipal1 prin = new FrmPrincipal1(); //instancia
                prin.Show(); //abrir form
            }
            else   { //Se não

                erros++; //Adicionar 1 a variavel erro

                MessageBox.Show("Você errou a senha " +erros+ " vez(es), o programa irá fechar!", "Atenção!",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Mensagem de texto
                
  
            }
            
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users voltar = new Users(); //instancia
            voltar.Show(); //instancia
            this.Close(); //fechar form
        }

        private void FrmLogin1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblusuario_Click_1(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

