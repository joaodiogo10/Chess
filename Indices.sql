DROP INDEX IxRankedGame ON Chess_Ranked
DROP INDEX IxCasualGame ON Chess_Casual
DROP INDEX IxGameTermination ON Chess_Game
GO
-- Indice para records (ranked e casual) para o registo de record de um determinado jogo, procura pelo game
CREATE INDEX IxRankedGame ON Chess_Ranked(Game)
GO
CREATE INDEX IxCasualGame ON Chess_Casual(Game)
GO

CREATE INDEX IxGameTermination ON Chess_Game(Termination) WHERE Termination IS NULL
GO


/*
DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
GO
SELECT * FROM Chess_Game WHERE Termination IS NULL
DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
GO
SELECT * FROM Chess_Game
GO
DBCC FREEPROCCACHE;
DBCC DROPCLEANBUFFERS;
GO
SELECT * FROM Chess_Opening WHERE [Name] = 'Zukertort Opening: St. George Defense'
GO */