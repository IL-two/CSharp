USE [master]
GO
/****** Object:  Database [EmployeeAccounting]    Script Date: 23.10.2020 0:46:54 ******/
CREATE DATABASE [EmployeeAccounting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeAccounting', FILENAME = N'C:\Users\idukh\EmployeeAccounting.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeAccounting_log', FILENAME = N'C:\Users\idukh\EmployeeAccounting_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EmployeeAccounting] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeAccounting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeAccounting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeAccounting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeAccounting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeAccounting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeAccounting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeAccounting] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeAccounting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeAccounting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeAccounting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeAccounting] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeAccounting] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EmployeeAccounting] SET QUERY_STORE = OFF
GO
USE [EmployeeAccounting]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [EmployeeAccounting]
GO
/****** Object:  Table [dbo].[Emplayee_table]    Script Date: 23.10.2020 0:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emplayee_table](
	[Emp_id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_lastName] [nchar](20) NOT NULL,
	[Emp_firstName] [nchar](15) NOT NULL,
	[Emp_ptronymic] [nchar](20) NULL,
	[Emp_salary] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Emplayee_table] PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emplayee_table] ON 

INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (1, N'Иванов              ', N'Иван           ', N'Иванович            ', CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (3, N'Кирилов             ', N'Кирил          ', N'Кирилович           ', CAST(75000.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (4, N'Антонова            ', N'Феодосия       ', N'                    ', CAST(123.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (1003, N'Антонов             ', N'Антон          ', N'Антоновч            ', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (2003, N'Андреев             ', N'Андрей         ', N'                    ', CAST(70.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (2004, N'Никитин             ', N'Никита         ', N'Никитич             ', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (3003, N'Дмитриев            ', N'Дмитрий        ', N'Дмитриевич          ', CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (4004, N'Петров              ', N'Петр           ', N'Петрович            ', CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (7003, N'Шев                 ', N'Валентин       ', N'Дмитриевич          ', CAST(120.00 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (8003, N'Ильин               ', N'Илья           ', N'Ильич               ', CAST(500.99 AS Decimal(18, 2)))
INSERT [dbo].[Emplayee_table] ([Emp_id], [Emp_lastName], [Emp_firstName], [Emp_ptronymic], [Emp_salary]) VALUES (9006, N'Фдотова             ', N'Екатерина      ', N'Васильевна          ', CAST(504.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Emplayee_table] OFF
USE [master]
GO
ALTER DATABASE [EmployeeAccounting] SET  READ_WRITE 
GO
