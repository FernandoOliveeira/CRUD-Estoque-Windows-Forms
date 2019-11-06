CREATE DATABASE ESTOQUE COLLATE Latin1_General_100_CI_AS_SC;

GO

USE ESTOQUE;

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
	DESCRICAO NVARCHAR(MAX) NOT NULL,
	DATA_CADASTRO DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL

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


GO



INSERT INTO PRODUTOS VALUES
('Alface Americana', 3.85, 250, '5413217898', '101', '2020-01-01', 'G�ndola 07', 'Americana � s� o nome mesmo, n�o veio dos USA n�o (eu acho)', default),
('Banana Nanica', 6.67, 300, '1289851301', '102', '2019-11-05', 'G�ndola 08', 'Amanh� estraga', default),
('Bisteca Su�na', 8.90, 98, '1238878946', '103', '2019-12-22', 'Freezer Frigor�fico', 'Su�nos n�o vem da Su��a', default),
('Feij�o Camil', 5.49, 312, '8913218898', '104', '2020-03-12','G�ndola 03', 'Feij�o Carioca Tipo 1 Feij�o n�o, � bixxcoito!', default),
('Ma�� Verde', 9.90, 122, '8941321858', '105', '2019-12-22', 'G�ndola 10', 'N�o, essa ma�� n�o � do amor', default),
('Marshmallow Fini', 7.00, 250, '2318987659', '106', '2019-12-22', 'G�ndola 05', 'Marshmallow que n�o da pra por na fogueira igual americano safado', default),
('P�o Franc�s', 0.75, 92, '9874513132', '107', '2019-12-11', 'G�ndola 01','P�o franc�s que veio da it�lia', default),
('Picana', 28.90, 54, '8971987975', '108', '2019-12-22', 'Freezer Frigor�fico', 'Da terceira veia pra frente � cox�o duro', default),
('Salm�o', 25.90, 23, '46189876215', '109', '2019-12-27', 'Freezer Frigor�fico', 'Salm�o que vai ser usado para sushi', default),
('Sorvete Napolitano Kibon', 10.50, 88, '9816264785', '110', '2020-05-22', 'Freezer', 'Tem que beber �gua depois de tomar sorvete - M�es de todas as idades', default)



SELECT * FROM PRODUTOS;