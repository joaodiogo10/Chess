﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LabelSocial = New System.Windows.Forms.Label()
        Me.LabelGames = New System.Windows.Forms.Label()
        Me.ButtonTeams = New System.Windows.Forms.Button()
        Me.ButtonGames = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonLeaderboards = New System.Windows.Forms.Button()
        Me.LabelLeaderboard = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Users"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelSocial
        '
        Me.LabelSocial.AutoSize = True
        Me.LabelSocial.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSocial.Location = New System.Drawing.Point(33, 23)
        Me.LabelSocial.Name = "LabelSocial"
        Me.LabelSocial.Size = New System.Drawing.Size(64, 28)
        Me.LabelSocial.TabIndex = 1
        Me.LabelSocial.Text = "Social"
        '
        'LabelGames
        '
        Me.LabelGames.AutoSize = True
        Me.LabelGames.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelGames.Location = New System.Drawing.Point(33, 132)
        Me.LabelGames.Name = "LabelGames"
        Me.LabelGames.Size = New System.Drawing.Size(71, 28)
        Me.LabelGames.TabIndex = 2
        Me.LabelGames.Text = "Games"
        '
        'ButtonTeams
        '
        Me.ButtonTeams.Location = New System.Drawing.Point(201, 54)
        Me.ButtonTeams.Name = "ButtonTeams"
        Me.ButtonTeams.Size = New System.Drawing.Size(128, 62)
        Me.ButtonTeams.TabIndex = 3
        Me.ButtonTeams.Text = "Teams"
        Me.ButtonTeams.UseVisualStyleBackColor = True
        '
        'ButtonGames
        '
        Me.ButtonGames.Location = New System.Drawing.Point(33, 163)
        Me.ButtonGames.Name = "ButtonGames"
        Me.ButtonGames.Size = New System.Drawing.Size(128, 62)
        Me.ButtonGames.TabIndex = 4
        Me.ButtonGames.Text = "Games"
        Me.ButtonGames.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(33, 385)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonLogin.Size = New System.Drawing.Size(128, 53)
        Me.ButtonLogin.TabIndex = 5
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonLeaderboards
        '
        Me.ButtonLeaderboards.Location = New System.Drawing.Point(33, 273)
        Me.ButtonLeaderboards.Name = "ButtonLeaderboards"
        Me.ButtonLeaderboards.Size = New System.Drawing.Size(128, 62)
        Me.ButtonLeaderboards.TabIndex = 7
        Me.ButtonLeaderboards.Text = "Leaderboards"
        Me.ButtonLeaderboards.UseVisualStyleBackColor = True
        '
        'LabelLeaderboard
        '
        Me.LabelLeaderboard.AutoSize = True
        Me.LabelLeaderboard.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelLeaderboard.Location = New System.Drawing.Point(33, 242)
        Me.LabelLeaderboard.Name = "LabelLeaderboard"
        Me.LabelLeaderboard.Size = New System.Drawing.Size(123, 28)
        Me.LabelLeaderboard.TabIndex = 6
        Me.LabelLeaderboard.Text = "Leaderboard"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(201, 385)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonRegister.Size = New System.Drawing.Size(128, 53)
        Me.ButtonRegister.TabIndex = 8
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 450)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.ButtonLeaderboards)
        Me.Controls.Add(Me.LabelLeaderboard)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.ButtonGames)
        Me.Controls.Add(Me.ButtonTeams)
        Me.Controls.Add(Me.LabelGames)
        Me.Controls.Add(Me.LabelSocial)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainPage"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LabelSocial As Label
    Friend WithEvents LabelGames As Label
    Friend WithEvents ButtonTeams As Button
    Friend WithEvents ButtonGames As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonLeaderboards As Button
    Friend WithEvents LabelLeaderboard As Label
    Friend WithEvents ButtonRegister As Button
End Class
