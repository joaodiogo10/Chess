DROP TRIGGER tr_onUserInserted
GO

CREATE TRIGGER tr_onUserInserted ON dbo.Chess_User
AFTER INSERT
AS
BEGIN
	DECLARE @insertedUsername VARCHAR(64)
	SELECT @insertedUsername = Username FROM inserted

	DECLARE @classifiedTable TABLE
	([User]			VARCHAR(64),
	 FormatID		INT)

	INSERT INTO @classifiedTable (FormatID)
	SELECT ID FROM Chess_Format

	UPDATE @classifiedTable SET [User] = @insertedUsername
	INSERT INTO Chess_Classified ([User], FormatID) SELECT * FROM @classifiedTable
END
GO	
