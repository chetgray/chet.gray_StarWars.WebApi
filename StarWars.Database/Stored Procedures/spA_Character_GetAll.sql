CREATE PROCEDURE [dbo].[spA_Character_GetAll]
AS

SELECT
    [C].[Id]                    AS [CharacterId]
  , [C].[Name]                  AS [CharacterName]
  , [C].[AllegianceId]          AS [CharacterAllegianceId]
  , [C].[IsJedi]                AS [CharacterIsJedi]
  , [C].[TrilogyIntroducedInId] AS [CharacterTrilogyIntroducedInId]
FROM
    [Character] AS [C]
;

RETURN 0
;
