CREATE PROCEDURE [dbo].[spA_Character_GetById]
    @CharacterId INT
AS

SELECT
    [C].[Id]                    AS [CharacterId]
  , [C].[Name]                  AS [CharacterName]
  , [C].[AllegianceId]          AS [CharacterAllegianceId]
  , [C].[IsJedi]                AS [CharacterIsJedi]
  , [C].[TrilogyIntroducedInId] AS [CharacterTrilogyIntroducedInId]
FROM
    [Character] AS [C]
WHERE
    [C].[Id] = @CharacterId
;

RETURN 0
;
