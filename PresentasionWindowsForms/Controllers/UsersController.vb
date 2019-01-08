Imports RestSharp
Imports System.Configuration
Imports RestSharp.Deserializers
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop

Public Class Users_controller
    Shared Function login(ByVal pcorreo As String, ByVal ppassword As String) As UserModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/Login", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddParameter("correo", pcorreo)
        request.AddParameter("password", ppassword)

        Dim response = client.Execute(request)
        Dim usuario As UserModel = JsonConvert.DeserializeObject(Of UserModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuario
        Else
            Return Nothing
        End If
    End Function


    Shared Sub signOut(ByRef user As UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/SignOut", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(user)
        Dim response = client.Execute(request)
    End Sub

    Shared Function create(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New UserModel(pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(Of UserModel)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function create(ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date, plistaProductos As List(Of Producto)) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users", Method.POST)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New UserModel(pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento, plistaProductos))

        Dim response = client.Execute(Of UserModel)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function update(ByVal pid As String, ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/" + pid, Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddBody(New UserModel(CInt(pid), pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function updateUserAndPassword(ByVal pid As String, ByVal pcedula As String, ByVal pnombre As String, ByVal papellido As String,
                           ByVal pemail As String, ByVal pphone As String, ByVal ppassword As String,
                           ByVal pidRol As Integer, ByVal pactivo As Boolean, ByVal pfecha_nacimiento As Date) As Boolean
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/change/{id}", Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddUrlSegment("id", pid)
        request.AddBody(New UserModel(CInt(pid), pcedula, pnombre, papellido, pemail, pphone, ppassword, pidRol, pactivo, pfecha_nacimiento))

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function getUsers() As List(Of UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users", Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim usuarios As List(Of UserModel) = JsonConvert.DeserializeObject(Of List(Of UserModel))(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuarios
        Else
            Return Nothing
        End If
    End Function

    Shared Function getUser(ByVal pid As String) As UserModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/" + pid, Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim usuario As UserModel = JsonConvert.DeserializeObject(Of UserModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuario
        Else
            Return Nothing
        End If
    End Function

    Shared Function assignProspectus(ByVal usuario As UserModel)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/assign/" + usuario.id_usuario.ToString, Method.PUT)
        request.RequestFormat = DataFormat.Json
        request.AddBody(usuario)

        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.NoContent)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function getProspectusAssigned(ByVal pid As String) As UserModel
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Users/getassign/" + pid, Method.GET)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        Dim usuario As UserModel = JsonConvert.DeserializeObject(Of UserModel)(response.Content)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Return usuario
        Else
            Return Nothing
        End If
    End Function

    Shared Sub ImportarUsuarios(ByVal path As String, ByVal tipo As Integer)
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
        Dim cedula As String
        Dim estado As Boolean
        Dim telefono As String
        Dim email As String
        Dim dia As Integer
        Dim mes As Integer
        Dim anio As Integer
        Dim errores As Boolean
        Dim resul As String
        Dim password As String
        Dim idRol As Integer
        Dim registrosError As String = ""
        Dim mensajeError As String
        Dim usuarios As New List(Of UserModel)
        Dim registrosBitacora As New Dictionary(Of String, String)()
        Dim cursosActivos As List(Of Producto) = New List(Of Producto)
        Dim cursosAImportar As List(Of Producto) = New List(Of Producto)

        usuarios = getUsers()
        workbook = APP.Workbooks.Open(path)
        worksheet = workbook.Worksheets(1)
        rango = worksheet.UsedRange
        rowNum = 1
        rowCount = worksheet.UsedRange.Rows.Count
        colCount = worksheet.UsedRange.Columns.Count

        If colCount - 1 <> 7 Then
            MsgBox("La cantidad de columnas no coincide con la cantidad de campos de la tabla destino. " & vbNewLine _
                   & "Verifique el archivo e inténtelo de nuevo.", MsgBoxStyle.Critical)
            Exit Sub
        Else
            MsgBox("Se importarán " & rowCount & " registros.", MsgBoxStyle.Information)
            cursosActivos = ProductsController.obtenerListaProductos
            If cursosActivos.Count = 0 Then
                MsgBox("No se han encontrado productos. Primero debe cargar los cursos relacionados en la base de datos.", MsgBoxStyle.Critical)
            Else
                For i = 2 To rowCount
                    nombre = ""
                    apellidos = ""
                    cedula = ""
                    estado = False
                    telefono = ""
                    email = ""
                    idRol = 0
                    errores = False
                    mensajeError = ""

                    For j = 1 To colCount
                        fieldNum = j
                        If CStr(rango.Cells(i, j).Value) = "" Then
                            errores = True
                        End If
                        Select Case (fieldNum)
                            Case 1 'Num Cedula
                                Dim regularExpression As New Regex("^[0-9]{9,15}$")
                                cedula = CStr(Trim(rango.Cells(i, j).Value))
                                If CStr(rango.Cells(i, j).Value) = "" Or Not regularExpression.IsMatch(cedula) Then
                                    errores = True
                                    mensajeError = mensajeError & "Formato de cédula incorrecto"
                                Else
                                    cedula = CStr(Trim(rango.Cells(i, j).Value))
                                    For Each user In usuarios
                                        If cedula = user.cedula And Not errores Then
                                            errores = True
                                            mensajeError = mensajeError & "Ya existe un usuario con ese número de cédula"
                                        End If
                                    Next
                                End If
                            Case 2 'Nombre
                                nombre = CStr(Trim(rango.Cells(i, j).Value))
                                If nombre = "" Then
                                    errores = True
                                    mensajeError = mensajeError & "Nombre no provisto"
                                End If
                            Case 3 'Apellidos
                                apellidos = CStr(Trim(rango.Cells(i, j).Value))
                                If apellidos = "" Then
                                    errores = True
                                    mensajeError = mensajeError & "Apellidos no provistos"
                                End If
                            Case 4 'Email
                                Dim emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
                                email = CStr(rango.Cells(i, j).Value)
                                If email = "" Then
                                    errores = True
                                    mensajeError = mensajeError & "|" & "Formato de email incorrecto"
                                ElseIf emailExpression.IsMatch(email) Then
                                    email = CStr(Trim(rango.Cells(i, j).Value))
                                Else
                                End If
                            Case 5 'fechaNac
                                If CStr(Trim(rango.Cells(i, j).Value)) <> "" Then
                                    dia = Left(Trim(rango.Cells(i, j).Value.ToString()), 2)
                                    mes = Mid(Trim(rango.Cells(i, j).Value.ToString()), 4, 2)
                                    anio = Mid(Trim(rango.Cells(i, j).Value.ToString()), 7, 4)
                                    If dia > 31 < 0 Or mes > 12 < 0 Then
                                        errores = True
                                        mensajeError = mensajeError & "Formato de fecha incorrecto"
                                    Else
                                        fecha_nacimiento = Date.Parse(Format(rango.Cells(i, j).Value.ToString))
                                    End If
                                End If
                            Case 6 'Telefono
                                Dim regularExpression As New Regex("^[0-9]{8,15}$")
                                telefono = CStr(Trim(rango.Cells(i, j).Value))
                                If CStr(rango.Cells(i, j).Value) = "" Or Not regularExpression.IsMatch(telefono) Then
                                    errores = True
                                    mensajeError = mensajeError & "Formato de teléfono incorrecto"
                                End If
                            Case 7 'Estado
                                If CStr(UCase(rango.Cells(i, j).Value) = "ACTIVO") Then
                                    estado = True
                                Else
                                    estado = False
                                End If
                            Case 8 'Cursos
                                If Len(CStr(rango.Cells(i, j).Value)) > 0 And cursosActivos.Count > 0 Then '12
                                    Dim cursos As String 'Valor 
                                    Dim listaCursos As String() 'Lista generada luego de dividir la cadena de texto en códigos individuales.
                                    Dim h As Integer
                                    Dim isProdAvailable As Boolean = False
                                    cursos = UCase(rango.Cells(i, j).Value)
                                    listaCursos = cursos.Split(New Char() {","c})
                                    For Each curso In listaCursos
                                        For h = 0 To cursosActivos.Count - 1
                                            If curso.Equals(cursosActivos(h).Codigo_Producto) Then
                                                cursosAImportar.Add(cursosActivos(h))
                                            End If
                                        Next
                                    Next curso
                                Else '12
                                    errores = True
                                    mensajeError = mensajeError & "|Requiere tener al menos un curso matriculado."
                                End If '12
                            Case Else
                        End Select
                    Next j

                    If errores Then
                        registrosError = registrosError & Str(i) & "|" & nombre & "|" & apellidos & "|" & mensajeError & vbNewLine
                    Else
                        password = "UCenfotec" & anio 'Default password
                        If tipo = 1 Then
                            idRol = 5
                        Else
                            idRol = 4
                        End If
                        create(cedula, nombre, apellidos, email, telefono, password, idRol, estado, fecha_nacimiento, cursosAImportar)
                    End If
                Next i
                If registrosError.Length > 0 Then
                    resul = "Los siguientes registros presentaron problemas al tratar de ingresarse en la base de datos: " & vbNewLine _
                        & "Num.Registro|Nombre|Apellidos|Error" & vbNewLine & registrosError
                    MsgBox(resul, MsgBoxStyle.Critical)
                End If
                workbook.Close()
                APP = Nothing
            End If
        End If
    End Sub
End Class
