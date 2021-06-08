DROP FUNCTION udf_GetUserFriends
DROP FUNCTION udf_GetUserInfo
DROP FUNCTION udf_GetUsersInfo
DROP FUNCTION udf_AuthenticateUser
DROP FUNCTION udf_GetUserTeams
GO 

-- Returns all user's friends given a username
CREATE FUNCTION udf_GetUserFriends (@Username VARCHAR(64)) RETURNS TABLE
AS
	RETURN SELECT	TUsername as Friend FROM Chess_Friends WHERE @Username = SUsername 
					UNION 
					SELECT sUsername FROM Chess_Friends WHERE @Username = TUsername
GO

SELECT * FROM Chess_Friends WHERE TUsername = 'Judge59' OR SUsername = 'Judge59'
SELECT * FROM udf_GetUserFriends('Judge59')
GO

-- Returns all user's personal information given a username
-- Username, Password, Email, Country, RegistrationDate, Title
CREATE FUNCTION udf_GetUserInfo (@Username VARCHAR(64)) RETURNS TABLE
AS
	RETURN	SELECT Username, [Password], [Name], Email, Country, RegistrationDate, Title 
			FROM Chess_User LEFT OUTER JOIN Chess_UserTitle ON Username = [User]
			Where Username = @Username
GO

SELECT * FROM udf_GetUserInfo('A129')
GO

-- Returns all user's personal information for all users
-- Username, Password, Name, Email, Country, RegistrationDate, Title
CREATE FUNCTION udf_GetUsersInfo () RETURNS TABLE
AS
	RETURN	SELECT Username, [Password], [Name], Email, Country, RegistrationDate, Title 
			FROM Chess_User LEFT OUTER JOIN Chess_UserTitle ON Username = [User]
GO

SELECT * FROM udf_GetUsersInfo()
GO

CREATE FUNCTION udf_GetUserTeams (@Username VARCHAR(64)) RETURNS Table
AS
	RETURN SELECT Team FROM Chess_User JOIN Chess_Member ON Username = [User] WHERE Username = @Username
GO

SELECT * FROM udf_GetUserTeams('GhostAgent')
GO

CREATE FUNCTION udf_AuthenticateUser (@Username VARCHAR(64), @Password VARCHAR(64)) RETURNS bit
AS
BEGIN
	IF(EXISTS(SELECT * FROM Chess_User WHERE Username = @Username AND [Password] = @Password))
		RETURN 1
	RETURN 0
END
GO

SELECT dbo.udf_AuthenticateUser('M3hran', '948ZVBGGL3')
SELECT dbo.udf_AuthenticateUser('invalidUsername', '948ZVBGGL3')
SELECT dbo.udf_AuthenticateUser('M3hran', 'invalidPassword')

