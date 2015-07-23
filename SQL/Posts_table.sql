USE [andrew]
GO

/****** Object:  Table [andrew].[Posts] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [andrew].[Posts](
	[PostId] [int] NULL,
	[PostText] [text] NULL,
	[PostTitle] [varchar](50) NULL,
	[PostDate] [datetime2](7) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO