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
    public partial class Load1 : Form
    {
        public Load1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
                label1.Text = "Carregando..." + " " + progressBar1.Value + "%";
            }
            else
            {
                label1.Text = "Carregado";
                    this.Close();
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            Load1 Load1 = new Load1();
            Load1.ShowDialog();

            FrmLogin Form = new FrmLogin();
            Form.ShowDialog();

            MessageBox.Show("Bem Vindo!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
