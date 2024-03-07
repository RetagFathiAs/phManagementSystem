USE [pharmacy]
GO

/****** Object:  Table [dbo].[depts]    Script Date: 3/7/2024 3:22:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[depts](
	[name] [varchar](250) NOT NULL,
	[mobilephone] [varchar](250) NOT NULL,
	[homephone] [varchar](250) NOT NULL,
	[keyname] [varchar](250) NOT NULL
) ON [PRIMARY]
GO


