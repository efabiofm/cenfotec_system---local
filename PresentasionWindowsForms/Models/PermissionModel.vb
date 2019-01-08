Public Class PermissionModel
    Private _id_permiso As Integer
    Private _nombre As String
    Private _descripcion As String

    Public Sub New()
        _id_permiso = Nothing
        nombre = Nothing
        descripcion = Nothing
    End Sub

    Public Sub New(ByVal pid As Integer)
        id_permiso = pid
    End Sub

    Public Property id_permiso As Integer
        Get
            Return _id_permiso
        End Get
        Set(value As Integer)
            _id_permiso = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class
