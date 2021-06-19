Imports System.Data.SqlClient

Public Class Games

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentGameID As String
    Dim currentOnGoingMatch As Integer
    Dim declareMatch As GamesDeclareMatch
    Dim newGame As GamesNewGame

    Sub New(CN As SqlConnection, CMD As SqlCommand)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
    End Sub
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOnGoingMatches()
    End Sub
    Function LoadGame(gameID As UInt32)
        Dim game As Game = New Game

        CMD.Connection = CN
        CMD.CommandText = "dbo.pr_GetGameInfo"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@tournamentName", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@tournamentDate", SqlDbType.DateTime).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@tournamentTime", SqlDbType.DateTime).Direction = ParameterDirection.Output
        CMD.Parameters.Add("@gameID", SqlDbType.Int).Value = gameID

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader


        If (RDR.Read()) Then
            game.GameID = RDR.Item("gameid")
            game.Black = RDR.Item("black")
            game.White = RDR.Item("white")
            game.Type = RDR.Item("type")
            game.Duration = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("duration")), "None", RDR.Item("duration")))
            game.Pgn = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("pgn")), "None", RDR.Item("pgn")))
            game.GameDate = RDR.Item("date")
            game.GameTime = Convert.ToString(RDR.Item("time"))
            game.Termination = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("termination")), "None", RDR.Item("termination")))
            game.Result = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("result")), "None", RDR.Item("result")))
            game.FormatName = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("formatname")), "None", RDR.Item("formatname")))
            game.ClockTime = RDR.Item("clocktime")
            game.ClockIncrement = RDR.Item("clockincrement")
            game.OpeningECOCode = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("openingecocode")), "None", RDR.Item("openingecocode")))
            game.OpeningName = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("openingname")), "None", RDR.Item("openingname")))
            game.OpeningPattern = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("openingpattern")), "None", RDR.Item("openingpattern")))
            game.Pgn = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("pgn")), "None", RDR.Item("pgn")))
            CN.Close()

            game.TournamentName = Convert.ToString(IIf(IsDBNull(CMD.Parameters("@tournamentname").Value), "None", CMD.Parameters("@tournamentname").Value))
            game.TournamentDate = Convert.ToString(IIf(IsDBNull(CMD.Parameters("@tournamentdate").Value), "None", CMD.Parameters("@tournamentdate").Value))
            currentGameID = gameID
            ShowGame(game)
        Else
            CN.Close()

            game = Nothing
            MsgBox("Game not found")
        End If
        Return game
    End Function
    Sub LoadOnGoingMatches()
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "dbo.pr_getOnGoingGames"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()


        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxOngoingMatches.Items.Clear()
        While RDR.Read
            ListBoxOngoingMatches.Items.Add(RDR.Item("ID"))
        End While
        CN.Close()
    End Sub

    Sub ShowGame(game As Game)
        TextBoxBlack.Text = game.Black
        TextBoxWhite.Text = game.White
        TextBoxDuration.Text = game.Duration
        TextBoxDateGame.Text = game.GameDate
        TextBoxTime.Text = game.GameTime
        TextBoxTermination.Text = game.Termination
        TextBoxWinner.Text = game.Result
        TextBoxOpeningName.Text = game.OpeningName
        TextBoxOpeningCode.Text = game.OpeningECOCode
        TextBoxFormat.Text = game.FormatName
        TextBoxClockTime.Text = game.ClockTime
        TextBoxClockIncrement.Text = game.ClockIncrement
        LabelGameID.Text = currentGameID
        LabelType.Text = game.Type
        TextBoxPGN.Text = game.Pgn

        If (game.Termination <> "None") Then
            ButtonDeclareMatch.Visible = False
        Else
            ButtonDeclareMatch.Visible = True
        End If
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
    End Sub

    Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
        LoadOnGoingMatches()
    End Sub

    Private Sub ListBoxOngoingMatches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxOngoingMatches.SelectedIndexChanged
        If ListBoxOngoingMatches.SelectedIndex > -1 Then
            currentOnGoingMatch = ListBoxOngoingMatches.SelectedIndex
            LoadGame(ListBoxOngoingMatches.Items.Item(currentOnGoingMatch))
        End If
    End Sub

    Private Sub ButtonDeclareMatch_Click(sender As Object, e As EventArgs) Handles ButtonDeclareMatch.Click
        If (currentOnGoingMatch <> -1) Then
            declareMatch = New GamesDeclareMatch(CN, CMD, ListBoxOngoingMatches.Items.Item(currentOnGoingMatch))
            declareMatch.ShowDialog()
            LoadOnGoingMatches()
        End If
    End Sub

    Private Sub ButtonNewGame_Click(sender As Object, e As EventArgs) Handles ButtonNewGame.Click
        newGame = New GamesNewGame(CN, CMD)
        newGame.ShowDialog()
    End Sub
End Class