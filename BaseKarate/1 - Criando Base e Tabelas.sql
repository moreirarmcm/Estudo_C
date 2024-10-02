IF NOT EXISTS (select* from sys.databases where name = 'BaseKarate')
BEGIN
	CREATE DATABASE BaseKarate
END;
	
USE BaseKarate

IF NOT EXISTS (select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Aluno')
BEGIN
	CREATE TABLE Aluno(
		Codigo INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(50) NOT NULL,
		Graduacao VARCHAR (12) NOT NULL,
		Sexo CHAR(1),
		Nascimento DATE,
		CodigoResponsavel INT,
		Criacao DATE,
		Endereco VARCHAR(255),
		Telefone VARCHAR(15)
	)
END;

IF NOT EXISTS (select* from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Responsavel')
BEGIN
	CREATE TABLE Responsavel (
		Codigo INT PRIMARY KEY IDENTITY,
		Nome VARCHAR(50) NOT NULL,
		Endereco VARCHAR(50) NOT NULL,
		Telefone VARCHAR(50) NOT NULL,
		Parentesco VARCHAR(50) NOT NULL
	)
END;