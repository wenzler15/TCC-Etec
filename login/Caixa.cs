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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, v2, v3, v4, v5, v6, Entrada; //Declarando variaveis
            v1 = Convert.ToDouble(TXTBSegunda.Text); //Pegando valor
            v2 = Convert.ToDouble(TXTBTerça.Text); //Pegando valor
            v3 = Convert.ToDouble(TXTBQuarta.Text); //Pegando o valor
            v4 = Convert.ToDouble(TXTBQuinta.Text); //Pegando o valor
            v5 = Convert.ToDouble(TXTBSexta.Text); //Pegando o valor
            v6 = Convert.ToDouble(TXTBSabado.Text); //Pegando o valor
            Entrada = v1 + v2 + v3 + v4 + v5 + v6; //Calculando entrada
            TXTBTotalEntrar.Text = Convert.ToString(Entrada); //Exibindo total
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double v7, v8, v9, v10, v11, v12, Saida; //Declarando variaveis
            v7 = Convert.ToDouble(TXTBSegunda2.Text); //Pegando o valor
            v8 = Convert.ToDouble(TXTBTerça2.Text); //Pegando o valor
            v9 = Convert.ToDouble(TXTBQuarta2.Text); //Peganndo o valor
            v10 = Convert.ToDouble(TXTBQuinta2.Text); //Pegando o valor
            v11 = Convert.ToDouble(TXTBSexta2.Text); //Pegando o valor 
            v12 = Convert.ToDouble(TXTBSabado2.Text); //Pegando o valor
            Saida = v7 + v8 + v9 + v10 + v11 + v12; //Calculando saída
            TXTBTotalSaida.Text = Convert.ToString(Saida); //Exibindo total
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double entrada, saida, total; //Declarando variaveis
            entrada = Convert.ToDouble(TXTBTotalEntrar.Text); //Pegando o valor
            saida = Convert.ToDouble(TXTBTotalSaida.Text); //Pegando o valor
            total = entrada - saida; //Calculando
            if (total > 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Lucro de: R$ " + total); //Exibindo total
            }
            if (total < 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Prejuízo de: R$ " + total); //Exibindo total
            } 
            if (total == 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Não ouve nem lucro nem prejuízo"); //Exibindo total
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TXTBSegunda.Clear(); //Limpar campo
            TXTBTerça.Clear(); //Limpar campo
            TXTBQuarta.Clear(); //Limpar campo
            TXTBQuinta.Clear(); //Limpar campo
            TXTBSexta.Clear(); //Limpar campo
            TXTBSabado.Clear(); //Limpar campo
            TXTBSabado2.Clear(); //Limpar campo
            TXTBSexta2.Clear(); //Limpar campo
            TXTBQuinta2.Clear(); //Limpar campo
            TXTBQuarta2.Clear(); //Limpar campo
            TXTBTerça2.Clear(); //Limpar campo
            TXTBSegunda2.Clear(); //Limpar campo
            txtTotalFinal.Clear(); //Limpar campo
            TXTBTotalEntrar.Clear(); //Limpar campo
            TXTBTotalSaida.Clear(); //Limpar campo
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close(); //Fechar form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double v1 , v2, v3, v4, v5, v6, Entrada; //Declarando variaveis
            v1 = Convert.ToDouble(TXTBSegunda.Text); //Pegando o valor
            v2 = Convert.ToDouble(TXTBTerça.Text); //Pegando o valor
            v3 = Convert.ToDouble(TXTBQuarta.Text); //Pegando o valor
            v4 = Convert.ToDouble(TXTBQuinta.Text); //Pegando o valor
            v5 = Convert.ToDouble(TXTBSexta.Text); //Pegando o valor
            v6 = Convert.ToDouble(TXTBSabado.Text); //Pegando o valor
            Entrada = v1 + v2 + v3 + v4 + v5 + v6; //Calculando o total
            TXTBTotalEntrar.Text = Convert.ToString(Entrada); //Exibir
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
            double v7, v8, v9, v10, v11, v12, Saida; //Declarando variaveis
            v7 = Convert.ToDouble(TXTBSegunda2.Text); //Pegando o valor
            v8 = Convert.ToDouble(TXTBTerça2.Text); //Pegando o valor
            v9 = Convert.ToDouble(TXTBQuarta2.Text); //Pegando o valor
            v10 = Convert.ToDouble(TXTBQuinta2.Text); //Pegando o valor
            v11 = Convert.ToDouble(TXTBSexta2.Text); //Pegando o valor 
            v12 = Convert.ToDouble(TXTBSabado2.Text); //Pegando o  valor
            Saida = v7 + v8 + v9 + v10 + v11 + v12; //Calculando o total
            TXTBTotalSaida.Text = Convert.ToString(Saida); //Exibir
            }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double entrada, saida, total; //Iniciando variaveis
            entrada = Convert.ToDouble(TXTBTotalEntrar.Text); //ligando variavel a campo
            saida = Convert.ToDouble(TXTBTotalSaida.Text); //Ligando variaveis a campo
            total = entrada - saida; //Operação logica
            if (total > 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Lucro de: R$ " + total); //Exibir valor
            }
            if (total < 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Prejuízo de: R$ " + total); //Exibir valor
            }
            if (total == 0) //Laço de decisão
            {
                txtTotalFinal.Text = Convert.ToString("Não ouve nem lucro nem prejuízo"); //Exbiri valor
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TXTBSegunda.Clear(); //Limpar txt
            TXTBTerça.Clear(); //Limpar txt
            TXTBQuarta.Clear(); //Limpar txt
            TXTBQuinta.Clear(); //Limpar txt
            TXTBSexta.Clear(); //Limpar txt
            TXTBSabado.Clear(); //Limpar txt
            TXTBSabado2.Clear(); //Limpar txt
            TXTBSexta2.Clear(); //Limpar txt
            TXTBQuinta2.Clear(); //Limpar txt
            TXTBQuarta2.Clear(); //Limpar txt
            TXTBTerça2.Clear(); //Limpar txt
            TXTBSegunda2.Clear(); //Limpar txt
            txtTotalFinal.Clear(); //Limpar txt
            TXTBTotalEntrar.Clear(); //Limpar txt
            TXTBTotalSaida.Clear(); //Limpar txt
            mtbDia.Clear(); //Limpar maskedBox
        }

        private void TXTBTotalEntrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
            Conn.Open();

            string sql = "Select * FROM Caixa where Data= '" + mtbDia.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)

                try
                {

                    String SQL; //Definindo String SQL
                    SQL = "Insert into Caixa(Total_Final, Data) Values ('" + txtTotalFinal.Text + "','" + mtbDia.Text + "')"; //Ligando campos a tabela

                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn); //Instancia OleDb

                    Cmd.ExecuteNonQuery(); //Executando

                    MessageBox.Show("Dados cadastrados com sucesso!"); //Exibindo mensagem

                    txtTotalFinal.Clear(); //Limpar txt               
                    TXTBSegunda.Clear(); //Limpar txt
                    TXTBTerça.Clear(); //Limpar txt
                    TXTBQuarta.Clear(); //Limpar txt
                    TXTBQuinta.Clear(); //Limpar txt
                    TXTBSexta.Clear(); //Limpar txt
                    TXTBSabado.Clear(); //Limpar txt
                    TXTBSabado2.Clear(); //Limpar txt
                    TXTBSexta2.Clear(); //Limpar txt
                    TXTBQuinta2.Clear(); //Limpar txt
                    TXTBQuarta2.Clear(); //Limpar txt
                    TXTBTerça2.Clear(); //Limpar txt
                    TXTBSegunda2.Clear(); //Limpar txt
                    TXTBTotalEntrar.Clear(); //Limpar txt
                    TXTBTotalSaida.Clear(); //Limpar txt
                    mtbDia.Clear(); //Limpar mtb

                    Conn.Close(); //Fechando conexão
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message); //mensagem de erro
                }

            else {
                MessageBox.Show("A baixa no sistema já foi feita nesse dia");
            }
        }
    }
}