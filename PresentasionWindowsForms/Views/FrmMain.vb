Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports PresentasionWindowsForms.My.Resources

Public Class FrmMain
    Shared tipoImport As Integer
    Shared tipoExport As Integer
    Shared tipoProdImport As Integer
    Shared modProduct As Boolean = False
    Private user As UserModel

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Login</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Login</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Sub New(ByRef puser As UserModel)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        user = puser
        Me.Text = user.nombre + " " + user.apellido + " - " + user.rol.nombre
        'Me.tActis.Visible = False
        'Me.tCareers.Visible = False
        Me.Main.TabPages.Remove(Me.TabProductos)
        Me.Main.TabPages.Remove(Me.TabProspectos)
        Me.Main.TabPages.Remove(Me.TabVentas)
        Me.Main.TabPages.Remove(Me.Eventos)
        Me.Main.TabPages.Remove(Me.KPIHolder)
        Me.Main.TabPages.Remove(Me.TabUsuarios)
        Me.Main.TabPages.Remove(Me.TabReportes)
        Me.Main.TabPages.Remove(Me.TabConfiguracion)
    End Sub

    Dim idEventoModificar As Integer

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarEventos()
        Me.llenarListaProspectos()
        llenarTablaActis()
    End Sub

    Private Sub btnCrearEvento_Click(sender As Object, e As EventArgs) Handles btnCrearEvento.Click
        PanelListarEventos.Visible = False
        PanelListarEventos.Enabled = False
        PanelCrearEvento.Enabled = True
        PanelCrearEvento.Visible = True
    End Sub

    Private Sub btnCancelarEvento_Click(sender As Object, e As EventArgs) Handles btnCancelarEvento.Click
        PanelListarEventos.Visible = True
        PanelListarEventos.Enabled = True
        PanelCrearEvento.Enabled = False
        PanelCrearEvento.Visible = False
    End Sub

    Private Sub btnGuardarEvento_Click(sender As Object, e As EventArgs) Handles btnGuardarEvento.Click
        Dim objecto = EventosController.CrearEvento(idEventoModificar, TxtnombreEventos.Text, dateEventos.Text, dateFin.Text)
        If (objecto.Equals(True)) Then
            MsgBox("El Evento se creo con exito", MsgBoxStyle.Information, "Evento Guardado")
            Me.llenarEventos()
        Else
            MsgBox("El Evento se creo con exito", MsgBoxStyle.Critical, "Error")
        End If
        idEventoModificar = Nothing
        PanelListarEventos.Visible = True
        PanelListarEventos.Enabled = True
        PanelCrearEvento.Enabled = False
        PanelCrearEvento.Visible = False
    End Sub

    Private Sub llenarEventos()
        DataListarEventos.Rows.Clear()
        Dim eventos = EventosController.ListarEventos()
        If (Not eventos.Equals(Nothing)) Then
            For Each eve As Evento In eventos
                DataListarEventos.Rows.Add(eve.Lugar, eve.FechaInicio, eve.FechaFin, eve.IdEvento)
            Next
        End If
    End Sub


    Private Sub DataListarEventos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListarEventos.CellContentClick
        Dim id As String = DataListarEventos.Rows(e.RowIndex).Cells(3).Value
        Select Case e.ColumnIndex
            Case 4
                Dim evento As Evento = EventosController.getEvento(id)
                idEventoModificar = evento.IdEvento
                TxtnombreEventos.Text = evento.Lugar
                dateEventos.Text = evento.FechaInicio
                dateFin.Text = evento.FechaFin
                PanelListarEventos.Visible = False
                PanelCrearEvento.Visible = True
            Case 5
                Dim result = EventosController.eliminar(id)
                If (result.Equals(True)) Then
                    DataListarEventos.Rows.Remove(DataListarEventos.Rows(e.RowIndex))
                    MsgBox("El evento se elimino con exito", 0, "Exito")
                Else
                    MsgBox("No se pudo eliminar el evento", 0, "Error")
                End If
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub TileKpiVentas_Click(sender As Object, e As EventArgs) Handles TileKpiVentas.Click
        panSeleccionarTipoKPI.Visible = False
        panKpiVentas.Visible = True
        pnlKpiProspectos.Visible = False
        pnlCrearKpiProducto.Visible = False
    End Sub

    Private Sub TileKpiProspecto_Click(sender As Object, e As EventArgs) Handles TileKpiProspecto.Click
        panSeleccionarTipoKPI.Visible = False
        pnlKpiProspectos.Visible = True
        panKpiVentas.Visible = False
        pnlCrearKpiProducto.Visible = False
    End Sub

    Private Sub TileKpiProductos_Click(sender As Object, e As EventArgs) Handles TileKpiProductos.Click
        panSeleccionarTipoKPI.Visible = False
        pnlCrearKpiProducto.Visible = True
        pnlKpiProspectos.Visible = False
        panKpiVentas.Visible = False
    End Sub

    Private Sub btnCrearKpiProducto_Click(sender As Object, e As EventArgs) Handles btnCrearKpiProducto.Click
        Dim resultado As String = ""
        If (checkBoxTotalProducto.Checked) Then
            resultado = ProductsController.totalProductos()
        ElseIf (checkBoxTotalProducto.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If
        TextBoxResultadoKpiProductos.AppendText(resultado)
        TextBoxResultadoKpiProductos.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCrearKpiVenta_Click(sender As Object, e As EventArgs) Handles btnCrearKpiVenta.Click
        Dim resultado As String = ""
        If (checkBoxMontoTotalVentas.Checked) Then
            resultado = SalesController.obtenerKpiTotalVentas()
        ElseIf (checkBoxTotalVentas.Checked) Then
            resultado = SalesController.obtenerTotalMontoVentas()
        End If
        If (checkBoxTotalVentas.Checked = False And checkBoxMontoTotalVentas.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If

        TextBoxResultadosVentas.AppendText(resultado)
        TextBoxResultadosVentas.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCancelarKpiVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiVenta.Click
        panKpiVentas.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    Private Sub BtnGenerarKpiProspecto_Click(sender As Object, e As EventArgs) Handles BtnGenerarKpiProspecto.Click
        Dim resultado As String = ""
        If (checkBoxTotalProspectos.Checked) Then
            resultado = ProspectusController.getTotalProspectos()
        ElseIf (checkboxTotalProspetosCliente.Checked) Then
            resultado = ProspectusController.getTotalProspectosClientes()
        End If
        If (checkboxTotalProspetosCliente.Checked = False And checkBoxTotalProspectos.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If
        TextBoxResultadosKpiProspectos.AppendText(resultado)
        TextBoxResultadosKpiProspectos.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCancelarKpiProspecto_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiProspecto.Click
        pnlKpiProspectos.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    Private Sub btnCancelarKpiProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiProducto.Click
        pnlCrearKpiProducto.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    '//////////////////////////////////////// PROSPECTOS ////////////////////////////////////////

    Private Sub llenarListaProspectos()
        Dim prospectos = ProspectusController.listar()
        If (Not prospectos.Equals(Nothing)) Then
            For Each prosp As Prospecto In prospectos
                lstProspectos.Rows.Add(prosp.Id_prospecto, prosp.Nombre, prosp.Apellidos, Format(prosp.Fecha_nacimiento, "dd-MM-yyyy"),
                                       prosp.Procedencia, prosp.Telefono, prosp.Email)
            Next
        End If
    End Sub

    Private Sub btnCrearProspecto_Click(sender As Object, e As EventArgs) Handles btnCrearProspecto.Click
        If lblIdProspecto.Equals(-1) Then
            lblCrearProspectos.Text = "Editar prospecto"
        Else
            lblCrearProspectos.Text = "Crear prospecto"
        End If
        btnNuevoSeguimiento.Visible = False
        btnListarSeguimientos.Visible = False
        PnlListaProspectos.Visible = False
        PnlNuevoProspecto.Visible = True
    End Sub

    Private Sub btnCancelarProspecto_Click(sender As Object, e As EventArgs) Handles btnCancelarProspecto.Click
        Me.limpiarFormProspectos()
        PnlListaProspectos.Visible = True
        PnlNuevoProspecto.Visible = False
    End Sub

    Private Sub limpiarFormProspectos()
        lblIdProspecto.Text = -1
        txtNombreProspecto.Clear()
        txtApellidosProspecto.Clear()
        txtFechaNacProspecto.Value = Date.Now
        txtProcedenciaProspecto.Clear()
        txtProcedenciaProspecto.Enabled = True
        tglEstadoProspecto.Checked = True
        txtTelProspecto.Clear()
        txtEmailProspecto.Clear()
        txtDireccionProspecto.Clear()
        tglEstaInteresado.Checked = False
        tglEsCliente.Checked = False
        ckbEventoProspecto.Checked = False
        cbEventos.DataSource = Nothing
    End Sub

    Private Sub btnGuardarProspecto_Click(sender As Object, e As EventArgs) Handles btnGuardarProspecto.Click
        Dim listaIntereses As New List(Of Tipo_Producto)
        Dim idEvento = Nothing
        If (tglEstaInteresado.Checked = True) Then
            Dim idInteres = (DirectCast(cbInteresesProspecto.SelectedItem, KeyValuePair(Of Integer, String)).Key)
            Dim nombreInteres = Nothing
            If idInteres = 0 Then
                For x As Integer = 1 To cbInteresesProspecto.Items.Count - 1
                    Dim interes As New Tipo_Producto
                    idInteres = DirectCast(cbInteresesProspecto.Items.Item(x), KeyValuePair(Of Integer, String)).Key
                    nombreInteres = DirectCast(cbInteresesProspecto.Items.Item(x), KeyValuePair(Of Integer, String)).Value
                    interes.Id_Tipo_Producto = idInteres
                    interes.Nombre = nombreInteres
                    listaIntereses.Add(interes)
                Next
            Else
                Dim interes As New Tipo_Producto
                nombreInteres = DirectCast(cbInteresesProspecto.SelectedItem, KeyValuePair(Of Integer, String)).Value
                interes.Id_Tipo_Producto = idInteres
                interes.Nombre = nombreInteres
                listaIntereses.Add(interes)
            End If
        End If
        If (ckbEventoProspecto.Checked = True) Then
            idEvento = DirectCast(cbEventos.SelectedItem, KeyValuePair(Of Integer, String)).Key
        End If
        If validateProspectusForm() Then
            Dim resul = ProspectusController.guardarOActualizar(CInt(lblIdProspecto.Text), txtNombreProspecto.Text, txtApellidosProspecto.Text, txtFechaNacProspecto.Value,
                                         txtProcedenciaProspecto.Text, tglEstadoProspecto.Checked, txtTelProspecto.Text,
                                         txtEmailProspecto.Text, txtDireccionProspecto.Text, tglEstaInteresado.Checked,
                                         tglEsCliente.Checked, listaIntereses, idEvento)
            If (resul.Equals(True)) Then
                MsgBox(respuestasDelSistema.CREATE_USER_SUCCESS, MsgBoxStyle.Information)
            Else
                MsgBox(respuestasDelSistema.CREATE_USER_ERROR, MsgBoxStyle.Critical)
            End If
            lstProspectos.Rows.Clear()
            Me.llenarListaProspectos()
            Me.limpiarFormProspectos()
            PnlListaProspectos.Visible = True
            PnlNuevoProspecto.Visible = False
            lblIdProspecto.Text = -1
        End If
    End Sub

    Public Function validateProspectusForm() As Boolean
        Dim result As Boolean = True
        If Not IsEmail(txtEmailProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailProspecto, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtTelProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtTelProspecto, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If String.IsNullOrEmpty(txtNombreProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtNombreProspecto, ValidationsMessages.EMPTY_FIELD)
        End If
        If String.IsNullOrEmpty(txtApellidosProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtApellidosProspecto, ValidationsMessages.EMPTY_FIELD)
        End If
        If String.IsNullOrEmpty(txtProcedenciaProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtProcedenciaProspecto, ValidationsMessages.EMPTY_FIELD)
        End If
        Return result
    End Function

    Private Sub lstProspectos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstProspectos.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim id As String = lstProspectos.Rows(e.RowIndex).Cells(0).Value
            Dim ppros As Prospecto = ProspectusController.getProspecto(id)
            lblIdProspecto.Text = ppros.Id_prospecto
            txtNombreProspecto.Text = ppros.Nombre
            txtApellidosProspecto.Text = ppros.Apellidos
            txtFechaNacProspecto.Text = ppros.Fecha_nacimiento
            txtProcedenciaProspecto.Text = ppros.Procedencia
            tglEstadoProspecto.Checked = ppros.Estado
            txtTelProspecto.Text = ppros.Telefono
            txtEmailProspecto.Text = ppros.Email
            txtDireccionProspecto.Text = ppros.Direccion
            tglEstaInteresado.Checked = ppros.Interesado
            tglEsCliente.Checked = ppros.Cliente
            btnNuevoSeguimiento.Visible = True
            btnListarSeguimientos.Visible = True
            PnlListaProspectos.Visible = False
            PnlNuevoProspecto.Visible = True
            If (Not ppros.Id_evento.Equals(Nothing)) Then
                ckbEventoProspecto.Checked = True
                For x As Integer = 0 To cbEventos.Items.Count - 1
                    If (ppros.Id_evento.Equals(DirectCast(cbEventos.Items.Item(x), KeyValuePair(Of Integer, String)).Key)) Then
                        cbEventos.SelectedItem = cbEventos.Items.Item(x)
                    End If
                Next
            End If
            If tglEstaInteresado.Checked = True Then
                If ppros.Tipo_producto.Count > 1 Then
                    cbInteresesProspecto.SelectedItem = cbInteresesProspecto.Items.Item(0)
                Else
                    cbInteresesProspecto.SelectedItem = cbInteresesProspecto.Items.Item(ppros.Tipo_producto(0).Id_Tipo_Producto)
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Sub llenarComboIntereses()
        Dim tipos = ProductTypeController.obtenerLista()
        Dim comboData As New Dictionary(Of Integer, String)()
        comboData.Add(0, "Todo")
        If tipos.Count > 0 Then
            For Each tipo As Tipo_Producto In tipos
                comboData.Add(tipo.Id_Tipo_Producto, tipo.Nombre)
            Next
            cbInteresesProspecto.DataSource = New BindingSource(comboData, Nothing)
            cbInteresesProspecto.DisplayMember = "Value"
            cbInteresesProspecto.ValueMember = "Key"
        End If
    End Sub

    Public Sub llenarComboEventos()
        Dim eventos = EventosController.ListarEventos()
        Dim comboData As New Dictionary(Of Integer, String)()
        If (eventos.Count > 0) Then
            For Each evento As Evento In eventos
                comboData.Add(evento.IdEvento, evento.Lugar)
            Next
            cbEventos.DataSource = New BindingSource(comboData, Nothing)
            cbEventos.DisplayMember = "Value"
            cbEventos.ValueMember = "Key"
        End If
    End Sub

    Private Sub tglEstaInteresado_CheckedChanged(sender As Object, e As EventArgs) Handles tglEstaInteresado.CheckedChanged
        If (tglEstaInteresado.Checked = True) Then
            cbInteresesProspecto.Enabled = True
            llenarComboIntereses()
        Else
            cbInteresesProspecto.Enabled = False
            cbInteresesProspecto.SelectedItem = Nothing
        End If
    End Sub

    Private Sub ckbEventoProspecto_CheckedChanged(sender As Object, e As EventArgs) Handles ckbEventoProspecto.CheckedChanged
        If (ckbEventoProspecto.Checked = True) Then
            cbEventos.Enabled = True
            llenarComboEventos()
        Else
            cbEventos.Enabled = False
            cbEventos.SelectedItem = Nothing
        End If
    End Sub

    Private Sub tglEstadoProspecto_CheckedChanged(sender As Object, e As EventArgs) Handles tglEstadoProspecto.CheckedChanged
        If tglEstadoProspecto.Checked = True Then
            habilitarFormProspectos(True)
        Else
            habilitarFormProspectos(False)
        End If
    End Sub

    Private Sub habilitarFormProspectos(ByVal valor As Boolean)
        txtNombreProspecto.Enabled = valor
        txtApellidosProspecto.Enabled = valor
        txtFechaNacProspecto.Enabled = valor
        txtEmailProspecto.Enabled = valor
        txtTelProspecto.Enabled = valor
        txtProcedenciaProspecto.Enabled = valor
        txtDireccionProspecto.Enabled = valor
        tglEstaInteresado.Enabled = valor
        tglEsCliente.Enabled = valor
        ckbEventoProspecto.Enabled = valor
        If tglEstaInteresado.Checked = True Then
            cbInteresesProspecto.Enabled = valor
        End If
        If ckbEventoProspecto.Checked = True Then
            cbEventos.Enabled = valor
        End If
    End Sub

    Private Sub btnAsignarProspecto_Click_1(sender As Object, e As EventArgs) Handles btnAsignarProspecto.Click
        PnlListaProspectos.Visible = False
        pnlAsignarProspecto.Visible = True
        llenarListBoxVendedores()
    End Sub

    Dim data1 As New Dictionary(Of Integer, String)()
    Dim data2 As New Dictionary(Of Integer, String)()
    Dim data3 As New Dictionary(Of Integer, String)()

    Public Sub llenarListBoxVendedores()
        If data1.Count.Equals(0) Then
            Dim users = Users_controller.getUsers()
            If users.Count > 0 Then
                For Each user As UserModel In users
                    Dim rol As RolModel = RolsController.getRol(user.id_rol)
                    If rol.nombre.Equals("Telemercadeo") Or rol.nombre.Equals("Ventas") Then
                        data1.Add(user.id_usuario, user.nombre + " " + user.apellido)
                    End If
                Next
                ltbVendedoresSlt.DataSource = New BindingSource(data1, Nothing)
                ltbVendedoresSlt.DisplayMember = "Value"
                ltbVendedoresSlt.ValueMember = "Key"
            End If
        End If
    End Sub

    Public Sub llenarListBoxProspectos()
        Dim users = Users_controller.getUsers()
        If data2.Count.Equals(0) Then
            Dim prospectos = ProspectusController.listar()
            If prospectos.Count > 0 Then
                For Each prosp As Prospecto In prospectos
                    If Not yaFueAsignado(prosp.Id_prospecto, users) And prosp.Estado.Equals(True) Then
                        data2.Add(prosp.Id_prospecto, prosp.Nombre + " " + prosp.Apellidos)
                    End If
                Next
                If data2.Count > 0 Then
                    ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
                    ltbProspectosSlt.DisplayMember = "Value"
                    ltbProspectosSlt.ValueMember = "Key"
                End If
            End If
        End If
    End Sub

    Public Function yaFueAsignado(ByVal idProsp As Integer, ByVal users As List(Of UserModel)) As Boolean
        For Each usuario In users
            usuario = Users_controller.getProspectusAssigned(usuario.id_usuario)
            For Each prospecto In usuario.Prospectos
                If idProsp.Equals(prospecto.Id_prospecto) Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub btnCancelarAsignarProsp_Click(sender As Object, e As EventArgs) Handles btnCancelarAsignarProsp.Click
        data1.Clear()
        data2.Clear()
        data3.Clear()
        pnlAsignarProspecto.Visible = False
        PnlListaProspectos.Visible = True
    End Sub

    Private Sub btnAsignarListaProsp_Click(sender As Object, e As EventArgs) Handles btnAsignarListaProsp.Click
        If (data2.Count > 0) Then
            Dim llave = DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim valor = DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Value
            data3.Add(llave, valor)
            data2.Remove(DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key)

            ltbProspectosSlt.DataSource = Nothing
            If data2.Count > 0 Then

                ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
                ltbProspectosSlt.DisplayMember = "Value"
                ltbProspectosSlt.ValueMember = "Key"
            End If

            ltbProspAsignados.DataSource = Nothing
            If data3.Count > 0 Then

                ltbProspAsignados.DataSource = New BindingSource(data3, Nothing)
                ltbProspAsignados.DisplayMember = "Value"
                ltbProspAsignados.ValueMember = "Key"
            End If
        End If
    End Sub

    Private Sub btnQuitarProspAsignado_Click(sender As Object, e As EventArgs) Handles btnQuitarProspAsignado.Click
        If data3.Count > 0 Then
            Dim llave = DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim valor = DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Value
            data2.Add(llave, valor)
            data3.Remove(DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Key)
            ltbProspAsignados.DataSource = Nothing

            If data3.Count > 0 Then
                ltbProspAsignados.DataSource = New BindingSource(data3, Nothing)
                ltbProspAsignados.DisplayMember = "Value"
                ltbProspAsignados.ValueMember = "Key"
            End If

            ltbProspectosSlt.DataSource = Nothing
            If data2.Count > 0 Then
                ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
                ltbProspectosSlt.DisplayMember = "Value"
                ltbProspectosSlt.ValueMember = "Key"
            End If
            
        End If
    End Sub

    Private Sub ltbVendedoresSlt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbVendedoresSlt.SelectedIndexChanged
        data2.Clear()
        data3.Clear()
        ltbProspAsignados.DataSource = Nothing

        Dim idVendedor = DirectCast(ltbVendedoresSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim vendedor = Users_controller.getProspectusAssigned(idVendedor.ToString)

        If vendedor.Prospectos.Count > 0 Then
            For Each prospecto In vendedor.Prospectos
                data3.Add(prospecto.Id_prospecto, prospecto.Nombre + " " + prospecto.Apellidos)
            Next
            ltbProspAsignados.DataSource = New BindingSource(data3, Nothing)
            ltbProspAsignados.DisplayMember = "Value"
            ltbProspAsignados.ValueMember = "Key"
        End If

        llenarListBoxProspectos()
    End Sub

    Private Sub btnGuardarAsignarProsp_Click(sender As Object, e As EventArgs) Handles btnGuardarAsignarProsp.Click
        Dim vendedor As New UserModel
        Dim idVendedor = DirectCast(ltbVendedoresSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim listaProspectos As New List(Of Prospecto)
        vendedor = Users_controller.getUser(idVendedor.ToString)

        If data3.Count > 0 Then
            For x As Integer = 0 To ltbProspAsignados.Items.Count - 1
                Dim prospecto As New Prospecto
                prospecto.Id_prospecto = DirectCast(ltbProspAsignados.Items.Item(x), KeyValuePair(Of Integer, String)).Key
                listaProspectos.Add(prospecto)
            Next
        End If

        vendedor.Prospectos = listaProspectos
        If (Users_controller.assignProspectus(vendedor).Equals(True)) Then
            MsgBox("Los prospectos fueron asignados con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("Hubo un error al tratar de guardar los cambios", MsgBoxStyle.Critical)
        End If
    End Sub
    '
    'SEGUIMIENTOS
    '
    Private Sub lstSeguimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstSeguimientos.CellContentClick
        Select Case e.ColumnIndex
            Case 3
                Dim id As String = lstSeguimientos.Rows(e.RowIndex).Cells(0).Value
                Dim pseg As Seguimiento = SeguimientoController.getSeguimiento(id)
                lblIdSeguimiento.Text = pseg.Id_seguimiento
                txtFechaSeguimiento.Value = pseg.Fecha
                txtComentarioSeguimiento.Text = pseg.Comentario
                PnlListaSeguimientos.Visible = False
                pnlSeguimientos.Visible = True
            Case 4
                Dim id As String = lstSeguimientos.Rows(e.RowIndex).Cells(0).Value
                Dim resul = SeguimientoController.eliminar(id)
                If (resul.Equals(True)) Then
                    lstSeguimientos.Rows.Remove(lstSeguimientos.Rows(e.RowIndex))
                    MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox("Imposible eliminar el registro", MsgBoxStyle.Critical)
                End If
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub limpiarFormSeguimiento()
        txtComentarioSeguimiento.Clear()
        txtFechaSeguimiento.Value = Date.Now
    End Sub

    Private Sub btnNuevoSeguimiento_Click(sender As Object, e As EventArgs) Handles btnNuevoSeguimiento.Click
        If lblIdSeguimiento.Equals(-1) Then
            lblCrearSeguimiento.Text = "Editar seguimiento"
        Else
            lblCrearSeguimiento.Text = "Crear seguimiento"
        End If
        PnlNuevoProspecto.Visible = False
        pnlSeguimientos.Visible = True
    End Sub

    Private Sub btnCancelarSeguimiento_Click(sender As Object, e As EventArgs) Handles btnCancelarSeguimiento.Click
        Me.limpiarFormSeguimiento()
        PnlNuevoProspecto.Visible = True
        pnlSeguimientos.Visible = False
    End Sub

    Private Sub btnGuardarSeguimiento_Click(sender As Object, e As EventArgs) Handles btnGuardarSeguimiento.Click
        If String.IsNullOrEmpty(txtComentarioSeguimiento.Text) Then
            ErrorProvider1.SetError(txtComentarioSeguimiento, ValidationsMessages.EMPTY_FIELD)
        Else
            Dim resul = SeguimientoController.guardarOActualizar(CInt(lblIdSeguimiento.Text), CInt(lblIdProspecto.Text), txtFechaSeguimiento.Value, txtComentarioSeguimiento.Text)
            If (resul.Equals(True)) Then
                MsgBox("El registro ha sido creado exitosamente", MsgBoxStyle.Information)
                Me.limpiarFormSeguimiento()
                PnlNuevoProspecto.Visible = True
                pnlSeguimientos.Visible = False
            Else
                MsgBox("Hubo un error al guardar el registro", MsgBoxStyle.Critical)
            End If
            lblIdSeguimiento.Text = -1
        End If
    End Sub

    Private Sub btnListarSeguimientos_Click(sender As Object, e As EventArgs) Handles btnListarSeguimientos.Click
        Me.llenarListaSeguimientos()
        PnlListaSeguimientos.Visible = True
        PnlNuevoProspecto.Visible = False
    End Sub

    Private Sub btnCancelarListaSeguimiento_Click(sender As Object, e As EventArgs) Handles btnCancelarListaSeguimiento.Click
        PnlListaSeguimientos.Visible = False
        PnlNuevoProspecto.Visible = True
    End Sub

    Private Sub llenarListaSeguimientos()
        lstSeguimientos.Rows.Clear()
        Dim seguimientos = SeguimientoController.listar(CInt(lblIdProspecto.Text))
        If (Not seguimientos.Equals(Nothing)) Then
            For Each seg As Seguimiento In seguimientos
                lstSeguimientos.Rows.Add(seg.Id_seguimiento, Format(seg.Fecha, "dd-MM-yyyy"), seg.Comentario)
            Next
        End If
    End Sub

    'VALIDACIONES
    Function IsEmail(ByVal text As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(text)
    End Function

    Function IsGoodPassword(ByVal text As String) As Boolean
        '- 8 caracteres
        '- no mas de 15 caracteres
        '- Letra mayuscula, minuscula y un numero
        Static regularExpression As New Regex("^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function isAUserId(ByVal text As String) As Boolean 'Minimo 9
        Static regularExpression As New Regex("^[0-9]{9,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function isAPhoneNumber(ByVal text As String) As Boolean 'Minimo 8
        Static regularExpression As New Regex("^[0-9]{8,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function OnlyTextAllowSpaces(ByVal text As String) As Boolean
        Static regularExpression As New Regex("^[a-zA-Z ]*$")
        Return regularExpression.IsMatch(text)
    End Function

    Private Sub btnActiIco_Click(sender As Object, e As EventArgs) Handles btnActiIco.Click
        listaActis_pnl.Visible = True
    End Sub

    Private Sub nuevoActi_btn_Click(sender As Object, e As EventArgs) Handles nuevoActi_btn.Click
        llenarActi()
        LlenarComboDias()
        registrarActi_pnl.Visible = True
    End Sub

    Private Sub guardarAct_btn_Click(sender As Object, e As EventArgs) Handles guardarAct_btn.Click
        ErrorProvider1.Clear()

        Dim horarios = crearHorariosActi()
        Dim id_tipo = (DirectCast(tipoActi_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
        If nombreActi_text.Text = "" Then
            ErrorProvider1.SetError(nombreActi_text, "Debe ingresar un nombre para el nuevo curso.")
            Exit Sub
        ElseIf codigoActi_text.Text = "" Then
            ErrorProvider1.SetError(codigoActi_text, "Debe ingresar un código para el nuevo curso.")
            Exit Sub
        ElseIf costoActi_text.Text = "" Then
            ErrorProvider1.SetError(costoActi_text, "Debe ingresar un costo para el nuevo curso.")
            Exit Sub
        ElseIf horarios.Length = 8 Then
            horaIni1Acti_nmb.ToString()
            ErrorProvider1.SetError(horariosActi_grp, "Debe elegir al menos un dia y una hora para el nuevo curso.")
            Exit Sub
        ElseIf Not modProduct Then
            Dim IsCorrect = ProductsController.RegistrarProducto(nombreActi_text.Text, costoActi_text.Text, codigoActi_text.Text, horarios, id_tipo, fechaInicio_dp.Value)
            If IsCorrect Then
                MsgBox("El nuevo curso se ha agregado con exito.", MsgBoxStyle.Information)
                limpiarFormActi()
                llenarTablaActis()
                listaActis_pnl.Visible = True
            Else
                MsgBox("No se ha podido ingresar el nuevo curso.", MsgBoxStyle.Critical)
            End If
        Else
            Dim IsCorrect = ProductsController.RegistrarProducto(nombreActi_text.Text, costoActi_text.Text, codigoActi_text.Text, horarios, id_tipo, fechaInicio_dp.Value)
            If IsCorrect Then
                MsgBox("El nuevo curso se ha agregado con exito.", MsgBoxStyle.Information)
                limpiarFormActi()
                llenarTablaActis()
                listaActis_pnl.Visible = True
            Else
                MsgBox("No se ha podido ingresar el nuevo curso.", MsgBoxStyle.Critical)
            End If

        End If
    End Sub
    Private Function crearHorariosActi() As String

        Dim horario1 As String = ""
        Dim horario2 As String = ""
        Dim horario3 As String = ""
        Dim horario4 As String = ""
        Dim horario5 As String = ""

        If horaIni1Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni1Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni1Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin1Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin1Acti_nmb.Value.ToString("00")
            horario1 = dia1Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni2Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni2Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni2Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin2Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin2Acti_nmb.Value.ToString("00")
            horario2 = dia2Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni3Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni3Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni3Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin3Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin3Acti_nmb.Value.ToString("00")
            horario3 = dia3Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni4Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni4Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni4Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin4Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin4Acti_nmb.Value.ToString("00")
            horario4 = dia4Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni5Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni5Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni5Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin5Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin5Acti_nmb.Value.ToString("00")
            horario5 = dia5Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin

        End If

        Dim resul As String = Trim(horario1 & vbNewLine & horario2 & vbNewLine & horario3 & vbNewLine & horario4 & vbNewLine & horario5)
        Return resul
    End Function

    Private Sub llenarActi()

        'Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        Dim comboSource As New Dictionary(Of String, String)()
        'For Each tipo As Tipo_Producto In tipos
        comboSource.Add(1, "Acti")
        'Next
        tipoActi_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipoActi_cmb.DisplayMember = "Value"
        tipoActi_cmb.ValueMember = "Key"
    End Sub
    Private Sub limpiarFormActi()

        nombreActi_text.Text = ""
        costoActi_text.Text = ""
        codigoActi_text.Text = ""
        dia1Acti_cmb.Text = ""
        dia2Acti_cmb.Text = ""
        dia3Acti_cmb.Text = ""
        dia4Acti_cmb.Text = ""
        dia5Acti_cmb.Text = ""
        horaFin1Acti_nmb.Value = 0
        horaFin2Acti_nmb.Value = 0
        horaFin3Acti_nmb.Value = 0
        horaFin4Acti_nmb.Value = 0
        horaIni1Acti_nmb.Value = 0
        horaIni2Acti_nmb.Value = 0
        horaIni3Acti_nmb.Value = 0
        horaIni4Acti_nmb.Value = 0
        minsFin1Acti_nmb.Value = 0
        minsFin2Acti_nmb.Value = 0
        minsFin3Acti_nmb.Value = 0
        minsFin4Acti_nmb.Value = 0
        minsFin5Acti_nmb.Value = 0
        minsIni1Acti_nmb.Value = 0
        minsIni2Acti_nmb.Value = 0
        minsIni3Acti_nmb.Value = 0
        minsIni4Acti_nmb.Value = 0
        minsIni5Acti_nmb.Value = 0
        registrarActi_pnl.Visible = False
    End Sub

    Private Sub llenarTablaActis()
        listaActis_dg.Rows.Clear()
        Dim actis As List(Of Producto) = ProductsController.obtenerListaProductos()
        If (Not actis Is Nothing) Then
            For Each acti As Producto In actis
                If (acti.Id_Tipo_Product = 1) Then
                    listaActis_dg.Rows.Add(acti.Id_producto, acti.Nombre, acti.Codigo_Producto, acti.Costo, acti.Horario, Format(acti.Fecha_Inicio, "dd-MM-yyyy"))
                End If
            Next
        End If
    End Sub

    Private Sub vovlerActi_btn_Click(sender As Object, e As EventArgs) Handles vovlerActi_btn.Click
        listaActis_pnl.Visible = False
        pnlListaCarreras.Visible = False
    End Sub

    Private Sub LlenarComboDias()

        Dim dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}

        dia1Acti_cmb.MaxDropDownItems = dias.Length
        dia2Acti_cmb.MaxDropDownItems = dias.Length
        dia3Acti_cmb.MaxDropDownItems = dias.Length
        dia4Acti_cmb.MaxDropDownItems = dias.Length
        dia5Acti_cmb.MaxDropDownItems = dias.Length

        For i = 0 To (dias.Length - 1)
            dia1Acti_cmb.Items.Add(dias(i))
            dia2Acti_cmb.Items.Add(dias(i))
            dia3Acti_cmb.Items.Add(dias(i))
            dia4Acti_cmb.Items.Add(dias(i))
            dia5Acti_cmb.Items.Add(dias(i))

        Next
    End Sub

    Private Sub cancelarAct_btn_Click(sender As Object, e As EventArgs) Handles cancelarAct_btn.Click
        registrarActi_pnl.Visible = False
    End Sub

    'USERS

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Close Session</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lblCloseSession_Click(sender As Object, e As EventArgs) Handles lblCloseSession.Click
        Dim login As New FrmLogin()
        Me.Hide()
        login.ShowDialog()
        Me.Close()
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Close Session</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Users_controller.signOut(user)
        Application.Exit()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListOfRols()
        pnlListRols.Show()
        populateListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListOfRols()
        pnlListRols.Hide()
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateListOfRols()
        lstListRols.Rows.Clear()
        Dim estado = "Inactivo"
        Dim rols As List(Of RolModel) = RolsController.obtener()
        If (Not rols Is Nothing) Then
            For Each rol As RolModel In rols
                If rol.activo Then
                    estado = "Activo"
                End If
                lstListRols.Rows.Add(rol.id_rol, rol.nombre, estado)
            Next
        End If
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Main_Click(sender As Object, e As EventArgs) Handles Main.Click
        showListUserForm()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideCreateRolForm()
        pnlCreateRol.Hide()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cleanCreateRolForm()
        txtRolName.Text = ""
        tgEnabledRol.Checked = False
        tgKpiRol.Checked = False
        tgActiRol.Checked = False
        tgSalesRol.Checked = False
        tgProspectusRol.Checked = False
        tgEventsRol.Checked = False
        tgReportsRol.Checked = False
        tgConfigurationRol.Checked = False
        tgUsersRol.Checked = False
        tgCareersRol.Checked = False
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showCreateRolForm(ByVal id As String)
        lblIdRol.Text = id
        pnlCreateRol.Show()
        cleanCreateRolForm()
        If id = "-1" Then
            lblCreateRolTittle.Text = "Crear rol"
        Else
            lblCreateRolTittle.Text = "Modificar rol"
            Dim rol As RolModel = RolsController.getRol(id)
            If (Not rol Is Nothing) Then
                txtRolName.Text = rol.nombre
                tgEnabledRol.Checked = rol.activo
                For Each permiso As PermissionModel In rol.permisos
                    Select Case permiso.nombre
                        Case "actis"
                            tgActiRol.Checked = True
                        Case "carreras"
                            tgCareersRol.Checked = True
                        Case "ventas"
                            tgSalesRol.Checked = True
                        Case "prospectos"
                            tgProspectusRol.Checked = True
                        Case "usuarios"
                            tgUsersRol.Checked = True
                        Case "eventos"
                            tgEventsRol.Checked = True
                        Case "kpis"
                            tgKpiRol.Checked = True
                        Case "reportes"
                            tgReportsRol.Checked = True
                        Case "configuracion"
                            tgConfigurationRol.Checked = True
                        Case "evaluaciones"
                            tgEvaluacionesRol.Checked = True
                        Case "preguntas"
                            tgPreguntasRol.Checked = True
                    End Select
                Next
            Else
                MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
            End If
        End If
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveRol_Click(sender As Object, e As EventArgs) Handles btnSaveRol.Click
        If (OnlyTextAllowSpaces(txtRolName.Text)) Then
            Dim permissions As New List(Of PermissionModel)
            If tgActiRol.Checked Then
                permissions.Add(New PermissionModel(1))
            End If
            If tgCareersRol.Checked Then
                permissions.Add(New PermissionModel(2))
            End If
            If tgSalesRol.Checked Then
                permissions.Add(New PermissionModel(3))
            End If
            If tgProspectusRol.Checked Then
                permissions.Add(New PermissionModel(4))
            End If
            If tgEventsRol.Checked Then
                permissions.Add(New PermissionModel(5))
            End If
            If tgKpiRol.Checked Then
                permissions.Add(New PermissionModel(6))
            End If
            If tgUsersRol.Checked Then
                permissions.Add(New PermissionModel(7))
            End If
            If tgReportsRol.Checked Then
                permissions.Add(New PermissionModel(8))
            End If
            If tgConfigurationRol.Checked Then
                permissions.Add(New PermissionModel(9))
            End If
            If tgEvaluacionesRol.Checked Then
                permissions.Add(New PermissionModel(10))
            End If
            If tgPreguntasRol.Checked Then
                permissions.Add(New PermissionModel(11))
            End If
            If String.Compare(lblIdRol.Text, "-1") = 0 Then
                If (RolsController.create(txtRolName.Text, tgEnabledRol.Checked, permissions)) Then
                    MsgBox(respuestasDelSistema.CREATE_ROL_SUCCESS, MsgBoxStyle.Information)
                    showListOfRols()
                    hideCreateRolForm()
                Else
                    MsgBox(respuestasDelSistema.CREATE_ROL_ERROR, MsgBoxStyle.Critical)
                End If
            Else
                If (RolsController.update(lblIdRol.Text, txtRolName.Text, tgEnabledRol.Checked, permissions)) Then
                    MsgBox(respuestasDelSistema.UPDATE_ROL_SUCCESS, MsgBoxStyle.Information)
                    showListOfRols()
                    hideCreateRolForm()
                Else
                    MsgBox(respuestasDelSistema.UPDATE_ROL_ERROR, MsgBoxStyle.Critical)
                End If
            End If

        Else
            ErrorProvider1.SetError(txtRolName, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnNewRol_Click(sender As Object, e As EventArgs) Handles btnNewRol.Click
        showCreateRolForm("-1")
        hideListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lstListRols_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstListRols.CellContentClick
        Dim id As String = lstListRols.Rows(e.RowIndex).Cells(0).Value
        Select Case e.ColumnIndex
            Case 3
                hideListOfRols()
                showCreateRolForm(id)
        End Select
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelRol_Click(sender As Object, e As EventArgs) Handles btnCancelRol.Click
        hideCreateRolForm()
        showListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>List users</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListUserForm()
        Me.pnListUsers.Show()
        populateListOfUsers()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>List users</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListUserForm()
        Me.pnListUsers.Hide()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>List users</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateListOfUsers()
        lstUsers.Rows.Clear()
        Dim estado = "Inactivo"
        Dim usuarios As List(Of UserModel) = Users_controller.getUsers()
        If (Not usuarios Is Nothing) Then
            For Each usuario As UserModel In usuarios
                If usuario.activo Then
                    estado = "Activo"
                End If
                lstUsers.Rows.Add(usuario.id_usuario, usuario.cedula, usuario.nombre, usuario.apellido, usuario.telefono,
                                      usuario.correo, estado)
            Next
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>List users</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lblRolsSection_Click(sender As Object, e As EventArgs) Handles lblRolsSection.Click
        populateListOfRols()
        hideListUserForm()
        showListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnBackRolsUsers_Click(sender As Object, e As EventArgs) Handles btnBackRolsUsers.Click
        hideListOfRols()
        showListUserForm()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Create user</usecase>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveCreateUser_Click(sender As Object, e As EventArgs) Handles btnSaveCreateUser.Click
        Dim id_rol As String = DirectCast(cboRolCreateUser.SelectedItem, KeyValuePair(Of String, String)).Key
        If (validateCreateUserForm()) Then
            If String.Compare(lblCreateUpdateUserId.Text, "-1") = 0 Then
                If (Users_controller.create(txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                    txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                    id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                    MsgBox(respuestasDelSistema.CREATE_USER_SUCCESS, MsgBoxStyle.Information)
                    hideCreateUserForm()
                    showListUserForm()
                Else
                    MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                End If
            Else
                If (chkChangeUserPassword.Checked) Then
                    If (Users_controller.updateUserAndPassword(lblCreateUpdateUserId.Text, txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                                txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                                id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideCreateUserForm()
                        showListUserForm()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                Else
                    If (Users_controller.update(lblCreateUpdateUserId.Text, txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                                txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                                id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideCreateUserForm()
                        showListUserForm()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Create user</usecase>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Function validateCreateUserForm() As Boolean
        Dim result As Boolean = True
        If Not isAUserId(txtIdCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtIdCreateUser, ValidationsMessages.INVALID_USER_ID)
            txtIdCreateUser.WithError = True
        End If
        If Not OnlyTextAllowSpaces(txtNameCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtNameCreateUser, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not OnlyTextAllowSpaces(txtLastNameCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtLastNameCreateUser, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not IsEmail(txtEmailCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailCreateUser, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtPhoneCreateUser.Text) Or txtPhoneCreateUser.Text.Length < 8 Then
            result = False
            ErrorProvider1.SetError(txtPhoneCreateUser, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If (chkChangeUserPassword.Checked) Then
            If Not IsGoodPassword(txtPasswordCreateUser.Text) Then
                ErrorProvider1.SetError(txtPasswordCreateUser, ValidationsMessages.PASSWORD_INCORRECT_FORMAT)
                result = False
            End If
        End If
        Return result
    End Function

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        hideListUserForm()
        showCreateUserForm("-1")
    End Sub

    Private Sub hideCreateUserForm()
        Me.pnlCreateUser.Hide()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Create user</usecase>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearCreateUserForm()
        txtIdCreateUser.Text = ""
        txtNameCreateUser.Text = ""
        txtLastNameCreateUser.Text = ""
        txtPasswordCreateUser.Text = ""
        txtPhoneCreateUser.Text = ""
        txtEmailCreateUser.Text = ""
        tgEnableCreateUser.Checked = False
        chkChangeUserPassword.Checked = False
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Create user</usecase>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showCreateUserForm(ByVal id As String)
        clearCreateUserForm()
        Me.pnlCreateUser.Visible = True
        Dim roles As List(Of RolModel) = RolsController.obtener()
        'Llenar roles
        Dim comboSource As New Dictionary(Of String, String)()
        For Each rol As RolModel In roles
            comboSource.Add(rol.id_rol.ToString, rol.nombre)
        Next
        cboRolCreateUser.DataSource = New BindingSource(comboSource, Nothing)
        lblCreateUpdateUserId.Text = id
        cboRolCreateUser.DisplayMember = "Value"
        cboRolCreateUser.ValueMember = "Key"
        If id = "-1" Then
            lblCreateUserTittle.Text = "Crear usuario"
            txtPasswordCreateUser.Enabled = True
            chkChangeUserPassword.Visible = False
        Else
            chkChangeUserPassword.Visible = True
            lblCreateUserTittle.Text = "Modificar usuario"
            Dim user As UserModel = Users_controller.getUser(id)
            If (Not user Is Nothing) Then
                txtIdCreateUser.Text = user.cedula
                txtNameCreateUser.Text = user.nombre
                txtLastNameCreateUser.Text = user.apellido
                txtEmailCreateUser.Text = user.correo
                txtPhoneCreateUser.Text = user.telefono
                txtPasswordCreateUser.Text = user.password
                cboRolCreateUser.SelectedIndex = cboRolCreateUser.FindStringExact(user.rol.nombre)
                tgEnableCreateUser.Checked = user.activo
                cboDateCreateUser.Value = user.fecha_nacimiento
                txtPasswordCreateUser.Enabled = False
                lblPasswordUserBackup.Text = user.password
            Else
                MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lstUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstUsers.CellContentClick
        Select Case e.ColumnIndex
            Case 7
                Dim id As String = lstUsers.Rows(e.RowIndex).Cells(0).Value
                hideListUserForm()
                showCreateUserForm(id)
        End Select
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Update user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub chkChangeUserPassword_Click(sender As Object, e As EventArgs) Handles chkChangeUserPassword.Click
        txtPasswordCreateUser.Enabled = chkChangeUserPassword.Checked
        txtPasswordCreateUser.Text = lblPasswordUserBackup.Text
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Update user</usecase>
    ''' <usecase>Create user</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelCreateUser_Click(sender As Object, e As EventArgs) Handles btnCancelCreateUser.Click
        hideCreateUserForm()
        showListUserForm()
        clearCreateUserForm()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles btnSaveUpdateUserInfo.Click
        If (validateUpdateUserForm()) Then

            If Not (Users_controller.login(user.correo, txtPasswordUpdateUserInfo.Text)) Is Nothing Then
                If tgChangePassUpdateUserInfo.Checked Then
                    If (Users_controller.updateUserAndPassword(user.id_usuario, txtIdUpdateUserInfo.Text, txtNameUpdateUserInfo.Text, txtLastNameUpdateUserInfo.Text,
                                            txtEmailUpdateUserInfo.Text, txtPhoneUpdateUserInfo.Text, txtNewPassUpdateUserInfo.Text, user.id_rol, user.activo, cboDateUpdateUserInfo.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideUpdateUserInfo()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                Else 'No quiere actualizar la contraseña
                    If (Users_controller.update(user.id_usuario, txtIdUpdateUserInfo.Text, txtNameUpdateUserInfo.Text, txtLastNameUpdateUserInfo.Text,
                                            txtEmailUpdateUserInfo.Text, txtPhoneUpdateUserInfo.Text, user.password, user.id_rol, user.activo, cboDateUpdateUserInfo.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideUpdateUserInfo()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                End If
            Else
                MsgBox(MsgBox(respuestasDelSistema.USER_NOT_EXIST, MsgBoxStyle.Critical))
            End If
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Function validateUpdateUserForm() As Boolean
        Dim result As Boolean = True
        If Not isAUserId(txtIdUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtIdUpdateUserInfo, ValidationsMessages.INVALID_USER_ID)
            txtIdUpdateUserInfo.WithError = True
        End If
        If Not OnlyTextAllowSpaces(txtNameUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtNameUpdateUserInfo, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not OnlyTextAllowSpaces(txtLastNameUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtLastNameUpdateUserInfo, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not IsEmail(txtEmailUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailUpdateUserInfo, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtPhoneUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtPhoneUpdateUserInfo, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If Not IsGoodPassword(txtPasswordUpdateUserInfo.Text) Then
            ErrorProvider1.SetError(txtPasswordUpdateUserInfo, ValidationsMessages.PASSWORD_INCORRECT_FORMAT)
            result = False
        End If
        Return result
    End Function

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideUpdateUserInfo()
        pnlUpdateUserInfo.Hide()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showUpdateUserInfo()
        Dim usuario As UserModel = Users_controller.getUser(user.id_usuario)
        If (Not usuario Is Nothing) Then
            txtIdUpdateUserInfo.Text = usuario.cedula
            txtNameUpdateUserInfo.Text = usuario.nombre
            txtLastNameUpdateUserInfo.Text = usuario.apellido
            txtEmailUpdateUserInfo.Text = usuario.correo
            txtPhoneUpdateUserInfo.Text = usuario.telefono
            txtPasswordUpdateUserInfo.Text = ""
            txtNewPassUpdateUserInfo.Text = user.password
            tgChangePassUpdateUserInfo.Checked = False
            txtNewPassUpdateUserInfo.Enabled = False
        Else
            MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
        End If
        pnlUpdateUserInfo.Show()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tileChangeInformation_Click(sender As Object, e As EventArgs) Handles tileChangeInformation.Click
        showUpdateUserInfo()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tgChangePassUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles tgChangePassUpdateUserInfo.Click
        txtNewPassUpdateUserInfo.Enabled = tgChangePassUpdateUserInfo.Checked
        lblNewpassUpdateUserInfo.Enabled = tgChangePassUpdateUserInfo.Checked
        txtNewPassUpdateUserInfo.Text = ""
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>5-11-2015</Date>
    ''' <usecase>Change password</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateUserInfo.Click
        hideUpdateUserInfo()
    End Sub

    Private Sub btnCarrerasIcon_Click(sender As Object, e As EventArgs) Handles btnCarrerasIcon.Click
        llenarTablaCarreras()
        pnlListaCarreras.Visible = True
    End Sub

    Private Sub btnGuardarCarrera_Click(sender As Object, e As EventArgs) Handles btnGuardarCarrera.Click
        ErrorProvider1.Clear()
        Dim horarios = "-"
        Dim fechaInicio = CDate("01-01-1900")
        Dim id_tipo = (DirectCast(tipoCarrera_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
        If nombreCarrera_text.Text = "" Then
            ErrorProvider1.SetError(nombreCarrera_text, "Debe ingresar un nombre para la nueva carrera.")
            Exit Sub
        ElseIf codigoCarrera_text.Text = "" Then
            ErrorProvider1.SetError(codigoCarrera_text, "Debe ingresar un código para la nueva carrera.")
            Exit Sub
        ElseIf costoCarrera_text.Text = "" Then
            ErrorProvider1.SetError(costoCarrera_text, "Debe ingresar un costo para la nueva carrera.")
            Exit Sub
        Else

            Dim IsCorrect = ProductsController.RegistrarProducto(nombreCarrera_text.Text, costoCarrera_text.Text, codigoCarrera_text.Text, horarios, id_tipo, fechaInicio)

            If IsCorrect Then
                MsgBox("La nueva carrera se ha agregado con exito.", MsgBoxStyle.Information)
                limpiarFormCarrera()
                llenarTablaCarreras()
                pnlRegistrarCarrera.Visible = False
                pnlListaCarreras.Visible = True
            Else
                MsgBox("No se ha podido ingresar la nueva carrera.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btnCancelarCarrera_Click(sender As Object, e As EventArgs) Handles btnCancelarCarrera.Click
        pnlRegistrarCarrera.Visible = False
    End Sub

    Private Sub limpiarFormCarrera()
        nombreCarrera_text.Text = ""
        costoCarrera_text.Text = ""
        codigoCarrera_text.Text = ""
        pnlRegistrarCarrera.Visible = False
    End Sub

    Private Sub btnVolver_Carrera_Click(sender As Object, e As EventArgs) Handles btnVolver_Carrera.Click
        pnlListaCarreras.Visible = False
    End Sub

    Private Sub btnNueva_Carrera_Click(sender As Object, e As EventArgs) Handles btnNueva_Carrera.Click
        llenarComboTiposCarrera()
        pnlRegistrarCarrera.Visible = True
    End Sub

    Private Sub llenarTablaCarreras()
        listaCarreras_dg.Rows.Clear()
        Dim carreras As List(Of Producto) = ProductsController.obtenerListaProductos()
        If (Not carreras Is Nothing) Then
            For Each prod As Producto In carreras
                If (prod.Id_Tipo_Product = 2) Then
                    listaCarreras_dg.Rows.Add(prod.Id_producto, prod.Nombre, prod.Codigo_Producto, prod.Costo)
                End If
            Next
        Else
            MsgBox("No se han encontrado carreras para cargar", vbCritical)
        End If
    End Sub

    Private Sub llenarComboTiposCarrera()

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add(2, "Carrera")
        tipoCarrera_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipoCarrera_cmb.DisplayMember = "Value"
        tipoCarrera_cmb.ValueMember = "Key"
    End Sub

    Private Sub btnExportar_Carreras_Click(sender As Object, e As EventArgs) Handles btnExportar_Carreras.Click
        tipoExport = 2
        Dim path = SalvarArchivo()
    End Sub

    Private Sub btnListarVentasIcon_Click(sender As Object, e As EventArgs) Handles btnListarVentasIcon.Click
        llenarTablaVentas()
        pnlListarVentas.Visible = True

    End Sub

    Private Sub llenarTablaVentas()
        dgListaVentas.Rows.Clear()
        Dim usuario As UserModel = Nothing

        Dim ventas As List(Of Sale) = SalesController.ObtenerListaVentas()
        If (Not ventas Is Nothing) Then
            For Each venta As Sale In ventas
                If user.id_rol = 1 Then
                    usuario = Users_controller.getUser(venta.Id_Usuario)
                    dgListaVentas.Rows.Add(venta.Id_Sale, usuario.nombre & " " & usuario.apellido, venta.Monto, venta.Fecha, venta.Tipo)
                Else

                    If venta.Id_Usuario = user.id_usuario Then
                        usuario = Users_controller.getUser(venta.Id_Usuario)
                        dgListaVentas.Rows.Add(venta.Id_Sale, usuario.nombre & " " & usuario.apellido, venta.Monto, venta.Fecha, venta.Tipo)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub btnRegistrarVentaIcon_Click(sender As Object, e As EventArgs) Handles btnRegistrarVentaIcon.Click
        llenarComboProductos()
        llenarComboCodigos()
        llenarComboTipoVenta()
        pnlRegistrarVenta.Visible = True

    End Sub

    Private Sub llenarComboProductos()
        Dim productos As List(Of Producto) = ProductsController.obtenerListaProductos
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("", "Elija uno")
        If (Not productos Is Nothing) Then
            For Each prod As Producto In productos
                comboSource.Add(prod.Id_producto.ToString, prod.Nombre)
            Next
        Else
            MsgBox("No se han encontrado productos para cargar", vbCritical)
        End If
        productos_cmb.DataSource = New BindingSource(comboSource, Nothing)
        productos_cmb.DisplayMember = "Value"
        productos_cmb.ValueMember = "Key"
    End Sub

    Private Sub llenarComboCodigos()

        Dim productos As List(Of Producto) = ProductsController.obtenerListaProductos
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("", "Elija uno")
        If (Not productos Is Nothing) Then
            For Each prod As Producto In productos
                comboSource.Add(prod.Id_producto.ToString, prod.Codigo_Producto)
            Next
        Else
            MsgBox("No se han encontrado productos para cargar", vbCritical)
        End If
        cod_prod_cmb.DataSource = New BindingSource(comboSource, Nothing)
        cod_prod_cmb.DisplayMember = "Value"
        cod_prod_cmb.ValueMember = "Key"
    End Sub
    Private Sub llenarComboTipoVenta()

        Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        Dim comboSource As New Dictionary(Of String, String)()

        If IsNothing(tipos) Then
            MsgBox("Se ha producido un error y no se pueden cargar los datos de tipo de producto.", MsgBoxStyle.Critical)
        Else
            comboSource.Add("", "")
            For Each tipo As Tipo_Producto In tipos
                comboSource.Add(tipo.Id_Tipo_Producto.ToString, tipo.Nombre)
            Next
        End If
        tipo_prodVenta_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipo_prodVenta_cmb.DisplayMember = "Value"
        tipo_prodVenta_cmb.ValueMember = "Key"
    End Sub

    Private Sub btnConsultarVentasIcon_Click(sender As Object, e As EventArgs) Handles btnConsultarVentasIcon.Click
        LlenarComboUsersConsulta()
        LlenarComboPeriodos()
        pnlConsultarVentas.Visible = True
    End Sub

    Private Sub LimpiarFormVenta()
        productos_cmb.SelectedIndex = 0
        cod_prod_cmb.SelectedIndex = 0
        matricula_text.Text = ""
        costoVenta_text.Text = ""
    End Sub

    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        Dim totalPagar As Double
        Dim fecha As Date
        Dim id_usuario As Integer
        Dim tipo As String

        id_usuario = user.id_usuario
        tipo = tipo_prodVenta_cmb.Text
        fecha = Today
        totalPagar = calcularTotal()
        Dim isCorrect = SalesController.RegistrarVenta(fecha, totalPagar, id_usuario, tipo)
        If isCorrect Then
            MsgBox("La nueva venta se ha agregado con exito.", MsgBoxStyle.Information)
            LimpiarFormVenta()
            llenarTablaVentas()
            pnlRegistrarVenta.Visible = False
            pnlListarVentas.Visible = True
        Else
            MsgBox("No se ha podido ingresar la nueva venta.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cod_prod_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod_prod_cmb.SelectedIndexChanged
        Dim id As Integer
        Dim producto As Producto

        If IsNothing(cod_prod_cmb.SelectedValue) Or (DirectCast(cod_prod_cmb.SelectedItem, KeyValuePair(Of String, String)).Key) = "" Then
            id = 0
        Else
            id = CInt(DirectCast(cod_prod_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
            producto = ProductsController.obtenerProducto(id)
            costoVenta_text.Text = producto.Costo
            tipo_prodVenta_cmb.SelectedIndex = producto.Id_Tipo_Product
            productos_cmb.SelectedIndex = cod_prod_cmb.SelectedIndex

        End If
    End Sub

    Private Sub productos_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productos_cmb.SelectedIndexChanged
        Dim id As Integer
        Dim producto As Producto
        If IsNothing(productos_cmb.SelectedValue) Or (DirectCast(productos_cmb.SelectedItem, KeyValuePair(Of String, String)).Key) = "" Then
            id = 0
        Else
            id = CInt(DirectCast(productos_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
            producto = ProductsController.obtenerProducto(id)
            costoVenta_text.Text = producto.Costo
            tipo_prodVenta_cmb.SelectedIndex = producto.Id_Tipo_Product
            cod_prod_cmb.SelectedIndex = productos_cmb.SelectedIndex

        End If
    End Sub

    Private Sub costo_text_Click(sender As Object, e As EventArgs) Handles costoVenta_text.TextChanged
        calcularTotal()
    End Sub

    Private Sub matricula_text_Click(sender As Object, e As EventArgs) Handles matricula_text.TextChanged
        calcularTotal()
    End Sub

    Public Function calcularTotal() As Double
        Dim totalPagar As Double
        Dim matricula As Double

        If matricula_text.Text = "" Then
            matricula = 0.0
        Else
            matricula = Double.Parse(matricula_text.Text)
        End If
        If costoVenta_text.Text <> "" Then
            totalPagar = Double.Parse(costoVenta_text.Text)
        End If
        totalPagar = totalPagar + matricula
        totalVenta_text.Text = totalPagar
        Return totalPagar
    End Function

    Private Sub btnCancelarVenta_Click_1(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        LimpiarFormVenta()
        pnlRegistrarVenta.Visible = False
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        llenarComboCodigos()
        llenarComboProductos()
        llenarComboTipoVenta()
        pnlRegistrarVenta.Visible = True
    End Sub

    Private Sub btnVolverListarVenta_Click(sender As Object, e As EventArgs) Handles btnVolverListarVenta.Click
        pnlListarVentas.Visible = False
    End Sub

    Private Sub btnVolverConsultaVentas_Click(sender As Object, e As EventArgs) Handles btnVolverConsultaVentas.Click
        pnlConsultarVentas.Visible = False
        usuarioConsulta_cmb.SelectedIndex = 0
        periodos_cmb.SelectedIndex = 0
    End Sub

    Private Sub usuarioConsulta_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usuarioConsulta_cmb.SelectedIndexChanged
        If usuarioConsulta_cmb.SelectedIndex > 0 Then
            llenarTablaVentasConsulta()
            llenarTablaTotalesConsulta()
        End If
    End Sub
    Private Sub llenarTablaTotalesConsulta()
        ingresosConsulta_dg.Rows.Clear()
        Dim ventas As List(Of Sale) = SalesController.ObtenerListaVentas()
        Dim venta As Sale = Nothing
        Dim total As Double
        Dim IdUsuarioConsultar As Integer
        Dim usuario As UserModel = Nothing
        Dim periodo As String
        usuario = Users_controller.getUser(user.id_usuario)
        periodo = DirectCast(periodos_cmb.SelectedItem, KeyValuePair(Of String, String)).Value
        'usuarioConsulta_cmb.SelectedIndex = 0
        total = 0
        If (Not ventas Is Nothing) Then
            For Each venta In ventas
                If user.id_rol = 1 And usuarioConsulta_cmb.SelectedIndex > 0 Then
                    IdUsuarioConsultar = CInt(DirectCast(usuarioConsulta_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
                    usuario = Users_controller.getUser(IdUsuarioConsultar)
                    If venta.Id_Usuario = IdUsuarioConsultar Then
                        total = total + venta.Monto
                    End If
                Else
                    usuario = user
                    If user.id_usuario = venta.Id_Usuario Then
                        total = total + venta.Monto
                    End If
                End If
            Next
            ingresosConsulta_dg.Rows.Add(usuario.nombre & " " & usuario.apellido, total, periodo)
        End If
    End Sub


    Private Sub llenarTablaVentasConsulta()
        ventasConsulta_dg.Rows.Clear()
        Dim ventas As List(Of Sale) = SalesController.ObtenerListaVentas()
        Dim venta As Sale = Nothing
        Dim cantidadVentas As Integer
        Dim IdUsuarioConsultar As Integer
        Dim usuario As UserModel = Nothing
        Dim periodo As String
        usuario = Users_controller.getUser(user.id_usuario)
        cantidadVentas = 0

        periodo = DirectCast(periodos_cmb.SelectedItem, KeyValuePair(Of String, String)).Value
        If (Not ventas Is Nothing) Then
            For Each venta In ventas
                If user.id_rol = 1 And usuarioConsulta_cmb.SelectedIndex > 0 Then
                    IdUsuarioConsultar = CInt(DirectCast(usuarioConsulta_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
                    usuario = Users_controller.getUser(IdUsuarioConsultar)
                    If venta.Id_Usuario = IdUsuarioConsultar Then
                        cantidadVentas = cantidadVentas + 1
                    End If
                Else

                    If usuario.id_usuario = venta.Id_Usuario Then
                        cantidadVentas = cantidadVentas + 1
                    End If
                End If
            Next
            ventasConsulta_dg.Rows.Add(IdUsuarioConsultar, usuario.nombre & " " & usuario.apellido, cantidadVentas, periodo)

        End If
    End Sub

    Private Sub LlenarComboUsersConsulta()
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("", "Elija uno")
        If user.id_rol = 1 Then
            Dim usuarios As List(Of UserModel) = Users_controller.getUsers
            For Each usuario As UserModel In usuarios
                comboSource.Add(usuario.id_usuario, usuario.apellido & " " & usuario.nombre)
            Next
        Else
            comboSource.Add(user.id_usuario, user.nombre & " " & user.apellido)
        End If
        usuarioConsulta_cmb.DataSource = New BindingSource(comboSource, Nothing)
        usuarioConsulta_cmb.DisplayMember = "Value"
        usuarioConsulta_cmb.ValueMember = "Key"
    End Sub

    Private Sub LlenarComboPeriodos()
        Dim periodos() As String = {"Año en curso"}
        Dim comboSource As New Dictionary(Of String, String)()
        Dim i As Integer = 0
        For Each per In periodos
            comboSource.Add(i, periodos(i))
            i = i + 1
        Next
        periodos_cmb.DataSource = New BindingSource(comboSource, Nothing)
        periodos_cmb.DisplayMember = "Value"
        periodos_cmb.ValueMember = "Key"
    End Sub

    Private Sub lblImportarCarrera_Click(sender As Object, e As EventArgs) Handles lblImportarCarrera.Click
        tipoImport = 1
        tipoProdImport = 2
        AbrirArchivo()
        llenarTablaCarreras()
        pnlRegistrarCarrera.Visible = False
        pnlListaCarreras.Visible = True
    End Sub

    Public Sub AbrirArchivo()

        Dim openFileDialog1 As New OpenFileDialog()
        Dim path As String

        openFileDialog1.InitialDirectory = "c:\Desktop"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                path = openFileDialog1.FileName
                If (path IsNot "") Then
                    Select Case (tipoImport)
                        Case 1
                            ProductsController.ImportarProductos(path, tipoProdImport)
                        Case 2
                            ProspectusController.ImportarProspectos(path)
                        Case 3
                            Users_controller.ImportarUsuarios(path, 1)
                        Case 4
                            Users_controller.ImportarUsuarios(path, 5)
                        Case Else
                    End Select

                End If
            Catch Ex As Exception
                MessageBox.Show("Ocurrio un error al intentar importar la información." & Ex.Message)
            End Try

            'llenarTablaCarreras()
            'limpiarFormCarrera()
            'pnlListaCarreras.Visible = True
        End If
    End Sub

    Private Sub importarActis_lbl_Click(sender As Object, e As EventArgs) Handles importarActis_lbl.Click
        tipoImport = 1
        tipoProdImport = 1
        AbrirArchivo()
        llenarTablaActis()
        registrarActi_pnl.Visible = False
        listaActis_pnl.Visible = True
    End Sub

    Private Sub exportarActi_btn_Click(sender As Object, e As EventArgs) Handles exportarActi_btn.Click
        tipoExport = 1
        Dim path = SalvarArchivo()
    End Sub
    Public Function SalvarArchivo() As String
        Dim path As String = ""
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Seleccione la ubicación donde desea guardar el archivo: "
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            path = dialog.SelectedPath
            ProductsController.ExportarProductos(tipoExport, path)
        ElseIf dialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            path = ""
        End If
        Return path
    End Function

    Private Sub lblImportarProspectos_Click(sender As Object, e As EventArgs) Handles lblImportarProspectos.Click
        tipoImport = 2
        AbrirArchivo()
        PnlNuevoProspecto.Visible = False
        lstProspectos.Rows.Clear()
        llenarListaProspectos()
        PnlListaProspectos.Visible = True
    End Sub

    Private Sub lblImportProfesores_Click(sender As Object, e As EventArgs) Handles lblImportProfesores.Click
        tipoImport = 3
        AbrirArchivo()
        populateListOfUsers()
        pnListUsers.Visible = True
        pnlCreateUser.Visible = False
    End Sub

    Private Sub lblImportEstudiantes_Click(sender As Object, e As EventArgs) Handles lblImportEstudiantes.Click
        tipoImport = 4
        AbrirArchivo()
        populateListOfUsers()
        pnListUsers.Visible = True
        pnlCreateUser.Visible = False
    End Sub
End Class



