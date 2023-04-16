USE [Faruk]
GO

/****** Object:  Table [dbo].[ProductsCard]    Script Date: 17.04.2023 02:34:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductsCard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[TotalPrice] [money] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

