using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BaseKarate
{
    internal class Administracao
    {
        private String nomeBase, caminhoBase;
        private SQLiteConnection conexao = null;
        public void CriandoBaseDados()
        {
            nomeBase = Application.StartupPath + @"GuerreirosDoFuturo.db";
            caminhoBase = @"Data Source = " + nomeBase + "; Version = 3";
            if (!File.Exists(nomeBase))
            {
                SQLiteConnection.CreateFile(nomeBase);
            }
            conexao = new SQLiteConnection(nomeBase);
            try
            {
                conexao.Open();
                CriandoTabelas();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CriandoTabelas()
        {
            SQLiteCommand tabela_aluno, tabela_responsavel;
            #region Tabela Aluno
            tabela_aluno = conexao.CreateCommand();
            tabela_aluno.CommandText = @"CREATE TABLE IF NOT EXISTS Aluno(
                                                Codigo INT PRIMARY KEY AUTOINCREMENT,
		                                        Nome VARCHAR(50) NOT NULL,
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

            #region Tabela Responsável
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
        }

    }
}
        