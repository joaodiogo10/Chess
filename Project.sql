USE Chess
GO

DROP TABLE Chess_PuzzleRecord
DROP TABLE Chess_PuzzleTheme
DROP TABLE Chess_Puzzle
DROP TABLE Chess_Theme
DROP TABLE Chess_Classified
DROP TABLE Chess_Casual
DROP TABLE Chess_Ranked
DROP TABLE Chess_Game
DROP TABLE Chess_Opening
DROP TABLE Chess_TournamentParticipation
DROP TABLE Chess_Tournament
DROP TABLE Chess_Format
DROP TABLE Chess_Member
DROP TABLE Chess_Team
DROP TABLE Chess_Friends
DROP TABLE Chess_UserTitle
DROP TABLE Chess_User
Go

CREATE TABLE Chess_User (
	Username				 VARCHAR(64) NOT NULL,
	[Password]				 BINARY(32) NOT NULL,
	[Name]					 VARCHAR(128) NOT NULL,
	Country					 VARCHAR(64) NOT NULL,
	Email					 VARCHAR(128) UNIQUE NOT NULL,
	RegistrationDate		 DATE NOT NULL,
	MaxPuzzleRating			 INT NOT NULL DEFAULT 400,
	CurrentPuzzleRating		 INT NOT NULL DEFAULT 400,
	CHECK(MaxPuzzleRating >= 0 AND MaxPuzzleRating >= CurrentPuzzleRating),
	CHECK(CurrentPuzzleRating >= 0),
	PRIMARY KEY(Username)
)
GO

-- restringir titles ??
CREATE TABLE Chess_UserTitle (
	[User] 	VARCHAR(64) NOT NULL,
	Title	VARCHAR(64) NOT NULL,
	PRIMARY KEY([User])
)	

CREATE TABLE Chess_Friends (
	SUsername	VARCHAR(64) NOT NULL,
	TUsername	VARCHAR(64) NOT NULL,
	PRIMARY KEY (SUsername, TUsername)
)
GO

-- acrescentar hora
CREATE TABLE Chess_Tournament (
	ID						 INT NOT NULL IDENTITY(1,1),
	[Name]					 VARCHAR(64) NOT NULL,
	[Date]					 DATE NOT NULL,
	[Time]					 TIME NOT NULL,
	Duration				 INT NOT NULL,
	[Description]			 VARCHAR(2048),
	MaxRating				 INT DEFAULT NULL,
	MinRating				 INT DEFAULT NULL,
	FormatID				 INT,
	CHECK(MaxRating >= 0),
	CHECK(MinRating >= 0),
	CHECK(MaxRating >= MinRating),
	PRIMARY KEY(ID),
	UNIQUE([Name], [Date], [Time])
)
GO

CREATE TABLE Chess_TournamentParticipation (
	Tournament				 INT NOT NULL,
	[User]					 VARCHAR(64) NOT NULL,
	Position				 INT,
	Points					 INT NOT NULL DEFAULT 0,
	CHECK(Points >= 0),
	CHECK(Position >= 0),
	PRIMARY KEY (Tournament, [User])
)
GO

-- Primary key = ID
CREATE TABLE Chess_Casual (
	ID						 INT NOT NULL IDENTITY(1,1),  --?
	[User]					 VARCHAR(64) NOT NULL,
	Game					 INT NOT NULL,
	Color					 VARCHAR(5) NOT NULL,
	PRIMARY KEY (ID),
	--CHECK (Color = "White" OR Color = "Black") --?
)
GO

-- DEFAULT NULL provisorio
CREATE TABLE Chess_Ranked (
	ID						 INT NOT NULL IDENTITY(1,1), --?
	[User]					 VARCHAR(64) NOT NULL,
	Game					 INT NOT NULL,
	Color					 VARCHAR(5) NOT NULL,
	Rating					 INT NOT NULL,
	EarnedRating			 INT DEFAULT NULL,
	PRIMARY KEY (ID),
	CHECK(Rating >= 0),
	-- CHECK (Color = "White" OR Color = "Black") --?
)
GO


-- todos os jogadores devem estar classificados em todos os formatos
CREATE TABLE Chess_Classified (
	[User]					 VARCHAR(64) NOT NULL,
	[FormatID]				 INT NOT NULL,
	Position				 INT NOT NULL DEFAULT 0,
	MaxRating				 INT NOT NULL DEFAULT 400,
	CurrentRating			 INT NOT NULL DEFAULT 400,
	CHECK(Position >= 0),
	CHECK(MaxRating >= 0 AND MaxRating >= CurrentRating),
	CHECK(CurrentRating >= 0),
	PRIMARY KEY ([FormatID], [User])
)
GO

CREATE TABLE Chess_Team (
    [Name]				VARCHAR(128),
	Leader				VARCHAR(64) NOT NULL,
    [Description]		VARCHAR(MAX),
	PRIMARY KEY([Name])
)

CREATE TABLE Chess_Member (
    Team		VARCHAR(128),
    [User]		VARCHAR(64),
	PRIMARY KEY(Team, [User])
)

-- DEFAUL 0 provisorio
CREATE TABLE Chess_PuzzleRecord (
    ID				INT IDENTITY(1,1),
    [User]			VARCHAR(64),
    [Date]			DATE NOT NULL,
	[Time]			TIME NOT NULL,
    Rating			INT	NOT NULL,		
    EarnedRating	INT NOT NULL DEFAULT 0,
    PuzzleID		INT NOT NULL,
	CHECK(Rating >= 0),
	PRIMARY KEY(ID, [User])
)

CREATE TABLE Chess_Puzzle (
    ID			INT IDENTITY(1,1),
    Rating		INT	NOT NULL,
    InicialPlay VARCHAR(256) NOT NULL,
    Solution	VARCHAR(256) NOT NULL,
    GameID		INT NOT NULL,
	CHECK(Rating >= 0),
	PRIMARY KEY(ID)
)

CREATE TABLE Chess_PuzzleTheme (
	PuzzleID	INT,
	ThemeID		INT,
	PRIMARY KEY(PuzzleID, ThemeID)
)

CREATE TABLE Chess_Theme (
	ID		INT	IDENTITY(1,1),
	[Name]	VARCHAR(64),
	PRIMARY KEY(ID)
)
-- Adcionei Result
CREATE TABLE Chess_Game (
	ID				INT IDENTITY(1,1),
	Duration		TIME,
	PGN				VARCHAR(MAX),
	[Date]			DATE NOT NULL,
	[Time]			TIME NOT NULL,
	Termination		VARCHAR(64), 
	Result			VARCHAR(5),
	FormatID		INT NOT NULL,
	OpeningID		INT,
	TournamentID	INT,
	PRIMARY KEY(ID),
	CHECK (Result = 'BLACK' OR Result = 'WHITE' OR RESULT = 'DRAW'),
	-- CHECK (termination = 'TIME FORFEIT' OR termination = 'NORMAL' OR termination = 'ABANDONED' OR termination = 'RULES INFRACTION')
)

CREATE TABLE Chess_Opening (
	ID		INT IDENTITY(1,1),
	ECOCode VARCHAR(3)	NOT NULL,
	[Name]	VARCHAR(128) NOT NULL UNIQUE,
	Pattern VARCHAR(1024) NOT NULL UNIQUE,
	PRIMARY KEY(ID)
)

CREATE TABLE Chess_Format (
	ID				INT IDENTITY(1,1),
	[Name]			VARCHAR(64),
	ClockTime		INT	NOT NULL,
	ClockIncrement	INT NOT NULL,
	CHECK(ClockTime >= 0),
	CHECK(ClockIncrement >= 0),
	UNIQUE(ClockTime,ClockIncrement),
	PRIMARY KEY(ID)
)
GO

ALTER TABLE Chess_UserTitle ADD CONSTRAINT FK_UserTitile_User_User
FOREIGN KEY([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Friends ADD CONSTRAINT FK_FriendsSUser_User_SUsername
FOREIGN KEY(SUsername) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Friends ADD CONSTRAINT FK_FriendsTUser_User_TUsername
FOREIGN KEY(TUsername) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Tournament ADD CONSTRAINT FK_TournamentFormat_FormatID
FOREIGN KEY(FormatID) REFERENCES Chess_Format(ID)

ALTER TABLE Chess_TournamentParticipation ADD CONSTRAINT FK_TournamentParticipationTournament_Tournament
FOREIGN KEY(Tournament) REFERENCES Chess_Tournament(ID)
GO

ALTER TABLE Chess_TournamentParticipation ADD CONSTRAINT FK_TournamentParticipationUser_User_User
FOREIGN KEY([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Casual ADD CONSTRAINT FK_CasualUser_User_User
FOREIGN KEY([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Casual ADD CONSTRAINT FK_CasualGame_Game
FOREIGN KEY(Game) REFERENCES Chess_Game(ID)
GO


ALTER TABLE Chess_Ranked ADD CONSTRAINT FK_RankedUser_User_User
FOREIGN KEY([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Ranked ADD CONSTRAINT FK_RankedGame_Game
FOREIGN KEY(Game) REFERENCES Chess_Game(ID)
GO

ALTER TABLE Chess_Classified ADD CONSTRAINT FK_ClassifiedUser_User
FOREIGN KEY([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Classified ADD CONSTRAINT FK_ClassifiedFormat_FormatID
FOREIGN KEY([FormatID]) REFERENCES Chess_Format(ID)
GO

ALTER TABLE Chess_Team ADD CONSTRAINT FK_TeamUser_Leader
FOREIGN KEY ([Leader]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Member ADD CONSTRAINT FK_MemberTeam_Team 
FOREIGN KEY (Team) REFERENCES Chess_Team([Name])

ALTER TABLE Chess_Member ADD CONSTRAINT FK_MemberUser_User
FOREIGN KEY ([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_PuzzleRecord ADD CONSTRAINT FK_PuzzleRecordPuzzle_ID
FOREIGN KEY(PuzzleID) REFERENCES Chess_PUZZLE(ID)

ALTER TABLE Chess_PuzzleRecord ADD CONSTRAINT FK_PuzzleRecordUser_User
FOREIGN KEY ([User]) REFERENCES Chess_User(Username)
GO

ALTER TABLE Chess_Puzzle ADD CONSTRAINT FL_PuzzleGame_GameID 
FOREIGN KEY (GameID) REFERENCES Chess_GAME(ID)
GO

ALTER TABLE Chess_PuzzleTheme ADD CONSTRAINT FK_PuzzleThemePuzzle_PuzzleID
FOREIGN KEY (PuzzleID) REFERENCES Chess_PUZZLE(ID)
GO

ALTER TABLE Chess_PuzzleTheme ADD CONSTRAINT FK_PuzzleThemeTheme_ThemeID
FOREIGN KEY (ThemeID) REFERENCES Chess_Theme(ID)
GO

ALTER TABLE Chess_Game ADD CONSTRAINT FK_GameOpening_OpeningID
FOREIGN KEY (OpeningID) REFERENCES Chess_Opening(ID)
ALTER TABLE Chess_Game ADD CONSTRAINT Fk_GameFormat_FormatID
FOREIGN KEY (FormatID) REFERENCES Chess_Format(ID)
GO
ALTER TABLE Chess_Game ADD CONSTRAINT FK_GameTournament_TournamentID
FOREIGN KEY(TournamentID) REFERENCES Chess_Tournament(ID)
GO

Select * FROM Chess_PuzzleRecord
Select * FROM Chess_PuzzleTheme
Select * FROM Chess_Puzzle
Select * FROM Chess_Theme
Select * FROM Chess_Classified ORDER BY [USER]
Select * FROM Chess_Casual
Select * FROM Chess_Ranked
Select * FROM Chess_Game
Select * FROM Chess_Opening
Select * FROM Chess_TournamentParticipation
Select * FROM Chess_Tournament
Select * FROM Chess_Format
Select * FROM Chess_Member
Select * FROM Chess_Team
Select * FROM Chess_Friends
Select * FROM Chess_UserTitle
Select * FROM Chess_User
