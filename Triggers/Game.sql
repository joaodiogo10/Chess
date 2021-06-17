DROP TRIGGER tr_gameOnInsert
DROP TRIGGER tr_gameOnUpdate
GO
CREATE TRIGGER tr_gameOnInsert ON Chess_Game
INSTEAD OF INSERT
AS
BEGIN
	INSERT INTO Chess_Game (
      [Duration]
      ,[PGN]
      ,[Date]
      ,[Time]
      ,[Termination]
      ,[Result]
      ,[FormatID]
      ,[OpeningID]
      ,[TournamentID]) 
	 SELECT Duration, PGN, [Date], [Time], UPPER(Termination), UPPER(Result), FormatID, OpeningID, TournamentID FROM inserted
END
GO

CREATE TRIGGER tr_gameOnUpdate ON Chess_Game
INSTEAD OF UPDATE
AS
BEGIN 
	UPDATE Chess_Game
	SET Duration = inserted.Duration, PGN = inserted.PGN, Termination = UPPER(inserted.Termination), Result = UPPER(inserted.Result) 
	FROM inserted
	WHERE Chess_Game.ID = inserted.ID
END
GO