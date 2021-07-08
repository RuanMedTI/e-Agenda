-- Script Date: 05/07/2021 16:42  - ErikEJ.SqlCeScripting version 3.5.2.87
CREATE TABLE [TBCONTATO] (
  [Id] INTEGER NOT NULL
, [Nome] TEXT NOT NULL
, [Email] TEXT NOT NULL
, [Telefone] TEXT NOT NULL
, [Cargo] TEXT NULL
, [Empresa] TEXT NULL
, CONSTRAINT [PK_TBCONTATO] PRIMARY KEY ([Id])
);
