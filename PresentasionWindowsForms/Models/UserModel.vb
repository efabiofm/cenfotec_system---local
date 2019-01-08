Public Class UserModel
    Private _id_usuario As Integer
    Private _cedula As String
    Private _nombre As String
    Private _apellido As String
    Private _correo As String
    Private _telefono As String
    Private _password As String
    Private _id_rol As Integer
    Private _activo As Boolean
    Private _fecha_nacimiento As Date
    Private _rol As RolModel
    Private _prospectos As List(Of Prospecto)
    Private _productos As List(Of Producto)

    Sub New()
        cedula = Nothing
        nombre = Nothing
        apellido = Nothing
        correo = Nothing
        telefono = Nothing
        id_rol = Nothing
        activo = Nothing
        fecha_nacimiento = Nothing
        rol = Nothing
    End Sub

    Sub New(ByVal pemail As String, ByVal ppassword As String)
        cedula = Nothing
        nombre = Nothing
        apellido = Nothing
        correo = pemail
        telefono = Nothing
        id_rol = Nothing
        activo = Nothing
        password = Nothing
        fecha_nacimiento = Nothing
        rol = Nothing
    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String, ByVal pcorreo As String,
            ByVal ptelefono As String, ByVal ppassword As String, ByVal pid_rol As Integer, ByVal pactivo As Boolean,
            ByVal pfechaNacimiento As Date)
        cedula = pcedula
        nombre = pnombre
        apellido = papellido
        correo = pcorreo
        telefono = ptelefono
        id_rol = pid_rol
        activo = pactivo
        password = ppassword
        fecha_nacimiento = pfechaNacimiento
    End Sub

    Sub New(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String, ByVal pcorreo As String,
        ByVal ptelefono As String, ByVal ppassword As String, ByVal pid_rol As Integer, ByVal pactivo As Boolean,
        ByVal pfechaNacimiento As Date, plistaProductos As List(Of Producto))
        cedula = pcedula
        nombre = pnombre
        apellido = papellido
        correo = pcorreo
        telefono = ptelefono
        id_rol = pid_rol
        activo = pactivo
        password = ppassword
        fecha_nacimiento = pfechaNacimiento
        productos = plistaProductos
    End Sub
    Sub New(ByVal pid As Integer, ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String, ByVal pcorreo As String,
            ByVal ptelefono As String, ByVal ppassword As String, ByVal pid_rol As Integer, ByVal pactivo As Boolean,
            ByVal pfechaNacimiento As Date)
        cedula = pcedula
        nombre = pnombre
        apellido = papellido
        correo = pcorreo
        telefono = ptelefono
        id_rol = pid_rol
        activo = pactivo
        password = ppassword
        fecha_nacimiento = pfechaNacimiento
        _id_usuario = pid
    End Sub

    Public Property id_usuario As Integer

        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property cedula As String

        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property apellido As String

        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
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

    Public Property correo As String

        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property telefono As String

        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property password As String

        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property id_rol As Integer

        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
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

    Public Property fecha_nacimiento As Date

        Get
            Return _fecha_nacimiento
        End Get
        Set(value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    Public Property rol As RolModel

        Get
            Return _rol
        End Get
        Set(value As RolModel)
            _rol = value
        End Set
    End Property

    Public Property Prospectos As List(Of Prospecto)
        Get
            Return _prospectos
        End Get
        Set(value As List(Of Prospecto))
            _prospectos = value
        End Set
    End Property

    Public Property productos As List(Of Producto)
        Get
            Return _productos
        End Get
        Set(value As List(Of Producto))
            _productos = value
        End Set
    End Property
End Class
