Imports System.Data.SqlClient

Public Class GamesDeclareMatch
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim gameID As UInt32

    Sub New(CN As SqlConnection, CMD As SqlCommand, gameID As UInt32)
        InitializeComponent()
        Me.CN = CN
        Me.CMD = CMD
        Me.gameID = gameID
    End Sub
    Private Sub GamesDeclareMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN.Open()
        CMD.CommandType = CommandType.Text
        CMD.CommandText = "SELECT * FROM udf_GetAllOpenings()"
        CMD.Parameters.Clear()

        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader

        ComboBoxOpening.Items.Clear()
        While RDR.Read
            ComboBoxOpening.Items.Add(RDR.Item("Name"))
        End While
        CN.Close()

        ComboBoxTermination.Items.Clear()
        ComboBoxTermination.Items.Add("Time forfeit")
        ComboBoxTermination.Items.Add("Normal")
        ComboBoxTermination.Items.Add("Abandoned")

        ComboBoxResult.Items.Clear()
        ComboBoxResult.Items.Add("Black")
        ComboBoxResult.Items.Add("White")
        ComboBoxResult.Items.Add("Draw")
    End Sub
    Private Sub DeclareMatch()
        CN.Open()
        CMD.Parameters.Clear()
        CMD.CommandText = "pr_CreateRecord"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@Duration", SqlDbType.VarChar, 5).Value = "00:" + DateTimeDuration.Value.TimeOfDay.ToString()
        CMD.Parameters.Add("@PGN", SqlDbType.VarChar, -1).Value = TextBoxPGN.Text
        CMD.Parameters.Add("@Termination", SqlDbType.VarChar, 64).Value = ComboBoxTermination.Text
        CMD.Parameters.Add("@OpeningName", SqlDbType.VarChar, 128).Value = ComboBoxOpening.Text
        CMD.Parameters.Add("@GameID", SqlDbType.Int).Value = gameID
        CMD.Parameters.Add("@Result", SqlDbType.VarChar, 5).Value = ComboBoxResult.Text

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Operation failed. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        End Try
        CN.Close()
        Me.Close()
    End Sub
    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        DeclareMatch()
    End Sub
End Class