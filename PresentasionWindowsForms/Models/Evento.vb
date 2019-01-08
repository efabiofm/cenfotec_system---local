Public Class Evento
    Private _lugar As String
    Private _fecha_inicio As Date
    Private _fecha_fin As Date
    Private _id As Integer

    Public Property Lugar As String
        Get
            Return _lugar
        End Get
        Set(value As String)
            _lugar = value
        End Set
    End Property

    Public Property FechaInicio As Date
        Get
            Return _fecha_inicio
        End Get
        Set(value As Date)
            _fecha_inicio = value
        End Set
    End Property

    Public Property FechaFin As Date
        Get
            Return _fecha_fin
        End Get
        Set(value As Date)
            _fecha_fin = value
        End Set
    End Property

    Public Property IdEvento As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

End Class

