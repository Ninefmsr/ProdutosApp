﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [CATEGORIA] (
    [ID] uniqueidentifier NOT NULL,
    [NOME] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_CATEGORIA] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [FORNECEDOR] (
    [ID] uniqueidentifier NOT NULL,
    [RAZAOSOCIAL] nvarchar(100) NOT NULL,
    [CNPJ] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_FORNECEDOR] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [PRODUTO] (
    [ID] uniqueidentifier NOT NULL,
    [NOME] nvarchar(100) NOT NULL,
    [PRECO] DECIMAL(10,2) NOT NULL,
    [QUANTIDADE] int NOT NULL,
    [CATEGORIA_ID] uniqueidentifier NOT NULL,
    [FORNECEDOR_ID] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_PRODUTO] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_PRODUTO_CATEGORIA_CATEGORIA_ID] FOREIGN KEY ([CATEGORIA_ID]) REFERENCES [CATEGORIA] ([ID]),
    CONSTRAINT [FK_PRODUTO_FORNECEDOR_FORNECEDOR_ID] FOREIGN KEY ([FORNECEDOR_ID]) REFERENCES [FORNECEDOR] ([ID])
);
GO

CREATE UNIQUE INDEX [IX_CATEGORIA_NOME] ON [CATEGORIA] ([NOME]);
GO

CREATE UNIQUE INDEX [IX_FORNECEDOR_CNPJ] ON [FORNECEDOR] ([CNPJ]);
GO

CREATE INDEX [IX_PRODUTO_CATEGORIA_ID] ON [PRODUTO] ([CATEGORIA_ID]);
GO

CREATE INDEX [IX_PRODUTO_FORNECEDOR_ID] ON [PRODUTO] ([FORNECEDOR_ID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240206003657_Initial', N'8.0.1');
GO

COMMIT;
GO

