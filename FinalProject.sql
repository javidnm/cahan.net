USE [master]
GO
/****** Object:  Database [Final]    Script Date: 4/9/2019 11:47:41 PM ******/
CREATE DATABASE [Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [Final] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Final] SET  MULTI_USER 
GO
ALTER DATABASE [Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [Final]
GO
/****** Object:  Table [dbo].[BloodGroup]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Value] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EyeColor]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EyeColor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[ColorName] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MartialStatus]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MartialStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MilitaryStatus]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MilitaryStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[DeletedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationality]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationality](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Citizenship] [nvarchar](200) NOT NULL,
	[DeletedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](70) NOT NULL,
	[LastName] [nvarchar](70) NOT NULL,
	[FatherName] [nvarchar](70) NULL,
	[BirthPlace] [nvarchar](200) NULL,
	[BirthOfDate] [date] NULL,
	[GenderId] [int] NULL,
	[NationalityId] [int] NULL,
	[MartialStatusId] [int] NULL,
	[Height] [tinyint] NULL,
	[MilitaryStatusId] [int] NULL,
	[EyeColorId] [int] NULL,
	[BloodGroupId] [int] NULL,
	[LivingPlace] [nvarchar](200) NULL,
	[IssueDate] [date] NOT NULL,
	[ExpiryDate] [date] NULL,
	[Series] [varchar](20) NOT NULL,
	[IssuingAuthority] [nvarchar](200) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Number] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/9/2019 11:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeletedDate] [datetime] NULL,
	[Email] [nvarchar](255) NULL,
	[Password] [nvarchar](200) NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK__User__3214EC073C8151BB] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BloodGroup] ON 

INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (1, NULL, N'l+')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (2, NULL, N'l-')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (3, NULL, N'll+')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (4, NULL, N'll-')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (5, NULL, N'lll+')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (6, NULL, N'lll-')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (7, NULL, N'lV+')
INSERT [dbo].[BloodGroup] ([Id], [DeletedDate], [Value]) VALUES (8, NULL, N'lV-')
SET IDENTITY_INSERT [dbo].[BloodGroup] OFF
SET IDENTITY_INSERT [dbo].[EyeColor] ON 

INSERT [dbo].[EyeColor] ([Id], [DeletedDate], [ColorName]) VALUES (1, NULL, N'qehveyi')
INSERT [dbo].[EyeColor] ([Id], [DeletedDate], [ColorName]) VALUES (2, NULL, N'goy')
INSERT [dbo].[EyeColor] ([Id], [DeletedDate], [ColorName]) VALUES (3, NULL, N'qara')
INSERT [dbo].[EyeColor] ([Id], [DeletedDate], [ColorName]) VALUES (4, CAST(N'2019-04-08T19:02:43.917' AS DateTime), N'yasil')
SET IDENTITY_INSERT [dbo].[EyeColor] OFF
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [DeletedDate], [Name]) VALUES (1, NULL, N'Kisi')
INSERT [dbo].[Gender] ([Id], [DeletedDate], [Name]) VALUES (2, NULL, N'Qadin')
SET IDENTITY_INSERT [dbo].[Gender] OFF
SET IDENTITY_INSERT [dbo].[MartialStatus] ON 

INSERT [dbo].[MartialStatus] ([Id], [DeletedDate], [Name]) VALUES (1, NULL, N'Evli')
INSERT [dbo].[MartialStatus] ([Id], [DeletedDate], [Name]) VALUES (2, NULL, N'Subay')
SET IDENTITY_INSERT [dbo].[MartialStatus] OFF
SET IDENTITY_INSERT [dbo].[MilitaryStatus] ON 

INSERT [dbo].[MilitaryStatus] ([Id], [Name], [DeletedDate]) VALUES (1, N'Yararli', NULL)
INSERT [dbo].[MilitaryStatus] ([Id], [Name], [DeletedDate]) VALUES (2, N'Yararsiz', NULL)
INSERT [dbo].[MilitaryStatus] ([Id], [Name], [DeletedDate]) VALUES (3, N'Tehsil(indi)', NULL)
SET IDENTITY_INSERT [dbo].[MilitaryStatus] OFF
SET IDENTITY_INSERT [dbo].[Nationality] ON 

INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (1, N'Azerbaycan', NULL)
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (2, N'Rusiya', NULL)
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (3, N'Amerika', NULL)
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (4, N'Gurcustan', NULL)
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (5, N'Turkiye', NULL)
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (6, N'', CAST(N'2019-04-08' AS Date))
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (7, N'', CAST(N'2019-04-08' AS Date))
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (8, N'Bolqaristan', CAST(N'2019-04-09' AS Date))
INSERT [dbo].[Nationality] ([Id], [Citizenship], [DeletedDate]) VALUES (9, N'Afrika', CAST(N'2019-04-08' AS Date))
SET IDENTITY_INSERT [dbo].[Nationality] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (3, N'Cavid', N'Mehdi-bayli', N'Nazim', N'Baku', CAST(N'2001-01-23' AS Date), 1, 1, 2, 179, 1, 1, 1, N'Baku', CAST(N'2019-04-04' AS Date), CAST(N'2022-04-04' AS Date), N'12345679', N'Asan xidmet', CAST(N'2019-04-09T19:22:20.753' AS DateTime), N'31231')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (4, N'dqdsq', N'vhvhvhgv', N'hgvhgvhv', N'hgvhgvhgv', CAST(N'2019-04-19' AS Date), 1, 1, 1, NULL, 1, 1, 1, N'vjjgvj', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-05' AS Date), N'878', N'vhgvhv', CAST(N'2019-04-08T16:16:17.840' AS DateTime), NULL)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (5, N'tofiq', N'vhvhvhgv', N'xa', N'xas', CAST(N'2019-04-19' AS Date), 1, 1, 1, 0, 1, 1, 1, N'vjjgvj', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-05' AS Date), N'878', N'vhgvhv', CAST(N'2019-04-08T16:15:49.573' AS DateTime), NULL)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (6, N'xxx', N'c', N'xxx', N'xas', CAST(N'2019-04-19' AS Date), 1, 1, 1, 0, 1, 1, 1, N'vjjgvj', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-05' AS Date), N'878', N'vhgvhv', CAST(N'2019-04-08T16:12:59.780' AS DateTime), NULL)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (8, N'gfgggd', N'Eminbeyli', N'Mirhesim', N'Naxcivan', CAST(N'2019-04-19' AS Date), 1, 1, 1, 160, 1, 1, 1, N'hh', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-09' AS Date), N'h', N'bb', NULL, N'h')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (9, N'kjndskjab', N'kbkb', N'kjbkb', N'kkbkb', CAST(N'2019-04-19' AS Date), 1, 1, 1, 0, 1, 1, 1, N'kjnjk', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-09' AS Date), N'98', N'hbhbjhb', CAST(N'2019-04-09T16:12:32.263' AS DateTime), N'8989')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (10, N'Cavid', N'Mehdi-bayli', N'Nazim', N'Baku', CAST(N'2001-01-23' AS Date), 1, 1, 2, 179, 1, 1, 1, N'Baku', CAST(N'2019-04-04' AS Date), CAST(N'2022-04-04' AS Date), N'12345679', N'Asan xidmet', NULL, N'31231')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (11, N'gfgggd', N'Eminbeyli', N'Mirhesim', N'Naxcivan', CAST(N'2019-04-19' AS Date), 1, 1, 1, 160, 1, 1, 1, N'hh', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-09' AS Date), N'h', N'bb', CAST(N'2019-04-09T21:16:36.043' AS DateTime), N'h')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (12, N'gfgggd', N'Eminbeyli', N'Mirhesim', N'Naxcivan', CAST(N'2019-04-19' AS Date), 1, 1, 1, 160, 1, 1, 1, N'hh', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-09' AS Date), N'h', N'bb', CAST(N'2019-04-09T21:15:49.760' AS DateTime), N'h')
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [FatherName], [BirthPlace], [BirthOfDate], [GenderId], [NationalityId], [MartialStatusId], [Height], [MilitaryStatusId], [EyeColorId], [BloodGroupId], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [IssuingAuthority], [DeletedDate], [Number]) VALUES (13, N'gfgggd', N'Eminbeyli', N'Mirhesim', N'Naxcivan', CAST(N'2019-04-19' AS Date), 1, 1, 1, 160, 1, 1, 1, N'hh', CAST(N'2019-04-19' AS Date), CAST(N'2019-04-09' AS Date), N'h', N'bb', CAST(N'2019-04-09T21:15:47.023' AS DateTime), N'h')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [DeletedDate], [Name]) VALUES (1, NULL, N'admin')
INSERT [dbo].[Role] ([Id], [DeletedDate], [Name]) VALUES (2, NULL, N'user')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (1, NULL, N'javidnm@code.edu.az', N'G??????????Z?t?~??l????w?\?8i', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (2, NULL, N'djavid.mli7@gmail.com', N'V?/8?<n?q?=qd??-64-?a??0	#u', 2)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (3, NULL, N'myUser', N'?e?Y B/?A~Hg??O??J???~??????z?', NULL)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (10, CAST(N'2019-04-09T23:10:52.690' AS DateTime), N'djavid.mli7@gmail.com', N' ?D#7???#???O????@?????,?', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (11, CAST(N'2019-04-09T23:10:50.423' AS DateTime), N'djavid.mli7@gmail.com', N' ?D#7???#???O????@?????,?', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (12, CAST(N'2019-04-09T23:10:47.890' AS DateTime), N'djavid.mli7@gmail.com', N'}"f????c????Oh(??'':?''??W@???', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (13, CAST(N'2019-04-09T23:10:45.293' AS DateTime), N'djavid.mli7@gmail.com', N'}"f????c????Oh(??'':?''??W@???', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (14, CAST(N'2019-04-09T23:10:42.310' AS DateTime), N'djavid.mli7@gmail.com', N'}"f????c????Oh(??'':?''??W@???', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (15, CAST(N'2019-04-09T23:10:38.983' AS DateTime), N'djavid.mli7@gmail.com', N'}"f????c????Oh(??'':?''??W@???', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (16, CAST(N'2019-04-09T23:10:13.110' AS DateTime), N'djavid.mli7@gmail.com', N'}"f????c????Oh(??'':?''??W@???', 1)
INSERT [dbo].[User] ([Id], [DeletedDate], [Email], [Password], [RoleId]) VALUES (19, NULL, N'qaqa', N'??b8d?E??	t?A>??????R?1JaMH', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([BloodGroupId])
REFERENCES [dbo].[BloodGroup] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([EyeColorId])
REFERENCES [dbo].[EyeColor] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([GenderId])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([MartialStatusId])
REFERENCES [dbo].[MartialStatus] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([MilitaryStatusId])
REFERENCES [dbo].[MilitaryStatus] ([Id])
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([NationalityId])
REFERENCES [dbo].[Nationality] ([Id])
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK__User__RoleId__6B24EA82] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK__User__RoleId__6B24EA82]
GO
USE [master]
GO
ALTER DATABASE [Final] SET  READ_WRITE 
GO
