Public Class Producto

    Private _id_Producto As Integer
    Private _nombre As String
    Private _costo As Double
    Private _horario As String
    Private _codigo_producto As String
    Private _id_tipo_product As Integer
    Dim _fecha_inicio As Date
    Dim _fecha_creacion As Date
    Dim _fecha_actualizacion As Date
    Public Property Id_Tipo_Product() As Integer
        Get
            Return _id_tipo_product
        End Get
        Set(ByVal value As Integer)
            _id_tipo_product = value
        End Set
    End Property

    Public Property Codigo_Producto As String
        Get
            Return _codigo_producto
        End Get
        Set(ByVal value As String)
            _codigo_producto = value
        End Set
    End Property

    Public Property Horario() As String
        Get
            Return _horario
        End Get
        Set(ByVal value As String)
            _horario = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
        End Set
    End Property

    Public Property Id_producto() As String
        Get
            Return _id_Producto
        End Get
        Set(ByVal value As String)
            _id_Producto = value
        End Set
    End Property

    Public Property Fecha_Creacion() As Date
        Get
            Return _fecha_creacion
        End Get
        Set(ByVal value As Date)
            _fecha_creacion = value
        End Set
    End Property
    Public Property Fecha_actualizacion() As Date
        Get
            Return _fecha_actualizacion
        End Get
        Set(ByVal value As Date)
            _fecha_actualizacion = value
        End Set
    End Property

    Public Property Fecha_inicio() As Date
        Get
            Return _fecha_inicio
        End Get
        Set(ByVal value As Date)
            _fecha_inicio = value
        End Set
    End Property



End Class