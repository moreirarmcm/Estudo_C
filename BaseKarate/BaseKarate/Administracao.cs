using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Mysqlx.Crud;
using System.Data.SqlClient;
using System.Data;

namespace BaseKarate
{
    internal class Administracao
    {
        private static String acesso_base = "Server=RENAN-PC;Database=GuerreirosDoFuturo;Trusted_Connection=True;";
        SqlConnection conexao;// = new SqlConnection(acesso_base);

        #region Versão anterior usando SQLite
        /*
        private static String nomeBase = Application.StartupPath + @"GuerreirosDoFuturo.db";
        private static String caminhoBase = @"Data Source = " + nomeBase + "; Version = 3";
        private SQLiteConnection conexao = new SQLConnection(caminhoBase);
        bool baseNova = false;
       
        public void CriandoBaseDados()
        {
           //nomeBase = Application.StartupPath + @"GuerreirosDoFuturo.db";
            // caminhoBase = @"Data Source = " + nomeBase + "; Version = 3";
            if (!File.Exists(nomeBase))
            {
                baseNova = true;
                SQLiteConnection.CreateFile(nomeBase);
                conexao.Open();
                CriandoTabelas(baseNova); // True para tabela no
            }
        }

        private void CriandoTabelas(bool baseNova)
        {
            SQLiteCommand tabela_aluno, tabela_responsavel;

            #region Criando a tabela 'Aluno'
            tabela_aluno = conexao.CreateCommand();
            // tabela_aluno.CommandText = "CREATE TABLE Aluno (Codigo INTEGER, Nome VARCHAR (50))";
            tabela_aluno.CommandText = "CREATE TABLE Aluno(Codigo INTEGER PRIMARY KEY AUTOINCREMENT,Nome VARCHAR(50),CPF VARCHAR(50),Graduacao VARCHAR (20) ,Sexo CHAR(1) , Nascimento DATE, CodigoResponsavel INT,Criacao DATE,Endereco VARCHAR(255),Contato VARCHAR(15))";
            tabela_aluno.ExecuteNonQuery();
           // #endregion

            #region Criando a tabela 'Responsavel'
            tabela_responsavel = conexao.CreateCommand();
            // tabela_responsavel.CommandText = "CREATE TABLE Responsavel (NomeResponsavel VARHCAR(50))";
            tabela_responsavel.CommandText = "CREATE TABLE Responsavel( Codigo INTEGER PRIMARY KEY AUTOINCREMENT,Nome VARCHAR(50) ,Endereco VARCHAR(50) ,Contato VARCHAR(50) , Parentesco VARCHAR(50))";
            tabela_responsavel.ExecuteNonQuery();
           // #endregion
          #endregion

            #region Inserindo todos os dados de backup
            //if (baseNova == true)
            //{
            //    SQLiteCommand insert_backup = new SQLiteCommand(conexao);
            //    insert_backup.CommandText = File.ReadAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt");
            //    insert_backup.ExecuteNonQuery();
            //}
            #endregion

            conexao.Close();
        }*/
        #endregion

        public String InserindoDados(string nome_aluno, string cpf_aluno, string endereco, string contato_aluno, string contato_responsavel, string graduacao, string nome_responsavel, string cpf_responsavel, string parentesco, DateTime data_nascimento, DateTime inicio_karate, char sexo)
        {
            String teste = "";
            conexao = new SqlConnection(acesso_base);
            conexao.Open();
            String str_inserir_aluno = null;
            String str_inserir_responsavel = null;
            try
            {
                str_inserir_responsavel = "IF NOT EXISTS (select Codigo from Responsavel where Nome = '" + nome_responsavel + "' AND CPF = '" + cpf_responsavel + "')" +
                                         " BEGIN " +
                                        "INSERT INTO Responsavel (Nome, Endereco, Contato,CPF, Parentesco) VALUES ('" +
                                        nome_responsavel + "','" + endereco + "','" + contato_responsavel + "','" + cpf_responsavel + "','" + parentesco + "') END";


                 str_inserir_aluno = "INSERT INTO Aluno (Nome, CPF, Graduacao, Sexo, Nascimento, Criacao, Endereco, Contato,CodigoResponsavel) select '" +
                    nome_aluno + "', '" + cpf_aluno + "', '" + graduacao + "', '" + sexo + "', '" + data_nascimento + "','" + DateTime.Now + "', '" + endereco + "', '" + contato_aluno + "', res.Codigo"
                  + " from Responsavel res WHERE CPF = '" + cpf_responsavel + "'";

                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", str_inserir_responsavel);
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", "\n \n");
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", str_inserir_aluno);
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", "\n \n");

                SqlCommand inserir_aluno = conexao.CreateCommand();
                SqlCommand inserir_responsavel = conexao.CreateCommand();
                inserir_responsavel.CommandText = str_inserir_responsavel;
                inserir_aluno.CommandText = str_inserir_aluno;
                inserir_responsavel.ExecuteNonQuery();
                inserir_aluno.ExecuteNonQuery();
                teste = "Dados inseridos com sucesso.";
            }
            catch (Exception ex)
            {
                teste = "Dados não inseridos.";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return teste;
        }

        public DataTable ListandoDados(bool alunoEspecifico, string consulta)
        {
            using (SqlConnection conexao = new SqlConnection(acesso_base))
            {
                conexao.Open();
                String seleciona_dados = null;
               // String seleciona_dados = "Select res.Codigo, alu.Nome from Aluno alu join Responsavel res on res.Codigo = alu.CodigoResponsavel";
               
                if (alunoEspecifico == false) { 
                    seleciona_dados = "SELECT alu.Codigo, " +
                                                 "alu.Nome, " +
                                                 "alu.CPF," +
                                                 "alu.Graduacao, " +
                                                 "alu.Nascimento, " +
                                                 "alu.Endereco, " +
                                                 "alu.Contato, " +
                                                 "res.Nome," +
                                                 "res.Contato, " +
                                                 "res.CPF," + 
                                                 "res.Parentesco, " +
                                                 "alu.Criacao " +
                                                     "FROM Aluno alu " +
                                                         "JOIN Responsavel res ON res.Codigo = alu.CodigoResponsavel";
                }
                else
                {
                    seleciona_dados = "SELECT alu.Codigo, " +
                                                 "alu.Nome as 'NomeAluno', " +
                                                 "alu.CPF," +
                                                 "alu.Graduacao, " +
                                                 "alu.Nascimento, " +
                                                 "alu.Endereco, " +
                                                 "alu.Contato, " +
                                                 "alu.Sexo, " +
                                                 "res.Nome as 'NomeResponsavel', " +
                                                 "res.Contato as 'ContatoResponsavel', " +
                                                 "res.CPF as 'CPFResponsavel'," +
                                                 "res.Parentesco as 'GrauParentesco', " +
                                                 "alu.Criacao " +
                                                     "FROM Aluno alu " +
                                                         "JOIN Responsavel res ON res.Codigo = alu.CodigoResponsavel " +
                                                         "AND (alu.Nome Like '%" + consulta + "%'  OR alu.CPF = '" + consulta + "' OR alu.Codigo = TRY_CAST('" + consulta + "' as int))";

                }
                DataTable tabela_dados = new DataTable();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(seleciona_dados, acesso_base);
                    adapter.Fill(tabela_dados);
                    return tabela_dados;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return tabela_dados;
            }
        }
    }
}
        