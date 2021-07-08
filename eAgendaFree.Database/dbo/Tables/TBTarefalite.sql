-- Script Date: 05/07/2021 17:00  - ErikEJ.SqlCeScripting version 3.5.2.87
CREATE TABLE [TBTAREFA] (
  [Id] INTEGER NOT NULL
, [Titulo] TEXT NOT NULL
, [DataCriacao] TEXT NOT NULL
, [DataConclusao] TEXT NULL
, [Prioridade] INTEGER NOT NULL
, [Percentual] INTEGER NOT NULL
, CONSTRAINT [PK_TBTAREFA] PRIMARY KEY ([Id])
);
