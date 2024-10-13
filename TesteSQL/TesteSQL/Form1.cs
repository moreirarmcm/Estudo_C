using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            String str_baseDados = "Server=RENAN-PC;Database=TesteBase;Trusted_Connection= true;";
            SqlConnection conexao = new SqlConnection(str_baseDados);
            try
            {
                conexao.Open();
                lblTeste.Text = "Deu bom.";
            }
            catch
            {
                lblTeste.Text = "Deu ruim.";
            }   
        }
    }
}
            /*using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    string query = "INSERT INTO Responsavel (Nome, Endereco, Contato, Parentesco) VALUES (@Nome, @Endereco, @Contato, @Parentesco)";
                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@Nome", "João da Silva");
                        command.Parameters.AddWithValue("@Endereco", "Rua A, 123");
                        command.Parameters.AddWithValue("@Contato", "123456789");
                        command.Parameters.AddWithValue("@Parentesco", "Pai");

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} linha(s) inserida(s) com sucesso.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }*/
        
