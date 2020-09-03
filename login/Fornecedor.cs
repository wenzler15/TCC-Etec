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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
            Conn.Open();

            string sql = "Select * FROM Fornecedor where Fornecedor= '" + txtFornecedor.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)

                try
                {

                    String SQL; //Declarando SQL como String
                    SQL = "Insert into Fornecedor(Fornecedor, Telefone, Tipo_De_Produto) Values ('" + txtFornecedor.Text + "','" + mkbTelefone.Text + "', '" + txtProduto.Text + "')"; //Dando valor aos campos

                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn); //Instancia

                    Cmd.ExecuteNonQuery(); //Executando

                    MessageBox.Show("Dados cadastrados com sucesso!!!"); //Mensagem

                    txtFornecedor.Clear(); //Limpar caixa
                    txtProduto.Clear(); //Limpar caixa
                    mkbTelefone.Clear(); //Limpar caixa

                    Conn.Close(); //Fechar conexão
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message); //Mensagem de erro
                }

            else
            {
                MessageBox.Show("Fornecedor já cadastrado");
            }
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
