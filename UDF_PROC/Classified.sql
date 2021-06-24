DROP PROCEDURE dbo.pr_GetClassifiedUsersByFormat
DROP PROCEDURE dbo.pr_getTopElements 


GO
CREATE PROCEDURE dbo.pr_GetClassifiedUsersByFormat (@ClockTime INT, @ClockIncrement INT, @Top INT) 
AS
BEGIN
	DECLARE @FormatID INT
	
	SET @FormatID = dbo.udf_GetFormatID(@ClockTime, @ClockIncrement)
		IF (@FormatID IS NULL)
		BEGIN
			RAISERROR('Format doesnt exists', 16, 1)
		END

	SELECT TOP (@Top) [User], CurrentRating, MaxRating  FROM Chess_Classified WHERE FormatID = @FormatID ORDER BY CurrentRating DESC, [User]
END
GO
/* Test 
EXEC pr_GetClassifiedUsersByFormat 15, 10, 10

Select * FROM Chess_Format
SELECT * FROM Chess_Classified
GO */

CREATE PROCEDURE dbo.pr_getTopElements (@ClockTime INT, @ClockIncrement INT, @Top INT) 
AS
BEGIN
	DECLARE @formatID INT
	DECLARE @pos INT
	DECLARE @prevPos INT
	DECLARE @prevCurrRating INT
	DECLARE @currRating INT
	DECLARE @countEquals INT
	DECLARE @maxRating INT
	DECLARE @userName VARCHAR(64)
	DECLARE @prevUserName VARCHAR(64)
	DECLARE @PositionsTmp TABLE (Position INT, [User] VARCHAR(64), CurrentRating INT, MaxRating INT)
	
	SET @FormatID = dbo.udf_GetFormatID(@ClockTime, @ClockIncrement)
		IF (@FormatID IS NULL)
		BEGIN
			RAISERROR('Format doesnt exists', 16, 1)
		END

	DECLARE C CURSOR FAST_FORWARD
	FOR SELECT TOP (@Top) [User], CurrentRating, MaxRating  FROM Chess_Classified WHERE FormatID = @FormatID ORDER BY CurrentRating DESC, [User]

	OPEN C;

	FETCH C INTO @userName, @currRating, @maxRating

	SELECT @pos = 0, @prevPos = 0, @prevCurrRating = 0, @prevUserName = '', @countEquals = 1

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		IF @prevUserName <> @userName
		BEGIN
			PRINT @prevCurrRating
			print @currRating
			IF (@prevCurrRating = @currRating)
			BEGIN
				INSERT INTO @PositionsTmp VALUES (@pos, @userName, @currRating, @maxRating)
				SET @countEquals += 1
			END
			ELSE
			BEGIN

				IF (@countEquals <> 1)
				BEGIN
					SET @pos = @prevPos + @countEquals
					SET @countEquals = 1
				END
				ELSE
					SET @pos = @prevPos + 1

				SET @prevPos = @pos
				INSERT INTO @PositionsTmp VALUES (@pos, @userName, @currRating, @maxRating)
			END
			SELECT @prevUserName = @userName, @prevCurrRating = @currRating
		END;

		FETCH C INTO @userName, @currRating, @maxRating;
	END;
	CLOSE C;
	DEALLOCATE C;
	SELECT * FROM @PositionsTmp
END
GO
/* Test 
EXEC pr_getTopElements 15, 10, 10

UPDATE Chess_Classified
SET CurrentRating = 2862
WHERE [User] = 'rezi09' and FormatID = 8

Select * FROM Chess_Format
SELECT * FROM Chess_Classified
GO */
