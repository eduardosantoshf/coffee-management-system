/*
BEGIN
	PRINT 'Teste'
	RETURN
END
*/
/*
GO
CREATE PROCEDURE Cafes.GetEmpregado
AS
	SET NOCOUNT ON; 
	SELECT nome
	FROM Cafes.Empregado AS nn
	print nn
RETURN
GO
*/

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
*/

--drop procedure insertRecibo;
--EXEC insertRecibo 687643810, 241045237, 3.75;
--SELECT * FROM Cafes.Recibo;

/*
ALTER PROCEDURE [dbo].[removeRecibo](@rID INT)
AS
BEGIN
	DELETE FROM Cafes.Recibo WHERE reciboID = @rID
END
*/
--EXEC removeRecibo 4;
--SELECT * FROM Cafes.Recibo;

/*
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
CREATE PROCEDURE [dbo].[removeProduto](@pID INT)
AS
BEGIN
	DELETE FROM Cafes.Produto WHERE ID_P = @pID
END
*/
--EXEC removeProduto 1;
--SELECT * FROM Cafes.Produto;
