Public Class Game
    Private _gameID As UInt32
    Private _type As String
    Private _black As String
    Private _white As String
    Private _duration As String
    Private _pgn As String
    Private _date As String
    Private _time As String
    Private _termination As String
    Private _result As String
    Private _formatName As String
    Private _ClockTime As String
    Private _ClockIncrement As String
    Private _openingECOCode As String
    Private _openingName As String
    Private _openingPattern As String
    Private _tournamentName As String
    Private _tournamentDate As String

    Public Property GameID As String
        Get
            Return _gameID
        End Get
        Set(value As String)
            _gameID = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
    Public Property Black As String
        Get
            Return _black
        End Get
        Set(value As String)
            _black = value
        End Set
    End Property

    Public Property White As String
        Get
            Return _white
        End Get
        Set(value As String)
            _white = value
        End Set
    End Property

    Public Property Duration As String
        Get
            Return _duration
        End Get
        Set(value As String)
            _duration = value
        End Set
    End Property

    Public Property Pgn As String
        Get
            Return _pgn
        End Get
        Set(value As String)
            _pgn = value
        End Set
    End Property

    Public Property GameDate As String
        Get
            Return _date
        End Get
        Set(value As String)
            _date = value
        End Set
    End Property

    Public Property GameTime As String
        Get
            Return _time
        End Get
        Set(value As String)
            _time = value
        End Set
    End Property
    Public Property Termination As String
        Get
            Return _termination
        End Get
        Set(value As String)
            _termination = value
        End Set
    End Property

    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            _result = value
        End Set
    End Property

    Public Property FormatName As String
        Get
            Return _formatName
        End Get
        Set(value As String)
            _formatName = value
        End Set
    End Property

    Public Property ClockTime As String
        Get
            Return _ClockTime
        End Get
        Set(value As String)
            _ClockTime = value
        End Set
    End Property

    Public Property ClockIncrement As String
        Get
            Return _ClockIncrement
        End Get
        Set(value As String)
            _ClockIncrement = value
        End Set
    End Property

    Public Property OpeningECOCode As String
        Get
            Return _openingECOCode
        End Get
        Set(value As String)
            _openingECOCode = value
        End Set
    End Property

    Public Property OpeningName As String
        Get
            Return _openingName
        End Get
        Set(value As String)
            _openingName = value
        End Set
    End Property

    Public Property OpeningPattern As String
        Get
            Return _openingPattern
        End Get
        Set(value As String)
            _openingPattern = value
        End Set
    End Property

    Public Property TournamentName As String
        Get
            Return _tournamentName
        End Get
        Set(value As String)
            _tournamentName = value
        End Set
    End Property

    Public Property TournamentDate As String
        Get
            Return _tournamentDate
        End Get
        Set(value As String)
            _tournamentDate = value
        End Set
    End Property


    Public Sub New(gameID As UInteger, black As String, white As String, duration As String, pgn As String, [date] As String, [time] As String, termination As String, result As String, formatName As String, clockTime As String, clockIncrement As String, openingECOCode As String, openingName As String, openingPattern As String, tournamentName As String, tournamentDate As String, type As String)
        _gameID = gameID
        _type = type
        _black = black
        _white = white
        _duration = duration
        _pgn = pgn
        _date = [date]
        _time = [time]
        _termination = termination
        _result = result
        _formatName = formatName
        _ClockTime = clockTime
        _ClockIncrement = clockIncrement
        _openingECOCode = openingECOCode
        _openingName = openingName
        _openingPattern = openingPattern
        _tournamentName = tournamentName
        _tournamentDate = tournamentDate
    End Sub

    Public Sub New()
    End Sub

End Class
