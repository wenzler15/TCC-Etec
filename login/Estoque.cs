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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
            Conn.Open();

            string sql = "Select * FROM Estoque where Nome_Produto= '" + txtNomeProduto.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)

                try
                {

                    String SQL; //Definindo SQL como String
                    SQL = "Insert into Estoque(Nome_Produto, Quantidade) Values ('" + txtNomeProduto.Text + "','" + txtQuantidade.Text + "')"; //Dando valores aos campos

                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn); //Instacia

                    Cmd.ExecuteNonQuery(); //Executar

                    MessageBox.Show("Dados cadastrados com sucesso!!!"); //Mensagem

                    txtNomeProduto.Clear(); //Limpar caixa
                    txtQuantidade.Clear(); //Limpar caixa

                    Conn.Close(); //Fechando conexão
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message); //Mensagem de erro
                }

            else
            {
                MessageBox.Show("Item já cadastrado no estoque");
            }
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            
        }
    }
}
