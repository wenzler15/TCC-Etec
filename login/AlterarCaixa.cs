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
    public partial class AlterarCaixa : Form
    {
        public AlterarCaixa()
        {
            InitializeComponent();
        }

        public String Cod_Total, Total_Final, Data;

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarCaixa_Load(object sender, EventArgs e)
        {
            txtFinal.Text = Total_Final;
            mkbDia.Text = Data;
            txtID.Text = Cod_Total;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
            txtFinal.Focus();
            return;
        }

        private Boolean validaDados()
        {
            if (txtFinal.Text == string.Empty)
                return false;

            if (mkbDia.Text == string.Empty)
                return false;

            return true;
        }

        private void AlterarDados()
        {

            //define string de conexÆo - Provedor + fonte de dados (caminho do banco de dados e seu nome)

            String strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";

            //define a instru‡Æo SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE Caixa SET Total_Final ='" + txtFinal.Text.Replace("'", "''") + "', Data='" + mkbDia.Text + "'  Where Cod_Total=" + int.Parse(Cod_Total) + "";

            //cria a conexÆo com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);

            //Cria o comando que inicia a instru‡Æo SQL para altera‡Æo
            OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);

            string sql = "Select * FROM Caixa where Data= '" + mkbDia.Text + "'";

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
                MessageBox.Show("Baixa já feita neste dia");
            }
            txtFinal.Clear();
            mkbDia.Clear();
        }

    }
}
