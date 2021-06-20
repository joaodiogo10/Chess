Imports System.Data.SqlClient

Public Class Leaderboards

    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub
    Private Sub Leaderboards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN.Open()
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT * FROM udf_getAllFormats()"
        CMD.Parameters.Clear()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ComboBoxFormat.Items.Clear()
        While RDR.Read
            Dim Format As New Format With {
                .Name = RDR.Item("Name"),
                .Clock = RDR.Item("ClockTime"),
                .ClockIncrement = RDR.Item("ClockIncrement")
            }
            ComboBoxFormat.Items.Add(Format)
        End While
        CN.Close()
    End Sub

    Private Sub LeaderboardByFormat()
        Dim selectedFormat As Format
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "pr_getTopElements"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        selectedFormat = CType(ComboBoxFormat.SelectedItem, Format)
        If selectedFormat IsNot Nothing Then
            CMD.Parameters.Add("@ClockTime", SqlDbType.Int).Value = selectedFormat.Clock
            CMD.Parameters.Add("@ClockIncrement", SqlDbType.Int).Value = selectedFormat.ClockIncrement

            If TextBoxTop.Text IsNot "" Then
                CMD.Parameters.Add("@Top", SqlDbType.Int).Value = TextBoxTop.Text


                CMD.ExecuteNonQuery()

                Dim RDR As SqlDataReader
                RDR = CMD.ExecuteReader

                ListBoxLeaderbord.Items.Clear()
                While RDR.Read
                    Dim Classification As New Classification With {
                    .User = RDR.Item("User"),
                    .CurrentRating = RDR.Item("CurrentRating"),
                    .MaxRating = RDR.Item("MaxRating"),
                    .Position = RDR.Item("Position")
                }
                    ListBoxLeaderbord.Items.Add(Classification)
                End While
            Else
                MsgBox("You must choose a top number!")
            End If
        Else
            MsgBox("You must choose a format!")
        End If
        CN.Close()
    End Sub

    Private Sub ShowUserInfo()
        Dim selectedUser As Classification
        selectedUser = CType(ListBoxLeaderbord.SelectedItem, Classification)

        TextBoxCurrent.Text = selectedUser.CurrentRating
        TextBoxMax.Text = selectedUser.MaxRating
        TextBoxPosition.Text = selectedUser.Position
        TextBoxUser.Text = selectedUser.User

    End Sub

    Private Sub ButtonSelect_Click(sender As Object, e As EventArgs) Handles ButtonSelect.Click
        LeaderboardByFormat()
    End Sub

    Private Sub ListBoxLeaderbord_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLeaderbord.SelectedIndexChanged
        ShowUserInfo()
    End Sub
End Class