<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teams
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
        Me.LabelSearchTeam = New System.Windows.Forms.Label()
        Me.TextBoxSearchTeam = New System.Windows.Forms.TextBox()
        Me.ButtonSearchTeam = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxTeams = New System.Windows.Forms.ListBox()
        Me.LabelLeader = New System.Windows.Forms.Label()
        Me.TextBoxLeader = New System.Windows.Forms.TextBox()
        Me.LabelMembers = New System.Windows.Forms.Label()
        Me.ListBoxMembers = New System.Windows.Forms.ListBox()
        Me.ButtonAddMember = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMemberAdd = New System.Windows.Forms.TextBox()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDeleteMember = New System.Windows.Forms.Button()
        Me.ButtonChangeLeader = New System.Windows.Forms.Button()
        Me.ButtonDeleteTeam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelSearchTeam
        '
        Me.LabelSearchTeam.AutoSize = True
        Me.LabelSearchTeam.Location = New System.Drawing.Point(26, 9)
        Me.LabelSearchTeam.Name = "LabelSearchTeam"
        Me.LabelSearchTeam.Size = New System.Drawing.Size(121, 15)
        Me.LabelSearchTeam.TabIndex = 20
        Me.LabelSearchTeam.Text = "Search by team name"
        '
        'TextBoxSearchTeam
        '
        Me.TextBoxSearchTeam.Location = New System.Drawing.Point(26, 27)
        Me.TextBoxSearchTeam.Name = "TextBoxSearchTeam"
        Me.TextBoxSearchTeam.Size = New System.Drawing.Size(208, 23)
        Me.TextBoxSearchTeam.TabIndex = 21
        '
        'ButtonSearchTeam
        '
        Me.ButtonSearchTeam.Location = New System.Drawing.Point(240, 27)
        Me.ButtonSearchTeam.Name = "ButtonSearchTeam"
        Me.ButtonSearchTeam.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearchTeam.TabIndex = 22
        Me.ButtonSearchTeam.Text = "Search"
        Me.ButtonSearchTeam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Teams"
        '
        'ListBoxTeams
        '
        Me.ListBoxTeams.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBoxTeams.FormattingEnabled = True
        Me.ListBoxTeams.ItemHeight = 15
        Me.ListBoxTeams.Location = New System.Drawing.Point(26, 82)
        Me.ListBoxTeams.Name = "ListBoxTeams"
        Me.ListBoxTeams.Size = New System.Drawing.Size(289, 229)
        Me.ListBoxTeams.TabIndex = 24
        '
        'LabelLeader
        '
        Me.LabelLeader.AutoSize = True
        Me.LabelLeader.Location = New System.Drawing.Point(332, 81)
        Me.LabelLeader.Name = "LabelLeader"
        Me.LabelLeader.Size = New System.Drawing.Size(42, 15)
        Me.LabelLeader.TabIndex = 25
        Me.LabelLeader.Text = "Leader"
        '
        'TextBoxLeader
        '
        Me.TextBoxLeader.Location = New System.Drawing.Point(332, 99)
        Me.TextBoxLeader.Name = "TextBoxLeader"
        Me.TextBoxLeader.ReadOnly = True
        Me.TextBoxLeader.Size = New System.Drawing.Size(245, 23)
        Me.TextBoxLeader.TabIndex = 26
        '
        'LabelMembers
        '
        Me.LabelMembers.AutoSize = True
        Me.LabelMembers.Location = New System.Drawing.Point(332, 140)
        Me.LabelMembers.Name = "LabelMembers"
        Me.LabelMembers.Size = New System.Drawing.Size(57, 15)
        Me.LabelMembers.TabIndex = 27
        Me.LabelMembers.Text = "Members"
        '
        'ListBoxMembers
        '
        Me.ListBoxMembers.FormattingEnabled = True
        Me.ListBoxMembers.ItemHeight = 15
        Me.ListBoxMembers.Location = New System.Drawing.Point(332, 158)
        Me.ListBoxMembers.Name = "ListBoxMembers"
        Me.ListBoxMembers.Size = New System.Drawing.Size(245, 154)
        Me.ListBoxMembers.TabIndex = 28
        '
        'ButtonAddMember
        '
        Me.ButtonAddMember.Location = New System.Drawing.Point(26, 340)
        Me.ButtonAddMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAddMember.Name = "ButtonAddMember"
        Me.ButtonAddMember.Size = New System.Drawing.Size(116, 32)
        Me.ButtonAddMember.TabIndex = 29
        Me.ButtonAddMember.Text = "Add Member"
        Me.ButtonAddMember.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Member to add"
        '
        'TextBoxMemberAdd
        '
        Me.TextBoxMemberAdd.Location = New System.Drawing.Point(598, 99)
        Me.TextBoxMemberAdd.Name = "TextBoxMemberAdd"
        Me.TextBoxMemberAdd.ReadOnly = True
        Me.TextBoxMemberAdd.Size = New System.Drawing.Size(245, 23)
        Me.TextBoxMemberAdd.TabIndex = 31
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(708, 340)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(116, 32)
        Me.ButtonOk.TabIndex = 32
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(581, 340)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(116, 32)
        Me.ButtonCancel.TabIndex = 33
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonDeleteMember
        '
        Me.ButtonDeleteMember.Location = New System.Drawing.Point(148, 340)
        Me.ButtonDeleteMember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDeleteMember.Name = "ButtonDeleteMember"
        Me.ButtonDeleteMember.Size = New System.Drawing.Size(116, 32)
        Me.ButtonDeleteMember.TabIndex = 34
        Me.ButtonDeleteMember.Text = "Delete Member"
        Me.ButtonDeleteMember.UseVisualStyleBackColor = True
        '
        'ButtonChangeLeader
        '
        Me.ButtonChangeLeader.Location = New System.Drawing.Point(270, 340)
        Me.ButtonChangeLeader.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonChangeLeader.Name = "ButtonChangeLeader"
        Me.ButtonChangeLeader.Size = New System.Drawing.Size(116, 32)
        Me.ButtonChangeLeader.TabIndex = 35
        Me.ButtonChangeLeader.Text = "Change Leader"
        Me.ButtonChangeLeader.UseVisualStyleBackColor = True
        '
        'ButtonDeleteTeam
        '
        Me.ButtonDeleteTeam.Location = New System.Drawing.Point(148, 399)
        Me.ButtonDeleteTeam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDeleteTeam.Name = "ButtonDeleteTeam"
        Me.ButtonDeleteTeam.Size = New System.Drawing.Size(116, 32)
        Me.ButtonDeleteTeam.TabIndex = 36
        Me.ButtonDeleteTeam.Text = "Delete Team"
        Me.ButtonDeleteTeam.UseVisualStyleBackColor = True
        '
        'Teams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 507)
        Me.Controls.Add(Me.ButtonDeleteTeam)
        Me.Controls.Add(Me.ButtonChangeLeader)
        Me.Controls.Add(Me.ButtonDeleteMember)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.TextBoxMemberAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAddMember)
        Me.Controls.Add(Me.ListBoxMembers)
        Me.Controls.Add(Me.LabelMembers)
        Me.Controls.Add(Me.TextBoxLeader)
        Me.Controls.Add(Me.LabelLeader)
        Me.Controls.Add(Me.ListBoxTeams)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonSearchTeam)
        Me.Controls.Add(Me.TextBoxSearchTeam)
        Me.Controls.Add(Me.LabelSearchTeam)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Teams"
        Me.Text = "Teams"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSearchTeam As Label
    Friend WithEvents TextBoxSearchTeam As TextBox
    Friend WithEvents ButtonSearchTeam As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxTeams As ListBox
    Friend WithEvents LabelLeader As Label
    Friend WithEvents TextBoxLeader As TextBox
    Friend WithEvents LabelMembers As Label
    Friend WithEvents ListBoxMembers As ListBox
    Friend WithEvents ButtonAddMember As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMemberAdd As TextBox
    Friend WithEvents ButtonOk As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDeleteMember As Button
    Friend WithEvents ButtonChangeLeader As Button
    Friend WithEvents ButtonDeleteTeam As Button
End Class
