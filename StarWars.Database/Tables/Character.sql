CREATE TABLE [dbo].[Character] (
    [Id]                    INT IDENTITY   NOT NULL
  , [Name]                  NVARCHAR(4000) NOT NULL
  , [AllegianceId]          INT            NOT NULL
  , [IsJedi]                BIT            NOT NULL
  , [TrilogyIntroducedInId] INT            NOT NULL

  , CONSTRAINT [PK_Character_Id]                    PRIMARY KEY ([Id])
  , CONSTRAINT [AK_Carrier_Name]                    UNIQUE      ([Name])
  , CONSTRAINT [FK_Character_AllegianceId]          FOREIGN KEY ([AllegianceId])          REFERENCES [Allegiance] ([Id])
  , CONSTRAINT [FK_Character_TrilogyIntroducedInId] FOREIGN KEY ([TrilogyIntroducedInId]) REFERENCES [Trilogy]    ([Id])
)
;
