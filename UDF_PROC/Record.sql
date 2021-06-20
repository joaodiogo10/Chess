DROP PROC pr_CreateRecord
DROP FUNCTION dbo.udf_Probability
DROP FUNCTION dbo.udf_EloRating
GO

-- Calculate winning probability of a Player to win
-- @R1: Oponnent rating
-- @R2: Player rating
CREATE FUNCTION dbo.udf_Probability(@R1 INT, @R2 INT) RETURNS DECIMAL(3,2)
AS
BEGIN
	RETURN 1.00 * (1.00 / (1.00 + 1.00 * POWER(10.00, 1.00 * (@R1 - @R2) / 400)))
END
GO


CREATE FUNCTION dbo.udf_EloRating(@R1 INT, @R2 INT, @Winner bit, @K INT) RETURNS @ELOs TABLE (ELOP1 INT, ELOP2 INT)
AS
BEGIN
	DECLARE @P1 DECIMAL(3,2), @P2 DECIMAL(3,2)
	-- Winning probability of Player 1 
	SET @P1 = dbo.udf_Probability(@R2, @R1)
	-- Winning probability of Player 2 
	SET @P2 = dbo.udf_Probability(@R1, @R2)
	
	-- Player 1 wins
	IF(@Winner = 0)
	BEGIN
		SET @R1 = @R1 + @K * (1 - @P1)
		SET @R2 = @R2 + @K * (0 - @P2)
	END
	-- Player 2 wins
	ELSE
	BEGIN
		SET @R1 = @R1 + @K * (0 - @P1)
		SET @R2 = @R2 + @K * (1 - @P2)
	END
	INSERT INTO @ELOs VALUES (@R1, @R2)
	RETURN
END
GO

/* Test
DECLARE @RBlack INT = 1200, @RWhite INT = 1200
DECLARE @NewRBlack DECIMAL(3,2), @NewRWhite DECIMAL(3,2)
DECLARE @K INT = 30

-- Black wins
SELECT ELOP1 AS Black, ELOP2 AS White FROM dbo.udf_EloRating(@RBlack, @RWhite, 0, @K)

-- White wins
SELECT ELOP1 AS Black, ELOP2 AS White FROM dbo.udf_EloRating(@RBlack, @RWhite, 1, @K)

*/

CREATE PROC pr_CreateRecord (@Duration VARCHAR(5), @PGN VARCHAR(MAX), @Termination VARCHAR(64), @OpeningName VARCHAR(128),
								  @GameID INT, @Result VARCHAR(5))
AS
BEGIN
	BEGIN TRY
		DECLARE @PBlack VARCHAR(64), @PWhite VARCHAR(64)
		DECLARE @RBlack INT, @RWhite INT
		DECLARE @NewRBlack INT, @NewRWhite INT
		DECLARE @K INT = 20
		DECLARE @FormatID INT, @OpeningID INT 
		
		-- Get game format
		SELECT @FormatID = FormatID FROM Chess_Game WHERE ID = @GameID	
		IF(@FormatID IS NULL)
			RAISERROR ('Game doesnt exist', 16, 1)

		DECLARE @tmp VARCHAR(64) = NULL
		--Check if record as already been created
		SELECT @tmp = Termination  FROM Chess_Game WHERE ID = @GameID 
		IF(NOT @tmp IS NULL)
			RAISERROR ('Record already created', 16, 1)

		-- Get Opening Name
		SELECT @OpeningID = ID FROM Chess_Opening WHERE [NAME] = @OpeningName 
		IF(@OpeningID IS NULL)
			RAISERROR ('Opening doesnt exist', 16, 1)

		DECLARE @PlayersTable TABLE (Username VARCHAR(64), Color VARCHAR(5))


		BEGIN TRANSACTION AddRecord
		-- Get Players
		-- Check type
		
		-- IF Casual
		INSERT INTO @PlayersTable SELECT [User], Color FROM Chess_Casual WHERE Game = @GameID
		IF(@@ROWCOUNT > 0)
			UPDATE Chess_Game SET Duration = @Duration, PGN = @PGN, Termination = @Termination, Result = @Result, OpeningID = @OpeningID
				   WHERE Chess_Game.ID = @GameID
		-- IF Ranked
		ELSE
		BEGIN
			INSERT INTO @PlayersTable SELECT [User], Color FROM Chess_Ranked WHERE Game = @GameID

			-- Get black current rating
			SELECT @RBlack = CurrentRating, @PBlack = [User]
			FROM 
			Chess_Classified JOIN @PlayersTable ON Chess_Classified.[User] = Username
			WHERE [Color] = 'BLACK' AND FormatID = @FormatID

			-- Get white current rating
			SELECT @RWhite = CurrentRating, @PWhite = [User] 
			FROM 
			Chess_Classified JOIN @PlayersTable ON Chess_Classified.[User] = Username
			WHERE [Color] = 'WHITE' AND FormatID = @FormatID

			-- Black wins
			IF(@Result = 'BLACK')
				SELECT @NewRBlack = ELOP1, @NewRWhite = ELOP2 FROM dbo.udf_EloRating(@RBlack, @RWhite, 0, @K)
			-- White wins
			ELSE IF (@Result = 'WHITE')
				SELECT @NewRBlack = ELOP1, @NewRWhite = ELOP2 FROM dbo.udf_EloRating(@RBlack, @RWhite, 1, @K)
			-- Draw 
			ELSE
			BEGIN
				SET @NewRBlack =  @RBlack
				SET @NewRWhite =  @RWhite
			END
			--Make updates
			UPDATE Chess_Ranked SET EarnedRating = (@NewRBlack - @RBlack) WHERE GAME = @GameID AND [USER] = @PBlack
			UPDATE Chess_Ranked SET EarnedRating = (@NewRWhite - @RWhite) WHERE GAME = @GameID AND [USER] = @PWhite
			UPDATE Chess_Classified SET CurrentRating = @NEWRBlack WHERE [USER] = @PBlack AND [FormatID] = @FormatID
			UPDATE Chess_Classified SET CurrentRating = @NEWRWhite WHERE [USER] = @PWhite AND [FormatID] = @FormatID
			UPDATE Chess_Game SET Duration = @Duration, PGN = @PGN, Termination = @Termination, Result = @Result, OpeningID = @OpeningID
				   WHERE Chess_Game.ID = @GameID
		END
		COMMIT TRANSACTION AddRecord
	
	END TRY
	BEGIN CATCH 
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION AddRecord
		END 
		DECLARE @ErrorMessage   NVARCHAR(4000) = ERROR_MESSAGE(),
				@ErrorState     INT = ERROR_STATE(),
				@ErrorSeverity  INT = ERROR_SEVERITY();

		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
	END CATCH
END
GO
/* Test 
DECLARE @DURATION VARCHAR(5), @PGN VARCHAR(MAX), @Termination VARCHAR(64),
	    @OpeningName VARCHAR(128), @GameID INT, @Result VARCHAR(5)
SET @DURATION = '00:30:00'
SET @PGN = 'PGN test'
SET @Termination = 'NORmaL'
SET @OpeningName = 'Alekhine Defense'
SET @GameID = 11949
SET @Result = 'WHITE'

EXEC pr_CreateRecord @Duration, @PGN, @Termination, @OpeningName, @GameID, @Result
SELECT * FROM Chess_Casual
SELECT * FROM Chess_Game
SELECT * FROM Chess_Ranked 
SELECT * FROM Chess_Classified WHERE [User] = 'maximederkek' OR [User] = 'bahodiraxmedov'
SELECT * FROM Chess_Opening
GO

*/
