Public Class Tipo_Producto

    Private _id_tipo_producto As Integer
    Public Property Id_Tipo_Producto() As String
        Get
            Return _id_tipo_producto
        End Get
        Set(ByVal value As String)
            _id_tipo_producto = value
        End Set
    End Property
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property


End Class


