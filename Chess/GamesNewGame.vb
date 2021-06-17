Imports System.Data.SqlClient

Public Class GamesNewGame
    Dim CN As SqlConnection
    Dim CMD As SqlCommand

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
        ComboBoxType.Items.Add("Ranked")
        ComboBoxType.Items.Add("Casual")
        ComboBoxType.SelectedIndex = 0
    End Sub
    Private Sub GamesNewGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN.Open()
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT * FROM dbo.udf_getAllFormats()"

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        While RDR.Read
            Dim format = New Format
            format.Name = RDR.Item("Name")
            format.Clock = RDR.Item("ClockTime")
            format.ClockIncrement = RDR.Item("ClockIncrement")

            ComboBoxGameFormat.Items.Add(format)
        End While
        ComboBoxGameFormat.SelectedIndex = 0
        CN.Close()
    End Sub

    Sub CreateGame(game As Game, type As String)
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_newGame"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@clockTime", SqlDbType.Int).Value = game.ClockTime
        CMD.Parameters.Add("@clockIncrement", SqlDbType.Int).Value = game.ClockIncrement
        CMD.Parameters.Add("@playerBlack", SqlDbType.VarChar, 64).Value = game.Black
        CMD.Parameters.Add("@playerWhite", SqlDbType.VarChar, 64).Value = game.White
        If (type = "Ranked") Then
            CMD.Parameters.Add("@type", SqlDbType.Bit).Value = 1
        Else
            CMD.Parameters.Add("@type", SqlDbType.Bit).Value = 0
        End If

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Operation failed. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        End Try
        CN.Close()
        Me.Close()
    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        Dim Game = New Game()
        Game.Black = TextBoxPlayerBlack.Text
        Game.White = TextBoxPlayerWhite.Text
        Dim format = CType(ComboBoxGameFormat.SelectedItem, Format)
        Game.ClockTime = format.Clock
        Game.ClockIncrement = format.ClockIncrement

        If ComboBoxType.SelectedItem = "Ranked" Then
            CreateGame(Game, "Ranked")
        Else
            CreateGame(Game, "Casual")
        End If
    End Sub


End Class