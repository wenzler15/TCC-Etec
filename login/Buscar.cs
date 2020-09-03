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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            //Puxando campos da tabela
            String SQL = "Select  Cod_Cadastro, NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP From Cadastro;";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

                Conn.Open(); //Abrindo conexão
                 
                DataSet DS = new DataSet(); //Instanciando
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instaciando a ligação com banco de dados
                Adapter.Fill(DS, "Cadastro"); //Nomeando a tabela
                dgCadastro.DataSource = DS.Tables[0]; //Pesquisando a tabela

                Conn.Close(); //Fechando conexão

                dgCadastro.Columns[0].Visible = false;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }



        private void CarregarCaixa()
        {
            //Puxando campos da tabela
            String SQL = "Select Cod_Total, Total_Final, Data from Caixa;";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão
                
                Conn.Open(); //Abrindo conexão

                DataSet DS = new DataSet(); //Instaciando 
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instaciando ligação com banco de dados
                Adapter.Fill(DS, "Caixa"); //Nomeando a tabela
                dgCaixa.DataSource = DS.Tables[0]; //Pesquisando a tabela

                Conn.Close(); //Fechando conexão

                dgCaixa.Columns[0].Visible = false;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }


        private void CarregarEstoque()
        {
            //Puxando campos da tabela
            String SQL = "Select Cod_Produto, Nome_Produto, Quantidade From Estoque;";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

                Conn.Open(); //Abrindo conexão

                DataSet DS = new DataSet(); //Instaciando
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instaciando ligação com banco de dados
                Adapter.Fill(DS, "Estoque"); //Nomeando banco de dados  
                dgEstoque.DataSource = DS.Tables[0]; //Procurando tabela 

                Conn.Close(); //Fechando conexão 

                dgEstoque.Columns[0].Visible = false;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }

        private void CarregarFornecedor()
        {
            //Puxando campos da tabela
            String SQL = "select Cod_Fornecedor, Fornecedor, Telefone, Tipo_De_Produto from Fornecedor;";

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão com banco de dados

                Conn.Open(); //Abrindo conexão
                 
                DataSet DS = new DataSet(); //Instaciando 
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instacia com banco de dados
                Adapter.Fill(DS, "Fornecedor"); //Nomeando a tabela
                dgFornecedor.DataSource = DS.Tables[0]; //Procurando tabela

                Conn.Close(); //Fechando conexão

                dgFornecedor.Columns[0].Visible = false;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }

        private void CarregarTrabalho()
        {

            String SQL = "select Cod_Trabalho, NomeTrabalho, Preco from Trabalho;"; //Definindo campo e tabela

            try
            {

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

                Conn.Open(); //Abrindo conexão
                 
                DataSet DS = new DataSet(); //Instancia
                OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conn); //Instancia de conexão
                Adapter.Fill(DS, "Trabalho"); //Nomeando tabela
                dgServico.DataSource = DS.Tables[0]; //Procurar tabela

                Conn.Close(); //Fechar conexão

                dgServico.Columns[0].Visible = false;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message); //Mensagem de erro
            }
        }
        private void Buscar_Load(object sender, EventArgs e)
        {
            CarregarAgendamento(); //Carregar a tabela
            CarregarCadastro(); //Carregar a tabela
            CarregarCaixa(); //Carregar a tabela
            CarregarEstoque(); //Carregar a tabela 
            CarregarFornecedor(); //Carregar a tabela
            CarregarTrabalho(); //Carregar a tabela
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando Conexão

            //Define a instrução Sql
            string SQL = "SELECT NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa FROM Cadastro WHERE NomeCliente LIKE '%" + txtBuscar1.Text + "%'";

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
            Conn.Close(); //Fechar conexão
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar6_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

            //Define a instrução Sql
            string SQL = "SELECT NomeTrabalho, Preco FROM Trabalho WHERE NomeTrabalho LIKE '%" + txtBuscar6.Text + "%'";

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
            DataTable Trabalho = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Trabalho);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgServico.DataSource = Trabalho;
            Conn.Close(); //Fechando conexão
        }

        private void btnBuscar5_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando Conexão

            //Define a instrução Sql
            string SQL = "SELECT Fornecedor, Telefone, Tipo_De_Produto FROM Fornecedor WHERE Fornecedor LIKE '%" + txtBuscar5.Text + "%'";

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
            DataTable Fornecedor = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Fornecedor);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgFornecedor.DataSource = Fornecedor;
            Conn.Close(); //Fecha conexão
        }

        private void btnBuscar4_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

            //Define a instrução Sql
            string SQL = "SELECT Nome_Produto, Quantidade FROM Estoque WHERE Nome_Produto LIKE '%" + txtBuscar4.Text + "%'";

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
            DataTable Estoque = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Estoque);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgEstoque.DataSource = Estoque;
            Conn.Close(); //Fechar conexão
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

            //Define a instrução Sql
            string SQL = "SELECT Total_Final, Data FROM Caixa WHERE Data LIKE '%" + mkbBuscar3.Text + "%'";

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
            DataTable Caixa = new DataTable();
            /* Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de
            * dados usando o DataTable.*/
            Adapter.Fill(Caixa);
            /*A dataGriedView recebe o DataTable Trabalho*/
            dgCaixa.DataSource = Caixa;
            Conn.Close(); //Fechar conexão
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão

            //Define a instrução Sql
            string SQL = "SELECT Data, Horario, Cod_Cliente, Cod_Trabalho FROM Agendamento WHERE Data LIKE '%" + mkbBuscar2.Text + "%'";

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

                Buscar o = new Buscar();
                o.Show();
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private int linhaAtual6 = 0;

        public String Cod_Agendamento, Data1, Horario, Cod_Cliente1, Cod_Trabalho1;

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
        private int linhaAtual2 = 0;

        public String Cod_Cadastro, NomeCliente, Data_Nascimento, Telefone, Celular, Bairro, Rua, Numero_Casa, CEP;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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


        private void excluirToolStripMenuItem1_Click_1(object sender, EventArgs e)
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

                Buscar o = new Buscar();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgCaixa.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Caixa where Cod_Total=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar o = new Buscar();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void excluirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgEstoque.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Estoque where Cod_Produto=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar o = new Buscar();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void excluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgFornecedor.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Fornecedor where Cod_Fornecedor=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar o = new Buscar();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void excluirToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                String ID;

                ID = dgServico.SelectedCells[0].Value.ToString();

                String SQL = "Delete from Trabalho where Cod_Trabalho=" + ID;

                String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\MovvHair.mdb;";
                OleDbConnection Conn = new OleDbConnection(StrConn);

                Conn.Open();


                OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                Cmd.ExecuteNonQuery();

                Conn.Close();

                this.Hide();

                Buscar o = new Buscar();
                o.Show();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private int linhaAtual = 0;

       public String IDEstoque, Nome_Produto, Quantidade;

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                IDEstoque = dgEstoque[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid();

                Alterar f3 = new Alterar();
                //
                f3.IDEstoque = IDEstoque;
                f3.Nome_Produto = Nome_Produto;
                f3.Quantidade = Quantidade;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgEstoque.Update();
                CarregarEstoque();
            }
        }

        private void obtemDadosGrid()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            Nome_Produto = dgEstoque[1, linhaAtual].Value.ToString();
            Quantidade = dgEstoque[2, linhaAtual].Value.ToString();
        }

        private void CTSEstoque_Opening(object sender, CancelEventArgs e)
        {

        }
        private int linhaAtual3 = 0;

        public String Cod_Total, Total_Final, Data;

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                Cod_Total = dgCaixa[0, linhaAtual3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual3 >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid3();

                AlterarCaixa f3 = new AlterarCaixa();
                //
                f3.Cod_Total = Cod_Total;
                f3.Total_Final = Total_Final;
                f3.Data = Data;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgCaixa.Update();
                CarregarCaixa();
            }

        }

        private void obtemDadosGrid3()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            Total_Final = dgCaixa[1, linhaAtual3].Value.ToString();
            Data = dgCaixa[2, linhaAtual3].Value.ToString();
        }

        private int linhaAtual4 = 0;

        public String Cod_Fornecedor, Fornecedor, TelefoneForn, Tipo_De_Produto;

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                Cod_Fornecedor = dgFornecedor[0, linhaAtual4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual4 >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid4();

                AlterarFornecedor f3 = new AlterarFornecedor();
                //
                f3.Cod_Fornecedor = Cod_Fornecedor;
                f3.Fornecedor = Fornecedor;
                f3.TelefoneForn = TelefoneForn;
                f3.Tipo_De_Produto = Tipo_De_Produto;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgFornecedor.Update();
                CarregarFornecedor();
            }

        }

        private void obtemDadosGrid4()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            Fornecedor = dgFornecedor[1, linhaAtual4].Value.ToString();
            TelefoneForn = dgFornecedor[2, linhaAtual4].Value.ToString();
            Tipo_De_Produto = dgFornecedor[3, linhaAtual4].Value.ToString();
        }

        private int linhaAtual5 = 0;

        public String Cod_Trabalho, NomeTrabalho, Preco;

        private void alterarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            try
            {
                //obtem o c¢digo do cliente a partir da linha selecionada no datagridview
                Cod_Trabalho = dgServico[0, linhaAtual5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }

            if (linhaAtual5 >= 0)
            {
                //obtem dados do datagridview e atribui as variaveis definidas no formulario alterar
                obtemDadosGrid5();

                AlterarTrabalho f3 = new AlterarTrabalho();
                //
                f3.Cod_Trabalho = Cod_Trabalho;
                f3.NomeTrabalho = NomeTrabalho;
                f3.Preco = Preco;
                //exibe o formulario para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgServico.Update();
                CarregarTrabalho();
            }

        }

        private void obtemDadosGrid5()
        {
            //obtém os dados do datagridview da linha selecionada usando as posi‡äes das colunas
            //a primeira coluna ‚ a coluna 0 a segunda ‚ a coluna 1 , e , assim por diante
            NomeTrabalho = dgServico[1, linhaAtual5].Value.ToString();
            Preco = dgServico[2, linhaAtual5].Value.ToString();
            }

    }
}
