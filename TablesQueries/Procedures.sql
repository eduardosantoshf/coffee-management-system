/*
CREATE PROCEDURE [dbo].[insertRecibo](@ClienteNIF INT, @EmpNIF INT, @data_recibo DATE, @valor FLOAT)
AS
BEGIN 
	INSERT INTO Cafes.recibo(ClienteNIF, EmpNIF, data_recibo, valor)
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

--EXEC addProduto café, 0.65, 1;
--SELECT * FROM Cafes.Produto;

GO
CREATE PROCEDURE [dbo].[removeProduto](@pID INT)
AS
BEGIN
	DELETE FROM Cafes.Produto WHERE ID_P = @pID
END

--EXEC removeProduto 1;
--SELECT * FROM Cafes.Produto;


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


ALTER PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30))
AS
BEGIN
	INSERT INTO Cafes.Administrador([username],[pwd]) VALUES (@username, HASHBYTES('MD5', @pwd));
END;
*/



/*
CREATE PROCEDURE [dbo].[verifyLogin](@username VARCHAR(30), @pwd VARCHAR(30), @flag INT OUTPUT)
AS
BEGIN
	DECLARE @temp_pwd VARBINARY(36);
	SET @temp_pwd = (SELECT pwd FROM Cafes.Administrador)
	IF (HASHBYTES('MD5', @pwd) = @temp_pwd)
		SET @flag = 1
	ELSE
		SET @flag = 0
END
*/

--EXEC insertAdministrador 'administrador', 'palavrachave';
DECLARE @flag2 INT;
EXEC verifyLogin 'ola', 'palavrachave', @flag2 OUTPUT; --Should return 1
PRINT @flag2;
