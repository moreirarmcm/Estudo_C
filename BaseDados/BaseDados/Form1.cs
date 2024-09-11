using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            #region SQL Server CE
            
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
            #endregion

            #region SQLite
           /*
             string baseDados = Application.StartupPath + @"\DBSQLite.db";
             string strConection = @"Data Source = " + baseDados + "; Version = 3";

             if (!File.Exists(baseDados))
             {
                 SQLiteConnection.CreateFile(baseDados);
             }
             SQLiteConnection connection = new SQLiteConnection(strConection);
             try
             {
                 connection.Open();
                 lblResultado.Text = "Conectado.";
             }
             catch (Exception ee)
             {
                 lblResultado.Text = "Não conectado.";
             }
             finally
             {
                 connection.Close();
             }

             */
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
         #region Criar tabela (Pessoas) SQL Server CE
            /*
             String baseDados = Application.StartupPath + @"\DBSQLServer.sdf";
            String conexao = @"DataSource = " + baseDados + "; Password = '1234'";
            SqlCeConnection connection = new SqlCeConnection(conexao);

            try
            {
                connection.Open();
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = connection;
                comando.CommandText = "CREATE TABLE Pessoas (id int not null primary key, nome nvarchar(50),email nvarchar(50))";
                comando.ExecuteNonQuery();

                lblResultado.Text = "Tabela Criada (SQL Server CE).";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally { 
                connection.Close();
            }
            */
            #endregion
            #region Criar tabela (Pessoas) SQLite
           /*
            String baseDados = Application.StartupPath + @"\DBSQLite.db";
            String conexao = @"DataSource = " + baseDados + "; version = 3";
            SQLiteConnection connection = new SQLiteConnection(conexao);

            try
            {
                connection.Open();
                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = connection;
                comando.CommandText = "CREATE TABLE Pessoas (id int not null primary key, nome nvarchar(50),email nvarchar(50))";
                comando.ExecuteNonQuery();

                lblResultado.Text = "Tabela Criada (SQLite).";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
           */
            #endregion


        }
    }
}
