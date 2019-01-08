Imports RestSharp
Imports System.Configuration
Imports Newtonsoft.Json

Public Class SeguimientoController
    Shared Function guardarOActualizar(ByVal id As Integer, ByVal idProspecto As Integer, ByVal fecha As Date, ByVal comentario As String) As Boolean
        Dim nvoSeguimiento = New Seguimiento
        nvoSeguimiento.Id_prospecto = idProspecto
        nvoSeguimiento.Fecha = fecha
        nvoSeguimiento.Comentario = comentario

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request As RestRequest
        If (id <> -1) Then
            nvoSeguimiento.Id_seguimiento = id
            request = New RestRequest("Followups/" + id.ToString, Method.PUT)
            request.RequestFormat = DataFormat.Json
        Else
            request = New RestRequest("Followups", Method.POST)
            request.RequestFormat = DataFormat.Json
        End If
        request.AddBody(nvoSeguimiento)
        Dim response = client.Execute(Of Seguimiento)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created) Or
            (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent))) Then
            Return True
        Else
            Return Nothing
        End If
    End Function

    Shared Function listar(ByVal idProspecto As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Followups/Prospectus/" + idProspecto.ToString, Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim seguimientos As List(Of Seguimiento) = JsonConvert.DeserializeObject(Of List(Of Seguimiento))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return seguimientos
        Else
            Return Nothing
        End If
    End Function

    Shared Function eliminar(ByVal id As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Followups", Method.DELETE)
        request.AddParameter("id", id)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Seguimiento)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return True
        Else
            Return Nothing
        End If
    End Function

    Shared Function getSeguimiento(ByVal id As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Followups", Method.GET)
        request.AddParameter("id", id)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Seguimiento)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return response.Data
        Else
            Return Nothing
        End If
    End Function
End Class
