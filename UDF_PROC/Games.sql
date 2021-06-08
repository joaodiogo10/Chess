DROP PROCEDURE pr_GetGameInfo
GO

-- get game info
CREATE PROCEDURE pr_GetGameInfo (@GameID INT) 
AS
BEGIN
	DECLARE @Game TABLE (GameID INT, Player1 VARCHAR(64), Player2 VARCHAR(64), Duration TIME, PGN VARCHAR(MAX),
							GameDate DATETIME, Outcome VARCHAR(64), FormatID INT, OpeningID INT, TournamentID INT)

	DECLARE @GameTmp TABLE (GameID INT, Player1 VARCHAR(64), Player2 VARCHAR(64))
	INSERT INTO @GameTmp (GameID, Player1, Player2) SELECT *
	FROM 
	(
		SELECT [User], Game, 'Player' + CAST(ROW_NUMBER() OVER (ORDER BY [User]) AS VARCHAR(7)) AS PlayerNum 
		FROM (
			SELECT [User], Game FROM Chess_Ranked WHERE Chess_Ranked.game = @GameID 
			UNION
			SELECT [User], Game FROM Chess_Casual WHERE Chess_Casual.game = @GameID 
			) AS Records
	) AS Players
	PIVOT(
		MAX(Players.[User]) FOR PlayerNum in (Player1, Player2)
	)PIV

	-- ?
	SELECT GameID, Player1, Player2, ID, Duration, PGN, GameDate, Outcome, FormatID, OpeningID, TournamentID FROM @GameTmp JOIN Chess_Game ON GameID = ID
	-- INSERT INTO @GAME SELECT GameID, Player1, Player2, Chess_Game.Duration, Chess_Game.PGN, Chess_Game.GameDate, Chess_Game.Outcome, Chess_Game.FormatID, Chess_Game.OpeningID, Chess_Game.TournamentID 
	-- FROM @GameTmp JOIN Chess_Game ON GameID = ID

	-- SELECT ECOCode, [Name], Pattern FROM @Game JOIN Chess_Opening ON OpeningID = Chess_Opening.ID
END
GO

EXEC pr_GetGameInfo 3
GO