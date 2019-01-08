Public Class Prospecto
    Private _id_prospecto As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _fecha_nacimiento As Date
    Private _procedencia As String
    Private _estado As Boolean
    Private _telefono As String
    Private _email As String
    Private _direccion As String
    Private _interesado As Boolean
    Private _cliente As Boolean
    Private _tipo_producto As List(Of Tipo_Producto)
    Private _id_evento As Nullable(Of Integer)

    Public Property Id_prospecto As Integer
        Get
            Return _id_prospecto
        End Get
        Set(value As Integer)
            _id_prospecto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Fecha_nacimiento As Date
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As Date)
            _fecha_nacimiento = value
        End Set
    End Property

    Public Property Procedencia As String
        Get
            Return _procedencia
        End Get
        Set(value As String)
            _procedencia = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Interesado As Boolean
        Get
            Return _interesado
        End Get
        Set(value As Boolean)
            _interesado = value
        End Set
    End Property

    Public Property Cliente As Boolean
        Get
            Return _cliente
        End Get
        Set(value As Boolean)
            _cliente = value
        End Set
    End Property

    Public Property Tipo_producto As List(Of Tipo_Producto)
        Get
            Return _tipo_producto
        End Get
        Set(value As List(Of Tipo_Producto))
            _tipo_producto = value
        End Set
    End Property

    Public Property Id_evento As Nullable(Of Integer)
        Get
            Return _id_evento
        End Get
        Set(value As Nullable(Of Integer))
            _id_evento = value
        End Set
    End Property
End Class