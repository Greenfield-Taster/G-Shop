USE [master]
GO
/****** Object:  Database [G-Shop]    Script Date: 27.11.2022 21:49:03 ******/
CREATE DATABASE [G-Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'G-Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\G-Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'G-Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\G-Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [G-Shop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [G-Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [G-Shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [G-Shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [G-Shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [G-Shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [G-Shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [G-Shop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [G-Shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [G-Shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [G-Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [G-Shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [G-Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [G-Shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [G-Shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [G-Shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [G-Shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [G-Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [G-Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [G-Shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [G-Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [G-Shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [G-Shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [G-Shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [G-Shop] SET RECOVERY FULL 
GO
ALTER DATABASE [G-Shop] SET  MULTI_USER 
GO
ALTER DATABASE [G-Shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [G-Shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [G-Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [G-Shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [G-Shop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [G-Shop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'G-Shop', N'ON'
GO
ALTER DATABASE [G-Shop] SET QUERY_STORE = OFF
GO
USE [G-Shop]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 27.11.2022 21:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](90) NOT NULL,
	[Address] [nvarchar](90) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[ZIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Customer__3214EC07617B0B7C] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27.11.2022 21:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NOT NULL,
	[Country] [nvarchar](90) NOT NULL,
	[Category] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Image] [image] NULL,
	[Description] [nvarchar](4000) NOT NULL,
	[Season] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 27.11.2022 21:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataTime] [date] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[ChekId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.11.2022 21:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](10) NOT NULL,
	[Adress] [nvarchar](110) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 27.11.2022 21:49:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[ProductId] [int] NOT NULL,
	[XS] [nvarchar](50) NOT NULL,
	[S] [nvarchar](50) NOT NULL,
	[M] [nvarchar](50) NOT NULL,
	[L] [nvarchar](50) NOT NULL,
	[XL] [nvarchar](50) NOT NULL,
	[XXL] [nvarchar](50) NOT NULL,
	[XXXL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customers]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Products]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Users]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Products]
GO
USE [master]
GO
ALTER DATABASE [G-Shop] SET  READ_WRITE 
GO
