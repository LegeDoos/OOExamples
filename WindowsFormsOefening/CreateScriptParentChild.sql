        CREATE TABLE [dbo].[tblParent](
	    [ID] [int] IDENTITY(1,1) NOT NULL,
	    [Name] [nvarchar](50) NULL,
	    [Status] [nvarchar](50) NULL,
        CONSTRAINT [PK_tblParentTable] PRIMARY KEY CLUSTERED 
        ([ID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]
        GO
        CREATE TABLE [dbo].[tblChild](
	    [ID] [int] IDENTITY(1,1) NOT NULL,
	    [Name] [nvarchar](50) NULL,
	    [ParentID] [int] NOT NULL,
	    [ClassType] [nvarchar](50) NOT NULL,
	    [ExtraAttribute] [nvarchar](50) NULL,
        CONSTRAINT [PK_tblChild] PRIMARY KEY CLUSTERED 
        ([ID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]
        GO
        ALTER TABLE [dbo].[tblChild]  WITH CHECK ADD CONSTRAINT [FK_tblChild_tblChild] FOREIGN KEY([ParentID])
        REFERENCES [dbo].[tblParent] ([ID])
        GO
        ALTER TABLE [dbo].[tblChild] CHECK CONSTRAINT [FK_tblChild_tblChild]
        GO

SET IDENTITY_INSERT [dbo].[tblParent] ON 
GO
INSERT [dbo].[tblParent] ([ID], [Name], [Status]) VALUES (1, N'Klas', N'Actief  ')
GO
INSERT [dbo].[tblParent] ([ID], [Name], [Status]) VALUES (2, N'Voertuig', N'Actief ')
GO
INSERT [dbo].[tblParent] ([ID], [Name], [Status]) VALUES (3, N'Leger', N'Actief')
GO
SET IDENTITY_INSERT [dbo].[tblParent] OFF
GO
SET IDENTITY_INSERT [dbo].[tblChild] ON 
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (1, N'Docent', 1, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (2, N'Student 1', 1, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (6, N'Wiel', 2, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (7, N'Stuur', 2, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (8, N'Stoel', 2, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (10, N'Stoel', 2, N'SubClass', N'Sportstoel          ')
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (11, N'Infantry', 3, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (12, N'Artillery', 3, N'ChildClass', NULL)
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (13, N'Cavalry', 3, N'SubClass', N'Scouts')
GO
INSERT [dbo].[tblChild] ([ID], [Name], [ParentID], [ClassType], [ExtraAttribute]) VALUES (19, N'Student 2', 1, N'ChildClass', NULL)
GO
SET IDENTITY_INSERT [dbo].[tblChild] OFF
GO

