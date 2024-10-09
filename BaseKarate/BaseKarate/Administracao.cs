using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Mysqlx.Crud;
using System.Data.SqlClient;

namespace BaseKarate
{
    internal class Administracao
    {
        private static String nomeBase = Application.StartupPath + @"GuerreirosDoFuturo.db";
        private static String caminhoBase = @"Data Source = " + nomeBase + "; Version = 3";
        private SQLiteConnection conexao = new SQLiteConnection(caminhoBase);
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
            tabela_aluno.CommandText = @"CREATE TABLE IF NOT EXISTS Aluno(
                                                Codigo INT PRIMARY KEY AUTOINCREMENT,
		                                        Nome VARCHAR(50) NOT NULL,
		                                        CPF VARCHAR(50) NOT NULL,
                                                Graduacao VARCHAR (12) NOT NULL,
		                                        Sexo CHAR(1) NOT NULL CHECK (Sexo IN('M','F')),
		                                        Nascimento DATE,
		                                        CodigoResponsavel INT,
		                                        Criacao DATE,
		                                        Endereco VARCHAR(255),
		                                        Telefone VARCHAR(15)
	                                         )";
            tabela_aluno.ExecuteNonQuery();
            #endregion

            #region Criando a tabela 'Responsavel'
            tabela_responsavel = conexao.CreateCommand();
            tabela_responsavel.CommandText = @"CREATE TABLE IF NOT EXISTS Responsavel(
                                               Codigo INT PRIMARY KEY AUTOINCREMENT,
                                               Nome VARCHAR(50) NOT NULL,
                                               Endereco VARCHAR(50) NOT NULL,
                                               Telefone VARCHAR(50) NOT NULL,
                                               Parentesco VARCHAR(50) NOT NULL CHECK (Parentesco IN('Mãe/Pai','Irmão/Irmã','Tio/Tia','Avô/Avó','Primo/Prima')
	                                         )";
            tabela_responsavel.ExecuteNonQuery();
            #endregion

            #region Inserindo todos os dados de backup
            if (baseNova == true)
            {
                SQLiteCommand insert_backup = new SQLiteCommand(conexao);
                insert_backup.CommandText = File.ReadAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt");
                insert_backup.ExecuteNonQuery();
            }
            #endregion
            
            conexao.Close();
        }

        public void InserindoDados(string nome_aluno, string cpf_aluno, string endereco, string telefone_aluno, string telefone_responsavel, string graduacao, string nome_responsavel, string cpf_responsavel, string parentesco, DateTime data_nascimento, DateTime inicio_karate, char sexo)
        {
            conexao = new SQLiteConnection(caminhoBase);
            conexao.Open();
            String str_inserir_aluno = null;
            String str_inserir_responsavel = null;
            try

            {
                str_inserir_responsavel = "IF NOT EXISTS (select Codigo from Responsavel where Nome = '" + nome_responsavel + "' AND CPF = '" + cpf_responsavel + "')"
                                        + " BEGIN " 
                                        + "INSERT INTO Responsavel (Nome, Endereco, Telefone, Parentesco) VALUES (" 
                                        + "'" + nome_responsavel + "','" + endereco + "','" + telefone_responsavel + "','" + parentesco + "')";


                str_inserir_aluno = "INSERT INTO Aluno(Nome, CPF, Graduacao, Sexo, Nascimento, CodigoResponsavel, Criacao, Endereco, Telefone) SELECT '" + nome_aluno + "', '" + cpf_aluno + "', '" + graduacao + "', '" + sexo + "', " + data_nascimento.Date + ", '" + "CPF" + "', " + DateTime.Now + ", '" + endereco + "', '" + telefone_aluno 
                  + "' from Responsavel WHERE CPF = '" + cpf_responsavel + "'";

                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", str_inserir_responsavel);
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", "\n \n");
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", str_inserir_aluno);
                File.AppendAllText("C:\\Users\\morei\\Documents\\GitHub\\Estudo_C\\BaseKarate\\DadosKarate.txt", "\n \n");

                SQLiteCommand inserir_aluno = conexao.CreateCommand();
                SQLiteCommand inserir_responsavel = conexao.CreateCommand();
                inserir_responsavel.CommandText = str_inserir_responsavel;
                inserir_aluno.CommandText = str_inserir_aluno;
                inserir_responsavel.ExecuteNonQuery();
                inserir_aluno.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
        