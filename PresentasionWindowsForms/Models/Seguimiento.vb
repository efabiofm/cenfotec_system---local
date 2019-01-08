Public Class Seguimiento
    Private _id_seguimiento As Integer
    Private _id_prospecto As Integer
    Private _fecha As Date
    Private _comentario As String

    Public Property Id_seguimiento As Integer
        Get
            Return _id_seguimiento
        End Get
        Set(value As Integer)
            _id_seguimiento = value
        End Set
    End Property

    Public Property Id_prospecto As Integer
        Get
            Return _id_prospecto
        End Get
        Set(value As Integer)
            _id_prospecto = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Comentario As String
        Get
            Return _comentario
        End Get
        Set(value As String)
            _comentario = value
        End Set
    End Property
End Class

