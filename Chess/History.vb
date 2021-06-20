Imports System.Data.SqlClient

Public Class History
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentGameID As String
    Dim currentOnGoingMatch As Integer
    Dim username As String

    Sub New(CN As SqlConnection, CMD As SqlCommand, username As String)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
        Me.username = username
    End Sub
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistory()
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
            game.BlackRating = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("blackRating")), "None", RDR.Item("blackRating")))
            game.BlackEarnedRating = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("blackEarnedRating")), "None", RDR.Item("blackEarnedRating")))
            game.WhiteRating = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("whiteRating")), "None", RDR.Item("whiteRating")))
            game.WhiteEarnedRating = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("whiteEarnedRating")), "None", RDR.Item("whiteEarnedRating")))
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
    Sub LoadHistory()
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "SELECT * FROM dbo.udf_getGamesOfPlayer(@username)"
        CMD.CommandType = CommandType.Text
        CMD.Parameters.Add("@username", SqlDbType.VarChar, 64).Value = username
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ListBoxHistory.Items.Clear()
        While RDR.Read
            ListBoxHistory.Items.Add(RDR.Item("Game"))
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

        If (game.Type = "Ranked") Then
            LabelBlackRating.Visible = True
            LabelWhiteRating.Visible = True
            TextBoxBlackRating.Visible = True
            TextBoxBlackRating.Text = game.BlackRating
            LabelBlackRatingEarned.Visible = True
            LabelBlackRatingEarned.Text = game.BlackEarnedRating
            TextBoxWhiteRating.Visible = True
            TextBoxWhiteRating.Text = game.WhiteRating
            LabelWhiteRatingEarned.Visible = True
            LabelWhiteRatingEarned.Text = game.WhiteEarnedRating
        Else
            TextBoxBlackRating.Visible = False
            LabelBlackRatingEarned.Visible = False
            TextBoxWhiteRating.Visible = False
            LabelWhiteRatingEarned.Visible = False
        End If


    End Sub

    Private Sub ListBoxOngoingMatches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxHistory.SelectedIndexChanged
        If ListBoxHistory.SelectedIndex > -1 Then
            currentOnGoingMatch = ListBoxHistory.SelectedIndex
            LoadGame(ListBoxHistory.Items.Item(currentOnGoingMatch))
        End If
    End Sub
End Class