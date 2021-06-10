DROP PROCEDURE pr_GetGameInfo
GO
-- indices Game - Ranked e Casual

-- get game info
-- Incluir rating diff?
-- outputs: TournamentName, tournamentDate and tournamentTime of the game. If the game isn´t from a tournament returns NULL
CREATE PROCEDURE pr_GetGameInfo (@GameID INT, @TournamentName VARCHAR(64) OUTPUT, @TournamentDate DATE OUTPUT, @TournamentTime TIME OUTPUT) 
AS
BEGIN
	DECLARE @Game TABLE (GameID INT, Black VARCHAR(64), White VARCHAR(64), Duration VARCHAR(5), PGN VARCHAR(MAX),
	[Date] DATE, [Time] Time,Termination VARCHAR(64), Result VARCHAR(5), FormatName VARCHAR(64), ClockTime INT, ClockIncrement INT, 
	OpeningECOCode VARCHAR(3), OpeningName VARCHAR(128), OpeningPattern VARCHAR(1024),
	TournamentName VARCHAR(64), TournamentDate DATETIME)

	DECLARE @GameTmp TABLE (GameID INT, Black VARCHAR(64), White VARCHAR(64))
	
	INSERT INTO @GameTmp (GameID, Black, White) SELECT *
	FROM 
	(
		SELECT [User], Game, Color
		FROM (
			SELECT [User], Game, Color FROM Chess_Ranked WHERE Chess_Ranked.game = @GameID
			UNION
			SELECT [User], Game, Color FROM Chess_Casual WHERE Chess_Casual.game = @GameID
			) AS Records
	) AS Players
	PIVOT(
		MAX(Players.[User]) FOR Color in (Black, White)
	)PIV

	INSERT INTO @Game SELECT GameID, Black, White, Chess_GAME.Duration, PGN, Chess_Game.[Date], Chess_Game.[Time], Termination, Result, Chess_Format.[Name], Chess_Format.ClockTime, Chess_Format.ClockIncrement
	, Chess_Opening.ECOCode, Chess_Opening.[Name], Chess_Opening.Pattern, Chess_Tournament.[Name], Chess_Tournament.[Date]
	FROM 
	(
		@GameTmp 
		JOIN 
		Chess_Game ON GameID = Chess_Game.ID 
		JOIN
		Chess_Format ON Chess_Format.ID = Chess_Game.FormatID
		JOIN 
		Chess_Opening ON Chess_Opening.ID = Chess_Game.OpeningID
		LEFT OUTER JOIN
		Chess_Tournament ON Chess_Tournament.ID = Chess_Game.TournamentID
	)

	SELECT @TournamentDate = TournamentDate, @TournamentName = TournamentName FROM @Game 
	SELECT GameID, Black , White , Duration, PGN ,[Date], Termination, Result, FormatName, ClockTime, ClockIncrement, OpeningECOCode, OpeningName, OpeningPattern FROM @Game
END
GO

DECLARE @TournamentName VARCHAR(64)
DECLARE @TournamentDate DATE
DECLARE @TournamentTime TIME
EXEC pr_GetGameInfo 1001, @TournamentName OUTPUT, @TournamentDate OUTPUT, @TournamentTime OUTPUT

SELECT @TournamentName
SELECT @TournamentDate
GO

DROP PROCEDURE dbo.pr_newGame
GO

-- Create new Game of given format (of given tournament opcional)
-- Create new GameRecords
-- Inputs: ClockTime, ClockIncrement, Player name playing black, Player name playing white
--		   Type (0 casual, 1 ranked)
-- Acrescentar o possibilidade de definir o time?
-- Ver se ja esta num jogo

-- TRANSACTION ??
CREATE PROCEDURE dbo.pr_NewGame (@ClockTime INT, @ClockIncrement INT, @PlayerBlack VARCHAR(64), @PlayerWhite VARCHAR(64),
								 @TournamentID INT = NULL, @Type bit = 0)
AS
BEGIN
	BEGIN TRANSACTION
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
	
		INSERT INTO Chess_Game ([Date], [Time], FormatID, TournamentID) VALUES (@TodayDate, @TodayTime, @FormatID, @TournamentID)
		DECLARE @GameID INT = @@IDENTITY
		SELECT @GameID
		SELECT @BlackRating = CurrentRating FROM Chess_Classified WHERE FormatID = @FormatID AND [USER] = @PlayerBlack 
		SELECT @WhiteRating = CurrentRating FROM Chess_Classified WHERE FormatID = @FormatID AND [USER] = @PlayerWhite

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
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK
		DECLARE @ErrorMessage   NVARCHAR(4000) = ERROR_MESSAGE(),
				@ErrorState     INT = ERROR_STATE(),
				@ErrorSeverity  INT = ERROR_SEVERITY();

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
	END CATCH
END
GO

--Casual
EXEC pr_NewGame 3, 0, 'LuckyLucker', 'yassinetaoufiki', NULL, 0
--Ranked
EXEC pr_NewGame 3, 0, 'LuckyLucker', 'yassinetaoufiki', NULL, 1
SELECT * FROM Chess_Game
SELECT * FROM Chess_Casual
SELECT * FROM Chess_Ranked
GO

DROP FUNCTION dbo.udf_GetFormatID
GO

-- Private
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

DECLARE @FormatID INT
SET @FormatID = dbo.udf_GetFormatID(3, 0)
SELECT @FormatID

DROP FUNCTION dbo.udf_GetTournamentID
GO

-- TODO: Adicionar trigger para Name e Date no tournament

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



 