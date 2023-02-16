SET IDENTITY_INSERT [Character] ON;

INSERT INTO [Character] (
    [Id]
  , [Name]
  , [AllegianceId]
  , [IsJedi]
  , [TrilogyIntroducedInId]
)
SELECT [src].*
FROM (
              SELECT 1,    'Luke Skywalker', 1,              1,        1
    UNION ALL SELECT 2,    'Obi-Wan Kenobi', 1,              1,        1
    UNION ALL SELECT 3,    'Jar Jar Binks',  0,              0,        2
    UNION ALL SELECT 4,    'Poe Dameron',    1,              0,        3
    UNION ALL SELECT 5,    'Finn',           1,              0,        3
    UNION ALL SELECT 6,    'Rey Skywalker',  1,              1,        3
    UNION ALL SELECT 7,    'C-3PO',          1,              0,        1
    UNION ALL SELECT 8,    'R2-D2',          1,              0,        1
) AS [src]          ([Id], [Name],           [AllegianceId], [IsJedi], [TrilogyIntroducedInId])
WHERE NOT EXISTS (
    SELECT 1
    FROM [Character]
)
;

SET IDENTITY_INSERT [Character] OFF;
GO
