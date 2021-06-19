<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Games
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonSearchGame = New System.Windows.Forms.Button()
        Me.LabelSearchGame = New System.Windows.Forms.Label()
        Me.TextBoxSearchGame = New System.Windows.Forms.TextBox()
        Me.TextBoxBlack = New System.Windows.Forms.TextBox()
        Me.LabelBlack = New System.Windows.Forms.Label()
        Me.vs = New System.Windows.Forms.Label()
        Me.LabelWhite = New System.Windows.Forms.Label()
        Me.TextBoxWhite = New System.Windows.Forms.TextBox()
        Me.LabelDuration = New System.Windows.Forms.Label()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.LabelDateGame = New System.Windows.Forms.Label()
        Me.TextBoxDateGame = New System.Windows.Forms.TextBox()
        Me.LabelOpeningName = New System.Windows.Forms.Label()
        Me.TextBoxOpeningName = New System.Windows.Forms.TextBox()
        Me.LabelOpeningCode = New System.Windows.Forms.Label()
        Me.TextBoxOpeningCode = New System.Windows.Forms.TextBox()
        Me.LabelFormat = New System.Windows.Forms.Label()
        Me.TextBoxFormat = New System.Windows.Forms.TextBox()
        Me.LabelTermination = New System.Windows.Forms.Label()
        Me.TextBoxTermination = New System.Windows.Forms.TextBox()
        Me.TextBoxClockIncrement = New System.Windows.Forms.TextBox()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.TextBoxClockTime = New System.Windows.Forms.TextBox()
        Me.TextBoxTournamentName = New System.Windows.Forms.TextBox()
        Me.LabelTournamentName = New System.Windows.Forms.Label()
        Me.LabelDateTournament = New System.Windows.Forms.Label()
        Me.TextBoxDateTournament = New System.Windows.Forms.TextBox()
        Me.GroupBoxTournament = New System.Windows.Forms.GroupBox()
        Me.LabelWinner = New System.Windows.Forms.Label()
        Me.TextBoxWinner = New System.Windows.Forms.TextBox()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.ListBoxOngoingMatches = New System.Windows.Forms.ListBox()
        Me.LabelOngoingMatches = New System.Windows.Forms.Label()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.ButtonDeclareMatch = New System.Windows.Forms.Button()
        Me.LabelIdentifier = New System.Windows.Forms.Label()
        Me.LabelGameID = New System.Windows.Forms.Label()
        Me.ButtonNewGame = New System.Windows.Forms.Button()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.TextBoxPGN = New System.Windows.Forms.TextBox()
        Me.LabelPGN = New System.Windows.Forms.Label()
        Me.GroupBoxTournament.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSearchGame
        '
        Me.ButtonSearchGame.Location = New System.Drawing.Point(236, 44)
        Me.ButtonSearchGame.Name = "ButtonSearchGame"
        Me.ButtonSearchGame.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearchGame.TabIndex = 23
        Me.ButtonSearchGame.Text = "Search"
        Me.ButtonSearchGame.UseVisualStyleBackColor = True
        '
        'LabelSearchGame
        '
        Me.LabelSearchGame.AutoSize = True
        Me.LabelSearchGame.Location = New System.Drawing.Point(29, 27)
        Me.LabelSearchGame.Name = "LabelSearchGame"
        Me.LabelSearchGame.Size = New System.Drawing.Size(106, 15)
        Me.LabelSearchGame.TabIndex = 22
        Me.LabelSearchGame.Text = "Search by Game ID"
        '
        'TextBoxSearchGame
        '
        Me.TextBoxSearchGame.Location = New System.Drawing.Point(29, 45)
        Me.TextBoxSearchGame.Name = "TextBoxSearchGame"
        Me.TextBoxSearchGame.Size = New System.Drawing.Size(191, 23)
        Me.TextBoxSearchGame.TabIndex = 21
        '
        'TextBoxBlack
        '
        Me.TextBoxBlack.Location = New System.Drawing.Point(402, 88)
        Me.TextBoxBlack.Name = "TextBoxBlack"
        Me.TextBoxBlack.ReadOnly = True
        Me.TextBoxBlack.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxBlack.TabIndex = 24
        '
        'LabelBlack
        '
        Me.LabelBlack.AutoSize = True
        Me.LabelBlack.Location = New System.Drawing.Point(402, 70)
        Me.LabelBlack.Name = "LabelBlack"
        Me.LabelBlack.Size = New System.Drawing.Size(35, 15)
        Me.LabelBlack.TabIndex = 25
        Me.LabelBlack.Text = "Black"
        '
        'vs
        '
        Me.vs.AutoSize = True
        Me.vs.Location = New System.Drawing.Point(531, 91)
        Me.vs.Name = "vs"
        Me.vs.Size = New System.Drawing.Size(18, 15)
        Me.vs.TabIndex = 26
        Me.vs.Text = "vs"
        '
        'LabelWhite
        '
        Me.LabelWhite.AutoSize = True
        Me.LabelWhite.Location = New System.Drawing.Point(555, 73)
        Me.LabelWhite.Name = "LabelWhite"
        Me.LabelWhite.Size = New System.Drawing.Size(38, 15)
        Me.LabelWhite.TabIndex = 28
        Me.LabelWhite.Text = "White"
        '
        'TextBoxWhite
        '
        Me.TextBoxWhite.Location = New System.Drawing.Point(555, 91)
        Me.TextBoxWhite.Name = "TextBoxWhite"
        Me.TextBoxWhite.ReadOnly = True
        Me.TextBoxWhite.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxWhite.TabIndex = 27
        '
        'LabelDuration
        '
        Me.LabelDuration.AutoSize = True
        Me.LabelDuration.Location = New System.Drawing.Point(402, 124)
        Me.LabelDuration.Name = "LabelDuration"
        Me.LabelDuration.Size = New System.Drawing.Size(53, 15)
        Me.LabelDuration.TabIndex = 30
        Me.LabelDuration.Text = "Duration"
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(402, 142)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.ReadOnly = True
        Me.TextBoxDuration.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxDuration.TabIndex = 29
        '
        'LabelDateGame
        '
        Me.LabelDateGame.AutoSize = True
        Me.LabelDateGame.Location = New System.Drawing.Point(555, 124)
        Me.LabelDateGame.Name = "LabelDateGame"
        Me.LabelDateGame.Size = New System.Drawing.Size(31, 15)
        Me.LabelDateGame.TabIndex = 32
        Me.LabelDateGame.Text = "Date"
        '
        'TextBoxDateGame
        '
        Me.TextBoxDateGame.Location = New System.Drawing.Point(555, 142)
        Me.TextBoxDateGame.Name = "TextBoxDateGame"
        Me.TextBoxDateGame.ReadOnly = True
        Me.TextBoxDateGame.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxDateGame.TabIndex = 31
        '
        'LabelOpeningName
        '
        Me.LabelOpeningName.AutoSize = True
        Me.LabelOpeningName.Location = New System.Drawing.Point(402, 227)
        Me.LabelOpeningName.Name = "LabelOpeningName"
        Me.LabelOpeningName.Size = New System.Drawing.Size(88, 15)
        Me.LabelOpeningName.TabIndex = 34
        Me.LabelOpeningName.Text = "Opening Name"
        '
        'TextBoxOpeningName
        '
        Me.TextBoxOpeningName.Location = New System.Drawing.Point(402, 245)
        Me.TextBoxOpeningName.Name = "TextBoxOpeningName"
        Me.TextBoxOpeningName.ReadOnly = True
        Me.TextBoxOpeningName.Size = New System.Drawing.Size(282, 23)
        Me.TextBoxOpeningName.TabIndex = 33
        '
        'LabelOpeningCode
        '
        Me.LabelOpeningCode.AutoSize = True
        Me.LabelOpeningCode.Location = New System.Drawing.Point(701, 227)
        Me.LabelOpeningCode.Name = "LabelOpeningCode"
        Me.LabelOpeningCode.Size = New System.Drawing.Size(84, 15)
        Me.LabelOpeningCode.TabIndex = 36
        Me.LabelOpeningCode.Text = "Opening Code"
        '
        'TextBoxOpeningCode
        '
        Me.TextBoxOpeningCode.Location = New System.Drawing.Point(701, 245)
        Me.TextBoxOpeningCode.Name = "TextBoxOpeningCode"
        Me.TextBoxOpeningCode.ReadOnly = True
        Me.TextBoxOpeningCode.Size = New System.Drawing.Size(84, 23)
        Me.TextBoxOpeningCode.TabIndex = 35
        '
        'LabelFormat
        '
        Me.LabelFormat.AutoSize = True
        Me.LabelFormat.Location = New System.Drawing.Point(402, 281)
        Me.LabelFormat.Name = "LabelFormat"
        Me.LabelFormat.Size = New System.Drawing.Size(45, 15)
        Me.LabelFormat.TabIndex = 40
        Me.LabelFormat.Text = "Format"
        '
        'TextBoxFormat
        '
        Me.TextBoxFormat.Location = New System.Drawing.Point(402, 299)
        Me.TextBoxFormat.Name = "TextBoxFormat"
        Me.TextBoxFormat.ReadOnly = True
        Me.TextBoxFormat.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxFormat.TabIndex = 39
        '
        'LabelTermination
        '
        Me.LabelTermination.AutoSize = True
        Me.LabelTermination.Location = New System.Drawing.Point(402, 176)
        Me.LabelTermination.Name = "LabelTermination"
        Me.LabelTermination.Size = New System.Drawing.Size(70, 15)
        Me.LabelTermination.TabIndex = 38
        Me.LabelTermination.Text = "Termination"
        '
        'TextBoxTermination
        '
        Me.TextBoxTermination.Location = New System.Drawing.Point(402, 194)
        Me.TextBoxTermination.Name = "TextBoxTermination"
        Me.TextBoxTermination.ReadOnly = True
        Me.TextBoxTermination.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxTermination.TabIndex = 37
        '
        'TextBoxClockIncrement
        '
        Me.TextBoxClockIncrement.Location = New System.Drawing.Point(716, 299)
        Me.TextBoxClockIncrement.Name = "TextBoxClockIncrement"
        Me.TextBoxClockIncrement.ReadOnly = True
        Me.TextBoxClockIncrement.Size = New System.Drawing.Size(69, 23)
        Me.TextBoxClockIncrement.TabIndex = 43
        '
        'LabelClock
        '
        Me.LabelClock.AutoSize = True
        Me.LabelClock.Location = New System.Drawing.Point(587, 302)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(46, 15)
        Me.LabelClock.TabIndex = 42
        Me.LabelClock.Text = "Clock : "
        '
        'TextBoxClockTime
        '
        Me.TextBoxClockTime.Location = New System.Drawing.Point(639, 299)
        Me.TextBoxClockTime.Name = "TextBoxClockTime"
        Me.TextBoxClockTime.ReadOnly = True
        Me.TextBoxClockTime.Size = New System.Drawing.Size(71, 23)
        Me.TextBoxClockTime.TabIndex = 41
        '
        'TextBoxTournamentName
        '
        Me.TextBoxTournamentName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxTournamentName.Location = New System.Drawing.Point(18, 51)
        Me.TextBoxTournamentName.Name = "TextBoxTournamentName"
        Me.TextBoxTournamentName.ReadOnly = True
        Me.TextBoxTournamentName.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxTournamentName.TabIndex = 44
        '
        'LabelTournamentName
        '
        Me.LabelTournamentName.AutoSize = True
        Me.LabelTournamentName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTournamentName.Location = New System.Drawing.Point(18, 33)
        Me.LabelTournamentName.Name = "LabelTournamentName"
        Me.LabelTournamentName.Size = New System.Drawing.Size(39, 15)
        Me.LabelTournamentName.TabIndex = 46
        Me.LabelTournamentName.Text = "Name"
        '
        'LabelDateTournament
        '
        Me.LabelDateTournament.AutoSize = True
        Me.LabelDateTournament.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDateTournament.Location = New System.Drawing.Point(197, 33)
        Me.LabelDateTournament.Name = "LabelDateTournament"
        Me.LabelDateTournament.Size = New System.Drawing.Size(31, 15)
        Me.LabelDateTournament.TabIndex = 48
        Me.LabelDateTournament.Text = "Date"
        '
        'TextBoxDateTournament
        '
        Me.TextBoxDateTournament.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxDateTournament.Location = New System.Drawing.Point(197, 51)
        Me.TextBoxDateTournament.Name = "TextBoxDateTournament"
        Me.TextBoxDateTournament.ReadOnly = True
        Me.TextBoxDateTournament.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxDateTournament.TabIndex = 47
        '
        'GroupBoxTournament
        '
        Me.GroupBoxTournament.Controls.Add(Me.TextBoxTournamentName)
        Me.GroupBoxTournament.Controls.Add(Me.LabelDateTournament)
        Me.GroupBoxTournament.Controls.Add(Me.TextBoxDateTournament)
        Me.GroupBoxTournament.Controls.Add(Me.LabelTournamentName)
        Me.GroupBoxTournament.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxTournament.Location = New System.Drawing.Point(32, 349)
        Me.GroupBoxTournament.Name = "GroupBoxTournament"
        Me.GroupBoxTournament.Size = New System.Drawing.Size(352, 95)
        Me.GroupBoxTournament.TabIndex = 49
        Me.GroupBoxTournament.TabStop = False
        Me.GroupBoxTournament.Text = "Tournament"
        Me.GroupBoxTournament.Visible = False
        '
        'LabelWinner
        '
        Me.LabelWinner.AutoSize = True
        Me.LabelWinner.Location = New System.Drawing.Point(555, 176)
        Me.LabelWinner.Name = "LabelWinner"
        Me.LabelWinner.Size = New System.Drawing.Size(45, 15)
        Me.LabelWinner.TabIndex = 51
        Me.LabelWinner.Text = "Winner"
        '
        'TextBoxWinner
        '
        Me.TextBoxWinner.Location = New System.Drawing.Point(555, 194)
        Me.TextBoxWinner.Name = "TextBoxWinner"
        Me.TextBoxWinner.ReadOnly = True
        Me.TextBoxWinner.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxWinner.TabIndex = 50
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(701, 124)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(33, 15)
        Me.LabelTime.TabIndex = 53
        Me.LabelTime.Text = "Time"
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(701, 142)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.ReadOnly = True
        Me.TextBoxTime.Size = New System.Drawing.Size(84, 23)
        Me.TextBoxTime.TabIndex = 52
        '
        'ListBoxOngoingMatches
        '
        Me.ListBoxOngoingMatches.FormattingEnabled = True
        Me.ListBoxOngoingMatches.ItemHeight = 15
        Me.ListBoxOngoingMatches.Location = New System.Drawing.Point(32, 143)
        Me.ListBoxOngoingMatches.Name = "ListBoxOngoingMatches"
        Me.ListBoxOngoingMatches.Size = New System.Drawing.Size(287, 154)
        Me.ListBoxOngoingMatches.TabIndex = 54
        '
        'LabelOngoingMatches
        '
        Me.LabelOngoingMatches.AutoSize = True
        Me.LabelOngoingMatches.Location = New System.Drawing.Point(32, 125)
        Me.LabelOngoingMatches.Name = "LabelOngoingMatches"
        Me.LabelOngoingMatches.Size = New System.Drawing.Size(105, 15)
        Me.LabelOngoingMatches.TabIndex = 55
        Me.LabelOngoingMatches.Text = "Ongoing Matches:"
        '
        'ButtonReload
        '
        Me.ButtonReload.Location = New System.Drawing.Point(258, 122)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(61, 21)
        Me.ButtonReload.TabIndex = 56
        Me.ButtonReload.Text = "Reload"
        Me.ButtonReload.UseVisualStyleBackColor = True
        '
        'ButtonDeclareMatch
        '
        Me.ButtonDeclareMatch.Location = New System.Drawing.Point(667, 463)
        Me.ButtonDeclareMatch.Name = "ButtonDeclareMatch"
        Me.ButtonDeclareMatch.Size = New System.Drawing.Size(118, 28)
        Me.ButtonDeclareMatch.TabIndex = 57
        Me.ButtonDeclareMatch.Text = "Declare match"
        Me.ButtonDeclareMatch.UseVisualStyleBackColor = True
        Me.ButtonDeclareMatch.Visible = False
        '
        'LabelIdentifier
        '
        Me.LabelIdentifier.AutoSize = True
        Me.LabelIdentifier.Location = New System.Drawing.Point(402, 44)
        Me.LabelIdentifier.Name = "LabelIdentifier"
        Me.LabelIdentifier.Size = New System.Drawing.Size(21, 15)
        Me.LabelIdentifier.TabIndex = 58
        Me.LabelIdentifier.Text = "ID:"
        '
        'LabelGameID
        '
        Me.LabelGameID.AutoSize = True
        Me.LabelGameID.Location = New System.Drawing.Point(438, 45)
        Me.LabelGameID.Name = "LabelGameID"
        Me.LabelGameID.Size = New System.Drawing.Size(0, 15)
        Me.LabelGameID.TabIndex = 59
        '
        'ButtonNewGame
        '
        Me.ButtonNewGame.Location = New System.Drawing.Point(32, 463)
        Me.ButtonNewGame.Name = "ButtonNewGame"
        Me.ButtonNewGame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonNewGame.Size = New System.Drawing.Size(118, 28)
        Me.ButtonNewGame.TabIndex = 60
        Me.ButtonNewGame.Text = "New game"
        Me.ButtonNewGame.UseVisualStyleBackColor = True
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(555, 44)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(0, 15)
        Me.LabelType.TabIndex = 61
        '
        'TextBoxPGN
        '
        Me.TextBoxPGN.Location = New System.Drawing.Point(402, 360)
        Me.TextBoxPGN.Name = "TextBoxPGN"
        Me.TextBoxPGN.ReadOnly = True
        Me.TextBoxPGN.Size = New System.Drawing.Size(383, 23)
        Me.TextBoxPGN.TabIndex = 62
        '
        'LabelPGN
        '
        Me.LabelPGN.AutoSize = True
        Me.LabelPGN.Location = New System.Drawing.Point(402, 342)
        Me.LabelPGN.Name = "LabelPGN"
        Me.LabelPGN.Size = New System.Drawing.Size(31, 15)
        Me.LabelPGN.TabIndex = 63
        Me.LabelPGN.Text = "PGN"
        '
        'Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 523)
        Me.Controls.Add(Me.LabelPGN)
        Me.Controls.Add(Me.TextBoxPGN)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.ButtonNewGame)
        Me.Controls.Add(Me.LabelGameID)
        Me.Controls.Add(Me.LabelIdentifier)
        Me.Controls.Add(Me.ButtonDeclareMatch)
        Me.Controls.Add(Me.ButtonReload)
        Me.Controls.Add(Me.LabelOngoingMatches)
        Me.Controls.Add(Me.ListBoxOngoingMatches)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.LabelWinner)
        Me.Controls.Add(Me.TextBoxWinner)
        Me.Controls.Add(Me.GroupBoxTournament)
        Me.Controls.Add(Me.TextBoxClockIncrement)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.TextBoxClockTime)
        Me.Controls.Add(Me.LabelFormat)
        Me.Controls.Add(Me.TextBoxFormat)
        Me.Controls.Add(Me.LabelTermination)
        Me.Controls.Add(Me.TextBoxTermination)
        Me.Controls.Add(Me.LabelOpeningCode)
        Me.Controls.Add(Me.TextBoxOpeningCode)
        Me.Controls.Add(Me.LabelOpeningName)
        Me.Controls.Add(Me.TextBoxOpeningName)
        Me.Controls.Add(Me.LabelDateGame)
        Me.Controls.Add(Me.TextBoxDateGame)
        Me.Controls.Add(Me.LabelDuration)
        Me.Controls.Add(Me.TextBoxDuration)
        Me.Controls.Add(Me.LabelWhite)
        Me.Controls.Add(Me.TextBoxWhite)
        Me.Controls.Add(Me.vs)
        Me.Controls.Add(Me.LabelBlack)
        Me.Controls.Add(Me.TextBoxBlack)
        Me.Controls.Add(Me.ButtonSearchGame)
        Me.Controls.Add(Me.LabelSearchGame)
        Me.Controls.Add(Me.TextBoxSearchGame)
        Me.Name = "Games"
        Me.Text = "Games"
        Me.GroupBoxTournament.ResumeLayout(False)
        Me.GroupBoxTournament.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSearchGame As Button
    Friend WithEvents LabelSearchGame As Label
    Friend WithEvents TextBoxSearchGame As TextBox
    Friend WithEvents TextBoxBlack As TextBox
    Friend WithEvents LabelBlack As Label
    Friend WithEvents vs As Label
    Friend WithEvents LabelWhite As Label
    Friend WithEvents TextBoxWhite As TextBox
    Friend WithEvents LabelDuration As Label
    Friend WithEvents TextBoxDuration As TextBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents TextBoxDateGame As TextBox
    Friend WithEvents LabelGameDate As Label
    Friend WithEvents LabelDateGame As Label
    Friend WithEvents LabelOpeningName As Label
    Friend WithEvents TextBoxOpeningName As TextBox
    Friend WithEvents LabelOpeningCode As Label
    Friend WithEvents TextBoxOpeningCode As TextBox
    Friend WithEvents LabelFormat As Label
    Friend WithEvents TextBoxFormat As TextBox
    Friend WithEvents LabelTermination As Label
    Friend WithEvents TextBoxTermination As TextBox
    Friend WithEvents TextBoxClockIncrement As TextBox
    Friend WithEvents LabelClock As Label
    Friend WithEvents TextBoxClockTime As TextBox
    Friend WithEvents TextBoxTournamentName As TextBox
    Friend WithEvents LabelTournamentName As Label
    Friend WithEvents TextBoxDateTournament As TextBox
    Friend WithEvents TextBoxTournamentDate As TextBox
    Friend WithEvents LabelTournamentDate As Label
    Friend WithEvents LabelDateTournament As Label
    Friend WithEvents GroupBoxTournament As GroupBox
    Friend WithEvents LabelWinner As Label
    Friend WithEvents TextBoxWinner As TextBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LabelOngoingMatches As Label
    Friend WithEvents ListBoxOngoingMatches As ListBox
    Friend WithEvents ButtonReload As Button
    Friend WithEvents ButtonDeclareMatch As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents Label_ID As Label
    Friend WithEvents LabelGameID As Label
    Friend WithEvents LabelIdentifier As Label
    Friend WithEvents ButtonNewGame As Button
    Friend WithEvents LabelType As Label
    Friend WithEvents TextBoxPGN As TextBox
    Friend WithEvents LabelPGN As Label
End Class
