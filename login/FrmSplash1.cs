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
    public partial class FrmSplash1 : Form
    {
        public FrmSplash1()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            if (PBSplash.Value < 100)
            {
                PBSplash.Value += 5;
                
            }

            else
            {

               
                timer1.Enabled = false;
                this.Hide();
                Users us = new Users();
                us.ShowDialog();

                

                
                 }
                    }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           
        }
        }
    }

