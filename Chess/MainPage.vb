Imports System.Data.SqlClient

Public Class MainPage
    Dim CN As New SqlConnection
    Dim CMD As SqlCommand
    Dim usersForm As Users

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

End Class
