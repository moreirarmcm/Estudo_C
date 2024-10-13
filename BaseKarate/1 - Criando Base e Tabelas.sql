IF NOT EXISTS (select* from sys.databases where name = 'GuerreirosDoFuturo')
BEGIN
	CREATE DATABASE GuerreirosDoFuturo
	WAITFOR DELAY '00:00:05'

	PRINT 'Base "GuerreirosDoFuturo" Criada;'
END;

--Gambiarra pra impedir o SQL de tentar se conectar antes da finalização da criação da base.
--WHILE (NOT EXISTS(select* from sys.databases where name = 'GuerreirosDoFuturo'))
--BEGIN
--	WAITFOR DELAY '00:00:05'
--END;

USE GuerreirosDoFuturo;

IF NOT EXISTS (select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Aluno')
BEGIN
	CREATE TABLE Aluno(
		Codigo INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(50) NOT NULL,
		CPF VARCHAR(50) NOT NULL,
		Graduacao VARCHAR (50) NOT NULL,
		Sexo CHAR(1) NOT NULL,
		Nascimento DATE,
		CodigoResponsavel INT,
		Criacao DATE,
		Endereco VARCHAR(255),
		Contato VARCHAR(50)
	)
PRINT 'Tabela "Aluno" Criada;'
END;


IF NOT EXISTS (select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Responsavel')
BEGIN
	CREATE TABLE Responsavel (
		Codigo INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(50) NOT NULL,
		Endereco VARCHAR(50) NOT NULL,
		Contato VARCHAR(50) NOT NULL,
		CPF VARCHAR(40) NOT NULL,
		Parentesco VARCHAR(50) NOT NULL
	)
PRINT 'Tabela "Responsavel" Criada;'
END;

IF NOT EXISTS (select Codigo from Responsavel where Nome = 'wefwefwe' AND CPF = 'fwefwefwe') BEGIN INSERT INTO Responsavel (Nome, Endereco, Contato, Parentesco,CPF) VALUES ('wefwefwe','ddfwfwfwe','efwefwefw','Irmão/Irmã','11111') END
 
INSERT INTO Aluno (Nome, CPF, Graduacao, Sexo, Nascimento, Criacao, Endereco, Contato,CodigoResponsavel) select 'Renan Moreira', '12345678976', 'Laranja (4° Kyu)', 'M', '05/10/2024 23:16:19','12/10/2024 22:43:28', 'ddfwfwfwe', 'wefwefwefwefw', res.Codigo from Responsavel res WHERE CPF = '11111'
 
--DROP DATABASE GuerreirosDoFuturo