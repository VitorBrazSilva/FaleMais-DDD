USE [FaleMaisDBNovo]
GO
SET IDENTITY_INSERT [dbo].[Plano] ON 
GO
INSERT [dbo].[Plano] ([PlanoId], [Nome], [Tempo]) VALUES (1, N'FaleMais 30', 30)
GO
INSERT [dbo].[Plano] ([PlanoId], [Nome], [Tempo]) VALUES (2, N'FaleMais 60', 60)
GO
INSERT [dbo].[Plano] ([PlanoId], [Nome], [Tempo]) VALUES (3, N'FaleMais 120', 120)
GO
SET IDENTITY_INSERT [dbo].[Plano] OFF
GO
SET IDENTITY_INSERT [dbo].[Tarifa] ON 
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (1, 11, 16, 1.9)
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (2, 16, 11, 2.9)
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (3, 11, 17, 1.7)
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (4, 17, 11, 2.7)
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (5, 11, 18, 0.9)
GO
INSERT [dbo].[Tarifa] ([TarifaId], [Origem], [Destino], [ValorMin]) VALUES (6, 18, 11, 1.9)
GO
SET IDENTITY_INSERT [dbo].[Tarifa] OFF
GO
