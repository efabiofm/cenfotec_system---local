Public Class RolModel
    Private _id_rol As Integer
    Private _nombre As String
    Private _activo As Boolean
    Private _permisos As List(Of PermissionModel)

    Public Sub New()

    End Sub

    Public Sub New(ByVal pnombre As String, ByVal ppermisos As List(Of PermissionModel))
        nombre = pnombre
        permisos = ppermisos
    End Sub
    Public Sub New(ByVal pnombre As String, pactivo As Boolean, ByVal ppermisos As List(Of PermissionModel))
        id_rol = Nothing
        nombre = pnombre
        activo = pactivo
        permisos = ppermisos
    End Sub
    Public Sub New(ByVal pid As Integer, ByVal pnombre As String, pactivo As Boolean, ByVal ppermisos As List(Of PermissionModel))
        id_rol = pid
        nombre = pnombre
        activo = pactivo
        permisos = ppermisos
    End Sub

    Public Property id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
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

    Public Property permisos As List(Of PermissionModel)
        Get
            Return _permisos
        End Get
        Set(value As List(Of PermissionModel))
            _permisos = value
        End Set
    End Property

    Public Property activo As Boolean

        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property
End Class
