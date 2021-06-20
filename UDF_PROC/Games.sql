DROP PROCEDURE pr_GetGameInfo
DROP PROCEDURE pr_NewGame
DROP PROCEDURE pr_getOnGoingGames
DROP FUNCTION dbo.udf_GetFormatID
DROP FUNCTION dbo.udf_GetTournamentID
DROP FUNCTION dbo.udf_GetAllOpenings
DROP FUNCTION dbo.udf_getAllFormats
DROP FUNCTION dbo.udf_getGamesOfPlayer
GO
-- indices Game - Ranked e Casual

-- get game info
-- Incluir rating diff?
-- outputs: TournamentName, tournamentDate and tournamentTime of the game. If the game isn´t from a tournament returns NULL
CREATE PROCEDURE pr_GetGameInfo (@GameID INT, @TournamentName VARCHAR(64) OUTPUT, @TournamentDate DATE OUTPUT, @TournamentTime TIME OUTPUT) 
AS
BEGIN
	DECLARE @Game TABLE (GameID INT, [Type] VARCHAR(10), Black VARCHAR(64), White VARCHAR(64), Duration VARCHAR(5), PGN VARCHAR(MAX),
	[Date] DATE, [Time] Time,Termination VARCHAR(64), Result VARCHAR(5), FormatName VARCHAR(64), ClockTime INT, ClockIncrement INT, 
	OpeningECOCode VARCHAR(3), OpeningName VARCHAR(128), OpeningPattern VARCHAR(1024),
	TournamentName VARCHAR(64), TournamentDate DATETIME)

	DECLARE @GameTmp TABLE (GameID INT, Black VARCHAR(64), White VARCHAR(64), [Type] VARCHAR(10))

	INSERT INTO @GameTmp (GameID, Black, White) SELECT *
	FROM 
	(
		SELECT [User], Game, Color
		FROM (
			SELECT [User], Game, Color FROM Chess_Ranked WHERE Chess_Ranked.game = @GameID
			) AS Records
	) AS Players
	PIVOT(
		MAX(Players.[User]) FOR Color in (Black, White)
	)PIV

	DECLARE @N INT
	SELECT @N = COUNT(*) FROM @GameTmp
	IF (@N < 1)
	BEGIN
		INSERT INTO @GameTmp (GameID, Black, White) SELECT *
		FROM 
		(
			SELECT [User], Game, Color
			FROM (
				SELECT [User], Game, Color FROM Chess_Casual WHERE Chess_Casual.game = @GameID
				) AS Records
		) AS Players
		PIVOT(
			MAX(Players.[User]) FOR Color in (Black, White)
		)PIV
		UPDATE @GameTmp  SET [Type] = 'Casual'
	END
	ELSE
		UPDATE @GameTmp  SET [Type] = 'Ranked'
		
	INSERT INTO @Game SELECT GameID, [Type], Black, White, Chess_GAME.Duration, PGN, Chess_Game.[Date], Chess_Game.[Time], Termination, Result, Chess_Format.[Name], Chess_Format.ClockTime, Chess_Format.ClockIncrement
	, Chess_Opening.ECOCode, Chess_Opening.[Name], Chess_Opening.Pattern, Chess_Tournament.[Name], Chess_Tournament.[Date]
	FROM 
	(
		@GameTmp 
		JOIN 
		Chess_Game ON GameID = Chess_Game.ID 
		LEFT OUTER JOIN
		Chess_Format ON Chess_Format.ID = Chess_Game.FormatID
		LEFT OUTER JOIN 
		Chess_Opening ON Chess_Opening.ID = Chess_Game.OpeningID
		LEFT OUTER JOIN
		Chess_Tournament ON Chess_Tournament.ID = Chess_Game.TournamentID
	)

	SELECT @TournamentDate = TournamentDate, @TournamentName = TournamentName FROM @Game 
	SELECT GameID, [Type], Black , White , Duration, PGN , [Time],[Date], Termination, Result, FormatName, ClockTime, ClockIncrement, OpeningECOCode, OpeningName, OpeningPattern FROM @Game
END
GO
/*
Test 
DECLARE @TournamentName VARCHAR(64)
DECLARE @TournamentDate DATE
DECLARE @TournamentTime TIME
EXEC pr_GetGameInfo 2963, @TournamentName OUTPUT, @TournamentDate OUTPUT, @TournamentTime OUTPUT

SELECT @TournamentName
SELECT @TournamentDate
GO
*/
-- Create new Game of given format (of given tournament opcional)
-- Create new GameRecords
-- Inputs: ClockTime, ClockIncrement, Player name playing black, Player name playing white
--		   Type (0 casual, 1 ranked)
-- Acrescentar o possibilidade de definir o time?
-- Ver se ja esta num jogo

-- TRANSACTION ??

CREATE PROCEDURE dbo.pr_newGame (@ClockTime INT, @ClockIncrement INT, @PlayerBlack VARCHAR(64), @PlayerWhite VARCHAR(64),
								 @TournamentID INT = NULL, @Type bit = 0)
AS
BEGIN
	DECLARE @FormatID INT
	DECLARE @BlackRating INT
	DECLARE @WhiteRating INT
	DECLARE @TodayDate DATE
	DECLARE @TodayTime TIME
	BEGIN TRY
		SET @FormatID = dbo.udf_GetFormatID(@ClockTime, @ClockIncrement)
		IF (@FormatID IS NULL)
		BEGIN
			RAISERROR('Format doesnt exists', 16, 1)
		END

		SET @TodayDate = GETDATE()
		SET @TodayTime = CONVERT(TIME(0),GETDATE())
	
		SELECT @BlackRating = CurrentRating FROM Chess_Classified WHERE FormatID = @FormatID AND [USER] = @PlayerBlack 
		SELECT @WhiteRating = CurrentRating FROM Chess_Classified WHERE FormatID = @FormatID AND [USER] = @PlayerWhite
		IF(@BlackRating IS NULL)
		BEGIN
			RAISERROR('Jogador %s inexistente', 16, 1, @PlayerBlack)
		END
		IF(@WhiteRating IS NULL)
		BEGIN
			RAISERROR('Jogador %s inexistente', 16, 1, @PlayerWhite)
		END
		
		BEGIN TRANSACTION AddGame
			INSERT INTO Chess_Game ([Date], [Time], FormatID, TournamentID) VALUES (@TodayDate, @TodayTime, @FormatID, @TournamentID)
			DECLARE @GameID INT = @@IDENTITY

			IF(@Type = 0)
			BEGIN
				INSERT INTO Chess_Casual ([User], Game, Color) VALUES (@PlayerBlack, @GameID, 'BLACK')
				INSERT INTO Chess_Casual ([User], Game, Color) VALUES (@PlayerWhite, @GameID, 'WHITE')
			END
			ELSE
			BEGIN
				INSERT INTO Chess_Ranked ([User], Rating, Game, Color) VALUES (@PlayerBlack, @BlackRating, @GameID, 'BLACK')
				INSERT INTO Chess_Ranked ([User], Rating, Game, Color) VALUES (@PlayerWhite, @WhiteRating, @GameID, 'WHITE')
			END
		COMMIT TRANSACTION AddGame
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION AddGame
		END 
		DECLARE @ErrorMessage   NVARCHAR(4000) = ERROR_MESSAGE(),
				@ErrorState     INT = ERROR_STATE(),
				@ErrorSeverity  INT = ERROR_SEVERITY();

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
	END CATCH
END
GO

/* Test 
--Casual
EXEC pr_NewGame 3, 0, 'maximederkek', 'bahodiraxmedov', NULL, 0
--Ranked
EXEC pr_NewGame 3, 0, 'maximederkek', 'bahodiraxmedov', NULL, 1
SELECT * FROM Chess_Game
SELECT * FROM Chess_Casual
SELECT * FROM Chess_Ranked
SELECT * FROM Chess_Classified

GO
*/

-- Input: Type 0 - casual; 1 - ranked; NULL - both 
CREATE PROCEDURE dbo.pr_getOnGoingGames(@Type bit = NULL)
AS
BEGIN
	IF(@Type IS NULL)
		SELECT DISTINCT Chess_Game.ID FROM Chess_Game WHERE Termination IS NULL 
	ELSE IF(@Type = 0)
		SELECT DISTINCT Chess_Game.ID
		FROM Chess_Game JOIN Chess_Casual ON Chess_Casual.Game = Chess_Game.ID 
		WHERE Termination IS NULL
	ELSE
		SELECT DISTINCT Chess_Game.ID
		FROM Chess_Game JOIN Chess_Ranked ON Chess_Ranked.Game = Chess_Game.ID 
		WHERE Termination IS NULL
END
GO
/* Test
EXEC pr_getOnGoingGames 
GO
*/

CREATE FUNCTION dbo.udf_getGamesOfPlayer(@Username VARCHAR(64)) RETURNS TABLE
AS
	RETURN SELECT Game FROM Chess_Ranked WHERE [User] = @Username
		   UNION SELECT Game FROM Chess_Casual WHERE [User] = @Username
GO


/* Test
SELECT * FROM dbo.udf_getGamesOfPlayer('maximederkek')
GO
*/
--- Private ---
-- Get FormatID for given Format ClockTime and ClockIncrement
-- Returns NULL IF Format doesnt exist
CREATE FUNCTION dbo.udf_GetFormatID (@ClockTime INT, @ClockIncrement INT) RETURNS INT
AS
BEGIN
	DECLARE @FormatID INT
	SELECT @FormatID = ID FROM Chess_Format WHERE ClockTime = @ClockTime AND ClockIncrement = @ClockIncrement 
	RETURN @FormatID
END
GO
/* Test
DECLARE @FormatID INT
SET @FormatID = dbo.udf_GetFormatID(3, 0)
SELECT @FormatID
GO
*/

-- Private
-- Get TournamentID for given Tournament name and date
-- Returns NULL IF Tournament doesnt exist
CREATE FUNCTION dbo.udf_GetTournamentID (@Name VARCHAR(64), @Date DATE, @Time TIME) RETURNS INT
AS
BEGIN
	DECLARE @TournamentID INT
	SELECT @TournamentID = ID FROM Chess_Tournament WHERE [Name] = @Name AND [Date] = @Date AND [Time] = @Time
	RETURN @TournamentID
END
GO


CREATE FUNCTION dbo.udf_GetAllOpenings() RETURNS TABLE
AS
	RETURN SELECT [Name] FROM Chess_Opening
GO
/* Test
SELECT * FROM dbo.udf_GetAllOpenings()
GO
*/
CREATE FUNCTION dbo.udf_getAllFormats() RETURNS TABLE
AS
	RETURN SELECT [Name], ClockTime, ClockIncrement FROM Chess_Format
GO
/* Test
SELECT * FROM dbo.udf_getAllFormats()
*/

