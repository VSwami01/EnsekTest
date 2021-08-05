
USE [ENSEK]
GO

CREATE TABLE [dbo].[Test_Accounts](
	[AccountId] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Meter_Reading](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[MeterReadingDateTime] [datetime] NOT NULL,
	[MeterReadValue] [varchar](5) NOT NULL,
 CONSTRAINT [PK_MeterReading] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2344', N'Tommy', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2233', N'Barry', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'8766', N'Sally', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2345', N'Jerry', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2346', N'Ollie', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2347', N'Tara', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2348', N'Tammy', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2349', N'Simon', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2350', N'Colin', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2351', N'Gladys', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2352', N'Greg', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2353', N'Tony', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2355', N'Arthur', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'2356', N'Craig', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'6776', N'Laura', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'4534', N'JOSH', N'TEST')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1234', N'Freya', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1239', N'Noddy', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1240', N'Archie', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1241', N'Lara', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1242', N'Tim', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1243', N'Graham', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1244', N'Tony', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1245', N'Neville', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1246', N'Jo', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1247', N'Jim', N'Test')
GO
INSERT [dbo].[Test_Accounts] ([AccountId], [FirstName], [LastName]) VALUES (N'1248', N'Pam', N'Test')
GO
