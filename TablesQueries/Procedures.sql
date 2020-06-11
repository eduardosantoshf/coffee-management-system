
--Procedure to insert new administrator, hashing the password before inserting the hash into the password column 
--on the table Cafes.Administrador
/*
ALTER PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30), @NIF INT)
AS
	BEGIN
		INSERT INTO Cafes.Administrador([username],[pwd],[NIF]) VALUES (@username, HASHBYTES('MD5', @pwd), @NIF);
	END
GO

--------------------------------------------------------

--Procedure to verify login, first verifying if the username exists in the database,if it does verify the pwd, 
--and because we cannot "unhash" the password, we hash the inserted pwd at the login and check if the new hash 
--is the same as the stored password hash, if this is true, the procedure returns 1, meaning "success"

CREATE PROCEDURE [dbo].[verifyLogin](@username VARCHAR(30), @pass VARCHAR(30))
AS
BEGIN
    declare @flag int;
    DECLARE @temp_username VARCHAR(30);
    SET @temp_username = (SELECT username FROM Cafes.Administrador WHERE username = @username AND [pwd] = HASHBYTES('MD5', @pass))
    IF (@temp_username IS NULL)
        SET @flag = 0
    ELSE
        SET @flag = 1
    END
    return @flag
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[insertRecibo](@ClienteNIF INT, @EmpNIF INT, @data_recibo DATE, @valor FLOAT)
AS
	BEGIN 
		INSERT INTO Cafes.Recibo(ClienteNIF, EmpNIF, data_recibo, valor)
		SELECT @ClienteNIF, @EmpNIF, cast(@data_recibo as date), @valor
	END
GO

--------------------------------------------------------

Create PROCEDURE [dbo].[removeRecibo](@rID INT)
AS
	BEGIN
		DELETE FROM Cafes.Recibo WHERE reciboID = @rID
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[addProduto](@nomeP VARCHAR(20), @precoP FLOAT, @tipoP INT)
AS
	BEGIN
		INSERT INTO Cafes.Produto(nomeP, precoP, tipoP)
		SELECT @nomeP, @precoP, @tipoP
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeProduto](@pID INT)
AS
	BEGIN
		DELETE FROM Cafes.Produto WHERE ID_P = @pID
	END
GO

--------------------------------------------------------

--To get the ID from the last invoice, and because with each new inserted
--the ID is the anterior ID +1, we only have to get the max ID

CREATE PROCEDURE [dbo].[getLastReciboID](@lastID INT OUTPUT)
AS
BEGIN
	declare @lastID integer;
	SET @lastID = (Select MAX(reciboID) FROM Cafes.Recibo);
	return @lastID
END

--------------------------------------------------------

--To get the ID from the last product, and because with each new inserted
--the ID is the anterior ID +1, we only have to get the max ID

CREATE PROCEDURE [dbo].[getLastProdutoID]
AS
	BEGIN
		declare @lastID integer;
		SET @lastID = (Select MAX(ID_P) FROM Cafes.Produto);
		return @lastID
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[insertCompra](@reciboID INT, @produtoID INT)
AS
	BEGIN
		INSERT INTO Cafes.Compra([Recibo_ID],[Produto_ID]) VALUES (@reciboID, @produtoID);
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getBebidas]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 1;
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getAlcool]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 2;
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getAlmocos]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 3;
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getPasteis]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 4;
	END
GO

--------------------------------------------------------

CREATE PROCEDURE editProduto(@ID_P INT, @precoP FLOAT)
AS
	BEGIN
		UPDATE Cafes.Produto
		SET  [precoP] = @precoP WHERE [ID_P] = @ID_P;
	END
GO

--------------------------------------------------------

--When this procedure is called, it calls the trigger Cafes.checkEmpregado, wich checks if the Empregado to be added is
--already on the database (on the table Pessoa), and, if not, adds it to the table Pessoa and then to the table Empregado

CREATE PROCEDURE insertEmpregado(@NIF INT, @NIF_cafe INT, @idade INT, @nome VARCHAR(30), @data_inic_contrato DATE)
AS
	BEGIN
		INSERT INTO Cafes.Empregado([NIF],[NIF_cafe],[idade],[nome],[data_inic_contrato]) VALUES(@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
	END
GO

--------------------------------------------------------

--When this procedure is called, it calls the trigger Cafes.checkCliente, wich checks if the Cliente to be added is
--already on the database (on the table Pessoa), and, if not, adds it to the table Pessoa and then to the table Cliente

CREATE PROCEDURE insertCliente(@NIF INT, @nome VARCHAR(30))
AS
	BEGIN
		INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getProdutosInRecibo](@reciboID INT)
AS
    BEGIN
        Select Produto.*,Cafes.Compra.[quantidade] from Cafes.Compra join Cafes.Recibo on Cafes.Compra.Recibo_ID = Cafes.Recibo.reciboID Join Cafes.Produto on Cafes.Produto.ID_P = Cafes.Compra.Produto_ID where Cafes.Recibo.reciboID = @reciboID
    END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeEmpregado](@EmpNIF INT)
AS
	BEGIN
		DELETE FROM Cafes.Empregado WHERE NIF = @EmpNIF
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeCliente](@ClienteNIF INT)
AS
	BEGIN
		DELETE FROM Cafes.Cliente WHERE NIF = @ClienteNIF
	END
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getProdutoQ](@ID_P INT)
AS
    BEGIN
        DECLARE @quantidade INT;
        SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE [Produto_ID] = @ID_P);
        RETURN @quantidade;
    END
GO
*/