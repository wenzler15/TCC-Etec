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
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }
        int erros = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string login, senha;


            login = Convert.ToString(TXTBUsuario.Text);
            senha = Convert.ToString(TXTBSenha.Text);


            if (erros == 4)
            {

                Application.Exit();

            }

            if (login == "funcionario" && senha == "func123")
            {
                this.Hide();
                FrmPrincipal2 prin2 = new FrmPrincipal2();
                prin2.ShowDialog();
                
            }
            else
            {

                erros++;

                MessageBox.Show("Você errou a senha " + erros + " vezes, o programa irá fechar!", "Atenção!",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login2_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users voltar = new Users();
            voltar.Show();
            this.Close();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {
           
        }
    }
}