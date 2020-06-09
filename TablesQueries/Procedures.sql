
--INSERT INTO Cafes.recibo([ClienteNIF],[EmpNIF],[valor]) VALUES (296969668,241045237,2.7);
--INSERT INTO Cafes.recibo([ClienteNIF],[EmpNIF],[valor]) VALUES (687643810,241045237,3.40);


--SELECT reciboID FROM Cafes.Recibo;

--DROP PROCEDURE Cafes.GetEmpregado;

/*
ALTER PROCEDURE [dbo].[insertRecibo](@ClienteNIF INT, @EmpNIF INT, @data_recibo DATE, @valor FLOAT)
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
*/
--EXEC removeProduto 1;
--SELECT * FROM Cafes.Produto;


--This selects the last (max) ID from products' table
--SELECT MAX(ID_P) FROM Cafes.Produto;


/*
CREATE PROCEDURE [dbo].[getLastReciboID](@lastID INT OUTPUT)
AS
BEGIN
	SELECT @lastID = MAX(reciboID) FROM Cafes.Recibo;
END
*/
--DROP PROCEDURE [dbo].[getLastReciboID]

/*l
DECLARE @lastID INT;
EXEC getLastReciboID @lastID OUTPUT;
PRINT @lastID;
*/

--EXEC getLastReciboID

/*
CREATE PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30))
AS
BEGIN
	INSERT INTO Cafes.Administrador([username],[pwd]) VALUES ('Admin', HASHBYTES('MD5', @pwd));
END;
*/

--EXEC insertAdministrador 'Admin', 'palavrapasse';
--SELECT * FROM Cafes.Administrador;