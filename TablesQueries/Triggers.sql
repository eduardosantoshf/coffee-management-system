/*
CREATE TRIGGER Cafes.checkEmpregado ON Cafes.Empregado
INSTEAD OF INSERT
AS
	BEGIN
		DECLARE @NIF INT;
		DECLARE @NIF_cafe INT;
		DECLARE @idade INT;
		DECLARE @nome VARCHAR(30);
		DECLARE @data_inic_contrato DATE;
		SELECT @NIF = NIF, @nome = nome, @NIF_cafe = NIF_cafe, @idade = idade, @nome = nome, @data_inic_contrato = data_inic_contrato  FROM inserted;
		IF ([dbo].[checkPessoa](@NIF, @nome) = 1)
			RAISERROR('Já existe',16,1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
			END
	END
GO

CREATE TRIGGER Cafes.checkCliente ON Cafes.Cliente
INSTEAD OF INSERT
AS
	BEGIN
		DECLARE @NIF INT;
		DECLARE @nome VARCHAR(30);;
		SELECT @NIF = NIF, @nome = nome FROM inserted;
		IF ([dbo].[checkPessoa](@NIF, @nome) = 1)
			RAISERROR('Já existe',16,1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			END
	END
GO
*/