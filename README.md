# MVCProjects#

To run no further action is needed.

It has connected to LocalDB but if you want to connect it to <SQL Server> go to <appsetting.json> file to change the server and database name as shown below.

"LGXContext": "Server=<yourservername>;Database=<yourdatabase>;Trusted_Connection=True;MultipleActiveResultSets=true"

Then run the following two SQL scripts to create a <table>

======================================================================================= USE <Your DB name>

/****** Object: Table [dbo].[RelayRack] Script Date: 8/11/2021 11:09:24 PM ******/ DROP TABLE [dbo].[RelayRack] GO

/****** Object: Table [dbo].[RelayRack] Script Date: 8/11/2021 11:09:24 PM ******/ SET ANSI_NULLS ON GO

SET QUOTED_IDENTIFIER ON GO

SET ANSI_PADDING ON GO

CREATE TABLE [dbo].[RelayRack]( [Id] [int] IDENTITY(1,1) NOT NULL, [Name] nvarchar NULL, [Isle] varchar NULL, [RackNumber] nvarchar NULL, [Comment] varchar NULL, CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED ( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF GO

====================================================================================

ALTER TABLE [dbo].[Shelf] DROP CONSTRAINT [FK_Sale_Movie_MovieId] GO

/****** Object: Table [dbo].[Shelf] Script Date: 8/11/2021 11:09:52 PM ******/ DROP TABLE [dbo].[Shelf] GO

/****** Object: Table [dbo].[Shelf] Script Date: 8/11/2021 11:09:52 PM ******/ SET ANSI_NULLS ON GO

SET QUOTED_IDENTIFIER ON GO

CREATE TABLE [dbo].[Shelf]( [Id] [int] IDENTITY(1,1) NOT NULL, [DeviceType] nvarchar NULL, [RelayRackId] [int] NOT NULL, CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED ( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Shelf] WITH CHECK ADD CONSTRAINT [FK_Sale_Movie_MovieId] FOREIGN KEY([RelayRackId]) REFERENCES [dbo].[RelayRack] ([Id]) ON DELETE CASCADE GO

ALTER TABLE [dbo].[Shelf] CHECK CONSTRAINT [FK_Sale_Movie_MovieId] GO

Author.
Zemenu Bejiga ZBejiga@asginc.us
