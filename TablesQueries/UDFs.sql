/*
CREATE FUNCTION [dbo].[checkPessoa](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Pessoa AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO


CREATE FUNCTION [dbo].[checkQuantidadeProduto](@ID_P INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra AS C WHERE C.Produto_ID = @ID_P)
			RETURN 1;
		RETURN 0;
	END
GO



CREATE FUNCTION [dbo].[getProdutoQuantidade](@ID_P INT) RETURNS INT
AS
	BEGIN
		DECLARE @quantidade INT;
		SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE [Produto_ID] = @ID_P);
		RETURN @quantidade;
	END
GO
*/