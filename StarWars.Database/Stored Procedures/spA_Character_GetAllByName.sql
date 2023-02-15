CREATE PROCEDURE [dbo].[spA_Character_GetAllByName]
    @CharacterName NVARCHAR(850)
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
    [C].[Name] = @CharacterName
;

RETURN 0
;
