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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            String StrConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\MovvHair.mdb;";
            OleDbConnection Conn = new OleDbConnection(StrConn); //Criando conexão
            Conn.Open(); //Abrindo conexão

            String SQL = "Select Cod_Total, Total_Final, Data from Caixa;";
            
            OleDbDataAdapter Cmd = new OleDbDataAdapter(SQL, Conn); //Instancia
            
            Cmd.Fill(DS_Caixa, "Caixa");
            Conn.Close();
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
