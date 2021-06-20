Imports System.Data.SqlClient

Public Class Register
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentUser As Integer

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub

    Sub RegisterUser(username As String, password As String, name As String, country As String, email As String)
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "pr_RegisterUser"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = username
        CMD.Parameters.Add("@password", SqlDbType.VarChar, 64).Value = password
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 128).Value = name
        CMD.Parameters.Add("@country", SqlDbType.VarChar, 64).Value = country
        CMD.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = email

        Try
            CMD.ExecuteNonQuery()
            MsgBox("Account registered!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Registration failed. " & vbCrLf & vbCrLf & ex.Message, Title:="Error")
        End Try
        CN.Close()
    End Sub
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        RegisterUser(TextBoxUsername.Text, TextBoxPassword.Text, TextBoxName.Text, TextBoxCountry.Text, TextBoxEmail.Text)
    End Sub

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        If TextBoxPassword.UseSystemPasswordChar Then
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If

    End Sub
End Class