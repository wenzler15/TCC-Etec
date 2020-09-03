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
    public partial class AlterarCadastrar : Form
    {
        public AlterarCadastrar()
        {
            InitializeComponent();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String Cod_Cadastro, NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP;

        private void AlterarCadastrar_Load(object sender, EventArgs e)
        {
            txtID.Text = Cod_Cadastro;
            txtCliente.Text = NomeCliente;
            mkbData.Text = Data_Nascimento;
            mkbTelefone.Text = Telefone;
            mkbCelular.Text = Celular;
            txtBairro.Text = Bairro;
            txtRua.Text = Rua;
            txtNumero.Text = Numero_Casa;
            mkbCEP.Text = CEP;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
            txtCliente.Focus();
            return;
        }

        private Boolean validaDados()
        {
            if (txtCliente.Text == string.Empty)
                return false;

            if (mkbData.Text == string.Empty)
                return false;

            if (mkbTelefone.Text == string.Empty)
                return false;

            if (mkbCelular.Text == string.Empty)
                return false;

            if (txtBairro.Text == string.Empty)
                return false;

            if (txtRua.Text == string.Empty)
                return false;

            if (txtNumero.Text == string.Empty)
                return false;

            if (mkbCEP.Text == string.Empty)
                return false;

            return true;
        }

        private void AlterarDados()
        {

            //define string de conexÆo - Provedor + fonte de dados (caminho do banco de dados e seu nome)

            String strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";

            //define a instru‡Æo SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE Cadastro SET NomeCliente ='" + txtCliente.Text.Replace("'", "''") + "', Data_Nascimento='" + mkbData.Text + "', Telefone='" + mkbTelefone.Text + "', Celular='" + mkbCelular.Text + "', Bairro='" + txtBairro.Text + "', Rua='" + txtRua.Text + "',Numero_Casa='" + txtNumero.Text + "', CEP='" + mkbCEP.Text + "'  Where Cod_Cadastro=" + int.Parse(Cod_Cadastro) + "";

            //cria a conexÆo com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);

            //Cria o comando que inicia a instru‡Æo SQL para altera‡Æo
            OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);

            string sql = "Select * FROM Cadastro where NomeCliente= '" + txtCliente.Text + "' and Numero_Casa= '" + txtNumero.Text + "'";

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
                MessageBox.Show("Cliente já cadastrado");
            }
            txtCliente.Clear();
            mkbData.Clear();
            mkbTelefone.Clear();
            mkbCelular.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            mkbCEP.Clear();
        }

    }
}
