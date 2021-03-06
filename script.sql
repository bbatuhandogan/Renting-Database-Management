USE [master]
GO
/****** Object:  Database [UrunKiralamaSistemiVTYS]    Script Date: 18.01.2022 11:51:21 ******/
CREATE DATABASE [UrunKiralamaSistemiVTYS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UrunKiralamaSistemiVTYS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\UrunKiralamaSistemiVTYS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UrunKiralamaSistemiVTYS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\UrunKiralamaSistemiVTYS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UrunKiralamaSistemiVTYS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ARITHABORT OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET  MULTI_USER 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET QUERY_STORE = OFF
GO
USE [UrunKiralamaSistemiVTYS]
GO
/****** Object:  Table [dbo].[Kiralamalar]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kiralamalar](
	[KiraID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NOT NULL,
	[KiraBaslangic] [date] NOT NULL,
	[KiraBitis] [date] NOT NULL,
	[UrunId] [int] NOT NULL,
	[TakipNo] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KiraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](30) NOT NULL,
	[Soyad] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[TelNo] [varchar](11) NOT NULL,
	[TCKNo] [varchar](11) NOT NULL,
	[AdresID] [int] NOT NULL,
 CONSTRAINT [PK__Musteril__726244710E0B8273] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [varchar](255) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[AylikKiraUcreti] [int] NULL,
 CONSTRAINT [PK__Urun__623D364B2D2332C8] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Yaklasan Kiralar]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Yaklasan Kiralar] as 
SELECT    
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) as KalanGun
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
	, ur.AylikKiraUcreti
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where  DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) > 0 and DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) < 7
GO
/****** Object:  UserDefinedFunction [dbo].[belirliMusteriKiraGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[belirliMusteriKiraGoster](@gelenid smallint)
returns table
AS
return (
SELECT    
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
	, ur.AylikKiraUcreti
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where mus.MusteriID = @gelenid
)
GO
/****** Object:  UserDefinedFunction [dbo].[belirliMusteriAylikBorc]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[belirliMusteriAylikBorc] (@gelenid smallint)
returns table
AS
return (
SELECT    
	mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, sum(ur.AylikKiraUcreti) as Toplam
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where mus.MusteriID = @gelenid
group by mus.MusteriID, mus.Ad, mus.Soyad
)
GO
/****** Object:  UserDefinedFunction [dbo].[takipNoIleKiraSorgula]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[takipNoIleKiraSorgula](@takipNo int)
returns table
AS
return(
Select
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where kira.TakipNo = @takipNo
)
GO
/****** Object:  Table [dbo].[Adres]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adres](
	[AdresID] [int] IDENTITY(1,1) NOT NULL,
	[BinaNo] [varchar](25) NOT NULL,
	[Sokak] [varchar](20) NOT NULL,
	[Mahalle] [varchar](25) NULL,
	[IlID] [int] NOT NULL,
	[IlceID] [int] NOT NULL,
	[UlkeID] [int] NOT NULL,
 CONSTRAINT [PK__Adres__DA8DEA6C37DD23D4] PRIMARY KEY CLUSTERED 
(
	[AdresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Il]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Il](
	[IlID] [int] IDENTITY(1,1) NOT NULL,
	[IlAdi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IlID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilce]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilce](
	[IlceID] [int] IDENTITY(1,1) NOT NULL,
	[IlceAdi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IlceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[KategoriId] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ulke]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ulke](
	[UlkeKodu] [int] IDENTITY(1,1) NOT NULL,
	[UlkeAdi] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UlkeKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adres]  WITH CHECK ADD  CONSTRAINT [FK_AdresIl] FOREIGN KEY([IlID])
REFERENCES [dbo].[Il] ([IlID])
GO
ALTER TABLE [dbo].[Adres] CHECK CONSTRAINT [FK_AdresIl]
GO
ALTER TABLE [dbo].[Adres]  WITH CHECK ADD  CONSTRAINT [FK_AdresIlce] FOREIGN KEY([IlceID])
REFERENCES [dbo].[Ilce] ([IlceID])
GO
ALTER TABLE [dbo].[Adres] CHECK CONSTRAINT [FK_AdresIlce]
GO
ALTER TABLE [dbo].[Adres]  WITH CHECK ADD  CONSTRAINT [FK_AdresUlke] FOREIGN KEY([UlkeID])
REFERENCES [dbo].[Ulke] ([UlkeKodu])
GO
ALTER TABLE [dbo].[Adres] CHECK CONSTRAINT [FK_AdresUlke]
GO
ALTER TABLE [dbo].[Kiralamalar]  WITH CHECK ADD  CONSTRAINT [FK__Kiralamal__Muste__398D8EEE] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteriler] ([MusteriID])
GO
ALTER TABLE [dbo].[Kiralamalar] CHECK CONSTRAINT [FK__Kiralamal__Muste__398D8EEE]
GO
ALTER TABLE [dbo].[Kiralamalar]  WITH CHECK ADD  CONSTRAINT [FK__Kiralamal__UrunI__3B75D760] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[Kiralamalar] CHECK CONSTRAINT [FK__Kiralamal__UrunI__3B75D760]
GO
ALTER TABLE [dbo].[Musteriler]  WITH CHECK ADD  CONSTRAINT [FK__Musterile__Adres__5165187F] FOREIGN KEY([AdresID])
REFERENCES [dbo].[Adres] ([AdresID])
GO
ALTER TABLE [dbo].[Musteriler] CHECK CONSTRAINT [FK__Musterile__Adres__5165187F]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK__Urun__KategoriId__36B12243] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoriler] ([KategoriId])
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK__Urun__KategoriId__36B12243]
GO
/****** Object:  StoredProcedure [dbo].[aylikBorcGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aylikBorcGoster]
AS
SELECT    
	mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, sum(ur.AylikKiraUcreti) as Toplam
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
group by mus.MusteriID, mus.Ad, mus.Soyad
GO
/****** Object:  StoredProcedure [dbo].[borcluDurumu]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[borcluDurumu]
as
begin
SELECT    
	mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, sum(ur.AylikKiraUcreti) as Toplam,
CASE
    WHEN sum(ur.AylikKiraUcreti) >= 10000 THEN 'Yüksek Borçlu'
    WHEN sum(ur.AylikKiraUcreti) between 4000 and 10000 THEN 'Normal Borçlu'
    ELSE 'Az Borçlu'
END AS toplamtext
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
group by mus.MusteriID, mus.Ad, mus.Soyad;
end
GO
/****** Object:  StoredProcedure [dbo].[kiralamalariGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[kiralamalariGoster]
AS
SELECT    
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
	, ur.AylikKiraUcreti
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
GO
/****** Object:  StoredProcedure [dbo].[musteriAyrintiGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[musteriAyrintiGoster]
AS
SELECT     
	mus.Ad
    , mus.Soyad
    , mus.TelNo
    , mus.TCKNo
    , adr.BinaNo
    , adr.Sokak
	, ı2.IlceAdi
    , ı1.IlAdi
	, ulk.UlkeAdi
FROM  Musteriler AS mus 
INNER JOIN Adres as adr 
    ON mus.AdresID = adr.AdresID
INNER JOIN Il AS ı1 
    ON adr.IlID = ı1.IlID
INNER JOIN Ilce AS ı2
    ON adr.IlceID = ı2.IlceID
INNER JOIN Ulke AS ulk
    ON adr.UlkeID = ulk.UlkeKodu
GO
/****** Object:  StoredProcedure [dbo].[musteriGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[musteriGoster]
AS
SELECT 
	mus.Ad,
	mus.Soyad,
	mus.Email,
	mus.TelNo,
	mus.TCKNo
FROM Musteriler mus
GO
/****** Object:  StoredProcedure [dbo].[MusteriStatus]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MusteriStatus]
as
begin
DECLARE @kiralamasayisi INTEGER, @musteriId INTEGER
SET @kiralamasayisi = 3
SET @musteriId = 5
IF @kiralamasayisi <= (SELECT count(kira.MusteriID) FROM Kiralamalar as kira
    WHERE kira.MusteriID =  @musteriId
    group by kira.MusteriID
    )
    SELECT @musteriId AS MusteriId, count(kira.UrunId) as KiralamaSayisi, 'Düzenli müşteri.' 
        AS MusteriStatus
        FROM  Kiralamalar AS kira
    WHERE kira.MusteriID = @musteriId
    group by kira.MusteriID
ELSE 
    SELECT @musteriId AS MusteriId, count(kira.UrunID) as KiralamaSayisi, 'Sıradan müşteri.' 
        AS MusteriStatus
        FROM  Kiralamalar AS kira
    WHERE kira.MusteriID = @musteriId
    group by kira.MusteriID
end
GO
/****** Object:  StoredProcedure [dbo].[suresiDolacakKiralamalar]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[suresiDolacakKiralamalar]
as 
SELECT    
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, DATEDIFF(day, GETDATE(), kira.KiraBitis) as KalanGun
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
	, ur.AylikKiraUcreti
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where DATEDIFF(day, GETDATE(), kira.KiraBitis) < 7 
order by KalanGun
GO
/****** Object:  StoredProcedure [dbo].[urunGoster]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[urunGoster]
AS
SELECT    
	ur.UrunID
	, ur.UrunAdi
	, kat.KategoriAdi
    , ur.AylikKiraUcreti
FROM  Urun AS ur 
INNER JOIN Kategoriler as kat 
    ON ur.KategoriId = kat.KategoriId
GO
/****** Object:  StoredProcedure [dbo].[yaklasanKiralar]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[yaklasanKiralar]
AS
SELECT    
	kira.KiraID
	, mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) as KalanGun
    , kira.KiraBaslangic
    , kira.KiraBitis
	, ur.UrunAdi
	, ur.AylikKiraUcreti
    , kira.TakipNo
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
where  DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) > 0 and DATEDIFF(day, DATEPART(dd, GETDATE()), DATEPART(dd, kira.KiraBitis)) < 7
order by KalanGun
GO
/****** Object:  StoredProcedure [dbo].[yuksekBorclular]    Script Date: 18.01.2022 11:51:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[yuksekBorclular]
AS
SELECT    
	mus.MusteriID
	, mus.Ad
    , mus.Soyad
	, sum(ur.AylikKiraUcreti) as Toplam
FROM  Kiralamalar AS kira 
INNER JOIN Musteriler as mus 
    ON kira.MusteriID = mus.MusteriID
INNER JOIN Urun AS ur 
    ON kira.UrunId = ur.UrunID
group by mus.MusteriID, mus.Ad, mus.Soyad
having sum(ur.AylikKiraUcreti) >= 10000
GO
USE [master]
GO
ALTER DATABASE [UrunKiralamaSistemiVTYS] SET  READ_WRITE 
GO
