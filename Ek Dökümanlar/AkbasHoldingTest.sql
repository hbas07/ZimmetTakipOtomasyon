USE [master]
GO
/****** Object:  Database [AkbasHoldingTest]    Script Date: 17.12.2018 23:41:08 ******/
CREATE DATABASE [AkbasHoldingTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AkbasHolding', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AkbasHoldingTest.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AkbasHolding_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\AkbasHoldingTest_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AkbasHoldingTest] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AkbasHoldingTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AkbasHoldingTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AkbasHoldingTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AkbasHoldingTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AkbasHoldingTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AkbasHoldingTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AkbasHoldingTest] SET  MULTI_USER 
GO
ALTER DATABASE [AkbasHoldingTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AkbasHoldingTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AkbasHoldingTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AkbasHoldingTest] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AkbasHoldingTest] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AkbasHoldingTest]
GO
/****** Object:  Table [dbo].[tblAtikKontrol]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAtikKontrol](
	[ZimmetID] [int] NOT NULL,
	[ZimmetAktifligi] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDepartman]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDepartman](
	[DepartmanID] [int] NOT NULL,
	[DepartmanAdı] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblDepartman] PRIMARY KEY CLUSTERED 
(
	[DepartmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFirma]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFirma](
	[FirmaID] [int] NOT NULL,
	[Firma] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tblFirma] PRIMARY KEY CLUSTERED 
(
	[FirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[KullaniciAdi] [varchar](20) NOT NULL,
	[Sifre] [int] NOT NULL,
	[Yetki] [int] NOT NULL,
	[DepartmanID] [int] NOT NULL,
 CONSTRAINT [PK_tblKullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPersonel](
	[PersonelID] [int] NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](30) NOT NULL,
	[DepartmanID] [int] NOT NULL,
 CONSTRAINT [PK_tblPersonel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSatinAlma]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSatinAlma](
	[UrunID] [int] NOT NULL,
	[FirmaAdi] [varchar](30) NOT NULL,
	[Urun] [varchar](30) NOT NULL,
	[SatinAlmaTarihi] [date] NOT NULL,
	[Adet] [int] NOT NULL,
	[Fiyat] [float] NOT NULL,
	[FirmaID] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblStok]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStok](
	[UrunID] [int] NOT NULL,
	[Urun] [varchar](30) NOT NULL,
	[AktiflikDurumu] [bit] NOT NULL,
	[FirmaID] [int] NOT NULL,
	[Adet] [int] NOT NULL,
 CONSTRAINT [PK_tblStok] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC,
	[FirmaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYetki]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYetki](
	[YetkiID] [int] NOT NULL,
	[Yetki] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblYetki] PRIMARY KEY CLUSTERED 
(
	[YetkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblZimmet]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblZimmet](
	[PersonelID] [int] NOT NULL,
	[UrunID] [int] NOT NULL,
	[DepartmanID] [int] NOT NULL,
	[ZimmetID] [int] IDENTITY(1,1) NOT NULL,
	[FirmaID] [int] NOT NULL,
	[ZimmetAktifligi] [bit] NOT NULL,
 CONSTRAINT [PK_tblZimmet] PRIMARY KEY CLUSTERED 
(
	[ZimmetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vw_PersonelBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_PersonelBilgi]
AS
SELECT p.PersonelID,p.Ad,p.Soyad,d.DepartmanAdı,d.DepartmanID
FROM tblPersonel p INNER JOIN tblDepartman d ON p.DepartmanID=d.DepartmanID
GO
/****** Object:  View [dbo].[vw_RaporIslem]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_RaporIslem] 
AS
SELECT z.ZimmetID,s.Urun AS 'ZimmetliUrun',f.Firma,p.PersonelID,p.Ad,p.Soyad,d.DepartmanID,d.DepartmanAdı,z.ZimmetAktifligi
FROM tblZimmet z INNER JOIN tblDepartman d ON z.DepartmanID=d.DepartmanID
				 INNER JOIN tblPersonel p ON z.PersonelID=p.PersonelID
				 INNER JOIN tblStok s ON s.FirmaID=z.FirmaID AND s.UrunID=z.FirmaID
				 INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID
GO
/****** Object:  View [dbo].[vw_ZimmetBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_ZimmetBilgi] 
AS
SELECT z.ZimmetID,s.Urun AS 'ZimmetliUrun',f.Firma,p.PersonelID,p.Ad,p.Soyad,d.DepartmanAdı,z.ZimmetAktifligi
FROM tblZimmet z INNER JOIN tblDepartman d ON z.DepartmanID=d.DepartmanID
				 INNER JOIN tblPersonel p ON z.PersonelID=p.PersonelID
				 INNER JOIN tblStok s ON s.FirmaID=z.FirmaID AND s.UrunID=z.FirmaID
				 INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID
GO
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (19, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (40, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (39, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (4, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (3, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (20, 0)
INSERT [dbo].[tblAtikKontrol] ([ZimmetID], [ZimmetAktifligi]) VALUES (25, 0)
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (1, N'İnsan Kaynakları')
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (2, N'Bilgi İşlem')
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (3, N'Satın Alma')
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (4, N'Muhasebe')
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (5, N'Planlama')
INSERT [dbo].[tblDepartman] ([DepartmanID], [DepartmanAdı]) VALUES (6, N'Ar-Ge')
INSERT [dbo].[tblFirma] ([FirmaID], [Firma]) VALUES (1, N'ASUS')
INSERT [dbo].[tblFirma] ([FirmaID], [Firma]) VALUES (2, N'TOSHIBA')
INSERT [dbo].[tblFirma] ([FirmaID], [Firma]) VALUES (3, N'MSI')
INSERT [dbo].[tblFirma] ([FirmaID], [Firma]) VALUES (4, N'DELL')
INSERT [dbo].[tblFirma] ([FirmaID], [Firma]) VALUES (5, N'LENOVO')
INSERT [dbo].[tblKullanici] ([KullaniciAdi], [Sifre], [Yetki], [DepartmanID]) VALUES (N'admin', 1234, 0, 1)
INSERT [dbo].[tblKullanici] ([KullaniciAdi], [Sifre], [Yetki], [DepartmanID]) VALUES (N'argeyetkili', 1234, 2, 6)
INSERT [dbo].[tblKullanici] ([KullaniciAdi], [Sifre], [Yetki], [DepartmanID]) VALUES (N'ikyetkili', 1234, 2, 1)
INSERT [dbo].[tblKullanici] ([KullaniciAdi], [Sifre], [Yetki], [DepartmanID]) VALUES (N'satinalma', 2222, 1, 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (1, N'Fatih', N'Erbaş', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (2, N'Hüseyin', N'Ertürk', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (3, N'Betül', N'Yılmaz', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (4, N'Cem', N'Ala', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (5, N'Metin', N'Palazoğlu', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (6, N'Aydın', N'Koçak', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (7, N'Filiz', N'Yavuz', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (8, N'Halime', N'Bulut', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (9, N'Melek', N'Yosun', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (10, N'Hasan', N'Baş', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (11, N'Selçuk', N'Özben', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (12, N'Hakan', N'Baş', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (13, N'Anıl', N'Sezer', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (14, N'Engin Can', N'Çalışkan', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (15, N'Taha', N'Soydan', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (16, N'Berkan', N'Şaşmaz', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (17, N'Ahmet', N'Çalışkan', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (18, N'Yılmaz', N'Yavuz', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (19, N'Saliha', N'Gülsen', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (20, N'Açelya', N'Kozan', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (21, N'Aykan', N'Aykaç', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (22, N'Bahattin', N'Tokmak', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (23, N'Afra', N'Güneysu', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (24, N'Hüsnü', N'Çoban', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (25, N'Arda', N'Şahin', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (26, N'Almila', N'Parlar', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (27, N'Berfin', N'Aygündüz', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (28, N'Onur', N'Özcan', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (29, N'Orbay', N'Güler', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (30, N'Oğuzhan', N'Güler', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (31, N'Hakan', N'Yılmaz', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (32, N'Şevval', N'Barut', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (33, N'Feyza', N'Topçu', 4)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (34, N'Meral', N'Taşdemir', 3)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (35, N'Kübra', N'Kahyalar', 6)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (36, N'Bahar', N'Yılmaz', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (37, N'Zişan', N'Karsatar', 2)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (38, N'Buluthan', N'Yazıcı', 5)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (39, N'Begüm', N'Bal', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [Ad], [Soyad], [DepartmanID]) VALUES (40, N'Gökhan', N'Yavuz', 3)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 1, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-09-11' AS Date), 5, 7, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-09-11' AS Date), 5, 7, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 0, 0, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 4, 5, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (2, N'TOSHIBA', N'KLAVYE', CAST(N'2018-10-12' AS Date), 5, 9, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (4, N'LENOVO', N'MOUSE', CAST(N'2018-10-12' AS Date), 21, 15, 5)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (4, N'LENOVO', N'MOUSE', CAST(N'2019-10-12' AS Date), 21, 15, 5)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'TOSHIBA', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 1, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'MSI', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 1, 3)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'DELL', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 1, 4)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'LENOVO', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 1, 5)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 0, 0, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 5, 0, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (4, N'TOSHIBA', N'MOUSE', CAST(N'2018-10-12' AS Date), 7, 4, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (2, N'TOSHIBA', N'KLAVYE', CAST(N'2018-10-12' AS Date), 2, 3, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-10-12' AS Date), 1, 2, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'TOSHIBA', N'BİLGİSAYAR', CAST(N'2018-11-12' AS Date), 1, 2, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'TOSHIBA', N'BİLGİSAYAR', CAST(N'2018-12-12' AS Date), 1, 2, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'TOSHIBA', N'BİLGİSAYAR', CAST(N'2018-04-12' AS Date), 2, 4, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-12-12' AS Date), 2, 5, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (1, N'ASUS', N'BİLGİSAYAR', CAST(N'2018-11-12' AS Date), 3, 5, 1)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (2, N'TOSHIBA', N'KLAVYE', CAST(N'2018-11-12' AS Date), 4, 5, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (5, N'TOSHIBA', N'DDR RAM', CAST(N'2018-12-12' AS Date), 4, 4, 2)
INSERT [dbo].[tblSatinAlma] ([UrunID], [FirmaAdi], [Urun], [SatinAlmaTarihi], [Adet], [Fiyat], [FirmaID]) VALUES (3, N'TOSHIBA', N'KULAKLIK', CAST(N'2018-05-12' AS Date), 12, 23, 2)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (1, N'Bilgisayar', 1, 1, 3)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (1, N'Bilgisayar', 1, 2, 1)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (1, N'Bilgisayar', 1, 3, 3)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (1, N'Bilgisayar', 0, 4, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (1, N'Bilgisayar', 0, 5, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (2, N'Mouse', 1, 1, 9)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (2, N'Mouse', 1, 2, 17)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (2, N'Mouse', 1, 3, 3)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (2, N'Mouse', 1, 4, 8)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (2, N'Mouse', 0, 5, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (3, N'Klavye', 1, 1, 5)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (3, N'Klavye', 1, 2, 11)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (3, N'Klavye', 0, 3, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (3, N'Klavye', 1, 4, 8)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (3, N'Klavye', 1, 5, 9)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (4, N'Kulaklık', 1, 1, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (4, N'Kulaklık', 1, 2, 2)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (4, N'Kulaklık', 0, 3, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (4, N'Kulaklık', 1, 4, 5)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (4, N'Kulaklık', 0, 5, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (5, N'DDR RAM', 1, 1, 4)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (5, N'DDR RAM', 1, 2, 7)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (5, N'DDR RAM', 0, 3, 0)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (5, N'DDR RAM', 1, 4, 5)
INSERT [dbo].[tblStok] ([UrunID], [Urun], [AktiflikDurumu], [FirmaID], [Adet]) VALUES (5, N'DDR RAM', 1, 5, 6)
INSERT [dbo].[tblYetki] ([YetkiID], [Yetki]) VALUES (0, N'Admin')
INSERT [dbo].[tblYetki] ([YetkiID], [Yetki]) VALUES (1, N'Satış Sorumlusu')
INSERT [dbo].[tblYetki] ([YetkiID], [Yetki]) VALUES (2, N'Bölüm Başkanı')
SET IDENTITY_INSERT [dbo].[tblZimmet] ON 

INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (29, 1, 6, 3, 2, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (29, 2, 6, 4, 5, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (10, 1, 3, 19, 3, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (11, 2, 3, 20, 1, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (11, 1, 3, 21, 2, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (10, 4, 3, 22, 1, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (4, 4, 6, 24, 2, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (4, 1, 6, 25, 1, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (6, 1, 5, 26, 1, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (8, 1, 1, 27, 1, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (15, 1, 2, 28, 3, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 1, 2, 33, 1, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 1, 2, 34, 1, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 1, 2, 35, 2, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 1, 2, 36, 3, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (2, 1, 2, 37, 2, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (3, 1, 4, 38, 2, 1)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 1, 2, 39, 2, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 3, 2, 40, 2, 0)
INSERT [dbo].[tblZimmet] ([PersonelID], [UrunID], [DepartmanID], [ZimmetID], [FirmaID], [ZimmetAktifligi]) VALUES (1, 2, 2, 41, 2, 1)
SET IDENTITY_INSERT [dbo].[tblZimmet] OFF
/****** Object:  Index [IX_tblAtikKontrol]    Script Date: 17.12.2018 23:41:08 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tblAtikKontrol] ON [dbo].[tblAtikKontrol]
(
	[ZimmetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAtikKontrol]  WITH CHECK ADD  CONSTRAINT [FK_tblAtikKontrol_tblZimmet] FOREIGN KEY([ZimmetID])
REFERENCES [dbo].[tblZimmet] ([ZimmetID])
GO
ALTER TABLE [dbo].[tblAtikKontrol] CHECK CONSTRAINT [FK_tblAtikKontrol_tblZimmet]
GO
ALTER TABLE [dbo].[tblKullanici]  WITH CHECK ADD  CONSTRAINT [FK_tblKullanici_tblDepartman] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[tblDepartman] ([DepartmanID])
GO
ALTER TABLE [dbo].[tblKullanici] CHECK CONSTRAINT [FK_tblKullanici_tblDepartman]
GO
ALTER TABLE [dbo].[tblKullanici]  WITH CHECK ADD  CONSTRAINT [FK_tblKullanici_tblYetki] FOREIGN KEY([Yetki])
REFERENCES [dbo].[tblYetki] ([YetkiID])
GO
ALTER TABLE [dbo].[tblKullanici] CHECK CONSTRAINT [FK_tblKullanici_tblYetki]
GO
ALTER TABLE [dbo].[tblPersonel]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonel_tblDepartman] FOREIGN KEY([DepartmanID])
REFERENCES [dbo].[tblDepartman] ([DepartmanID])
GO
ALTER TABLE [dbo].[tblPersonel] CHECK CONSTRAINT [FK_tblPersonel_tblDepartman]
GO
ALTER TABLE [dbo].[tblSatinAlma]  WITH CHECK ADD  CONSTRAINT [FK_tblSatinAlma_tblStok] FOREIGN KEY([UrunID], [FirmaID])
REFERENCES [dbo].[tblStok] ([UrunID], [FirmaID])
GO
ALTER TABLE [dbo].[tblSatinAlma] CHECK CONSTRAINT [FK_tblSatinAlma_tblStok]
GO
ALTER TABLE [dbo].[tblStok]  WITH CHECK ADD  CONSTRAINT [FK_tblStok_tblFirma1] FOREIGN KEY([FirmaID])
REFERENCES [dbo].[tblFirma] ([FirmaID])
GO
ALTER TABLE [dbo].[tblStok] CHECK CONSTRAINT [FK_tblStok_tblFirma1]
GO
ALTER TABLE [dbo].[tblZimmet]  WITH CHECK ADD  CONSTRAINT [FK_tblZimmet_tblPersonel] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[tblPersonel] ([PersonelID])
GO
ALTER TABLE [dbo].[tblZimmet] CHECK CONSTRAINT [FK_tblZimmet_tblPersonel]
GO
ALTER TABLE [dbo].[tblZimmet]  WITH CHECK ADD  CONSTRAINT [FK_tblZimmet_tblStok] FOREIGN KEY([UrunID], [FirmaID])
REFERENCES [dbo].[tblStok] ([UrunID], [FirmaID])
GO
ALTER TABLE [dbo].[tblZimmet] CHECK CONSTRAINT [FK_tblZimmet_tblStok]
GO
/****** Object:  StoredProcedure [dbo].[sp_AtikKontrolBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_AtikKontrolBilgi]
AS
SELECT  a.ZimmetID,s.Urun AS 'Zimmetli Ürün',f.Firma,p.Ad,p.Soyad,d.DepartmanAdı,z.ZimmetAktifligi
FROM tblAtikKontrol a INNER JOIN tblZimmet z ON a.ZimmetID=z.ZimmetID
					  INNER JOIN tblDepartman d ON z.DepartmanID=d.DepartmanID
				      INNER JOIN tblPersonel p ON z.PersonelID=p.PersonelID
				      INNER JOIN tblStok s ON s.FirmaID=z.FirmaID AND s.UrunID=z.FirmaID
				      INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID
GO
/****** Object:  StoredProcedure [dbo].[sp_PersonelZimmetBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_PersonelZimmetBilgi] (@p1 int)
AS
SELECT p.PersonelID,p.Ad,p.Soyad,z.ZimmetID,s.Urun AS 'Zimmetli Ürün',f.Firma,d.DepartmanAdı,z.ZimmetAktifligi
FROM tblZimmet z INNER JOIN tblDepartman d ON z.DepartmanID=d.DepartmanID
				 INNER JOIN tblPersonel p ON z.PersonelID=p.PersonelID
				 INNER JOIN tblStok s ON s.FirmaID=z.FirmaID AND s.UrunID=z.FirmaID
				 INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID 
WHERE p.PersonelID=@p1
GO
/****** Object:  StoredProcedure [dbo].[sp_StokBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_StokBilgi]
AS
SELECT s.UrunID,s.Urun,f.Firma,s.Adet,s.AktiflikDurumu,f.FirmaID
FROM tblStok s INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID
GO
/****** Object:  StoredProcedure [dbo].[sp_ZimmetBilgi]    Script Date: 17.12.2018 23:41:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ZimmetBilgi]
AS
SELECT z.ZimmetID,s.Urun AS 'Zimmetli Ürün',f.Firma,p.Ad,p.Soyad,d.DepartmanAdı,z.ZimmetAktifligi
FROM tblZimmet z INNER JOIN tblDepartman d ON z.DepartmanID=d.DepartmanID
				 INNER JOIN tblPersonel p ON z.PersonelID=p.PersonelID
				 INNER JOIN tblStok s ON s.FirmaID=z.FirmaID AND s.UrunID=z.FirmaID
				 INNER JOIN tblFirma f ON s.FirmaID=f.FirmaID
GO
USE [master]
GO
ALTER DATABASE [AkbasHoldingTest] SET  READ_WRITE 
GO
