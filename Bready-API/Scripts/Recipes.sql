SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BreadId] [int] NOT NULL,
	[Flour] [int] NOT NULL,
	[Flour2] [int] NULL,
	[FlourTypes] [nvarchar](500) NOT NULL,
	[Water] [int] NOT NULL,
	[WaterTemp] [int] NOT NULL,
	[Salt] [int] NOT NULL,
	[Yeast] [int] NULL,
	[Starter] [int] NULL,
	[YeastTsp] [decimal](18, 2) NULL,
	[BulkFermentTime] [decimal](18, 2) NOT NULL,
	[ProofTime] [decimal](18, 2) NOT NULL,
	[OvenTemp] [int] NOT NULL,
	[BakeTime] [decimal](18, 2) NOT NULL,
	[MixTime] [decimal](18, 2) NOT NULL,
	[StarterType] [nvarchar](200) NULL,
	[NumberOfSteps] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recipes] ADD  CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_BreadId] FOREIGN KEY([BreadId])
REFERENCES [dbo].[Breads] ([Id])
GO
ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_BreadId]
GO
