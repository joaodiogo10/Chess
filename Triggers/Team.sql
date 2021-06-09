DROP TRIGGER tr_onTeamInsert
DROP TRIGGER tr_onTeamUpdate
GO

CREATE TRIGGER tr_onTeamInsert ON dbo.CHESS_Team
AFTER INSERT
AS
BEGIN
	DECLARE @Leader VARCHAR(64)
	DECLARE @TName VARCHAR(64) 
	SELECT @Leader = Leader, @TName= [Name] FROM inserted
	INSERT INTO Chess_Member VALUES (@TName, @Leader)
END
GO

CREATE TRIGGER tr_onTeamUpdate ON dbo.CHESS_Team
AFTER UPDATE
AS
BEGIN
	DECLARE @Leader VARCHAR(64)
	DECLARE @TName VARCHAR(64) 
	SELECT @Leader = Leader, @TName= [Name] FROM inserted

	IF(NOT EXISTS(SELECT * FROM Chess_Member WHERE [User] = @Leader AND Team = @TName))
		ROLLBACK TRAN;
END
GO

--SELECT * FROM dbo.udf_GetTeamMembers('Chesslandia')
--SELECT dbo.udf_GetTeamInfo('Chesslandia')
--UPDATE Chess_Team SET Leader = 'AbdullayevB' Where [Name] = 'Chesslandia'
--SELECT dbo.udf_GetTeamInfo('Chesslandia')
--UPDATE Chess_Team SET Leader = 'M3hran' Where [Name] = 'Chesslandia'