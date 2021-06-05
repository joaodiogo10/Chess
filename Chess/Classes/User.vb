Public Class User
    Private _username As String
    Private _name As String
    Private _password As String
    Private _country As String
    Private _email As String
    Private _registrationDate As String
    Private _title As String

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property RegistrationDate As String
        Get
            Return _registrationDate
        End Get
        Set(ByVal value As String)
            _registrationDate = value
        End Set
    End Property
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Public Sub New(username As String, name As String, password As String, country As String, email As String, registrationDate As String, title As String)
        _username = username
        _name = name
        _password = password
        _country = country
        _email = email
        _registrationDate = registrationDate
        _title = title
    End Sub
    Overrides Function ToString() As String
        Return _username & "   " & _email
    End Function

    Public Sub New()
    End Sub
End Class
