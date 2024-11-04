--Server=localhost\\SQLEXPRESS;Database=WGR;Trusted_Connection=True;"

USE [WGR]
GO

/****** Object:  Table [dbo].[StockDataInput]    Script Date: 11/4/2024 1:25:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StockDataInput](
	[Run] [int] IDENTITY(1,1) NOT NULL,
	[SectionCode] [nvarchar](10) NOT NULL,
	[RegistDateTime] [datetime] NOT NULL,
	[PartNumber] [nvarchar](20) NOT NULL,
	[PiecePerKanban] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_StockDataInput] PRIMARY KEY CLUSTERED 
(
	[Run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[StockList](
	[SectionCode] [nvarchar](10) NOT NULL,
	[PartNumber] [nvarchar](20) NOT NULL,
	[Balance] [int] NOT NULL,
	[PiecePerKanban] [int] NOT NULL,
	[HHLimit] [int] NOT NULL,
	[HLimit] [int] NOT NULL,
	[LLimit] [int] NOT NULL,
	[LLLimt] [int] NOT NULL,
	[ActivePN] [bit] NOT NULL,
 CONSTRAINT [PK_StockList] PRIMARY KEY CLUSTERED 
(
	[SectionCode] ASC,
	[PartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[StockListLog](
	[run] [int] IDENTITY(1,1) NOT NULL,
	[SectionCode] [nvarchar](10) NOT NULL,
	[registdatetime] [datetime] NOT NULL,
	[PartNumber] [nvarchar](20) NOT NULL,
	[Balance] [int] NOT NULL,
	[upLoad] [bit] NULL,
 CONSTRAINT [PK_StockListLog] PRIMARY KEY CLUSTERED 
(
	[run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

