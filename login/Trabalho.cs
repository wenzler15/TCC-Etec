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
    public partial class Trabalho : Form
    {
        public Trabalho()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Conexão com banco de dados
            Conn.Open();

            string sql = "Select * FROM Trabalho where NomeTrabalho= '" + txtServico.Text + "'";

            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, Conn);
            DataTable o = new DataTable();

            Adapter.Fill(o);

            if (o.Rows.Count == 0)

                try
                {

                    String SQL;
                    SQL = "Insert into Trabalho(NomeTrabalho, Preco) Values ('" + txtServico.Text + "', '" + mkbPreco.Text + "')";

                    OleDbCommand Cmd = new OleDbCommand(SQL, Conn);

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com sucesso!!!");

                    txtServico.Clear();
                    mkbPreco.Clear();

                    Conn.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message);
                }
            else
            {
                MessageBox.Show("Serviço já cadastrado");
            }
        }

        private void BTNSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trabalho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
