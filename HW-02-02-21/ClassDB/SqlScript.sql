USE [First_DB]
GO
/****** Object:  Table [dbo].[Tech]    Script Date: 03.02.2021 19:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tech](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[model] [nvarchar](50) NULL,
	[Company] [nvarchar](50) NULL,
	[price] [int] NULL,
	[ReleaseDate] [date] SPARSE  NULL,
 CONSTRAINT [PK_Tech] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
