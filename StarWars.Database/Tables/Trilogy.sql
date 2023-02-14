CREATE TABLE [dbo].[Trilogy] (
    [Id]   INT IDENTITY  NOT NULL
  , [Name] NVARCHAR(850) NOT NULL

  , CONSTRAINT [PK_Trilogy_Id]   PRIMARY KEY ([Id])
  , CONSTRAINT [AK_Trilogy_Name] UNIQUE      ([Name])
)
;
