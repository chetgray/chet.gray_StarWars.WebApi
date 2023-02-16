SET IDENTITY_INSERT [Allegiance] ON;

MERGE INTO [Allegiance] AS [tgt]
USING (
              SELECT 0,    'None'
    UNION ALL SELECT 1,    'Rebellion'
    UNION ALL SELECT 2,    'Empire'
) AS [src]          ([Id], [Name])
ON
    [tgt].[Id] = [src].[Id]
WHEN MATCHED THEN
    UPDATE
    SET
        [tgt].[Name] = [src].[Name]
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id],       [Name])
    VALUES ([src].[Id], [src].[Name])
WHEN NOT MATCHED BY SOURCE THEN
    DELETE
;

SET IDENTITY_INSERT [Allegiance] OFF;
GO

SET IDENTITY_INSERT [Trilogy] ON;

MERGE INTO [Trilogy] AS [tgt]
USING (
              SELECT 0,    'None'
    UNION ALL SELECT 1,    'Original'
    UNION ALL SELECT 2,    'Prequel'
    UNION ALL SELECT 3,    'Sequel'
) AS [src]          ([Id], [Name])
ON
    [tgt].[Id] = [src].[Id]
WHEN MATCHED THEN
    UPDATE
    SET
        [tgt].[Name] = [src].[Name]
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Id],       [Name])
    VALUES ([src].[Id], [src].[Name])
WHEN NOT MATCHED BY SOURCE THEN
    DELETE
;

SET IDENTITY_INSERT [Trilogy] OFF;
GO
