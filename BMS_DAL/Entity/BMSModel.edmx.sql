
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/05/2018 14:07:32
-- Generated from EDMX file: C:\Users\Administrator\Documents\Visual Studio 2012\Projects\BMSProject\BMS_DAL\Entity\BMSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bds248164437_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TSys_Users'
CREATE TABLE [dbo].[TSys_Users] (
    [ID] nvarchar(max)  NOT NULL,
    [NAME] nvarchar(max)  NOT NULL,
    [PWD] nvarchar(max)  NOT NULL,
    [USERTYPE] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'TSys_Users'
ALTER TABLE [dbo].[TSys_Users]
ADD CONSTRAINT [PK_TSys_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------