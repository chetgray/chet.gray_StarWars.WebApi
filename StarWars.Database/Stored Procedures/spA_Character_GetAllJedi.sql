CREATE PROCEDURE [dbo].[spA_Character_GetAllJedi]
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
    [C].[IsJedi] = 1
;

RETURN 0
;
