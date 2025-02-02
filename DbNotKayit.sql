USE [DbNotKayit]
GO
/****** Object:  Table [dbo].[TblDevamsizlik]    Script Date: 5.06.2023 00:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDevamsizlik](
	[OgrID] [smallint] IDENTITY(1,1) NOT NULL,
	[OgrNo] [char](4) NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](15) NULL,
	[OgrDevamsizlik] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDuyuru]    Script Date: 5.06.2023 00:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDuyuru](
	[DuyuruID] [smallint] IDENTITY(1,1) NOT NULL,
	[Duyuru] [varchar](300) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblIstek]    Script Date: 5.06.2023 00:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblIstek](
	[OgrAd] [varchar](15) NULL,
	[OgrSoyad] [varchar](15) NULL,
	[OgrMesaj] [varchar](300) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNotKayit]    Script Date: 5.06.2023 00:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNotKayit](
	[OgrID] [int] IDENTITY(1,1) NOT NULL,
	[OgrNo] [char](4) NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](15) NULL,
	[OgrSinav1] [tinyint] NULL,
	[OgrSinav2] [tinyint] NULL,
	[OgrProje] [tinyint] NULL,
	[OgrOrt] [decimal](18, 2) NULL,
	[OgrDurum] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblOgretmenGiris]    Script Date: 5.06.2023 00:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOgretmenGiris](
	[OgretmenTC] [char](11) NULL,
	[OgretmenSifre] [char](4) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblDevamsizlik] ON 

INSERT [dbo].[TblDevamsizlik] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrDevamsizlik]) VALUES (1, N'1453', N'Musa Bilal', N'Yaz', 4)
INSERT [dbo].[TblDevamsizlik] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrDevamsizlik]) VALUES (2, N'1299', N'Burakcan', N'Satık', 3)
INSERT [dbo].[TblDevamsizlik] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrDevamsizlik]) VALUES (20, N'1881', N'Mustafa', N'Kemal', 5)
INSERT [dbo].[TblDevamsizlik] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrDevamsizlik]) VALUES (17, N'4235', N'Ahmet', N'Şimşek', 4)
INSERT [dbo].[TblDevamsizlik] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrDevamsizlik]) VALUES (24, N'1789', N'Kerem', N'Korkmaz', 3)
SET IDENTITY_INSERT [dbo].[TblDevamsizlik] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDuyuru] ON 

INSERT [dbo].[TblDuyuru] ([DuyuruID], [Duyuru]) VALUES (28, N'Merhaba çocuklar, yarın okul tatil.')
INSERT [dbo].[TblDuyuru] ([DuyuruID], [Duyuru]) VALUES (21, N'Merhaba gençler, bugünkü dersimizi hastalığım sebebiyle maalesef yapamayacağız. Telafi dersin tarih ve saatini sizlere yine buradan duyuracağım. Görüşmek üzere.')
INSERT [dbo].[TblDuyuru] ([DuyuruID], [Duyuru]) VALUES (34, N'Bu duyuru video için gönderilmiştir.')
INSERT [dbo].[TblDuyuru] ([DuyuruID], [Duyuru]) VALUES (23, N'Merhaba çocuklar, sınavınız guzem üzerinden yapılacak olup kamera kontrolü Zoom üzerinden yapılacaktır. Lütfen sınava girmeden önce kameranızın sizi ve ekranınızı çektiğinden emin olun. Başarılar.')
INSERT [dbo].[TblDuyuru] ([DuyuruID], [Duyuru]) VALUES (26, N'Merhaba öğrenciler, bugün ders yok.')
SET IDENTITY_INSERT [dbo].[TblDuyuru] OFF
GO
INSERT [dbo].[TblIstek] ([OgrAd], [OgrSoyad], [OgrMesaj]) VALUES (N'Burakcan', N'Satık', N'Hocam kusura bakmayın bilgisayarımda bir problem çıktı videoyu çekemedim, arkadaşım yapmak zorunda kaldı.')
INSERT [dbo].[TblIstek] ([OgrAd], [OgrSoyad], [OgrMesaj]) VALUES (N'Musa Bilal', N'Yaz', N'Merhaba hocam ben 1453 numaralı Musa Bilal Yaz. Proje notumun biraz düşük olduğunu düşünüyorum acaba tekrar kontrol etmeniz mümkün mü?')
GO
SET IDENTITY_INSERT [dbo].[TblNotKayit] ON 

INSERT [dbo].[TblNotKayit] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrSinav1], [OgrSinav2], [OgrProje], [OgrOrt], [OgrDurum]) VALUES (1, N'1453', N'Musa Bilal', N'Yaz', 95, 64, 85, CAST(80.60 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblNotKayit] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrSinav1], [OgrSinav2], [OgrProje], [OgrOrt], [OgrDurum]) VALUES (2, N'1299', N'Burakcan', N'Satık', 98, 60, 86, CAST(80.40 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblNotKayit] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrSinav1], [OgrSinav2], [OgrProje], [OgrOrt], [OgrDurum]) VALUES (25, N'1881', N'Mustafa', N'Kemal', 34, 54, 12, CAST(37.60 AS Decimal(18, 2)), 0)
INSERT [dbo].[TblNotKayit] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrSinav1], [OgrSinav2], [OgrProje], [OgrOrt], [OgrDurum]) VALUES (22, N'4235', N'Ahmet', N'Şimşek', 45, 52, 44, CAST(47.60 AS Decimal(18, 2)), 0)
INSERT [dbo].[TblNotKayit] ([OgrID], [OgrNo], [OgrAd], [OgrSoyad], [OgrSinav1], [OgrSinav2], [OgrProje], [OgrOrt], [OgrDurum]) VALUES (29, N'1789', N'Kerem', N'Korkmaz', 52, 63, 75, CAST(61.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[TblNotKayit] OFF
GO
INSERT [dbo].[TblOgretmenGiris] ([OgretmenTC], [OgretmenSifre]) VALUES (N'11111111111', N'1111')
INSERT [dbo].[TblOgretmenGiris] ([OgretmenTC], [OgretmenSifre]) VALUES (N'22222222222', N'2222')
INSERT [dbo].[TblOgretmenGiris] ([OgretmenTC], [OgretmenSifre]) VALUES (N'33333333333', N'3333')
INSERT [dbo].[TblOgretmenGiris] ([OgretmenTC], [OgretmenSifre]) VALUES (N'44444444444', N'4444')
GO
