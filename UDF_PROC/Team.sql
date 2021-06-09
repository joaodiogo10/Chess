DROP FUNCTION udf_GetTeamMembers
DROP FUNCTION udf_GetTeamInfo
DROP PROCEDURE pr_AddTeamMember
DROP PROCEDURE pr_DeleteTeamMember
DROP PROCEDURE pr_DeleteTeam
GO

-- Returns all team's members given a teamName 
CREATE FUNCTION dbo.udf_GetTeamMembers (@teamName VARCHAR(128)) RETURNS TABLE
	RETURN SELECT [User] FROM Chess_Member 
			WHERE Team = @teamName
GO

SELECT * FROM dbo.udf_GetTeamMembers('Chesslandia')
GO

-- Returns all team's information given a teamName
CREATE FUNCTION dbo.udf_GetTeamInfo (@teamName VARCHAR(128)) RETURNS TABLE
AS
	RETURN  SELECT * FROM Chess_Team
			WHERE Chess_Team.[Name] = @teamName
GO

SELECT * FROM dbo.udf_GetTeamInfo('Chesslandia')
GO

select * from Chess_Team
GO

-- Given a teamName and an username adds it to the team
CREATE PROCEDURE dbo.pr_AddTeamMember (@teamName VARCHAR(128), @userName VARCHAR(64))
AS
	INSERT INTO Chess_Member VALUES(@teamName, @userName)
GO

EXEC pr_AddTeamMember @teamName = 'Chesslandia', @userName = 'Adri_3'
GO

-- Given a teamName and an username deletes it of the team
CREATE PROCEDURE dbo.pr_DeleteTeamMember (@teamName VARCHAR(128), @userName VARCHAR(64))
AS
	IF NOT EXISTS(SELECT Leader FROM Chess_Team WHERE Chess_Team.[Name] = @teamName and Chess_Team.Leader = @userName) 
		DELETE Chess_Member WHERE Team = @teamName and [User] = @userName
GO

EXEC pr_DeleteTeamMember @teamName = 'Chesslandia', @userName = 'Adri_3'
GO

CREATE PROCEDURE dbo.pr_ChangeTeamLeader (@teamName VARCHAR(128), @userName VARCHAR(64))
AS 
		UPDATE Chess_Team SET Leader = @userName WHERE [Name] = @teamName
GO

EXEC pr_ChangeTeamLeader @teamName = 'Chesslandia', @userName = 'Adri_3'
GO

CREATE PROCEDURE dbo.pr_DeleteTeam (@teamName VARCHAR(128))
AS
	DECLARE @Leader VARCHAR(64)

	SELECT @Leader = Leader FROM Chess_Team WHERE [Name] = @teamName

	DELETE Chess_Member WHERE Team = @teamName
	DELETE Chess_Team WHERE [Name] = @teamName
GO

EXEC pr_DeleteTeam @teamName = 'ChessMaster'
GO