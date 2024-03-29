USE [master]
GO
/****** Object:  Database [p2g1]    Script Date: 12/06/2020 15:48:17 ******/
CREATE DATABASE [p2g1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'p2g1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\p2g1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'p2g1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\p2g1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [p2g1] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [p2g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [p2g1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [p2g1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [p2g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [p2g1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [p2g1] SET ARITHABORT OFF 
GO
ALTER DATABASE [p2g1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [p2g1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [p2g1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [p2g1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [p2g1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [p2g1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [p2g1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [p2g1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [p2g1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [p2g1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [p2g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [p2g1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [p2g1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [p2g1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [p2g1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [p2g1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [p2g1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [p2g1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [p2g1] SET  MULTI_USER 
GO
ALTER DATABASE [p2g1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [p2g1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [p2g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [p2g1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [p2g1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [p2g1] SET QUERY_STORE = OFF
GO
USE [p2g1]
GO
/****** Object:  User [p2g1]    Script Date: 12/06/2020 15:48:17 ******/
CREATE USER [p2g1] FOR LOGIN [p2g1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [p2g1]
GO
/****** Object:  Schema [Cafes]    Script Date: 12/06/2020 15:48:17 ******/
CREATE SCHEMA [Cafes]
GO
/****** Object:  UserDefinedFunction [dbo].[checkCl]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
CREATE FUNCTION [dbo].[checkCl](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Cliente AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkClienteByNIF]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[checkClienteByNIF](@NIF INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Cliente AS P WHERE P.NIF = @NIF)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkEmp]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

CREATE FUNCTION [dbo].[checkEmp](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Empregado AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkEmpregadoByNIF]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
CREATE FUNCTION [dbo].[checkPessoa](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Pessoa AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO

CREATE FUNCTION [dbo].[checkCl](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Cliente AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO

CREATE FUNCTION [dbo].[checkEmp](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Empregado AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO

CREATE FUNCTION [dbo].[checkQuantidadeProduto](@Produto_ID INT, @Recibo_ID INT) RETURNS INT
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

CREATE FUNCTION [dbo].[checkReciboInCompra](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra AS C WHERE C.Recibo_ID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO


CREATE FUNCTION [dbo].[checkReciboInRecibo](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Recibo AS R WHERE R.reciboID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO
*/

CREATE FUNCTION [dbo].[checkEmpregadoByNIF](@NIF INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Empregado AS P WHERE P.NIF = @NIF)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkPessoa]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkPessoa](@NIF INT, @nome VARCHAR(30)) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Pessoa AS P WHERE P.NIF = @NIF AND P.nome = @nome)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkQuantidadeProduto]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[checkQuantidadeProduto](@Produto_ID INT, @Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID))
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkReciboInCompra]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[checkReciboInCompra](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Compra AS C WHERE C.Recibo_ID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[checkReciboInRecibo]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[checkReciboInRecibo](@Recibo_ID INT) RETURNS INT
AS
	BEGIN
		IF EXISTS(SELECT * FROM Cafes.Recibo AS R WHERE R.reciboID = @Recibo_ID)
			RETURN 1;
		RETURN 0;
	END
GO
/****** Object:  UserDefinedFunction [dbo].[getProdutoQuantidade]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[getProdutoQuantidade](@Produto_ID INT, @Recibo_ID INT) RETURNS INT
AS
	BEGIN
		DECLARE @quantidade INT;
		SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID));
		RETURN @quantidade;
	END
GO
/****** Object:  Table [Cafes].[Administrador]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Administrador](
	[username] [varchar](30) NOT NULL,
	[pwd] [varbinary](36) NOT NULL,
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC,
	[nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Bartender]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Bartender](
	[NIF] [int] NOT NULL,
	[NIF_cafeB] [int] NOT NULL,
	[idade] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[data_inic_contrato] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cafe]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cafe](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[morada] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cafe_Bar]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cafe_Bar](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[morada] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cafe_Pastelaria]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cafe_Pastelaria](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[morada] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cafe_Restaurante]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cafe_Restaurante](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[morada] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cliente]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cliente](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Compra]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Compra](
	[Recibo_ID] [int] NOT NULL,
	[Produto_ID] [int] NOT NULL,
	[quantidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Recibo_ID] ASC,
	[Produto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Cozinheiro]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Cozinheiro](
	[NIF] [int] NOT NULL,
	[NIF_cafeR] [int] NOT NULL,
	[idade] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[data_inic_contrato] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Empregado]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Empregado](
	[NIF] [int] NOT NULL,
	[NIF_cafe] [int] NOT NULL,
	[idade] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[data_inic_contrato] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Pasteleiro]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Pasteleiro](
	[NIF] [int] NOT NULL,
	[NIF_cafeP] [int] NOT NULL,
	[idade] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[data_inic_contrato] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Pessoa]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Pessoa](
	[NIF] [int] NOT NULL,
	[nome] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NIF] ASC,
	[nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Produto]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Produto](
	[nomeP] [varchar](20) NOT NULL,
	[ID_P] [int] IDENTITY(1,1) NOT NULL,
	[precoP] [float] NOT NULL,
	[tipoP] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_P] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Cafes].[Recibo]    Script Date: 12/06/2020 15:48:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Cafes].[Recibo](
	[reciboID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteNIF] [int] NOT NULL,
	[EmpNIF] [int] NOT NULL,
	[data_recibo] [date] NULL,
	[valor] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[reciboID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [Cafes].[Administrador] ([username], [pwd], [NIF], [nome]) VALUES (N'profBD', 0xE670AACE19F68E6372742489C45BDE5C, 322850048, N'Professor')
INSERT [Cafes].[Administrador] ([username], [pwd], [NIF], [nome]) VALUES (N'dudu', 0xCAF1A3DFB505FFED0D024130F58C5CFA, 806344901, N'Eduardo Santos')
INSERT [Cafes].[Administrador] ([username], [pwd], [NIF], [nome]) VALUES (N'quimf', 0x8C5CBB8EED37D6B153C5E15265A7410C, 820473910, N'Joaquim Freitas')
INSERT [Cafes].[Administrador] ([username], [pwd], [NIF], [nome]) VALUES (N'didi', 0x202CB962AC59075B964B07152D234B70, 836401127, N'Diogo Moreira')
GO
INSERT [Cafes].[Cafe] ([NIF], [nome], [morada]) VALUES (411766585, N'E-Cafe', N'Rua da Buba')
GO
INSERT [Cafes].[Cafe_Bar] ([NIF], [nome], [morada]) VALUES (411766585, N'E-Cafe', N'Rua da Buba')
GO
INSERT [Cafes].[Cafe_Pastelaria] ([NIF], [nome], [morada]) VALUES (411766585, N'E-Cafe', N'Rua da Buba')
GO
INSERT [Cafes].[Cafe_Restaurante] ([NIF], [nome], [morada]) VALUES (411766585, N'E-Cafe', N'Rua da Buba')
GO
INSERT [Cafes].[Cliente] ([NIF], [nome]) VALUES (213456321, N'Erick Jackson')
INSERT [Cafes].[Cliente] ([NIF], [nome]) VALUES (379923298, N'Anjolie Peck')
INSERT [Cafes].[Cliente] ([NIF], [nome]) VALUES (987123654, N'John Smith')
GO
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (1, 2, 4)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (1, 17, 9)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (1, 25, 6)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (1, 27, 2)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (2, 2, 5)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (2, 13, 1)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (2, 14, 5)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (2, 15, 2)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (2, 25, 6)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (3, 24, 14)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (4, 14, 13)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (4, 24, 11)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (5, 14, 2)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (5, 21, 1)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (5, 25, 8)
INSERT [Cafes].[Compra] ([Recibo_ID], [Produto_ID], [quantidade]) VALUES (5, 27, 1)
GO
INSERT [Cafes].[Empregado] ([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (111111111, 411766585, 24, N'Chris Orange', CAST(N'2020-06-11' AS Date))
INSERT [Cafes].[Empregado] ([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (567489321, 411766585, 35, N'Pinto Costa', CAST(N'2020-05-01' AS Date))
GO
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (98765432, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (111111111, N'Chris Orange')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123123123, N'Jose Carvalho')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123321321, N'Guilherme Moreira')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123432156, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123454321, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123455432, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123456788, N'Antonio Maria')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123456789, N'Paula Ramirez')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (123987045, N'Pedro Andrade')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (132063497, N'Megan Wise')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (142550724, N'Xenos Brady')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (190289378, N'Diogo Moreira')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (213456321, N'Erick Jackson')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (213758999, N'Jose Pereira')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (225537635, N'Fuller Glass')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (231915681, N'Haviva Holloway')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (235889530, N'Iris Greene')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (236696799, N'Axel Lowe')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (241045237, N'Winifred Walter')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (259143494, N'Uma Mason')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (268189127, N'Dylan Maynard')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (283922644, N'Jose Pereira')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (293595015, N'Quentin Santana')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (294939603, N'Chastity Gay')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (296969668, N'Angelica Maldonado')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (321972703, N'Jacob Guy')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (322850048, N'Professor')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (323856495, N'Aaron Valdez')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (332426721, N'Ginger Mclaughlin')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (353381104, N'Frances Douglas')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (369024440, N'Bruce Hines')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (369437051, N'Leroy Everett')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (379923298, N'Anjolie Peck')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (379932298, N'Anjolie Peck')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (429529859, N'Roth Holcomb')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (443138848, N'Connor Brady')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (452467352, N'Price Whitfield')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (455491867, N'Yvonne Lowery')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (473829019, N'Eduardo Santos')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (477154900, N'Honorato Crawford')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (481192418, N'Arthur Greene')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (497784251, N'Noelani Freeman')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (508174850, N'Medge Trevino')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (513196871, N'Jared Berg')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (513696290, N'John Franklin')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (547916021, N'Branden Cherry')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (567489321, N'Pinto Costa')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (567765567, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (568333318, N'Candace Case')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (593505493, N'Shad Gill')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (608068232, N'Martin Estrada')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (629328443, N'Beau Phillips')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (657432891, N'Pedro Torres')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (687643810, N'Tate Stout')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (723657350, N'Magee Carey')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (766186809, N'Joan Guthrie')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (770167696, N'Hadassah Mcdonald')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (797610436, N'Sara Wilkins')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (799631594, N'Alana Tyson')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (802270517, N'Iliana Ballard')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (806344901, N'Eduardo Santos')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (810577576, N'Avye Hancock')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (820473910, N'Joaquim Freitas')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (836401127, N'Diogo Moreira')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (848484848, N'Diogo Emanuel')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (874054574, N'Medge Frost')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (884448426, N'Gay Bond')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (888777666, N'Teste')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (894940017, N'Cameron Nieves')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (896728691, N'Chiquita Head')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (899461477, N'Gary Roy')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (900541552, N'Walker Fox')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (918313660, N'Demetria Erickson')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (943234234, N'Pierce Jackson')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (949597097, N'Libby Francis')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (987123654, N'John Smith')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (987654321, N'Pedro Santos')
INSERT [Cafes].[Pessoa] ([NIF], [nome]) VALUES (987789987, N'Teste')
GO
SET IDENTITY_INSERT [Cafes].[Produto] ON 

INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Compal', 2, 1, 1)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Prego no Prato', 13, 5, 3)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Francesinha', 14, 5.5, 3)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Caldo Verde', 15, 2.6, 3)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Croissant', 17, 0.8, 4)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Cafe', 21, 0.550000011920929, 1)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Ucal', 22, 1.1000000238418579, 1)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Vodka', 23, 1, 2)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Gin Tonico', 24, 4.5, 2)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Cerveja', 25, 0.89999997615814209, 2)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Tranca', 26, 2.5, 4)
INSERT [Cafes].[Produto] ([nomeP], [ID_P], [precoP], [tipoP]) VALUES (N'Nata', 27, 0.44999998807907104, 4)
SET IDENTITY_INSERT [Cafes].[Produto] OFF
GO
SET IDENTITY_INSERT [Cafes].[Recibo] ON 

INSERT [Cafes].[Recibo] ([reciboID], [ClienteNIF], [EmpNIF], [data_recibo], [valor]) VALUES (1, 473829019, 123456789, CAST(N'2020-06-08' AS Date), 9.84999942779541)
INSERT [Cafes].[Recibo] ([reciboID], [ClienteNIF], [EmpNIF], [data_recibo], [valor]) VALUES (2, 943234234, 111111111, CAST(N'2020-06-12' AS Date), 48.099998474121094)
INSERT [Cafes].[Recibo] ([reciboID], [ClienteNIF], [EmpNIF], [data_recibo], [valor]) VALUES (3, 379923298, 190289378, CAST(N'2020-06-12' AS Date), 63)
INSERT [Cafes].[Recibo] ([reciboID], [ClienteNIF], [EmpNIF], [data_recibo], [valor]) VALUES (4, 943234234, 379932298, CAST(N'2020-06-12' AS Date), 44.5)
INSERT [Cafes].[Recibo] ([reciboID], [ClienteNIF], [EmpNIF], [data_recibo], [valor]) VALUES (5, 473829019, 190289378, CAST(N'2020-06-23' AS Date), 19.200000762939453)
SET IDENTITY_INSERT [Cafes].[Recibo] OFF
GO
ALTER TABLE [Cafes].[Administrador]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
ALTER TABLE [Cafes].[Bartender]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
ALTER TABLE [Cafes].[Bartender]  WITH CHECK ADD FOREIGN KEY([NIF_cafeB])
REFERENCES [Cafes].[Cafe_Bar] ([NIF])
GO
ALTER TABLE [Cafes].[Cafe_Bar]  WITH CHECK ADD FOREIGN KEY([NIF])
REFERENCES [Cafes].[Cafe] ([NIF])
GO
ALTER TABLE [Cafes].[Cafe_Pastelaria]  WITH CHECK ADD FOREIGN KEY([NIF])
REFERENCES [Cafes].[Cafe] ([NIF])
GO
ALTER TABLE [Cafes].[Cafe_Restaurante]  WITH CHECK ADD FOREIGN KEY([NIF])
REFERENCES [Cafes].[Cafe] ([NIF])
GO
ALTER TABLE [Cafes].[Cliente]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
ALTER TABLE [Cafes].[Compra]  WITH CHECK ADD FOREIGN KEY([Produto_ID])
REFERENCES [Cafes].[Produto] ([ID_P])
GO
ALTER TABLE [Cafes].[Compra]  WITH CHECK ADD FOREIGN KEY([Recibo_ID])
REFERENCES [Cafes].[Recibo] ([reciboID])
GO
ALTER TABLE [Cafes].[Cozinheiro]  WITH CHECK ADD FOREIGN KEY([NIF_cafeR])
REFERENCES [Cafes].[Cafe_Restaurante] ([NIF])
GO
ALTER TABLE [Cafes].[Cozinheiro]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
ALTER TABLE [Cafes].[Empregado]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
ALTER TABLE [Cafes].[Empregado]  WITH CHECK ADD FOREIGN KEY([NIF_cafe])
REFERENCES [Cafes].[Cafe] ([NIF])
GO
ALTER TABLE [Cafes].[Pasteleiro]  WITH CHECK ADD FOREIGN KEY([NIF_cafeP])
REFERENCES [Cafes].[Cafe_Pastelaria] ([NIF])
GO
ALTER TABLE [Cafes].[Pasteleiro]  WITH CHECK ADD FOREIGN KEY([NIF], [nome])
REFERENCES [Cafes].[Pessoa] ([NIF], [nome])
GO
/****** Object:  StoredProcedure [dbo].[addProduto]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[addProduto](@nomeP VARCHAR(20), @precoP FLOAT, @tipoP INT)
AS
	BEGIN
		INSERT INTO Cafes.Produto(nomeP, precoP, tipoP)
		SELECT @nomeP, @precoP, @tipoP
	END
GO
/****** Object:  StoredProcedure [dbo].[editProduto]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[editProduto](@ID_P INT, @precoP FLOAT)
AS
	BEGIN
		UPDATE Cafes.Produto
		SET  [precoP] = @precoP WHERE [ID_P] = @ID_P;
	END
GO
/****** Object:  StoredProcedure [dbo].[getAlcool]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getAlcool]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 2;
	END
GO
/****** Object:  StoredProcedure [dbo].[getAlmocos]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getAlmocos]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 3;
	END
GO
/****** Object:  StoredProcedure [dbo].[getBebidas]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getBebidas]
AS
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 1;
	END
GO
/****** Object:  StoredProcedure [dbo].[getClientes]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getClientes]
AS
	BEGIN
		SELECT * FROM Cafes.Cliente
		RETURN
	END
GO
/****** Object:  StoredProcedure [dbo].[getEmps]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getEmps]
AS
	BEGIN
		SELECT * FROM Cafes.Empregado
		RETURN
	END
GO
/****** Object:  StoredProcedure [dbo].[getLastProdutoID]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
/****** Object:  StoredProcedure [dbo].[getLastReciboID]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

--To get the ID from the last invoice, and because with each new inserted
--the ID is the anterior ID +1, we only have to get the max ID

CREATE PROCEDURE [dbo].[getLastReciboID]
AS
	BEGIN
		declare @lastID integer;
		SET @lastID = (Select MAX(reciboID) FROM Cafes.Recibo);
		return @lastID
	END
GO
/****** Object:  StoredProcedure [dbo].[getPasteis]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getPasteis]
AS 
	BEGIN
		SELECT * FROM Cafes.Produto WHERE tipoP = 4;
	END
GO
/****** Object:  StoredProcedure [dbo].[getProdutoQ]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getProdutoQ](@Produto_ID INT, @Recibo_ID INT)
AS
    BEGIN
        DECLARE @quantidade INT;
        SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID));
        RETURN @quantidade;
    END
GO
/****** Object:  StoredProcedure [dbo].[getProdutosInRecibo]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[getProdutosInRecibo](@reciboID INT)
AS
    BEGIN
        Select Produto.*,Cafes.Compra.[quantidade] from Cafes.Compra join Cafes.Recibo on Cafes.Compra.Recibo_ID = Cafes.Recibo.reciboID Join Cafes.Produto on Cafes.Produto.ID_P = Cafes.Compra.Produto_ID where Cafes.Recibo.reciboID = @reciboID
    END
GO
/****** Object:  StoredProcedure [dbo].[insertAdministrador]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedure to insert new administrator, hashing the password before inserting the hash into the password column 
--on the table Cafes.Administrador

CREATE PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30), @NIF INT, @nome VARCHAR(30))
AS
	BEGIN
		INSERT INTO Cafes.Administrador([username],[pwd],[NIF],[nome]) VALUES (@username, HASHBYTES('MD5', @pwd), @NIF, @nome);
	END
GO
/****** Object:  StoredProcedure [dbo].[insertCliente]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

--When this procedure is called, it calls the trigger Cafes.checkCliente, wich checks if the Cliente to be added is
--already on the database (on the table Pessoa), and, if not, adds it to the table Pessoa and then to the table Cliente

CREATE PROCEDURE [dbo].[insertCliente](@NIF INT, @nome VARCHAR(30))
AS
	BEGIN
		INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
	END
GO
/****** Object:  StoredProcedure [dbo].[insertCompra]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[insertCompra](@reciboID INT, @produtoID INT)
AS
	BEGIN
		INSERT INTO Cafes.Compra([Recibo_ID],[Produto_ID]) VALUES (@reciboID, @produtoID);
	END
GO
/****** Object:  StoredProcedure [dbo].[insertEmpregado]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

--When this procedure is called, it calls the trigger Cafes.checkEmpregado, wich checks if the Empregado to be added is
--already on the database (on the table Pessoa), and, if not, adds it to the table Pessoa and then to the table Empregado

CREATE PROCEDURE [dbo].[insertEmpregado](@NIF INT, @NIF_cafe INT, @idade INT, @nome VARCHAR(30), @data_inic_contrato DATE)
AS
	BEGIN
		INSERT INTO Cafes.Empregado([NIF],[NIF_cafe],[idade],[nome],[data_inic_contrato]) VALUES(@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
	END
GO
/****** Object:  StoredProcedure [dbo].[insertRecibo]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[insertRecibo](@ClienteNIF INT, @EmpNIF INT, @data_recibo DATE, @valor FLOAT)
AS
	BEGIN 
		INSERT INTO Cafes.Recibo(ClienteNIF, EmpNIF, data_recibo, valor)
		SELECT @ClienteNIF, @EmpNIF, cast(@data_recibo as date), @valor
	END
GO
/****** Object:  StoredProcedure [dbo].[removeCliente]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeCliente](@ClienteNIF INT)
AS
	BEGIN
		DELETE FROM Cafes.Cliente WHERE NIF = @ClienteNIF
	END
GO
/****** Object:  StoredProcedure [dbo].[removeEmpregado]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeEmpregado](@EmpNIF INT)
AS
	BEGIN
		DELETE FROM Cafes.Empregado WHERE NIF = @EmpNIF
	END
GO
/****** Object:  StoredProcedure [dbo].[removeProduto]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

CREATE PROCEDURE [dbo].[removeProduto](@pID INT)
AS
	BEGIN
		DELETE FROM Cafes.Produto WHERE ID_P = @pID
	END
GO
/****** Object:  StoredProcedure [dbo].[removeRecibo]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------

Create PROCEDURE [dbo].[removeRecibo](@rID INT)
AS
	BEGIN
		DELETE FROM Cafes.Recibo WHERE reciboID = @rID
	END
GO
/****** Object:  StoredProcedure [dbo].[searchRecibo]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
--Procedure to insert new administrator, hashing the password before inserting the hash into the password column 
--on the table Cafes.Administrador

CREATE PROCEDURE [dbo].[insertAdministrador](@username VARCHAR(30), @pwd VARCHAR(30), @NIF INT, @nome VARCHAR(30))
AS
	BEGIN
		INSERT INTO Cafes.Administrador([username],[pwd],[NIF],[nome]) VALUES (@username, HASHBYTES('MD5', @pwd), @NIF, @nome);
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

CREATE PROCEDURE [dbo].[getLastReciboID]
AS
	BEGIN
		declare @lastID integer;
		SET @lastID = (Select MAX(reciboID) FROM Cafes.Recibo);
		return @lastID
	END
GO

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

CREATE PROCEDURE [dbo].[getProdutoQ](@Produto_ID INT, @Recibo_ID INT)
AS
    BEGIN
        DECLARE @quantidade INT;
        SET @quantidade = (SELECT [quantidade] FROM Cafes.Compra WHERE (([Produto_ID] = @Produto_ID) AND [Recibo_ID] = @Recibo_ID));
        RETURN @quantidade;
    END
GO

CREATE PROCEDURE [dbo].[getEmps]
AS
	BEGIN
		SELECT * FROM Cafes.Empregado
		RETURN
	END
GO

CREATE PROCEDURE [dbo].[getClientes]
AS
	BEGIN
		SELECT * FROM Cafes.Cliente
		RETURN
	END
GO
*/
CREATE PROCEDURE [dbo].[searchRecibo](@reciboID INT)
AS
	BEGIN
		SELECT * FROM Cafes.Recibo WHERE [reciboID] = @reciboID;
	END
GO
/****** Object:  StoredProcedure [dbo].[verifyLogin]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Trigger [Cafes].[checkCliente]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
ALTER TRIGGER Cafes.checkEmpregado ON Cafes.Empregado
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);;
			ELSE
				RAISERROR('Já existe!', 16, 1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
			END
	END
GO
*/

CREATE TRIGGER [Cafes].[checkCliente] ON [Cafes].[Cliente]
INSTEAD OF INSERT
AS
	BEGIN
		DECLARE @NIF INT;
		DECLARE @nome VARCHAR(30);;
		SELECT @NIF = NIF, @nome = nome FROM inserted;
		IF ([dbo].[checkPessoa](@NIF, @nome) = 1)
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			ELSE
				RAISERROR('Já existe!',16,1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			END
	END
GO
ALTER TABLE [Cafes].[Cliente] ENABLE TRIGGER [checkCliente]
GO
/****** Object:  Trigger [Cafes].[checkInsertProduto]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);;
			ELSE
				RAISERROR('Já existe!', 16, 1);
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			ELSE
				RAISERROR('Já existe!',16,1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			END
	END
GO
*/
CREATE TRIGGER [Cafes].[checkInsertProduto] ON [Cafes].[Compra]
INSTEAD OF INSERT
AS
    BEGIN
        DECLARE @Recibo_ID INT;
        DECLARE @Produto_ID INT;
        DECLARE @newQuantidade INT;
        SELECT @Recibo_ID = Recibo_ID, @Produto_ID = Produto_ID FROM INSERTED;
        IF ([dbo].[checkQuantidadeProduto](@Produto_ID, @Recibo_ID) = 0)
                INSERT INTO Cafes.Compra([Recibo_ID], [Produto_ID], [quantidade]) VALUES (@Recibo_ID, @Produto_ID, 1);
        ELSE
            BEGIN
                UPDATE Cafes.Compra
                SET [quantidade] = ([dbo].[getProdutoQuantidade](@Produto_ID, @Recibo_ID) + 1) WHERE ([Produto_ID] = @Produto_ID AND [Recibo_ID] = @Recibo_ID);
            END
    END
GO
ALTER TABLE [Cafes].[Compra] ENABLE TRIGGER [checkInsertProduto]
GO
/****** Object:  Trigger [Cafes].[checkEmpregado]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [Cafes].[checkEmpregado] ON [Cafes].[Empregado]
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
			ELSE
				RAISERROR('Ja existe!', 16, 1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);
			END
	END
GO
ALTER TABLE [Cafes].[Empregado] ENABLE TRIGGER [checkEmpregado]
GO
/****** Object:  Trigger [Cafes].[checkNIFs]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Empregado([NIF], [NIF_cafe], [idade], [nome], [data_inic_contrato]) VALUES (@NIF, @NIF_cafe, @idade, @nome, @data_inic_contrato);;
			ELSE
				RAISERROR('Já existe!', 16, 1);
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
			IF (([dbo].[checkEmp](@NIF, @nome) = 0) AND ([dbo].[checkCl](@NIF, @nome) = 0))
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			ELSE
				RAISERROR('Já existe!',16,1);
		ELSE
			BEGIN
				INSERT INTO Cafes.Pessoa([NIF], [nome]) VALUES (@NIF, @nome);
				INSERT INTO Cafes.Cliente([NIF], [nome]) VALUES (@NIF, @nome);
			END
	END
GO

CREATE TRIGGER Cafes.checkInsertProduto ON [Cafes].[Compra]
INSTEAD OF INSERT
AS
    BEGIN
        DECLARE @Recibo_ID INT;
        DECLARE @Produto_ID INT;
        DECLARE @newQuantidade INT;
        SELECT @Recibo_ID = Recibo_ID, @Produto_ID = Produto_ID FROM INSERTED;
        IF ([dbo].[checkQuantidadeProduto](@Produto_ID, @Recibo_ID) = 0)
                INSERT INTO Cafes.Compra([Recibo_ID], [Produto_ID], [quantidade]) VALUES (@Recibo_ID, @Produto_ID, 1);
        ELSE
            BEGIN
                UPDATE Cafes.Compra
                SET [quantidade] = ([dbo].[getProdutoQuantidade](@Produto_ID, @Recibo_ID) + 1) WHERE ([Produto_ID] = @Produto_ID AND [Recibo_ID] = @Recibo_ID);
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
--trigger para recibo quando tentamos fazer insert do recibo, verificar se nifs de emp e cliente existem
CREATE TRIGGER [Cafes].[checkNIFs] ON [Cafes].[Recibo]
INSTEAD OF INSERT
AS
	BEGIN
		DECLARE @ClienteNIF INT;
		DECLARE @EmpNIF INT;
		DECLARE @data_recibo DATE;
		DECLARE @valor FLOAT;
		SELECT @ClienteNIF = ClienteNIF, @EmpNIF = EmpNIF, @data_recibo = data_recibo, @valor = valor FROM INSERTED;
		IF (([dbo].[checkEmpregadoByNIF](@EmpNIF) = 1) AND ([dbo].[checkClienteByNIF](@ClienteNIF) = 1))
			BEGIN
				INSERT INTO Cafes.Recibo([ClienteNIF],[EmpNIF],[data_recibo],[valor]) VALUES (@ClienteNIF, @EmpNIF, @data_recibo, @valor);
			END
		ELSE
			RAISERROR('NIF não existe!', 16, 1);
	END
GO
ALTER TABLE [Cafes].[Recibo] ENABLE TRIGGER [checkNIFs]
GO
/****** Object:  Trigger [Cafes].[checkRemoveRecibo]    Script Date: 12/06/2020 15:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [Cafes].[checkRemoveRecibo] ON [Cafes].[Recibo]
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
ALTER TABLE [Cafes].[Recibo] ENABLE TRIGGER [checkRemoveRecibo]
GO
USE [master]
GO
ALTER DATABASE [p2g1] SET  READ_WRITE 
GO
