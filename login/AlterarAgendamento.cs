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
    public partial class AlterarAgendamento : Form
    {
        public AlterarAgendamento()
        {
            InitializeComponent();
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String Cod_Agendamento, Data1, Horario, Cod_Cliente1, Cod_Trabalho1;

        private void AlterarAgendamento_Load(object sender, EventArgs e)
        {
            try
            {
                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
                Conn.Open(); //Abrindo conexão com banco de dados

                String SQL1; //Nomeando String como SQL

                SQL1 = "Select NomeCliente,Cod_Cadastro From Cadastro"; //Chamando campos da tabela


                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL1, Conn); /*Representa um conjunto de comandos de dados e uma conexão de banco de dados
            * que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/

                DataSet ds = new DataSet(); //Representação do banco off

                Adapter.Fill(ds, "Cadastro"); //Cria tabela para adicionar consultas

                cboCliente.DataSource = ds.Tables["Cadastro"]; //Qual tabela preenche o DataSource
                cboCliente.DisplayMember = "NomeCliente";  //Visualiza
                cboCliente.ValueMember = "Cod_Cadastro"; //Fica por trás do código
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }

            try
            {
                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
                Conn.Open(); //Abrindo conexão

                String SQL1; //Definindo SQL1 como String

                SQL1 = "Select NomeTrabalho, Cod_Trabalho From Trabalho"; //Chamando os campos da tabela


                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL1, Conn); /*Representa um conjunto de comandos de dados e uma conexão de banco de dados
            * que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/

                DataSet ds = new DataSet(); //Representação do banco off

                Adapter.Fill(ds, "Trabalho"); //Cria tabela para adicionar consultas

                cboServico.DataSource = ds.Tables["Trabalho"]; //Qual tabela preenche o DataSource
                cboServico.DisplayMember = "NomeTrabalho";  //Visualiza
                cboServico.ValueMember = "Cod_Trabalho"; //Fica por trás do código
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }

            mkbData.Text = Data1;
            mkbHora.Text = Horario;
            txtCod.Text = Cod_Agendamento;
            cboCliente.Text = Cod_Cliente1;
            cboServico.Text = Cod_Trabalho1;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaDados())
                AlterarDados();
            else
                MessageBox.Show("Dados Inválidos...");
            mkbData.Focus();
            return;
        }

        private Boolean validaDados()
        {
            if (mkbData.Text == string.Empty)
                return false;

            if (mkbHora.Text == string.Empty)
                return false;

            if (cboCliente.Text == string.Empty)
                return false;

            if (cboServico.Text == string.Empty)
                return false;

            return true;
        }

        private void AlterarDados()
        {

            //define string de conexÆo - Provedor + fonte de dados (caminho do banco de dados e seu nome)

            String strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";

            //define a instru‡Æo SQL para atualizar os dados da tabela Clientes - UPDATE tabela SET campos
            string strSQL = "UPDATE Agendamento SET Data ='" + mkbData.Text.Replace("'", "''") + "', Horario='" + mkbHora.Text + "', Cod_Cliente='" + cboCliente.SelectedValue.ToString() + "', Cod_Trabalho= '" + cboServico.SelectedValue.ToString() + "' Where Cod_Agendamento="+int.Parse(Cod_Agendamento)+"";

            //cria a conexÆo com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);

            //Cria o comando que inicia a instru‡Æo SQL para altera‡Æo
            OleDbCommand cmdAlterar = new OleDbCommand(strSQL, dbConnection);


            string sql = "Select * FROM Agendamento where Data= '" + mkbData.Text + "' and Horario= '" + mkbHora.Text + "'";

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
            else {
                MessageBox.Show("Horario já agendado");
            }
            mkbData.Clear();
            mkbHora.Clear();
        }

    }
}
