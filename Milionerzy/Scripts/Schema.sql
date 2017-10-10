CREATE DATABASE Millionaire
GO

USE [Millionaire]
GO

/****** Object: Table [dbo].[Questions] Script Date: 2017-10-10 20:39:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Questions] (
    [ID]      INT            IDENTITY (1, 1) NOT NULL,
    [Text]    NVARCHAR (150) NOT NULL,
    [AnswerA] NVARCHAR (50)  NOT NULL,
    [AnswerB] NVARCHAR (50)  NOT NULL,
    [AnswerC] NVARCHAR (50)  NOT NULL,
    [AnswerD] NVARCHAR (50)  NOT NULL,
    [Answer]  NCHAR (1)      NOT NULL
);


