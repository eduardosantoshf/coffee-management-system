/*
ALTER PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30))
AS
BEGIN
	INSERT INTO Cafes.Administrador([username],[pwd]) VALUES (@username, HASHBYTES('MD5', @pwd));
END;
*/
/*
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
*/
/*
DECLARE @flag2 INT;
EXEC verifyLogin 'ola', 'palavrachave', @flag2 OUTPUT;
PRINT @flag2;
*/


/*
CREATE PROCEDURE [dbo].[insertRecibo](@ClienteNIF INT, @EmpNIF INT, @data_recibo DATE, @valor FLOAT)
AS
BEGIN 
	INSERT INTO Cafes.Recibo(ClienteNIF, EmpNIF, data_recibo, valor)
	SELECT @ClienteNIF, @EmpNIF, cast(@data_recibo as date), @valor
END


--drop procedure insertRecibo;
--EXEC insertRecibo 687643810, 241045237, 3.75;
--SELECT * FROM Cafes.Recibo; 

GO
Create PROCEDURE [dbo].[removeRecibo](@rID INT)
AS
BEGIN
	DELETE FROM Cafes.Recibo WHERE reciboID = @rID
END

--EXEC removeRecibo 4;
--SELECT * FROM Cafes.Recibo;

GO
CREATE PROCEDURE [dbo].[addProduto](@nomeP VARCHAR(20), @precoP FLOAT, @tipoP INT)
AS
BEGIN
	INSERT INTO Cafes.Produto(nomeP, precoP, tipoP)
	SELECT @nomeP, @precoP, @tipoP
END
*/
--EXEC addProduto café, 0.65, 1;
--SELECT * FROM Cafes.Produto;
/*
GO
CREATE PROCEDURE [dbo].[removeProduto](@pID INT)
AS
BEGIN
	DELETE FROM Cafes.Produto WHERE ID_P = @pID
END
*/
--EXEC removeProduto 3;
--SELECT * FROM Cafes.Produto;
/*

--This selects the last (max) ID from products' table
--SELECT MAX(ID_P) FROM Cafes.Produto;



CREATE PROCEDURE [dbo].[getLastReciboID](@lastID INT OUTPUT)
AS
BEGIN
	SELECT @lastID = MAX(reciboID) FROM Cafes.Recibo;
END

--DROP PROCEDURE [dbo].[getLastReciboID]


DECLARE @lastID INT;
EXEC getLastReciboID @lastID OUTPUT;
PRINT @lastID;


--EXEC getLastReciboID
*/
/*
CREATE PROCEDURE [dbo].[insertCompra](@reciboID INT, @produtoID INT)
AS
BEGIN
	INSERT INTO Cafes.Compra([Recibo_ID],[Produto_ID]) VALUES (@reciboID, @produtoID);
END

--SELECT * FROM Cafes.Recibo;
--SELECT * FROM Cafes.Produto;
--EXEC insertCompra 1, 2;
--SELECT * FROM Cafes.Compra;


ALTER PROCEDURE [dbo].[getBebidas]
AS
	BEGIN
		SELECT nomeP, precoP FROM Cafes.Produto WHERE tipoP = 1;
	END
GO


ALTER PROCEDURE [dbo].[getAlcool]
AS
	BEGIN
		SELECT nomeP, precoP FROM Cafes.Produto WHERE tipoP = 2;
	END
GO

ALTER PROCEDURE [dbo].[getAlmocos]
AS
	BEGIN
		SELECT nomeP, precoP FROM Cafes.Produto WHERE tipoP = 3;
	END
GO

ALTER PROCEDURE [dbo].[getPasteis]
AS
	BEGIN
		SELECT nomeP, precoP FROM Cafes.Produto WHERE tipoP = 4;
	END
GO
*/
--EXEC getBebidas;
--EXEC getAlcool;
--EXEC getAlmocos;
--EXEC getPasteis;

CREATE TRIGGER [dbo].[checkEmpregado] BEFORE INSERT ON Cafes.Pessoa
FOR EACH ROW
	BEGIN
		




