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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
            Conn.Open();

            string sql = "Select * FROM Agendamento where Data= '" + mkbData.Text + "' and Horario= '" + mkbHorario.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)
                try
                {
                    String SQL; //Nomeando String como SQL
                    SQL = "Insert into Agendamento(Data, Horario, Cod_Cliente, Cod_Trabalho) Values ('" + mkbData.Text + "','" + mkbHorario.Text + "','" + cboCliente.SelectedValue.ToString() + "','" + cboServico.SelectedValue.ToString() + "')"; //Ligando os campos as textBox

                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn); //Lê os dados da variavel sql e conectar no cn

                    Cmd.ExecuteNonQuery(); //Executando a conexão

                    MessageBox.Show("Dados cadastrados com sucesso!!!"); //Exibir mensagem

                    mkbHorario.Clear(); //Limpa a maskedBox
                    mkbData.Clear(); //Limpa a maskedBox

                    Conn.Close(); //Fecha a conexão

                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message); //Mensagem de erro
                }
            else
            {
                MessageBox.Show("Horario já agendado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Agendamento_Load(object sender, EventArgs e)
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

            

                
           
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
