Imports RestSharp
Imports System.Configuration
Imports RestSharp.Deserializers
Imports Newtonsoft.Json

Public Class RolsController

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Shared Function obtener() As List(Of RolModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols", Method.GET)
        request.RootElement = "result"
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim roles As List(Of RolModel) = JsonConvert.DeserializeObject(Of List(Of RolModel))(response.Content)
            Return roles
        Else
            Return Nothing
        End If
    End Function

    Shared Function create(ByVal pnombre As String, ByVal pactivo As String, ByVal plistaPermisos As List(Of PermissionModel)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New RolModel(pnombre, pactivo, plistaPermisos))

        Dim response = client.Execute(Of RolModel)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function getRol(ByVal pid As String) As RolModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols/" + pid, Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim rol As RolModel = JsonConvert.DeserializeObject(Of RolModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return rol
        Else
            Return Nothing
        End If
    End Function

    Shared Function update(ByVal pid As String, ByVal pnombre As String, ByVal pactivo As String, ByVal plistaPermisos As List(Of PermissionModel)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Rols/" + pid, Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New RolModel(CInt(pid), pnombre, pactivo, plistaPermisos))

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
