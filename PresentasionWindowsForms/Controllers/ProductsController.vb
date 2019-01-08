Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Configuration
Imports Newtonsoft.Json
Imports Microsoft.Office.Interop

Public Class ProductsController

    Shared Function getTopProducts()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/getTopProducts", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function

    Shared Function totalProductos()
        Dim resultado As String
        Dim cliente = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Sales/totalProductos", Method.GET)
        Dim respuesta = cliente.Execute(request)
        If (respuesta.Content.Equals(Nothing)) Then
            resultado = "0"
        Else
            resultado = "Resultado de el KPI" & " " & respuesta.Content
        End If
        Return resultado
    End Function
    Shared Function RegistrarProducto(ByVal nombre As String, ByVal costo As Double, ByVal codigo As String, _
                                      ByVal horarios As String, ByVal id_tipo_product As Integer, ByVal fecha_Inicio As Date) As Boolean

        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products", Method.POST)
        Dim producto = New Producto
        producto.Nombre = nombre
        producto.Costo = costo
        producto.Codigo_Producto = codigo
        producto.Horario = horarios
        producto.Id_Tipo_Product = id_tipo_product
        producto.Fecha_inicio = fecha_Inicio
        producto.Fecha_Creacion = Date.Now
        producto.Fecha_actualizacion = Date.Now

        request.RequestFormat = DataFormat.Json
        request.AddBody(producto)
        Dim response = client.Execute(Of Producto)(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.Created)) Then
            Return True
        Else
            Return False
        End If

    End Function
    Shared Function obtenerListaProductos() As List(Of Producto)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products", Method.GET)
        request.RootElement = "result"
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(request)
        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim productos As List(Of Producto) = JsonConvert.DeserializeObject(Of List(Of Producto))(response.Content)
            Return productos
        Else
            Return Nothing
        End If
    End Function

    Shared Function obtenerProducto(ByVal id As Integer)
        Dim client = New RestClient(ConfigurationManager.AppSettings.Get("endpoint"))
        Dim request = New RestRequest("Products/{id}", Method.GET)
        request.RootElement = "result"
        request.AddUrlSegment("id", id)
        request.RequestFormat = DataFormat.Json
        Dim response = client.Execute(Of Producto)(request)

        If (response.StatusCode.Equals(System.Net.HttpStatusCode.OK)) Then
            Dim prod = New Producto
            prod.Costo = response.Data.Costo
            prod.Nombre = response.Data.Nombre
            prod.Codigo_Producto = response.Data.Codigo_Producto
            prod.Id_Tipo_Product = response.Data.Id_Tipo_Product
            prod.Horario = response.Data.Horario
            Return prod
        Else
            Return Nothing
        End If
    End Function

    Shared Sub ImportarProductos(ByVal path As String, ByVal ptipoProdImport As Integer)
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim rango As Excel.Range
        Dim rowNum As Integer
        Dim fieldNum As Integer
        Dim rowCount As Integer
        Dim colCount As Integer
        Dim codProd As String
        Dim nombreProd As String
        Dim costoProd As Double
        Dim costo2 As String
        Dim tipoProd As Integer
        Dim horario As String
        Dim tipoProdImport As Integer
        Dim fecha_inicio As Date
        Dim errores As Boolean
        Dim registrosError As String
        Dim cantRegistros As Integer

        cantRegistros = 0
        tipoProdImport = ptipoProdImport
        horario = ""
        nombreProd = ""
        costoProd = 0
        codProd = ""
        registrosError = ""
        workbook = APP.Workbooks.Open(path)
        worksheet = workbook.Worksheets(1)
        rango = worksheet.UsedRange
        rowNum = 1
        rowCount = worksheet.UsedRange.Rows.Count
        colCount = worksheet.UsedRange.Columns.Count

        If colCount <> 6 Then
            MsgBox("La cantidad de columnas no coincide con la cantidad de campos de la tabla destino. " & vbNewLine _
                   & "Verifique el archivo e inténtelo de nuevo.", MsgBoxStyle.Critical)
            Exit Sub
        Else

            For i = 2 To rowCount
                If CStr(rango.Cells(i, 4).Value) = ptipoProdImport Then
                    cantRegistros = cantRegistros + 1
                End If
            Next
            MsgBox("Se importarán " & cantRegistros & " registros.", MsgBoxStyle.Information)
            For i = 2 To rowCount
                For j = 1 To colCount
                    fieldNum = j

                    Select Case (fieldNum)
                        Case 1
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                codProd = "No Provisto"
                            Else
                                codProd = CStr(rango.Cells(i, j).Value)
                            End If
                        Case 2
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                nombreProd = "No Provisto"
                            Else
                                nombreProd = CStr(rango.Cells(i, j).Value)
                            End If
                        Case 3
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                costo2 = "0"
                            Else
                                costo2 = rango.Cells(i, j).value.ToString()
                            End If
                            costoProd = Double.Parse(costo2)
                        Case 4
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                errores = True
                                tipoProd = tipoProdImport
                            Else
                                tipoProd = Integer.Parse(rango.Cells(i, j).Value.ToString())
                            End If

                        Case 5
                            If CStr(rango.Cells(i, j).Value) = "" Then
                                horario = "No Provisto"
                            Else
                                horario = rango.Cells(i, j).Value.ToString()
                            End If
                        Case 6
                            Dim dia As Integer
                            Dim mes As Integer

                            If CStr(Trim(rango.Cells(i, j).Value)) <> "" Then
                                dia = Left(Trim(CStr(rango.Cells(i, j).Value)), 2)
                                mes = Mid(Trim(CStr(rango.Cells(i, j).Value)), 4, 2)
                                If dia > 31 < 0 Or mes > 12 < 0 Then
                                    fecha_inicio = Date.Parse(Format("01/01/1900"))
                                    errores = True
                                Else
                                    fecha_inicio = Date.Parse(Format(CStr(rango.Cells(i, j).Value)))
                                End If
                            Else
                                fecha_inicio = Date.Parse(Format("01/01/1900"))
                            End If
                        Case Else
                    End Select
                Next j
                If errores Then
                    registrosError = registrosError & codProd & "|" & nombreProd & "|" & Str(costoProd) & "|" & tipoProd & "|" & horario & vbNewLine
                End If
                If tipoProd = tipoProdImport And Not errores Then
                    RegistrarProducto(nombreProd, costoProd, codProd, horario, tipoProd, fecha_inicio)
                End If
            Next i
            If registrosError.Length > 0 Then
                Dim resul = "Los siguientes registros presentaron problemas al tratar de ingresarse en la base de datos: " & vbNewLine _
                & "Código|Nombre|Costo|Tipo|Horario|Fecha Inicio" & registrosError
                MsgBox(resul, MsgBoxStyle.Critical)
            Else
                MsgBox("La información de productos se ingresó correctamente.", MsgBoxStyle.Information)
            End If
            errores = False
            costoProd = 0
            codProd = ""
            nombreProd = ""

        End If
        workbook.Close()
        APP = Nothing
    End Sub

    Shared Sub ExportarProductos(ByVal tipoProd As Integer, ByVal path As String)
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim nombreFile As String = ""
        Dim productos As List(Of Producto) = ProductsController.obtenerListaProductos

        If productos.Count > 0 Then
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add
            oSheet = oBook.Worksheets(1)
            oSheet.Range("A1").value = "Código"
            oSheet.Range("B1").value = "Nombre"
            oSheet.Range("C1").value = "Costo"
            oSheet.Range("D1").value = "Horario"
            Dim i = 2
            For Each prod As Producto In productos
                If prod.Id_Tipo_Product = tipoProd Then
                    oSheet.Range("A" & i).value = Trim(prod.Codigo_Producto)
                    oSheet.Range("B" & i).Value = Trim(prod.Nombre)
                    oSheet.Range("C" & i).Value = Trim(prod.Costo)
                    oSheet.Range("D" & i).value = Trim(prod.Horario)
                    i = i + 1
                End If
            Next prod
            If tipoProd = 1 Then
                nombreFile = "Actis.xlsx"
            End If
            If tipoProd = 2 Then
                nombreFile = "Carreras.xlsx"
            End If
            oSheet.usedRange.EntireColumn.AutoFit()
            oSheet.usedRange.WrapText = False
            If path <> "" Then
                oBook.SaveAs(path & "\" & nombreFile)
                oSheet = Nothing
                oBook = Nothing
                oExcel.Quit()
                oExcel = Nothing
                GC.Collect()
                MsgBox("La información se exportó correctamente.", MsgBoxStyle.Information)
                Process.Start("explorer", "/select," & path & "\" & nombreFile)
            End If
        Else
            MsgBox("No hay información para exportar.", MsgBoxStyle.Critical)
        End If

    End Sub
End Class
