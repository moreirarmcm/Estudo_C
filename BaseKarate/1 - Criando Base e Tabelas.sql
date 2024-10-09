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
		Graduacao VARCHAR (12) NOT NULL,
		Sexo CHAR(1),
		Nascimento DATE,
		CodigoResponsavel INT,
		Criacao DATE,
		Endereco VARCHAR(255),
		Telefone VARCHAR(15)
	)
PRINT 'Tabela "Aluno" Criada;'
END;

INSERT INTO Aluno (Nome,Graduacao,Sexo,Nascimento,Criacao,Endereco,Telefone

IF NOT EXISTS (select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Responsavel')
BEGIN
	CREATE TABLE Responsavel (
		Codigo INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(50) NOT NULL,
		Endereco VARCHAR(50) NOT NULL,
		Telefone VARCHAR(50) NOT NULL,
		Parentesco VARCHAR(50) NOT NULL
	)
PRINT 'Tabela "Responsavel" Criada;'
END;

--DROP DATABASE GuerreirosDoFuturo