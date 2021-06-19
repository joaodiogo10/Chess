Imports System.Data.SqlClient

Public Class MainPage
    Dim CN As New SqlConnection
    Dim CMD As SqlCommand
    Dim usersForm As Users
    Dim teamsForm As Teams
    Dim gamesForm As Games
    Dim loginForm As Login
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("data source = localhost;" & "integrated security=true;" & "initial catalog = Chess;")
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
        loginForm.Show()
    End Sub
End Class
