Public Class Classification
    Private _user As String
    Private _formatName As String
    Private _formatClock As String
    Private _formatClockIncrement As String
    Private _position As String
    Private _maxRating As String
    Private _currentRating As String

    Public Property User As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Public Property FormatName As String
        Get
            Return _formatName
        End Get
        Set(ByVal value As String)
            _formatName = value
        End Set
    End Property

    Public Property FormatClock As String
        Get
            Return _formatClock
        End Get
        Set(ByVal value As String)
            _formatClock = value
        End Set
    End Property

    Public Property FormatClockIncrement As String
        Get
            Return _formatClockIncrement
        End Get
        Set(ByVal value As String)
            _formatClockIncrement = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property

    Public Property MaxRating As String
        Get
            Return _maxRating
        End Get
        Set(value As String)
            _maxRating = value
        End Set
    End Property

    Public Property CurrentRating As String
        Get
            Return _currentRating
        End Get
        Set(value As String)
            _currentRating = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _position + " " + _user + " " + _currentRating + " " + _maxRating
    End Function

    Public Sub New(user As String, formatName As String, formatClock As String, formatClockIncrement As String, position As String, maxRating As String, currentRating As String)
        _user = user
        _formatName = formatName
        _formatClock = formatClock
        _formatClockIncrement = formatClockIncrement
        _position = position
        _maxRating = maxRating
        _currentRating = currentRating
    End Sub
    Public Sub New()
    End Sub

End Class
