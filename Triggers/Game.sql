DROP TRIGGER tr_gameOnInsert
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