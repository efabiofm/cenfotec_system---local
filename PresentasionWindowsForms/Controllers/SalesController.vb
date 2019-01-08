Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json

Public Class SalesController
    Shared Function obtenerKpiTotalVentas()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalVentas", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function obtenerTotalMontoVentas()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalMontoVentas", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function RegistrarVenta(ByVal fecha As Date, ByVal monto As Double, ByVal id_usuario As Integer, ByVal tipo As String) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales", Method.POST)
        Dim sale = New Sale

        sale.Tipo = tipo
        sale.Id_Usuario = id_usuario
        sale.Monto = monto
        sale.Fecha = fecha
        sale.Fecha_creacion = Date.Now
        sale.Fecha_actualizacion = Date.Now
        request.RequestFormat = DataFormat.Json
        request.AddBody(sale)
        Dim response = client.Execute(Of Sale)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Shared Function ObtenerListaVentas() As List(Of Sale)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales", Method.GET)
        request.RootElement = "result"
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim ventas As List(Of Sale) = JsonConvert.DeserializeObject(Of List(Of Sale))(response.Content)
            Return ventas
        Else
            Return Nothing
        End If
    End Function
End Class
