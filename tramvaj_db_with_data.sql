USE [master]
GO
/****** Object:  Database [tramvaj_db]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE DATABASE [tramvaj_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tramvaj_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tramvaj_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tramvaj_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tramvaj_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [tramvaj_db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tramvaj_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tramvaj_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tramvaj_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tramvaj_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tramvaj_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tramvaj_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [tramvaj_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tramvaj_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tramvaj_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tramvaj_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tramvaj_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tramvaj_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tramvaj_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tramvaj_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tramvaj_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tramvaj_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tramvaj_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tramvaj_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tramvaj_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tramvaj_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tramvaj_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tramvaj_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tramvaj_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tramvaj_db] SET RECOVERY FULL 
GO
ALTER DATABASE [tramvaj_db] SET  MULTI_USER 
GO
ALTER DATABASE [tramvaj_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tramvaj_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tramvaj_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tramvaj_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tramvaj_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tramvaj_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'tramvaj_db', N'ON'
GO
ALTER DATABASE [tramvaj_db] SET QUERY_STORE = OFF
GO
USE [tramvaj_db]
GO
/****** Object:  Table [dbo].[Karta]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Karta](
	[id_karta] [int] IDENTITY(1,1) NOT NULL,
	[trenutak_aktivacije] [datetime2](0) NULL,
	[valjanost] [int] NULL,
	[datum_kupnje] [datetime2](0) NULL,
	[id_vrsta_karte] [int] NOT NULL,
	[id_mjesto] [int] NOT NULL,
	[id_korisnik] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_karta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[id_korisnik] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](45) NULL,
	[prezime] [varchar](45) NULL,
	[korisnicko_ime] [varchar](45) NULL,
	[datum_rodenja] [date] NULL,
	[adresa] [varchar](45) NULL,
	[email] [varchar](45) NULL,
	[broj_mobitela] [int] NULL,
	[uvjeti_koristenja] [int] NULL,
	[uloga_id_uloga] [int] NULL,
 CONSTRAINT [PK__korisnik__C570D8FBAE68A6A2] PRIMARY KEY CLUSTERED 
(
	[id_korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Linija]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Linija](
	[id_linija] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_linija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mjesto]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mjesto](
	[id_mjesto] [int] NOT NULL,
	[naziv] [varchar](45) NULL,
	[postanski_broj] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mjesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stanica]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stanica](
	[id_stanica] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_stanica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tramvaj]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tramvaj](
	[id_tramvaj] [int] IDENTITY(1,1) NOT NULL,
	[broj_vagona] [varchar](45) NULL,
	[broj_sjedala] [varchar](45) NULL,
	[kapacitet_ljudi] [varchar](45) NULL,
	[godina_proizvodnje] [varchar](45) NULL,
	[id_vozac] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tramvaj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uloga]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uloga](
	[id_uloga] [int] NOT NULL,
	[naziv] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_uloga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vozac]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vozac](
	[id_vozac] [int] IDENTITY(1,1) NOT NULL,
	[ime] [varchar](45) NULL,
	[prezime] [varchar](45) NULL,
	[placa] [varchar](45) NULL,
	[datum_rodenja] [varchar](45) NULL,
	[telefon] [varchar](45) NULL,
	[email] [varchar](45) NULL,
	[adresa] [varchar](45) NULL,
	[id_korisnik] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vozac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vozna_ruta]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vozna_ruta](
	[id_stanica] [int] NOT NULL,
	[id_linija] [int] NOT NULL,
	[vrijeme_dolaska] [time](0) NULL,
	[vrijeme_odlaska] [time](0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_stanica] ASC,
	[id_linija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vozni_red]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vozni_red](
	[id_vozni_red] [int] IDENTITY(1,1) NOT NULL,
	[vrijeme_pocetka] [time](0) NULL,
	[vrijeme_zavrsetka] [time](0) NULL,
	[status] [int] NULL,
	[id_tramvaj] [int] NOT NULL,
	[id_linija] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vozni_red] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vrsta_karte]    Script Date: 31.8.2022. 23:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vrsta_karte](
	[id_vrsta_karte] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [varchar](45) NULL,
	[trajanje_valjanosti] [int] NULL,
	[cijena] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_vrsta_karte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Karta] ON 

INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (1, CAST(N'2022-07-30T20:56:57.0000000' AS DateTime2), 0, CAST(N'2022-07-30T20:16:38.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (2, CAST(N'2022-08-30T22:56:37.0000000' AS DateTime2), 1, CAST(N'2022-08-30T22:56:32.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (3, CAST(N'2022-07-30T23:03:33.0000000' AS DateTime2), 0, CAST(N'2022-07-30T23:03:05.0000000' AS DateTime2), 2, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (20, NULL, 1, CAST(N'2022-08-31T21:55:38.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (21, NULL, 1, CAST(N'2022-08-31T22:40:11.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (22, NULL, 1, CAST(N'2022-08-31T22:41:01.0000000' AS DateTime2), 2, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (23, NULL, 1, CAST(N'2022-08-31T22:41:51.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (24, NULL, 1, CAST(N'2022-08-31T22:56:07.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (25, NULL, 1, CAST(N'2022-08-31T22:56:35.0000000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[Karta] ([id_karta], [trenutak_aktivacije], [valjanost], [datum_kupnje], [id_vrsta_karte], [id_mjesto], [id_korisnik]) VALUES (26, NULL, 1, CAST(N'2022-08-31T23:00:00.0000000' AS DateTime2), 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Karta] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([id_korisnik], [ime], [prezime], [korisnicko_ime], [datum_rodenja], [adresa], [email], [broj_mobitela], [uvjeti_koristenja], [uloga_id_uloga]) VALUES (1, N'Marko', N'Peric', N'mperic', CAST(N'2022-08-30' AS Date), N'Marticeva 13', N'mperic@test.com', 385000000, NULL, 1)
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
INSERT [dbo].[Mjesto] ([id_mjesto], [naziv], [postanski_broj]) VALUES (1, N'Zagreb', N'10000')
GO
INSERT [dbo].[Uloga] ([id_uloga], [naziv]) VALUES (1, N'Administrator')
INSERT [dbo].[Uloga] ([id_uloga], [naziv]) VALUES (2, N'Vozac')
INSERT [dbo].[Uloga] ([id_uloga], [naziv]) VALUES (3, N'Kupac')
GO
SET IDENTITY_INSERT [dbo].[Vrsta_karte] ON 

INSERT [dbo].[Vrsta_karte] ([id_vrsta_karte], [naziv], [trajanje_valjanosti], [cijena]) VALUES (1, N'Polusatna', 30, 4)
INSERT [dbo].[Vrsta_karte] ([id_vrsta_karte], [naziv], [trajanje_valjanosti], [cijena]) VALUES (2, N'Satna', 60, 8)
SET IDENTITY_INSERT [dbo].[Vrsta_karte] OFF
GO
/****** Object:  Index [fk_karta_korisnik1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_karta_korisnik1_idx] ON [dbo].[Karta]
(
	[id_korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_karta_mjesto1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_karta_mjesto1_idx] ON [dbo].[Karta]
(
	[id_mjesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_karta_vrsta_karte1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_karta_vrsta_karte1_idx] ON [dbo].[Karta]
(
	[id_vrsta_karte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_korisnik_uloga1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_korisnik_uloga1_idx] ON [dbo].[Korisnik]
(
	[uloga_id_uloga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_tramvaj_vozac1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_tramvaj_vozac1_idx] ON [dbo].[Tramvaj]
(
	[id_vozac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_vozac_korisnik1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_vozac_korisnik1_idx] ON [dbo].[Vozac]
(
	[id_korisnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_linija_has_stanica_linija_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_linija_has_stanica_linija_idx] ON [dbo].[Vozna_ruta]
(
	[id_stanica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_linija_has_stanica_stanica1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_linija_has_stanica_stanica1_idx] ON [dbo].[Vozna_ruta]
(
	[id_linija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_vozni_red_linija1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_vozni_red_linija1_idx] ON [dbo].[Vozni_red]
(
	[id_linija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_vozni_red_tramvaj1_idx]    Script Date: 31.8.2022. 23:27:48 ******/
CREATE NONCLUSTERED INDEX [fk_vozni_red_tramvaj1_idx] ON [dbo].[Vozni_red]
(
	[id_tramvaj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnik] ADD  CONSTRAINT [DF__korisnik__uvjeti__2A4B4B5E]  DEFAULT ((0)) FOR [uvjeti_koristenja]
GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [fk_karta_korisnik1] FOREIGN KEY([id_korisnik])
REFERENCES [dbo].[Korisnik] ([id_korisnik])
GO
ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [fk_karta_korisnik1]
GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [fk_karta_mjesto1] FOREIGN KEY([id_mjesto])
REFERENCES [dbo].[Mjesto] ([id_mjesto])
GO
ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [fk_karta_mjesto1]
GO
ALTER TABLE [dbo].[Karta]  WITH CHECK ADD  CONSTRAINT [fk_karta_vrsta_karte1] FOREIGN KEY([id_vrsta_karte])
REFERENCES [dbo].[Vrsta_karte] ([id_vrsta_karte])
GO
ALTER TABLE [dbo].[Karta] CHECK CONSTRAINT [fk_karta_vrsta_karte1]
GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [fk_korisnik_uloga1] FOREIGN KEY([uloga_id_uloga])
REFERENCES [dbo].[Uloga] ([id_uloga])
GO
ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [fk_korisnik_uloga1]
GO
ALTER TABLE [dbo].[Tramvaj]  WITH CHECK ADD  CONSTRAINT [fk_tramvaj_vozac1] FOREIGN KEY([id_vozac])
REFERENCES [dbo].[Vozac] ([id_vozac])
GO
ALTER TABLE [dbo].[Tramvaj] CHECK CONSTRAINT [fk_tramvaj_vozac1]
GO
ALTER TABLE [dbo].[Vozac]  WITH CHECK ADD  CONSTRAINT [fk_vozac_korisnik1] FOREIGN KEY([id_korisnik])
REFERENCES [dbo].[Korisnik] ([id_korisnik])
GO
ALTER TABLE [dbo].[Vozac] CHECK CONSTRAINT [fk_vozac_korisnik1]
GO
ALTER TABLE [dbo].[Vozna_ruta]  WITH CHECK ADD  CONSTRAINT [fk_linija_has_stanica_linija] FOREIGN KEY([id_stanica])
REFERENCES [dbo].[Linija] ([id_linija])
GO
ALTER TABLE [dbo].[Vozna_ruta] CHECK CONSTRAINT [fk_linija_has_stanica_linija]
GO
ALTER TABLE [dbo].[Vozna_ruta]  WITH CHECK ADD  CONSTRAINT [fk_linija_has_stanica_stanica1] FOREIGN KEY([id_linija])
REFERENCES [dbo].[Stanica] ([id_stanica])
GO
ALTER TABLE [dbo].[Vozna_ruta] CHECK CONSTRAINT [fk_linija_has_stanica_stanica1]
GO
ALTER TABLE [dbo].[Vozni_red]  WITH CHECK ADD  CONSTRAINT [fk_vozni_red_linija1] FOREIGN KEY([id_linija])
REFERENCES [dbo].[Linija] ([id_linija])
GO
ALTER TABLE [dbo].[Vozni_red] CHECK CONSTRAINT [fk_vozni_red_linija1]
GO
ALTER TABLE [dbo].[Vozni_red]  WITH CHECK ADD  CONSTRAINT [fk_vozni_red_tramvaj1] FOREIGN KEY([id_tramvaj])
REFERENCES [dbo].[Tramvaj] ([id_tramvaj])
GO
ALTER TABLE [dbo].[Vozni_red] CHECK CONSTRAINT [fk_vozni_red_tramvaj1]
GO
USE [master]
GO
ALTER DATABASE [tramvaj_db] SET  READ_WRITE 
GO
