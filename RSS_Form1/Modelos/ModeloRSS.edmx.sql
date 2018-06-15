
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2018 13:52:23
-- Generated from EDMX file: C:\Users\rmathias\Source\Repos\RSS_Form1\RSS_Form1\Modelos\ModeloRSS.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bancoRSS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Feed_To_Categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Feeds] DROP CONSTRAINT [FK_Feed_To_Categoria];
GO
IF OBJECT_ID(N'[dbo].[FK_Item_To_Feed]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Items] DROP CONSTRAINT [FK_Item_To_Feed];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Feeds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feeds];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Regras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Regras];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [cat_codigo] int IDENTITY(1,1) NOT NULL,
    [cat_descricao] nvarchar(50)  NOT NULL,
    [cat_ordem] int  NULL
);
GO

-- Creating table 'Feeds'
CREATE TABLE [dbo].[Feeds] (
    [feed_codigo] int IDENTITY(1,1) NOT NULL,
    [feed_descricao] nvarchar(50)  NOT NULL,
    [feed_site] nvarchar(100)  NULL,
    [feed_url] nvarchar(200)  NULL,
    [feed_qt_nao_lidos] int  NULL,
    [cat_codigo] int  NOT NULL,
    [feed_ordem] int  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [item_codigo] int IDENTITY(1,1) NOT NULL,
    [item_url] nvarchar(200)  NOT NULL,
    [item_titulo] nvarchar(200)  NULL,
    [item_lido] bit  NULL,
    [item_conteudo] nvarchar(max)  NULL,
    [item_dthr] datetime  NULL,
    [feed_codigo] int  NULL
);
GO

-- Creating table 'Regras'
CREATE TABLE [dbo].[Regras] (
    [regra_codigo] int IDENTITY(1,1) NOT NULL,
    [regra_chaves] nvarchar(max)  NULL,
    [regra_ativo] bit  NULL,
    [regra_tipo] nvarchar(20)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [cat_codigo] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([cat_codigo] ASC);
GO

-- Creating primary key on [feed_codigo] in table 'Feeds'
ALTER TABLE [dbo].[Feeds]
ADD CONSTRAINT [PK_Feeds]
    PRIMARY KEY CLUSTERED ([feed_codigo] ASC);
GO

-- Creating primary key on [item_codigo] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([item_codigo] ASC);
GO

-- Creating primary key on [regra_codigo] in table 'Regras'
ALTER TABLE [dbo].[Regras]
ADD CONSTRAINT [PK_Regras]
    PRIMARY KEY CLUSTERED ([regra_codigo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cat_codigo] in table 'Feeds'
ALTER TABLE [dbo].[Feeds]
ADD CONSTRAINT [FK_Feed_To_Categoria]
    FOREIGN KEY ([cat_codigo])
    REFERENCES [dbo].[Categorias]
        ([cat_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Feed_To_Categoria'
CREATE INDEX [IX_FK_Feed_To_Categoria]
ON [dbo].[Feeds]
    ([cat_codigo]);
GO

-- Creating foreign key on [feed_codigo] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [FK_Item_To_Feed]
    FOREIGN KEY ([feed_codigo])
    REFERENCES [dbo].[Feeds]
        ([feed_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_To_Feed'
CREATE INDEX [IX_FK_Item_To_Feed]
ON [dbo].[Items]
    ([feed_codigo]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------