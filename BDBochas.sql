USE [BDBochas]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](20) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([idUsuario], [nombreUsuario], [password], [estado]) VALUES (1, N'admin', N'123', N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[idTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Disciplinas]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disciplinas](
	[idDisciplina] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[precioCuota] [int] NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Disciplinas] PRIMARY KEY CLUSTERED 
(
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Becas]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Becas](
	[idBeca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](75) NULL,
	[nombre] [varchar](25) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Becas] PRIMARY KEY CLUSTERED 
(
	[idBeca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socios](
	[idSocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[direccion] [varchar](75) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[dni] [int] NOT NULL,
 CONSTRAINT [PK_Socios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recibo]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Recibo](
	[nroRecibo] [int] IDENTITY(1,1) NOT NULL,
	[fechaRecibo] [date] NOT NULL,
	[montoPagado] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[nombreCliente] [varchar](50) NOT NULL,
	[domicilioCliente] [varchar](75) NOT NULL,
 CONSTRAINT [PK_Recibo] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[idTipoProducto] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precioUnitario] [int] NOT NULL,
	[idProductos] [int] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[idProductos] ASC,
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[precioCuota] [int] NOT NULL,
	[precioInscripcion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[edadDesde] [int] NOT NULL,
	[edadHasta] [int] NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_CategoriasXDisciplinas] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC,
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BecasXSocios]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BecasXSocios](
	[idBeca] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[fechaInicioBeca] [date] NOT NULL,
	[fechaFinBeca] [date] NULL,
	[nroRecibo] [int] NOT NULL,
 CONSTRAINT [PK_BecasXSocios] PRIMARY KEY CLUSTERED 
(
	[idBeca] ASC,
	[fechaInicioBeca] ASC,
	[idSocio] ASC,
	[nroRecibo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuotaSocial]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuotaSocial](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
 CONSTRAINT [PK_CuotaSocial] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefonosXSocios]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TelefonosXSocios](
	[idSocio] [int] NOT NULL,
	[nroTelefono] [int] NOT NULL,
	[responsableTelefono] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TelefonosXSocios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC,
	[nroTelefono] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentaProductos]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProductos](
	[nroRecibo] [int] NOT NULL,
	[idProductos] [int] NOT NULL,
	[idTipoProducto] [int] NOT NULL,
 CONSTRAINT [PK_VentaProductos] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idProductos] ASC,
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriasXSocios]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoriasXSocios](
	[idSocio] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[asistencia] [varchar](1) NOT NULL,
	[idCategoria] [int] NOT NULL,
 CONSTRAINT [PK_DisciplinasXSocios] PRIMARY KEY CLUSTERED 
(
	[idSocio] ASC,
	[idDisciplina] ASC,
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentaProductosXSocioXDisciplina]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaProductosXSocioXDisciplina](
	[nroRecibo] [int] NOT NULL,
	[idProductos] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[idTipoProducto] [int] NOT NULL,
 CONSTRAINT [PK_VentaProductosXSocioXDisciplina] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idDisciplina] ASC,
	[idProductos] ASC,
	[idSocio] ASC,
	[idCategoria] ASC,
	[idTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuotaDisciplina]    Script Date: 10/19/2018 20:32:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuotaDisciplina](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
 CONSTRAINT [PK_CuotaDisciplina] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC,
	[idCategoria] ASC,
	[idDisciplina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Recibo_nombreCliente]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[Recibo] ADD  CONSTRAINT [DF_Recibo_nombreCliente]  DEFAULT ('Cliente') FOR [nombreCliente]
GO
/****** Object:  Default [DF_Recibo_domicilioCliente]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[Recibo] ADD  CONSTRAINT [DF_Recibo_domicilioCliente]  DEFAULT ('DOMICILIO') FOR [domicilioCliente]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Becas]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Becas] FOREIGN KEY([idBeca])
REFERENCES [dbo].[Becas] ([idBeca])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Becas]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Recibo]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Recibo]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Socios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_CategoriasXDisciplinas_Disciplinas]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[Categorias]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas] FOREIGN KEY([idDisciplina])
REFERENCES [dbo].[Disciplinas] ([idDisciplina])
GO
ALTER TABLE [dbo].[Categorias] CHECK CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas]
GO
/****** Object:  ForeignKey [FK_CategoriasXSocios_Categorias]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CategoriasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXSocios_Categorias] FOREIGN KEY([idCategoria], [idDisciplina])
REFERENCES [dbo].[Categorias] ([idCategoria], [idDisciplina])
GO
ALTER TABLE [dbo].[CategoriasXSocios] CHECK CONSTRAINT [FK_CategoriasXSocios_Categorias]
GO
/****** Object:  ForeignKey [FK_CategoriasXSocios_Socios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CategoriasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[CategoriasXSocios] CHECK CONSTRAINT [FK_CategoriasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_CategoriasXSocios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_CategoriasXSocios] FOREIGN KEY([idSocio], [idDisciplina], [idCategoria])
REFERENCES [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [idCategoria])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_CategoriasXSocios]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_Recibo]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_Recibo]
GO
/****** Object:  ForeignKey [FK_CuotaSocial_Recibo]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CuotaSocial]  WITH CHECK ADD  CONSTRAINT [FK_CuotaSocial_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[CuotaSocial] CHECK CONSTRAINT [FK_CuotaSocial_Recibo]
GO
/****** Object:  ForeignKey [FK_CuotaSocial_Socios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[CuotaSocial]  WITH CHECK ADD  CONSTRAINT [FK_CuotaSocial_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[CuotaSocial] CHECK CONSTRAINT [FK_CuotaSocial_Socios]
GO
/****** Object:  ForeignKey [FK_Productos_TipoProducto]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProducto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo].[TipoProducto] ([idTipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProducto]
GO
/****** Object:  ForeignKey [FK_TelefonosXSocios_Socios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[TelefonosXSocios]  WITH CHECK ADD  CONSTRAINT [FK_TelefonosXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[TelefonosXSocios] CHECK CONSTRAINT [FK_TelefonosXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Productos]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Productos] FOREIGN KEY([idProductos], [idTipoProducto])
REFERENCES [dbo].[Productos] ([idProductos], [idTipoProducto])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Productos]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Recibo]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Recibo]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios] FOREIGN KEY([idProductos], [idDisciplina], [idCategoria])
REFERENCES [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [idCategoria])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_Socios]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_VentaProductos1]    Script Date: 10/19/2018 20:32:25 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos1] FOREIGN KEY([nroRecibo], [idProductos], [idTipoProducto])
REFERENCES [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos1]
GO
