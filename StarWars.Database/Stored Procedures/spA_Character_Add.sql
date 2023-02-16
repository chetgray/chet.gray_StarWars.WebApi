CREATE PROCEDURE [dbo].[spA_Character_Add]
    @CharacterName                  NVARCHAR(850)
  , @CharacterAllegianceId          NVARCHAR(850)
  , @CharacterIsJedi                BIT
  , @CharacterTrilogyIntroducedInId NVARCHAR(850)
AS

INSERT INTO [Character]
  ([Name],         [AllegianceId],         [IsJedi],         [TrilogyIntroducedInId])
VALUES
  (@CharacterName, @CharacterAllegianceId, @CharacterIsJedi, @CharacterTrilogyIntroducedInId)
;

DECLARE @CharacterId INT;
SELECT @CharacterId = SCOPE_IDENTITY();

-- Suppress results if we were called by another stored procedure that doesn't want our results.
IF OBJECT_ID('tempdb..#__SuppressResults_Character_Add') IS NULL
BEGIN
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
END

RETURN 0
