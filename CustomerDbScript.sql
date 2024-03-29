USE [master]
GO
/****** Object:  Database [LabPracticeDb]    Script Date: 10/5/2019 11:07:35 PM ******/
CREATE DATABASE [LabPracticeDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LabPracticeDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SILENTREVENGER\MSSQL\DATA\LabPracticeDb.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LabPracticeDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SILENTREVENGER\MSSQL\DATA\LabPracticeDb_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LabPracticeDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LabPracticeDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LabPracticeDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LabPracticeDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LabPracticeDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LabPracticeDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LabPracticeDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [LabPracticeDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LabPracticeDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LabPracticeDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LabPracticeDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LabPracticeDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LabPracticeDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LabPracticeDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LabPracticeDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LabPracticeDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LabPracticeDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LabPracticeDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LabPracticeDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LabPracticeDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LabPracticeDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LabPracticeDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LabPracticeDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LabPracticeDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LabPracticeDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LabPracticeDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LabPracticeDb] SET  MULTI_USER 
GO
ALTER DATABASE [LabPracticeDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LabPracticeDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LabPracticeDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LabPracticeDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [LabPracticeDb]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/5/2019 11:07:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](4) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Contact] [varchar](11) NOT NULL,
	[District] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 10/5/2019 11:07:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Locations](
	[District] [varchar](50) NOT NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[District] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (1, N'C001', N'Milon', N'Taltola', N'01927202017', N'DHAKA')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (2, N'C002', N'Masud', N'Farmgate', N'01987142536', N'DHAKA')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (3, N'C004', N'Salauddin', N'Elephant Road', N'01684571030', N'RAJBARI')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (4, N'C003', N'Arif', N'Gulshan', N'01301473265', N'KUSHTIA')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (5, N'C005', N'Rana', N'Motijheel', N'01852134698', N'BARGUNA')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (6, N'C006', N'Raja', N'Mirpur', N'01722559889', N'KHULNA')
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Contact], [District]) VALUES (7, N'C009', N'Hasan', N'Uttora', N'01714528965', N'GAZIPUR')
SET IDENTITY_INSERT [dbo].[Customers] OFF
INSERT [dbo].[Locations] ([District]) VALUES (N'BAGERHAT')
INSERT [dbo].[Locations] ([District]) VALUES (N'BANDARBAN')
INSERT [dbo].[Locations] ([District]) VALUES (N'BARGUNA')
INSERT [dbo].[Locations] ([District]) VALUES (N'BARISAL')
INSERT [dbo].[Locations] ([District]) VALUES (N'BHOLA')
INSERT [dbo].[Locations] ([District]) VALUES (N'BOGRA')
INSERT [dbo].[Locations] ([District]) VALUES (N'BRAHMANBARIA')
INSERT [dbo].[Locations] ([District]) VALUES (N'CHANDPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'CHAPAINABABGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'CHITTAGONG')
INSERT [dbo].[Locations] ([District]) VALUES (N'CHUADANGA')
INSERT [dbo].[Locations] ([District]) VALUES (N'COMILLA')
INSERT [dbo].[Locations] ([District]) VALUES (N'COXS BAZAR')
INSERT [dbo].[Locations] ([District]) VALUES (N'DHAKA')
INSERT [dbo].[Locations] ([District]) VALUES (N'DINAJPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'FARIDPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'FENI')
INSERT [dbo].[Locations] ([District]) VALUES (N'GAIBANDHA')
INSERT [dbo].[Locations] ([District]) VALUES (N'GAZIPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'GOPALGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'HABIGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'JAMALPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'JESSORE')
INSERT [dbo].[Locations] ([District]) VALUES (N'JHALOKATI')
INSERT [dbo].[Locations] ([District]) VALUES (N'JHENAIDAH')
INSERT [dbo].[Locations] ([District]) VALUES (N'JOYPURHAT')
INSERT [dbo].[Locations] ([District]) VALUES (N'KHULNA')
INSERT [dbo].[Locations] ([District]) VALUES (N'KISHOREGONJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'KURIGRAM')
INSERT [dbo].[Locations] ([District]) VALUES (N'KUSHTIA')
INSERT [dbo].[Locations] ([District]) VALUES (N'LAKSHMIPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'MADARIPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'MAGURA')
INSERT [dbo].[Locations] ([District]) VALUES (N'MANIKGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'MAULVIBAZAR')
INSERT [dbo].[Locations] ([District]) VALUES (N'MEHERPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'MUNSHIGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'MYMENSINGH')
INSERT [dbo].[Locations] ([District]) VALUES (N'NARAIL')
INSERT [dbo].[Locations] ([District]) VALUES (N'NARAYANGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'NARSINGDI')
INSERT [dbo].[Locations] ([District]) VALUES (N'NATORE')
INSERT [dbo].[Locations] ([District]) VALUES (N'NETRAKONA')
INSERT [dbo].[Locations] ([District]) VALUES (N'NILPHAMARI')
INSERT [dbo].[Locations] ([District]) VALUES (N'NOAKHALI')
INSERT [dbo].[Locations] ([District]) VALUES (N'PABNA')
INSERT [dbo].[Locations] ([District]) VALUES (N'PANCHAGARH')
INSERT [dbo].[Locations] ([District]) VALUES (N'PATUAKHALI')
INSERT [dbo].[Locations] ([District]) VALUES (N'PIROJPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'RAJBARI')
INSERT [dbo].[Locations] ([District]) VALUES (N'RAJSHAHI')
INSERT [dbo].[Locations] ([District]) VALUES (N'RANGAMATI')
INSERT [dbo].[Locations] ([District]) VALUES (N'RANGPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'SATKHIRA')
INSERT [dbo].[Locations] ([District]) VALUES (N'SHARIATPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'SHERPUR')
INSERT [dbo].[Locations] ([District]) VALUES (N'SUNAMGANJ')
INSERT [dbo].[Locations] ([District]) VALUES (N'SYLHET')
INSERT [dbo].[Locations] ([District]) VALUES (N'TANGAIL')
INSERT [dbo].[Locations] ([District]) VALUES (N'THAKURGAON')
USE [master]
GO
ALTER DATABASE [LabPracticeDb] SET  READ_WRITE 
GO
