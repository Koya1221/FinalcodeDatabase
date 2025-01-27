USE [master]
GO
/****** Object:  Database [ASM_STD_ATT]    Script Date: 15/08/2024 3:53:24 CH ******/
CREATE DATABASE [ASM_STD_ATT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASM_STD_ATT', FILENAME = N'D:\SQL_Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ASM_STD_ATT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ASM_STD_ATT_log', FILENAME = N'D:\SQL_Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ASM_STD_ATT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ASM_STD_ATT] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ASM_STD_ATT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ASM_STD_ATT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET ARITHABORT OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ASM_STD_ATT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ASM_STD_ATT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ASM_STD_ATT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ASM_STD_ATT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ASM_STD_ATT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ASM_STD_ATT] SET  MULTI_USER 
GO
ALTER DATABASE [ASM_STD_ATT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ASM_STD_ATT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ASM_STD_ATT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ASM_STD_ATT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ASM_STD_ATT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ASM_STD_ATT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ASM_STD_ATT] SET QUERY_STORE = ON
GO
ALTER DATABASE [ASM_STD_ATT] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ASM_STD_ATT]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] NOT NULL,
	[ClassName] [varchar](255) NOT NULL,
	[TeacherID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[StudentID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
	[EnrollTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[GradesID] [int] NOT NULL,
	[StudentID] [int] NULL,
	[ClassID] [int] NULL,
	[Semester1Scores] [float] NULL,
	[Semester2Scores] [float] NULL,
	[FinalScores] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[GradesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [int] NOT NULL,
	[StudentName] [varchar](255) NOT NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [char](1) NULL,
	[email] [varchar](15) NULL,
	[Phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectID] [int] NOT NULL,
	[SubjectName] [varchar](255) NOT NULL,
	[TimeOfSubject] [varchar](255) NULL,
	[Credit] [int] NULL,
	[TeacherID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherID] [int] NOT NULL,
	[TeacherName] [varchar](255) NOT NULL,
	[email] [varchar](15) NULL,
	[Phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/08/2024 3:53:24 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](256) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[Phone] [nvarchar](100) NULL,
	[dateofbirth] [date] NULL,
	[role] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Class] ([ClassID], [ClassName], [TeacherID]) VALUES (1, N'SE07102', 1)
GO
INSERT [dbo].[Enrollment] ([StudentID], [ClassID], [EnrollTime]) VALUES (1, 1, CAST(N'2024-08-22T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (1, 1, 1, 7, 9, 6)
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (2, 2, 1, 7, 8, 8)
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (3, 3, 1, 7, 7, 8)
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (4, 4, 1, 8, 9, 10)
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (5, 5, 1, 8, 6, 9)
INSERT [dbo].[Grades] ([GradesID], [StudentID], [ClassID], [Semester1Scores], [Semester2Scores], [FinalScores]) VALUES (6, NULL, NULL, 7, 8, 9)
GO
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (1, N'Lumine', CAST(N'2005-04-12' AS Date), N'f', N'123', N'1234567890')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (2, N'Aether', CAST(N'2005-05-12' AS Date), N'm', N'234', N'2345678901')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (3, N'Xiao', CAST(N'2005-06-12' AS Date), N'm', N'345', N'3456789012')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (4, N'Diluc', CAST(N'2005-07-12' AS Date), N'm', N'456', N'4567890123')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (5, N'Fischl', CAST(N'2005-08-12' AS Date), N'f', N'567', N'5678901234')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (6, N'Paimon', CAST(N'2005-09-12' AS Date), N'f', N'678', N'6789012345')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (7, N'Ganyu', CAST(N'2005-10-12' AS Date), N'f', N'789', N'7890123456')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (8, N'Albedo', CAST(N'2005-11-12' AS Date), N'm', N'890', N'8901234567')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (9, N'Hu Tao', CAST(N'2005-12-12' AS Date), N'f', N'901', N'9012345678')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (10, N'Kazuha', CAST(N'2005-01-12' AS Date), N'm', N'012', N'0123456789')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (11, N'Sampo', CAST(N'2005-02-12' AS Date), N'm', N'123', N'1234567891')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (12, N'Seele Vollerei', CAST(N'2005-03-12' AS Date), N'f', N'234', N'2345678902')
INSERT [dbo].[Students] ([StudentID], [StudentName], [DateOfBirth], [Gender], [email], [Phone]) VALUES (13, N'March 7th', CAST(N'2005-04-12' AS Date), N'f', N'345', N'3456789013')
GO
INSERT [dbo].[Subject] ([SubjectID], [SubjectName], [TimeOfSubject], [Credit], [TeacherID]) VALUES (1, N'Database Systems', N'120', 2000000, 1)
GO
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [email], [Phone]) VALUES (1, N'Zhongli', N'111', N'1112223333')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [email], [Phone]) VALUES (2, N'Keqing', N'222', N'2223334444')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [email], [Phone]) VALUES (3, N'Raiden Shogun', N'333', N'3334445555')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [email], [Phone]) VALUES (4, N'Jing Yuan', N'444', N'4445556666')
INSERT [dbo].[Teachers] ([TeacherID], [TeacherName], [email], [Phone]) VALUES (5, N'Bronya Zaychik', N'555', N'5556667777')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (3, N'lumine', N'1234', N'Lumine', N'Traveler', N'1234567890', CAST(N'2000-01-01' AS Date), N'student')
INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (4, N'aether', N'1234', N'Aether', N'Traveler', N'2345678901', CAST(N'2000-02-01' AS Date), N'student')
INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (5, N'xiao', N'1234', N'Xiao', N'Adeptus', N'3456789012', CAST(N'2000-03-01' AS Date), N'student')
INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (6, N'diluc', N'1234', N'Diluc', N'Dawn Winery', N'4567890123', CAST(N'2000-04-01' AS Date), N'teacher')
INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (7, N'fischl', N'1234', N'Fischl', N'Raven', N'5678901234', CAST(N'2000-05-01' AS Date), N'student')
INSERT [dbo].[Users] ([userID], [username], [password], [firstName], [lastName], [Phone], [dateofbirth], [role]) VALUES (8, N'jingyuan', N'123', N'Jing Yuan', N'q', N'23214123', CAST(N'2024-08-15' AS Date), N'teacher')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([StudentID])
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([TeacherID])
GO
USE [master]
GO
ALTER DATABASE [ASM_STD_ATT] SET  READ_WRITE 
GO
