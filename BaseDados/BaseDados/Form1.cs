using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String baseDados = Application.StartupPath + @"\DBSQLServer.sdf";
            String conexao = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeEngine db = new SqlCeEngine(conexao);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();
            SqlCeConnection conexaoConnection = new SqlCeConnection(conexao);
            try
            {
                conexaoConnection.Open();
                lblResultado.Text = "Conectado!";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro ao conectar à base";
            }
            finally
            {
                conexaoConnection.Close();

            }
        }
    }
}
