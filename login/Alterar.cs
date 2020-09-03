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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       public String Nome_Produto, Quantidade, IDEstoque;
        
        private void Alterar_Load(object sender, EventArgs e)
        {
            txtProduto.Text = Nome_Produto;
            txtQuantidade.Text = Quantidade;
            txtID.Text = IDEstoque;
        }

        private void Alterar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
            txtProduto.Focus();
            return;
        }

        private Boolean validaDados()
        {
            if (txtProduto.Text == string.Empty)
                return false;

            if (txtQuantidade.Text == string.Empty)
                return false;

            return true;
        }

        private void AlterarDados()
{


      //define string de conexÆo - Provedor + fonte de dados (caminho do banco de dados e seu nome)
     
      String strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";

      //define a instru‡Æo SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
      string strSQL = "UPDATE Estoque SET Nome_Produto ='" + txtProduto.Text.Replace("'", "''") + "', Quantidade='" + txtQuantidade.Text + "' Where Cod_Produto=" + int.Parse(IDEstoque) + "";
 
     //cria a conexÆo com o banco de dados
     OleDbConnection dbConnection = new OleDbConnection(strConnection);

     //Cria o comando que inicia a instru‡Æo SQL para altera‡Æo
     OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);

     string sql = "Select * FROM Estoque where Nome_Produto= '" + txtProduto.Text + "'";

     OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, dbConnection);
     DataTable o = new DataTable();

     Adapter.Fill(o);

     if (o.Rows.Count == 0)

     try
     {
     // abre o banco de dados
     dbConnection.Open();
     // executa a instru‡Æo SQL
     cmdAlterar.ExecuteNonQuery();
     //
     MessageBox.Show("Dados Alterados com sucesso.");
     }
     //Trata a exce‡Æo
     catch (OleDbException ex)
     {
     MessageBox.Show("Error: " + ex.Message);
     }
        
     finally
     {
    //fecha a conexao
    dbConnection.Close();
    }
     else
     {
         MessageBox.Show("Item já cadastrado no sistema");
     }
            txtProduto.Clear();
            txtQuantidade.Clear();
   } 
        

        

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
