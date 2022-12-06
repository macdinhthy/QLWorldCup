USE [WolrdCup]
GO
/****** Object:  Table [dbo].[BXH]    Script Date: 12/6/2022 9:37:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BXH](
	[Vong_dau] [nchar](10) NULL,
	[STT] [nchar](10) NULL,
	[Ma_doi] [nchar](10) NULL,
	[Sotranchoi] [nchar](10) NULL,
	[banthang] [nchar](10) NULL,
	[banthua] [nchar](10) NULL,
	[Hieuso] [nchar](10) NULL,
	[Thevang] [nchar](10) NULL,
	[Thedo] [nchar](10) NULL,
	[tongdiem] [nchar](10) NULL,
	[ghichu] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cau_thu]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cau_thu](
	[Ma_cauthu] [nchar](10) NULL,
	[Ten_cauthu] [nchar](10) NULL,
	[Ngay_sinh] [nchar](10) NULL,
	[Quoc tich] [nchar](10) NULL,
	[So_ao] [nchar](10) NULL,
	[Vi_tri] [nchar](10) NULL,
	[Doi_bong] [nchar](10) NULL,
	[HLV] [nchar](10) NULL,
	[Ma_doi] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doi_bong]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doi_bong](
	[Ma_doi] [nchar](10) NULL,
	[Ten_doi] [nchar](10) NULL,
	[HLV] [nchar](10) NULL,
	[So_cauthu] [nchar](10) NULL,
	[Doi_truong] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HLV]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HLV](
	[Ma_HLV] [nchar](10) NULL,
	[Ten_HLV] [nchar](10) NULL,
	[Ngay_sinh] [nchar](10) NULL,
	[Quoc_tich] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San_bong]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San_bong](
	[Ma_sanbong] [nchar](10) NULL,
	[Ten_Sanbong] [nchar](10) NULL,
	[So_ghe] [nchar](10) NULL,
	[Thanh_pho] [nchar](10) NULL,
	[DKVC] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thi_dau]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thi_dau](
	[Ma_doi1] [nchar](10) NULL,
	[Ma_doi2] [nchar](10) NULL,
	[Ma_trandau] [nchar](10) NULL,
	[Ma_sanbong] [nchar](10) NULL,
	[Ma_vongdau] [nchar](10) NULL,
	[Ngay] [nchar](10) NULL,
	[Gio] [nchar](10) NULL,
	[Trongtai] [nchar](10) NULL,
	[Trongtaibien_1] [nchar](10) NULL,
	[Trongtaibien_2] [nchar](10) NULL,
	[Da_san1] [nchar](10) NULL,
	[Da_san2] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tran_dau]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tran_dau](
	[Ma_trandau] [nchar](10) NULL,
	[Sotran] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vong_dau]    Script Date: 12/6/2022 9:37:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vong_dau](
	[Ma_vongdau] [nchar](10) NULL,
	[Ten_vongdau] [nchar](10) NULL
) ON [PRIMARY]
GO