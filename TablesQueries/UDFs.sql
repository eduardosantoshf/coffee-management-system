/*
CREATE FUNCTION [dbo].[checkPessoa](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Pessoa AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO


ALTER FUNCTION [dbo].[checkQuantidadeProduto](@Produto_ID INT, @Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID))
			RETURN 1;
		RETURN 0;
	END
GO

CREATE FUNCTION [dbo].[getProdutoQuantidade](@Produto_ID INT, @Recibo_ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @quantidade INT;
		SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID));
		RETURN @quantidade;
	END
GO

ALTER FUNCTION [dbo].[checkReciboInCompra](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra AS C WHERE C.Recibo_ID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO


ALTER FUNCTION [dbo].[checkReciboInRecibo](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Recibo AS R WHERE R.reciboID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO
*/

