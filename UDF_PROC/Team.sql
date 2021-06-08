DROP FUNCTION udf_GetTeamMembers
DROP FUNCTION udf_GetTeamInfo
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