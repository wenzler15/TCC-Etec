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
    public partial class Buscar2 : Form
    {
        public Buscar2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarAgendamento()
        {
            //Ligando campos da tabela a textBox
            String SQL = "Select A.Cod_Agendamento, A.Data, A.Horario, C.NomeCliente, T.NomeTrabalho From Agendamento as A, Cadastro as C, Trabalho as T Where A.Cod_Cliente = C.Cod_Cadastro and A.Cod_Trabalho = T.Cod_Trabalho";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

                Conn.Open(); //Abrindo conexão

                DataSet DS = new DataSet(); //Instaciando
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instaciando a ligação com banco de dados
                Adapter.Fill(DS, "Agendamento"); //Dando nome a tabela
                dgAgendamento.DataSource = DS.Tables[0]; //Pesquisa da tabela

                Conn.Close(); //Fechando conexão

                dgAgendamento.Columns[0].Visible = false;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        
        }
        private void CarregarCadastro()
        {
            //Seleciana oque vai ser exibido
            String SQL = "Select  Cod_Cadastro, NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP From Cadastro;";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

                Conn.Open(); //Abrindo conexão
                 
                DataSet DS = new DataSet(); //Instacia
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instacia com banco de dados
                Adapter.Fill(DS, "Cadastro"); //Nomeando tabela
                dgCadastro.DataSource = DS.Tables[0]; //Buscando tabela

                Conn.Close(); //Fechando conexão

                dgCadastro.Columns[0].Visible = false;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }

        private void Buscar2_Load(object sender, EventArgs e)
        {
            CarregarAgendamento(); //Carregando tabela
            CarregarCadastro(); //Carregando tabela
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão
             
            //Define a instrução Sql
            string SQL = "SELECT * FROM Cadastro WHERE NomeCliente LIKE '%" + txtBuscar1.Text + "%'";

            //Lê os dados da variavel sql e conectar no cn
            OleDbCommand Cmd = new OleDbCommand(SQL, Conn);
            //Abre conexão
            Conn.Open();
            //Define o valor da CommandType para cmd
            Cmd.CommandType = CommandType.Text;
            /*Representa um conjunto de comandos de dados e uma conexão de banco de dados
            * que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/
            OleDbDataAdapter Adapter = new OleDbDataAdapter(Cmd);

            //Representa uma tabela de dados na memória.
            DataTable Cadastro = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Cadastro);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgCadastro.DataSource = Cadastro;
            Conn.Close(); //Fechando conexão
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão  

            //Define a instrução Sql
            string SQL = "SELECT * FROM Agendamento WHERE Data LIKE '%" + mkbBuscar2.Text + "%'";

            //Lê os dados da variavel sql e conectar no cn
            OleDbCommand Cmd = new OleDbCommand(SQL, Conn);
            //Abre conexão
            Conn.Open();
            //Define o valor da CommandType para cmd
            Cmd.CommandType = CommandType.Text;
            /*Representa um conjunto de comandos de dados e uma conexão de banco de dados
            * que são usados para preencher o DataSet e atualizar um banco de dados SQL Server.*/
            OleDbDataAdapter Adapter = new OleDbDataAdapter(Cmd);

            //Representa uma tabela de dados na memória.
            DataTable Agendamento = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Agendamento);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgAgendamento.DataSource = Agendamento;
            Conn.Close(); //Fechando conexão
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgCadastro.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Cadastro where Cod_Cadastro=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar2 o = new Buscar2();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgAgendamento.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Agendamento where Cod_Agendamento=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar2 o = new Buscar2();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }
        private int linhaAtual2 = 0;

        public String Cod_Cadastro, NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP;

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                Cod_Cadastro = dgCadastro[0, linhaAtual2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual2 >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid2();

                AlterarCadastrar f3 = new AlterarCadastrar();
                //
                f3.Cod_Cadastro = Cod_Cadastro;
                f3.NomeCliente = NomeCliente;
                f3.Data_Nascimento = Data_Nascimento;
                f3.Telefone = Telefone;
                f3.Celular = Celular;
                f3.Bairro = Bairro;
                f3.Rua = Rua;
                f3.Numero_Casa = Numero_Casa;
                f3.CEP = CEP;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgCadastro.Update();
                CarregarCadastro();
            }
        }

        private void obtemDadosGrid2()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            NomeCliente = dgCadastro[1, linhaAtual2].Value.ToString();
            Data_Nascimento = dgCadastro[2, linhaAtual2].Value.ToString();
            Telefone = dgCadastro[3, linhaAtual2].Value.ToString();
            Celular = dgCadastro[4, linhaAtual2].Value.ToString();
            Bairro = dgCadastro[5, linhaAtual2].Value.ToString();
            Rua = dgCadastro[6, linhaAtual2].Value.ToString();
            Numero_Casa = dgCadastro[7, linhaAtual2].Value.ToString();
            CEP = dgCadastro[8, linhaAtual2].Value.ToString();
        }

        private int linhaAtual6 = 0;

        public String Cod_Agendamento, Data1, Horario, Cod_Cliente1, Cod_Trabalho1;

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                Cod_Agendamento = dgAgendamento[0, linhaAtual6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual6 >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid6();
                AlterarAgendamento f3 = new AlterarAgendamento();
                //
                f3.Cod_Agendamento = Cod_Agendamento;
                f3.Data1 = Data1;
                f3.Horario = Horario;
                f3.Cod_Cliente1 = Cod_Cliente1;
                f3.Cod_Trabalho1 = Cod_Trabalho1;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgAgendamento.Update();
                CarregarAgendamento();
            }

        }

        private void obtemDadosGrid6()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            Data1 = dgAgendamento[1, linhaAtual6].Value.ToString();
            Horario = dgAgendamento[2, linhaAtual6].Value.ToString();
            Cod_Cliente1 = dgAgendamento[3, linhaAtual6].Value.ToString();
            Cod_Trabalho1 = dgAgendamento[4, linhaAtual6].Value.ToString();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgCadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
