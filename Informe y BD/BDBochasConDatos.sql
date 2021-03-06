USE [BDBochas]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/17/2018 19:13:24 ******/
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
INSERT [dbo].[Usuarios] ([idUsuario], [nombreUsuario], [password], [estado]) VALUES (1, N'Simon', N'simon', N'S')
INSERT [dbo].[Usuarios] ([idUsuario], [nombreUsuario], [password], [estado]) VALUES (2, N'Otro', N'1111', N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[TipoProducto] ON
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (1, N'Accesorios', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (2, N'Equipo Gimnasio', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (3, N'Equipo de boxeo', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (4, N'Equipo volley', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (5, N'Equipo de fútbol', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (6, N'Equipo Natación', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (7, N'Equipo Karate', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (8, N'Equipo Basquet', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (9, N'Equipo Bochas', N'S')
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [estado]) VALUES (10, N'Equipo Ciclismo', N'S')
SET IDENTITY_INSERT [dbo].[TipoProducto] OFF
/****** Object:  Table [dbo].[Disciplinas]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Disciplinas] ON
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (1, N'Tenis', 25, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (2, N'Volley', 3000, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (3, N'Natación', 2, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (4, N'Fútbol', 25, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (5, N'Patín', 250, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (6, N'Karate', 300, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (7, N'Bochas', 250, N'S')
INSERT [dbo].[Disciplinas] ([idDisciplina], [nombre], [precioCuota], [estado]) VALUES (8, N'Basquet', 150, N'S')
SET IDENTITY_INSERT [dbo].[Disciplinas] OFF
/****** Object:  Table [dbo].[Becas]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Becas] ON
INSERT [dbo].[Becas] ([idBeca], [descripcion], [nombre], [estado]) VALUES (5, N'Beca para estudiantes universitarios', N'Alumnos 2018', N'S')
INSERT [dbo].[Becas] ([idBeca], [descripcion], [nombre], [estado]) VALUES (6, N'Beca para estudiantes de secundario', N'Aprendiendo a hacer', N'S')
INSERT [dbo].[Becas] ([idBeca], [descripcion], [nombre], [estado]) VALUES (7, N'Beca para mejores promedios', N'DestacAR', N'S')
SET IDENTITY_INSERT [dbo].[Becas] OFF
/****** Object:  Table [dbo].[Socios]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Socios] ON
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (2, N'Juan', N'Juanes', N'juan de juanete', CAST(0x2E200B00 AS Date), N'S', 404040)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (3, N'Simon', N'Mungi', N'Por aca nomas', CAST(0x1A3C0B00 AS Date), N'S', 404040)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (4, N'Juanez', N'Juan', N'Juan de Juanes', CAST(0xEA1F0B00 AS Date), N'S', 45477)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (5, N'Santiago', N'Benavidez', N'Calle 1', CAST(0xD03E0B00 AS Date), N'S', 404041)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (6, N'Matias', N'Craver', N'Velez Sarsfield', CAST(0xC4250B00 AS Date), N'S', 2)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (7, N'Esteban', N'Banquito', N'Carpinteria 54', CAST(0xAB240B00 AS Date), N'S', 454545)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (8, N'Carlos', N'Fernandez', N'Maipú 256', CAST(0x09160B00 AS Date), N'S', 400000)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (9, N'Yanira', N'Espinoza', N'999-751 Fringilla Avenue', CAST(0x832F0B00 AS Date), N'S', 43187198)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (10, N'Flavia', N'Cáceres', N'400-4541 Metus Road', CAST(0x23280B00 AS Date), N'S', 47961840)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (11, N'Brithany', N'Aravena', N'537-5272 Ante. Av.', CAST(0xB80D0B00 AS Date), N'S', 46940783)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (12, N'Darien', N'Orellana', N'P.O. Box 225, 6861 Etiam Street', CAST(0x4F330B00 AS Date), N'S', 39376022)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (13, N'Ximena', N'Jiménez', N'Ap #256-1120 Integer Avenue', CAST(0x53290B00 AS Date), N'S', 46471674)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (14, N'Federico', N'Reyes', N'1786 Laoreet St.', CAST(0xDE110B00 AS Date), N'S', 45326720)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (15, N'Edgar', N'Núñez', N'2966 Amet St.', CAST(0x46170B00 AS Date), N'S', 46266204)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (16, N'Margarita', N'Ortiz', N'8145 Vestibulum Street', CAST(0xC4210B00 AS Date), N'S', 44420666)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (17, N'Lucio', N'Yáñez', N'389-8181 Nec Avenue', CAST(0x2D1E0B00 AS Date), N'S', 43825283)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (18, N'Dixon', N'Parra', N'5852 Rutrum. Ave', CAST(0x59330B00 AS Date), N'S', 44641204)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (19, N'Yamila', N'Vera', N'1267 Sollicitudin St.', CAST(0xE00D0B00 AS Date), N'S', 42118240)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (20, N'Jonas', N'Cáceres', N'5046 Quis, Road', CAST(0xE5070B00 AS Date), N'S', 41547272)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (21, N'Edward', N'Núñez', N'244-5645 Quis Av.', CAST(0x53330B00 AS Date), N'S', 44032230)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (22, N'Manu', N'Gallardo', N'Ap #539-3982 Magnis St.', CAST(0x7F310B00 AS Date), N'S', 48714273)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (23, N'Annais', N'Muñoz', N'391-4754 Sed Rd.', CAST(0x4D110B00 AS Date), N'S', 41377544)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (24, N'Francheska', N'Jiménez', N'424-4701 Augue Avenue', CAST(0x48100B00 AS Date), N'S', 39066516)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (25, N'Nayeli', N'Sanhueza', N'7914 Ac Avenue', CAST(0x7B2F0B00 AS Date), N'S', 46313403)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (26, N'Arantxa', N'Bustamante', N'Ap #727-5421 Aliquam Av.', CAST(0x4C080B00 AS Date), N'S', 48217212)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (27, N'Ramiro', N'Reyes', N'Ap #848-1223 Auctor Av.', CAST(0x421A0B00 AS Date), N'S', 40493843)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (28, N'Ágata', N'Ruiz', N'Ap #614-3184 Volutpat. Avenue', CAST(0x4A150B00 AS Date), N'S', 45458927)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (29, N'Kassandra', N'Alarcón', N'3126 Vitae Street', CAST(0x85290B00 AS Date), N'S', 45807640)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (30, N'Deivid', N'Aravena', N'P.O. Box 132, 4745 Quisque Avenue', CAST(0x21090B00 AS Date), N'S', 48773745)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (31, N'Jeremías', N'Sanhueza', N'2286 Magnis St.', CAST(0xDA280B00 AS Date), N'S', 47270268)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (32, N'Rachel', N'Reyes', N'P.O. Box 647, 2305 Pede St.', CAST(0xF5200B00 AS Date), N'S', 45503113)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (33, N'Tabita', N'Medina', N'901-6900 Cum Street', CAST(0xF5240B00 AS Date), N'S', 45938480)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (34, N'Italo', N'Ruiz', N'P.O. Box 826, 6368 Adipiscing Ave', CAST(0xEE120B00 AS Date), N'S', 47772158)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (35, N'Eber', N'Pizarro', N'4831 Velit Road', CAST(0x090D0B00 AS Date), N'S', 40537793)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (36, N'Aliro', N'Zúñiga', N'650 Libero Avenue', CAST(0x78260B00 AS Date), N'S', 48942596)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (37, N'Rosa', N'Sandoval', N'P.O. Box 803, 5380 Egestas Street', CAST(0xF8100B00 AS Date), N'S', 45497581)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (38, N'Samantha', N'Ortega', N'Ap #868-335 Est St.', CAST(0xF4090B00 AS Date), N'S', 44729743)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (39, N'Daniel', N'González', N'Ap #954-3888 Dui Avenue', CAST(0x3A2D0B00 AS Date), N'S', 45421567)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (40, N'Noelia', N'Silva', N'6796 Volutpat Rd.', CAST(0x27210B00 AS Date), N'S', 45978209)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (41, N'Alfredo', N'Herrera', N'635 Interdum St.', CAST(0x622E0B00 AS Date), N'S', 40171164)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (42, N'Nallely', N'Miranda', N'7922 Pellentesque Street', CAST(0x99130B00 AS Date), N'S', 47251316)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (43, N'Johaquin', N'Valdés', N'5159 Ligula. Rd.', CAST(0xFA220B00 AS Date), N'S', 46501215)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (44, N'Maicol', N'Parra', N'2914 Tempor Av.', CAST(0xED2A0B00 AS Date), N'S', 45159428)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (45, N'Naira', N'Cáceres', N'9694 Donec St.', CAST(0xD8270B00 AS Date), N'S', 47000481)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (46, N'Elias', N'Zúñiga', N'9074 Suscipit, Rd.', CAST(0x4A0F0B00 AS Date), N'S', 45661519)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (47, N'Jadiel', N'Valdés', N'P.O. Box 438, 6874 Eu Road', CAST(0x75250B00 AS Date), N'S', 44098140)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (48, N'Ryan', N'Álvarez', N'P.O. Box 978, 3250 Vitae Rd.', CAST(0x19280B00 AS Date), N'S', 45860900)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (49, N'Eimy', N'Olivares', N'P.O. Box 965, 769 Aliquet, Rd.', CAST(0xFB0B0B00 AS Date), N'S', 41325980)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (50, N'Antuan', N'Ramírez', N'P.O. Box 877, 5307 Sed St.', CAST(0x5A310B00 AS Date), N'S', 41181260)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (51, N'Brenda', N'Palma', N'Ap #707-3694 Mauris Rd.', CAST(0xFF240B00 AS Date), N'S', 40340009)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (52, N'Grace', N'Guerrero', N'8980 Convallis St.', CAST(0xD31F0B00 AS Date), N'S', 39553948)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (53, N'Jhordan', N'Fuentes', N'4711 In, Street', CAST(0xCF200B00 AS Date), N'S', 39592113)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (54, N'Ian', N'Gómez', N'Ap #262-7591 Conubia Ave', CAST(0x8E140B00 AS Date), N'S', 42370829)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (55, N'Yanella', N'Jara', N'8421 Ac, Ave', CAST(0x570F0B00 AS Date), N'S', 41820085)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (56, N'Lucía', N'Sepúlveda', N'Ap #134-6296 Neque Av.', CAST(0x0F280B00 AS Date), N'S', 43504495)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (57, N'Lyan', N'Vera', N'818-2827 At Rd.', CAST(0x0D140B00 AS Date), N'S', 47458174)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (58, N'Max', N'Sánchez', N'Ap #753-1113 Non, Rd.', CAST(0x16150B00 AS Date), N'S', 42829296)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (59, N'Marthyna', N'Pizarro', N'P.O. Box 460, 9082 Semper Avenue', CAST(0xE0320B00 AS Date), N'S', 47079658)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (60, N'Lukas', N'Bustamante', N'697-6842 Nec Ave', CAST(0xBA130B00 AS Date), N'S', 40253251)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (61, N'Matia', N'Torres', N'Ap #961-1925 Nibh Ave', CAST(0x36220B00 AS Date), N'S', 46768722)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (62, N'Ayleen', N'Araya', N'Ap #541-3978 Enim Road', CAST(0x30250B00 AS Date), N'S', 42734432)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (63, N'Joseph', N'Vargas', N'945 Nunc St.', CAST(0x86300B00 AS Date), N'S', 44591968)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (64, N'Adrian', N'Gómez', N'Ap #688-3763 Nec, Ave', CAST(0x951D0B00 AS Date), N'S', 40591192)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (65, N'Joaquina', N'Díaz', N'300-6373 Elementum, Avenue', CAST(0x22250B00 AS Date), N'S', 43235492)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (66, N'Jennifer', N'Sanhueza', N'P.O. Box 958, 4765 Ornare, Road', CAST(0x6B2F0B00 AS Date), N'S', 43520431)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (67, N'Leon', N'Toro', N'1676 Mauris Street', CAST(0xD5270B00 AS Date), N'S', 39453749)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (68, N'Jessica', N'Venegas', N'P.O. Box 249, 7002 Mi Ave', CAST(0xAC0E0B00 AS Date), N'S', 47564176)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (69, N'Inti', N'Medina', N'P.O. Box 558, 1404 Ut St.', CAST(0x84220B00 AS Date), N'S', 41997211)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (70, N'Benito', N'Castillo', N'748-6633 Tellus Rd.', CAST(0xB1140B00 AS Date), N'S', 39867502)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (71, N'Bernardita', N'Castro', N'Ap #627-3910 Placerat Avenue', CAST(0x1F290B00 AS Date), N'S', 45313780)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (72, N'Kasandra', N'Romero', N'6639 Imperdiet St.', CAST(0x772A0B00 AS Date), N'S', 40585889)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (73, N'Gerard', N'Carrasco', N'Ap #837-4518 Dolor St.', CAST(0x34210B00 AS Date), N'S', 48744279)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (74, N'Rouse', N'Saavedra', N'993-9099 A, St.', CAST(0xE90B0B00 AS Date), N'S', 48373648)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (75, N'Crishna', N'Pizarro', N'P.O. Box 155, 3245 Libero. Avenue', CAST(0x3C0C0B00 AS Date), N'S', 47554765)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (76, N'Aidan', N'Pizarro', N'P.O. Box 318, 2077 Nonummy. Rd.', CAST(0xE91A0B00 AS Date), N'S', 47212292)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (77, N'Ibrahim', N'Ruiz', N'5126 In Street', CAST(0x30130B00 AS Date), N'S', 44759613)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (78, N'Dakota', N'Carvajal', N'Ap #759-533 Ut Rd.', CAST(0x361C0B00 AS Date), N'S', 40787305)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (79, N'Rudy', N'Castillo', N'Ap #285-1181 Diam Rd.', CAST(0xCB2F0B00 AS Date), N'S', 44470112)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (80, N'Tobías', N'Escobar', N'Ap #122-3740 At, St.', CAST(0x30080B00 AS Date), N'S', 45686146)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (81, N'Karina', N'Núñez', N'742-2960 Pellentesque Avenue', CAST(0xA9130B00 AS Date), N'S', 46358496)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (82, N'Gerónimo', N'Aguilera', N'Ap #378-1608 Eget Street', CAST(0x62300B00 AS Date), N'S', 47474664)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (83, N'Escarlett', N'Vera', N'Ap #475-2962 Donec St.', CAST(0xE5200B00 AS Date), N'S', 41432358)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (84, N'Juana', N'Venegas', N'5735 Magnis St.', CAST(0x0E2C0B00 AS Date), N'S', 44967517)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (85, N'Martín', N'Martínez', N'1922 Ipsum. Rd.', CAST(0x57170B00 AS Date), N'S', 46627428)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (86, N'Maximiliano', N'Palma', N'6082 Lobortis St.', CAST(0x0A280B00 AS Date), N'S', 42280396)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (87, N'Jonatan', N'Fernández', N'7605 Sed, St.', CAST(0xD7290B00 AS Date), N'S', 48485619)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (88, N'Marisol', N'Saavedra', N'8828 Vulputate Road', CAST(0x772F0B00 AS Date), N'S', 41172954)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (89, N'Paz', N'Sandoval', N'Ap #594-5955 Porta Street', CAST(0x5F180B00 AS Date), N'S', 39851852)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (90, N'Damary', N'Herrera', N'Ap #813-6564 At, Street', CAST(0x15190B00 AS Date), N'S', 48939053)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (91, N'Lucca', N'Ramírez', N'430-235 Mi, Av.', CAST(0x0E270B00 AS Date), N'S', 47000875)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (92, N'Arturo', N'Araya', N'P.O. Box 414, 3590 Auctor Rd.', CAST(0xA2200B00 AS Date), N'S', 45309082)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (93, N'Baythiare', N'Ortiz', N'Ap #536-6297 Sed Road', CAST(0xA3160B00 AS Date), N'S', 47186102)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (94, N'Nayareth', N'Farías', N'P.O. Box 462, 7551 Felis. St.', CAST(0x49230B00 AS Date), N'S', 42797845)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (95, N'Tristán', N'Carvajal', N'838-2295 Arcu. St.', CAST(0x370F0B00 AS Date), N'S', 40580583)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (96, N'Lukas', N'Núñez', N'P.O. Box 130, 7163 Ligula St.', CAST(0xBE090B00 AS Date), N'S', 42148477)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (97, N'Carolina', N'Miranda', N'676-7233 Aliquam Ave', CAST(0xA4130B00 AS Date), N'S', 44011618)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (98, N'Yadira', N'Cáceres', N'P.O. Box 551, 5701 Lorem Rd.', CAST(0x3A2F0B00 AS Date), N'S', 45541115)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (99, N'Stefany', N'Maldonado', N'9909 Phasellus Rd.', CAST(0x75330B00 AS Date), N'S', 44499831)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (100, N'Irene', N'Herrera', N'P.O. Box 952, 296 Diam. Av.', CAST(0x0B0A0B00 AS Date), N'S', 43103027)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (101, N'Remigio', N'Sánchez', N'1747 Parturient Avenue', CAST(0x0C2B0B00 AS Date), N'S', 43164452)
GO
print 'Processed 100 total records'
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (102, N'Geraldine', N'Tapia', N'723 Nunc Street', CAST(0xA1120B00 AS Date), N'S', 44709498)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (103, N'Anyelina', N'Godoy', N'P.O. Box 816, 5431 Fusce Av.', CAST(0xF0180B00 AS Date), N'S', 44215405)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (104, N'Yordano', N'Contreras', N'348-7908 Sit St.', CAST(0x30230B00 AS Date), N'S', 40695506)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (105, N'Eduar', N'Poblete', N'Ap #639-2251 Leo. Avenue', CAST(0xF5090B00 AS Date), N'S', 48447824)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (106, N'Maritza', N'Flores', N'Ap #324-7093 Etiam Street', CAST(0x3A2E0B00 AS Date), N'S', 46335321)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (107, N'Yerko', N'Guerrero', N'308-6850 Eu Avenue', CAST(0x341B0B00 AS Date), N'S', 46636771)
INSERT [dbo].[Socios] ([idSocio], [nombre], [apellido], [direccion], [fechaNacimiento], [estado], [dni]) VALUES (108, N'Hugo', N'Aravena', N'345 Diam Road', CAST(0xA6260B00 AS Date), N'S', 45737718)
SET IDENTITY_INSERT [dbo].[Socios] OFF
/****** Object:  Table [dbo].[Recibo]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Recibo] ON
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (1, CAST(0xF13E0B00 AS Date), 250, N'Inscripcion', N'Juan', N'Juan')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (2, CAST(0x4C320B00 AS Date), 20, N'no se', N'otro juan', N'no el mismo juan')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (3, CAST(0xF23E0B00 AS Date), 50, N'Venta de Indumentaria Deportiva', N'Esteban Fernandez', N'Avellaneda 502')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (4, CAST(0xF33E0B00 AS Date), 300, N'Inscripcion', N'Espeche Oscar', N'UTN')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (5, CAST(0xF33E0B00 AS Date), 250, N'Inscripcion', N'Mansilla Gustavo', N'Su casa')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (6, CAST(0xF33E0B00 AS Date), 10000, N'Venta de Indumentaria Deportiva', N'ALGUIEN QUE VINO', N'No me dijo')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (7, CAST(0xF33E0B00 AS Date), 280000, N'Venta de Indumentaria Deportiva', N'Jewsbury Alejandra', N'Barrio Olmendo')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (8, CAST(0xF63E0B00 AS Date), 950, N'Inscripcion', N'Sebastien', N'Ogier')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (9, CAST(0xF63E0B00 AS Date), 1000, N'Inscripcion', N'Ott', N'Tanak')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (10, CAST(0xF63E0B00 AS Date), 142900, N'Venta de Indumentaria Deportiva', N'Carlos Tauro', N'Su casa')
INSERT [dbo].[Recibo] ([nroRecibo], [fechaRecibo], [montoPagado], [descripcion], [nombreCliente], [domicilioCliente]) VALUES (11, CAST(0xF63E0B00 AS Date), 5300, N'Venta de Indumentaria Deportiva', N'Mads Ostberg', N'Noruega')
SET IDENTITY_INSERT [dbo].[Recibo] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (1, N'Botellita del Bobby', 2500, 1, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (2, N'Mancuerna 5kg', 25, 2, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (4, N'Pelota volley', 200, 3, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (3, N'Guantes Everlast', 5000, 4, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (5, N'Pelota de futbol', 70000, 5, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (5, N'Botines fútbol', 70000, 6, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (6, N'Antiparras', 200, 7, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (7, N'Kimono Artes Marciales', 800, 8, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (8, N'Pelota Basquet Wilson', 200, 9, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (9, N'Bocha', 500, 10, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (10, N'Casco Ciclismo', 1500, 11, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (1, N'Guantes gimansio', 200, 12, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (2, N'Mancuerna 20 kg', 400, 13, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (3, N'Vendas', 200, 14, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (4, N'Pantalones Volley', 1100, 15, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (5, N'Camiseta selección argentina', 1500, 16, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (6, N'Tapones oídos', 250, 17, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (7, N'Kimono negro karate', 1700, 18, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (8, N'Camiseta Chicago Bulls', 1300, 19, N'S')
INSERT [dbo].[Productos] ([idTipoProducto], [descripcion], [precioUnitario], [idProductos], [estado]) VALUES (10, N'Anteojos deportivos', 1200, 20, N'S')
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Categorias]    Script Date: 11/17/2018 19:13:24 ******/
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
SET IDENTITY_INSERT [dbo].[Categorias] ON
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (1, 1, 250, 500, N'Senior', 40, 45, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (2, 1, 250, 300, N'Deportes', 21, 20, N'N')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (3, 2, 200, 50, N'Cebollitas', 11, 13, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (4, 4, 500, 250, N'Pichones', 15, 17, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (5, 5, 250, 500, N'Pichones', 15, 17, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (6, 6, 50, 200, N'Cebollitas', 11, 13, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (7, 7, 500, 250, N'Senior', 40, 45, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (8, 8, 500, 250, N'Senior', 40, 45, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (9, 5, 50, 200, N'Cebollitas', 11, 13, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (10, 8, 50, 200, N'Cebollitas', 11, 13, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (11, 1, 50, 200, N'Cebollitas', 11, 13, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (12, 1, 250, 500, N'Pichones', 15, 17, N'S')
INSERT [dbo].[Categorias] ([idCategoria], [idDisciplina], [precioCuota], [precioInscripcion], [nombre], [edadDesde], [edadHasta], [estado]) VALUES (13, 8, 500, 250, N'Pichones', 15, 17, N'S')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
/****** Object:  Table [dbo].[BecasXSocios]    Script Date: 11/17/2018 19:13:24 ******/
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
/****** Object:  Table [dbo].[CuotaSocial]    Script Date: 11/17/2018 19:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuotaSocial](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[mes] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CuotaSocial] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC,
	[mes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TelefonosXSocios]    Script Date: 11/17/2018 19:13:24 ******/
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
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (3, 4, N'Mi mamá', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (4, 4122, N'su mamá', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (5, 1111, N'-', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (6, 15489945, N'Lenny', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (7, 1598877, N'Pepe', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (8, 15778963, N'Kamila Jara', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (9, 15882414, N'Lautaro Rojas', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (10, 15626984, N'Richard Medina', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (11, 15734958, N'Aleen González', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (12, 15958834, N'Jordano Vera', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (13, 15787825, N'Aileen Soto', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (14, 15320674, N'Ángel Aguilera', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (15, 15546078, N'Mitchell Rodríguez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (16, 15819932, N'Estefania López', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (17, 15602121, N'Salvador Sánchez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (18, 15853818, N'Aitor Sáez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (19, 15202791, N'Melanie Zúñiga', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (20, 15221109, N'Flavio Sanhueza', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (21, 15696484, N'Alicia López', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (22, 15384637, N'Ashlie Ortiz', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (23, 15883183, N'Elvis Espinoza', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (24, 15321687, N'Joao Escobar', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (25, 15112078, N'Nelson Henríquez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (26, 15546908, N'Aranza Valenzuela', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (27, 15167567, N'Ademir Castro', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (28, 15383040, N'Milenka Sanhueza', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (29, 15993231, N'Escarlet Toro', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (30, 15560390, N'Gael Pérez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (31, 15851946, N'Nicolás Olivares', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (32, 15091323, N'Annette Morales', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (33, 15801561, N'Anakin Aguilera', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (34, 15231121, N'Bryan Sepúlveda', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (35, 15392098, N'Cristina Romero', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (36, 15607184, N'Amapola Campos', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (37, 15097616, N'Víctor San Martín', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (38, 15287869, N'Fredy López', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (39, 15880469, N'Luka Aravena', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (40, 15175486, N'Lizbeth Leiva', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (41, 15224728, N'Cristhian Ortega', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (42, 15430371, N'Thiago Gallardo', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (43, 15643040, N'Sharon Jara', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (44, 15959067, N'Giuliana Sepúlveda', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (45, 15738939, N'Marianela Bustamante', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (46, 15410344, N'Maira Vega', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (47, 15942365, N'Krishna Vidal', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (48, 15818690, N'Fabiola Pérez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (49, 15095793, N'Francisco Maldonado', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (50, 15745142, N'Karen Vidal', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (51, 15650157, N'Nahir Rojas', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (52, 15366415, N'Darian Rodríguez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (53, 15490672, N'Aline Miranda', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (54, 15834106, N'Giovanni Godoy', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (55, 15543866, N'Maythe Bustos', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (56, 15382405, N'Salomé Medina', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (57, 15914408, N'Francisco Miranda', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (58, 15941768, N'Vittorio Garrido', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (59, 15520292, N'Lisset Silva', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (60, 15175912, N'Arantza Reyes', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (61, 15756169, N'Johnny Salazar', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (62, 15861206, N'Maikel Henríquez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (63, 15682919, N'Joaquina Gómez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (64, 15445437, N'Mailen Tapia', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (65, 15227347, N'René Yáñez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (66, 15868199, N'Dilan Contreras', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (67, 15473697, N'Giuseppe Vásquez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (68, 15276160, N'Francoise Leiva', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (69, 15327745, N'Fermín Donoso', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (70, 15225286, N'Dante Fuentes', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (71, 15184779, N'Marcel Rodríguez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (72, 15380260, N'Yadira Ruiz', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (73, 15632404, N'Maythe Castillo', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (74, 15288059, N'Renata Pino', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (75, 15576205, N'Mikaela Gallardo', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (76, 15586590, N'Marianela Valenzuela', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (77, 15208281, N'Branco Garrido', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (78, 15894076, N'Francesca Aravena', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (79, 15622639, N'Brandon Escobar', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (80, 15253210, N'Anaís Sáez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (81, 15248818, N'Bianka Aguilera', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (82, 15290100, N'Anna Guerrero', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (83, 15222059, N'Eleazar Saavedra', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (84, 15823279, N'Dastin Garrido', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (85, 15294804, N'Matthew Soto', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (86, 15705463, N'Luckas Sandoval', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (87, 15000778, N'Darian Jara', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (88, 15194961, N'Nathalie Alvarado', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (89, 15023921, N'Francoise Ortega', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (90, 15394799, N'Yhan Espinoza', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (91, 15446783, N'Dieter Leiva', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (92, 15603688, N'Sarita Alvarado', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (93, 15089048, N'Jeremi Campos', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (94, 15657151, N'Anthonela Gallardo', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (95, 15810811, N'Lorena Espinoza', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (96, 15190877, N'Debora Venegas', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (97, 15169949, N'Marcial Gallardo', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (98, 15551172, N'Abrahan Pizarro', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (99, 15525849, N'Astrid Sáez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (100, 15754000, N'Arianna Martínez', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (101, 15796530, N'Andy García', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (102, 15018786, N'Elio Reyes', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (103, 15695490, N'Debora Garrido', N'S')
GO
print 'Processed 100 total records'
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (104, 15015546, N'Zamira Valdés', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (105, 15300127, N'Emili Olivares', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (106, 15140194, N'Jason Saavedra', N'S')
INSERT [dbo].[TelefonosXSocios] ([idSocio], [nroTelefono], [responsableTelefono], [estado]) VALUES (107, 15288731, N'Gadiel López', N'S')
/****** Object:  Table [dbo].[VentaProductos]    Script Date: 11/17/2018 19:13:24 ******/
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
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (2, 2, 2)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (5, 4, 3)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (6, 6, 5)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (9, 1, 1)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (9, 6, 5)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (9, 13, 2)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (10, 8, 7)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (10, 13, 2)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (10, 18, 7)
INSERT [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto]) VALUES (10, 20, 10)
/****** Object:  Table [dbo].[CategoriasXSocios]    Script Date: 11/17/2018 19:13:24 ******/
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
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (3, 1, N'S', 1)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (4, 2, N'S', 3)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (5, 4, N'S', 4)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (7, 4, N'S', 4)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (10, 1, N'S', 12)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (10, 6, N'S', 6)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (15, 2, N'S', 3)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (30, 4, N'S', 4)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (45, 1, N'S', 2)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (49, 6, N'S', 6)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (49, 7, N'S', 7)
INSERT [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [asistencia], [idCategoria]) VALUES (72, 8, N'S', 10)
/****** Object:  Table [dbo].[VentaProductosXSocioXDisciplina]    Script Date: 11/17/2018 19:13:24 ******/
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
/****** Object:  Table [dbo].[CuotaDisciplina]    Script Date: 11/17/2018 19:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuotaDisciplina](
	[nroRecibo] [int] NOT NULL,
	[idSocio] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[mes] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CuotaDisciplina] PRIMARY KEY CLUSTERED 
(
	[nroRecibo] ASC,
	[idSocio] ASC,
	[idCategoria] ASC,
	[idDisciplina] ASC,
	[mes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Recibo_nombreCliente]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[Recibo] ADD  CONSTRAINT [DF_Recibo_nombreCliente]  DEFAULT ('Cliente') FOR [nombreCliente]
GO
/****** Object:  Default [DF_Recibo_domicilioCliente]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[Recibo] ADD  CONSTRAINT [DF_Recibo_domicilioCliente]  DEFAULT ('DOMICILIO') FOR [domicilioCliente]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Becas]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Becas] FOREIGN KEY([idBeca])
REFERENCES [dbo].[Becas] ([idBeca])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Becas]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Recibo]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Recibo]
GO
/****** Object:  ForeignKey [FK_BecasXSocios_Socios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[BecasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_BecasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[BecasXSocios] CHECK CONSTRAINT [FK_BecasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_CategoriasXDisciplinas_Disciplinas]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[Categorias]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas] FOREIGN KEY([idDisciplina])
REFERENCES [dbo].[Disciplinas] ([idDisciplina])
GO
ALTER TABLE [dbo].[Categorias] CHECK CONSTRAINT [FK_CategoriasXDisciplinas_Disciplinas]
GO
/****** Object:  ForeignKey [FK_CategoriasXSocios_Categorias]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CategoriasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXSocios_Categorias] FOREIGN KEY([idCategoria], [idDisciplina])
REFERENCES [dbo].[Categorias] ([idCategoria], [idDisciplina])
GO
ALTER TABLE [dbo].[CategoriasXSocios] CHECK CONSTRAINT [FK_CategoriasXSocios_Categorias]
GO
/****** Object:  ForeignKey [FK_CategoriasXSocios_Socios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CategoriasXSocios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[CategoriasXSocios] CHECK CONSTRAINT [FK_CategoriasXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_CategoriasXSocios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_CategoriasXSocios] FOREIGN KEY([idSocio], [idDisciplina], [idCategoria])
REFERENCES [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [idCategoria])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_CategoriasXSocios]
GO
/****** Object:  ForeignKey [FK_CuotaDisciplina_Recibo]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CuotaDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_CuotaDisciplina_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[CuotaDisciplina] CHECK CONSTRAINT [FK_CuotaDisciplina_Recibo]
GO
/****** Object:  ForeignKey [FK_CuotaSocial_Recibo]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CuotaSocial]  WITH CHECK ADD  CONSTRAINT [FK_CuotaSocial_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[CuotaSocial] CHECK CONSTRAINT [FK_CuotaSocial_Recibo]
GO
/****** Object:  ForeignKey [FK_CuotaSocial_Socios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[CuotaSocial]  WITH CHECK ADD  CONSTRAINT [FK_CuotaSocial_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[CuotaSocial] CHECK CONSTRAINT [FK_CuotaSocial_Socios]
GO
/****** Object:  ForeignKey [FK_Productos_TipoProducto]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProducto] FOREIGN KEY([idTipoProducto])
REFERENCES [dbo].[TipoProducto] ([idTipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProducto]
GO
/****** Object:  ForeignKey [FK_TelefonosXSocios_Socios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[TelefonosXSocios]  WITH CHECK ADD  CONSTRAINT [FK_TelefonosXSocios_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[TelefonosXSocios] CHECK CONSTRAINT [FK_TelefonosXSocios_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Productos]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Productos] FOREIGN KEY([idProductos], [idTipoProducto])
REFERENCES [dbo].[Productos] ([idProductos], [idTipoProducto])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Productos]
GO
/****** Object:  ForeignKey [FK_VentaProductos_Recibo]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[VentaProductos]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductos_Recibo] FOREIGN KEY([nroRecibo])
REFERENCES [dbo].[Recibo] ([nroRecibo])
GO
ALTER TABLE [dbo].[VentaProductos] CHECK CONSTRAINT [FK_VentaProductos_Recibo]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios] FOREIGN KEY([idProductos], [idDisciplina], [idCategoria])
REFERENCES [dbo].[CategoriasXSocios] ([idSocio], [idDisciplina], [idCategoria])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_CategoriasXSocios]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_Socios]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios] FOREIGN KEY([idSocio])
REFERENCES [dbo].[Socios] ([idSocio])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_Socios]
GO
/****** Object:  ForeignKey [FK_VentaProductosXSocioXDisciplina_VentaProductos1]    Script Date: 11/17/2018 19:13:24 ******/
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina]  WITH CHECK ADD  CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos1] FOREIGN KEY([nroRecibo], [idProductos], [idTipoProducto])
REFERENCES [dbo].[VentaProductos] ([nroRecibo], [idProductos], [idTipoProducto])
GO
ALTER TABLE [dbo].[VentaProductosXSocioXDisciplina] CHECK CONSTRAINT [FK_VentaProductosXSocioXDisciplina_VentaProductos1]
GO
