DROP INDEX IxRankedGame ON Chess_Ranked
DROP INDEX IxCasualGame ON Chess_Casual
DROP INDEX IxGameTermination ON Chess_Game
DROP INDEX IxRankedUserIncGame ON Chess_ranked
DROP INDEX IxCasualUserIncGame ON Chess_ranked
GO
-- Indice para records (ranked e casual) para o registo de record de um determinado jogo, na procura de dados do jogo
CREATE INDEX IxRankedGame ON Chess_Ranked(Game)
GO
CREATE INDEX IxCasualGame ON Chess_Casual(Game)
GO

-- Indice para on going matches
CREATE INDEX IxGameTermination ON Chess_Game(Termination) WHERE Termination IS NULL
GO

-- Indices para obter os jogos de determinado utilizador atrav�s dos seus records
CREATE INDEX IxRankedUserIncGame ON Chess_Ranked([User]) INCLUDE (Game)
CREATE INDEX IxCasualUserIncGame ON Chess_Casual([User]) INCLUDE (Game)

---xx Chess_Opening: Adicionar Index para name
-- nao pq � unique e ele cria um indice automaticamente

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