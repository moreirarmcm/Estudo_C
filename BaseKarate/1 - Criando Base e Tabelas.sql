CREATE DATABASE BaseKarate

USE BaseKarate

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

CREATE TABLE Responsavel (
	Codigo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL,
	Endereco VARCHAR(50) NOT NULL,
	Telefone VARCHAR(50) NOT NULL,
	Parentesco VARCHAR(50) NOT NULL
)	