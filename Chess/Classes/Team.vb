Public Class Team

    Private _name As String
    Private _description As String
    Private _leader As String

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Property Leader As String
        Get
            Return _leader
        End Get
        Set(ByVal value As String)
            _leader = value
        End Set
    End Property

    Public Sub New(name As String, description As String, leader As String)
        _name = name
        _description = description
        _leader = leader
    End Sub
    Overrides Function ToString() As String
        Return _name
    End Function
    Public Sub New()
    End Sub
End Class
