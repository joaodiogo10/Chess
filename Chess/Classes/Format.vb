Public Class Format
    Private _name As String
    Private _clock As UInt16
    Private _clockIncrement As UInt16

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Clock As String
        Get
            Return _clock
        End Get
        Set(value As String)
            _clock = value
        End Set
    End Property

    Public Property ClockIncrement As String
        Get
            Return _clockIncrement
        End Get
        Set(value As String)
            _clockIncrement = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name + " " + Clock + " " + ClockIncrement
    End Function
End Class
