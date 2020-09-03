using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão
            Conn.Open(); //Abrindo conexão

            string sql = "Select * FROM Cadastro where NomeCliente= '" + txtCliente.Text + "' and Numero_Casa= '" + txtNCasa.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)
                try
                {

                    String SQL; //Nomeando SQL como String
                    SQL = "Insert into Cadastro(NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP) Values ('" + txtCliente.Text + "','" + mkbData.Text + "','" + mskTele.Text + "','" + mskCel.Text + "','" + txtBairro.Text + "','" + txtRua.Text + "','" + txtNCasa.Text + "','" + mskCEP.Text + "')"; //Cadastrando dados
                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn); //Instaciando
                    Cmd.ExecuteNonQuery(); //Executando

                    MessageBox.Show("Dados cadastrados com sucesso!"); //Mensagem

                    txtCliente.Clear(); //Limpar textBox
                    mkbData.Clear(); //Limpar maskedBox
                    mskTele.Clear(); //Limpar maskedBox
                    mskCel.Clear(); //Limpar maskedBox
                    txtBairro.Clear(); //Limpar textBox
                    txtRua.Clear(); //Limpar textBox    
                    mskCEP.Clear(); //Limpar maskedBox
                    txtNCasa.Clear(); //Limpar textBox

                    Conn.Close(); //Fechando conexão
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message); //Messagem de erro
                }
            else
            {
                MessageBox.Show("Cliente já cadastrado");
            }
        }

        private void BTNSair_Click_1(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }
    }
}
