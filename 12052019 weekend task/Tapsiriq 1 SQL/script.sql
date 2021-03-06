/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [MyDatabase]    Script Date: 5/11/2019 2:20:25 AM ******/
CREATE DATABASE [MyDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyDatabase', FILENAME = N'C:\Users\code\Desktop\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyDatabase_log', FILENAME = N'C:\Users\code\Desktop\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MyDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MyDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [MyDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [MyDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyDatabase', N'ON'
GO
ALTER DATABASE [MyDatabase] SET QUERY_STORE = OFF
GO
USE [MyDatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MyDatabase]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[CategoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ProductID] [int] NULL,
	[ProductCount] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Price] [float] NULL,
	[CategoryID] [int] NULL,
	[BrandID] [int] NULL,
	[Color] [nvarchar](75) NOT NULL,
	[BarCode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[Count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/11/2019 2:20:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (1, N'Guneshli zavodu', 2)
INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (2, N'Final Yaglari Zavodu', 5)
INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (3, N'Acili Cipsiler', 3)
INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (4, N'Temiz Meyve Shireleri', 1)
INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (5, N'Kend Pendirleri', 6)
INSERT [dbo].[Brands] ([Id], [Name], [CategoryID]) VALUES (6, N'Yashil Cay Zavodu', 4)
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Sok')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Corek')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Lays')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Cay')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Yag')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'Pendir')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserID], [ProductID], [ProductCount], [OrderDate]) VALUES (1, 1, 6, 3, CAST(N'2019-05-11' AS Date))
INSERT [dbo].[Orders] ([Id], [UserID], [ProductID], [ProductCount], [OrderDate]) VALUES (2, 2, 2, 2, CAST(N'2019-05-11' AS Date))
INSERT [dbo].[Orders] ([Id], [UserID], [ProductID], [ProductCount], [OrderDate]) VALUES (3, 3, 4, 4, CAST(N'2019-05-11' AS Date))
INSERT [dbo].[Orders] ([Id], [UserID], [ProductID], [ProductCount], [OrderDate]) VALUES (4, 4, 7, 2, CAST(N'2019-05-11' AS Date))
INSERT [dbo].[Orders] ([Id], [UserID], [ProductID], [ProductCount], [OrderDate]) VALUES (5, 5, 1, 3, CAST(N'2019-05-11' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (1, N'Fanta', 1.25, 1, 4, N'narinci', 21212)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (2, N'Sprite', 1.25, 1, 4, N'ag', 1212)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (3, N'Zavod', 0.5, 2, 1, N'narinci', 2932)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (4, N'Tendir', 0.7, 2, 1, N'ag', 21452)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (5, N'Gunebaxan', 3.6, 5, 2, N'narinci', 4544)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (6, N'Chipsim', 2.25, 3, 3, N'qirmizi', 21212)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (7, N'Canag', 4.5, 6, 5, N'ag', 100234)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (8, N'Motal', 7.4, 6, 5, N'ag', 762211)
INSERT [dbo].[Products] ([Id], [Name], [Price], [CategoryID], [BrandID], [Color], [BarCode]) VALUES (9, N'Beta', 2.7, 4, 6, N'qara', 67534)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (1, 1, 3)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (2, 2, 2)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (3, 3, 1)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (4, 4, 5)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (5, 7, 5)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (6, 6, 10)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (7, 9, 1)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (8, 8, 1)
INSERT [dbo].[Stock] ([Id], [ProductID], [Count]) VALUES (9, 5, 1)
SET IDENTITY_INSERT [dbo].[Stock] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Email], [Password]) VALUES (1, N'Toghrul', N'Rzayev', N'toghrul123', N'toghrul1999@mail.ru', N'12345')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Email], [Password]) VALUES (2, N'Ekber', N'Emenov', N'ekber23', N'ekber1999@mail.ru', N'ekber2018')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Email], [Password]) VALUES (3, N'Murad', N'Babazade', N'murad0101', N'murad1999@mail.ru', N'muradsalamnecesen')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Email], [Password]) VALUES (4, N'Hesen', N'Eliyev', N'hesen78', N'hesen1998@mail.ru', N'hesenaliyev')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Email], [Password]) VALUES (5, N'Bayram', N'Kurdexanali', N'bayramdari', N'bayram1969@mail.ru', N'Allah rehmet elesin')
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__536C85E47EB9B48C]    Script Date: 5/11/2019 2:20:26 AM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D10534C4761C93]    Script Date: 5/11/2019 2:20:26 AM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Brands]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([Id])
GO
USE [master]
GO
ALTER DATABASE [MyDatabase] SET  READ_WRITE 
GO
