Imports RestSharp
Imports System.Configuration
Imports Newtonsoft.Json

Public Class PermissionsController
    Public Shared Function getPermissions() As List(Of PermissionModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Permissions", Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim permissions As List(Of PermissionModel) = JsonConvert.DeserializeObject(Of List(Of PermissionModel))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return permissions
        Else
            Return Nothing
        End If
    End Function
End Class
