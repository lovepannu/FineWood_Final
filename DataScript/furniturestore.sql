USE [master]
GO
/****** Object:  Database [FurnitureStore]    Script Date: 17/05/2021 2:46:13 AM ******/
CREATE DATABASE [FurnitureStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FurnitureStore_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FurnitureStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FurnitureStore_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FurnitureStore.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FurnitureStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FurnitureStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FurnitureStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FurnitureStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FurnitureStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FurnitureStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FurnitureStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [FurnitureStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FurnitureStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FurnitureStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FurnitureStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FurnitureStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FurnitureStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FurnitureStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FurnitureStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FurnitureStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FurnitureStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FurnitureStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FurnitureStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FurnitureStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FurnitureStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FurnitureStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FurnitureStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FurnitureStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FurnitureStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FurnitureStore] SET  MULTI_USER 
GO
ALTER DATABASE [FurnitureStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FurnitureStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FurnitureStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FurnitureStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FurnitureStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FurnitureStore] SET QUERY_STORE = OFF
GO
USE [FurnitureStore]
GO
/****** Object:  Table [dbo].[AdminDetails]    Script Date: 17/05/2021 2:46:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminDetails](
	[AdminName] [varchar](50) NULL,
	[AdminPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 17/05/2021 2:46:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Product] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 17/05/2021 2:46:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Size] [nvarchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Query]    Script Date: 17/05/2021 2:46:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Query](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_Query] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rawmaterial]    Script Date: 17/05/2021 2:46:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rawmaterial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[Size] [nvarchar](50) NULL,
	[Qty] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rawmaterial] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AdminDetails] ([AdminName], [AdminPassword]) VALUES (N'admin', N'admin')
INSERT [dbo].[Client] ([id], [Name], [contact], [Address], [Product], [Price]) VALUES (1, N'Love', N'64857849', N'Hamilton', N'Table', N'56')
USE [master]
GO
ALTER DATABASE [FurnitureStore] SET  READ_WRITE 
GO
