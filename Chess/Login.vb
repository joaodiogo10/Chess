﻿Imports System.Data.SqlClient

Public Class Login

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentUser As Integer
    Dim history As History
    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub

    Private Sub Authenticate(Username As String, Password As String)
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT dbo.udf_AuthenticateUser(@username, @password)"
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = Username
        CMD.Parameters.Add("@password", SqlDbType.VarChar, 64).Value = Password


        CN.Open()
        Dim valid = CMD.ExecuteScalar()
        CN.Close()

        If valid = True Then
            MsgBox("Authenticated")
            Me.Close()
            history = New History(CN, CMD, Username)
            history.Show()
        Else
            MsgBox("Invalid username or password")
        End If
    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Authenticate(TextBoxUsername.Text, TextBoxPassword.Text)
    End Sub

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        If TextBoxPassword.UseSystemPasswordChar Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If

    End Sub
End Class