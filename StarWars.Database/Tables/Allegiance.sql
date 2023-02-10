CREATE TABLE [dbo].[Allegiance] (
    [Id]   INT IDENTITY   NOT NULL
  , [Name] NVARCHAR(4000) NOT NULL

  , CONSTRAINT [PK_Allegiance_Id]   PRIMARY KEY ([Id])
  , CONSTRAINT [AK_Allegiance_Name] UNIQUE      ([Name])
)
;
