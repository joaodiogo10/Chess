<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesNewGame
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
        Me.LabelPlayerBlack = New System.Windows.Forms.Label()
        Me.LabelWhite = New System.Windows.Forms.Label()
        Me.LabelPlayers = New System.Windows.Forms.Label()
        Me.TextBoxPlayerBlack = New System.Windows.Forms.TextBox()
        Me.TextBoxPlayerWhite = New System.Windows.Forms.TextBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelGameFormat = New System.Windows.Forms.Label()
        Me.ComboBoxGameFormat = New System.Windows.Forms.ComboBox()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelPlayerBlack
        '
        Me.LabelPlayerBlack.AutoSize = True
        Me.LabelPlayerBlack.Location = New System.Drawing.Point(38, 57)
        Me.LabelPlayerBlack.Name = "LabelPlayerBlack"
        Me.LabelPlayerBlack.Size = New System.Drawing.Size(35, 15)
        Me.LabelPlayerBlack.TabIndex = 0
        Me.LabelPlayerBlack.Text = "Black"
        '
        'LabelWhite
        '
        Me.LabelWhite.AutoSize = True
        Me.LabelWhite.Location = New System.Drawing.Point(35, 93)
        Me.LabelWhite.Name = "LabelWhite"
        Me.LabelWhite.Size = New System.Drawing.Size(38, 15)
        Me.LabelWhite.TabIndex = 1
        Me.LabelWhite.Text = "White"
        '
        'LabelPlayers
        '
        Me.LabelPlayers.AutoSize = True
        Me.LabelPlayers.Location = New System.Drawing.Point(26, 31)
        Me.LabelPlayers.Name = "LabelPlayers"
        Me.LabelPlayers.Size = New System.Drawing.Size(47, 15)
        Me.LabelPlayers.TabIndex = 2
        Me.LabelPlayers.Text = "Players:"
        '
        'TextBoxPlayerBlack
        '
        Me.TextBoxPlayerBlack.Location = New System.Drawing.Point(79, 54)
        Me.TextBoxPlayerBlack.Name = "TextBoxPlayerBlack"
        Me.TextBoxPlayerBlack.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPlayerBlack.TabIndex = 3
        '
        'TextBoxPlayerWhite
        '
        Me.TextBoxPlayerWhite.Location = New System.Drawing.Point(79, 90)
        Me.TextBoxPlayerWhite.Name = "TextBoxPlayerWhite"
        Me.TextBoxPlayerWhite.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPlayerWhite.TabIndex = 4
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Location = New System.Drawing.Point(293, 49)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(110, 23)
        Me.ComboBoxType.TabIndex = 5
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(244, 52)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(31, 15)
        Me.LabelType.TabIndex = 6
        Me.LabelType.Text = "Type"
        '
        'LabelGameFormat
        '
        Me.LabelGameFormat.AutoSize = True
        Me.LabelGameFormat.Location = New System.Drawing.Point(244, 98)
        Me.LabelGameFormat.Name = "LabelGameFormat"
        Me.LabelGameFormat.Size = New System.Drawing.Size(45, 15)
        Me.LabelGameFormat.TabIndex = 7
        Me.LabelGameFormat.Text = "Format"
        '
        'ComboBoxGameFormat
        '
        Me.ComboBoxGameFormat.FormattingEnabled = True
        Me.ComboBoxGameFormat.Location = New System.Drawing.Point(293, 95)
        Me.ComboBoxGameFormat.Name = "ComboBoxGameFormat"
        Me.ComboBoxGameFormat.Size = New System.Drawing.Size(110, 23)
        Me.ComboBoxGameFormat.TabIndex = 8
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(444, 133)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConfirm.TabIndex = 11
        Me.ButtonConfirm.Text = "Confirm"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'GamesNewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 169)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.ComboBoxGameFormat)
        Me.Controls.Add(Me.LabelGameFormat)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.ComboBoxType)
        Me.Controls.Add(Me.TextBoxPlayerWhite)
        Me.Controls.Add(Me.TextBoxPlayerBlack)
        Me.Controls.Add(Me.LabelPlayers)
        Me.Controls.Add(Me.LabelWhite)
        Me.Controls.Add(Me.LabelPlayerBlack)
        Me.Name = "GamesNewGame"
        Me.Text = "New Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPlayers As Label
    Friend WithEvents LabelWhite As Label
    Friend WithEvents LabelPlayerBlack As Label
    Friend WithEvents TextBoxPlayerBlack As TextBox
    Friend WithEvents TextBoxPlayerWhite As TextBox
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents LabelType As Label
    Friend WithEvents LabelGameFormat As Label
    Friend WithEvents ComboBoxClockTime As ComboBox
    Friend WithEvents ButtonConfirm As Button
    Friend WithEvents ComboBoxGameFormat As ComboBox
End Class
