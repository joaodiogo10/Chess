Imports System.Data.SqlClient

Public Class MainPage
    Dim CN As New SqlConnection
    Dim CMD As SqlCommand
    Dim usersForm As Users
    Dim teamsForm As Teams
    Dim gamesForm As Games
    Dim loginForm As Login
    Dim leaderboardsForm As Leaderboards
    Dim registerForm As Register
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source = tcp:mednat.ieeta.pt\SQLSERVER,8101;" & "initial catalog = p1g7;" & "uid=p1g7;" & "password=Baleia2!;")
        CMD = New SqlCommand With {
            .Connection = CN
        }

    End Sub

    Private Sub ButtonUsers_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usersForm = New Users(CN, CMD)
        usersForm.Show()
    End Sub

    Private Sub ButtonTeams_Click(sender As Object, e As EventArgs) Handles ButtonTeams.Click
        teamsForm = New Teams(CN, CMD)
        teamsForm.Show()
    End Sub

    Private Sub ButtonGames_Click(sender As Object, e As EventArgs) Handles ButtonGames.Click
        gamesForm = New Games(CN, CMD)
        gamesForm.Show()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        loginForm = New Login(CN, CMD)
        loginForm.ShowDialog()
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        registerForm = New Register(CN, CMD)
        registerForm.ShowDialog()
    End Sub

    Private Sub ButtonLeaderboards_Click(sender As Object, e As EventArgs) Handles ButtonLeaderboards.Click
        leaderboardsForm = New Leaderboards(CN, CMD)
        leaderboardsForm.Show()
    End Sub
End Class
