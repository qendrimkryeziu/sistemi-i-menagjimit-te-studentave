USE [master]
GO
/****** Object:  Database [college]    Script Date: 4/19/2021 6:37:27 AM ******/
CREATE DATABASE [college]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'college', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\college.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'college_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\college_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [college] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [college].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [college] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [college] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [college] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [college] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [college] SET ARITHABORT OFF 
GO
ALTER DATABASE [college] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [college] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [college] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [college] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [college] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [college] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [college] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [college] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [college] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [college] SET  ENABLE_BROKER 
GO
ALTER DATABASE [college] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [college] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [college] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [college] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [college] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [college] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [college] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [college] SET RECOVERY FULL 
GO
ALTER DATABASE [college] SET  MULTI_USER 
GO
ALTER DATABASE [college] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [college] SET DB_CHAINING OFF 
GO
ALTER DATABASE [college] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [college] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [college] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [college] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'college', N'ON'
GO
ALTER DATABASE [college] SET QUERY_STORE = OFF
GO
USE [college]
GO
/****** Object:  Table [dbo].[fees1]    Script Date: 4/19/2021 6:37:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fees1](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[NAID] [int] NOT NULL,
	[fees] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 4/19/2021 6:37:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewAdmission]    Script Date: 4/19/2021 6:37:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewAdmission](
	[NAID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](250) NOT NULL,
	[faname] [varchar](250) NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[dob] [varchar](50) NOT NULL,
	[mobile] [bigint] NOT NULL,
	[email] [varchar](150) NULL,
	[semester] [varchar](100) NOT NULL,
	[prog] [varchar](150) NOT NULL,
	[sname] [varchar](150) NOT NULL,
	[duration] [varchar](120) NOT NULL,
	[addres] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NAID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teacher]    Script Date: 4/19/2021 6:37:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teacher](
	[tID] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](250) NOT NULL,
	[gender] [varchar](10) NOT NULL,
	[dob] [varchar](50) NOT NULL,
	[mobile] [bigint] NOT NULL,
	[email] [varchar](250) NOT NULL,
	[semester] [varchar](250) NOT NULL,
	[prog] [varchar](100) NOT NULL,
	[yer] [varchar](250) NOT NULL,
	[adr] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [college] SET  READ_WRITE 
GO
