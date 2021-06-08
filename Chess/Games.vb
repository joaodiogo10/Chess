Imports System.Data.SqlClient

Public Class Games

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentUser As Integer

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub

    Function LoadGame(gameID As UInt32)
        Dim game As Game = New Game

        CMD.Connection = CN
        CMD.CommandText = "dbo.pr_GetGameInfo"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@tournamentName", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@tournamentDate", SqlDbType.DateTime).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@gameID", SqlDbType.Int).Value = gameID

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader


        If (RDR.Read()) Then
            game.GameID = RDR.Item("gameid")
            game.Black = RDR.Item("black")
            game.White = RDR.Item("white")
            game.Duration = RDR.Item("duration")
            game.Pgn = RDR.Item("pgn")
            game.GameDate = RDR.Item("gamedate")
            game.Outcome = RDR.Item("outcome")
            game.FormatName = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("formatname")), "None", RDR.Item("formatname")))
            game.ClockTime = RDR.Item("clocktime")
            game.ClockIncrement = RDR.Item("clockincrement")
            game.OpeningECOCode = RDR.Item("openingecocode")
            game.OpeningName = RDR.Item("openingname")
            game.OpeningPattern = RDR.Item("openingpattern")
            CN.Close()

            game.TournamentName = Convert.ToString(IIf(IsDBNull(CMD.Parameters("@tournamentname").Value), "None", CMD.Parameters("@tournamentname").Value))
            game.TournamentDate = Convert.ToString(IIf(IsDBNull(CMD.Parameters("@tournamentdate").Value), "None", CMD.Parameters("@tournamentdate").Value))
        Else
            CN.Close()

            game = Nothing
            MsgBox("game not found")
        End If


        Return game
    End Function

    Sub ShowGame(game As Game)
        TextBoxBlack.Text = game.Black
        TextBoxWhite.Text = game.White
        TextBoxDuration.Text = game.Duration
        TextBoxDateGame.Text = game.GameDate
        TextBoxOutcome.Text = game.Outcome
        TextBoxOpeningName.Text = game.OpeningName
        TextBoxOpeningCode.Text = game.OpeningECOCode
        TextBoxFormat.Text = game.FormatName
        TextBoxClockTime.Text = game.ClockTime
        TextBoxClockIncrement.Text = game.ClockIncrement
        If (game.TournamentName <> "None") Then
            GroupBoxTournament.Visible = True
            TextBoxTournamentName.Text = game.TournamentName
            TextBoxDateTournament.Text = game.TournamentDate
        Else
            GroupBoxTournament.Visible = False
        End If
    End Sub

    Private Sub ButtonSearchGame_Click(sender As Object, e As EventArgs) Handles ButtonSearchGame.Click
        Dim insertedID As UInt32 = TextBoxSearchGame.Text
        Dim game As Game = LoadGame(insertedID)

        If (game IsNot Nothing) Then
            ShowGame(game)
        End If
    End Sub

End Class