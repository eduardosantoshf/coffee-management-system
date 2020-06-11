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

CREATE TRIGGER [Cafes].[checkInsertProduto] ON [Cafes].[Compra]
INSTEAD OF INSERT
AS
    BEGIN
        DECLARE @Recibo_ID INT;
        DECLARE @Produto_ID INT;
        DECLARE @newQuantidade INT;
        SELECT @Recibo_ID = Recibo_ID, @Produto_ID = Produto_ID FROM INSERTED;
        IF ([dbo].[checkQuantidadeProduto](@Produto_ID) = 0)
                INSERT INTO Cafes.Compra([Recibo_ID], [Produto_ID], [quantidade]) VALUES (@Recibo_ID, @Produto_ID, 1);
        ELSE
            BEGIN
                SET @newQuantidade = [dbo].[getProdutoQuantidade](@Produto_ID) + 1;
                UPDATE Cafes.Compra
                SET [quantidade] = @newQuantidade;
            END
    END
GO

CREATE TRIGGER Cafes.checkRemoveRecibo ON Cafes.Recibo
INSTEAD OF DELETE
AS
	BEGIN
		DECLARE @reciboID INT;
		SELECT @reciboID = reciboID FROM DELETED;
		IF (([dbo].[checkReciboInCompra](@reciboID) = 1) OR ([dbo].[checkReciboInRecibo](@reciboID) = 1))
			BEGIN
				--RAISERROR('Teste',16,1);
				DELETE FROM Cafes.Compra WHERE [Recibo_ID] IN (SELECT reciboID FROM DELETED);
				DELETE FROM Cafes.Recibo WHERE [reciboID] IN (SELECT reciboID FROM DELETED);
			END
		ELSE
			BEGIN
				RAISERROR('Esse recibo não existe',16,1);
			END
	END
GO
*/

