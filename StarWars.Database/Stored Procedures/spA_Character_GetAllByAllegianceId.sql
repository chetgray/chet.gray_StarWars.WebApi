CREATE PROCEDURE [dbo].[spA_Character_GetAllByAllegianceId]
    @CharacterAllegianceId NVARCHAR(850)
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
    [C].[AllegianceId] = @CharacterAllegianceId
;

RETURN 0
;
