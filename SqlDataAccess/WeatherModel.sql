
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2016 16:32:10
-- Generated from EDMX file: D:\Dropbox\dev\WeatherDisplay\SqlDataAccess\WeatherModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WeatherDisplay];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Forecast]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Forecast];
GO
IF OBJECT_ID(N'[dbo].[Weather]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Weather];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Forecast'
CREATE TABLE [dbo].[Forecast] (
    [Id] int IDENTITY(1,1) NOT NULL,
	[CityId] bigint NOT NULL,
    [ForecastDate] date  NOT NULL,
    [Measurement] datetime  NOT NULL,
    [TemperatureDay] float  NOT NULL,
    [TemperatureEvening] float  NOT NULL,
    [TemperatureMorning] float  NOT NULL,
    [TemperatureNight] float  NOT NULL
);
GO

-- Creating table 'Weather'
CREATE TABLE [dbo].[Weather] (
    [Id] int IDENTITY(1,1) NOT NULL,
	[CityId] bigint NOT NULL,
    [WeatherDate] date  NOT NULL,
    [WeatherTime] time  NOT NULL,
    [Measurement] datetime  NOT NULL,
    [Temperature] float  NOT NULL,
    [Cloudness] float  NULL,
    [Humidity] float  NULL,
    [Pressure] float  NULL,
    [Sunrise] datetime  NULL,
    [Sunset] datetime  NULL,
    [WindDirection] float  NULL,
    [WindSpeed] float  NULL,
    [Condition] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Forecast'
ALTER TABLE [dbo].[Forecast]
ADD CONSTRAINT [PK_Forecast]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Weather'
ALTER TABLE [dbo].[Weather]
ADD CONSTRAINT [PK_Weather]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------