DROP FUNCTION udf_GetUserFriends
DROP FUNCTION udf_GetUserInfo
DROP FUNCTION udf_GetUsersInfo
DROP FUNCTION udf_AuthenticateUser
DROP FUNCTION udf_GetUserTeams
DROP PROCEDURE pr_RegisterUser
GO 

-- Returns all user's friends given a username
CREATE FUNCTION udf_GetUserFriends (@Username VARCHAR(64)) RETURNS TABLE
AS
	RETURN SELECT	TUsername as Friend FROM Chess_Friends WHERE @Username = SUsername 
					UNION 
					SELECT sUsername FROM Chess_Friends WHERE @Username = TUsername
GO

/* Test
SELECT * FROM Chess_Friends WHERE TUsername = 'Judge59' OR SUsername = 'Judge59'
SELECT * FROM udf_GetUserFriends('Judge59')
GO
*/

-- Returns all user's personal information given a username
-- Username, Password, Email, Country, RegistrationDate, Title
CREATE FUNCTION udf_GetUserInfo (@Username VARCHAR(64)) RETURNS TABLE
AS
	RETURN	SELECT Username, [Name], Email, Country, RegistrationDate, Title 
			FROM Chess_User LEFT OUTER JOIN Chess_UserTitle ON Username = [User]
			Where Username = @Username
GO
/* Test
SELECT * FROM udf_GetUserInfo('A129')
GO
*/
-- Returns all user's personal information for all users
-- Username, Password, Name, Email, Country, RegistrationDate, Title
CREATE FUNCTION udf_GetUsersInfo () RETURNS TABLE
AS
	RETURN	SELECT Username, [Name], Email, Country, RegistrationDate, Title 
			FROM Chess_User LEFT OUTER JOIN Chess_UserTitle ON Username = [User]
GO
/* Test
SELECT * FROM udf_GetUsersInfo()
GO
*/
CREATE FUNCTION udf_GetUserTeams (@Username VARCHAR(64)) RETURNS Table
AS
	RETURN SELECT Team FROM Chess_User JOIN Chess_Member ON Username = [User] WHERE Username = @Username
GO

/* Test
SELECT * FROM udf_GetUserTeams('GhostAgent')
GO
*/

CREATE FUNCTION udf_AuthenticateUser (@Username VARCHAR(64), @Password VARCHAR(64)) RETURNS bit
AS
BEGIN
	DECLARE @HashedPassword AS BINARY(32)
	SET @HashedPassword = HASHBYTES('SHA2_256', @Password)
	DECLARE @UserHashedPass AS BINARY(32)

	SELECT  @UserHashedPass  = [Password] FROM Chess_User WHERE Username = @Username
	IF(@UserHashedPass = @HashedPassword)
		RETURN 1
	RETURN 0
END
GO

/* Test
SELECT dbo.udf_AuthenticateUser('Kakurenbo', 'U45EP48GDM')
SELECT dbo.udf_AuthenticateUser('invalidUsername', '948ZVBGGL3')
SELECT dbo.udf_AuthenticateUser('M3hran', 'invalidPassword')
GO
*/


CREATE PROCEDURE pr_RegisterUser (@Username VARCHAR(64), @Password VARCHAR(64), @Name VARCHAR(128), @Country VARCHAR(64),
							 @Email VARCHAR(128)) 
AS
BEGIN
	BEGIN TRY
		IF (LEN(@Username) < 3)
			RAISERROR ('Invalid username!', 16, 1)

		IF (LEN(@Password) < 6)
			RAISERROR ('Password is too short!', 16, 1)
			
		IF (LEN(@name) < 3)
			RAISERROR ('Invalid name!', 16, 1)

		IF (NOT @Email LIKE '%_@__%._%')
			RAISERROR ('Invalid email!', 16, 1)
	
		DECLARE @HashedPassword AS BINARY(32)
		SET @HashedPassword = HASHBYTES('SHA2_256', @Password)
		DECLARE @RegistrationDate DATE
		SET @RegistrationDate = GETDATE()
	
		DECLARE @classifiedTable TABLE
		([User]			VARCHAR(64),
		 FormatID		INT)

		INSERT INTO @classifiedTable (FormatID)
		SELECT ID FROM Chess_Format

		UPDATE @classifiedTable SET [User] = @Username
		BEGIN TRANSACTION NewUser
			INSERT INTO Chess_User VALUES (@Username, @HashedPassword, @Name, @Country, @Email, @RegistrationDate, 400, 400)
			INSERT INTO Chess_Classified ([User], FormatID) SELECT * FROM @classifiedTable
		COMMIT TRANSACTION NewUser
	END TRY
	BEGIN CATCH 
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION NewUser
		END 
		DECLARE @ErrorMessage   NVARCHAR(4000) = ERROR_MESSAGE(),
				@ErrorState     INT = ERROR_STATE(),
				@ErrorSeverity  INT = ERROR_SEVERITY();

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
	END CATCH
END
GO
/* Test
EXEC pr_RegisterUser 'ChessUsername', 'Chessr', 'ChessName', 'Portugal', 'email@gmail.com'
SELECT * FROM Chess_User WHERE Username = 'ChessUsername'
SELECT * FROM Chess_Classified WHERE [User] = 'ChessUsername'
SELECT dbo.udf_AuthenticateUser('ChessUsername', 'ChessUser')

SELECT * FROM Chess_User WHERE Username = 'joao'
DELETE FROM Chess_Classified WHERE [User] = 'ChessUsername'
DELETE FROM Chess_User WHERE Username = 'ChessUsername'
*/
