Imports System.Data.SqlClient

Public Class Users
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentUser As Integer

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    'If user not found returns Nothing
    Function LoadUser(username As String)
        Dim user As User = New User

        CN.Open()
        CMD.CommandText = "SELECT * FROM udf_GetUserInfo(@username)"
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = username
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        If (RDR.Read()) Then
            user.Username = RDR.Item("Username")
            user.Name = RDR.Item("Name")
            user.Password = RDR.Item("Password")
            user.Country = RDR.Item("Country")
            user.Email = RDR.Item("Email")
            user.RegistrationDate = RDR.Item("RegistrationDate")
            user.Title = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Title")), "None", RDR.Item("Title")))
        Else
            user = Nothing
            MsgBox("User not found")
        End If

        CN.Close()

        Return User
    End Function
    Sub LoadUsers()
        CMD.CommandText = "SELECT * FROM udf_GetUsersInfo()"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBoxUsers.Items.Clear()
        While RDR.Read
            Dim User As New User With {
                .Username = RDR.Item("Username"),
                .Name = RDR.Item("Name"),
                .Password = RDR.Item("Password"),
                .Country = RDR.Item("Country"),
                .Email = RDR.Item("Email"),
                .RegistrationDate = RDR.Item("RegistrationDate"),
                .Title = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Title")), "None", RDR.Item("Title")))
            }
            ListBoxUsers.Items.Add(User)
        End While
        CN.Close()
        currentUser = 0
        ShowUser(CType(ListBoxUsers.Items.Item(currentUser), User))
    End Sub
    Sub LoadFriends(user As User)
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "SELECT * FROM udf_GetUserFriends(@username)"
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = user.Username
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxFriends.Items.Clear()
        While RDR.Read
            ListBoxFriends.Items.Add(RDR.Item("Friend"))
        End While
        CN.Close()
    End Sub

    Sub LoadTeams(user As User)
        CN.Open()

        CMD.CommandText = "SELECT * FROM udf_GetUserTeams(@username)"
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = user.Username
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxTeams.Items.Clear()
        While RDR.Read
            ListBoxTeams.Items.Add(RDR.Item("Team"))
        End While
        CN.Close()

    End Sub

    Sub ShowUser(user As User)
        TextBoxUsername.Text = user.Username
        TextBoxName.Text = user.Name
        TextBoxPassword.Text = user.Password
        TextBoxCountry.Text = user.Country
        TextBoxEmail.Text = user.Email
        TextBoxRegistrationDate.Text = user.RegistrationDate
        TextBoxTitle.Text = user.Title
        LoadFriends(user)
        LoadTeams(user)
    End Sub

    Private Sub UserList_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBoxUsers.SelectedValueChanged
        If ListBoxUsers.SelectedIndex > -1 Then
            currentUser = ListBoxUsers.SelectedIndex
            ShowUser(CType(ListBoxUsers.Items.Item(currentUser), User))
        End If
    End Sub

    Private Sub ButtonSearchUser_Click(sender As Object, e As EventArgs) Handles ButtonSearchUser.Click
        Dim insertedName As String = TextBoxSearchUser.Text
        Dim user As User = LoadUser(insertedName)
        If (user IsNot Nothing) Then
            ShowUser(user)
        End If
    End Sub
End Class