<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxCountry = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(38, 75)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(221, 23)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(38, 133)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(221, 23)
        Me.TextBoxPassword.TabIndex = 1
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(38, 199)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(221, 23)
        Me.TextBoxName.TabIndex = 2
        '
        'TextBoxCountry
        '
        Me.TextBoxCountry.Location = New System.Drawing.Point(38, 260)
        Me.TextBoxCountry.Name = "TextBoxCountry"
        Me.TextBoxCountry.Size = New System.Drawing.Size(221, 23)
        Me.TextBoxCountry.TabIndex = 3
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(38, 318)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(221, 23)
        Me.TextBoxEmail.TabIndex = 4
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(38, 57)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(60, 15)
        Me.LabelUsername.TabIndex = 5
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(38, 115)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(57, 15)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "Password"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(38, 181)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(39, 15)
        Me.LabelName.TabIndex = 7
        Me.LabelName.Text = "Name"
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Location = New System.Drawing.Point(38, 242)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(50, 15)
        Me.LabelCountry.TabIndex = 8
        Me.LabelCountry.Text = "Country"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(38, 300)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(36, 15)
        Me.LabelEmail.TabIndex = 9
        Me.LabelEmail.Text = "Email"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(91, 381)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(108, 23)
        Me.ButtonRegister.TabIndex = 10
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonShow
        '
        Me.ButtonShow.Location = New System.Drawing.Point(265, 133)
        Me.ButtonShow.Name = "ButtonShow"
        Me.ButtonShow.Size = New System.Drawing.Size(52, 23)
        Me.ButtonShow.TabIndex = 11
        Me.ButtonShow.Text = "Show"
        Me.ButtonShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonShow.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 450)
        Me.Controls.Add(Me.ButtonShow)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelCountry)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxCountry)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxCountry As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelCountry As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonShow As Button
End Class
