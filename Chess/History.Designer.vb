<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.LabelPGN = New System.Windows.Forms.Label()
        Me.TextBoxPGN = New System.Windows.Forms.TextBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelGameID = New System.Windows.Forms.Label()
        Me.LabelIdentifier = New System.Windows.Forms.Label()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.LabelHistory = New System.Windows.Forms.Label()
        Me.ListBoxHistory = New System.Windows.Forms.ListBox()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.LabelWinner = New System.Windows.Forms.Label()
        Me.TextBoxWinner = New System.Windows.Forms.TextBox()
        Me.TextBoxClockIncrement = New System.Windows.Forms.TextBox()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.TextBoxClockTime = New System.Windows.Forms.TextBox()
        Me.LabelFormat = New System.Windows.Forms.Label()
        Me.TextBoxFormat = New System.Windows.Forms.TextBox()
        Me.LabelTermination = New System.Windows.Forms.Label()
        Me.TextBoxTermination = New System.Windows.Forms.TextBox()
        Me.LabelOpeningCode = New System.Windows.Forms.Label()
        Me.TextBoxOpeningCode = New System.Windows.Forms.TextBox()
        Me.LabelOpeningName = New System.Windows.Forms.Label()
        Me.TextBoxOpeningName = New System.Windows.Forms.TextBox()
        Me.LabelDateGame = New System.Windows.Forms.Label()
        Me.TextBoxDateGame = New System.Windows.Forms.TextBox()
        Me.LabelDuration = New System.Windows.Forms.Label()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.LabelWhite = New System.Windows.Forms.Label()
        Me.TextBoxWhite = New System.Windows.Forms.TextBox()
        Me.vs = New System.Windows.Forms.Label()
        Me.LabelBlack = New System.Windows.Forms.Label()
        Me.TextBoxBlack = New System.Windows.Forms.TextBox()
        Me.LabelBlackRating = New System.Windows.Forms.Label()
        Me.TextBoxBlackRating = New System.Windows.Forms.TextBox()
        Me.LabelWhiteRating = New System.Windows.Forms.Label()
        Me.TextBoxWhiteRating = New System.Windows.Forms.TextBox()
        Me.LabelBlackRatingEarned = New System.Windows.Forms.Label()
        Me.LabelWhiteRatingEarned = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPGN
        '
        Me.LabelPGN.AutoSize = True
        Me.LabelPGN.Location = New System.Drawing.Point(413, 340)
        Me.LabelPGN.Name = "LabelPGN"
        Me.LabelPGN.Size = New System.Drawing.Size(31, 15)
        Me.LabelPGN.TabIndex = 101
        Me.LabelPGN.Text = "PGN"
        '
        'TextBoxPGN
        '
        Me.TextBoxPGN.Location = New System.Drawing.Point(413, 358)
        Me.TextBoxPGN.Name = "TextBoxPGN"
        Me.TextBoxPGN.ReadOnly = True
        Me.TextBoxPGN.Size = New System.Drawing.Size(383, 23)
        Me.TextBoxPGN.TabIndex = 100
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(566, 42)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(0, 15)
        Me.LabelType.TabIndex = 99
        '
        'LabelGameID
        '
        Me.LabelGameID.AutoSize = True
        Me.LabelGameID.Location = New System.Drawing.Point(449, 43)
        Me.LabelGameID.Name = "LabelGameID"
        Me.LabelGameID.Size = New System.Drawing.Size(0, 15)
        Me.LabelGameID.TabIndex = 97
        '
        'LabelIdentifier
        '
        Me.LabelIdentifier.AutoSize = True
        Me.LabelIdentifier.Location = New System.Drawing.Point(413, 42)
        Me.LabelIdentifier.Name = "LabelIdentifier"
        Me.LabelIdentifier.Size = New System.Drawing.Size(21, 15)
        Me.LabelIdentifier.TabIndex = 96
        Me.LabelIdentifier.Text = "ID:"
        '
        'ButtonReload
        '
        Me.ButtonReload.Location = New System.Drawing.Point(269, 120)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(61, 21)
        Me.ButtonReload.TabIndex = 94
        Me.ButtonReload.Text = "Reload"
        Me.ButtonReload.UseVisualStyleBackColor = True
        '
        'LabelHistory
        '
        Me.LabelHistory.AutoSize = True
        Me.LabelHistory.Location = New System.Drawing.Point(43, 123)
        Me.LabelHistory.Name = "LabelHistory"
        Me.LabelHistory.Size = New System.Drawing.Size(45, 15)
        Me.LabelHistory.TabIndex = 93
        Me.LabelHistory.Text = "History"
        '
        'ListBoxHistory
        '
        Me.ListBoxHistory.FormattingEnabled = True
        Me.ListBoxHistory.ItemHeight = 15
        Me.ListBoxHistory.Location = New System.Drawing.Point(43, 141)
        Me.ListBoxHistory.Name = "ListBoxHistory"
        Me.ListBoxHistory.Size = New System.Drawing.Size(287, 304)
        Me.ListBoxHistory.TabIndex = 92
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(712, 122)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(33, 15)
        Me.LabelTime.TabIndex = 91
        Me.LabelTime.Text = "Time"
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(712, 140)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.ReadOnly = True
        Me.TextBoxTime.Size = New System.Drawing.Size(84, 23)
        Me.TextBoxTime.TabIndex = 90
        '
        'LabelWinner
        '
        Me.LabelWinner.AutoSize = True
        Me.LabelWinner.Location = New System.Drawing.Point(566, 174)
        Me.LabelWinner.Name = "LabelWinner"
        Me.LabelWinner.Size = New System.Drawing.Size(45, 15)
        Me.LabelWinner.TabIndex = 89
        Me.LabelWinner.Text = "Winner"
        '
        'TextBoxWinner
        '
        Me.TextBoxWinner.Location = New System.Drawing.Point(566, 192)
        Me.TextBoxWinner.Name = "TextBoxWinner"
        Me.TextBoxWinner.ReadOnly = True
        Me.TextBoxWinner.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxWinner.TabIndex = 88
        '
        'TextBoxClockIncrement
        '
        Me.TextBoxClockIncrement.Location = New System.Drawing.Point(727, 297)
        Me.TextBoxClockIncrement.Name = "TextBoxClockIncrement"
        Me.TextBoxClockIncrement.ReadOnly = True
        Me.TextBoxClockIncrement.Size = New System.Drawing.Size(69, 23)
        Me.TextBoxClockIncrement.TabIndex = 86
        '
        'LabelClock
        '
        Me.LabelClock.AutoSize = True
        Me.LabelClock.Location = New System.Drawing.Point(598, 300)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(46, 15)
        Me.LabelClock.TabIndex = 85
        Me.LabelClock.Text = "Clock : "
        '
        'TextBoxClockTime
        '
        Me.TextBoxClockTime.Location = New System.Drawing.Point(650, 297)
        Me.TextBoxClockTime.Name = "TextBoxClockTime"
        Me.TextBoxClockTime.ReadOnly = True
        Me.TextBoxClockTime.Size = New System.Drawing.Size(71, 23)
        Me.TextBoxClockTime.TabIndex = 84
        '
        'LabelFormat
        '
        Me.LabelFormat.AutoSize = True
        Me.LabelFormat.Location = New System.Drawing.Point(413, 279)
        Me.LabelFormat.Name = "LabelFormat"
        Me.LabelFormat.Size = New System.Drawing.Size(45, 15)
        Me.LabelFormat.TabIndex = 83
        Me.LabelFormat.Text = "Format"
        '
        'TextBoxFormat
        '
        Me.TextBoxFormat.Location = New System.Drawing.Point(413, 297)
        Me.TextBoxFormat.Name = "TextBoxFormat"
        Me.TextBoxFormat.ReadOnly = True
        Me.TextBoxFormat.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxFormat.TabIndex = 82
        '
        'LabelTermination
        '
        Me.LabelTermination.AutoSize = True
        Me.LabelTermination.Location = New System.Drawing.Point(413, 174)
        Me.LabelTermination.Name = "LabelTermination"
        Me.LabelTermination.Size = New System.Drawing.Size(70, 15)
        Me.LabelTermination.TabIndex = 81
        Me.LabelTermination.Text = "Termination"
        '
        'TextBoxTermination
        '
        Me.TextBoxTermination.Location = New System.Drawing.Point(413, 192)
        Me.TextBoxTermination.Name = "TextBoxTermination"
        Me.TextBoxTermination.ReadOnly = True
        Me.TextBoxTermination.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxTermination.TabIndex = 80
        '
        'LabelOpeningCode
        '
        Me.LabelOpeningCode.AutoSize = True
        Me.LabelOpeningCode.Location = New System.Drawing.Point(712, 225)
        Me.LabelOpeningCode.Name = "LabelOpeningCode"
        Me.LabelOpeningCode.Size = New System.Drawing.Size(84, 15)
        Me.LabelOpeningCode.TabIndex = 79
        Me.LabelOpeningCode.Text = "Opening Code"
        '
        'TextBoxOpeningCode
        '
        Me.TextBoxOpeningCode.Location = New System.Drawing.Point(712, 243)
        Me.TextBoxOpeningCode.Name = "TextBoxOpeningCode"
        Me.TextBoxOpeningCode.ReadOnly = True
        Me.TextBoxOpeningCode.Size = New System.Drawing.Size(84, 23)
        Me.TextBoxOpeningCode.TabIndex = 78
        '
        'LabelOpeningName
        '
        Me.LabelOpeningName.AutoSize = True
        Me.LabelOpeningName.Location = New System.Drawing.Point(413, 225)
        Me.LabelOpeningName.Name = "LabelOpeningName"
        Me.LabelOpeningName.Size = New System.Drawing.Size(88, 15)
        Me.LabelOpeningName.TabIndex = 77
        Me.LabelOpeningName.Text = "Opening Name"
        '
        'TextBoxOpeningName
        '
        Me.TextBoxOpeningName.Location = New System.Drawing.Point(413, 243)
        Me.TextBoxOpeningName.Name = "TextBoxOpeningName"
        Me.TextBoxOpeningName.ReadOnly = True
        Me.TextBoxOpeningName.Size = New System.Drawing.Size(282, 23)
        Me.TextBoxOpeningName.TabIndex = 76
        '
        'LabelDateGame
        '
        Me.LabelDateGame.AutoSize = True
        Me.LabelDateGame.Location = New System.Drawing.Point(566, 122)
        Me.LabelDateGame.Name = "LabelDateGame"
        Me.LabelDateGame.Size = New System.Drawing.Size(31, 15)
        Me.LabelDateGame.TabIndex = 75
        Me.LabelDateGame.Text = "Date"
        '
        'TextBoxDateGame
        '
        Me.TextBoxDateGame.Location = New System.Drawing.Point(566, 140)
        Me.TextBoxDateGame.Name = "TextBoxDateGame"
        Me.TextBoxDateGame.ReadOnly = True
        Me.TextBoxDateGame.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxDateGame.TabIndex = 74
        '
        'LabelDuration
        '
        Me.LabelDuration.AutoSize = True
        Me.LabelDuration.Location = New System.Drawing.Point(413, 122)
        Me.LabelDuration.Name = "LabelDuration"
        Me.LabelDuration.Size = New System.Drawing.Size(53, 15)
        Me.LabelDuration.TabIndex = 73
        Me.LabelDuration.Text = "Duration"
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(413, 140)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.ReadOnly = True
        Me.TextBoxDuration.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxDuration.TabIndex = 72
        '
        'LabelWhite
        '
        Me.LabelWhite.AutoSize = True
        Me.LabelWhite.Location = New System.Drawing.Point(566, 71)
        Me.LabelWhite.Name = "LabelWhite"
        Me.LabelWhite.Size = New System.Drawing.Size(38, 15)
        Me.LabelWhite.TabIndex = 71
        Me.LabelWhite.Text = "White"
        '
        'TextBoxWhite
        '
        Me.TextBoxWhite.Location = New System.Drawing.Point(566, 89)
        Me.TextBoxWhite.Name = "TextBoxWhite"
        Me.TextBoxWhite.ReadOnly = True
        Me.TextBoxWhite.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxWhite.TabIndex = 70
        '
        'vs
        '
        Me.vs.AutoSize = True
        Me.vs.Location = New System.Drawing.Point(542, 89)
        Me.vs.Name = "vs"
        Me.vs.Size = New System.Drawing.Size(18, 15)
        Me.vs.TabIndex = 69
        Me.vs.Text = "vs"
        '
        'LabelBlack
        '
        Me.LabelBlack.AutoSize = True
        Me.LabelBlack.Location = New System.Drawing.Point(413, 68)
        Me.LabelBlack.Name = "LabelBlack"
        Me.LabelBlack.Size = New System.Drawing.Size(35, 15)
        Me.LabelBlack.TabIndex = 68
        Me.LabelBlack.Text = "Black"
        '
        'TextBoxBlack
        '
        Me.TextBoxBlack.Location = New System.Drawing.Point(413, 86)
        Me.TextBoxBlack.Name = "TextBoxBlack"
        Me.TextBoxBlack.ReadOnly = True
        Me.TextBoxBlack.Size = New System.Drawing.Size(123, 23)
        Me.TextBoxBlack.TabIndex = 67
        '
        'LabelBlackRating
        '
        Me.LabelBlackRating.AutoSize = True
        Me.LabelBlackRating.Location = New System.Drawing.Point(413, 406)
        Me.LabelBlackRating.Name = "LabelBlackRating"
        Me.LabelBlackRating.Size = New System.Drawing.Size(72, 15)
        Me.LabelBlackRating.TabIndex = 103
        Me.LabelBlackRating.Text = "Black Rating"
        Me.LabelBlackRating.Visible = False
        '
        'TextBoxBlackRating
        '
        Me.TextBoxBlackRating.Location = New System.Drawing.Point(413, 424)
        Me.TextBoxBlackRating.Name = "TextBoxBlackRating"
        Me.TextBoxBlackRating.ReadOnly = True
        Me.TextBoxBlackRating.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxBlackRating.TabIndex = 102
        Me.TextBoxBlackRating.Visible = False
        '
        'LabelWhiteRating
        '
        Me.LabelWhiteRating.AutoSize = True
        Me.LabelWhiteRating.Location = New System.Drawing.Point(616, 406)
        Me.LabelWhiteRating.Name = "LabelWhiteRating"
        Me.LabelWhiteRating.Size = New System.Drawing.Size(75, 15)
        Me.LabelWhiteRating.TabIndex = 105
        Me.LabelWhiteRating.Text = "White Rating"
        Me.LabelWhiteRating.Visible = False
        '
        'TextBoxWhiteRating
        '
        Me.TextBoxWhiteRating.Location = New System.Drawing.Point(616, 424)
        Me.TextBoxWhiteRating.Name = "TextBoxWhiteRating"
        Me.TextBoxWhiteRating.ReadOnly = True
        Me.TextBoxWhiteRating.Size = New System.Drawing.Size(129, 23)
        Me.TextBoxWhiteRating.TabIndex = 104
        Me.TextBoxWhiteRating.WordWrap = False
        '
        'LabelBlackRatingEarned
        '
        Me.LabelBlackRatingEarned.AutoSize = True
        Me.LabelBlackRatingEarned.Location = New System.Drawing.Point(548, 427)
        Me.LabelBlackRatingEarned.Name = "LabelBlackRatingEarned"
        Me.LabelBlackRatingEarned.Size = New System.Drawing.Size(15, 15)
        Me.LabelBlackRatingEarned.TabIndex = 106
        Me.LabelBlackRatingEarned.Text = "+"
        Me.LabelBlackRatingEarned.Visible = False
        '
        'LabelWhiteRatingEarned
        '
        Me.LabelWhiteRatingEarned.AutoSize = True
        Me.LabelWhiteRatingEarned.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelWhiteRatingEarned.Location = New System.Drawing.Point(751, 427)
        Me.LabelWhiteRatingEarned.Name = "LabelWhiteRatingEarned"
        Me.LabelWhiteRatingEarned.Size = New System.Drawing.Size(15, 15)
        Me.LabelWhiteRatingEarned.TabIndex = 107
        Me.LabelWhiteRatingEarned.Text = "+"
        Me.LabelWhiteRatingEarned.Visible = False
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 520)
        Me.Controls.Add(Me.LabelWhiteRatingEarned)
        Me.Controls.Add(Me.LabelBlackRatingEarned)
        Me.Controls.Add(Me.LabelWhiteRating)
        Me.Controls.Add(Me.TextBoxWhiteRating)
        Me.Controls.Add(Me.LabelBlackRating)
        Me.Controls.Add(Me.TextBoxBlackRating)
        Me.Controls.Add(Me.LabelPGN)
        Me.Controls.Add(Me.TextBoxPGN)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelGameID)
        Me.Controls.Add(Me.LabelIdentifier)
        Me.Controls.Add(Me.ButtonReload)
        Me.Controls.Add(Me.LabelHistory)
        Me.Controls.Add(Me.ListBoxHistory)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.LabelWinner)
        Me.Controls.Add(Me.TextBoxWinner)
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
        Me.Name = "History"
        Me.Text = "History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPGN As Label
    Friend WithEvents TextBoxPGN As TextBox
    Friend WithEvents LabelType As Label
    Friend WithEvents LabelGameID As Label
    Friend WithEvents LabelIdentifier As Label
    Friend WithEvents ButtonReload As Button
    Friend WithEvents LabelHistory As Label
    Friend WithEvents ListBoxHistory As ListBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents LabelWinner As Label
    Friend WithEvents TextBoxWinner As TextBox
    Friend WithEvents TextBoxClockIncrement As TextBox
    Friend WithEvents LabelClock As Label
    Friend WithEvents TextBoxClockTime As TextBox
    Friend WithEvents LabelFormat As Label
    Friend WithEvents TextBoxFormat As TextBox
    Friend WithEvents LabelTermination As Label
    Friend WithEvents TextBoxTermination As TextBox
    Friend WithEvents LabelOpeningCode As Label
    Friend WithEvents TextBoxOpeningCode As TextBox
    Friend WithEvents LabelOpeningName As Label
    Friend WithEvents TextBoxOpeningName As TextBox
    Friend WithEvents LabelDateGame As Label
    Friend WithEvents TextBoxDateGame As TextBox
    Friend WithEvents LabelDuration As Label
    Friend WithEvents TextBoxDuration As TextBox
    Friend WithEvents LabelWhite As Label
    Friend WithEvents TextBoxWhite As TextBox
    Friend WithEvents vs As Label
    Friend WithEvents LabelBlack As Label
    Friend WithEvents TextBoxBlack As TextBox
    Friend WithEvents LabelBlackRating As Label
    Friend WithEvents TextBoxBlackRating As TextBox
    Friend WithEvents LabelWhiteRating As Label
    Friend WithEvents TextBoxOpponentRating As TextBox
    Friend WithEvents TextBoxWhiteRating As TextBox
    Friend WithEvents LabelBlackRatingEarned As Label
    Friend WithEvents LabelWhiteRatingEarned As Label
End Class
