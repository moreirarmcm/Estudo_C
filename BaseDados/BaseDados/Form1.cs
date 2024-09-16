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
        string nomeBase, acessoBase;
        private SQLiteConnection conexao = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void EstabelecendoConexao()
        {
            nomeBase = Application.StartupPath + "\\DBSQlite.db";
            acessoBase = @"Data Source = " + nomeBase + "; Version = 3";

            if (!File.Exists(nomeBase))
            {
                SQLiteConnection.CreateFile(nomeBase);
            }
             conexao = new SQLiteConnection(acessoBase);
            try
            {
                conexao.Open();
                lblResultado.Text = "Conectado à base de dados " + nomeBase;
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro ao conectar à base de dados " + nomeBase + "\n" + ex.Message;
            }
        }

        public void EncerrandoConexao(SQLiteConnection conexao)
        {
            if (conexao != null)
            {
                conexao.Close();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                EstabelecendoConexao();
                SQLiteCommand criarTabela = new SQLiteCommand();
                criarTabela.Connection = this.conexao;
                criarTabela.CommandText = "CREATE TABLE Pessoas (id int not null primary key, nome nvarchar(50),email nvarchar(50))";
                criarTabela.ExecuteNonQuery();
                lblResultado.Text = "Tabela Criada (SQLite).";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                EncerrandoConexao(conexao);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                EstabelecendoConexao();
                SQLiteCommand insertDados = new SQLiteCommand(conexao);
                //insertDados.Connection = conexao;
                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                if (!nome.Equals("") && nome != null)
                {
                    if (!email.Equals("") && email != null)
                    {
                        insertDados.CommandText = "INSERT INTO Pessoas VALUES (" + id + ",'" + nome + "','" + email + "')";
                        insertDados.ExecuteNonQuery();

                        lblResultado.Text = "Registro inserido (SQLite).";
                        insertDados.Dispose();
                    }
                    else
                    {
                        lblResultado.Text = "O email deve ser informado.";
                        EncerrandoConexao(conexao);
                    }
                }
                else
                {
                    lblResultado.Text = "O nome deve ser informado.";
                    EncerrandoConexao(conexao);
                }
                
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                EncerrandoConexao(conexao);
            }
        }


        private void btnProcurar_Click(object sender, EventArgs e)
        {
            
            lblResultado.Text = "";
            Lista.Rows.Clear();

            try
            {
                EstabelecendoConexao();
                string query = "select * from pessoas";
                if (!txtNome.Text.Equals("") || !txtEmail.Text.Equals(""))
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    query += " where nome like '" + nome + "' OR email like '" + Email + "'";
                }

                DataTable dados = new DataTable();
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexao);
                adaptador.Fill(dados);
                foreach (DataRow dr in dados.Rows)
                {
                    Lista.Rows.Add(dr.ItemArray);
                }
            }
            catch (Exception ex) {

                lblResultado.Text += "Erro.";
                Lista.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            lblResultado.Text = "";
            Lista.Rows.Clear();

            try
            {
                EstabelecendoConexao();
                SQLiteCommand deletarDados = new SQLiteCommand(conexao);
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                if ((!nome.Equals("") && nome != null) || (!email.Equals("") && email != null))
                {
                    deletarDados.CommandText = "delete from Pessoas where nome like '" + nome + "' OR email like '" + Email + "'";
                    lblResultado.Text = "Dados deletados.";
                    deletarDados.ExecuteNonQuery();
                    deletarDados.Dispose();
                }
                else
                {
                    deletarDados.CommandText = "delete from pessoas WHERE nome = ''";
                    deletarDados.ExecuteNonQuery();
                    lblResultado.Text = "Apenas os dados com nome e email vazios foram deletados.";
                    EncerrandoConexao(conexao);
                }
            }          
            catch (Exception ex)
            {

                lblResultado.Text = ex.Message;
                Lista.Rows.Clear();
            }
            finally
            {
                EncerrandoConexao(conexao);
            }

        }    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            //Lista.Rows.Clear();

            try
            {
                EstabelecendoConexao();
                SQLiteCommand editarDados = new SQLiteCommand();
                editarDados.Connection = conexao;

                int id = (int)Lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;
               
                string query = "update Pessoas set nome = '"+ nome + "', email = '" + email + "' where id = " + id;
                editarDados.CommandText = query;

                editarDados.ExecuteNonQuery();

                lblResultado.Text = "Dados atualizados.";
                editarDados.Dispose();

            }
            catch (Exception ex)
            {

                lblResultado.Text += "Erro.";
                Lista.Rows.Clear();
            }
            finally
            {
                EncerrandoConexao(conexao);
            }

        }
    }
}

