USE [bloodBankDB]
GO
/****** Object:  Table [dbo].[newDonor]    Script Date: 17.04.2021 13:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[newDonor](
	[did] [int] IDENTITY(1,1) NOT NULL,
	[dname] [varchar](250) NOT NULL,
	[fname] [varchar](250) NOT NULL,
	[mname] [varchar](250) NOT NULL,
	[dob] [varchar](250) NOT NULL,
	[mobile] [varchar](50) NOT NULL,
	[gender] [varchar](25) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[bloodGroup] [varchar](250) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[daddress] [varchar](max) NOT NULL,
 CONSTRAINT [PK__newDonor__D877D216255ACE1A] PRIMARY KEY CLUSTERED 
(
	[did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 17.04.2021 13:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[bid] [int] IDENTITY(1,1) NOT NULL,
	[blood_group] [varchar](50) NOT NULL,
	[quantity] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[newDonor] ON 

INSERT [dbo].[newDonor] ([did], [dname], [fname], [mname], [dob], [mobile], [gender], [email], [bloodGroup], [city], [daddress]) VALUES (1, N'Derya', N'Ahmet', N'Semra', N'2019-03-02', N'5312345656', N'female', N'derya88@hotmail.com', N'A+', N'Ankara', N'Ankara bahcelievler')
INSERT [dbo].[newDonor] ([did], [dname], [fname], [mname], [dob], [mobile], [gender], [email], [bloodGroup], [city], [daddress]) VALUES (2, N'Alican', N'Atakan', N'Arzu', N'15 Haziran 1994 Çarşamba', N'5443567878', N'Male', N'ali12@hotmail.com', N'0-', N'Bursa', N'Bursa')
SET IDENTITY_INSERT [dbo].[newDonor] OFF
GO
SET IDENTITY_INSERT [dbo].[stock] ON 

INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (1, N'A+', N'100')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (2, N'0+', N'111')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (3, N'B+', N'100')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (4, N'AB+', N'100')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (5, N'A-', N'120')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (6, N'0-', N'109')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (7, N'B-', N'100')
INSERT [dbo].[stock] ([bid], [blood_group], [quantity]) VALUES (9, N'AB-', N'105')
SET IDENTITY_INSERT [dbo].[stock] OFF
GO
