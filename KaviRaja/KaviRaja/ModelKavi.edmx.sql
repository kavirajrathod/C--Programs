
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 12:26:44
-- Generated from EDMX file: C:\Users\Admin\source\repos\KaviRaja\KaviRaja\ModelKavi.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyNewDatabase];
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

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Pid] int IDENTITY(1,1) NOT NULL,
    [Ptytle] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Cid] int  NOT NULL constraint fk_Pr foreign key references Categaries(Cid)
);
GO

-- Creating table 'Categaries'
CREATE TABLE [dbo].[Categaries] (
    [Cid] int IDENTITY(1,1) NOT NULL primary key,
    [Ctytle] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Pid] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Pid] ASC);
GO

-- Creating primary key on [Cid] in table 'Categaries'
ALTER TABLE [dbo].[Categaries]
ADD CONSTRAINT [PK_Categaries]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------