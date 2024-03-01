USE [pharmacy]
GO

/****** Object:  Table [dbo].[druginfo]    Script Date: 3/1/2024 3:20:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[druginfo](
	[sn] [int] IDENTITY(1,1) NOT NULL,
	[id] [int] NOT NULL,
	[medname] [varchar](250) NOT NULL,
	[quantity_of_bucket] [int] NOT NULL,
	[quantity_of_tabs] [int] NOT NULL,
	[price] [bigint] NOT NULL,
	[tabs] [int] NOT NULL,
	[company] [varchar](250) NOT NULL,
	[expire] [date] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[druginfo]  WITH CHECK ADD  CONSTRAINT [FK_druginfo_drugs] FOREIGN KEY([id])
REFERENCES [dbo].[drugs] ([id])
GO

ALTER TABLE [dbo].[druginfo] CHECK CONSTRAINT [FK_druginfo_drugs]
GO


