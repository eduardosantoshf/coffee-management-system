/*
CREATE FUNCTION [dbo].[checkPessoa](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Pessoa AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO
*/
/*
DECLARE @r INT;
SET @r = [dbo].[checkPessoa](132063497, 'Megan Wise');
PRINT @r
*/