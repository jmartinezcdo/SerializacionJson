Public Class ActualizacionBD

    Private _fecha As DateTime
    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

    Private _query As String
    Public Property Query() As String
        Get
            Return _query
        End Get
        Set(ByVal value As String)
            _query = value
        End Set
    End Property

End Class
