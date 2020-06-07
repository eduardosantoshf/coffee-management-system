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
--INSERT INTO Cafes.recibo([ClienteNIF],[EmpNIF],[valor]) VALUES (687643810,241045237,3.40)


--SELECT reciboID FROM Cafes.Recibo;
