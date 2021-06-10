DROP TRIGGER tr_onClassifiedUpdate
DROP TRIGGER tr_onClassifiedInsert
GO

-- Only update Current and Max ratings
-- TODO: RAISERROR if user tries to update others columns  
-- Missing position

CREATE TRIGGER tr_onClassifiedUpdate ON Chess_Classified
INSTEAD OF UPDATE
AS
BEGIN
	DECLARE @MaxRating INT, @NewRating INT, @FormatID INT
	DECLARE @User VARCHAR(64)

	SELECT @MaxRating = MaxRating, @User = [User], @FormatID = FormatID  FROM deleted
	SELECT @NewRating = CurrentRating FROM inserted
	
	IF(@NewRating > @MaxRating)
		SET @MaxRating = @NewRating
	
	UPDATE Chess_Classified SET MaxRating = @MaxRating, CurrentRating = @NewRating WHERE FormatID = @FormatID AND [User] = @User
END
GO

-- Missing position
CREATE TRIGGER tr_onClassifiedInsert ON Chess_Classified
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @Classified TABLE ([User] VARCHAR(64), FormatID INT, Position INT, MaxRating INT, CurrentRating INT)

	INSERT INTO @Classified ([User], FormatID) SELECT  [User], FormatID FROM inserted
	UPDATE @Classified SET MaxRating = 400, CurrentRating = 400 	
	
	INSERT INTO Chess_Classified ([User], FormatID, MaxRating, CurrentRating) 
	SELECT [User], FormatID, MaxRating, CurrentRating  FROM @Classified
END