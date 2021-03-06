
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/15/2018 00:24:11
-- Generated from EDMX file: C:\Users\yangz\Documents\Visual Studio 2012\Projects\BMSProject\BMS_DAL\Entity\BMSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [hds192879581_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TUsers];
GO
IF OBJECT_ID(N'[dbo].[TFixtures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TFixtures];
GO
IF OBJECT_ID(N'[dbo].[TVessels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TVessels];
GO
IF OBJECT_ID(N'[dbo].[TInvoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TInvoices];
GO
IF OBJECT_ID(N'[dbo].[TInvoiceDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TInvoiceDetails];
GO
IF OBJECT_ID(N'[dbo].[TClients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TClients];
GO
IF OBJECT_ID(N'[dbo].[TMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMenus];
GO
IF OBJECT_ID(N'[dbo].[TLogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TLogs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TUsers'
CREATE TABLE [dbo].[TUsers] (
    [ID] nvarchar(max)  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [PWD] nvarchar(max)  NOT NULL,
    [USERTYPE] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL
);
GO

-- Creating table 'TFixtures'
CREATE TABLE [dbo].[TFixtures] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [VSL_ID] int  NOT NULL,
    [CP_DATE] datetimeoffset  NOT NULL,
    [CP_TYPE] nvarchar(max)  NOT NULL,
    [CP_DESC] nvarchar(max)  NOT NULL,
    [PAYER] nvarchar(max)  NOT NULL,
    [HRORFRT] decimal(2,0)  NOT NULL,
    [DAYSORMT] decimal(18,0)  NOT NULL,
    [OWR] nvarchar(max)  NOT NULL,
    [BRKRATE_OWR] decimal(18,0)  NOT NULL,
    [BRKAMOUNT_OWR] decimal(18,0)  NOT NULL,
    [CHR] nvarchar(max)  NOT NULL,
    [BRKRATE_CHR] decimal(18,0)  NOT NULL,
    [BRKAMOUNT_CHR] decimal(18,0)  NOT NULL,
    [ESTBRK] decimal(18,0)  NOT NULL,
    [BROKER1] nvarchar(max)  NOT NULL,
    [BROKER2] nvarchar(max)  NOT NULL,
    [SIGNOPER] nvarchar(max)  NOT NULL,
    [CAP_RATE] decimal(18,0)  NOT NULL,
    [CAP_AMOUNT] decimal(18,0)  NOT NULL,
    [TFCB] int  NOT NULL,
    [FIXNO] nvarchar(max)  NOT NULL,
    [STATUS] nvarchar(max)  NOT NULL,
    [REMARK] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL
);
GO

-- Creating table 'TVessels'
CREATE TABLE [dbo].[TVessels] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [SIZE] nvarchar(max)  NOT NULL,
    [DESC] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL
);
GO

-- Creating table 'TInvoices'
CREATE TABLE [dbo].[TInvoices] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FIXNO] nvarchar(max)  NOT NULL,
    [REFNO] nvarchar(max)  NOT NULL,
    [INVOICE_DATE] datetimeoffset  NOT NULL,
    [MESSES] nvarchar(max)  NOT NULL,
    [VSL_ID] int  NOT NULL,
    [CP_DATE] datetimeoffset  NOT NULL,
    [CP_TYPE] nvarchar(max)  NOT NULL,
    [CP_DESC] nvarchar(max)  NOT NULL,
    [HRORFRT] decimal(18,0)  NOT NULL,
    [DAYSORMT] decimal(18,0)  NOT NULL,
    [ATIN] nvarchar(max)  NOT NULL,
    [CWNO] nvarchar(max)  NOT NULL,
    [OWR] nvarchar(max)  NOT NULL,
    [BRKRATE_OWR] decimal(18,0)  NOT NULL,
    [BRKAMOUNT_OWR] decimal(18,0)  NOT NULL,
    [CHR] nvarchar(max)  NOT NULL,
    [BRKRATE_CHR] decimal(18,0)  NOT NULL,
    [BRKAMOUNT_CHR] decimal(18,0)  NOT NULL,
    [PERIODS] nvarchar(max)  NOT NULL,
    [BANKACCOUNT] nvarchar(max)  NOT NULL,
    [RECEIVABLEAMOUNT] decimal(18,0)  NOT NULL,
    [STATUS] nvarchar(max)  NOT NULL,
    [REMARK] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL,
    [RECEIVABLEDATE] datetimeoffset  NOT NULL,
    [FIX_ID] int  NOT NULL,
    [PAIDIN] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'TInvoiceDetails'
CREATE TABLE [dbo].[TInvoiceDetails] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [C1] nvarchar(max)  NOT NULL,
    [C2] nvarchar(max)  NOT NULL,
    [C3] nvarchar(max)  NOT NULL,
    [C4] nvarchar(max)  NOT NULL,
    [C5] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL,
    [INVOICE_ID] int  NOT NULL,
    [DEBIT] decimal(18,0)  NOT NULL,
    [CREDIT] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'TClients'
CREATE TABLE [dbo].[TClients] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NAME] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TMenus'
CREATE TABLE [dbo].[TMenus] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DISPLAYNAME] nvarchar(max)  NOT NULL,
    [ASSEMBLY] nvarchar(max)  NOT NULL,
    [OPER] nvarchar(max)  NOT NULL,
    [OP_DT] datetimeoffset  NOT NULL
);
GO

-- Creating table 'TLogs'
CREATE TABLE [dbo].[TLogs] (
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'TUsers'
ALTER TABLE [dbo].[TUsers]
ADD CONSTRAINT [PK_TUsers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TFixtures'
ALTER TABLE [dbo].[TFixtures]
ADD CONSTRAINT [PK_TFixtures]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TVessels'
ALTER TABLE [dbo].[TVessels]
ADD CONSTRAINT [PK_TVessels]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TInvoices'
ALTER TABLE [dbo].[TInvoices]
ADD CONSTRAINT [PK_TInvoices]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TInvoiceDetails'
ALTER TABLE [dbo].[TInvoiceDetails]
ADD CONSTRAINT [PK_TInvoiceDetails]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TClients'
ALTER TABLE [dbo].[TClients]
ADD CONSTRAINT [PK_TClients]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TMenus'
ALTER TABLE [dbo].[TMenus]
ADD CONSTRAINT [PK_TMenus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TLogs'
ALTER TABLE [dbo].[TLogs]
ADD CONSTRAINT [PK_TLogs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------