Imports System.Data.SqlClient
Public Class Teams

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentTeam As Integer
    Dim currentMember As Integer
    Dim optionSelected As Integer

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub

    Private Sub Teams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeams()
        ShowButtons()

    End Sub

    'If user not found returns Nothing
    Function LoadTeam(teamName As String)
        Dim team As Team = New Team

        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.udf_GetTeamInfo(@teamName)"
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = teamName
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        If (RDR.Read()) Then
            team.Description = RDR.Item("Description")
            team.Name = RDR.Item("Name")
            team.Leader = RDR.Item("Leader")
        Else
            team = Nothing
            MsgBox("Team not found")
        End If

        CN.Close()

        Return team
    End Function

    Function UpdateTeam(team As Team)
        CN.Open()
        CMD.CommandText = "SELECT * FROM dbo.udf_GetTeamInfo(@teamName)"
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        If (RDR.Read()) Then
            team.Description = RDR.Item("Description")
            team.Name = RDR.Item("Name")
            team.Leader = RDR.Item("Leader")
        Else
            team = Nothing
            MsgBox("Team not found")
        End If

        CN.Close()

        Return team
    End Function

    Sub LoadMembers(team As Team)
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "SELECT * FROM dbo.udf_GetTeamMembers(@teamName)"
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxMembers.Items.Clear()
        While RDR.Read
            ListBoxMembers.Items.Add(RDR.Item("User"))
        End While
        CN.Close()
    End Sub

    Sub LoadTeams()
        CMD.CommandText = "SELECT * FROM Chess_Team"
        CMD.CommandType = CommandType.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxTeams.Items.Clear()
        While RDR.Read
            Dim Team As New Team With {
                .Description = RDR.Item("Description"),
                .Name = RDR.Item("Name"),
                .Leader = RDR.Item("Leader")
            }
            ListBoxTeams.Items.Add(Team)
        End While
        CN.Close()
        currentTeam = 0
        ShowTeam(CType(ListBoxTeams.Items.Item(currentTeam), Team))
    End Sub

    Sub ShowTeam(team As Team)
        TextBoxLeader.Text = team.Leader
        RichTextBoxDescription.Text = team.Description
        TextBoxName.Text = team.Name
        LoadMembers(team)
    End Sub

    Private Sub TeamList_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBoxTeams.SelectedValueChanged
        If ListBoxTeams.SelectedIndex > -1 Then
            currentTeam = ListBoxTeams.SelectedIndex
            ShowTeam(CType(ListBoxTeams.Items.Item(currentTeam), Team))
        End If
    End Sub

    Private Sub ButtonSearchTeam_Click(sender As Object, e As EventArgs) Handles ButtonSearchTeam.Click
        Dim insertedName As String = TextBoxSearchTeam.Text
        Dim team As Team = LoadTeam(insertedName)
        If (team IsNot Nothing) Then
            ShowTeam(team)
        End If
    End Sub

    Private Sub ButtonAddMember_Click(sender As Object, e As EventArgs) Handles ButtonAddMember.Click
        optionSelected = 1
        HideButtons()
        TextBoxMemberAdd.ReadOnly = False
    End Sub

    Sub HideButtons()
        ButtonAddMember.Visible = False
        ButtonChangeLeader.Visible = False
        ButtonDeleteMember.Visible = False
        ButtonDeleteTeam.Visible = False
        ButtonOk.Visible = True
        ButtonCancel.Visible = True
    End Sub

    Sub ShowButtons()
        ButtonAddMember.Visible = True
        ButtonChangeLeader.Visible = True
        ButtonDeleteMember.Visible = True
        ButtonDeleteTeam.Visible = True
        ButtonOk.Visible = False
        ButtonCancel.Visible = False
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Dim team As Team = CType(ListBoxTeams.Items.Item(currentTeam), Team)

        Select Case optionSelected
            Case 1
                Dim insertedUsername As String = TextBoxMemberAdd.Text
                AddMember(team, insertedUsername)
            Case 2
                Dim selectedMember = CType(ListBoxMembers.SelectedItem, String)
                DeleteMember(team, selectedMember)
            Case 3
                Dim insertedLeader As String = CType(ListBoxMembers.Items.Item(currentMember), String)
                ChangeLeader(team, insertedLeader)
            Case 4
                DeleteTeam(team)
        End Select

        ShowButtons()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ShowButtons()
        TextBoxMemberAdd.Text = ""
        TextBoxMemberAdd.ReadOnly = True
    End Sub

    Private Sub AddMember(team As Team, userName As String)
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_AddTeamMember"
        CMD.CommandType = CommandType.StoredProcedure
        Dim retValParam As New SqlParameter("@RETURN_VALUE", SqlDbType.Int)
        retValParam.Direction = ParameterDirection.ReturnValue
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name
        CMD.Parameters.Add("@userName", SqlDbType.VarChar, 64).Value = userName
        CMD.Parameters.Add(retValParam)
        Dim retVal As Integer

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            retVal = Convert.ToInt32(retValParam.Value)
            If (retVal = -100) Then
                MsgBox("User is already a member")
            End If
        Catch ex As Exception
            MsgBox("Failed to add member in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CMD.CommandType = CommandType.Text
            CN.Close()
            LoadMembers(team)
        End Try
    End Sub

    Private Sub DeleteMember(team As Team, userName As String)
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_DeleteTeamMember"
        CMD.CommandType = CommandType.StoredProcedure
        Dim retValParam As New SqlParameter("@RETURN_VALUE", SqlDbType.Int)
        retValParam.Direction = ParameterDirection.ReturnValue
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name
        CMD.Parameters.Add("@userName", SqlDbType.VarChar, 64).Value = userName
        CMD.Parameters.Add(retValParam)
        Dim retVal As Integer
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
            retVal = Convert.ToInt32(retValParam.Value)
            If (retVal = -100) Then
                MsgBox("Leader cannot be removed")
            End If
        Catch ex As Exception
            MsgBox("Failed to delete member in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CMD.CommandType = CommandType.Text
            CN.Close()
            LoadMembers(team)
        End Try
    End Sub

    Private Sub ChangeLeader(team As Team, userName As String)
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_ChangeTeamLeader"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name
        CMD.Parameters.Add("@userName", SqlDbType.VarChar, 64).Value = userName
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Failed to change leader in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CMD.CommandType = CommandType.Text
            CN.Close()
            UpdateTeam(team)
            ShowTeam(team)
        End Try
    End Sub

    Private Sub DeleteTeam(team As Team)
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_DeleteTeam"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Add("@teamName", SqlDbType.VarChar, 128).Value = team.Name

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Failed to delete the team. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CMD.CommandType = CommandType.Text
            CN.Close()
            LoadTeams()
        End Try
    End Sub

    Private Sub ButtonDeleteMember_Click(sender As Object, e As EventArgs) Handles ButtonDeleteMember.Click
        optionSelected = 2
        HideButtons()
    End Sub

    Private Sub ButtonChangeLeader_Click(sender As Object, e As EventArgs) Handles ButtonChangeLeader.Click
        optionSelected = 3
        HideButtons()
    End Sub

    Private Sub ListBoxMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMembers.SelectedIndexChanged
        If ListBoxTeams.SelectedIndex > -1 Then
            currentMember = ListBoxMembers.SelectedIndex
        End If
    End Sub

    Private Sub ButtonDeleteTeam_Click(sender As Object, e As EventArgs) Handles ButtonDeleteTeam.Click
        optionSelected = 4
        HideButtons()
    End Sub
End Class