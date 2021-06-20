<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboards
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxLeaderbord = New System.Windows.Forms.ListBox()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.ComboBoxFormat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxPosition = New System.Windows.Forms.TextBox()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCurrent = New System.Windows.Forms.TextBox()
        Me.TextBoxMax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Format"
        '
        'ListBoxLeaderbord
        '
        Me.ListBoxLeaderbord.FormattingEnabled = True
        Me.ListBoxLeaderbord.ItemHeight = 20
        Me.ListBoxLeaderbord.Location = New System.Drawing.Point(57, 162)
        Me.ListBoxLeaderbord.Name = "ListBoxLeaderbord"
        Me.ListBoxLeaderbord.Size = New System.Drawing.Size(371, 364)
        Me.ListBoxLeaderbord.TabIndex = 9
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Location = New System.Drawing.Point(708, 71)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(94, 29)
        Me.ButtonSelect.TabIndex = 10
        Me.ButtonSelect.Text = "Select"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'ComboBoxFormat
        '
        Me.ComboBoxFormat.FormattingEnabled = True
        Me.ComboBoxFormat.Location = New System.Drawing.Point(57, 72)
        Me.ComboBoxFormat.Name = "ComboBoxFormat"
        Me.ComboBoxFormat.Size = New System.Drawing.Size(371, 28)
        Me.ComboBoxFormat.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(490, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Top:"
        '
        'TextBoxTop
        '
        Me.TextBoxTop.Location = New System.Drawing.Point(542, 73)
        Me.TextBoxTop.Name = "TextBoxTop"
        Me.TextBoxTop.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxTop.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(490, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Position"
        '
        'TextBoxPosition
        '
        Me.TextBoxPosition.Location = New System.Drawing.Point(490, 185)
        Me.TextBoxPosition.Name = "TextBoxPosition"
        Me.TextBoxPosition.ReadOnly = True
        Me.TextBoxPosition.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxPosition.TabIndex = 15
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(693, 185)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.ReadOnly = True
        Me.TextBoxUser.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxUser.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(693, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Player"
        '
        'TextBoxCurrent
        '
        Me.TextBoxCurrent.Location = New System.Drawing.Point(490, 276)
        Me.TextBoxCurrent.Name = "TextBoxCurrent"
        Me.TextBoxCurrent.ReadOnly = True
        Me.TextBoxCurrent.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxCurrent.TabIndex = 18
        '
        'TextBoxMax
        '
        Me.TextBoxMax.Location = New System.Drawing.Point(693, 276)
        Me.TextBoxMax.Name = "TextBoxMax"
        Me.TextBoxMax.ReadOnly = True
        Me.TextBoxMax.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxMax.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Current Rating"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(693, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Max Rating"
        '
        'Leaderboards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 697)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxMax)
        Me.Controls.Add(Me.TextBoxCurrent)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.TextBoxPosition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxTop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxFormat)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.ListBoxLeaderbord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Leaderboards"
        Me.Text = "Leaderboards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFormatName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxClock As ComboBox
    Friend WithEvents ComboBoxIncrement As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxLeaderbord As ListBox
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents ComboBoxFormat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPosition As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCurrent As TextBox
    Friend WithEvents TextBoxMax As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
