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
    public partial class AlterarTrabalho : Form
    {
        public AlterarTrabalho()
        {
            InitializeComponent();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public String Cod_Trabalho, NomeTrabalho, Preco;

        private void AlterarTrabalho_Load(object sender, EventArgs e)
        {
            txtID.Text = Cod_Trabalho;
            txtServico.Text = NomeTrabalho;
            mkbPreco.Text = Preco;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
            txtServico.Focus();
            return;
        }

        private Boolean validaDados()
        {
            if (txtServico.Text == string.Empty)
                return false;

            if (mkbPreco.Text == string.Empty)
                return false;

            return true;
        }

        private void AlterarDados()
        {

            //define string de conexÆo - Provedor + fonte de dados (caminho do banco de dados e seu nome)

            String strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";

            //define a instru‡Æo SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE Trabalho SET NomeTrabalho ='" + txtServico.Text.Replace("'", "''") + "', Preco= '" + mkbPreco.Text + "'  Where Cod_Trabalho=" + int.Parse(Cod_Trabalho) + "";

            //cria a conexÆo com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);

            //Cria o comando que inicia a instru‡Æo SQL para altera‡Æo
            OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);

            string sql = "Select * FROM Trabalho where NomeTrabalho= '" + txtServico.Text + "'";

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
                MessageBox.Show("Serviço já cadastrado");
            }
            
            txtServico.Clear();
            mkbPreco.Clear();
            }
    }
}