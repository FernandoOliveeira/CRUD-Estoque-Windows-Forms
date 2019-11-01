CREATE DATABASE ESTOQUE COLLATE Latin1_General_100_CI_AS_SC;

GO

USE ESTOQUE

GO

CREATE TABLE PRODUTOS(
	ID_PRODUTOS INT PRIMARY KEY IDENTITY(1,1),
	NOME NVARCHAR(100) NOT NULL,
	PRECO DECIMAL(10,2) NOT NULL,
	QUANTIDADE INT NOT NULL,
	COD_BARRAS NVARCHAR(100) NOT NULL,
	COD_PRODUTO NVARCHAR(100) NOT NULL,
	DATA_VALIDADE DATE DEFAULT CURRENT_TIMESTAMP NOT NULL,
	LOCAL_ARMAZENADO NVARCHAR(100) NOT NULL,
	DESCRICAO NVARCHAR(MAX) NOT NULL

)


GO

CREATE TABLE VENDAS(
	ID_VENDAS INT PRIMARY KEY IDENTITY(1,1),
	VALOR_UNITARIO DECIMAL(10,2) NOT NULL,
	QUANTIDADE_VENDIDA INT NOT NULL,
	VALOR_TOTAL_VENDA DECIMAL(10,2) NOT NULL,
	DATA_VENDA DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,
	ID_PRODUTOS INT,

	FOREIGN KEY (ID_PRODUTOS) REFERENCES PRODUTOS(ID_PRODUTOS)

)