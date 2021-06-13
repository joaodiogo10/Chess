<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesDeclareMatch
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
        Me.LabelDuration = New System.Windows.Forms.Label()
        Me.GamePGN = New System.Windows.Forms.Label()
        Me.LabelTermination = New System.Windows.Forms.Label()
        Me.LabelOpening = New System.Windows.Forms.Label()
        Me.ComboBoxOpening = New System.Windows.Forms.ComboBox()
        Me.DateTimeDuration = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxPGN = New System.Windows.Forms.TextBox()
        Me.ComboBoxTermination = New System.Windows.Forms.ComboBox()
        Me.ButtonConfirm = New System.Windows.Forms.Button()
        Me.ComboBoxResult = New System.Windows.Forms.ComboBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelDuration
        '
        Me.LabelDuration.AutoSize = True
        Me.LabelDuration.Location = New System.Drawing.Point(34, 115)
        Me.LabelDuration.Name = "LabelDuration"
        Me.LabelDuration.Size = New System.Drawing.Size(53, 15)
        Me.LabelDuration.TabIndex = 0
        Me.LabelDuration.Text = "Duration"
        '
        'GamePGN
        '
        Me.GamePGN.AutoSize = True
        Me.GamePGN.Location = New System.Drawing.Point(34, 42)
        Me.GamePGN.Name = "GamePGN"
        Me.GamePGN.Size = New System.Drawing.Size(31, 15)
        Me.GamePGN.TabIndex = 1
        Me.GamePGN.Text = "PGN"
        '
        'LabelTermination
        '
        Me.LabelTermination.AutoSize = True
        Me.LabelTermination.Location = New System.Drawing.Point(146, 115)
        Me.LabelTermination.Name = "LabelTermination"
        Me.LabelTermination.Size = New System.Drawing.Size(70, 15)
        Me.LabelTermination.TabIndex = 2
        Me.LabelTermination.Text = "Termination"
        '
        'LabelOpening
        '
        Me.LabelOpening.AutoSize = True
        Me.LabelOpening.Location = New System.Drawing.Point(298, 42)
        Me.LabelOpening.Name = "LabelOpening"
        Me.LabelOpening.Size = New System.Drawing.Size(53, 15)
        Me.LabelOpening.TabIndex = 3
        Me.LabelOpening.Text = "Opening"
        '
        'ComboBoxOpening
        '
        Me.ComboBoxOpening.FormattingEnabled = True
        Me.ComboBoxOpening.Location = New System.Drawing.Point(298, 60)
        Me.ComboBoxOpening.Name = "ComboBoxOpening"
        Me.ComboBoxOpening.Size = New System.Drawing.Size(200, 23)
        Me.ComboBoxOpening.TabIndex = 4
        '
        'DateTimeDuration
        '
        Me.DateTimeDuration.CustomFormat = "mm:ss"
        Me.DateTimeDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeDuration.Location = New System.Drawing.Point(34, 133)
        Me.DateTimeDuration.Name = "DateTimeDuration"
        Me.DateTimeDuration.ShowUpDown = True
        Me.DateTimeDuration.Size = New System.Drawing.Size(70, 23)
        Me.DateTimeDuration.TabIndex = 5
        Me.DateTimeDuration.Value = New Date(2021, 6, 13, 3, 2, 32, 0)
        '
        'TextBoxPGN
        '
        Me.TextBoxPGN.Location = New System.Drawing.Point(34, 60)
        Me.TextBoxPGN.Name = "TextBoxPGN"
        Me.TextBoxPGN.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxPGN.TabIndex = 6
        '
        'ComboBoxTermination
        '
        Me.ComboBoxTermination.FormattingEnabled = True
        Me.ComboBoxTermination.Location = New System.Drawing.Point(146, 133)
        Me.ComboBoxTermination.Name = "ComboBoxTermination"
        Me.ComboBoxTermination.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxTermination.TabIndex = 7
        '
        'ButtonConfirm
        '
        Me.ButtonConfirm.Location = New System.Drawing.Point(490, 170)
        Me.ButtonConfirm.Name = "ButtonConfirm"
        Me.ButtonConfirm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConfirm.TabIndex = 8
        Me.ButtonConfirm.Text = "Confirm"
        Me.ButtonConfirm.UseVisualStyleBackColor = True
        '
        'ComboBoxResult
        '
        Me.ComboBoxResult.FormattingEnabled = True
        Me.ComboBoxResult.Location = New System.Drawing.Point(298, 133)
        Me.ComboBoxResult.Name = "ComboBoxResult"
        Me.ComboBoxResult.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxResult.TabIndex = 10
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(298, 115)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(39, 15)
        Me.LabelResult.TabIndex = 9
        Me.LabelResult.Text = "Result"
        '
        'GamesDeclareMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 205)
        Me.Controls.Add(Me.ComboBoxResult)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.ButtonConfirm)
        Me.Controls.Add(Me.ComboBoxTermination)
        Me.Controls.Add(Me.TextBoxPGN)
        Me.Controls.Add(Me.DateTimeDuration)
        Me.Controls.Add(Me.ComboBoxOpening)
        Me.Controls.Add(Me.LabelOpening)
        Me.Controls.Add(Me.LabelTermination)
        Me.Controls.Add(Me.GamePGN)
        Me.Controls.Add(Me.LabelDuration)
        Me.Name = "GamesDeclareMatch"
        Me.Text = "GamesDeclareMatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDuration As Label
    Friend WithEvents GamePGN As Label
    Friend WithEvents LabelTermination As Label
    Friend WithEvents LabelOpeningName As Label
    Friend WithEvents LabelOpening As Label
    Friend WithEvents ComboBoxOpening As ComboBox
    Friend WithEvents DateTimeDuration As DateTimePicker
    Friend WithEvents TextBoxPGN As TextBox
    Friend WithEvents ComboBoxTermination As ComboBox
    Friend WithEvents ButtonConfirm As Button
    Friend WithEvents ComboBoxResult As ComboBox
    Friend WithEvents LabelResult As Label
End Class
