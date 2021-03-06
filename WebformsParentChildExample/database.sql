USE [master]
GO
/****** Object:  Database [B2C2]    Script Date: 15-9-2021 11:04:04 ******/
CREATE DATABASE [B2C2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'B2C2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\B2C2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'B2C2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\B2C2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [B2C2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [B2C2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [B2C2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [B2C2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [B2C2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [B2C2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [B2C2] SET ARITHABORT OFF 
GO
ALTER DATABASE [B2C2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [B2C2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [B2C2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [B2C2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [B2C2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [B2C2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [B2C2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [B2C2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [B2C2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [B2C2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [B2C2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [B2C2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [B2C2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [B2C2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [B2C2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [B2C2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [B2C2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [B2C2] SET RECOVERY FULL 
GO
ALTER DATABASE [B2C2] SET  MULTI_USER 
GO
ALTER DATABASE [B2C2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [B2C2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [B2C2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [B2C2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [B2C2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [B2C2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'B2C2', N'ON'
GO
ALTER DATABASE [B2C2] SET QUERY_STORE = OFF
GO
USE [B2C2]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 15-9-2021 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Email] [varchar](50) NOT NULL,
	[PassSalt] [varchar](10) NULL,
	[PassSHA] [varchar](40) NULL,
	[FriendlyName] [varchar](50) NULL,
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [EmailUnique] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 15-9-2021 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[GameId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Startdate] [date] NULL,
	[Enddate] [date] NULL,
 CONSTRAINT [PK_Game] PRIMARY KEY CLUSTERED 
(
	[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameAccount]    Script Date: 15-9-2021 11:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameAccount](
	[gameid] [int] NOT NULL,
	[accountid] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_GameUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Unique_id] UNIQUE NONCLUSTERED 
(
	[gameid] ASC,
	[accountid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GameAccount]  WITH CHECK ADD  CONSTRAINT [FK_GameAccount_Account] FOREIGN KEY([accountid])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[GameAccount] CHECK CONSTRAINT [FK_GameAccount_Account]
GO
ALTER TABLE [dbo].[GameAccount]  WITH CHECK ADD  CONSTRAINT [FK_GameUser_Game] FOREIGN KEY([gameid])
REFERENCES [dbo].[Game] ([GameId])
GO
ALTER TABLE [dbo].[GameAccount] CHECK CONSTRAINT [FK_GameUser_Game]
GO
USE [master]
GO
ALTER DATABASE [B2C2] SET  READ_WRITE 
GO
