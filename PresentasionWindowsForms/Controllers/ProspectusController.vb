Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json
Imports Microsoft.Office.Interop

Public Class ProspectusController

    Shared Function getTotalProspectosClientes()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalProspectosClientes", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function getTotalProspectos()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTotalProspectos", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function listar()
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectus", Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim prospectos As List(Of Prospecto) = JsonConvert.DeserializeObject(Of List(Of Prospecto))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return prospectos
        Else
            Return Nothing
        End If
    End Function

    Shared Function guardarOActualizar(ByVal id As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal fecha_nacimiento As Date,
                            ByVal procedencia As String, ByVal estado As Boolean, ByVal telefono As String,
                            ByVal email As String, ByVal direccion As String, ByVal estaInteresado As Boolean,
                            ByVal esCliente As Boolean, ByVal intereses As List(Of Tipo_Producto), ByVal idEvento As Integer) As Boolean
        Dim nvoProspecto = New Prospecto
        nvoProspecto.Nombre = nombre
        nvoProspecto.Apellidos = apellidos
        nvoProspecto.Fecha_nacimiento = fecha_nacimiento
        nvoProspecto.Procedencia = procedencia
        nvoProspecto.Estado = estado
        nvoProspecto.Telefono = telefono
        nvoProspecto.Email = email
        nvoProspecto.Direccion = direccion
        nvoProspecto.Interesado = estaInteresado
        nvoProspecto.Cliente = esCliente
        nvoProspecto.Tipo_producto = intereses
        nvoProspecto.Id_evento = idEvento
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request As RestRequest
        If (id <> -1) Then
            nvoProspecto.Id_prospecto = id
            request = New RestRequest("Prospectus/" + id.ToString, Method.PUT)
            request.RequestFormat = DataFormat.Json
        Else
            request = New RestRequest("Prospectus", Method.POST)
            request.RequestFormat = DataFormat.Json
        End If
        request.AddBody(nvoProspecto)
        Dim response = client.Execute(Of Prospecto)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created) Or
            (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent))) Then
            Return True
        Else
            Return Nothing
        End If
    End Function

    Shared Function getProspecto(ByVal id As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Prospectus", Method.GET)
        request.AddParameter("id", id)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Prospecto)(request)
        Dim prospecto As Prospecto = JsonConvert.DeserializeObject(Of Prospecto)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return prospecto
        Else
            Return Nothing
        End If
    End Function

    Shared Sub ImportarProspectos(ByVal path As String)
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim rango As Excel.Range
        Dim rowNum As Integer
        Dim fieldNum As Integer
        Dim rowCount As Integer
        Dim colCount As Integer
        Dim nombre As String
        Dim apellidos As String
        Dim fecha_nacimiento As Date
        Dim procedencia As String
        Dim estado As Boolean
        Dim telefono As String
        Dim email As String
        Dim direccion As String
        Dim estaInteresado As Boolean
        Dim esCliente As Boolean
        Dim dia As Integer
        Dim mes As Integer
        Dim errores As Boolean
        Dim resul As String
        Dim registrosError As String = ""
        Dim intereses As List(Of Tipo_Producto) = Nothing
        Dim tipos As List(Of Tipo_Producto) = Nothing

        workbook = APP.Workbooks.Open(path)
        worksheet = workbook.Worksheets(1)
        rango = worksheet.UsedRange
        rowNum = 1
        rowCount = worksheet.UsedRange.Rows.Count
        colCount = worksheet.UsedRange.Columns.Count
        MsgBox("Se importarán " & rowCount & " registros.", MsgBoxStyle.Information)

        For i = 2 To rowCount
            nombre = ""
            apellidos = ""
            procedencia = ""
            estado = False
            telefono = ""
            email = ""
            direccion = ""
            estaInteresado = False
            esCliente = False
            errores = False
            For j = 1 To colCount
                fieldNum = j
                If CStr(rango.Cells(i, j).Value) = "" Then
                    errores = True
                End If
                Select Case (fieldNum)
                    Case 1
                        nombre = CStr(Trim(rango.Cells(i, j).Value))
                        If nombre = "" Then
                            nombre = "No Provisto"
                        End If
                    Case 2
                        apellidos = CStr(Trim(rango.Cells(i, j).Value))
                    Case 3
                        If CStr(Trim(rango.Cells(i, j).Value)) <> "" Then
                            dia = Left(Trim(rango.Cells(i, j).Value.ToString()), 2)
                            mes = Mid(Trim(rango.Cells(i, j).Value.ToString()), 4, 2)
                            If dia > 31 < 0 Or mes > 12 < 0 Then
                                fecha_nacimiento = Date.Parse(Format("01/01/1900"))
                                errores = True
                            Else
                                fecha_nacimiento = Date.Parse(Format(rango.Cells(i, j).Value.ToString))
                            End If
                        End If
                    Case 4
                        procedencia = CStr(Trim(rango.Cells(i, j).Value))
                        If procedencia = "" Then
                            procedencia = "No Provista"
                        End If
                    Case 5
                        If CStr(UCase(rango.Cells(i, j).Value = "ACTIVO")) Then
                            estado = True
                        Else
                            estado = False
                        End If
                    Case 6
                        If CStr(rango.Cells(i, j).Value) = "" Then
                            telefono = "00000000"
                        Else
                            telefono = CStr(Trim(rango.Cells(i, j).Value))
                        End If
                    Case 7
                        email = CStr(rango.Cells(i, j).Value)
                        If email = "" Then
                            email = "No Provisto"
                        End If
                    Case 8
                        direccion = CStr(Trim(rango.Cells(i, j).Value))
                        If direccion = "" Then
                            direccion = "No Provista"
                        End If
                    Case 9
                        If CStr(UCase(rango.Cells(i, j).Value = "SI")) Then
                            estaInteresado = True
                        Else
                            estaInteresado = False
                        End If
                    Case 10
                        If CStr(UCase(rango.Cells(i, j).Value = "SI")) Then
                            esCliente = True
                        Else
                            esCliente = False
                        End If
                    Case 11
                        tipos = ProductTypeController.obtenerLista
                        intereses = New List(Of Tipo_Producto)
                        If CInt(rango.Cells(i, j).Value) = 3 Then
                            intereses = tipos
                        Else
                            For Each tipo In tipos
                                If CInt(rango.Cells(i, j).Value) = tipo.Id_Tipo_Producto Then
                                    intereses.Add(tipo)
                                End If
                            Next tipo

                        End If
                    Case Else
                End Select
            Next j
            If errores Then
                registrosError = registrosError & nombre & "|" & apellidos & "|" & fecha_nacimiento & "|" & procedencia & "|" & _
                    estado & "|" & telefono & "|" & email & "|" & direccion & "|" & estaInteresado & "|" & esCliente & vbNewLine
            End If
            guardarOActualizar(-1, nombre, apellidos, fecha_nacimiento, procedencia, estado, telefono, email, direccion, estaInteresado, esCliente, intereses, 0)
        Next i
        If registrosError.Length > 0 Then
            resul = "Los siguientes registros presentaron problemas al tratar de ingresarse en la base de datos: " & vbNewLine _
                & "Nombre|Apellidos|Fecha Nac.|Procedencia|Estado|Teléfono|Email|Direccion|Interesado?|Es Cliente?|Intereses" & registrosError
            MsgBox(resul, MsgBoxStyle.Critical)
        End If
        workbook.Close()
        APP = Nothing
    End Sub
End Class
