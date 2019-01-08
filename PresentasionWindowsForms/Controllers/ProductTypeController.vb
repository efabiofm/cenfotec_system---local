Imports RestSharp
Imports System.Configuration
Imports RestSharp.Deserializers
Imports Newtonsoft.Json

Public Class ProductTypeController

    Shared Function obtenerLista() As List(Of Tipo_Producto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("ProductType", Method.GET)
        request.RootElement = "result"
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim tipos As List(Of Tipo_Producto) = JsonConvert.DeserializeObject(Of List(Of Tipo_Producto))(response.Content)
            Return tipos
        Else
            Return Nothing
        End If
    End Function
End Class
