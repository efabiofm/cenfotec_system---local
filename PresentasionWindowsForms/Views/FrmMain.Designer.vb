<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Main = New MetroFramework.Controls.MetroTabControl()
        Me.TabProductos = New MetroFramework.Controls.MetroTabPage()
        Me.registrarActi_pnl = New MetroFramework.Controls.MetroPanel()
        Me.fechaInicio_dp = New System.Windows.Forms.DateTimePicker()
        Me.fechaInicioCurso = New MetroFramework.Controls.MetroLabel()
        Me.cancelarAct_btn = New MetroFramework.Controls.MetroButton()
        Me.guardarAct_btn = New MetroFramework.Controls.MetroButton()
        Me.importarActis_lbl = New MetroFramework.Controls.MetroLink()
        Me.minsFinActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horaFinActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsFin5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIniActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horaIniActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsIni5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.dia5Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia4Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia3Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia2Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia1Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.horaFin = New MetroFramework.Controls.MetroLabel()
        Me.horaIni = New MetroFramework.Controls.MetroLabel()
        Me.dia5_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia4Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia2Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia3Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia1Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tipoActi_cmb = New System.Windows.Forms.ComboBox()
        Me.costoActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.nombreActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.codigoActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.nombreActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tipoActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.codigoActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horariosActi_grp = New System.Windows.Forms.GroupBox()
        Me.lblHorarioActi = New MetroFramework.Controls.MetroLabel()
        Me.lblCostoActi = New MetroFramework.Controls.MetroLabel()
        Me.listaActis_pnl = New MetroFramework.Controls.MetroPanel()
        Me.exportarActi_btn = New MetroFramework.Controls.MetroButton()
        Me.vovlerActi_btn = New MetroFramework.Controls.MetroButton()
        Me.listaActis_dg = New System.Windows.Forms.DataGridView()
        Me.colIdActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigoActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCostoActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHorarioActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaInicioActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editarActi = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listaActis_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevoActi_btn = New MetroFramework.Controls.MetroButton()
        Me.pnlRegistrarCarrera = New MetroFramework.Controls.MetroPanel()
        Me.btnCancelarCarrera = New MetroFramework.Controls.MetroButton()
        Me.lblCostoCarrera = New MetroFramework.Controls.MetroLabel()
        Me.costoCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardarCarrera = New MetroFramework.Controls.MetroButton()
        Me.tipoCarrera_cmb = New System.Windows.Forms.ComboBox()
        Me.codigoCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.lblTipoCarrera = New MetroFramework.Controls.MetroLabel()
        Me.lblCodigoCarrera = New MetroFramework.Controls.MetroLabel()
        Me.lblImportarCarrera = New MetroFramework.Controls.MetroLink()
        Me.nombreCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.lblNombreActi = New MetroFramework.Controls.MetroLabel()
        Me.lblRegistrarCarrera = New MetroFramework.Controls.MetroLabel()
        Me.pnlListaCarreras = New MetroFramework.Controls.MetroPanel()
        Me.btnExportar_Carreras = New MetroFramework.Controls.MetroButton()
        Me.btnVolver_Carrera = New MetroFramework.Controls.MetroButton()
        Me.listaCarreras_dg = New System.Windows.Forms.DataGridView()
        Me.id_carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo_carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editarCarrera = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListaCrreras = New MetroFramework.Controls.MetroLabel()
        Me.btnNueva_Carrera = New MetroFramework.Controls.MetroButton()
        Me.btnCarrerasIcon = New MetroFramework.Controls.MetroTile()
        Me.btnActiIco = New MetroFramework.Controls.MetroTile()
        Me.Eventos = New MetroFramework.Controls.MetroTabPage()
        Me.PanelListarEventos = New MetroFramework.Controls.MetroPanel()
        Me.btnCrearEvento = New MetroFramework.Controls.MetroButton()
        Me.DataListarEventos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblEventos = New MetroFramework.Controls.MetroLabel()
        Me.PanelCrearEvento = New MetroFramework.Controls.MetroPanel()
        Me.dateFin = New MetroFramework.Controls.MetroDateTime()
        Me.lblFechaFin = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelarEvento = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarEvento = New MetroFramework.Controls.MetroButton()
        Me.lblFechaInicio = New MetroFramework.Controls.MetroLabel()
        Me.dateEventos = New MetroFramework.Controls.MetroDateTime()
        Me.TxtnombreEventos = New MetroFramework.Controls.MetroTextBox()
        Me.lblLugar = New MetroFramework.Controls.MetroLabel()
        Me.EventosLbl = New MetroFramework.Controls.MetroLabel()
        Me.TabProspectos = New MetroFramework.Controls.MetroTabPage()
        Me.PnlNuevoProspecto = New MetroFramework.Controls.MetroPanel()
        Me.lblImportarProspectos = New MetroFramework.Controls.MetroLabel()
        Me.lblIdSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.lblIdProspecto = New MetroFramework.Controls.MetroLabel()
        Me.cbEventos = New MetroFramework.Controls.MetroComboBox()
        Me.ckbEventoProspecto = New MetroFramework.Controls.MetroCheckBox()
        Me.lblInteres = New MetroFramework.Controls.MetroLabel()
        Me.cbInteresesProspecto = New MetroFramework.Controls.MetroComboBox()
        Me.btnListarSeguimientos = New MetroFramework.Controls.MetroButton()
        Me.btnNuevoSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.txtFechaNacProspecto = New MetroFramework.Controls.MetroDateTime()
        Me.txtDireccionProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtProcedenciaProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmailProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtApellidosProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombreProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelarProspecto = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarProspecto = New MetroFramework.Controls.MetroButton()
        Me.tglEstaInteresado = New MetroFramework.Controls.MetroToggle()
        Me.lblInteresadoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblProcedenciaProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblDireccionProspecto = New MetroFramework.Controls.MetroLabel()
        Me.tglEstadoProspecto = New MetroFramework.Controls.MetroToggle()
        Me.lblTelefonoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblEstadoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblApellidosProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblFechaProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblCorreoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblNombreProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblCrearProspectos = New MetroFramework.Controls.MetroLabel()
        Me.lblClienteProspecto = New MetroFramework.Controls.MetroLabel()
        Me.tglEsCliente = New MetroFramework.Controls.MetroToggle()
        Me.PnlListaProspectos = New MetroFramework.Controls.MetroPanel()
        Me.btnAsignarProspecto = New MetroFramework.Controls.MetroButton()
        Me.lblListaProspectos = New MetroFramework.Controls.MetroLabel()
        Me.btnCrearProspecto = New MetroFramework.Controls.MetroButton()
        Me.lstProspectos = New System.Windows.Forms.DataGridView()
        Me.ColumnaIDProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaNombreProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaApellidosProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaNacimientoProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaProcedenciaProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTelefonoProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEmailProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEditarProspecto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlSeguimientos = New MetroFramework.Controls.MetroPanel()
        Me.lblCrearSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.txtComentarioSeguimiento = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelarSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.lblComentarioSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.txtFechaSeguimiento = New MetroFramework.Controls.MetroDateTime()
        Me.lblFechaSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.PnlListaSeguimientos = New MetroFramework.Controls.MetroPanel()
        Me.btnCancelarListaSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.lstSeguimientos = New System.Windows.Forms.DataGridView()
        Me.ColumnaIDSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaFechaSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaComentarioSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEditarSeguimiento = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColumnaEliminarSeguimiento = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListaSeguimientos = New MetroFramework.Controls.MetroLabel()
        Me.pnlAsignarProspecto = New MetroFramework.Controls.MetroPanel()
        Me.btnQuitarProspAsignado = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarAsignarProsp = New MetroFramework.Controls.MetroButton()
        Me.btnCancelarAsignarProsp = New MetroFramework.Controls.MetroButton()
        Me.btnAsignarListaProsp = New MetroFramework.Controls.MetroButton()
        Me.ltbProspAsignados = New System.Windows.Forms.ListBox()
        Me.lblProspAsignados = New MetroFramework.Controls.MetroLabel()
        Me.ltbProspectosSlt = New System.Windows.Forms.ListBox()
        Me.ltbVendedoresSlt = New System.Windows.Forms.ListBox()
        Me.lblProspectosSlt = New MetroFramework.Controls.MetroLabel()
        Me.lblVendedoresSlt = New MetroFramework.Controls.MetroLabel()
        Me.lblAsignarProspecto = New MetroFramework.Controls.MetroLabel()
        Me.KPIHolder = New MetroFramework.Controls.MetroTabPage()
        Me.panSeleccionarTipoKPI = New MetroFramework.Controls.MetroPanel()
        Me.TileKpiProductos = New MetroFramework.Controls.MetroTile()
        Me.TileKpiProspecto = New MetroFramework.Controls.MetroTile()
        Me.TileKpiVentas = New MetroFramework.Controls.MetroTile()
        Me.pnlCrearKpiProducto = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadoKpiProductos = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiProducto = New MetroFramework.Controls.MetroButton()
        Me.btnCrearKpiProducto = New MetroFramework.Controls.MetroButton()
        Me.checkBoxTotalProducto = New MetroFramework.Controls.MetroCheckBox()
        Me.lblCrearKpiProducto = New MetroFramework.Controls.MetroLabel()
        Me.pnlKpiProspectos = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadosKpiProspectos = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiProspecto = New MetroFramework.Controls.MetroButton()
        Me.BtnGenerarKpiProspecto = New MetroFramework.Controls.MetroButton()
        Me.checkboxTotalProspetosCliente = New MetroFramework.Controls.MetroCheckBox()
        Me.checkBoxTotalProspectos = New MetroFramework.Controls.MetroCheckBox()
        Me.lblCrearKpiProspecto = New MetroFramework.Controls.MetroLabel()
        Me.panKpiVentas = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadosVentas = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiVenta = New MetroFramework.Controls.MetroButton()
        Me.btnCrearKpiVenta = New MetroFramework.Controls.MetroButton()
        Me.checkBoxMontoTotalVentas = New MetroFramework.Controls.MetroCheckBox()
        Me.checkBoxTotalVentas = New MetroFramework.Controls.MetroCheckBox()
        Me.crearKPIVentas = New MetroFramework.Controls.MetroLabel()
        Me.TabConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.pnlUpdateUserInfo = New MetroFramework.Controls.MetroPanel()
        Me.tgChangePassUpdateUserInfo = New MetroFramework.Controls.MetroToggle()
        Me.txtPasswordUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCheckPasswordUpdate = New MetroFramework.Controls.MetroLabel()
        Me.txtNewPassUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.lblNewpassUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.cboDateUpdateUserInfo = New MetroFramework.Controls.MetroDateTime()
        Me.lblDateUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmailUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.txtLastNameUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhoneUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtNameUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelUpdateUserInfo = New MetroFramework.Controls.MetroButton()
        Me.btnSaveUpdateUserInfo = New MetroFramework.Controls.MetroButton()
        Me.lblPasswordUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblPhoneUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblNameUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblLastNameUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblIdUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblChangePasswordTittle = New MetroFramework.Controls.MetroLabel()
        Me.tileChangeInformation = New MetroFramework.Controls.MetroTile()
        Me.TabUsuarios = New MetroFramework.Controls.MetroTabPage()
        Me.pnlCreateRol = New MetroFramework.Controls.MetroPanel()
        Me.gboPermissionsRol = New System.Windows.Forms.GroupBox()
        Me.grpPermisosWeb = New System.Windows.Forms.GroupBox()
        Me.tgPreguntasRol = New MetroFramework.Controls.MetroToggle()
        Me.lblPregunntas = New MetroFramework.Controls.MetroLabel()
        Me.lblPermisosWeb = New MetroFramework.Controls.MetroLabel()
        Me.tgEvaluacionesRol = New MetroFramework.Controls.MetroToggle()
        Me.lblEvaluations = New MetroFramework.Controls.MetroLabel()
        Me.lblReportsRol = New MetroFramework.Controls.MetroLabel()
        Me.tgReportsRol = New MetroFramework.Controls.MetroToggle()
        Me.tgUsersRol = New MetroFramework.Controls.MetroToggle()
        Me.lblUsersRol = New MetroFramework.Controls.MetroLabel()
        Me.gboPorductsSectionRol = New System.Windows.Forms.GroupBox()
        Me.lblActisRol = New MetroFramework.Controls.MetroLabel()
        Me.lblCareersRol = New MetroFramework.Controls.MetroLabel()
        Me.tgCareersRol = New MetroFramework.Controls.MetroToggle()
        Me.tgActiRol = New MetroFramework.Controls.MetroToggle()
        Me.lblProductsSectionRol = New MetroFramework.Controls.MetroLabel()
        Me.tgConfigurationRol = New MetroFramework.Controls.MetroToggle()
        Me.tgKpiRol = New MetroFramework.Controls.MetroToggle()
        Me.tgEventsRol = New MetroFramework.Controls.MetroToggle()
        Me.tgProspectusRol = New MetroFramework.Controls.MetroToggle()
        Me.tgSalesRol = New MetroFramework.Controls.MetroToggle()
        Me.lblConfigurationRol = New MetroFramework.Controls.MetroLabel()
        Me.lblKpiRol = New MetroFramework.Controls.MetroLabel()
        Me.lblEventsRol = New MetroFramework.Controls.MetroLabel()
        Me.lblProspectusRol = New MetroFramework.Controls.MetroLabel()
        Me.lblSalesRol = New MetroFramework.Controls.MetroLabel()
        Me.lblPermissionsRol = New MetroFramework.Controls.MetroLabel()
        Me.tgEnabledRol = New MetroFramework.Controls.MetroToggle()
        Me.txtRolName = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelRol = New MetroFramework.Controls.MetroButton()
        Me.btnSaveRol = New MetroFramework.Controls.MetroButton()
        Me.btnEnabledRol = New MetroFramework.Controls.MetroLabel()
        Me.lblNameRol = New MetroFramework.Controls.MetroLabel()
        Me.lblCreateRolTittle = New MetroFramework.Controls.MetroLabel()
        Me.pnlCreateUser = New MetroFramework.Controls.MetroPanel()
        Me.lblImportEstudiantes = New MetroFramework.Controls.MetroLabel()
        Me.lblImportProfesores = New MetroFramework.Controls.MetroLabel()
        Me.lblPasswordUserBackup = New System.Windows.Forms.Label()
        Me.chkChangeUserPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.cboDateCreateUser = New MetroFramework.Controls.MetroDateTime()
        Me.lblDateCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmailCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtLastNameCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.cboRolCreateUser = New MetroFramework.Controls.MetroComboBox()
        Me.tgEnableCreateUser = New MetroFramework.Controls.MetroToggle()
        Me.lblRolCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblEnabledCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtPhoneCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtPasswordCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtNameCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelCreateUser = New MetroFramework.Controls.MetroButton()
        Me.btnSaveCreateUser = New MetroFramework.Controls.MetroButton()
        Me.lblPaswordCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblPhoneCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblNameCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblLastNameCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblCedulaCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblCreateUserTittle = New MetroFramework.Controls.MetroLabel()
        Me.pnListUsers = New MetroFramework.Controls.MetroPanel()
        Me.lblCreateUpdateUserId = New MetroFramework.Controls.MetroLabel()
        Me.lstUsers = New System.Windows.Forms.DataGridView()
        Me.colIdLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identificationLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userNameLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userLastNameLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userPhoneLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userEmailLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userStateLstUsers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userEditLstUsers = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblRolsSection = New MetroFramework.Controls.MetroLink()
        Me.lblListOfUsersTittle = New MetroFramework.Controls.MetroLabel()
        Me.btnCreateUser = New MetroFramework.Controls.MetroButton()
        Me.pnlListRols = New MetroFramework.Controls.MetroPanel()
        Me.btnBackRolsUsers = New MetroFramework.Controls.MetroButton()
        Me.lblIdRol = New MetroFramework.Controls.MetroLabel()
        Me.lstListRols = New System.Windows.Forms.DataGridView()
        Me.colIdListRols = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNameRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStateRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditListRol = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListOfRols = New MetroFramework.Controls.MetroLabel()
        Me.btnNewRol = New MetroFramework.Controls.MetroButton()
        Me.TabVentas = New MetroFramework.Controls.MetroTabPage()
        Me.pnlRegistrarVenta = New MetroFramework.Controls.MetroPanel()
        Me.totalVenta_text = New MetroFramework.Controls.MetroTextBox()
        Me.lblTotalVenta = New MetroFramework.Controls.MetroLabel()
        Me.lblMatriculaVenta = New MetroFramework.Controls.MetroLabel()
        Me.matricula_text = New MetroFramework.Controls.MetroTextBox()
        Me.productos_cmb = New System.Windows.Forms.ComboBox()
        Me.cod_prod_cmb = New System.Windows.Forms.ComboBox()
        Me.btnCancelarVenta = New MetroFramework.Controls.MetroButton()
        Me.lblCostoVenta = New MetroFramework.Controls.MetroLabel()
        Me.costoVenta_text = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardarVenta = New MetroFramework.Controls.MetroButton()
        Me.tipo_prodVenta_cmb = New System.Windows.Forms.ComboBox()
        Me.lblTipoVenta = New MetroFramework.Controls.MetroLabel()
        Me.lblProductoVenta = New MetroFramework.Controls.MetroLabel()
        Me.lblCodProductoVenta = New MetroFramework.Controls.MetroLabel()
        Me.lblRegistrarVenta = New MetroFramework.Controls.MetroLabel()
        Me.pnlConsultarVentas = New MetroFramework.Controls.MetroPanel()
        Me.btnVolverConsultaVentas = New MetroFramework.Controls.MetroButton()
        Me.grpConsultaIngresos = New System.Windows.Forms.GroupBox()
        Me.ingresosConsulta_dg = New System.Windows.Forms.DataGridView()
        Me.nombreUsuarioIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresosConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodoIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblIngresos = New MetroFramework.Controls.MetroLabel()
        Me.grpConsultaVentas = New System.Windows.Forms.GroupBox()
        Me.ventasConsulta_dg = New System.Windows.Forms.DataGridView()
        Me.idConsultaVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreUsuarioConsultaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadVentasConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodoConsultaVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVentas = New MetroFramework.Controls.MetroLabel()
        Me.periodos_cmb = New System.Windows.Forms.ComboBox()
        Me.lblPeriodoConsultarVenta = New MetroFramework.Controls.MetroLabel()
        Me.usuarioConsulta_cmb = New System.Windows.Forms.ComboBox()
        Me.lblUsuarioConsultarVenta = New MetroFramework.Controls.MetroLabel()
        Me.lblConsultarVentas = New MetroFramework.Controls.MetroLabel()
        Me.pnlListarVentas = New MetroFramework.Controls.MetroPanel()
        Me.btnVolverListarVenta = New MetroFramework.Controls.MetroButton()
        Me.dgListaVentas = New System.Windows.Forms.DataGridView()
        Me.idListarVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editarVenta = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListaVentas = New MetroFramework.Controls.MetroLabel()
        Me.btnNuevaVenta = New MetroFramework.Controls.MetroButton()
        Me.btnListarVentasIcon = New MetroFramework.Controls.MetroTile()
        Me.btnRegistrarVentaIcon = New MetroFramework.Controls.MetroTile()
        Me.btnConsultarVentasIcon = New MetroFramework.Controls.MetroTile()
        Me.TabReportes = New MetroFramework.Controls.MetroTabPage()
        Me.IdActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horarioActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInicioActi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.checkBoxTopProduto = New MetroFramework.Controls.MetroCheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCloseSession = New MetroFramework.Controls.MetroLink()
        Me.Main.SuspendLayout()
        Me.TabProductos.SuspendLayout()
        Me.registrarActi_pnl.SuspendLayout()
        CType(Me.minsFin5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.horariosActi_grp.SuspendLayout()
        Me.listaActis_pnl.SuspendLayout()
        CType(Me.listaActis_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegistrarCarrera.SuspendLayout()
        Me.pnlListaCarreras.SuspendLayout()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Eventos.SuspendLayout()
        Me.PanelListarEventos.SuspendLayout()
        CType(Me.DataListarEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCrearEvento.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.PnlNuevoProspecto.SuspendLayout()
        Me.PnlListaProspectos.SuspendLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSeguimientos.SuspendLayout()
        Me.PnlListaSeguimientos.SuspendLayout()
        CType(Me.lstSeguimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAsignarProspecto.SuspendLayout()
        Me.KPIHolder.SuspendLayout()
        Me.panSeleccionarTipoKPI.SuspendLayout()
        Me.pnlCrearKpiProducto.SuspendLayout()
        Me.pnlKpiProspectos.SuspendLayout()
        Me.panKpiVentas.SuspendLayout()
        Me.TabConfiguracion.SuspendLayout()
        Me.pnlUpdateUserInfo.SuspendLayout()
        Me.TabUsuarios.SuspendLayout()
        Me.pnlCreateRol.SuspendLayout()
        Me.gboPermissionsRol.SuspendLayout()
        Me.grpPermisosWeb.SuspendLayout()
        Me.gboPorductsSectionRol.SuspendLayout()
        Me.pnlCreateUser.SuspendLayout()
        Me.pnListUsers.SuspendLayout()
        CType(Me.lstUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlListRols.SuspendLayout()
        CType(Me.lstListRols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVentas.SuspendLayout()
        Me.pnlRegistrarVenta.SuspendLayout()
        Me.pnlConsultarVentas.SuspendLayout()
        Me.grpConsultaIngresos.SuspendLayout()
        CType(Me.ingresosConsulta_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsultaVentas.SuspendLayout()
        CType(Me.ventasConsulta_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlListarVentas.SuspendLayout()
        CType(Me.dgListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.Controls.Add(Me.TabProductos)
        Me.Main.Controls.Add(Me.Eventos)
        Me.Main.Controls.Add(Me.TabProspectos)
        Me.Main.Controls.Add(Me.KPIHolder)
        Me.Main.Controls.Add(Me.TabConfiguracion)
        Me.Main.Controls.Add(Me.TabUsuarios)
        Me.Main.Controls.Add(Me.TabVentas)
        Me.Main.Controls.Add(Me.TabReportes)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.Main.Location = New System.Drawing.Point(20, 60)
        Me.Main.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Main.Name = "Main"
        Me.Main.SelectedIndex = 0
        Me.Main.Size = New System.Drawing.Size(760, 520)
        Me.Main.Style = MetroFramework.MetroColorStyle.Purple
        Me.Main.TabIndex = 1
        Me.Main.UseSelectable = True
        '
        'TabProductos
        '
        Me.TabProductos.Controls.Add(Me.registrarActi_pnl)
        Me.TabProductos.Controls.Add(Me.listaActis_pnl)
        Me.TabProductos.Controls.Add(Me.pnlRegistrarCarrera)
        Me.TabProductos.Controls.Add(Me.pnlListaCarreras)
        Me.TabProductos.Controls.Add(Me.btnCarrerasIcon)
        Me.TabProductos.Controls.Add(Me.btnActiIco)
        Me.TabProductos.HorizontalScrollbarBarColor = True
        Me.TabProductos.HorizontalScrollbarHighlightOnWheel = False
        Me.TabProductos.HorizontalScrollbarSize = 10
        Me.TabProductos.Location = New System.Drawing.Point(4, 44)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.Size = New System.Drawing.Size(752, 472)
        Me.TabProductos.TabIndex = 1
        Me.TabProductos.Text = "Productos"
        Me.TabProductos.VerticalScrollbarBarColor = True
        Me.TabProductos.VerticalScrollbarHighlightOnWheel = False
        Me.TabProductos.VerticalScrollbarSize = 10
        '
        'registrarActi_pnl
        '
        Me.registrarActi_pnl.Controls.Add(Me.fechaInicio_dp)
        Me.registrarActi_pnl.Controls.Add(Me.fechaInicioCurso)
        Me.registrarActi_pnl.Controls.Add(Me.cancelarAct_btn)
        Me.registrarActi_pnl.Controls.Add(Me.guardarAct_btn)
        Me.registrarActi_pnl.Controls.Add(Me.importarActis_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.minsFinActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.horaFinActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIniActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.horaIniActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia5Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia4Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia3Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia2Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia1Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni)
        Me.registrarActi_pnl.Controls.Add(Me.dia5_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia4Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia2Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia3Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia1Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.tipoActi_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.costoActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.nombreActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.codigoActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.nombreActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.tipoActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.codigoActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.horariosActi_grp)
        Me.registrarActi_pnl.Controls.Add(Me.lblCostoActi)
        Me.registrarActi_pnl.HorizontalScrollbarBarColor = True
        Me.registrarActi_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.registrarActi_pnl.HorizontalScrollbarSize = 10
        Me.registrarActi_pnl.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.registrarActi_pnl.Location = New System.Drawing.Point(0, 3)
        Me.registrarActi_pnl.Name = "registrarActi_pnl"
        Me.registrarActi_pnl.Size = New System.Drawing.Size(746, 462)
        Me.registrarActi_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.registrarActi_pnl.TabIndex = 84
        Me.registrarActi_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.registrarActi_pnl.VerticalScrollbarBarColor = True
        Me.registrarActi_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.registrarActi_pnl.VerticalScrollbarSize = 10
        Me.registrarActi_pnl.Visible = False
        '
        'fechaInicio_dp
        '
        Me.fechaInicio_dp.Location = New System.Drawing.Point(463, 84)
        Me.fechaInicio_dp.Name = "fechaInicio_dp"
        Me.fechaInicio_dp.Size = New System.Drawing.Size(200, 20)
        Me.fechaInicio_dp.TabIndex = 89
        '
        'fechaInicioCurso
        '
        Me.fechaInicioCurso.AutoSize = True
        Me.fechaInicioCurso.Location = New System.Drawing.Point(375, 86)
        Me.fechaInicioCurso.Name = "fechaInicioCurso"
        Me.fechaInicioCurso.Size = New System.Drawing.Size(77, 19)
        Me.fechaInicioCurso.TabIndex = 88
        Me.fechaInicioCurso.Text = "Fecha Inicio"
        '
        'cancelarAct_btn
        '
        Me.cancelarAct_btn.Location = New System.Drawing.Point(427, 421)
        Me.cancelarAct_btn.Name = "cancelarAct_btn"
        Me.cancelarAct_btn.Size = New System.Drawing.Size(97, 23)
        Me.cancelarAct_btn.TabIndex = 87
        Me.cancelarAct_btn.Text = "Cancelar"
        Me.cancelarAct_btn.UseSelectable = True
        '
        'guardarAct_btn
        '
        Me.guardarAct_btn.Location = New System.Drawing.Point(324, 421)
        Me.guardarAct_btn.Name = "guardarAct_btn"
        Me.guardarAct_btn.Size = New System.Drawing.Size(97, 23)
        Me.guardarAct_btn.TabIndex = 86
        Me.guardarAct_btn.Text = "Guardar"
        Me.guardarAct_btn.UseSelectable = True
        '
        'importarActis_lbl
        '
        Me.importarActis_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.importarActis_lbl.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.importarActis_lbl.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.importarActis_lbl.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.importarActis_lbl.Location = New System.Drawing.Point(151, 9)
        Me.importarActis_lbl.Name = "importarActis_lbl"
        Me.importarActis_lbl.Size = New System.Drawing.Size(123, 23)
        Me.importarActis_lbl.TabIndex = 85
        Me.importarActis_lbl.Text = "Importar Actis"
        Me.importarActis_lbl.UseCustomForeColor = True
        Me.importarActis_lbl.UseSelectable = True
        '
        'minsFinActi_lbl
        '
        Me.minsFinActi_lbl.AutoSize = True
        Me.minsFinActi_lbl.Location = New System.Drawing.Point(594, 224)
        Me.minsFinActi_lbl.Name = "minsFinActi_lbl"
        Me.minsFinActi_lbl.Size = New System.Drawing.Size(55, 19)
        Me.minsFinActi_lbl.TabIndex = 74
        Me.minsFinActi_lbl.Text = "Minutos"
        '
        'horaFinActi_lbl
        '
        Me.horaFinActi_lbl.AutoSize = True
        Me.horaFinActi_lbl.Location = New System.Drawing.Point(546, 224)
        Me.horaFinActi_lbl.Name = "horaFinActi_lbl"
        Me.horaFinActi_lbl.Size = New System.Drawing.Size(38, 19)
        Me.horaFinActi_lbl.TabIndex = 73
        Me.horaFinActi_lbl.Text = "Hora"
        '
        'minsFin5Acti_nmb
        '
        Me.minsFin5Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin5Acti_nmb.Location = New System.Drawing.Point(603, 354)
        Me.minsFin5Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin5Acti_nmb.Name = "minsFin5Acti_nmb"
        Me.minsFin5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin5Acti_nmb.TabIndex = 53
        '
        'minsFin4Acti_nmb
        '
        Me.minsFin4Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin4Acti_nmb.Location = New System.Drawing.Point(603, 327)
        Me.minsFin4Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin4Acti_nmb.Name = "minsFin4Acti_nmb"
        Me.minsFin4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin4Acti_nmb.TabIndex = 48
        '
        'minsFin3Acti_nmb
        '
        Me.minsFin3Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin3Acti_nmb.Location = New System.Drawing.Point(603, 300)
        Me.minsFin3Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin3Acti_nmb.Name = "minsFin3Acti_nmb"
        Me.minsFin3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin3Acti_nmb.TabIndex = 43
        '
        'minsFin2Acti_nmb
        '
        Me.minsFin2Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin2Acti_nmb.Location = New System.Drawing.Point(603, 273)
        Me.minsFin2Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin2Acti_nmb.Name = "minsFin2Acti_nmb"
        Me.minsFin2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin2Acti_nmb.TabIndex = 38
        '
        'minsFin1Acti_nmb
        '
        Me.minsFin1Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin1Acti_nmb.Location = New System.Drawing.Point(603, 246)
        Me.minsFin1Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin1Acti_nmb.Name = "minsFin1Acti_nmb"
        Me.minsFin1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin1Acti_nmb.TabIndex = 33
        '
        'horaFin5Acti_nmb
        '
        Me.horaFin5Acti_nmb.Location = New System.Drawing.Point(546, 354)
        Me.horaFin5Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin5Acti_nmb.Name = "horaFin5Acti_nmb"
        Me.horaFin5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin5Acti_nmb.TabIndex = 52
        '
        'horaFin4Acti_nmb
        '
        Me.horaFin4Acti_nmb.Location = New System.Drawing.Point(546, 327)
        Me.horaFin4Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin4Acti_nmb.Name = "horaFin4Acti_nmb"
        Me.horaFin4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin4Acti_nmb.TabIndex = 47
        '
        'horaFin3Acti_nmb
        '
        Me.horaFin3Acti_nmb.Location = New System.Drawing.Point(546, 300)
        Me.horaFin3Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin3Acti_nmb.Name = "horaFin3Acti_nmb"
        Me.horaFin3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin3Acti_nmb.TabIndex = 42
        '
        'horaFin2Acti_nmb
        '
        Me.horaFin2Acti_nmb.Location = New System.Drawing.Point(546, 273)
        Me.horaFin2Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin2Acti_nmb.Name = "horaFin2Acti_nmb"
        Me.horaFin2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin2Acti_nmb.TabIndex = 37
        '
        'horaFin1Acti_nmb
        '
        Me.horaFin1Acti_nmb.Location = New System.Drawing.Point(546, 246)
        Me.horaFin1Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin1Acti_nmb.Name = "horaFin1Acti_nmb"
        Me.horaFin1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin1Acti_nmb.TabIndex = 32
        '
        'minsIniActi_lbl
        '
        Me.minsIniActi_lbl.AutoSize = True
        Me.minsIniActi_lbl.Location = New System.Drawing.Point(462, 224)
        Me.minsIniActi_lbl.Name = "minsIniActi_lbl"
        Me.minsIniActi_lbl.Size = New System.Drawing.Size(55, 19)
        Me.minsIniActi_lbl.TabIndex = 62
        Me.minsIniActi_lbl.Text = "Minutos"
        '
        'horaIniActi_lbl
        '
        Me.horaIniActi_lbl.AutoSize = True
        Me.horaIniActi_lbl.Location = New System.Drawing.Point(414, 224)
        Me.horaIniActi_lbl.Name = "horaIniActi_lbl"
        Me.horaIniActi_lbl.Size = New System.Drawing.Size(38, 19)
        Me.horaIniActi_lbl.TabIndex = 61
        Me.horaIniActi_lbl.Text = "Hora"
        '
        'minsIni5Acti_nmb
        '
        Me.minsIni5Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni5Acti_nmb.Location = New System.Drawing.Point(471, 354)
        Me.minsIni5Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni5Acti_nmb.Name = "minsIni5Acti_nmb"
        Me.minsIni5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni5Acti_nmb.TabIndex = 51
        '
        'minsIni4Acti_nmb
        '
        Me.minsIni4Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni4Acti_nmb.Location = New System.Drawing.Point(471, 327)
        Me.minsIni4Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni4Acti_nmb.Name = "minsIni4Acti_nmb"
        Me.minsIni4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni4Acti_nmb.TabIndex = 46
        '
        'minsIni3Acti_nmb
        '
        Me.minsIni3Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni3Acti_nmb.Location = New System.Drawing.Point(471, 300)
        Me.minsIni3Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni3Acti_nmb.Name = "minsIni3Acti_nmb"
        Me.minsIni3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni3Acti_nmb.TabIndex = 41
        '
        'minsIni2Acti_nmb
        '
        Me.minsIni2Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni2Acti_nmb.Location = New System.Drawing.Point(471, 273)
        Me.minsIni2Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni2Acti_nmb.Name = "minsIni2Acti_nmb"
        Me.minsIni2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni2Acti_nmb.TabIndex = 36
        '
        'minsIni1Acti_nmb
        '
        Me.minsIni1Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni1Acti_nmb.Location = New System.Drawing.Point(471, 246)
        Me.minsIni1Acti_nmb.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.minsIni1Acti_nmb.Name = "minsIni1Acti_nmb"
        Me.minsIni1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni1Acti_nmb.TabIndex = 31
        '
        'horaIni5Acti_nmb
        '
        Me.horaIni5Acti_nmb.Location = New System.Drawing.Point(414, 354)
        Me.horaIni5Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni5Acti_nmb.Name = "horaIni5Acti_nmb"
        Me.horaIni5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni5Acti_nmb.TabIndex = 50
        '
        'horaIni4Acti_nmb
        '
        Me.horaIni4Acti_nmb.Location = New System.Drawing.Point(414, 327)
        Me.horaIni4Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni4Acti_nmb.Name = "horaIni4Acti_nmb"
        Me.horaIni4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni4Acti_nmb.TabIndex = 45
        '
        'horaIni3Acti_nmb
        '
        Me.horaIni3Acti_nmb.Location = New System.Drawing.Point(414, 300)
        Me.horaIni3Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni3Acti_nmb.Name = "horaIni3Acti_nmb"
        Me.horaIni3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni3Acti_nmb.TabIndex = 40
        '
        'horaIni2Acti_nmb
        '
        Me.horaIni2Acti_nmb.Location = New System.Drawing.Point(414, 273)
        Me.horaIni2Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni2Acti_nmb.Name = "horaIni2Acti_nmb"
        Me.horaIni2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni2Acti_nmb.TabIndex = 35
        '
        'horaIni1Acti_nmb
        '
        Me.horaIni1Acti_nmb.Location = New System.Drawing.Point(414, 246)
        Me.horaIni1Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni1Acti_nmb.Name = "horaIni1Acti_nmb"
        Me.horaIni1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni1Acti_nmb.TabIndex = 30
        '
        'dia5Acti_cmb
        '
        Me.dia5Acti_cmb.FormattingEnabled = True
        Me.dia5Acti_cmb.Location = New System.Drawing.Point(156, 351)
        Me.dia5Acti_cmb.Name = "dia5Acti_cmb"
        Me.dia5Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia5Acti_cmb.TabIndex = 49
        '
        'dia4Acti_cmb
        '
        Me.dia4Acti_cmb.FormattingEnabled = True
        Me.dia4Acti_cmb.Location = New System.Drawing.Point(156, 324)
        Me.dia4Acti_cmb.Name = "dia4Acti_cmb"
        Me.dia4Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia4Acti_cmb.TabIndex = 44
        '
        'dia3Acti_cmb
        '
        Me.dia3Acti_cmb.FormattingEnabled = True
        Me.dia3Acti_cmb.Location = New System.Drawing.Point(156, 297)
        Me.dia3Acti_cmb.Name = "dia3Acti_cmb"
        Me.dia3Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia3Acti_cmb.TabIndex = 39
        '
        'dia2Acti_cmb
        '
        Me.dia2Acti_cmb.FormattingEnabled = True
        Me.dia2Acti_cmb.Location = New System.Drawing.Point(156, 270)
        Me.dia2Acti_cmb.Name = "dia2Acti_cmb"
        Me.dia2Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia2Acti_cmb.TabIndex = 34
        '
        'dia1Acti_cmb
        '
        Me.dia1Acti_cmb.FormattingEnabled = True
        Me.dia1Acti_cmb.Location = New System.Drawing.Point(156, 243)
        Me.dia1Acti_cmb.Name = "dia1Acti_cmb"
        Me.dia1Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia1Acti_cmb.TabIndex = 29
        '
        'horaFin
        '
        Me.horaFin.AutoSize = True
        Me.horaFin.Location = New System.Drawing.Point(562, 191)
        Me.horaFin.Name = "horaFin"
        Me.horaFin.Size = New System.Drawing.Size(59, 19)
        Me.horaFin.TabIndex = 45
        Me.horaFin.Text = "Hora Fin"
        '
        'horaIni
        '
        Me.horaIni.AutoSize = True
        Me.horaIni.Location = New System.Drawing.Point(426, 191)
        Me.horaIni.Name = "horaIni"
        Me.horaIni.Size = New System.Drawing.Size(72, 19)
        Me.horaIni.TabIndex = 44
        Me.horaIni.Text = "Hora Inicio"
        '
        'dia5_lbl
        '
        Me.dia5_lbl.AutoSize = True
        Me.dia5_lbl.Location = New System.Drawing.Point(111, 351)
        Me.dia5_lbl.Name = "dia5_lbl"
        Me.dia5_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia5_lbl.TabIndex = 43
        Me.dia5_lbl.Text = "Dia 5"
        '
        'dia4Acti_lbl
        '
        Me.dia4Acti_lbl.AutoSize = True
        Me.dia4Acti_lbl.Location = New System.Drawing.Point(111, 324)
        Me.dia4Acti_lbl.Name = "dia4Acti_lbl"
        Me.dia4Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia4Acti_lbl.TabIndex = 42
        Me.dia4Acti_lbl.Text = "Dia 4"
        '
        'dia2Acti_lbl
        '
        Me.dia2Acti_lbl.AutoSize = True
        Me.dia2Acti_lbl.Location = New System.Drawing.Point(111, 270)
        Me.dia2Acti_lbl.Name = "dia2Acti_lbl"
        Me.dia2Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia2Acti_lbl.TabIndex = 41
        Me.dia2Acti_lbl.Text = "Dia 2"
        '
        'dia3Acti_lbl
        '
        Me.dia3Acti_lbl.AutoSize = True
        Me.dia3Acti_lbl.Location = New System.Drawing.Point(111, 297)
        Me.dia3Acti_lbl.Name = "dia3Acti_lbl"
        Me.dia3Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia3Acti_lbl.TabIndex = 40
        Me.dia3Acti_lbl.Text = "Dia 3"
        '
        'dia1Acti_lbl
        '
        Me.dia1Acti_lbl.AutoSize = True
        Me.dia1Acti_lbl.Location = New System.Drawing.Point(111, 243)
        Me.dia1Acti_lbl.Name = "dia1Acti_lbl"
        Me.dia1Acti_lbl.Size = New System.Drawing.Size(37, 19)
        Me.dia1Acti_lbl.TabIndex = 39
        Me.dia1Acti_lbl.Text = "Dia 1"
        '
        'tipoActi_cmb
        '
        Me.tipoActi_cmb.FormattingEnabled = True
        Me.tipoActi_cmb.ItemHeight = 13
        Me.tipoActi_cmb.Location = New System.Drawing.Point(157, 117)
        Me.tipoActi_cmb.Name = "tipoActi_cmb"
        Me.tipoActi_cmb.Size = New System.Drawing.Size(148, 21)
        Me.tipoActi_cmb.TabIndex = 27
        '
        'costoActi_text
        '
        '
        '
        '
        Me.costoActi_text.CustomButton.Image = Nothing
        Me.costoActi_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.costoActi_text.CustomButton.Name = ""
        Me.costoActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoActi_text.CustomButton.TabIndex = 1
        Me.costoActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoActi_text.CustomButton.UseSelectable = True
        Me.costoActi_text.CustomButton.Visible = False
        Me.costoActi_text.Lines = New String(-1) {}
        Me.costoActi_text.Location = New System.Drawing.Point(157, 146)
        Me.costoActi_text.MaxLength = 8
        Me.costoActi_text.Name = "costoActi_text"
        Me.costoActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoActi_text.SelectedText = ""
        Me.costoActi_text.SelectionLength = 0
        Me.costoActi_text.SelectionStart = 0
        Me.costoActi_text.Size = New System.Drawing.Size(148, 23)
        Me.costoActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoActi_text.TabIndex = 28
        Me.costoActi_text.UseSelectable = True
        Me.costoActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nombreActi_text
        '
        '
        '
        '
        Me.nombreActi_text.CustomButton.Image = Nothing
        Me.nombreActi_text.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.nombreActi_text.CustomButton.Name = ""
        Me.nombreActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nombreActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nombreActi_text.CustomButton.TabIndex = 1
        Me.nombreActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nombreActi_text.CustomButton.UseSelectable = True
        Me.nombreActi_text.CustomButton.Visible = False
        Me.nombreActi_text.Lines = New String(-1) {}
        Me.nombreActi_text.Location = New System.Drawing.Point(157, 55)
        Me.nombreActi_text.MaxLength = 100
        Me.nombreActi_text.Name = "nombreActi_text"
        Me.nombreActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nombreActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nombreActi_text.SelectedText = ""
        Me.nombreActi_text.SelectionLength = 0
        Me.nombreActi_text.SelectionStart = 0
        Me.nombreActi_text.Size = New System.Drawing.Size(506, 23)
        Me.nombreActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.nombreActi_text.TabIndex = 25
        Me.nombreActi_text.UseSelectable = True
        Me.nombreActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nombreActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'codigoActi_text
        '
        '
        '
        '
        Me.codigoActi_text.CustomButton.Image = Nothing
        Me.codigoActi_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.codigoActi_text.CustomButton.Name = ""
        Me.codigoActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.codigoActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.codigoActi_text.CustomButton.TabIndex = 1
        Me.codigoActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.codigoActi_text.CustomButton.UseSelectable = True
        Me.codigoActi_text.CustomButton.Visible = False
        Me.codigoActi_text.Lines = New String(-1) {}
        Me.codigoActi_text.Location = New System.Drawing.Point(157, 84)
        Me.codigoActi_text.MaxLength = 20
        Me.codigoActi_text.Name = "codigoActi_text"
        Me.codigoActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.codigoActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.codigoActi_text.SelectedText = ""
        Me.codigoActi_text.SelectionLength = 0
        Me.codigoActi_text.SelectionStart = 0
        Me.codigoActi_text.Size = New System.Drawing.Size(148, 23)
        Me.codigoActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.codigoActi_text.TabIndex = 26
        Me.codigoActi_text.UseSelectable = True
        Me.codigoActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.codigoActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nombreActi_lbl
        '
        Me.nombreActi_lbl.AutoSize = True
        Me.nombreActi_lbl.Location = New System.Drawing.Point(31, 55)
        Me.nombreActi_lbl.Name = "nombreActi_lbl"
        Me.nombreActi_lbl.Size = New System.Drawing.Size(59, 19)
        Me.nombreActi_lbl.TabIndex = 14
        Me.nombreActi_lbl.Text = "Nombre"
        '
        'tipoActi_lbl
        '
        Me.tipoActi_lbl.AutoSize = True
        Me.tipoActi_lbl.Location = New System.Drawing.Point(31, 117)
        Me.tipoActi_lbl.Name = "tipoActi_lbl"
        Me.tipoActi_lbl.Size = New System.Drawing.Size(35, 19)
        Me.tipoActi_lbl.TabIndex = 13
        Me.tipoActi_lbl.Text = "Tipo"
        '
        'codigoActi_lbl
        '
        Me.codigoActi_lbl.AutoSize = True
        Me.codigoActi_lbl.Location = New System.Drawing.Point(31, 86)
        Me.codigoActi_lbl.Name = "codigoActi_lbl"
        Me.codigoActi_lbl.Size = New System.Drawing.Size(79, 19)
        Me.codigoActi_lbl.TabIndex = 11
        Me.codigoActi_lbl.Text = "Codigo Acti"
        '
        'acti_lbl
        '
        Me.acti_lbl.AutoSize = True
        Me.acti_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.acti_lbl.Location = New System.Drawing.Point(4, 9)
        Me.acti_lbl.Name = "acti_lbl"
        Me.acti_lbl.Size = New System.Drawing.Size(111, 25)
        Me.acti_lbl.TabIndex = 10
        Me.acti_lbl.Text = "Registrar Acti"
        '
        'horariosActi_grp
        '
        Me.horariosActi_grp.BackColor = System.Drawing.SystemColors.Window
        Me.horariosActi_grp.Controls.Add(Me.lblHorarioActi)
        Me.horariosActi_grp.Location = New System.Drawing.Point(30, 176)
        Me.horariosActi_grp.Name = "horariosActi_grp"
        Me.horariosActi_grp.Size = New System.Drawing.Size(678, 222)
        Me.horariosActi_grp.TabIndex = 77
        Me.horariosActi_grp.TabStop = False
        '
        'lblHorarioActi
        '
        Me.lblHorarioActi.AutoSize = True
        Me.lblHorarioActi.Location = New System.Drawing.Point(1, -5)
        Me.lblHorarioActi.Name = "lblHorarioActi"
        Me.lblHorarioActi.Size = New System.Drawing.Size(59, 19)
        Me.lblHorarioActi.TabIndex = 90
        Me.lblHorarioActi.Text = "Horarios"
        '
        'lblCostoActi
        '
        Me.lblCostoActi.AutoSize = True
        Me.lblCostoActi.Location = New System.Drawing.Point(31, 146)
        Me.lblCostoActi.Name = "lblCostoActi"
        Me.lblCostoActi.Size = New System.Drawing.Size(43, 19)
        Me.lblCostoActi.TabIndex = 91
        Me.lblCostoActi.Text = "Costo"
        '
        'listaActis_pnl
        '
        Me.listaActis_pnl.Controls.Add(Me.exportarActi_btn)
        Me.listaActis_pnl.Controls.Add(Me.vovlerActi_btn)
        Me.listaActis_pnl.Controls.Add(Me.listaActis_dg)
        Me.listaActis_pnl.Controls.Add(Me.listaActis_lbl)
        Me.listaActis_pnl.Controls.Add(Me.nuevoActi_btn)
        Me.listaActis_pnl.HorizontalScrollbarBarColor = True
        Me.listaActis_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listaActis_pnl.HorizontalScrollbarSize = 10
        Me.listaActis_pnl.Location = New System.Drawing.Point(0, 3)
        Me.listaActis_pnl.Name = "listaActis_pnl"
        Me.listaActis_pnl.Size = New System.Drawing.Size(767, 461)
        Me.listaActis_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listaActis_pnl.TabIndex = 87
        Me.listaActis_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listaActis_pnl.VerticalScrollbarBarColor = True
        Me.listaActis_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listaActis_pnl.VerticalScrollbarSize = 10
        Me.listaActis_pnl.Visible = False
        '
        'exportarActi_btn
        '
        Me.exportarActi_btn.Location = New System.Drawing.Point(485, 412)
        Me.exportarActi_btn.Name = "exportarActi_btn"
        Me.exportarActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.exportarActi_btn.TabIndex = 52
        Me.exportarActi_btn.Text = "Exportar"
        Me.exportarActi_btn.UseSelectable = True
        '
        'vovlerActi_btn
        '
        Me.vovlerActi_btn.Location = New System.Drawing.Point(7, 412)
        Me.vovlerActi_btn.Name = "vovlerActi_btn"
        Me.vovlerActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.vovlerActi_btn.TabIndex = 50
        Me.vovlerActi_btn.Text = "Volver"
        Me.vovlerActi_btn.UseSelectable = True
        '
        'listaActis_dg
        '
        Me.listaActis_dg.AllowUserToAddRows = False
        Me.listaActis_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaActis_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdActi, Me.colNombreActi, Me.colCodigoActi, Me.colCostoActi, Me.colHorarioActi, Me.colFechaInicioActi, Me.editarActi})
        Me.listaActis_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaActis_dg.Name = "listaActis_dg"
        Me.listaActis_dg.RowHeadersVisible = False
        Me.listaActis_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaActis_dg.TabIndex = 12
        '
        'colIdActi
        '
        Me.colIdActi.HeaderText = "Id"
        Me.colIdActi.Name = "colIdActi"
        Me.colIdActi.Visible = False
        '
        'colNombreActi
        '
        Me.colNombreActi.HeaderText = "Nombre"
        Me.colNombreActi.Name = "colNombreActi"
        '
        'colCodigoActi
        '
        Me.colCodigoActi.HeaderText = "Codigo"
        Me.colCodigoActi.Name = "colCodigoActi"
        '
        'colCostoActi
        '
        Me.colCostoActi.HeaderText = "Costo"
        Me.colCostoActi.Name = "colCostoActi"
        '
        'colHorarioActi
        '
        Me.colHorarioActi.HeaderText = "Horario"
        Me.colHorarioActi.Name = "colHorarioActi"
        '
        'colFechaInicioActi
        '
        Me.colFechaInicioActi.HeaderText = "Fecha Inicio"
        Me.colFechaInicioActi.Name = "colFechaInicioActi"
        '
        'editarActi
        '
        Me.editarActi.HeaderText = ""
        Me.editarActi.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.editarActi.Name = "editarActi"
        Me.editarActi.Width = 300
        '
        'listaActis_lbl
        '
        Me.listaActis_lbl.AutoSize = True
        Me.listaActis_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.listaActis_lbl.Location = New System.Drawing.Point(0, 3)
        Me.listaActis_lbl.Name = "listaActis_lbl"
        Me.listaActis_lbl.Size = New System.Drawing.Size(91, 25)
        Me.listaActis_lbl.TabIndex = 10
        Me.listaActis_lbl.Text = "Listar Actis"
        '
        'nuevoActi_btn
        '
        Me.nuevoActi_btn.Location = New System.Drawing.Point(623, 412)
        Me.nuevoActi_btn.Name = "nuevoActi_btn"
        Me.nuevoActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.nuevoActi_btn.TabIndex = 9
        Me.nuevoActi_btn.Text = "Nuevo Acti"
        Me.nuevoActi_btn.UseSelectable = True
        '
        'pnlRegistrarCarrera
        '
        Me.pnlRegistrarCarrera.Controls.Add(Me.btnCancelarCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblCostoCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.costoCarrera_text)
        Me.pnlRegistrarCarrera.Controls.Add(Me.btnGuardarCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.tipoCarrera_cmb)
        Me.pnlRegistrarCarrera.Controls.Add(Me.codigoCarrera_text)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblTipoCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblCodigoCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblImportarCarrera)
        Me.pnlRegistrarCarrera.Controls.Add(Me.nombreCarrera_text)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblNombreActi)
        Me.pnlRegistrarCarrera.Controls.Add(Me.lblRegistrarCarrera)
        Me.pnlRegistrarCarrera.HorizontalScrollbarBarColor = True
        Me.pnlRegistrarCarrera.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlRegistrarCarrera.HorizontalScrollbarSize = 10
        Me.pnlRegistrarCarrera.Location = New System.Drawing.Point(0, 3)
        Me.pnlRegistrarCarrera.Name = "pnlRegistrarCarrera"
        Me.pnlRegistrarCarrera.Size = New System.Drawing.Size(746, 462)
        Me.pnlRegistrarCarrera.TabIndex = 6
        Me.pnlRegistrarCarrera.VerticalScrollbarBarColor = True
        Me.pnlRegistrarCarrera.VerticalScrollbarHighlightOnWheel = False
        Me.pnlRegistrarCarrera.VerticalScrollbarSize = 10
        Me.pnlRegistrarCarrera.Visible = False
        '
        'btnCancelarCarrera
        '
        Me.btnCancelarCarrera.Location = New System.Drawing.Point(427, 421)
        Me.btnCancelarCarrera.Name = "btnCancelarCarrera"
        Me.btnCancelarCarrera.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarCarrera.TabIndex = 95
        Me.btnCancelarCarrera.Text = "Cancelar"
        Me.btnCancelarCarrera.UseSelectable = True
        '
        'lblCostoCarrera
        '
        Me.lblCostoCarrera.AutoSize = True
        Me.lblCostoCarrera.Location = New System.Drawing.Point(49, 158)
        Me.lblCostoCarrera.Name = "lblCostoCarrera"
        Me.lblCostoCarrera.Size = New System.Drawing.Size(43, 19)
        Me.lblCostoCarrera.TabIndex = 93
        Me.lblCostoCarrera.Text = "Costo"
        '
        'costoCarrera_text
        '
        '
        '
        '
        Me.costoCarrera_text.CustomButton.Image = Nothing
        Me.costoCarrera_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.costoCarrera_text.CustomButton.Name = ""
        Me.costoCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoCarrera_text.CustomButton.TabIndex = 1
        Me.costoCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoCarrera_text.CustomButton.UseSelectable = True
        Me.costoCarrera_text.CustomButton.Visible = False
        Me.costoCarrera_text.Lines = New String(-1) {}
        Me.costoCarrera_text.Location = New System.Drawing.Point(175, 158)
        Me.costoCarrera_text.MaxLength = 8
        Me.costoCarrera_text.Name = "costoCarrera_text"
        Me.costoCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoCarrera_text.SelectedText = ""
        Me.costoCarrera_text.SelectionLength = 0
        Me.costoCarrera_text.SelectionStart = 0
        Me.costoCarrera_text.Size = New System.Drawing.Size(148, 23)
        Me.costoCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoCarrera_text.TabIndex = 91
        Me.costoCarrera_text.UseSelectable = True
        Me.costoCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuardarCarrera
        '
        Me.btnGuardarCarrera.Location = New System.Drawing.Point(324, 421)
        Me.btnGuardarCarrera.Name = "btnGuardarCarrera"
        Me.btnGuardarCarrera.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarCarrera.TabIndex = 94
        Me.btnGuardarCarrera.Text = "Guardar"
        Me.btnGuardarCarrera.UseSelectable = True
        '
        'tipoCarrera_cmb
        '
        Me.tipoCarrera_cmb.FormattingEnabled = True
        Me.tipoCarrera_cmb.ItemHeight = 13
        Me.tipoCarrera_cmb.Location = New System.Drawing.Point(175, 127)
        Me.tipoCarrera_cmb.Name = "tipoCarrera_cmb"
        Me.tipoCarrera_cmb.Size = New System.Drawing.Size(148, 21)
        Me.tipoCarrera_cmb.TabIndex = 90
        '
        'codigoCarrera_text
        '
        '
        '
        '
        Me.codigoCarrera_text.CustomButton.Image = Nothing
        Me.codigoCarrera_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.codigoCarrera_text.CustomButton.Name = ""
        Me.codigoCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.codigoCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.codigoCarrera_text.CustomButton.TabIndex = 1
        Me.codigoCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.codigoCarrera_text.CustomButton.UseSelectable = True
        Me.codigoCarrera_text.CustomButton.Visible = False
        Me.codigoCarrera_text.Lines = New String(-1) {}
        Me.codigoCarrera_text.Location = New System.Drawing.Point(175, 94)
        Me.codigoCarrera_text.MaxLength = 20
        Me.codigoCarrera_text.Name = "codigoCarrera_text"
        Me.codigoCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.codigoCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.codigoCarrera_text.SelectedText = ""
        Me.codigoCarrera_text.SelectionLength = 0
        Me.codigoCarrera_text.SelectionStart = 0
        Me.codigoCarrera_text.Size = New System.Drawing.Size(148, 23)
        Me.codigoCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.codigoCarrera_text.TabIndex = 89
        Me.codigoCarrera_text.UseSelectable = True
        Me.codigoCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.codigoCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTipoCarrera
        '
        Me.lblTipoCarrera.AutoSize = True
        Me.lblTipoCarrera.Location = New System.Drawing.Point(49, 127)
        Me.lblTipoCarrera.Name = "lblTipoCarrera"
        Me.lblTipoCarrera.Size = New System.Drawing.Size(35, 19)
        Me.lblTipoCarrera.TabIndex = 91
        Me.lblTipoCarrera.Text = "Tipo"
        '
        'lblCodigoCarrera
        '
        Me.lblCodigoCarrera.AutoSize = True
        Me.lblCodigoCarrera.Location = New System.Drawing.Point(49, 96)
        Me.lblCodigoCarrera.Name = "lblCodigoCarrera"
        Me.lblCodigoCarrera.Size = New System.Drawing.Size(102, 19)
        Me.lblCodigoCarrera.TabIndex = 90
        Me.lblCodigoCarrera.Text = "Codigo Carrera"
        '
        'lblImportarCarrera
        '
        Me.lblImportarCarrera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblImportarCarrera.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lblImportarCarrera.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.lblImportarCarrera.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblImportarCarrera.Location = New System.Drawing.Point(171, 16)
        Me.lblImportarCarrera.Name = "lblImportarCarrera"
        Me.lblImportarCarrera.Size = New System.Drawing.Size(147, 23)
        Me.lblImportarCarrera.TabIndex = 89
        Me.lblImportarCarrera.Text = "Importar Carreras"
        Me.lblImportarCarrera.UseCustomForeColor = True
        Me.lblImportarCarrera.UseSelectable = True
        '
        'nombreCarrera_text
        '
        '
        '
        '
        Me.nombreCarrera_text.CustomButton.Image = Nothing
        Me.nombreCarrera_text.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.nombreCarrera_text.CustomButton.Name = ""
        Me.nombreCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nombreCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nombreCarrera_text.CustomButton.TabIndex = 1
        Me.nombreCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nombreCarrera_text.CustomButton.UseSelectable = True
        Me.nombreCarrera_text.CustomButton.Visible = False
        Me.nombreCarrera_text.Lines = New String(-1) {}
        Me.nombreCarrera_text.Location = New System.Drawing.Point(175, 62)
        Me.nombreCarrera_text.MaxLength = 100
        Me.nombreCarrera_text.Name = "nombreCarrera_text"
        Me.nombreCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nombreCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nombreCarrera_text.SelectedText = ""
        Me.nombreCarrera_text.SelectionLength = 0
        Me.nombreCarrera_text.SelectionStart = 0
        Me.nombreCarrera_text.Size = New System.Drawing.Size(506, 23)
        Me.nombreCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.nombreCarrera_text.TabIndex = 88
        Me.nombreCarrera_text.UseSelectable = True
        Me.nombreCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nombreCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNombreActi
        '
        Me.lblNombreActi.AutoSize = True
        Me.lblNombreActi.Location = New System.Drawing.Point(49, 62)
        Me.lblNombreActi.Name = "lblNombreActi"
        Me.lblNombreActi.Size = New System.Drawing.Size(59, 19)
        Me.lblNombreActi.TabIndex = 87
        Me.lblNombreActi.Text = "Nombre"
        '
        'lblRegistrarCarrera
        '
        Me.lblRegistrarCarrera.AutoSize = True
        Me.lblRegistrarCarrera.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblRegistrarCarrera.Location = New System.Drawing.Point(22, 16)
        Me.lblRegistrarCarrera.Name = "lblRegistrarCarrera"
        Me.lblRegistrarCarrera.Size = New System.Drawing.Size(139, 25)
        Me.lblRegistrarCarrera.TabIndex = 86
        Me.lblRegistrarCarrera.Text = "Registrar Carrera"
        '
        'pnlListaCarreras
        '
        Me.pnlListaCarreras.Controls.Add(Me.btnExportar_Carreras)
        Me.pnlListaCarreras.Controls.Add(Me.btnVolver_Carrera)
        Me.pnlListaCarreras.Controls.Add(Me.listaCarreras_dg)
        Me.pnlListaCarreras.Controls.Add(Me.lblListaCrreras)
        Me.pnlListaCarreras.Controls.Add(Me.btnNueva_Carrera)
        Me.pnlListaCarreras.HorizontalScrollbarBarColor = True
        Me.pnlListaCarreras.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlListaCarreras.HorizontalScrollbarSize = 10
        Me.pnlListaCarreras.Location = New System.Drawing.Point(0, 3)
        Me.pnlListaCarreras.Name = "pnlListaCarreras"
        Me.pnlListaCarreras.Size = New System.Drawing.Size(767, 461)
        Me.pnlListaCarreras.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnlListaCarreras.TabIndex = 88
        Me.pnlListaCarreras.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlListaCarreras.VerticalScrollbarBarColor = True
        Me.pnlListaCarreras.VerticalScrollbarHighlightOnWheel = False
        Me.pnlListaCarreras.VerticalScrollbarSize = 10
        Me.pnlListaCarreras.Visible = False
        '
        'btnExportar_Carreras
        '
        Me.btnExportar_Carreras.Location = New System.Drawing.Point(485, 412)
        Me.btnExportar_Carreras.Name = "btnExportar_Carreras"
        Me.btnExportar_Carreras.Size = New System.Drawing.Size(123, 36)
        Me.btnExportar_Carreras.TabIndex = 52
        Me.btnExportar_Carreras.Text = "Exportar"
        Me.btnExportar_Carreras.UseSelectable = True
        '
        'btnVolver_Carrera
        '
        Me.btnVolver_Carrera.Location = New System.Drawing.Point(7, 412)
        Me.btnVolver_Carrera.Name = "btnVolver_Carrera"
        Me.btnVolver_Carrera.Size = New System.Drawing.Size(123, 36)
        Me.btnVolver_Carrera.TabIndex = 50
        Me.btnVolver_Carrera.Text = "Volver"
        Me.btnVolver_Carrera.UseSelectable = True
        '
        'listaCarreras_dg
        '
        Me.listaCarreras_dg.AllowUserToAddRows = False
        Me.listaCarreras_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaCarreras_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_carrera, Me.nombre_carrera, Me.codigo_carrera, Me.costo_carrera, Me.editarCarrera})
        Me.listaCarreras_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaCarreras_dg.Name = "listaCarreras_dg"
        Me.listaCarreras_dg.RowHeadersVisible = False
        Me.listaCarreras_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaCarreras_dg.TabIndex = 12
        '
        'id_carrera
        '
        Me.id_carrera.HeaderText = "Id"
        Me.id_carrera.Name = "id_carrera"
        Me.id_carrera.Visible = False
        '
        'nombre_carrera
        '
        Me.nombre_carrera.HeaderText = "Nombre"
        Me.nombre_carrera.Name = "nombre_carrera"
        '
        'codigo_carrera
        '
        Me.codigo_carrera.HeaderText = "Codigo"
        Me.codigo_carrera.Name = "codigo_carrera"
        '
        'costo_carrera
        '
        Me.costo_carrera.HeaderText = "Costo"
        Me.costo_carrera.Name = "costo_carrera"
        '
        'editarCarrera
        '
        Me.editarCarrera.HeaderText = ""
        Me.editarCarrera.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.editarCarrera.Name = "editarCarrera"
        Me.editarCarrera.Width = 500
        '
        'lblListaCrreras
        '
        Me.lblListaCrreras.AutoSize = True
        Me.lblListaCrreras.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaCrreras.Location = New System.Drawing.Point(2, 3)
        Me.lblListaCrreras.Name = "lblListaCrreras"
        Me.lblListaCrreras.Size = New System.Drawing.Size(119, 25)
        Me.lblListaCrreras.TabIndex = 10
        Me.lblListaCrreras.Text = "Listar Carreras"
        '
        'btnNueva_Carrera
        '
        Me.btnNueva_Carrera.Location = New System.Drawing.Point(623, 412)
        Me.btnNueva_Carrera.Name = "btnNueva_Carrera"
        Me.btnNueva_Carrera.Size = New System.Drawing.Size(123, 36)
        Me.btnNueva_Carrera.TabIndex = 9
        Me.btnNueva_Carrera.Text = "Nueva Carrera"
        Me.btnNueva_Carrera.UseSelectable = True
        '
        'btnCarrerasIcon
        '
        Me.btnCarrerasIcon.ActiveControl = Nothing
        Me.btnCarrerasIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarrerasIcon.Location = New System.Drawing.Point(24, 27)
        Me.btnCarrerasIcon.Name = "btnCarrerasIcon"
        Me.btnCarrerasIcon.Size = New System.Drawing.Size(124, 119)
        Me.btnCarrerasIcon.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCarrerasIcon.TabIndex = 3
        Me.btnCarrerasIcon.Text = "Carreras"
        Me.btnCarrerasIcon.UseSelectable = True
        Me.btnCarrerasIcon.Visible = False
        '
        'btnActiIco
        '
        Me.btnActiIco.ActiveControl = Nothing
        Me.btnActiIco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActiIco.Location = New System.Drawing.Point(165, 27)
        Me.btnActiIco.Name = "btnActiIco"
        Me.btnActiIco.Size = New System.Drawing.Size(124, 119)
        Me.btnActiIco.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnActiIco.TabIndex = 4
        Me.btnActiIco.Text = "Acti's"
        Me.btnActiIco.UseSelectable = True
        Me.btnActiIco.Visible = False
        '
        'Eventos
        '
        Me.Eventos.Controls.Add(Me.PanelListarEventos)
        Me.Eventos.Controls.Add(Me.PanelCrearEvento)
        Me.Eventos.HorizontalScrollbarBarColor = True
        Me.Eventos.HorizontalScrollbarHighlightOnWheel = False
        Me.Eventos.HorizontalScrollbarSize = 10
        Me.Eventos.Location = New System.Drawing.Point(4, 44)
        Me.Eventos.Name = "Eventos"
        Me.Eventos.Size = New System.Drawing.Size(752, 472)
        Me.Eventos.TabIndex = 7
        Me.Eventos.Text = "Eventos"
        Me.Eventos.VerticalScrollbarBarColor = True
        Me.Eventos.VerticalScrollbarHighlightOnWheel = False
        Me.Eventos.VerticalScrollbarSize = 10
        '
        'PanelListarEventos
        '
        Me.PanelListarEventos.Controls.Add(Me.btnCrearEvento)
        Me.PanelListarEventos.Controls.Add(Me.DataListarEventos)
        Me.PanelListarEventos.Controls.Add(Me.lblEventos)
        Me.PanelListarEventos.HorizontalScrollbarBarColor = True
        Me.PanelListarEventos.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelListarEventos.HorizontalScrollbarSize = 10
        Me.PanelListarEventos.Location = New System.Drawing.Point(3, 9)
        Me.PanelListarEventos.Name = "PanelListarEventos"
        Me.PanelListarEventos.Size = New System.Drawing.Size(752, 742)
        Me.PanelListarEventos.TabIndex = 36
        Me.PanelListarEventos.VerticalScrollbarBarColor = True
        Me.PanelListarEventos.VerticalScrollbarHighlightOnWheel = False
        Me.PanelListarEventos.VerticalScrollbarSize = 10
        '
        'btnCrearEvento
        '
        Me.btnCrearEvento.Location = New System.Drawing.Point(620, 412)
        Me.btnCrearEvento.Name = "btnCrearEvento"
        Me.btnCrearEvento.Size = New System.Drawing.Size(123, 36)
        Me.btnCrearEvento.TabIndex = 14
        Me.btnCrearEvento.Text = "Crear Evento"
        Me.btnCrearEvento.UseSelectable = True
        '
        'DataListarEventos
        '
        Me.DataListarEventos.AllowUserToAddRows = False
        Me.DataListarEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListarEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.FechaInicio, Me.FechaFin, Me.IdEvento, Me.editar})
        Me.DataListarEventos.Location = New System.Drawing.Point(39, 42)
        Me.DataListarEventos.Name = "DataListarEventos"
        Me.DataListarEventos.Size = New System.Drawing.Size(643, 357)
        Me.DataListarEventos.TabIndex = 13
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Lugar"
        Me.Nombre.Name = "Nombre"
        '
        'FechaInicio
        '
        Me.FechaInicio.HeaderText = "Fecha Inicio"
        Me.FechaInicio.Name = "FechaInicio"
        '
        'FechaFin
        '
        Me.FechaFin.HeaderText = "Finaliza"
        Me.FechaFin.Name = "FechaFin"
        '
        'IdEvento
        '
        Me.IdEvento.HeaderText = "ID"
        Me.IdEvento.Name = "IdEvento"
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.editar.Name = "editar"
        Me.editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'lblEventos
        '
        Me.lblEventos.AutoSize = True
        Me.lblEventos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblEventos.Location = New System.Drawing.Point(4, 9)
        Me.lblEventos.Name = "lblEventos"
        Me.lblEventos.Size = New System.Drawing.Size(70, 25)
        Me.lblEventos.TabIndex = 12
        Me.lblEventos.Text = "Eventos"
        '
        'PanelCrearEvento
        '
        Me.PanelCrearEvento.Controls.Add(Me.dateFin)
        Me.PanelCrearEvento.Controls.Add(Me.lblFechaFin)
        Me.PanelCrearEvento.Controls.Add(Me.btnCancelarEvento)
        Me.PanelCrearEvento.Controls.Add(Me.btnGuardarEvento)
        Me.PanelCrearEvento.Controls.Add(Me.lblFechaInicio)
        Me.PanelCrearEvento.Controls.Add(Me.dateEventos)
        Me.PanelCrearEvento.Controls.Add(Me.TxtnombreEventos)
        Me.PanelCrearEvento.Controls.Add(Me.lblLugar)
        Me.PanelCrearEvento.Controls.Add(Me.EventosLbl)
        Me.PanelCrearEvento.HorizontalScrollbarBarColor = True
        Me.PanelCrearEvento.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelCrearEvento.HorizontalScrollbarSize = 10
        Me.PanelCrearEvento.Location = New System.Drawing.Point(3, 10)
        Me.PanelCrearEvento.Name = "PanelCrearEvento"
        Me.PanelCrearEvento.Size = New System.Drawing.Size(752, 472)
        Me.PanelCrearEvento.TabIndex = 2
        Me.PanelCrearEvento.VerticalScrollbarBarColor = True
        Me.PanelCrearEvento.VerticalScrollbarHighlightOnWheel = False
        Me.PanelCrearEvento.VerticalScrollbarSize = 10
        '
        'dateFin
        '
        Me.dateFin.Location = New System.Drawing.Point(158, 248)
        Me.dateFin.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dateFin.Name = "dateFin"
        Me.dateFin.Size = New System.Drawing.Size(200, 29)
        Me.dateFin.TabIndex = 40
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(24, 248)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(52, 19)
        Me.lblFechaFin.TabIndex = 39
        Me.lblFechaFin.Text = "Finaliza"
        '
        'btnCancelarEvento
        '
        Me.btnCancelarEvento.Location = New System.Drawing.Point(427, 436)
        Me.btnCancelarEvento.Name = "btnCancelarEvento"
        Me.btnCancelarEvento.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarEvento.TabIndex = 38
        Me.btnCancelarEvento.Text = "Cancelar"
        Me.btnCancelarEvento.UseSelectable = True
        '
        'btnGuardarEvento
        '
        Me.btnGuardarEvento.Location = New System.Drawing.Point(324, 436)
        Me.btnGuardarEvento.Name = "btnGuardarEvento"
        Me.btnGuardarEvento.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarEvento.TabIndex = 37
        Me.btnGuardarEvento.Text = "Guardar"
        Me.btnGuardarEvento.UseSelectable = True
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(24, 153)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(43, 19)
        Me.lblFechaInicio.TabIndex = 27
        Me.lblFechaInicio.Text = "Fecha"
        '
        'dateEventos
        '
        Me.dateEventos.Location = New System.Drawing.Point(158, 153)
        Me.dateEventos.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dateEventos.Name = "dateEventos"
        Me.dateEventos.Size = New System.Drawing.Size(200, 29)
        Me.dateEventos.TabIndex = 26
        '
        'TxtnombreEventos
        '
        '
        '
        '
        Me.TxtnombreEventos.CustomButton.Image = Nothing
        Me.TxtnombreEventos.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.TxtnombreEventos.CustomButton.Name = ""
        Me.TxtnombreEventos.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TxtnombreEventos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtnombreEventos.CustomButton.TabIndex = 1
        Me.TxtnombreEventos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtnombreEventos.CustomButton.UseSelectable = True
        Me.TxtnombreEventos.CustomButton.Visible = False
        Me.TxtnombreEventos.Lines = New String(-1) {}
        Me.TxtnombreEventos.Location = New System.Drawing.Point(157, 90)
        Me.TxtnombreEventos.MaxLength = 32767
        Me.TxtnombreEventos.Name = "TxtnombreEventos"
        Me.TxtnombreEventos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtnombreEventos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtnombreEventos.SelectedText = ""
        Me.TxtnombreEventos.SelectionLength = 0
        Me.TxtnombreEventos.SelectionStart = 0
        Me.TxtnombreEventos.Size = New System.Drawing.Size(367, 23)
        Me.TxtnombreEventos.Style = MetroFramework.MetroColorStyle.Purple
        Me.TxtnombreEventos.TabIndex = 25
        Me.TxtnombreEventos.UseSelectable = True
        Me.TxtnombreEventos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtnombreEventos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Location = New System.Drawing.Point(24, 81)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(42, 19)
        Me.lblLugar.TabIndex = 12
        Me.lblLugar.Text = "Lugar"
        '
        'EventosLbl
        '
        Me.EventosLbl.AutoSize = True
        Me.EventosLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.EventosLbl.Location = New System.Drawing.Point(4, 9)
        Me.EventosLbl.Name = "EventosLbl"
        Me.EventosLbl.Size = New System.Drawing.Size(109, 25)
        Me.EventosLbl.TabIndex = 11
        Me.EventosLbl.Text = "Crear Evento"
        '
        'TabProspectos
        '
        Me.TabProspectos.Controls.Add(Me.PnlNuevoProspecto)
        Me.TabProspectos.Controls.Add(Me.PnlListaProspectos)
        Me.TabProspectos.Controls.Add(Me.pnlSeguimientos)
        Me.TabProspectos.Controls.Add(Me.PnlListaSeguimientos)
        Me.TabProspectos.Controls.Add(Me.pnlAsignarProspecto)
        Me.TabProspectos.HorizontalScrollbarBarColor = True
        Me.TabProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.TabProspectos.HorizontalScrollbarSize = 10
        Me.TabProspectos.Location = New System.Drawing.Point(4, 44)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Size = New System.Drawing.Size(752, 472)
        Me.TabProspectos.TabIndex = 6
        Me.TabProspectos.Text = "Prospectos"
        Me.TabProspectos.VerticalScrollbarBarColor = True
        Me.TabProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.TabProspectos.VerticalScrollbarSize = 10
        '
        'PnlNuevoProspecto
        '
        Me.PnlNuevoProspecto.Controls.Add(Me.lblImportarProspectos)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblIdSeguimiento)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblIdProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.cbEventos)
        Me.PnlNuevoProspecto.Controls.Add(Me.ckbEventoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblInteres)
        Me.PnlNuevoProspecto.Controls.Add(Me.cbInteresesProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnListarSeguimientos)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnNuevoSeguimiento)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtFechaNacProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtDireccionProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtProcedenciaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtTelProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtEmailProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtApellidosProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtNombreProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnCancelarProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnGuardarProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEstaInteresado)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblInteresadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblProcedenciaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblDireccionProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEstadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblTelefonoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblEstadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblApellidosProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblFechaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblCorreoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblNombreProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblCrearProspectos)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblClienteProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEsCliente)
        Me.PnlNuevoProspecto.HorizontalScrollbarBarColor = True
        Me.PnlNuevoProspecto.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlNuevoProspecto.HorizontalScrollbarSize = 10
        Me.PnlNuevoProspecto.Location = New System.Drawing.Point(4, 14)
        Me.PnlNuevoProspecto.Name = "PnlNuevoProspecto"
        Me.PnlNuevoProspecto.Size = New System.Drawing.Size(704, 459)
        Me.PnlNuevoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.PnlNuevoProspecto.TabIndex = 44
        Me.PnlNuevoProspecto.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PnlNuevoProspecto.VerticalScrollbarBarColor = True
        Me.PnlNuevoProspecto.VerticalScrollbarHighlightOnWheel = False
        Me.PnlNuevoProspecto.VerticalScrollbarSize = 10
        Me.PnlNuevoProspecto.Visible = False
        '
        'lblImportarProspectos
        '
        Me.lblImportarProspectos.AutoSize = True
        Me.lblImportarProspectos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblImportarProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblImportarProspectos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblImportarProspectos.Location = New System.Drawing.Point(155, 4)
        Me.lblImportarProspectos.Name = "lblImportarProspectos"
        Me.lblImportarProspectos.Size = New System.Drawing.Size(165, 25)
        Me.lblImportarProspectos.TabIndex = 49
        Me.lblImportarProspectos.Text = "Importar prospectos"
        Me.lblImportarProspectos.UseCustomForeColor = True
        '
        'lblIdSeguimiento
        '
        Me.lblIdSeguimiento.AutoSize = True
        Me.lblIdSeguimiento.Location = New System.Drawing.Point(648, 9)
        Me.lblIdSeguimiento.Name = "lblIdSeguimiento"
        Me.lblIdSeguimiento.Size = New System.Drawing.Size(20, 19)
        Me.lblIdSeguimiento.TabIndex = 48
        Me.lblIdSeguimiento.Text = "-1"
        Me.lblIdSeguimiento.Visible = False
        '
        'lblIdProspecto
        '
        Me.lblIdProspecto.AutoSize = True
        Me.lblIdProspecto.Location = New System.Drawing.Point(671, 9)
        Me.lblIdProspecto.Name = "lblIdProspecto"
        Me.lblIdProspecto.Size = New System.Drawing.Size(20, 19)
        Me.lblIdProspecto.TabIndex = 47
        Me.lblIdProspecto.Text = "-1"
        Me.lblIdProspecto.Visible = False
        '
        'cbEventos
        '
        Me.cbEventos.Enabled = False
        Me.cbEventos.FormattingEnabled = True
        Me.cbEventos.ItemHeight = 23
        Me.cbEventos.Location = New System.Drawing.Point(403, 209)
        Me.cbEventos.Name = "cbEventos"
        Me.cbEventos.Size = New System.Drawing.Size(121, 29)
        Me.cbEventos.Style = MetroFramework.MetroColorStyle.Purple
        Me.cbEventos.TabIndex = 46
        Me.cbEventos.UseSelectable = True
        '
        'ckbEventoProspecto
        '
        Me.ckbEventoProspecto.AutoSize = True
        Me.ckbEventoProspecto.Location = New System.Drawing.Point(329, 217)
        Me.ckbEventoProspecto.Name = "ckbEventoProspecto"
        Me.ckbEventoProspecto.Size = New System.Drawing.Size(59, 15)
        Me.ckbEventoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.ckbEventoProspecto.TabIndex = 45
        Me.ckbEventoProspecto.Text = "Evento"
        Me.ckbEventoProspecto.UseSelectable = True
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(324, 356)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(59, 19)
        Me.lblInteres.TabIndex = 44
        Me.lblInteres.Text = "Intereses"
        '
        'cbInteresesProspecto
        '
        Me.cbInteresesProspecto.Enabled = False
        Me.cbInteresesProspecto.ItemHeight = 23
        Me.cbInteresesProspecto.Location = New System.Drawing.Point(403, 356)
        Me.cbInteresesProspecto.Name = "cbInteresesProspecto"
        Me.cbInteresesProspecto.Size = New System.Drawing.Size(121, 29)
        Me.cbInteresesProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.cbInteresesProspecto.TabIndex = 43
        Me.cbInteresesProspecto.UseSelectable = True
        '
        'btnListarSeguimientos
        '
        Me.btnListarSeguimientos.Location = New System.Drawing.Point(575, 104)
        Me.btnListarSeguimientos.Name = "btnListarSeguimientos"
        Me.btnListarSeguimientos.Size = New System.Drawing.Size(116, 37)
        Me.btnListarSeguimientos.TabIndex = 37
        Me.btnListarSeguimientos.Text = "Lista seguimientos"
        Me.btnListarSeguimientos.UseSelectable = True
        Me.btnListarSeguimientos.Visible = False
        '
        'btnNuevoSeguimiento
        '
        Me.btnNuevoSeguimiento.Location = New System.Drawing.Point(575, 51)
        Me.btnNuevoSeguimiento.Name = "btnNuevoSeguimiento"
        Me.btnNuevoSeguimiento.Size = New System.Drawing.Size(116, 37)
        Me.btnNuevoSeguimiento.TabIndex = 36
        Me.btnNuevoSeguimiento.Text = "Nuevo seguimiento"
        Me.btnNuevoSeguimiento.UseSelectable = True
        Me.btnNuevoSeguimiento.Visible = False
        '
        'txtFechaNacProspecto
        '
        Me.txtFechaNacProspecto.CustomFormat = ""
        Me.txtFechaNacProspecto.Location = New System.Drawing.Point(158, 112)
        Me.txtFechaNacProspecto.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtFechaNacProspecto.Name = "txtFechaNacProspecto"
        Me.txtFechaNacProspecto.Size = New System.Drawing.Size(367, 29)
        Me.txtFechaNacProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtFechaNacProspecto.TabIndex = 32
        Me.txtFechaNacProspecto.Value = New Date(2015, 11, 1, 16, 55, 54, 0)
        '
        'txtDireccionProspecto
        '
        '
        '
        '
        Me.txtDireccionProspecto.CustomButton.Image = Nothing
        Me.txtDireccionProspecto.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.txtDireccionProspecto.CustomButton.Name = ""
        Me.txtDireccionProspecto.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.txtDireccionProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccionProspecto.CustomButton.TabIndex = 1
        Me.txtDireccionProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccionProspecto.CustomButton.UseSelectable = True
        Me.txtDireccionProspecto.CustomButton.Visible = False
        Me.txtDireccionProspecto.Lines = New String(-1) {}
        Me.txtDireccionProspecto.Location = New System.Drawing.Point(158, 248)
        Me.txtDireccionProspecto.MaxLength = 32767
        Me.txtDireccionProspecto.Multiline = True
        Me.txtDireccionProspecto.Name = "txtDireccionProspecto"
        Me.txtDireccionProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccionProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccionProspecto.SelectedText = ""
        Me.txtDireccionProspecto.SelectionLength = 0
        Me.txtDireccionProspecto.SelectionStart = 0
        Me.txtDireccionProspecto.Size = New System.Drawing.Size(367, 67)
        Me.txtDireccionProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtDireccionProspecto.TabIndex = 31
        Me.txtDireccionProspecto.UseSelectable = True
        Me.txtDireccionProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccionProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtProcedenciaProspecto
        '
        '
        '
        '
        Me.txtProcedenciaProspecto.CustomButton.Image = Nothing
        Me.txtProcedenciaProspecto.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtProcedenciaProspecto.CustomButton.Name = ""
        Me.txtProcedenciaProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtProcedenciaProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProcedenciaProspecto.CustomButton.TabIndex = 1
        Me.txtProcedenciaProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProcedenciaProspecto.CustomButton.UseSelectable = True
        Me.txtProcedenciaProspecto.CustomButton.Visible = False
        Me.txtProcedenciaProspecto.Lines = New String(-1) {}
        Me.txtProcedenciaProspecto.Location = New System.Drawing.Point(158, 213)
        Me.txtProcedenciaProspecto.MaxLength = 32767
        Me.txtProcedenciaProspecto.Name = "txtProcedenciaProspecto"
        Me.txtProcedenciaProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProcedenciaProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProcedenciaProspecto.SelectedText = ""
        Me.txtProcedenciaProspecto.SelectionLength = 0
        Me.txtProcedenciaProspecto.SelectionStart = 0
        Me.txtProcedenciaProspecto.Size = New System.Drawing.Size(154, 23)
        Me.txtProcedenciaProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtProcedenciaProspecto.TabIndex = 30
        Me.txtProcedenciaProspecto.UseSelectable = True
        Me.txtProcedenciaProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProcedenciaProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelProspecto
        '
        '
        '
        '
        Me.txtTelProspecto.CustomButton.Image = Nothing
        Me.txtTelProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtTelProspecto.CustomButton.Name = ""
        Me.txtTelProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelProspecto.CustomButton.TabIndex = 1
        Me.txtTelProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelProspecto.CustomButton.UseSelectable = True
        Me.txtTelProspecto.CustomButton.Visible = False
        Me.txtTelProspecto.Lines = New String(-1) {}
        Me.txtTelProspecto.Location = New System.Drawing.Point(158, 180)
        Me.txtTelProspecto.MaxLength = 32767
        Me.txtTelProspecto.Name = "txtTelProspecto"
        Me.txtTelProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelProspecto.SelectedText = ""
        Me.txtTelProspecto.SelectionLength = 0
        Me.txtTelProspecto.SelectionStart = 0
        Me.txtTelProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtTelProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTelProspecto.TabIndex = 28
        Me.txtTelProspecto.UseSelectable = True
        Me.txtTelProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmailProspecto
        '
        '
        '
        '
        Me.txtEmailProspecto.CustomButton.Image = Nothing
        Me.txtEmailProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailProspecto.CustomButton.Name = ""
        Me.txtEmailProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailProspecto.CustomButton.TabIndex = 1
        Me.txtEmailProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailProspecto.CustomButton.UseSelectable = True
        Me.txtEmailProspecto.CustomButton.Visible = False
        Me.txtEmailProspecto.Lines = New String(-1) {}
        Me.txtEmailProspecto.Location = New System.Drawing.Point(158, 148)
        Me.txtEmailProspecto.MaxLength = 32767
        Me.txtEmailProspecto.Name = "txtEmailProspecto"
        Me.txtEmailProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailProspecto.SelectedText = ""
        Me.txtEmailProspecto.SelectionLength = 0
        Me.txtEmailProspecto.SelectionStart = 0
        Me.txtEmailProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailProspecto.TabIndex = 27
        Me.txtEmailProspecto.UseSelectable = True
        Me.txtEmailProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApellidosProspecto
        '
        '
        '
        '
        Me.txtApellidosProspecto.CustomButton.Image = Nothing
        Me.txtApellidosProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtApellidosProspecto.CustomButton.Name = ""
        Me.txtApellidosProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtApellidosProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApellidosProspecto.CustomButton.TabIndex = 1
        Me.txtApellidosProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApellidosProspecto.CustomButton.UseSelectable = True
        Me.txtApellidosProspecto.CustomButton.Visible = False
        Me.txtApellidosProspecto.Lines = New String(-1) {}
        Me.txtApellidosProspecto.Location = New System.Drawing.Point(158, 82)
        Me.txtApellidosProspecto.MaxLength = 32767
        Me.txtApellidosProspecto.Name = "txtApellidosProspecto"
        Me.txtApellidosProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidosProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellidosProspecto.SelectedText = ""
        Me.txtApellidosProspecto.SelectionLength = 0
        Me.txtApellidosProspecto.SelectionStart = 0
        Me.txtApellidosProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtApellidosProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtApellidosProspecto.TabIndex = 25
        Me.txtApellidosProspecto.UseSelectable = True
        Me.txtApellidosProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApellidosProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombreProspecto
        '
        '
        '
        '
        Me.txtNombreProspecto.CustomButton.Image = Nothing
        Me.txtNombreProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNombreProspecto.CustomButton.Name = ""
        Me.txtNombreProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreProspecto.CustomButton.TabIndex = 1
        Me.txtNombreProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreProspecto.CustomButton.UseSelectable = True
        Me.txtNombreProspecto.CustomButton.Visible = False
        Me.txtNombreProspecto.Lines = New String(-1) {}
        Me.txtNombreProspecto.Location = New System.Drawing.Point(158, 51)
        Me.txtNombreProspecto.MaxLength = 32767
        Me.txtNombreProspecto.Name = "txtNombreProspecto"
        Me.txtNombreProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreProspecto.SelectedText = ""
        Me.txtNombreProspecto.SelectionLength = 0
        Me.txtNombreProspecto.SelectionStart = 0
        Me.txtNombreProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtNombreProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombreProspecto.TabIndex = 24
        Me.txtNombreProspecto.UseSelectable = True
        Me.txtNombreProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelarProspecto
        '
        Me.btnCancelarProspecto.Location = New System.Drawing.Point(423, 433)
        Me.btnCancelarProspecto.Name = "btnCancelarProspecto"
        Me.btnCancelarProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarProspecto.TabIndex = 23
        Me.btnCancelarProspecto.Text = "Cancelar"
        Me.btnCancelarProspecto.UseSelectable = True
        '
        'btnGuardarProspecto
        '
        Me.btnGuardarProspecto.Location = New System.Drawing.Point(320, 433)
        Me.btnGuardarProspecto.Name = "btnGuardarProspecto"
        Me.btnGuardarProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarProspecto.TabIndex = 22
        Me.btnGuardarProspecto.Text = "Guardar"
        Me.btnGuardarProspecto.UseSelectable = True
        '
        'tglEstaInteresado
        '
        Me.tglEstaInteresado.AutoSize = True
        Me.tglEstaInteresado.Location = New System.Drawing.Point(158, 356)
        Me.tglEstaInteresado.Name = "tglEstaInteresado"
        Me.tglEstaInteresado.Size = New System.Drawing.Size(80, 17)
        Me.tglEstaInteresado.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEstaInteresado.TabIndex = 21
        Me.tglEstaInteresado.Text = "Off"
        Me.tglEstaInteresado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEstaInteresado.UseSelectable = True
        '
        'lblInteresadoProspecto
        '
        Me.lblInteresadoProspecto.AutoSize = True
        Me.lblInteresadoProspecto.Location = New System.Drawing.Point(24, 354)
        Me.lblInteresadoProspecto.Name = "lblInteresadoProspecto"
        Me.lblInteresadoProspecto.Size = New System.Drawing.Size(70, 19)
        Me.lblInteresadoProspecto.TabIndex = 20
        Me.lblInteresadoProspecto.Text = "Interesado"
        '
        'lblProcedenciaProspecto
        '
        Me.lblProcedenciaProspecto.AutoSize = True
        Me.lblProcedenciaProspecto.Location = New System.Drawing.Point(24, 213)
        Me.lblProcedenciaProspecto.Name = "lblProcedenciaProspecto"
        Me.lblProcedenciaProspecto.Size = New System.Drawing.Size(81, 19)
        Me.lblProcedenciaProspecto.TabIndex = 19
        Me.lblProcedenciaProspecto.Text = "Procedencia"
        '
        'lblDireccionProspecto
        '
        Me.lblDireccionProspecto.AutoSize = True
        Me.lblDireccionProspecto.Location = New System.Drawing.Point(25, 248)
        Me.lblDireccionProspecto.Name = "lblDireccionProspecto"
        Me.lblDireccionProspecto.Size = New System.Drawing.Size(63, 19)
        Me.lblDireccionProspecto.TabIndex = 18
        Me.lblDireccionProspecto.Text = "Dirección"
        '
        'tglEstadoProspecto
        '
        Me.tglEstadoProspecto.AutoSize = True
        Me.tglEstadoProspecto.Checked = True
        Me.tglEstadoProspecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tglEstadoProspecto.Location = New System.Drawing.Point(158, 328)
        Me.tglEstadoProspecto.Name = "tglEstadoProspecto"
        Me.tglEstadoProspecto.Size = New System.Drawing.Size(80, 17)
        Me.tglEstadoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEstadoProspecto.TabIndex = 17
        Me.tglEstadoProspecto.Text = "On"
        Me.tglEstadoProspecto.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEstadoProspecto.UseSelectable = True
        '
        'lblTelefonoProspecto
        '
        Me.lblTelefonoProspecto.AutoSize = True
        Me.lblTelefonoProspecto.Location = New System.Drawing.Point(24, 180)
        Me.lblTelefonoProspecto.Name = "lblTelefonoProspecto"
        Me.lblTelefonoProspecto.Size = New System.Drawing.Size(58, 19)
        Me.lblTelefonoProspecto.TabIndex = 16
        Me.lblTelefonoProspecto.Text = "Telefono"
        '
        'lblEstadoProspecto
        '
        Me.lblEstadoProspecto.AutoSize = True
        Me.lblEstadoProspecto.Location = New System.Drawing.Point(24, 326)
        Me.lblEstadoProspecto.Name = "lblEstadoProspecto"
        Me.lblEstadoProspecto.Size = New System.Drawing.Size(48, 19)
        Me.lblEstadoProspecto.TabIndex = 15
        Me.lblEstadoProspecto.Text = "Estado"
        '
        'lblApellidosProspecto
        '
        Me.lblApellidosProspecto.AutoSize = True
        Me.lblApellidosProspecto.Location = New System.Drawing.Point(24, 82)
        Me.lblApellidosProspecto.Name = "lblApellidosProspecto"
        Me.lblApellidosProspecto.Size = New System.Drawing.Size(58, 19)
        Me.lblApellidosProspecto.TabIndex = 14
        Me.lblApellidosProspecto.Text = "Apellido"
        '
        'lblFechaProspecto
        '
        Me.lblFechaProspecto.AutoSize = True
        Me.lblFechaProspecto.Location = New System.Drawing.Point(25, 114)
        Me.lblFechaProspecto.Name = "lblFechaProspecto"
        Me.lblFechaProspecto.Size = New System.Drawing.Size(111, 19)
        Me.lblFechaProspecto.TabIndex = 13
        Me.lblFechaProspecto.Text = "Fecha nacimiento"
        '
        'lblCorreoProspecto
        '
        Me.lblCorreoProspecto.AutoSize = True
        Me.lblCorreoProspecto.Location = New System.Drawing.Point(24, 148)
        Me.lblCorreoProspecto.Name = "lblCorreoProspecto"
        Me.lblCorreoProspecto.Size = New System.Drawing.Size(51, 19)
        Me.lblCorreoProspecto.TabIndex = 12
        Me.lblCorreoProspecto.Text = "Correo"
        '
        'lblNombreProspecto
        '
        Me.lblNombreProspecto.AutoSize = True
        Me.lblNombreProspecto.Location = New System.Drawing.Point(24, 51)
        Me.lblNombreProspecto.Name = "lblNombreProspecto"
        Me.lblNombreProspecto.Size = New System.Drawing.Size(59, 19)
        Me.lblNombreProspecto.TabIndex = 11
        Me.lblNombreProspecto.Text = "Nombre"
        '
        'lblCrearProspectos
        '
        Me.lblCrearProspectos.AutoSize = True
        Me.lblCrearProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearProspectos.Location = New System.Drawing.Point(-2, 4)
        Me.lblCrearProspectos.Name = "lblCrearProspectos"
        Me.lblCrearProspectos.Size = New System.Drawing.Size(133, 25)
        Me.lblCrearProspectos.TabIndex = 10
        Me.lblCrearProspectos.Text = "Crear prospecto"
        '
        'lblClienteProspecto
        '
        Me.lblClienteProspecto.AutoSize = True
        Me.lblClienteProspecto.Location = New System.Drawing.Point(25, 384)
        Me.lblClienteProspecto.Name = "lblClienteProspecto"
        Me.lblClienteProspecto.Size = New System.Drawing.Size(49, 19)
        Me.lblClienteProspecto.TabIndex = 34
        Me.lblClienteProspecto.Text = "Cliente"
        '
        'tglEsCliente
        '
        Me.tglEsCliente.AutoSize = True
        Me.tglEsCliente.Location = New System.Drawing.Point(158, 384)
        Me.tglEsCliente.Name = "tglEsCliente"
        Me.tglEsCliente.Size = New System.Drawing.Size(80, 17)
        Me.tglEsCliente.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEsCliente.TabIndex = 35
        Me.tglEsCliente.Text = "Off"
        Me.tglEsCliente.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEsCliente.UseSelectable = True
        '
        'PnlListaProspectos
        '
        Me.PnlListaProspectos.Controls.Add(Me.btnAsignarProspecto)
        Me.PnlListaProspectos.Controls.Add(Me.lblListaProspectos)
        Me.PnlListaProspectos.Controls.Add(Me.btnCrearProspecto)
        Me.PnlListaProspectos.Controls.Add(Me.lstProspectos)
        Me.PnlListaProspectos.HorizontalScrollbarBarColor = True
        Me.PnlListaProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.HorizontalScrollbarSize = 10
        Me.PnlListaProspectos.Location = New System.Drawing.Point(0, 20)
        Me.PnlListaProspectos.Name = "PnlListaProspectos"
        Me.PnlListaProspectos.Size = New System.Drawing.Size(749, 452)
        Me.PnlListaProspectos.Style = MetroFramework.MetroColorStyle.White
        Me.PnlListaProspectos.TabIndex = 41
        Me.PnlListaProspectos.VerticalScrollbarBarColor = True
        Me.PnlListaProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.VerticalScrollbarSize = 10
        '
        'btnAsignarProspecto
        '
        Me.btnAsignarProspecto.Location = New System.Drawing.Point(4, 412)
        Me.btnAsignarProspecto.Name = "btnAsignarProspecto"
        Me.btnAsignarProspecto.Size = New System.Drawing.Size(123, 36)
        Me.btnAsignarProspecto.TabIndex = 43
        Me.btnAsignarProspecto.Text = "Asignar prospectos"
        Me.btnAsignarProspecto.UseSelectable = True
        '
        'lblListaProspectos
        '
        Me.lblListaProspectos.AutoSize = True
        Me.lblListaProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaProspectos.Location = New System.Drawing.Point(4, 0)
        Me.lblListaProspectos.Name = "lblListaProspectos"
        Me.lblListaProspectos.Size = New System.Drawing.Size(132, 25)
        Me.lblListaProspectos.TabIndex = 10
        Me.lblListaProspectos.Text = "Lista prospectos"
        '
        'btnCrearProspecto
        '
        Me.btnCrearProspecto.Location = New System.Drawing.Point(620, 412)
        Me.btnCrearProspecto.Name = "btnCrearProspecto"
        Me.btnCrearProspecto.Size = New System.Drawing.Size(122, 36)
        Me.btnCrearProspecto.TabIndex = 9
        Me.btnCrearProspecto.Text = "Nuevo prospecto"
        Me.btnCrearProspecto.UseSelectable = True
        '
        'lstProspectos
        '
        Me.lstProspectos.AllowUserToAddRows = False
        Me.lstProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstProspectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaIDProspecto, Me.ColumnaNombreProspecto, Me.ColumnaApellidosProspecto, Me.ColumnaNacimientoProspecto, Me.ColumnaProcedenciaProspecto, Me.ColumnaTelefonoProspecto, Me.ColumnaEmailProspecto, Me.ColumnaEditarProspecto})
        Me.lstProspectos.Location = New System.Drawing.Point(4, 37)
        Me.lstProspectos.Name = "lstProspectos"
        Me.lstProspectos.RowHeadersVisible = False
        Me.lstProspectos.Size = New System.Drawing.Size(739, 344)
        Me.lstProspectos.TabIndex = 8
        '
        'ColumnaIDProspecto
        '
        Me.ColumnaIDProspecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaIDProspecto.HeaderText = "ID"
        Me.ColumnaIDProspecto.Name = "ColumnaIDProspecto"
        Me.ColumnaIDProspecto.ReadOnly = True
        Me.ColumnaIDProspecto.Visible = False
        '
        'ColumnaNombreProspecto
        '
        Me.ColumnaNombreProspecto.HeaderText = "Nombre"
        Me.ColumnaNombreProspecto.Name = "ColumnaNombreProspecto"
        Me.ColumnaNombreProspecto.ReadOnly = True
        '
        'ColumnaApellidosProspecto
        '
        Me.ColumnaApellidosProspecto.HeaderText = "Apellidos"
        Me.ColumnaApellidosProspecto.Name = "ColumnaApellidosProspecto"
        Me.ColumnaApellidosProspecto.ReadOnly = True
        '
        'ColumnaNacimientoProspecto
        '
        Me.ColumnaNacimientoProspecto.HeaderText = "Nacimiento"
        Me.ColumnaNacimientoProspecto.Name = "ColumnaNacimientoProspecto"
        Me.ColumnaNacimientoProspecto.ReadOnly = True
        '
        'ColumnaProcedenciaProspecto
        '
        Me.ColumnaProcedenciaProspecto.HeaderText = "Procedencia"
        Me.ColumnaProcedenciaProspecto.Name = "ColumnaProcedenciaProspecto"
        Me.ColumnaProcedenciaProspecto.ReadOnly = True
        '
        'ColumnaTelefonoProspecto
        '
        Me.ColumnaTelefonoProspecto.HeaderText = "Teléfono"
        Me.ColumnaTelefonoProspecto.Name = "ColumnaTelefonoProspecto"
        Me.ColumnaTelefonoProspecto.ReadOnly = True
        '
        'ColumnaEmailProspecto
        '
        Me.ColumnaEmailProspecto.HeaderText = "E-mail"
        Me.ColumnaEmailProspecto.Name = "ColumnaEmailProspecto"
        Me.ColumnaEmailProspecto.ReadOnly = True
        '
        'ColumnaEditarProspecto
        '
        Me.ColumnaEditarProspecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaEditarProspecto.HeaderText = ""
        Me.ColumnaEditarProspecto.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.ColumnaEditarProspecto.Name = "ColumnaEditarProspecto"
        Me.ColumnaEditarProspecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditarProspecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'pnlSeguimientos
        '
        Me.pnlSeguimientos.Controls.Add(Me.lblCrearSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.txtComentarioSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.btnCancelarSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.btnGuardarSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.lblComentarioSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.txtFechaSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.lblFechaSeguimiento)
        Me.pnlSeguimientos.HorizontalScrollbarBarColor = True
        Me.pnlSeguimientos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlSeguimientos.HorizontalScrollbarSize = 10
        Me.pnlSeguimientos.Location = New System.Drawing.Point(4, 14)
        Me.pnlSeguimientos.Name = "pnlSeguimientos"
        Me.pnlSeguimientos.Size = New System.Drawing.Size(565, 235)
        Me.pnlSeguimientos.TabIndex = 42
        Me.pnlSeguimientos.VerticalScrollbarBarColor = True
        Me.pnlSeguimientos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlSeguimientos.VerticalScrollbarSize = 10
        Me.pnlSeguimientos.Visible = False
        '
        'lblCrearSeguimiento
        '
        Me.lblCrearSeguimiento.AutoSize = True
        Me.lblCrearSeguimiento.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearSeguimiento.Location = New System.Drawing.Point(-2, 4)
        Me.lblCrearSeguimiento.Name = "lblCrearSeguimiento"
        Me.lblCrearSeguimiento.Size = New System.Drawing.Size(151, 25)
        Me.lblCrearSeguimiento.TabIndex = 40
        Me.lblCrearSeguimiento.Text = "Crear seguimiento"
        '
        'txtComentarioSeguimiento
        '
        '
        '
        '
        Me.txtComentarioSeguimiento.CustomButton.Image = Nothing
        Me.txtComentarioSeguimiento.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.txtComentarioSeguimiento.CustomButton.Name = ""
        Me.txtComentarioSeguimiento.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.txtComentarioSeguimiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComentarioSeguimiento.CustomButton.TabIndex = 1
        Me.txtComentarioSeguimiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComentarioSeguimiento.CustomButton.UseSelectable = True
        Me.txtComentarioSeguimiento.CustomButton.Visible = False
        Me.txtComentarioSeguimiento.Lines = New String(-1) {}
        Me.txtComentarioSeguimiento.Location = New System.Drawing.Point(155, 102)
        Me.txtComentarioSeguimiento.MaxLength = 32767
        Me.txtComentarioSeguimiento.Multiline = True
        Me.txtComentarioSeguimiento.Name = "txtComentarioSeguimiento"
        Me.txtComentarioSeguimiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentarioSeguimiento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComentarioSeguimiento.SelectedText = ""
        Me.txtComentarioSeguimiento.SelectionLength = 0
        Me.txtComentarioSeguimiento.SelectionStart = 0
        Me.txtComentarioSeguimiento.Size = New System.Drawing.Size(367, 67)
        Me.txtComentarioSeguimiento.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtComentarioSeguimiento.TabIndex = 39
        Me.txtComentarioSeguimiento.UseSelectable = True
        Me.txtComentarioSeguimiento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComentarioSeguimiento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelarSeguimiento
        '
        Me.btnCancelarSeguimiento.Location = New System.Drawing.Point(425, 187)
        Me.btnCancelarSeguimiento.Name = "btnCancelarSeguimiento"
        Me.btnCancelarSeguimiento.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarSeguimiento.TabIndex = 38
        Me.btnCancelarSeguimiento.Text = "Cancelar"
        Me.btnCancelarSeguimiento.UseSelectable = True
        '
        'btnGuardarSeguimiento
        '
        Me.btnGuardarSeguimiento.Location = New System.Drawing.Point(322, 187)
        Me.btnGuardarSeguimiento.Name = "btnGuardarSeguimiento"
        Me.btnGuardarSeguimiento.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarSeguimiento.TabIndex = 37
        Me.btnGuardarSeguimiento.Text = "Guardar"
        Me.btnGuardarSeguimiento.UseSelectable = True
        '
        'lblComentarioSeguimiento
        '
        Me.lblComentarioSeguimiento.AutoSize = True
        Me.lblComentarioSeguimiento.Location = New System.Drawing.Point(22, 102)
        Me.lblComentarioSeguimiento.Name = "lblComentarioSeguimiento"
        Me.lblComentarioSeguimiento.Size = New System.Drawing.Size(82, 19)
        Me.lblComentarioSeguimiento.TabIndex = 35
        Me.lblComentarioSeguimiento.Text = "Comentario:"
        '
        'txtFechaSeguimiento
        '
        Me.txtFechaSeguimiento.CustomFormat = ""
        Me.txtFechaSeguimiento.Location = New System.Drawing.Point(155, 52)
        Me.txtFechaSeguimiento.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtFechaSeguimiento.Name = "txtFechaSeguimiento"
        Me.txtFechaSeguimiento.Size = New System.Drawing.Size(367, 29)
        Me.txtFechaSeguimiento.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtFechaSeguimiento.TabIndex = 34
        Me.txtFechaSeguimiento.Value = New Date(2015, 11, 1, 16, 55, 54, 0)
        '
        'lblFechaSeguimiento
        '
        Me.lblFechaSeguimiento.AutoSize = True
        Me.lblFechaSeguimiento.Location = New System.Drawing.Point(22, 54)
        Me.lblFechaSeguimiento.Name = "lblFechaSeguimiento"
        Me.lblFechaSeguimiento.Size = New System.Drawing.Size(46, 19)
        Me.lblFechaSeguimiento.TabIndex = 33
        Me.lblFechaSeguimiento.Text = "Fecha:"
        '
        'PnlListaSeguimientos
        '
        Me.PnlListaSeguimientos.Controls.Add(Me.btnCancelarListaSeguimiento)
        Me.PnlListaSeguimientos.Controls.Add(Me.lstSeguimientos)
        Me.PnlListaSeguimientos.Controls.Add(Me.lblListaSeguimientos)
        Me.PnlListaSeguimientos.HorizontalScrollbarBarColor = True
        Me.PnlListaSeguimientos.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlListaSeguimientos.HorizontalScrollbarSize = 10
        Me.PnlListaSeguimientos.Location = New System.Drawing.Point(2, 11)
        Me.PnlListaSeguimientos.Name = "PnlListaSeguimientos"
        Me.PnlListaSeguimientos.Size = New System.Drawing.Size(743, 454)
        Me.PnlListaSeguimientos.TabIndex = 43
        Me.PnlListaSeguimientos.VerticalScrollbarBarColor = True
        Me.PnlListaSeguimientos.VerticalScrollbarHighlightOnWheel = False
        Me.PnlListaSeguimientos.VerticalScrollbarSize = 10
        Me.PnlListaSeguimientos.Visible = False
        '
        'btnCancelarListaSeguimiento
        '
        Me.btnCancelarListaSeguimiento.Location = New System.Drawing.Point(617, 409)
        Me.btnCancelarListaSeguimiento.Name = "btnCancelarListaSeguimiento"
        Me.btnCancelarListaSeguimiento.Size = New System.Drawing.Size(121, 36)
        Me.btnCancelarListaSeguimiento.TabIndex = 13
        Me.btnCancelarListaSeguimiento.Text = "Atrás"
        Me.btnCancelarListaSeguimiento.UseSelectable = True
        '
        'lstSeguimientos
        '
        Me.lstSeguimientos.AllowUserToAddRows = False
        Me.lstSeguimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstSeguimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaIDSeguimiento, Me.ColumnaFechaSeguimiento, Me.ColumnaComentarioSeguimiento, Me.ColumnaEditarSeguimiento, Me.ColumnaEliminarSeguimiento})
        Me.lstSeguimientos.Location = New System.Drawing.Point(0, 34)
        Me.lstSeguimientos.Name = "lstSeguimientos"
        Me.lstSeguimientos.RowHeadersVisible = False
        Me.lstSeguimientos.Size = New System.Drawing.Size(739, 344)
        Me.lstSeguimientos.TabIndex = 12
        '
        'ColumnaIDSeguimiento
        '
        Me.ColumnaIDSeguimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaIDSeguimiento.HeaderText = "ID"
        Me.ColumnaIDSeguimiento.Name = "ColumnaIDSeguimiento"
        Me.ColumnaIDSeguimiento.ReadOnly = True
        Me.ColumnaIDSeguimiento.Visible = False
        '
        'ColumnaFechaSeguimiento
        '
        Me.ColumnaFechaSeguimiento.HeaderText = "Fecha"
        Me.ColumnaFechaSeguimiento.Name = "ColumnaFechaSeguimiento"
        Me.ColumnaFechaSeguimiento.ReadOnly = True
        Me.ColumnaFechaSeguimiento.Width = 160
        '
        'ColumnaComentarioSeguimiento
        '
        Me.ColumnaComentarioSeguimiento.HeaderText = "Comentario"
        Me.ColumnaComentarioSeguimiento.Name = "ColumnaComentarioSeguimiento"
        Me.ColumnaComentarioSeguimiento.ReadOnly = True
        Me.ColumnaComentarioSeguimiento.Width = 500
        '
        'ColumnaEditarSeguimiento
        '
        Me.ColumnaEditarSeguimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaEditarSeguimiento.HeaderText = ""
        Me.ColumnaEditarSeguimiento.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.ColumnaEditarSeguimiento.Name = "ColumnaEditarSeguimiento"
        Me.ColumnaEditarSeguimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditarSeguimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColumnaEliminarSeguimiento
        '
        Me.ColumnaEliminarSeguimiento.HeaderText = ""
        Me.ColumnaEliminarSeguimiento.Image = Global.PresentasionWindowsForms.My.Resources.Resources.delete81
        Me.ColumnaEliminarSeguimiento.Name = "ColumnaEliminarSeguimiento"
        Me.ColumnaEliminarSeguimiento.Width = 38
        '
        'lblListaSeguimientos
        '
        Me.lblListaSeguimientos.AutoSize = True
        Me.lblListaSeguimientos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaSeguimientos.Location = New System.Drawing.Point(3, 6)
        Me.lblListaSeguimientos.Name = "lblListaSeguimientos"
        Me.lblListaSeguimientos.Size = New System.Drawing.Size(150, 25)
        Me.lblListaSeguimientos.TabIndex = 11
        Me.lblListaSeguimientos.Text = "Lista seguimientos"
        '
        'pnlAsignarProspecto
        '
        Me.pnlAsignarProspecto.Controls.Add(Me.btnQuitarProspAsignado)
        Me.pnlAsignarProspecto.Controls.Add(Me.btnGuardarAsignarProsp)
        Me.pnlAsignarProspecto.Controls.Add(Me.btnCancelarAsignarProsp)
        Me.pnlAsignarProspecto.Controls.Add(Me.btnAsignarListaProsp)
        Me.pnlAsignarProspecto.Controls.Add(Me.ltbProspAsignados)
        Me.pnlAsignarProspecto.Controls.Add(Me.lblProspAsignados)
        Me.pnlAsignarProspecto.Controls.Add(Me.ltbProspectosSlt)
        Me.pnlAsignarProspecto.Controls.Add(Me.ltbVendedoresSlt)
        Me.pnlAsignarProspecto.Controls.Add(Me.lblProspectosSlt)
        Me.pnlAsignarProspecto.Controls.Add(Me.lblVendedoresSlt)
        Me.pnlAsignarProspecto.Controls.Add(Me.lblAsignarProspecto)
        Me.pnlAsignarProspecto.HorizontalScrollbarBarColor = True
        Me.pnlAsignarProspecto.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlAsignarProspecto.HorizontalScrollbarSize = 10
        Me.pnlAsignarProspecto.Location = New System.Drawing.Point(4, 8)
        Me.pnlAsignarProspecto.Name = "pnlAsignarProspecto"
        Me.pnlAsignarProspecto.Size = New System.Drawing.Size(743, 464)
        Me.pnlAsignarProspecto.TabIndex = 45
        Me.pnlAsignarProspecto.VerticalScrollbarBarColor = True
        Me.pnlAsignarProspecto.VerticalScrollbarHighlightOnWheel = False
        Me.pnlAsignarProspecto.VerticalScrollbarSize = 10
        Me.pnlAsignarProspecto.Visible = False
        '
        'btnQuitarProspAsignado
        '
        Me.btnQuitarProspAsignado.Location = New System.Drawing.Point(488, 228)
        Me.btnQuitarProspAsignado.Name = "btnQuitarProspAsignado"
        Me.btnQuitarProspAsignado.Size = New System.Drawing.Size(35, 23)
        Me.btnQuitarProspAsignado.TabIndex = 26
        Me.btnQuitarProspAsignado.Text = "<="
        Me.btnQuitarProspAsignado.UseSelectable = True
        '
        'btnGuardarAsignarProsp
        '
        Me.btnGuardarAsignarProsp.Location = New System.Drawing.Point(318, 439)
        Me.btnGuardarAsignarProsp.Name = "btnGuardarAsignarProsp"
        Me.btnGuardarAsignarProsp.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarAsignarProsp.TabIndex = 25
        Me.btnGuardarAsignarProsp.Text = "Guardar"
        Me.btnGuardarAsignarProsp.UseSelectable = True
        '
        'btnCancelarAsignarProsp
        '
        Me.btnCancelarAsignarProsp.Location = New System.Drawing.Point(421, 439)
        Me.btnCancelarAsignarProsp.Name = "btnCancelarAsignarProsp"
        Me.btnCancelarAsignarProsp.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarAsignarProsp.TabIndex = 24
        Me.btnCancelarAsignarProsp.Text = "Cancelar"
        Me.btnCancelarAsignarProsp.UseSelectable = True
        '
        'btnAsignarListaProsp
        '
        Me.btnAsignarListaProsp.Location = New System.Drawing.Point(489, 190)
        Me.btnAsignarListaProsp.Name = "btnAsignarListaProsp"
        Me.btnAsignarListaProsp.Size = New System.Drawing.Size(35, 23)
        Me.btnAsignarListaProsp.TabIndex = 23
        Me.btnAsignarListaProsp.Text = "=>"
        Me.btnAsignarListaProsp.UseSelectable = True
        '
        'ltbProspAsignados
        '
        Me.ltbProspAsignados.FormattingEnabled = True
        Me.ltbProspAsignados.Location = New System.Drawing.Point(540, 91)
        Me.ltbProspAsignados.Name = "ltbProspAsignados"
        Me.ltbProspAsignados.Size = New System.Drawing.Size(184, 277)
        Me.ltbProspAsignados.TabIndex = 20
        '
        'lblProspAsignados
        '
        Me.lblProspAsignados.AutoSize = True
        Me.lblProspAsignados.Location = New System.Drawing.Point(540, 64)
        Me.lblProspAsignados.Name = "lblProspAsignados"
        Me.lblProspAsignados.Size = New System.Drawing.Size(135, 19)
        Me.lblProspAsignados.TabIndex = 19
        Me.lblProspAsignados.Text = "Prospectos asignados"
        '
        'ltbProspectosSlt
        '
        Me.ltbProspectosSlt.FormattingEnabled = True
        Me.ltbProspectosSlt.Location = New System.Drawing.Point(288, 91)
        Me.ltbProspectosSlt.Name = "ltbProspectosSlt"
        Me.ltbProspectosSlt.Size = New System.Drawing.Size(184, 277)
        Me.ltbProspectosSlt.TabIndex = 18
        '
        'ltbVendedoresSlt
        '
        Me.ltbVendedoresSlt.FormattingEnabled = True
        Me.ltbVendedoresSlt.Location = New System.Drawing.Point(23, 91)
        Me.ltbVendedoresSlt.Name = "ltbVendedoresSlt"
        Me.ltbVendedoresSlt.Size = New System.Drawing.Size(183, 277)
        Me.ltbVendedoresSlt.TabIndex = 17
        '
        'lblProspectosSlt
        '
        Me.lblProspectosSlt.AutoSize = True
        Me.lblProspectosSlt.Location = New System.Drawing.Point(288, 64)
        Me.lblProspectosSlt.Name = "lblProspectosSlt"
        Me.lblProspectosSlt.Size = New System.Drawing.Size(73, 19)
        Me.lblProspectosSlt.TabIndex = 16
        Me.lblProspectosSlt.Text = "Prospectos"
        '
        'lblVendedoresSlt
        '
        Me.lblVendedoresSlt.AutoSize = True
        Me.lblVendedoresSlt.Location = New System.Drawing.Point(22, 64)
        Me.lblVendedoresSlt.Name = "lblVendedoresSlt"
        Me.lblVendedoresSlt.Size = New System.Drawing.Size(78, 19)
        Me.lblVendedoresSlt.TabIndex = 15
        Me.lblVendedoresSlt.Text = "Vendedores"
        '
        'lblAsignarProspecto
        '
        Me.lblAsignarProspecto.AutoSize = True
        Me.lblAsignarProspecto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblAsignarProspecto.Location = New System.Drawing.Point(1, 10)
        Me.lblAsignarProspecto.Name = "lblAsignarProspecto"
        Me.lblAsignarProspecto.Size = New System.Drawing.Size(149, 25)
        Me.lblAsignarProspecto.TabIndex = 11
        Me.lblAsignarProspecto.Text = "Asignar prospecto"
        '
        'KPIHolder
        '
        Me.KPIHolder.Controls.Add(Me.panSeleccionarTipoKPI)
        Me.KPIHolder.Controls.Add(Me.pnlCrearKpiProducto)
        Me.KPIHolder.Controls.Add(Me.pnlKpiProspectos)
        Me.KPIHolder.Controls.Add(Me.panKpiVentas)
        Me.KPIHolder.HorizontalScrollbarBarColor = True
        Me.KPIHolder.HorizontalScrollbarHighlightOnWheel = False
        Me.KPIHolder.HorizontalScrollbarSize = 10
        Me.KPIHolder.Location = New System.Drawing.Point(4, 44)
        Me.KPIHolder.Name = "KPIHolder"
        Me.KPIHolder.Size = New System.Drawing.Size(752, 472)
        Me.KPIHolder.TabIndex = 3
        Me.KPIHolder.Text = "KPI"
        Me.KPIHolder.UseVisualStyleBackColor = True
        Me.KPIHolder.VerticalScrollbarBarColor = True
        Me.KPIHolder.VerticalScrollbarHighlightOnWheel = False
        Me.KPIHolder.VerticalScrollbarSize = 10
        '
        'panSeleccionarTipoKPI
        '
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiProductos)
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiProspecto)
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiVentas)
        Me.panSeleccionarTipoKPI.HorizontalScrollbarBarColor = True
        Me.panSeleccionarTipoKPI.HorizontalScrollbarHighlightOnWheel = False
        Me.panSeleccionarTipoKPI.HorizontalScrollbarSize = 10
        Me.panSeleccionarTipoKPI.Location = New System.Drawing.Point(1, 15)
        Me.panSeleccionarTipoKPI.Name = "panSeleccionarTipoKPI"
        Me.panSeleccionarTipoKPI.Size = New System.Drawing.Size(752, 742)
        Me.panSeleccionarTipoKPI.TabIndex = 2
        Me.panSeleccionarTipoKPI.VerticalScrollbarBarColor = True
        Me.panSeleccionarTipoKPI.VerticalScrollbarHighlightOnWheel = False
        Me.panSeleccionarTipoKPI.VerticalScrollbarSize = 10
        '
        'TileKpiProductos
        '
        Me.TileKpiProductos.ActiveControl = Nothing
        Me.TileKpiProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiProductos.Location = New System.Drawing.Point(331, 27)
        Me.TileKpiProductos.Name = "TileKpiProductos"
        Me.TileKpiProductos.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiProductos.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiProductos.TabIndex = 6
        Me.TileKpiProductos.Text = "Productos"
        Me.TileKpiProductos.UseSelectable = True
        '
        'TileKpiProspecto
        '
        Me.TileKpiProspecto.ActiveControl = Nothing
        Me.TileKpiProspecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiProspecto.Location = New System.Drawing.Point(178, 27)
        Me.TileKpiProspecto.Name = "TileKpiProspecto"
        Me.TileKpiProspecto.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiProspecto.TabIndex = 5
        Me.TileKpiProspecto.Text = "Prospectos"
        Me.TileKpiProspecto.UseSelectable = True
        '
        'TileKpiVentas
        '
        Me.TileKpiVentas.ActiveControl = Nothing
        Me.TileKpiVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiVentas.Location = New System.Drawing.Point(24, 27)
        Me.TileKpiVentas.Name = "TileKpiVentas"
        Me.TileKpiVentas.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiVentas.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiVentas.TabIndex = 4
        Me.TileKpiVentas.Text = "Ventas"
        Me.TileKpiVentas.UseSelectable = True
        '
        'pnlCrearKpiProducto
        '
        Me.pnlCrearKpiProducto.Controls.Add(Me.TextBoxResultadoKpiProductos)
        Me.pnlCrearKpiProducto.Controls.Add(Me.btnCancelarKpiProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.btnCrearKpiProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.checkBoxTotalProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.lblCrearKpiProducto)
        Me.pnlCrearKpiProducto.HorizontalScrollbarBarColor = True
        Me.pnlCrearKpiProducto.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCrearKpiProducto.HorizontalScrollbarSize = 10
        Me.pnlCrearKpiProducto.Location = New System.Drawing.Point(3, 15)
        Me.pnlCrearKpiProducto.Name = "pnlCrearKpiProducto"
        Me.pnlCrearKpiProducto.Size = New System.Drawing.Size(752, 742)
        Me.pnlCrearKpiProducto.TabIndex = 25
        Me.pnlCrearKpiProducto.VerticalScrollbarBarColor = True
        Me.pnlCrearKpiProducto.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCrearKpiProducto.VerticalScrollbarSize = 10
        '
        'TextBoxResultadoKpiProductos
        '
        Me.TextBoxResultadoKpiProductos.Location = New System.Drawing.Point(15, 187)
        Me.TextBoxResultadoKpiProductos.Name = "TextBoxResultadoKpiProductos"
        Me.TextBoxResultadoKpiProductos.Size = New System.Drawing.Size(710, 254)
        Me.TextBoxResultadoKpiProductos.TabIndex = 25
        Me.TextBoxResultadoKpiProductos.Text = ""
        '
        'btnCancelarKpiProducto
        '
        Me.btnCancelarKpiProducto.Location = New System.Drawing.Point(248, 112)
        Me.btnCancelarKpiProducto.Name = "btnCancelarKpiProducto"
        Me.btnCancelarKpiProducto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiProducto.TabIndex = 24
        Me.btnCancelarKpiProducto.Text = "Cancelar"
        Me.btnCancelarKpiProducto.UseSelectable = True
        '
        'btnCrearKpiProducto
        '
        Me.btnCrearKpiProducto.Location = New System.Drawing.Point(123, 112)
        Me.btnCrearKpiProducto.Name = "btnCrearKpiProducto"
        Me.btnCrearKpiProducto.Size = New System.Drawing.Size(97, 23)
        Me.btnCrearKpiProducto.TabIndex = 23
        Me.btnCrearKpiProducto.Text = "Generar"
        Me.btnCrearKpiProducto.UseSelectable = True
        '
        'checkBoxTotalProducto
        '
        Me.checkBoxTotalProducto.AutoSize = True
        Me.checkBoxTotalProducto.Location = New System.Drawing.Point(15, 62)
        Me.checkBoxTotalProducto.Name = "checkBoxTotalProducto"
        Me.checkBoxTotalProducto.Size = New System.Drawing.Size(101, 15)
        Me.checkBoxTotalProducto.TabIndex = 12
        Me.checkBoxTotalProducto.Text = "Total Producto"
        Me.checkBoxTotalProducto.UseSelectable = True
        '
        'lblCrearKpiProducto
        '
        Me.lblCrearKpiProducto.AutoSize = True
        Me.lblCrearKpiProducto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearKpiProducto.Location = New System.Drawing.Point(4, 9)
        Me.lblCrearKpiProducto.Name = "lblCrearKpiProducto"
        Me.lblCrearKpiProducto.Size = New System.Drawing.Size(155, 25)
        Me.lblCrearKpiProducto.TabIndex = 11
        Me.lblCrearKpiProducto.Text = "Crear Kpi Producto"
        '
        'pnlKpiProspectos
        '
        Me.pnlKpiProspectos.Controls.Add(Me.TextBoxResultadosKpiProspectos)
        Me.pnlKpiProspectos.Controls.Add(Me.btnCancelarKpiProspecto)
        Me.pnlKpiProspectos.Controls.Add(Me.BtnGenerarKpiProspecto)
        Me.pnlKpiProspectos.Controls.Add(Me.checkboxTotalProspetosCliente)
        Me.pnlKpiProspectos.Controls.Add(Me.checkBoxTotalProspectos)
        Me.pnlKpiProspectos.Controls.Add(Me.lblCrearKpiProspecto)
        Me.pnlKpiProspectos.HorizontalScrollbarBarColor = True
        Me.pnlKpiProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlKpiProspectos.HorizontalScrollbarSize = 10
        Me.pnlKpiProspectos.Location = New System.Drawing.Point(1, 0)
        Me.pnlKpiProspectos.Name = "pnlKpiProspectos"
        Me.pnlKpiProspectos.Size = New System.Drawing.Size(752, 742)
        Me.pnlKpiProspectos.TabIndex = 25
        Me.pnlKpiProspectos.VerticalScrollbarBarColor = True
        Me.pnlKpiProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlKpiProspectos.VerticalScrollbarSize = 10
        '
        'TextBoxResultadosKpiProspectos
        '
        Me.TextBoxResultadosKpiProspectos.Location = New System.Drawing.Point(19, 164)
        Me.TextBoxResultadosKpiProspectos.Name = "TextBoxResultadosKpiProspectos"
        Me.TextBoxResultadosKpiProspectos.Size = New System.Drawing.Size(713, 259)
        Me.TextBoxResultadosKpiProspectos.TabIndex = 25
        Me.TextBoxResultadosKpiProspectos.Text = ""
        '
        'btnCancelarKpiProspecto
        '
        Me.btnCancelarKpiProspecto.Location = New System.Drawing.Point(267, 112)
        Me.btnCancelarKpiProspecto.Name = "btnCancelarKpiProspecto"
        Me.btnCancelarKpiProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiProspecto.TabIndex = 24
        Me.btnCancelarKpiProspecto.Text = "Cancelar"
        Me.btnCancelarKpiProspecto.UseSelectable = True
        '
        'BtnGenerarKpiProspecto
        '
        Me.BtnGenerarKpiProspecto.Location = New System.Drawing.Point(151, 112)
        Me.BtnGenerarKpiProspecto.Name = "BtnGenerarKpiProspecto"
        Me.BtnGenerarKpiProspecto.Size = New System.Drawing.Size(97, 23)
        Me.BtnGenerarKpiProspecto.TabIndex = 23
        Me.BtnGenerarKpiProspecto.Text = "Generar"
        Me.BtnGenerarKpiProspecto.UseSelectable = True
        '
        'checkboxTotalProspetosCliente
        '
        Me.checkboxTotalProspetosCliente.AutoSize = True
        Me.checkboxTotalProspetosCliente.Location = New System.Drawing.Point(152, 60)
        Me.checkboxTotalProspetosCliente.Name = "checkboxTotalProspetosCliente"
        Me.checkboxTotalProspetosCliente.Size = New System.Drawing.Size(166, 15)
        Me.checkboxTotalProspetosCliente.TabIndex = 13
        Me.checkboxTotalProspetosCliente.Text = "Total de Prospectos Cliente"
        Me.checkboxTotalProspetosCliente.UseSelectable = True
        '
        'checkBoxTotalProspectos
        '
        Me.checkBoxTotalProspectos.AutoSize = True
        Me.checkBoxTotalProspectos.Location = New System.Drawing.Point(19, 60)
        Me.checkBoxTotalProspectos.Name = "checkBoxTotalProspectos"
        Me.checkBoxTotalProspectos.Size = New System.Drawing.Size(126, 15)
        Me.checkBoxTotalProspectos.TabIndex = 12
        Me.checkBoxTotalProspectos.Text = "Total de Prospectos"
        Me.checkBoxTotalProspectos.UseSelectable = True
        '
        'lblCrearKpiProspecto
        '
        Me.lblCrearKpiProspecto.AutoSize = True
        Me.lblCrearKpiProspecto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearKpiProspecto.Location = New System.Drawing.Point(4, 9)
        Me.lblCrearKpiProspecto.Name = "lblCrearKpiProspecto"
        Me.lblCrearKpiProspecto.Size = New System.Drawing.Size(161, 25)
        Me.lblCrearKpiProspecto.TabIndex = 11
        Me.lblCrearKpiProspecto.Text = "Crear Kpi Prospecto"
        '
        'panKpiVentas
        '
        Me.panKpiVentas.Controls.Add(Me.TextBoxResultadosVentas)
        Me.panKpiVentas.Controls.Add(Me.btnCancelarKpiVenta)
        Me.panKpiVentas.Controls.Add(Me.btnCrearKpiVenta)
        Me.panKpiVentas.Controls.Add(Me.checkBoxMontoTotalVentas)
        Me.panKpiVentas.Controls.Add(Me.checkBoxTotalVentas)
        Me.panKpiVentas.Controls.Add(Me.crearKPIVentas)
        Me.panKpiVentas.HorizontalScrollbarBarColor = True
        Me.panKpiVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.panKpiVentas.HorizontalScrollbarSize = 10
        Me.panKpiVentas.Location = New System.Drawing.Point(0, 0)
        Me.panKpiVentas.Name = "panKpiVentas"
        Me.panKpiVentas.Size = New System.Drawing.Size(752, 742)
        Me.panKpiVentas.TabIndex = 3
        Me.panKpiVentas.VerticalScrollbarBarColor = True
        Me.panKpiVentas.VerticalScrollbarHighlightOnWheel = False
        Me.panKpiVentas.VerticalScrollbarSize = 10
        '
        'TextBoxResultadosVentas
        '
        Me.TextBoxResultadosVentas.Location = New System.Drawing.Point(21, 208)
        Me.TextBoxResultadosVentas.Name = "TextBoxResultadosVentas"
        Me.TextBoxResultadosVentas.Size = New System.Drawing.Size(713, 259)
        Me.TextBoxResultadosVentas.TabIndex = 25
        Me.TextBoxResultadosVentas.Text = ""
        '
        'btnCancelarKpiVenta
        '
        Me.btnCancelarKpiVenta.Location = New System.Drawing.Point(303, 123)
        Me.btnCancelarKpiVenta.Name = "btnCancelarKpiVenta"
        Me.btnCancelarKpiVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiVenta.TabIndex = 24
        Me.btnCancelarKpiVenta.Text = "Cancelar"
        Me.btnCancelarKpiVenta.UseSelectable = True
        '
        'btnCrearKpiVenta
        '
        Me.btnCrearKpiVenta.Location = New System.Drawing.Point(200, 123)
        Me.btnCrearKpiVenta.Name = "btnCrearKpiVenta"
        Me.btnCrearKpiVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnCrearKpiVenta.TabIndex = 23
        Me.btnCrearKpiVenta.Text = "Generar"
        Me.btnCrearKpiVenta.UseSelectable = True
        '
        'checkBoxMontoTotalVentas
        '
        Me.checkBoxMontoTotalVentas.AutoSize = True
        Me.checkBoxMontoTotalVentas.Location = New System.Drawing.Point(115, 69)
        Me.checkBoxMontoTotalVentas.Name = "checkBoxMontoTotalVentas"
        Me.checkBoxMontoTotalVentas.Size = New System.Drawing.Size(141, 15)
        Me.checkBoxMontoTotalVentas.TabIndex = 14
        Me.checkBoxMontoTotalVentas.Text = "Monto Total de Ventas"
        Me.checkBoxMontoTotalVentas.UseSelectable = True
        '
        'checkBoxTotalVentas
        '
        Me.checkBoxTotalVentas.AutoSize = True
        Me.checkBoxTotalVentas.Location = New System.Drawing.Point(21, 69)
        Me.checkBoxTotalVentas.Name = "checkBoxTotalVentas"
        Me.checkBoxTotalVentas.Size = New System.Drawing.Size(86, 15)
        Me.checkBoxTotalVentas.TabIndex = 12
        Me.checkBoxTotalVentas.Text = "Total Ventas"
        Me.checkBoxTotalVentas.UseSelectable = True
        '
        'crearKPIVentas
        '
        Me.crearKPIVentas.AutoSize = True
        Me.crearKPIVentas.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.crearKPIVentas.Location = New System.Drawing.Point(4, 9)
        Me.crearKPIVentas.Name = "crearKPIVentas"
        Me.crearKPIVentas.Size = New System.Drawing.Size(135, 25)
        Me.crearKPIVentas.TabIndex = 11
        Me.crearKPIVentas.Text = "Crear KPI Ventas"
        '
        'TabConfiguracion
        '
        Me.TabConfiguracion.Controls.Add(Me.pnlUpdateUserInfo)
        Me.TabConfiguracion.Controls.Add(Me.tileChangeInformation)
        Me.TabConfiguracion.HorizontalScrollbarBarColor = True
        Me.TabConfiguracion.HorizontalScrollbarHighlightOnWheel = False
        Me.TabConfiguracion.HorizontalScrollbarSize = 10
        Me.TabConfiguracion.Location = New System.Drawing.Point(4, 44)
        Me.TabConfiguracion.Name = "TabConfiguracion"
        Me.TabConfiguracion.Size = New System.Drawing.Size(752, 472)
        Me.TabConfiguracion.Style = MetroFramework.MetroColorStyle.Silver
        Me.TabConfiguracion.TabIndex = 8
        Me.TabConfiguracion.Text = "Configuración"
        Me.TabConfiguracion.VerticalScrollbarBarColor = True
        Me.TabConfiguracion.VerticalScrollbarHighlightOnWheel = False
        Me.TabConfiguracion.VerticalScrollbarSize = 10
        '
        'pnlUpdateUserInfo
        '
        Me.pnlUpdateUserInfo.Controls.Add(Me.tgChangePassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtPasswordUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblCheckPasswordUpdate)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtNewPassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblNewpassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.cboDateUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblDateUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtEmailUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblEmailUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtLastNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtPhoneUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtIdUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.btnCancelUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.btnSaveUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblPasswordUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblPhoneUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblLastNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblIdUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblChangePasswordTittle)
        Me.pnlUpdateUserInfo.HorizontalScrollbarBarColor = True
        Me.pnlUpdateUserInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlUpdateUserInfo.HorizontalScrollbarSize = 10
        Me.pnlUpdateUserInfo.Location = New System.Drawing.Point(3, 5)
        Me.pnlUpdateUserInfo.Name = "pnlUpdateUserInfo"
        Me.pnlUpdateUserInfo.Size = New System.Drawing.Size(746, 462)
        Me.pnlUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlUpdateUserInfo.TabIndex = 7
        Me.pnlUpdateUserInfo.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlUpdateUserInfo.VerticalScrollbarBarColor = True
        Me.pnlUpdateUserInfo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlUpdateUserInfo.VerticalScrollbarSize = 10
        Me.pnlUpdateUserInfo.Visible = False
        '
        'tgChangePassUpdateUserInfo
        '
        Me.tgChangePassUpdateUserInfo.AutoSize = True
        Me.tgChangePassUpdateUserInfo.Location = New System.Drawing.Point(181, 250)
        Me.tgChangePassUpdateUserInfo.Name = "tgChangePassUpdateUserInfo"
        Me.tgChangePassUpdateUserInfo.Size = New System.Drawing.Size(80, 17)
        Me.tgChangePassUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgChangePassUpdateUserInfo.TabIndex = 50
        Me.tgChangePassUpdateUserInfo.Text = "Off"
        Me.tgChangePassUpdateUserInfo.UseSelectable = True
        '
        'txtPasswordUpdateUserInfo
        '
        '
        '
        '
        Me.txtPasswordUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtPasswordUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPasswordUpdateUserInfo.CustomButton.Name = ""
        Me.txtPasswordUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPasswordUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPasswordUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtPasswordUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtPasswordUpdateUserInfo.CustomButton.Visible = False
        Me.txtPasswordUpdateUserInfo.Lines = New String(-1) {}
        Me.txtPasswordUpdateUserInfo.Location = New System.Drawing.Point(181, 308)
        Me.txtPasswordUpdateUserInfo.MaxLength = 50
        Me.txtPasswordUpdateUserInfo.Name = "txtPasswordUpdateUserInfo"
        Me.txtPasswordUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordUpdateUserInfo.SelectedText = ""
        Me.txtPasswordUpdateUserInfo.SelectionLength = 0
        Me.txtPasswordUpdateUserInfo.SelectionStart = 0
        Me.txtPasswordUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtPasswordUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPasswordUpdateUserInfo.TabIndex = 49
        Me.txtPasswordUpdateUserInfo.UseSelectable = True
        Me.txtPasswordUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPasswordUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCheckPasswordUpdate
        '
        Me.lblCheckPasswordUpdate.AutoSize = True
        Me.lblCheckPasswordUpdate.Location = New System.Drawing.Point(25, 312)
        Me.lblCheckPasswordUpdate.Name = "lblCheckPasswordUpdate"
        Me.lblCheckPasswordUpdate.Size = New System.Drawing.Size(136, 19)
        Me.lblCheckPasswordUpdate.TabIndex = 48
        Me.lblCheckPasswordUpdate.Text = "Confirmar contraseña"
        '
        'txtNewPassUpdateUserInfo
        '
        '
        '
        '
        Me.txtNewPassUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtNewPassUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNewPassUpdateUserInfo.CustomButton.Name = ""
        Me.txtNewPassUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNewPassUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPassUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtNewPassUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPassUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtNewPassUpdateUserInfo.CustomButton.Visible = False
        Me.txtNewPassUpdateUserInfo.Enabled = False
        Me.txtNewPassUpdateUserInfo.Lines = New String(-1) {}
        Me.txtNewPassUpdateUserInfo.Location = New System.Drawing.Point(181, 277)
        Me.txtNewPassUpdateUserInfo.MaxLength = 50
        Me.txtNewPassUpdateUserInfo.Name = "txtNewPassUpdateUserInfo"
        Me.txtNewPassUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPassUpdateUserInfo.SelectedText = ""
        Me.txtNewPassUpdateUserInfo.SelectionLength = 0
        Me.txtNewPassUpdateUserInfo.SelectionStart = 0
        Me.txtNewPassUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtNewPassUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNewPassUpdateUserInfo.TabIndex = 47
        Me.txtNewPassUpdateUserInfo.UseSelectable = True
        Me.txtNewPassUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPassUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNewpassUpdateUserInfo
        '
        Me.lblNewpassUpdateUserInfo.AutoSize = True
        Me.lblNewpassUpdateUserInfo.Enabled = False
        Me.lblNewpassUpdateUserInfo.Location = New System.Drawing.Point(25, 281)
        Me.lblNewpassUpdateUserInfo.Name = "lblNewpassUpdateUserInfo"
        Me.lblNewpassUpdateUserInfo.Size = New System.Drawing.Size(116, 19)
        Me.lblNewpassUpdateUserInfo.TabIndex = 46
        Me.lblNewpassUpdateUserInfo.Text = "Nueva Contraseña"
        '
        'cboDateUpdateUserInfo
        '
        Me.cboDateUpdateUserInfo.Location = New System.Drawing.Point(181, 175)
        Me.cboDateUpdateUserInfo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cboDateUpdateUserInfo.Name = "cboDateUpdateUserInfo"
        Me.cboDateUpdateUserInfo.Size = New System.Drawing.Size(366, 29)
        Me.cboDateUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboDateUpdateUserInfo.TabIndex = 45
        '
        'lblDateUpdateUserInfo
        '
        Me.lblDateUpdateUserInfo.AutoSize = True
        Me.lblDateUpdateUserInfo.Location = New System.Drawing.Point(24, 185)
        Me.lblDateUpdateUserInfo.Name = "lblDateUpdateUserInfo"
        Me.lblDateUpdateUserInfo.Size = New System.Drawing.Size(111, 19)
        Me.lblDateUpdateUserInfo.TabIndex = 44
        Me.lblDateUpdateUserInfo.Text = "Fecha nacimiento"
        '
        'txtEmailUpdateUserInfo
        '
        '
        '
        '
        Me.txtEmailUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtEmailUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailUpdateUserInfo.CustomButton.Name = ""
        Me.txtEmailUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtEmailUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtEmailUpdateUserInfo.CustomButton.Visible = False
        Me.txtEmailUpdateUserInfo.Lines = New String(-1) {}
        Me.txtEmailUpdateUserInfo.Location = New System.Drawing.Point(181, 144)
        Me.txtEmailUpdateUserInfo.MaxLength = 50
        Me.txtEmailUpdateUserInfo.Name = "txtEmailUpdateUserInfo"
        Me.txtEmailUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailUpdateUserInfo.SelectedText = ""
        Me.txtEmailUpdateUserInfo.SelectionLength = 0
        Me.txtEmailUpdateUserInfo.SelectionStart = 0
        Me.txtEmailUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailUpdateUserInfo.TabIndex = 43
        Me.txtEmailUpdateUserInfo.UseSelectable = True
        Me.txtEmailUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmailUpdateUserInfo
        '
        Me.lblEmailUpdateUserInfo.AutoSize = True
        Me.lblEmailUpdateUserInfo.Location = New System.Drawing.Point(24, 148)
        Me.lblEmailUpdateUserInfo.Name = "lblEmailUpdateUserInfo"
        Me.lblEmailUpdateUserInfo.Size = New System.Drawing.Size(51, 19)
        Me.lblEmailUpdateUserInfo.TabIndex = 42
        Me.lblEmailUpdateUserInfo.Text = "Correo"
        '
        'txtLastNameUpdateUserInfo
        '
        '
        '
        '
        Me.txtLastNameUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtLastNameUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtLastNameUpdateUserInfo.CustomButton.Name = ""
        Me.txtLastNameUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastNameUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastNameUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtLastNameUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastNameUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtLastNameUpdateUserInfo.CustomButton.Visible = False
        Me.txtLastNameUpdateUserInfo.Lines = New String(-1) {}
        Me.txtLastNameUpdateUserInfo.Location = New System.Drawing.Point(181, 113)
        Me.txtLastNameUpdateUserInfo.MaxLength = 50
        Me.txtLastNameUpdateUserInfo.Name = "txtLastNameUpdateUserInfo"
        Me.txtLastNameUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastNameUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastNameUpdateUserInfo.SelectedText = ""
        Me.txtLastNameUpdateUserInfo.SelectionLength = 0
        Me.txtLastNameUpdateUserInfo.SelectionStart = 0
        Me.txtLastNameUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtLastNameUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtLastNameUpdateUserInfo.TabIndex = 41
        Me.txtLastNameUpdateUserInfo.UseSelectable = True
        Me.txtLastNameUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastNameUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhoneUpdateUserInfo
        '
        '
        '
        '
        Me.txtPhoneUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtPhoneUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPhoneUpdateUserInfo.CustomButton.Name = ""
        Me.txtPhoneUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtPhoneUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtPhoneUpdateUserInfo.CustomButton.Visible = False
        Me.txtPhoneUpdateUserInfo.Lines = New String(-1) {}
        Me.txtPhoneUpdateUserInfo.Location = New System.Drawing.Point(181, 215)
        Me.txtPhoneUpdateUserInfo.MaxLength = 30
        Me.txtPhoneUpdateUserInfo.Name = "txtPhoneUpdateUserInfo"
        Me.txtPhoneUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneUpdateUserInfo.SelectedText = ""
        Me.txtPhoneUpdateUserInfo.SelectionLength = 0
        Me.txtPhoneUpdateUserInfo.SelectionStart = 0
        Me.txtPhoneUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtPhoneUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPhoneUpdateUserInfo.TabIndex = 33
        Me.txtPhoneUpdateUserInfo.UseSelectable = True
        Me.txtPhoneUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNameUpdateUserInfo
        '
        '
        '
        '
        Me.txtNameUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtNameUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNameUpdateUserInfo.CustomButton.Name = ""
        Me.txtNameUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNameUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNameUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtNameUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNameUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtNameUpdateUserInfo.CustomButton.Visible = False
        Me.txtNameUpdateUserInfo.Lines = New String(-1) {}
        Me.txtNameUpdateUserInfo.Location = New System.Drawing.Point(181, 82)
        Me.txtNameUpdateUserInfo.MaxLength = 50
        Me.txtNameUpdateUserInfo.Name = "txtNameUpdateUserInfo"
        Me.txtNameUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNameUpdateUserInfo.SelectedText = ""
        Me.txtNameUpdateUserInfo.SelectionLength = 0
        Me.txtNameUpdateUserInfo.SelectionStart = 0
        Me.txtNameUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtNameUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNameUpdateUserInfo.TabIndex = 25
        Me.txtNameUpdateUserInfo.UseSelectable = True
        Me.txtNameUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNameUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdUpdateUserInfo
        '
        '
        '
        '
        Me.txtIdUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtIdUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtIdUpdateUserInfo.CustomButton.Name = ""
        Me.txtIdUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIdUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtIdUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtIdUpdateUserInfo.CustomButton.Visible = False
        Me.txtIdUpdateUserInfo.Lines = New String(-1) {}
        Me.txtIdUpdateUserInfo.Location = New System.Drawing.Point(181, 51)
        Me.txtIdUpdateUserInfo.MaxLength = 50
        Me.txtIdUpdateUserInfo.Name = "txtIdUpdateUserInfo"
        Me.txtIdUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdUpdateUserInfo.SelectedText = ""
        Me.txtIdUpdateUserInfo.SelectionLength = 0
        Me.txtIdUpdateUserInfo.SelectionStart = 0
        Me.txtIdUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtIdUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtIdUpdateUserInfo.TabIndex = 24
        Me.txtIdUpdateUserInfo.UseSelectable = True
        Me.txtIdUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelUpdateUserInfo
        '
        Me.btnCancelUpdateUserInfo.Location = New System.Drawing.Point(450, 436)
        Me.btnCancelUpdateUserInfo.Name = "btnCancelUpdateUserInfo"
        Me.btnCancelUpdateUserInfo.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelUpdateUserInfo.TabIndex = 23
        Me.btnCancelUpdateUserInfo.Text = "Cancelar"
        Me.btnCancelUpdateUserInfo.UseSelectable = True
        '
        'btnSaveUpdateUserInfo
        '
        Me.btnSaveUpdateUserInfo.Location = New System.Drawing.Point(347, 436)
        Me.btnSaveUpdateUserInfo.Name = "btnSaveUpdateUserInfo"
        Me.btnSaveUpdateUserInfo.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveUpdateUserInfo.TabIndex = 22
        Me.btnSaveUpdateUserInfo.Text = "Guardar"
        Me.btnSaveUpdateUserInfo.UseSelectable = True
        '
        'lblPasswordUpdateUserInfo
        '
        Me.lblPasswordUpdateUserInfo.AutoSize = True
        Me.lblPasswordUpdateUserInfo.Location = New System.Drawing.Point(24, 250)
        Me.lblPasswordUpdateUserInfo.Name = "lblPasswordUpdateUserInfo"
        Me.lblPasswordUpdateUserInfo.Size = New System.Drawing.Size(127, 19)
        Me.lblPasswordUpdateUserInfo.TabIndex = 19
        Me.lblPasswordUpdateUserInfo.Text = "Cambiar contraseña"
        '
        'lblPhoneUpdateUserInfo
        '
        Me.lblPhoneUpdateUserInfo.AutoSize = True
        Me.lblPhoneUpdateUserInfo.Location = New System.Drawing.Point(24, 215)
        Me.lblPhoneUpdateUserInfo.Name = "lblPhoneUpdateUserInfo"
        Me.lblPhoneUpdateUserInfo.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoneUpdateUserInfo.TabIndex = 15
        Me.lblPhoneUpdateUserInfo.Text = "Teléfono"
        '
        'lblNameUpdateUserInfo
        '
        Me.lblNameUpdateUserInfo.AutoSize = True
        Me.lblNameUpdateUserInfo.Location = New System.Drawing.Point(24, 82)
        Me.lblNameUpdateUserInfo.Name = "lblNameUpdateUserInfo"
        Me.lblNameUpdateUserInfo.Size = New System.Drawing.Size(59, 19)
        Me.lblNameUpdateUserInfo.TabIndex = 14
        Me.lblNameUpdateUserInfo.Text = "Nombre"
        '
        'lblLastNameUpdateUserInfo
        '
        Me.lblLastNameUpdateUserInfo.AutoSize = True
        Me.lblLastNameUpdateUserInfo.Location = New System.Drawing.Point(25, 114)
        Me.lblLastNameUpdateUserInfo.Name = "lblLastNameUpdateUserInfo"
        Me.lblLastNameUpdateUserInfo.Size = New System.Drawing.Size(58, 19)
        Me.lblLastNameUpdateUserInfo.TabIndex = 13
        Me.lblLastNameUpdateUserInfo.Text = "Apellido"
        '
        'lblIdUpdateUserInfo
        '
        Me.lblIdUpdateUserInfo.AutoSize = True
        Me.lblIdUpdateUserInfo.Location = New System.Drawing.Point(24, 51)
        Me.lblIdUpdateUserInfo.Name = "lblIdUpdateUserInfo"
        Me.lblIdUpdateUserInfo.Size = New System.Drawing.Size(50, 19)
        Me.lblIdUpdateUserInfo.TabIndex = 11
        Me.lblIdUpdateUserInfo.Text = "Cédula"
        '
        'lblChangePasswordTittle
        '
        Me.lblChangePasswordTittle.AutoSize = True
        Me.lblChangePasswordTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblChangePasswordTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblChangePasswordTittle.Name = "lblChangePasswordTittle"
        Me.lblChangePasswordTittle.Size = New System.Drawing.Size(214, 25)
        Me.lblChangePasswordTittle.TabIndex = 10
        Me.lblChangePasswordTittle.Text = "Modificar datos de usuario"
        '
        'tileChangeInformation
        '
        Me.tileChangeInformation.ActiveControl = Nothing
        Me.tileChangeInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tileChangeInformation.Location = New System.Drawing.Point(24, 27)
        Me.tileChangeInformation.Name = "tileChangeInformation"
        Me.tileChangeInformation.Size = New System.Drawing.Size(124, 119)
        Me.tileChangeInformation.Style = MetroFramework.MetroColorStyle.Purple
        Me.tileChangeInformation.TabIndex = 4
        Me.tileChangeInformation.Text = "Cambiar datos"
        Me.tileChangeInformation.UseSelectable = True
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Controls.Add(Me.pnlCreateRol)
        Me.TabUsuarios.Controls.Add(Me.pnlCreateUser)
        Me.TabUsuarios.Controls.Add(Me.pnListUsers)
        Me.TabUsuarios.Controls.Add(Me.pnlListRols)
        Me.TabUsuarios.HorizontalScrollbarBarColor = True
        Me.TabUsuarios.HorizontalScrollbarHighlightOnWheel = False
        Me.TabUsuarios.HorizontalScrollbarSize = 10
        Me.TabUsuarios.Location = New System.Drawing.Point(4, 44)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.Size = New System.Drawing.Size(752, 472)
        Me.TabUsuarios.TabIndex = 2
        Me.TabUsuarios.Text = "Usuarios"
        Me.TabUsuarios.VerticalScrollbarBarColor = True
        Me.TabUsuarios.VerticalScrollbarHighlightOnWheel = False
        Me.TabUsuarios.VerticalScrollbarSize = 10
        '
        'pnlCreateRol
        '
        Me.pnlCreateRol.Controls.Add(Me.gboPermissionsRol)
        Me.pnlCreateRol.Controls.Add(Me.lblPermissionsRol)
        Me.pnlCreateRol.Controls.Add(Me.tgEnabledRol)
        Me.pnlCreateRol.Controls.Add(Me.txtRolName)
        Me.pnlCreateRol.Controls.Add(Me.btnCancelRol)
        Me.pnlCreateRol.Controls.Add(Me.btnSaveRol)
        Me.pnlCreateRol.Controls.Add(Me.btnEnabledRol)
        Me.pnlCreateRol.Controls.Add(Me.lblNameRol)
        Me.pnlCreateRol.Controls.Add(Me.lblCreateRolTittle)
        Me.pnlCreateRol.HorizontalScrollbarBarColor = True
        Me.pnlCreateRol.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCreateRol.HorizontalScrollbarSize = 10
        Me.pnlCreateRol.Location = New System.Drawing.Point(0, 3)
        Me.pnlCreateRol.Name = "pnlCreateRol"
        Me.pnlCreateRol.Size = New System.Drawing.Size(753, 461)
        Me.pnlCreateRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlCreateRol.TabIndex = 51
        Me.pnlCreateRol.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlCreateRol.VerticalScrollbarBarColor = True
        Me.pnlCreateRol.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCreateRol.VerticalScrollbarSize = 10
        Me.pnlCreateRol.Visible = False
        '
        'gboPermissionsRol
        '
        Me.gboPermissionsRol.BackColor = System.Drawing.Color.White
        Me.gboPermissionsRol.Controls.Add(Me.grpPermisosWeb)
        Me.gboPermissionsRol.Controls.Add(Me.tgUsersRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblUsersRol)
        Me.gboPermissionsRol.Controls.Add(Me.gboPorductsSectionRol)
        Me.gboPermissionsRol.Controls.Add(Me.tgConfigurationRol)
        Me.gboPermissionsRol.Controls.Add(Me.tgKpiRol)
        Me.gboPermissionsRol.Controls.Add(Me.tgEventsRol)
        Me.gboPermissionsRol.Controls.Add(Me.tgProspectusRol)
        Me.gboPermissionsRol.Controls.Add(Me.tgSalesRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblConfigurationRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblKpiRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblEventsRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblProspectusRol)
        Me.gboPermissionsRol.Controls.Add(Me.lblSalesRol)
        Me.gboPermissionsRol.Location = New System.Drawing.Point(90, 133)
        Me.gboPermissionsRol.Name = "gboPermissionsRol"
        Me.gboPermissionsRol.Size = New System.Drawing.Size(605, 267)
        Me.gboPermissionsRol.TabIndex = 27
        Me.gboPermissionsRol.TabStop = False
        '
        'grpPermisosWeb
        '
        Me.grpPermisosWeb.BackColor = System.Drawing.Color.White
        Me.grpPermisosWeb.Controls.Add(Me.tgPreguntasRol)
        Me.grpPermisosWeb.Controls.Add(Me.lblPregunntas)
        Me.grpPermisosWeb.Controls.Add(Me.lblPermisosWeb)
        Me.grpPermisosWeb.Controls.Add(Me.tgEvaluacionesRol)
        Me.grpPermisosWeb.Controls.Add(Me.lblEvaluations)
        Me.grpPermisosWeb.Controls.Add(Me.lblReportsRol)
        Me.grpPermisosWeb.Controls.Add(Me.tgReportsRol)
        Me.grpPermisosWeb.Location = New System.Drawing.Point(215, 95)
        Me.grpPermisosWeb.Name = "grpPermisosWeb"
        Me.grpPermisosWeb.Size = New System.Drawing.Size(377, 156)
        Me.grpPermisosWeb.TabIndex = 51
        Me.grpPermisosWeb.TabStop = False
        '
        'tgPreguntasRol
        '
        Me.tgPreguntasRol.AutoSize = True
        Me.tgPreguntasRol.Location = New System.Drawing.Point(194, 110)
        Me.tgPreguntasRol.Name = "tgPreguntasRol"
        Me.tgPreguntasRol.Size = New System.Drawing.Size(80, 17)
        Me.tgPreguntasRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgPreguntasRol.TabIndex = 55
        Me.tgPreguntasRol.Text = "Off"
        Me.tgPreguntasRol.UseSelectable = True
        '
        'lblPregunntas
        '
        Me.lblPregunntas.AutoSize = True
        Me.lblPregunntas.Location = New System.Drawing.Point(97, 108)
        Me.lblPregunntas.Name = "lblPregunntas"
        Me.lblPregunntas.Size = New System.Drawing.Size(67, 19)
        Me.lblPregunntas.TabIndex = 54
        Me.lblPregunntas.Text = "Preguntas"
        '
        'lblPermisosWeb
        '
        Me.lblPermisosWeb.AutoSize = True
        Me.lblPermisosWeb.Location = New System.Drawing.Point(6, -4)
        Me.lblPermisosWeb.Name = "lblPermisosWeb"
        Me.lblPermisosWeb.Size = New System.Drawing.Size(105, 19)
        Me.lblPermisosWeb.TabIndex = 50
        Me.lblPermisosWeb.Text = "Plataforma Web"
        '
        'tgEvaluacionesRol
        '
        Me.tgEvaluacionesRol.AutoSize = True
        Me.tgEvaluacionesRol.Location = New System.Drawing.Point(194, 38)
        Me.tgEvaluacionesRol.Name = "tgEvaluacionesRol"
        Me.tgEvaluacionesRol.Size = New System.Drawing.Size(80, 17)
        Me.tgEvaluacionesRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEvaluacionesRol.TabIndex = 52
        Me.tgEvaluacionesRol.Text = "Off"
        Me.tgEvaluacionesRol.UseSelectable = True
        '
        'lblEvaluations
        '
        Me.lblEvaluations.AutoSize = True
        Me.lblEvaluations.Location = New System.Drawing.Point(97, 36)
        Me.lblEvaluations.Name = "lblEvaluations"
        Me.lblEvaluations.Size = New System.Drawing.Size(82, 19)
        Me.lblEvaluations.TabIndex = 53
        Me.lblEvaluations.Text = "Evaluaciones"
        '
        'lblReportsRol
        '
        Me.lblReportsRol.AutoSize = True
        Me.lblReportsRol.Location = New System.Drawing.Point(97, 72)
        Me.lblReportsRol.Name = "lblReportsRol"
        Me.lblReportsRol.Size = New System.Drawing.Size(62, 19)
        Me.lblReportsRol.TabIndex = 34
        Me.lblReportsRol.Text = "Reportes"
        '
        'tgReportsRol
        '
        Me.tgReportsRol.AutoSize = True
        Me.tgReportsRol.Location = New System.Drawing.Point(194, 74)
        Me.tgReportsRol.Name = "tgReportsRol"
        Me.tgReportsRol.Size = New System.Drawing.Size(80, 17)
        Me.tgReportsRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgReportsRol.TabIndex = 7
        Me.tgReportsRol.Text = "Off"
        Me.tgReportsRol.UseSelectable = True
        '
        'tgUsersRol
        '
        Me.tgUsersRol.AutoSize = True
        Me.tgUsersRol.Location = New System.Drawing.Point(99, 131)
        Me.tgUsersRol.Name = "tgUsersRol"
        Me.tgUsersRol.Size = New System.Drawing.Size(80, 17)
        Me.tgUsersRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgUsersRol.TabIndex = 12
        Me.tgUsersRol.Text = "Off"
        Me.tgUsersRol.UseSelectable = True
        '
        'lblUsersRol
        '
        Me.lblUsersRol.AutoSize = True
        Me.lblUsersRol.Location = New System.Drawing.Point(15, 129)
        Me.lblUsersRol.Name = "lblUsersRol"
        Me.lblUsersRol.Size = New System.Drawing.Size(58, 19)
        Me.lblUsersRol.TabIndex = 51
        Me.lblUsersRol.Text = "Usuarios"
        '
        'gboPorductsSectionRol
        '
        Me.gboPorductsSectionRol.BackColor = System.Drawing.Color.White
        Me.gboPorductsSectionRol.Controls.Add(Me.lblActisRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.lblCareersRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.tgCareersRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.tgActiRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.lblProductsSectionRol)
        Me.gboPorductsSectionRol.Location = New System.Drawing.Point(8, 165)
        Me.gboPorductsSectionRol.Name = "gboPorductsSectionRol"
        Me.gboPorductsSectionRol.Size = New System.Drawing.Size(182, 86)
        Me.gboPorductsSectionRol.TabIndex = 49
        Me.gboPorductsSectionRol.TabStop = False
        '
        'lblActisRol
        '
        Me.lblActisRol.AutoSize = True
        Me.lblActisRol.Location = New System.Drawing.Point(7, 23)
        Me.lblActisRol.Name = "lblActisRol"
        Me.lblActisRol.Size = New System.Drawing.Size(36, 19)
        Me.lblActisRol.TabIndex = 44
        Me.lblActisRol.Text = "Actis"
        '
        'lblCareersRol
        '
        Me.lblCareersRol.AutoSize = True
        Me.lblCareersRol.Location = New System.Drawing.Point(7, 56)
        Me.lblCareersRol.Name = "lblCareersRol"
        Me.lblCareersRol.Size = New System.Drawing.Size(59, 19)
        Me.lblCareersRol.TabIndex = 45
        Me.lblCareersRol.Text = "Carreras"
        '
        'tgCareersRol
        '
        Me.tgCareersRol.AutoSize = True
        Me.tgCareersRol.Location = New System.Drawing.Point(91, 58)
        Me.tgCareersRol.Name = "tgCareersRol"
        Me.tgCareersRol.Size = New System.Drawing.Size(80, 17)
        Me.tgCareersRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgCareersRol.TabIndex = 10
        Me.tgCareersRol.Text = "Off"
        Me.tgCareersRol.UseSelectable = True
        '
        'tgActiRol
        '
        Me.tgActiRol.AutoSize = True
        Me.tgActiRol.Location = New System.Drawing.Point(91, 23)
        Me.tgActiRol.Name = "tgActiRol"
        Me.tgActiRol.Size = New System.Drawing.Size(80, 17)
        Me.tgActiRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgActiRol.TabIndex = 9
        Me.tgActiRol.Text = "Off"
        Me.tgActiRol.UseSelectable = True
        '
        'lblProductsSectionRol
        '
        Me.lblProductsSectionRol.AutoSize = True
        Me.lblProductsSectionRol.Location = New System.Drawing.Point(6, -4)
        Me.lblProductsSectionRol.Name = "lblProductsSectionRol"
        Me.lblProductsSectionRol.Size = New System.Drawing.Size(68, 19)
        Me.lblProductsSectionRol.TabIndex = 50
        Me.lblProductsSectionRol.Text = "Productos"
        '
        'tgConfigurationRol
        '
        Me.tgConfigurationRol.AutoSize = True
        Me.tgConfigurationRol.Location = New System.Drawing.Point(318, 24)
        Me.tgConfigurationRol.Name = "tgConfigurationRol"
        Me.tgConfigurationRol.Size = New System.Drawing.Size(80, 17)
        Me.tgConfigurationRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgConfigurationRol.TabIndex = 8
        Me.tgConfigurationRol.Text = "Off"
        Me.tgConfigurationRol.UseSelectable = True
        '
        'tgKpiRol
        '
        Me.tgKpiRol.AutoSize = True
        Me.tgKpiRol.Location = New System.Drawing.Point(99, 25)
        Me.tgKpiRol.Name = "tgKpiRol"
        Me.tgKpiRol.Size = New System.Drawing.Size(80, 17)
        Me.tgKpiRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgKpiRol.TabIndex = 3
        Me.tgKpiRol.Text = "Off"
        Me.tgKpiRol.UseSelectable = True
        '
        'tgEventsRol
        '
        Me.tgEventsRol.AutoSize = True
        Me.tgEventsRol.Location = New System.Drawing.Point(99, 95)
        Me.tgEventsRol.Name = "tgEventsRol"
        Me.tgEventsRol.Size = New System.Drawing.Size(80, 17)
        Me.tgEventsRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEventsRol.TabIndex = 6
        Me.tgEventsRol.Text = "Off"
        Me.tgEventsRol.UseSelectable = True
        '
        'tgProspectusRol
        '
        Me.tgProspectusRol.AutoSize = True
        Me.tgProspectusRol.Location = New System.Drawing.Point(318, 61)
        Me.tgProspectusRol.Name = "tgProspectusRol"
        Me.tgProspectusRol.Size = New System.Drawing.Size(80, 17)
        Me.tgProspectusRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgProspectusRol.TabIndex = 5
        Me.tgProspectusRol.Text = "Off"
        Me.tgProspectusRol.UseSelectable = True
        '
        'tgSalesRol
        '
        Me.tgSalesRol.AutoSize = True
        Me.tgSalesRol.Location = New System.Drawing.Point(99, 61)
        Me.tgSalesRol.Name = "tgSalesRol"
        Me.tgSalesRol.Size = New System.Drawing.Size(80, 17)
        Me.tgSalesRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgSalesRol.TabIndex = 4
        Me.tgSalesRol.Text = "Off"
        Me.tgSalesRol.UseSelectable = True
        '
        'lblConfigurationRol
        '
        Me.lblConfigurationRol.AutoSize = True
        Me.lblConfigurationRol.Location = New System.Drawing.Point(221, 22)
        Me.lblConfigurationRol.Name = "lblConfigurationRol"
        Me.lblConfigurationRol.Size = New System.Drawing.Size(91, 19)
        Me.lblConfigurationRol.TabIndex = 35
        Me.lblConfigurationRol.Text = "Configuracion"
        '
        'lblKpiRol
        '
        Me.lblKpiRol.AutoSize = True
        Me.lblKpiRol.Location = New System.Drawing.Point(15, 23)
        Me.lblKpiRol.Name = "lblKpiRol"
        Me.lblKpiRol.Size = New System.Drawing.Size(27, 19)
        Me.lblKpiRol.TabIndex = 32
        Me.lblKpiRol.Text = "Kpi"
        '
        'lblEventsRol
        '
        Me.lblEventsRol.AutoSize = True
        Me.lblEventsRol.Location = New System.Drawing.Point(15, 93)
        Me.lblEventsRol.Name = "lblEventsRol"
        Me.lblEventsRol.Size = New System.Drawing.Size(53, 19)
        Me.lblEventsRol.TabIndex = 31
        Me.lblEventsRol.Text = "Eventos"
        '
        'lblProspectusRol
        '
        Me.lblProspectusRol.AutoSize = True
        Me.lblProspectusRol.Location = New System.Drawing.Point(221, 59)
        Me.lblProspectusRol.Name = "lblProspectusRol"
        Me.lblProspectusRol.Size = New System.Drawing.Size(73, 19)
        Me.lblProspectusRol.TabIndex = 30
        Me.lblProspectusRol.Text = "Prospectos"
        '
        'lblSalesRol
        '
        Me.lblSalesRol.AutoSize = True
        Me.lblSalesRol.Location = New System.Drawing.Point(15, 59)
        Me.lblSalesRol.Name = "lblSalesRol"
        Me.lblSalesRol.Size = New System.Drawing.Size(46, 19)
        Me.lblSalesRol.TabIndex = 29
        Me.lblSalesRol.Text = "Ventas"
        '
        'lblPermissionsRol
        '
        Me.lblPermissionsRol.AutoSize = True
        Me.lblPermissionsRol.Location = New System.Drawing.Point(23, 133)
        Me.lblPermissionsRol.Name = "lblPermissionsRol"
        Me.lblPermissionsRol.Size = New System.Drawing.Size(61, 19)
        Me.lblPermissionsRol.TabIndex = 26
        Me.lblPermissionsRol.Text = "Permisos"
        '
        'tgEnabledRol
        '
        Me.tgEnabledRol.AutoSize = True
        Me.tgEnabledRol.Location = New System.Drawing.Point(98, 86)
        Me.tgEnabledRol.Name = "tgEnabledRol"
        Me.tgEnabledRol.Size = New System.Drawing.Size(80, 17)
        Me.tgEnabledRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEnabledRol.TabIndex = 2
        Me.tgEnabledRol.Text = "Off"
        Me.tgEnabledRol.UseSelectable = True
        '
        'txtRolName
        '
        '
        '
        '
        Me.txtRolName.CustomButton.Image = Nothing
        Me.txtRolName.CustomButton.Location = New System.Drawing.Point(430, 1)
        Me.txtRolName.CustomButton.Name = ""
        Me.txtRolName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRolName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRolName.CustomButton.TabIndex = 1
        Me.txtRolName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRolName.CustomButton.UseSelectable = True
        Me.txtRolName.CustomButton.Visible = False
        Me.txtRolName.Lines = New String(-1) {}
        Me.txtRolName.Location = New System.Drawing.Point(98, 51)
        Me.txtRolName.MaxLength = 75
        Me.txtRolName.Name = "txtRolName"
        Me.txtRolName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRolName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRolName.SelectedText = ""
        Me.txtRolName.SelectionLength = 0
        Me.txtRolName.SelectionStart = 0
        Me.txtRolName.Size = New System.Drawing.Size(452, 23)
        Me.txtRolName.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtRolName.TabIndex = 1
        Me.txtRolName.UseSelectable = True
        Me.txtRolName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRolName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelRol
        '
        Me.btnCancelRol.Location = New System.Drawing.Point(598, 422)
        Me.btnCancelRol.Name = "btnCancelRol"
        Me.btnCancelRol.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelRol.TabIndex = 14
        Me.btnCancelRol.Text = "Cancelar"
        Me.btnCancelRol.UseSelectable = True
        '
        'btnSaveRol
        '
        Me.btnSaveRol.Location = New System.Drawing.Point(494, 422)
        Me.btnSaveRol.Name = "btnSaveRol"
        Me.btnSaveRol.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveRol.TabIndex = 13
        Me.btnSaveRol.Text = "Guardar"
        Me.btnSaveRol.UseSelectable = True
        '
        'btnEnabledRol
        '
        Me.btnEnabledRol.AutoSize = True
        Me.btnEnabledRol.Location = New System.Drawing.Point(24, 82)
        Me.btnEnabledRol.Name = "btnEnabledRol"
        Me.btnEnabledRol.Size = New System.Drawing.Size(45, 19)
        Me.btnEnabledRol.TabIndex = 14
        Me.btnEnabledRol.Text = "Activo"
        '
        'lblNameRol
        '
        Me.lblNameRol.AutoSize = True
        Me.lblNameRol.Location = New System.Drawing.Point(24, 51)
        Me.lblNameRol.Name = "lblNameRol"
        Me.lblNameRol.Size = New System.Drawing.Size(59, 19)
        Me.lblNameRol.TabIndex = 11
        Me.lblNameRol.Text = "Nombre"
        '
        'lblCreateRolTittle
        '
        Me.lblCreateRolTittle.AutoSize = True
        Me.lblCreateRolTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCreateRolTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblCreateRolTittle.Name = "lblCreateRolTittle"
        Me.lblCreateRolTittle.Size = New System.Drawing.Size(78, 25)
        Me.lblCreateRolTittle.TabIndex = 10
        Me.lblCreateRolTittle.Text = "Crear rol"
        '
        'pnlCreateUser
        '
        Me.pnlCreateUser.Controls.Add(Me.lblImportEstudiantes)
        Me.pnlCreateUser.Controls.Add(Me.lblImportProfesores)
        Me.pnlCreateUser.Controls.Add(Me.lblPasswordUserBackup)
        Me.pnlCreateUser.Controls.Add(Me.chkChangeUserPassword)
        Me.pnlCreateUser.Controls.Add(Me.cboDateCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblDateCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtEmailCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblEmailCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtLastNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.cboRolCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.tgEnableCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblRolCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblEnabledCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtPhoneCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtPasswordCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtIdCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.btnCancelCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.btnSaveCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblPaswordCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblPhoneCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblLastNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblCedulaCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblCreateUserTittle)
        Me.pnlCreateUser.HorizontalScrollbarBarColor = True
        Me.pnlCreateUser.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCreateUser.HorizontalScrollbarSize = 10
        Me.pnlCreateUser.Location = New System.Drawing.Point(3, 5)
        Me.pnlCreateUser.Name = "pnlCreateUser"
        Me.pnlCreateUser.Size = New System.Drawing.Size(746, 462)
        Me.pnlCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlCreateUser.TabIndex = 53
        Me.pnlCreateUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlCreateUser.VerticalScrollbarBarColor = True
        Me.pnlCreateUser.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCreateUser.VerticalScrollbarSize = 10
        Me.pnlCreateUser.Visible = False
        '
        'lblImportEstudiantes
        '
        Me.lblImportEstudiantes.AutoSize = True
        Me.lblImportEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblImportEstudiantes.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblImportEstudiantes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblImportEstudiantes.Location = New System.Drawing.Point(357, 10)
        Me.lblImportEstudiantes.Name = "lblImportEstudiantes"
        Me.lblImportEstudiantes.Size = New System.Drawing.Size(168, 25)
        Me.lblImportEstudiantes.TabIndex = 51
        Me.lblImportEstudiantes.Text = "Importar estudiantes"
        Me.lblImportEstudiantes.UseCustomForeColor = True
        '
        'lblImportProfesores
        '
        Me.lblImportProfesores.AutoSize = True
        Me.lblImportProfesores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblImportProfesores.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblImportProfesores.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblImportProfesores.Location = New System.Drawing.Point(158, 9)
        Me.lblImportProfesores.Name = "lblImportProfesores"
        Me.lblImportProfesores.Size = New System.Drawing.Size(162, 25)
        Me.lblImportProfesores.TabIndex = 50
        Me.lblImportProfesores.Text = "Importar profesores"
        Me.lblImportProfesores.UseCustomForeColor = True
        '
        'lblPasswordUserBackup
        '
        Me.lblPasswordUserBackup.AutoSize = True
        Me.lblPasswordUserBackup.Location = New System.Drawing.Point(20, 436)
        Me.lblPasswordUserBackup.Name = "lblPasswordUserBackup"
        Me.lblPasswordUserBackup.Size = New System.Drawing.Size(122, 13)
        Me.lblPasswordUserBackup.TabIndex = 48
        Me.lblPasswordUserBackup.Text = "lblPasswordUserBackup"
        Me.lblPasswordUserBackup.Visible = False
        '
        'chkChangeUserPassword
        '
        Me.chkChangeUserPassword.AutoSize = True
        Me.chkChangeUserPassword.Location = New System.Drawing.Point(531, 254)
        Me.chkChangeUserPassword.Name = "chkChangeUserPassword"
        Me.chkChangeUserPassword.Size = New System.Drawing.Size(68, 15)
        Me.chkChangeUserPassword.Style = MetroFramework.MetroColorStyle.Purple
        Me.chkChangeUserPassword.TabIndex = 47
        Me.chkChangeUserPassword.Text = "Cambiar"
        Me.chkChangeUserPassword.UseSelectable = True
        '
        'cboDateCreateUser
        '
        Me.cboDateCreateUser.Location = New System.Drawing.Point(158, 175)
        Me.cboDateCreateUser.MinimumSize = New System.Drawing.Size(4, 29)
        Me.cboDateCreateUser.Name = "cboDateCreateUser"
        Me.cboDateCreateUser.Size = New System.Drawing.Size(366, 29)
        Me.cboDateCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboDateCreateUser.TabIndex = 5
        '
        'lblDateCreateUser
        '
        Me.lblDateCreateUser.AutoSize = True
        Me.lblDateCreateUser.Location = New System.Drawing.Point(24, 185)
        Me.lblDateCreateUser.Name = "lblDateCreateUser"
        Me.lblDateCreateUser.Size = New System.Drawing.Size(111, 19)
        Me.lblDateCreateUser.TabIndex = 44
        Me.lblDateCreateUser.Text = "Fecha nacimiento"
        '
        'txtEmailCreateUser
        '
        '
        '
        '
        Me.txtEmailCreateUser.CustomButton.Image = Nothing
        Me.txtEmailCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailCreateUser.CustomButton.Name = ""
        Me.txtEmailCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailCreateUser.CustomButton.TabIndex = 1
        Me.txtEmailCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailCreateUser.CustomButton.UseSelectable = True
        Me.txtEmailCreateUser.CustomButton.Visible = False
        Me.txtEmailCreateUser.Lines = New String(-1) {}
        Me.txtEmailCreateUser.Location = New System.Drawing.Point(158, 144)
        Me.txtEmailCreateUser.MaxLength = 49
        Me.txtEmailCreateUser.Name = "txtEmailCreateUser"
        Me.txtEmailCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailCreateUser.SelectedText = ""
        Me.txtEmailCreateUser.SelectionLength = 0
        Me.txtEmailCreateUser.SelectionStart = 0
        Me.txtEmailCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailCreateUser.TabIndex = 4
        Me.txtEmailCreateUser.UseSelectable = True
        Me.txtEmailCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmailCreateUser
        '
        Me.lblEmailCreateUser.AutoSize = True
        Me.lblEmailCreateUser.Location = New System.Drawing.Point(24, 148)
        Me.lblEmailCreateUser.Name = "lblEmailCreateUser"
        Me.lblEmailCreateUser.Size = New System.Drawing.Size(51, 19)
        Me.lblEmailCreateUser.TabIndex = 42
        Me.lblEmailCreateUser.Text = "Correo"
        '
        'txtLastNameCreateUser
        '
        '
        '
        '
        Me.txtLastNameCreateUser.CustomButton.Image = Nothing
        Me.txtLastNameCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtLastNameCreateUser.CustomButton.Name = ""
        Me.txtLastNameCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastNameCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastNameCreateUser.CustomButton.TabIndex = 1
        Me.txtLastNameCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastNameCreateUser.CustomButton.UseSelectable = True
        Me.txtLastNameCreateUser.CustomButton.Visible = False
        Me.txtLastNameCreateUser.Lines = New String(-1) {}
        Me.txtLastNameCreateUser.Location = New System.Drawing.Point(158, 113)
        Me.txtLastNameCreateUser.MaxLength = 49
        Me.txtLastNameCreateUser.Name = "txtLastNameCreateUser"
        Me.txtLastNameCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastNameCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastNameCreateUser.SelectedText = ""
        Me.txtLastNameCreateUser.SelectionLength = 0
        Me.txtLastNameCreateUser.SelectionStart = 0
        Me.txtLastNameCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtLastNameCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtLastNameCreateUser.TabIndex = 3
        Me.txtLastNameCreateUser.UseSelectable = True
        Me.txtLastNameCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastNameCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboRolCreateUser
        '
        Me.cboRolCreateUser.FormattingEnabled = True
        Me.cboRolCreateUser.ItemHeight = 23
        Me.cboRolCreateUser.Location = New System.Drawing.Point(158, 277)
        Me.cboRolCreateUser.Name = "cboRolCreateUser"
        Me.cboRolCreateUser.Size = New System.Drawing.Size(367, 29)
        Me.cboRolCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboRolCreateUser.TabIndex = 8
        Me.cboRolCreateUser.UseSelectable = True
        '
        'tgEnableCreateUser
        '
        Me.tgEnableCreateUser.AutoSize = True
        Me.tgEnableCreateUser.Location = New System.Drawing.Point(158, 321)
        Me.tgEnableCreateUser.Name = "tgEnableCreateUser"
        Me.tgEnableCreateUser.Size = New System.Drawing.Size(80, 17)
        Me.tgEnableCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEnableCreateUser.TabIndex = 9
        Me.tgEnableCreateUser.Text = "Off"
        Me.tgEnableCreateUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tgEnableCreateUser.UseSelectable = True
        '
        'lblRolCreateUser
        '
        Me.lblRolCreateUser.AutoSize = True
        Me.lblRolCreateUser.Location = New System.Drawing.Point(26, 287)
        Me.lblRolCreateUser.Name = "lblRolCreateUser"
        Me.lblRolCreateUser.Size = New System.Drawing.Size(28, 19)
        Me.lblRolCreateUser.TabIndex = 39
        Me.lblRolCreateUser.Text = "Rol"
        '
        'lblEnabledCreateUser
        '
        Me.lblEnabledCreateUser.AutoSize = True
        Me.lblEnabledCreateUser.Location = New System.Drawing.Point(26, 319)
        Me.lblEnabledCreateUser.Name = "lblEnabledCreateUser"
        Me.lblEnabledCreateUser.Size = New System.Drawing.Size(45, 19)
        Me.lblEnabledCreateUser.TabIndex = 37
        Me.lblEnabledCreateUser.Text = "Activo"
        '
        'txtPhoneCreateUser
        '
        '
        '
        '
        Me.txtPhoneCreateUser.CustomButton.Image = Nothing
        Me.txtPhoneCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPhoneCreateUser.CustomButton.Name = ""
        Me.txtPhoneCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneCreateUser.CustomButton.TabIndex = 1
        Me.txtPhoneCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneCreateUser.CustomButton.UseSelectable = True
        Me.txtPhoneCreateUser.CustomButton.Visible = False
        Me.txtPhoneCreateUser.Lines = New String(-1) {}
        Me.txtPhoneCreateUser.Location = New System.Drawing.Point(158, 215)
        Me.txtPhoneCreateUser.MaxLength = 30
        Me.txtPhoneCreateUser.Name = "txtPhoneCreateUser"
        Me.txtPhoneCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneCreateUser.SelectedText = ""
        Me.txtPhoneCreateUser.SelectionLength = 0
        Me.txtPhoneCreateUser.SelectionStart = 0
        Me.txtPhoneCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtPhoneCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPhoneCreateUser.TabIndex = 6
        Me.txtPhoneCreateUser.UseSelectable = True
        Me.txtPhoneCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPasswordCreateUser
        '
        '
        '
        '
        Me.txtPasswordCreateUser.CustomButton.Image = Nothing
        Me.txtPasswordCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPasswordCreateUser.CustomButton.Name = ""
        Me.txtPasswordCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPasswordCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPasswordCreateUser.CustomButton.TabIndex = 1
        Me.txtPasswordCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordCreateUser.CustomButton.UseSelectable = True
        Me.txtPasswordCreateUser.CustomButton.Visible = False
        Me.txtPasswordCreateUser.Lines = New String(-1) {}
        Me.txtPasswordCreateUser.Location = New System.Drawing.Point(158, 246)
        Me.txtPasswordCreateUser.MaxLength = 49
        Me.txtPasswordCreateUser.Name = "txtPasswordCreateUser"
        Me.txtPasswordCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordCreateUser.SelectedText = ""
        Me.txtPasswordCreateUser.SelectionLength = 0
        Me.txtPasswordCreateUser.SelectionStart = 0
        Me.txtPasswordCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtPasswordCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPasswordCreateUser.TabIndex = 7
        Me.txtPasswordCreateUser.UseSelectable = True
        Me.txtPasswordCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPasswordCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNameCreateUser
        '
        '
        '
        '
        Me.txtNameCreateUser.CustomButton.Image = Nothing
        Me.txtNameCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNameCreateUser.CustomButton.Name = ""
        Me.txtNameCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNameCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNameCreateUser.CustomButton.TabIndex = 1
        Me.txtNameCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNameCreateUser.CustomButton.UseSelectable = True
        Me.txtNameCreateUser.CustomButton.Visible = False
        Me.txtNameCreateUser.Lines = New String(-1) {}
        Me.txtNameCreateUser.Location = New System.Drawing.Point(158, 82)
        Me.txtNameCreateUser.MaxLength = 49
        Me.txtNameCreateUser.Name = "txtNameCreateUser"
        Me.txtNameCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNameCreateUser.SelectedText = ""
        Me.txtNameCreateUser.SelectionLength = 0
        Me.txtNameCreateUser.SelectionStart = 0
        Me.txtNameCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtNameCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNameCreateUser.TabIndex = 2
        Me.txtNameCreateUser.UseSelectable = True
        Me.txtNameCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNameCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdCreateUser
        '
        '
        '
        '
        Me.txtIdCreateUser.CustomButton.Image = Nothing
        Me.txtIdCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtIdCreateUser.CustomButton.Name = ""
        Me.txtIdCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIdCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdCreateUser.CustomButton.TabIndex = 1
        Me.txtIdCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdCreateUser.CustomButton.UseSelectable = True
        Me.txtIdCreateUser.CustomButton.Visible = False
        Me.txtIdCreateUser.Lines = New String(-1) {}
        Me.txtIdCreateUser.Location = New System.Drawing.Point(158, 51)
        Me.txtIdCreateUser.MaxLength = 49
        Me.txtIdCreateUser.Name = "txtIdCreateUser"
        Me.txtIdCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdCreateUser.SelectedText = ""
        Me.txtIdCreateUser.SelectionLength = 0
        Me.txtIdCreateUser.SelectionStart = 0
        Me.txtIdCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtIdCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtIdCreateUser.TabIndex = 1
        Me.txtIdCreateUser.UseSelectable = True
        Me.txtIdCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelCreateUser
        '
        Me.btnCancelCreateUser.Location = New System.Drawing.Point(427, 436)
        Me.btnCancelCreateUser.Name = "btnCancelCreateUser"
        Me.btnCancelCreateUser.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelCreateUser.TabIndex = 11
        Me.btnCancelCreateUser.Text = "Cancelar"
        Me.btnCancelCreateUser.UseSelectable = True
        '
        'btnSaveCreateUser
        '
        Me.btnSaveCreateUser.Location = New System.Drawing.Point(324, 436)
        Me.btnSaveCreateUser.Name = "btnSaveCreateUser"
        Me.btnSaveCreateUser.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveCreateUser.TabIndex = 10
        Me.btnSaveCreateUser.Text = "Guardar"
        Me.btnSaveCreateUser.UseSelectable = True
        '
        'lblPaswordCreateUser
        '
        Me.lblPaswordCreateUser.AutoSize = True
        Me.lblPaswordCreateUser.Location = New System.Drawing.Point(25, 246)
        Me.lblPaswordCreateUser.Name = "lblPaswordCreateUser"
        Me.lblPaswordCreateUser.Size = New System.Drawing.Size(75, 19)
        Me.lblPaswordCreateUser.TabIndex = 19
        Me.lblPaswordCreateUser.Text = "Contraseña"
        '
        'lblPhoneCreateUser
        '
        Me.lblPhoneCreateUser.AutoSize = True
        Me.lblPhoneCreateUser.Location = New System.Drawing.Point(24, 215)
        Me.lblPhoneCreateUser.Name = "lblPhoneCreateUser"
        Me.lblPhoneCreateUser.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoneCreateUser.TabIndex = 15
        Me.lblPhoneCreateUser.Text = "Telefono"
        '
        'lblNameCreateUser
        '
        Me.lblNameCreateUser.AutoSize = True
        Me.lblNameCreateUser.Location = New System.Drawing.Point(24, 82)
        Me.lblNameCreateUser.Name = "lblNameCreateUser"
        Me.lblNameCreateUser.Size = New System.Drawing.Size(59, 19)
        Me.lblNameCreateUser.TabIndex = 14
        Me.lblNameCreateUser.Text = "Nombre"
        '
        'lblLastNameCreateUser
        '
        Me.lblLastNameCreateUser.AutoSize = True
        Me.lblLastNameCreateUser.Location = New System.Drawing.Point(25, 114)
        Me.lblLastNameCreateUser.Name = "lblLastNameCreateUser"
        Me.lblLastNameCreateUser.Size = New System.Drawing.Size(58, 19)
        Me.lblLastNameCreateUser.TabIndex = 13
        Me.lblLastNameCreateUser.Text = "Apellido"
        '
        'lblCedulaCreateUser
        '
        Me.lblCedulaCreateUser.AutoSize = True
        Me.lblCedulaCreateUser.Location = New System.Drawing.Point(24, 51)
        Me.lblCedulaCreateUser.Name = "lblCedulaCreateUser"
        Me.lblCedulaCreateUser.Size = New System.Drawing.Size(50, 19)
        Me.lblCedulaCreateUser.TabIndex = 11
        Me.lblCedulaCreateUser.Text = "Cedula"
        '
        'lblCreateUserTittle
        '
        Me.lblCreateUserTittle.AutoSize = True
        Me.lblCreateUserTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCreateUserTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblCreateUserTittle.Name = "lblCreateUserTittle"
        Me.lblCreateUserTittle.Size = New System.Drawing.Size(114, 25)
        Me.lblCreateUserTittle.TabIndex = 10
        Me.lblCreateUserTittle.Text = "Crear usuario"
        '
        'pnListUsers
        '
        Me.pnListUsers.Controls.Add(Me.lblCreateUpdateUserId)
        Me.pnListUsers.Controls.Add(Me.lstUsers)
        Me.pnListUsers.Controls.Add(Me.lblRolsSection)
        Me.pnListUsers.Controls.Add(Me.lblListOfUsersTittle)
        Me.pnListUsers.Controls.Add(Me.btnCreateUser)
        Me.pnListUsers.HorizontalScrollbarBarColor = True
        Me.pnListUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.pnListUsers.HorizontalScrollbarSize = 10
        Me.pnListUsers.Location = New System.Drawing.Point(0, 6)
        Me.pnListUsers.Name = "pnListUsers"
        Me.pnListUsers.Size = New System.Drawing.Size(753, 462)
        Me.pnListUsers.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnListUsers.TabIndex = 52
        Me.pnListUsers.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnListUsers.VerticalScrollbarBarColor = True
        Me.pnListUsers.VerticalScrollbarHighlightOnWheel = False
        Me.pnListUsers.VerticalScrollbarSize = 10
        '
        'lblCreateUpdateUserId
        '
        Me.lblCreateUpdateUserId.AutoSize = True
        Me.lblCreateUpdateUserId.Location = New System.Drawing.Point(723, 7)
        Me.lblCreateUpdateUserId.Name = "lblCreateUpdateUserId"
        Me.lblCreateUpdateUserId.Size = New System.Drawing.Size(20, 19)
        Me.lblCreateUpdateUserId.TabIndex = 49
        Me.lblCreateUpdateUserId.Text = "id"
        Me.lblCreateUpdateUserId.Visible = False
        '
        'lstUsers
        '
        Me.lstUsers.AllowUserToAddRows = False
        Me.lstUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdLstUsers, Me.identificationLstUsers, Me.userNameLstUsers, Me.userLastNameLstUsers, Me.userPhoneLstUsers, Me.userEmailLstUsers, Me.userStateLstUsers, Me.userEditLstUsers})
        Me.lstUsers.Location = New System.Drawing.Point(7, 37)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.RowHeadersVisible = False
        Me.lstUsers.Size = New System.Drawing.Size(739, 344)
        Me.lstUsers.TabIndex = 12
        '
        'colIdLstUsers
        '
        Me.colIdLstUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIdLstUsers.HeaderText = "ID"
        Me.colIdLstUsers.Name = "colIdLstUsers"
        Me.colIdLstUsers.ReadOnly = True
        Me.colIdLstUsers.Visible = False
        '
        'identificationLstUsers
        '
        Me.identificationLstUsers.HeaderText = "Cédula"
        Me.identificationLstUsers.Name = "identificationLstUsers"
        '
        'userNameLstUsers
        '
        Me.userNameLstUsers.HeaderText = "Nombre"
        Me.userNameLstUsers.Name = "userNameLstUsers"
        Me.userNameLstUsers.ReadOnly = True
        '
        'userLastNameLstUsers
        '
        Me.userLastNameLstUsers.HeaderText = "Apellidos"
        Me.userLastNameLstUsers.Name = "userLastNameLstUsers"
        Me.userLastNameLstUsers.ReadOnly = True
        '
        'userPhoneLstUsers
        '
        Me.userPhoneLstUsers.HeaderText = "Teléfono"
        Me.userPhoneLstUsers.Name = "userPhoneLstUsers"
        Me.userPhoneLstUsers.ReadOnly = True
        '
        'userEmailLstUsers
        '
        Me.userEmailLstUsers.HeaderText = "E-mail"
        Me.userEmailLstUsers.Name = "userEmailLstUsers"
        Me.userEmailLstUsers.ReadOnly = True
        '
        'userStateLstUsers
        '
        Me.userStateLstUsers.HeaderText = "Estado"
        Me.userStateLstUsers.Name = "userStateLstUsers"
        '
        'userEditLstUsers
        '
        Me.userEditLstUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userEditLstUsers.HeaderText = ""
        Me.userEditLstUsers.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.userEditLstUsers.Name = "userEditLstUsers"
        Me.userEditLstUsers.ReadOnly = True
        Me.userEditLstUsers.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userEditLstUsers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblRolsSection
        '
        Me.lblRolsSection.BackColor = System.Drawing.Color.Ivory
        Me.lblRolsSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRolsSection.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lblRolsSection.Location = New System.Drawing.Point(3, 425)
        Me.lblRolsSection.Name = "lblRolsSection"
        Me.lblRolsSection.Size = New System.Drawing.Size(217, 23)
        Me.lblRolsSection.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblRolsSection.TabIndex = 11
        Me.lblRolsSection.Text = "Administrar roles de usuario"
        Me.lblRolsSection.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblRolsSection.UseSelectable = True
        '
        'lblListOfUsersTittle
        '
        Me.lblListOfUsersTittle.AutoSize = True
        Me.lblListOfUsersTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListOfUsersTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblListOfUsersTittle.Name = "lblListOfUsersTittle"
        Me.lblListOfUsersTittle.Size = New System.Drawing.Size(113, 25)
        Me.lblListOfUsersTittle.TabIndex = 10
        Me.lblListOfUsersTittle.Text = "Lista usuarios"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(620, 412)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(123, 36)
        Me.btnCreateUser.TabIndex = 9
        Me.btnCreateUser.Text = "Nuevo usuario"
        Me.btnCreateUser.UseSelectable = True
        '
        'pnlListRols
        '
        Me.pnlListRols.Controls.Add(Me.btnBackRolsUsers)
        Me.pnlListRols.Controls.Add(Me.lblIdRol)
        Me.pnlListRols.Controls.Add(Me.lstListRols)
        Me.pnlListRols.Controls.Add(Me.lblListOfRols)
        Me.pnlListRols.Controls.Add(Me.btnNewRol)
        Me.pnlListRols.HorizontalScrollbarBarColor = True
        Me.pnlListRols.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlListRols.HorizontalScrollbarSize = 10
        Me.pnlListRols.Location = New System.Drawing.Point(0, 6)
        Me.pnlListRols.Name = "pnlListRols"
        Me.pnlListRols.Size = New System.Drawing.Size(749, 461)
        Me.pnlListRols.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnlListRols.TabIndex = 50
        Me.pnlListRols.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlListRols.VerticalScrollbarBarColor = True
        Me.pnlListRols.VerticalScrollbarHighlightOnWheel = False
        Me.pnlListRols.VerticalScrollbarSize = 10
        Me.pnlListRols.Visible = False
        '
        'btnBackRolsUsers
        '
        Me.btnBackRolsUsers.Location = New System.Drawing.Point(7, 412)
        Me.btnBackRolsUsers.Name = "btnBackRolsUsers"
        Me.btnBackRolsUsers.Size = New System.Drawing.Size(123, 36)
        Me.btnBackRolsUsers.TabIndex = 50
        Me.btnBackRolsUsers.Text = "Volver"
        Me.btnBackRolsUsers.UseSelectable = True
        '
        'lblIdRol
        '
        Me.lblIdRol.AutoSize = True
        Me.lblIdRol.Location = New System.Drawing.Point(723, 7)
        Me.lblIdRol.Name = "lblIdRol"
        Me.lblIdRol.Size = New System.Drawing.Size(20, 19)
        Me.lblIdRol.TabIndex = 49
        Me.lblIdRol.Text = "id"
        Me.lblIdRol.Visible = False
        '
        'lstListRols
        '
        Me.lstListRols.AllowUserToAddRows = False
        Me.lstListRols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstListRols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdListRols, Me.colNameRol, Me.colStateRol, Me.colEditListRol})
        Me.lstListRols.Location = New System.Drawing.Point(7, 37)
        Me.lstListRols.Name = "lstListRols"
        Me.lstListRols.RowHeadersVisible = False
        Me.lstListRols.Size = New System.Drawing.Size(739, 344)
        Me.lstListRols.TabIndex = 12
        '
        'colIdListRols
        '
        Me.colIdListRols.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIdListRols.HeaderText = "ID"
        Me.colIdListRols.Name = "colIdListRols"
        Me.colIdListRols.ReadOnly = True
        Me.colIdListRols.Visible = False
        '
        'colNameRol
        '
        Me.colNameRol.HeaderText = "Nombre"
        Me.colNameRol.Name = "colNameRol"
        '
        'colStateRol
        '
        Me.colStateRol.HeaderText = "Estado"
        Me.colStateRol.Name = "colStateRol"
        '
        'colEditListRol
        '
        Me.colEditListRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEditListRol.HeaderText = ""
        Me.colEditListRol.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.colEditListRol.Name = "colEditListRol"
        Me.colEditListRol.ReadOnly = True
        Me.colEditListRol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEditListRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblListOfRols
        '
        Me.lblListOfRols.AutoSize = True
        Me.lblListOfRols.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListOfRols.Location = New System.Drawing.Point(4, 9)
        Me.lblListOfRols.Name = "lblListOfRols"
        Me.lblListOfRols.Size = New System.Drawing.Size(92, 25)
        Me.lblListOfRols.TabIndex = 10
        Me.lblListOfRols.Text = "Listar roles"
        '
        'btnNewRol
        '
        Me.btnNewRol.Location = New System.Drawing.Point(623, 412)
        Me.btnNewRol.Name = "btnNewRol"
        Me.btnNewRol.Size = New System.Drawing.Size(123, 36)
        Me.btnNewRol.TabIndex = 9
        Me.btnNewRol.Text = "Nuevo rol"
        Me.btnNewRol.UseSelectable = True
        '
        'TabVentas
        '
        Me.TabVentas.Controls.Add(Me.pnlRegistrarVenta)
        Me.TabVentas.Controls.Add(Me.pnlConsultarVentas)
        Me.TabVentas.Controls.Add(Me.pnlListarVentas)
        Me.TabVentas.Controls.Add(Me.btnListarVentasIcon)
        Me.TabVentas.Controls.Add(Me.btnRegistrarVentaIcon)
        Me.TabVentas.Controls.Add(Me.btnConsultarVentasIcon)
        Me.TabVentas.HorizontalScrollbarBarColor = True
        Me.TabVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.TabVentas.HorizontalScrollbarSize = 10
        Me.TabVentas.Location = New System.Drawing.Point(4, 44)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.Size = New System.Drawing.Size(752, 472)
        Me.TabVentas.TabIndex = 9
        Me.TabVentas.Text = "Ventas"
        Me.TabVentas.VerticalScrollbarBarColor = True
        Me.TabVentas.VerticalScrollbarHighlightOnWheel = False
        Me.TabVentas.VerticalScrollbarSize = 10
        '
        'pnlRegistrarVenta
        '
        Me.pnlRegistrarVenta.Controls.Add(Me.totalVenta_text)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblTotalVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblMatriculaVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.matricula_text)
        Me.pnlRegistrarVenta.Controls.Add(Me.productos_cmb)
        Me.pnlRegistrarVenta.Controls.Add(Me.cod_prod_cmb)
        Me.pnlRegistrarVenta.Controls.Add(Me.btnCancelarVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblCostoVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.costoVenta_text)
        Me.pnlRegistrarVenta.Controls.Add(Me.btnGuardarVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.tipo_prodVenta_cmb)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblTipoVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblProductoVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblCodProductoVenta)
        Me.pnlRegistrarVenta.Controls.Add(Me.lblRegistrarVenta)
        Me.pnlRegistrarVenta.HorizontalScrollbarBarColor = True
        Me.pnlRegistrarVenta.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlRegistrarVenta.HorizontalScrollbarSize = 10
        Me.pnlRegistrarVenta.Location = New System.Drawing.Point(0, 3)
        Me.pnlRegistrarVenta.Name = "pnlRegistrarVenta"
        Me.pnlRegistrarVenta.Size = New System.Drawing.Size(746, 462)
        Me.pnlRegistrarVenta.TabIndex = 7
        Me.pnlRegistrarVenta.VerticalScrollbarBarColor = True
        Me.pnlRegistrarVenta.VerticalScrollbarHighlightOnWheel = False
        Me.pnlRegistrarVenta.VerticalScrollbarSize = 10
        Me.pnlRegistrarVenta.Visible = False
        '
        'totalVenta_text
        '
        '
        '
        '
        Me.totalVenta_text.CustomButton.Image = Nothing
        Me.totalVenta_text.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.totalVenta_text.CustomButton.Name = ""
        Me.totalVenta_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.totalVenta_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.totalVenta_text.CustomButton.TabIndex = 1
        Me.totalVenta_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.totalVenta_text.CustomButton.UseSelectable = True
        Me.totalVenta_text.CustomButton.Visible = False
        Me.totalVenta_text.Enabled = False
        Me.totalVenta_text.Lines = New String(-1) {}
        Me.totalVenta_text.Location = New System.Drawing.Point(534, 159)
        Me.totalVenta_text.MaxLength = 8
        Me.totalVenta_text.Name = "totalVenta_text"
        Me.totalVenta_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalVenta_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.totalVenta_text.SelectedText = ""
        Me.totalVenta_text.SelectionLength = 0
        Me.totalVenta_text.SelectionStart = 0
        Me.totalVenta_text.Size = New System.Drawing.Size(182, 23)
        Me.totalVenta_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.totalVenta_text.TabIndex = 101
        Me.totalVenta_text.UseSelectable = True
        Me.totalVenta_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.totalVenta_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTotalVenta
        '
        Me.lblTotalVenta.AutoSize = True
        Me.lblTotalVenta.Location = New System.Drawing.Point(463, 159)
        Me.lblTotalVenta.Name = "lblTotalVenta"
        Me.lblTotalVenta.Size = New System.Drawing.Size(36, 19)
        Me.lblTotalVenta.TabIndex = 100
        Me.lblTotalVenta.Text = "Total"
        '
        'lblMatriculaVenta
        '
        Me.lblMatriculaVenta.AutoSize = True
        Me.lblMatriculaVenta.Location = New System.Drawing.Point(49, 159)
        Me.lblMatriculaVenta.Name = "lblMatriculaVenta"
        Me.lblMatriculaVenta.Size = New System.Drawing.Size(63, 19)
        Me.lblMatriculaVenta.TabIndex = 99
        Me.lblMatriculaVenta.Text = "Matricula"
        '
        'matricula_text
        '
        '
        '
        '
        Me.matricula_text.CustomButton.Image = Nothing
        Me.matricula_text.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.matricula_text.CustomButton.Name = ""
        Me.matricula_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.matricula_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.matricula_text.CustomButton.TabIndex = 1
        Me.matricula_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.matricula_text.CustomButton.UseSelectable = True
        Me.matricula_text.CustomButton.Visible = False
        Me.matricula_text.Lines = New String(-1) {}
        Me.matricula_text.Location = New System.Drawing.Point(175, 159)
        Me.matricula_text.MaxLength = 8
        Me.matricula_text.Name = "matricula_text"
        Me.matricula_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.matricula_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.matricula_text.SelectedText = ""
        Me.matricula_text.SelectionLength = 0
        Me.matricula_text.SelectionStart = 0
        Me.matricula_text.Size = New System.Drawing.Size(182, 23)
        Me.matricula_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.matricula_text.TabIndex = 98
        Me.matricula_text.UseSelectable = True
        Me.matricula_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.matricula_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'productos_cmb
        '
        Me.productos_cmb.FormattingEnabled = True
        Me.productos_cmb.ItemHeight = 13
        Me.productos_cmb.Location = New System.Drawing.Point(175, 94)
        Me.productos_cmb.Name = "productos_cmb"
        Me.productos_cmb.Size = New System.Drawing.Size(541, 21)
        Me.productos_cmb.TabIndex = 97
        '
        'cod_prod_cmb
        '
        Me.cod_prod_cmb.FormattingEnabled = True
        Me.cod_prod_cmb.ItemHeight = 13
        Me.cod_prod_cmb.Location = New System.Drawing.Point(175, 62)
        Me.cod_prod_cmb.Name = "cod_prod_cmb"
        Me.cod_prod_cmb.Size = New System.Drawing.Size(182, 21)
        Me.cod_prod_cmb.TabIndex = 96
        '
        'btnCancelarVenta
        '
        Me.btnCancelarVenta.Location = New System.Drawing.Point(427, 421)
        Me.btnCancelarVenta.Name = "btnCancelarVenta"
        Me.btnCancelarVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarVenta.TabIndex = 95
        Me.btnCancelarVenta.Text = "Cancelar"
        Me.btnCancelarVenta.UseSelectable = True
        '
        'lblCostoVenta
        '
        Me.lblCostoVenta.AutoSize = True
        Me.lblCostoVenta.Location = New System.Drawing.Point(463, 127)
        Me.lblCostoVenta.Name = "lblCostoVenta"
        Me.lblCostoVenta.Size = New System.Drawing.Size(43, 19)
        Me.lblCostoVenta.TabIndex = 93
        Me.lblCostoVenta.Text = "Costo"
        '
        'costoVenta_text
        '
        '
        '
        '
        Me.costoVenta_text.CustomButton.Image = Nothing
        Me.costoVenta_text.CustomButton.Location = New System.Drawing.Point(160, 1)
        Me.costoVenta_text.CustomButton.Name = ""
        Me.costoVenta_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoVenta_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoVenta_text.CustomButton.TabIndex = 1
        Me.costoVenta_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoVenta_text.CustomButton.UseSelectable = True
        Me.costoVenta_text.CustomButton.Visible = False
        Me.costoVenta_text.Enabled = False
        Me.costoVenta_text.Lines = New String(-1) {}
        Me.costoVenta_text.Location = New System.Drawing.Point(534, 127)
        Me.costoVenta_text.MaxLength = 8
        Me.costoVenta_text.Name = "costoVenta_text"
        Me.costoVenta_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoVenta_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoVenta_text.SelectedText = ""
        Me.costoVenta_text.SelectionLength = 0
        Me.costoVenta_text.SelectionStart = 0
        Me.costoVenta_text.Size = New System.Drawing.Size(182, 23)
        Me.costoVenta_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoVenta_text.TabIndex = 91
        Me.costoVenta_text.UseSelectable = True
        Me.costoVenta_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoVenta_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.Location = New System.Drawing.Point(324, 421)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarVenta.TabIndex = 94
        Me.btnGuardarVenta.Text = "Guardar"
        Me.btnGuardarVenta.UseSelectable = True
        '
        'tipo_prodVenta_cmb
        '
        Me.tipo_prodVenta_cmb.Enabled = False
        Me.tipo_prodVenta_cmb.FormattingEnabled = True
        Me.tipo_prodVenta_cmb.ItemHeight = 13
        Me.tipo_prodVenta_cmb.Location = New System.Drawing.Point(175, 127)
        Me.tipo_prodVenta_cmb.Name = "tipo_prodVenta_cmb"
        Me.tipo_prodVenta_cmb.Size = New System.Drawing.Size(182, 21)
        Me.tipo_prodVenta_cmb.TabIndex = 90
        '
        'lblTipoVenta
        '
        Me.lblTipoVenta.AutoSize = True
        Me.lblTipoVenta.Location = New System.Drawing.Point(49, 127)
        Me.lblTipoVenta.Name = "lblTipoVenta"
        Me.lblTipoVenta.Size = New System.Drawing.Size(35, 19)
        Me.lblTipoVenta.TabIndex = 91
        Me.lblTipoVenta.Text = "Tipo"
        '
        'lblProductoVenta
        '
        Me.lblProductoVenta.AutoSize = True
        Me.lblProductoVenta.Location = New System.Drawing.Point(49, 96)
        Me.lblProductoVenta.Name = "lblProductoVenta"
        Me.lblProductoVenta.Size = New System.Drawing.Size(63, 19)
        Me.lblProductoVenta.TabIndex = 90
        Me.lblProductoVenta.Text = "Producto"
        '
        'lblCodProductoVenta
        '
        Me.lblCodProductoVenta.AutoSize = True
        Me.lblCodProductoVenta.Location = New System.Drawing.Point(49, 62)
        Me.lblCodProductoVenta.Name = "lblCodProductoVenta"
        Me.lblCodProductoVenta.Size = New System.Drawing.Size(95, 19)
        Me.lblCodProductoVenta.TabIndex = 87
        Me.lblCodProductoVenta.Text = "Cod. Producto"
        '
        'lblRegistrarVenta
        '
        Me.lblRegistrarVenta.AutoSize = True
        Me.lblRegistrarVenta.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblRegistrarVenta.Location = New System.Drawing.Point(22, 16)
        Me.lblRegistrarVenta.Name = "lblRegistrarVenta"
        Me.lblRegistrarVenta.Size = New System.Drawing.Size(125, 25)
        Me.lblRegistrarVenta.TabIndex = 86
        Me.lblRegistrarVenta.Text = "Registrar Venta"
        '
        'pnlConsultarVentas
        '
        Me.pnlConsultarVentas.Controls.Add(Me.btnVolverConsultaVentas)
        Me.pnlConsultarVentas.Controls.Add(Me.grpConsultaIngresos)
        Me.pnlConsultarVentas.Controls.Add(Me.grpConsultaVentas)
        Me.pnlConsultarVentas.Controls.Add(Me.periodos_cmb)
        Me.pnlConsultarVentas.Controls.Add(Me.lblPeriodoConsultarVenta)
        Me.pnlConsultarVentas.Controls.Add(Me.usuarioConsulta_cmb)
        Me.pnlConsultarVentas.Controls.Add(Me.lblUsuarioConsultarVenta)
        Me.pnlConsultarVentas.Controls.Add(Me.lblConsultarVentas)
        Me.pnlConsultarVentas.HorizontalScrollbarBarColor = True
        Me.pnlConsultarVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlConsultarVentas.HorizontalScrollbarSize = 10
        Me.pnlConsultarVentas.Location = New System.Drawing.Point(0, 3)
        Me.pnlConsultarVentas.Name = "pnlConsultarVentas"
        Me.pnlConsultarVentas.Size = New System.Drawing.Size(746, 462)
        Me.pnlConsultarVentas.TabIndex = 8
        Me.pnlConsultarVentas.VerticalScrollbarBarColor = True
        Me.pnlConsultarVentas.VerticalScrollbarHighlightOnWheel = False
        Me.pnlConsultarVentas.VerticalScrollbarSize = 10
        Me.pnlConsultarVentas.Visible = False
        '
        'btnVolverConsultaVentas
        '
        Me.btnVolverConsultaVentas.Location = New System.Drawing.Point(22, 402)
        Me.btnVolverConsultaVentas.Name = "btnVolverConsultaVentas"
        Me.btnVolverConsultaVentas.Size = New System.Drawing.Size(123, 36)
        Me.btnVolverConsultaVentas.TabIndex = 10
        Me.btnVolverConsultaVentas.Text = "Volver"
        Me.btnVolverConsultaVentas.UseSelectable = True
        '
        'grpConsultaIngresos
        '
        Me.grpConsultaIngresos.BackColor = System.Drawing.SystemColors.Window
        Me.grpConsultaIngresos.Controls.Add(Me.ingresosConsulta_dg)
        Me.grpConsultaIngresos.Controls.Add(Me.lblIngresos)
        Me.grpConsultaIngresos.Location = New System.Drawing.Point(22, 252)
        Me.grpConsultaIngresos.Name = "grpConsultaIngresos"
        Me.grpConsultaIngresos.Size = New System.Drawing.Size(678, 124)
        Me.grpConsultaIngresos.TabIndex = 105
        Me.grpConsultaIngresos.TabStop = False
        '
        'ingresosConsulta_dg
        '
        Me.ingresosConsulta_dg.AllowUserToAddRows = False
        Me.ingresosConsulta_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ingresosConsulta_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreUsuarioIngresos, Me.IngresosConsulta, Me.periodoIngresos})
        Me.ingresosConsulta_dg.Location = New System.Drawing.Point(14, 16)
        Me.ingresosConsulta_dg.Name = "ingresosConsulta_dg"
        Me.ingresosConsulta_dg.RowHeadersVisible = False
        Me.ingresosConsulta_dg.Size = New System.Drawing.Size(651, 100)
        Me.ingresosConsulta_dg.TabIndex = 108
        '
        'nombreUsuarioIngresos
        '
        Me.nombreUsuarioIngresos.HeaderText = "Nombre Usuario"
        Me.nombreUsuarioIngresos.Name = "nombreUsuarioIngresos"
        Me.nombreUsuarioIngresos.Width = 250
        '
        'IngresosConsulta
        '
        Me.IngresosConsulta.HeaderText = "Total de Ingresos"
        Me.IngresosConsulta.Name = "IngresosConsulta"
        Me.IngresosConsulta.Width = 150
        '
        'periodoIngresos
        '
        Me.periodoIngresos.HeaderText = "Periodo"
        Me.periodoIngresos.Name = "periodoIngresos"
        Me.periodoIngresos.Width = 250
        '
        'lblIngresos
        '
        Me.lblIngresos.AutoSize = True
        Me.lblIngresos.Location = New System.Drawing.Point(9, -4)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(100, 19)
        Me.lblIngresos.TabIndex = 107
        Me.lblIngresos.Text = "Ingresos Totales"
        '
        'grpConsultaVentas
        '
        Me.grpConsultaVentas.BackColor = System.Drawing.SystemColors.Window
        Me.grpConsultaVentas.Controls.Add(Me.ventasConsulta_dg)
        Me.grpConsultaVentas.Controls.Add(Me.lblVentas)
        Me.grpConsultaVentas.Location = New System.Drawing.Point(22, 113)
        Me.grpConsultaVentas.Name = "grpConsultaVentas"
        Me.grpConsultaVentas.Size = New System.Drawing.Size(678, 124)
        Me.grpConsultaVentas.TabIndex = 104
        Me.grpConsultaVentas.TabStop = False
        '
        'ventasConsulta_dg
        '
        Me.ventasConsulta_dg.AllowUserToAddRows = False
        Me.ventasConsulta_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ventasConsulta_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idConsultaVentas, Me.nombreUsuarioConsultaVenta, Me.cantidadVentasConsulta, Me.periodoConsultaVentas})
        Me.ventasConsulta_dg.Location = New System.Drawing.Point(15, 17)
        Me.ventasConsulta_dg.Name = "ventasConsulta_dg"
        Me.ventasConsulta_dg.RowHeadersVisible = False
        Me.ventasConsulta_dg.Size = New System.Drawing.Size(651, 100)
        Me.ventasConsulta_dg.TabIndex = 106
        '
        'idConsultaVentas
        '
        Me.idConsultaVentas.HeaderText = "Id"
        Me.idConsultaVentas.Name = "idConsultaVentas"
        Me.idConsultaVentas.Visible = False
        '
        'nombreUsuarioConsultaVenta
        '
        Me.nombreUsuarioConsultaVenta.HeaderText = "Nombre Usuario"
        Me.nombreUsuarioConsultaVenta.Name = "nombreUsuarioConsultaVenta"
        Me.nombreUsuarioConsultaVenta.Width = 250
        '
        'cantidadVentasConsulta
        '
        Me.cantidadVentasConsulta.HeaderText = "Cantidad de Ventas"
        Me.cantidadVentasConsulta.Name = "cantidadVentasConsulta"
        Me.cantidadVentasConsulta.Width = 150
        '
        'periodoConsultaVentas
        '
        Me.periodoConsultaVentas.HeaderText = "Periodo"
        Me.periodoConsultaVentas.Name = "periodoConsultaVentas"
        Me.periodoConsultaVentas.Width = 250
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Location = New System.Drawing.Point(9, -3)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(122, 19)
        Me.lblVentas.TabIndex = 106
        Me.lblVentas.Text = "Cantidad de Ventas"
        '
        'periodos_cmb
        '
        Me.periodos_cmb.FormattingEnabled = True
        Me.periodos_cmb.ItemHeight = 13
        Me.periodos_cmb.Location = New System.Drawing.Point(518, 62)
        Me.periodos_cmb.Name = "periodos_cmb"
        Me.periodos_cmb.Size = New System.Drawing.Size(182, 21)
        Me.periodos_cmb.TabIndex = 103
        '
        'lblPeriodoConsultarVenta
        '
        Me.lblPeriodoConsultarVenta.AutoSize = True
        Me.lblPeriodoConsultarVenta.Location = New System.Drawing.Point(457, 62)
        Me.lblPeriodoConsultarVenta.Name = "lblPeriodoConsultarVenta"
        Me.lblPeriodoConsultarVenta.Size = New System.Drawing.Size(55, 19)
        Me.lblPeriodoConsultarVenta.TabIndex = 102
        Me.lblPeriodoConsultarVenta.Text = "Periodo"
        '
        'usuarioConsulta_cmb
        '
        Me.usuarioConsulta_cmb.FormattingEnabled = True
        Me.usuarioConsulta_cmb.ItemHeight = 13
        Me.usuarioConsulta_cmb.Location = New System.Drawing.Point(81, 60)
        Me.usuarioConsulta_cmb.Name = "usuarioConsulta_cmb"
        Me.usuarioConsulta_cmb.Size = New System.Drawing.Size(182, 21)
        Me.usuarioConsulta_cmb.TabIndex = 96
        '
        'lblUsuarioConsultarVenta
        '
        Me.lblUsuarioConsultarVenta.AutoSize = True
        Me.lblUsuarioConsultarVenta.Location = New System.Drawing.Point(22, 62)
        Me.lblUsuarioConsultarVenta.Name = "lblUsuarioConsultarVenta"
        Me.lblUsuarioConsultarVenta.Size = New System.Drawing.Size(53, 19)
        Me.lblUsuarioConsultarVenta.TabIndex = 87
        Me.lblUsuarioConsultarVenta.Text = "Usuario"
        '
        'lblConsultarVentas
        '
        Me.lblConsultarVentas.AutoSize = True
        Me.lblConsultarVentas.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblConsultarVentas.Location = New System.Drawing.Point(22, 16)
        Me.lblConsultarVentas.Name = "lblConsultarVentas"
        Me.lblConsultarVentas.Size = New System.Drawing.Size(220, 25)
        Me.lblConsultarVentas.TabIndex = 86
        Me.lblConsultarVentas.Text = "Consultar Ventas e Ingresos"
        '
        'pnlListarVentas
        '
        Me.pnlListarVentas.Controls.Add(Me.btnVolverListarVenta)
        Me.pnlListarVentas.Controls.Add(Me.dgListaVentas)
        Me.pnlListarVentas.Controls.Add(Me.lblListaVentas)
        Me.pnlListarVentas.Controls.Add(Me.btnNuevaVenta)
        Me.pnlListarVentas.HorizontalScrollbarBarColor = True
        Me.pnlListarVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlListarVentas.HorizontalScrollbarSize = 10
        Me.pnlListarVentas.Location = New System.Drawing.Point(0, 3)
        Me.pnlListarVentas.Name = "pnlListarVentas"
        Me.pnlListarVentas.Size = New System.Drawing.Size(767, 461)
        Me.pnlListarVentas.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnlListarVentas.TabIndex = 89
        Me.pnlListarVentas.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlListarVentas.VerticalScrollbarBarColor = True
        Me.pnlListarVentas.VerticalScrollbarHighlightOnWheel = False
        Me.pnlListarVentas.VerticalScrollbarSize = 10
        Me.pnlListarVentas.Visible = False
        '
        'btnVolverListarVenta
        '
        Me.btnVolverListarVenta.Location = New System.Drawing.Point(7, 412)
        Me.btnVolverListarVenta.Name = "btnVolverListarVenta"
        Me.btnVolverListarVenta.Size = New System.Drawing.Size(123, 36)
        Me.btnVolverListarVenta.TabIndex = 50
        Me.btnVolverListarVenta.Text = "Volver"
        Me.btnVolverListarVenta.UseSelectable = True
        '
        'dgListaVentas
        '
        Me.dgListaVentas.AllowUserToAddRows = False
        Me.dgListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idListarVentas, Me.fechaVenta, Me.nombreVendedor, Me.totalVenta, Me.tipoVenta, Me.editarVenta})
        Me.dgListaVentas.Location = New System.Drawing.Point(7, 37)
        Me.dgListaVentas.Name = "dgListaVentas"
        Me.dgListaVentas.RowHeadersVisible = False
        Me.dgListaVentas.Size = New System.Drawing.Size(739, 344)
        Me.dgListaVentas.TabIndex = 12
        '
        'idListarVentas
        '
        Me.idListarVentas.HeaderText = "Id"
        Me.idListarVentas.Name = "idListarVentas"
        Me.idListarVentas.Visible = False
        '
        'fechaVenta
        '
        Me.fechaVenta.HeaderText = "Fecha"
        Me.fechaVenta.Name = "fechaVenta"
        '
        'nombreVendedor
        '
        Me.nombreVendedor.HeaderText = "Nombre"
        Me.nombreVendedor.Name = "nombreVendedor"
        '
        'totalVenta
        '
        Me.totalVenta.HeaderText = "Venta Total"
        Me.totalVenta.Name = "totalVenta"
        '
        'tipoVenta
        '
        Me.tipoVenta.HeaderText = "Tipo"
        Me.tipoVenta.Name = "tipoVenta"
        '
        'editarVenta
        '
        Me.editarVenta.HeaderText = ""
        Me.editarVenta.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.editarVenta.Name = "editarVenta"
        Me.editarVenta.Width = 500
        '
        'lblListaVentas
        '
        Me.lblListaVentas.AutoSize = True
        Me.lblListaVentas.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaVentas.Location = New System.Drawing.Point(2, 3)
        Me.lblListaVentas.Name = "lblListaVentas"
        Me.lblListaVentas.Size = New System.Drawing.Size(105, 25)
        Me.lblListaVentas.TabIndex = 10
        Me.lblListaVentas.Text = "Listar Ventas"
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Location = New System.Drawing.Point(623, 412)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(123, 36)
        Me.btnNuevaVenta.TabIndex = 9
        Me.btnNuevaVenta.Text = "Nueva Venta"
        Me.btnNuevaVenta.UseSelectable = True
        '
        'btnListarVentasIcon
        '
        Me.btnListarVentasIcon.ActiveControl = Nothing
        Me.btnListarVentasIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListarVentasIcon.Location = New System.Drawing.Point(307, 27)
        Me.btnListarVentasIcon.Name = "btnListarVentasIcon"
        Me.btnListarVentasIcon.Size = New System.Drawing.Size(124, 119)
        Me.btnListarVentasIcon.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnListarVentasIcon.TabIndex = 8
        Me.btnListarVentasIcon.Text = "Listar"
        Me.btnListarVentasIcon.UseSelectable = True
        '
        'btnRegistrarVentaIcon
        '
        Me.btnRegistrarVentaIcon.ActiveControl = Nothing
        Me.btnRegistrarVentaIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarVentaIcon.Location = New System.Drawing.Point(165, 27)
        Me.btnRegistrarVentaIcon.Name = "btnRegistrarVentaIcon"
        Me.btnRegistrarVentaIcon.Size = New System.Drawing.Size(124, 119)
        Me.btnRegistrarVentaIcon.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnRegistrarVentaIcon.TabIndex = 7
        Me.btnRegistrarVentaIcon.Text = "Registrar"
        Me.btnRegistrarVentaIcon.UseSelectable = True
        '
        'btnConsultarVentasIcon
        '
        Me.btnConsultarVentasIcon.ActiveControl = Nothing
        Me.btnConsultarVentasIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultarVentasIcon.Location = New System.Drawing.Point(24, 27)
        Me.btnConsultarVentasIcon.Name = "btnConsultarVentasIcon"
        Me.btnConsultarVentasIcon.Size = New System.Drawing.Size(124, 119)
        Me.btnConsultarVentasIcon.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnConsultarVentasIcon.TabIndex = 6
        Me.btnConsultarVentasIcon.Text = "Consultar"
        Me.btnConsultarVentasIcon.UseSelectable = True
        '
        'TabReportes
        '
        Me.TabReportes.HorizontalScrollbarBarColor = True
        Me.TabReportes.HorizontalScrollbarHighlightOnWheel = False
        Me.TabReportes.HorizontalScrollbarSize = 10
        Me.TabReportes.Location = New System.Drawing.Point(4, 44)
        Me.TabReportes.Name = "TabReportes"
        Me.TabReportes.Size = New System.Drawing.Size(752, 472)
        Me.TabReportes.TabIndex = 5
        Me.TabReportes.Text = "Reportes"
        Me.TabReportes.VerticalScrollbarBarColor = True
        Me.TabReportes.VerticalScrollbarHighlightOnWheel = False
        Me.TabReportes.VerticalScrollbarSize = 10
        '
        'IdActi
        '
        Me.IdActi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdActi.HeaderText = "ID"
        Me.IdActi.Name = "IdActi"
        Me.IdActi.ReadOnly = True
        Me.IdActi.Visible = False
        '
        'nombreActi
        '
        Me.nombreActi.HeaderText = "Nombre"
        Me.nombreActi.Name = "nombreActi"
        '
        'codigoActi
        '
        Me.codigoActi.HeaderText = "Codigo"
        Me.codigoActi.Name = "codigoActi"
        '
        'codigoCosto
        '
        Me.codigoCosto.HeaderText = "Costo"
        Me.codigoCosto.Name = "codigoCosto"
        '
        'horarioActi
        '
        Me.horarioActi.HeaderText = "Horario"
        Me.horarioActi.Name = "horarioActi"
        '
        'fechaInicioActi
        '
        Me.fechaInicioActi.HeaderText = "Fecha Inicio"
        Me.fechaInicioActi.Name = "fechaInicioActi"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'checkBoxTopProduto
        '
        Me.checkBoxTopProduto.AutoSize = True
        Me.checkBoxTopProduto.Location = New System.Drawing.Point(123, 62)
        Me.checkBoxTopProduto.Name = "checkBoxTopProduto"
        Me.checkBoxTopProduto.Size = New System.Drawing.Size(96, 15)
        Me.checkBoxTopProduto.TabIndex = 13
        Me.checkBoxTopProduto.Text = "Top Producto"
        Me.checkBoxTopProduto.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblCloseSession
        '
        Me.lblCloseSession.Location = New System.Drawing.Point(694, 25)
        Me.lblCloseSession.Name = "lblCloseSession"
        Me.lblCloseSession.Size = New System.Drawing.Size(82, 23)
        Me.lblCloseSession.TabIndex = 5
        Me.lblCloseSession.Text = "Cerrar sesion"
        Me.lblCloseSession.UseSelectable = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblCloseSession)
        Me.Controls.Add(Me.Main)
        Me.Name = "FrmMain"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Menu Principal"
        Me.Main.ResumeLayout(False)
        Me.TabProductos.ResumeLayout(False)
        Me.registrarActi_pnl.ResumeLayout(False)
        Me.registrarActi_pnl.PerformLayout()
        CType(Me.minsFin5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.horariosActi_grp.ResumeLayout(False)
        Me.horariosActi_grp.PerformLayout()
        Me.listaActis_pnl.ResumeLayout(False)
        Me.listaActis_pnl.PerformLayout()
        CType(Me.listaActis_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegistrarCarrera.ResumeLayout(False)
        Me.pnlRegistrarCarrera.PerformLayout()
        Me.pnlListaCarreras.ResumeLayout(False)
        Me.pnlListaCarreras.PerformLayout()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Eventos.ResumeLayout(False)
        Me.PanelListarEventos.ResumeLayout(False)
        Me.PanelListarEventos.PerformLayout()
        CType(Me.DataListarEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCrearEvento.ResumeLayout(False)
        Me.PanelCrearEvento.PerformLayout()
        Me.TabProspectos.ResumeLayout(False)
        Me.PnlNuevoProspecto.ResumeLayout(False)
        Me.PnlNuevoProspecto.PerformLayout()
        Me.PnlListaProspectos.ResumeLayout(False)
        Me.PnlListaProspectos.PerformLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSeguimientos.ResumeLayout(False)
        Me.pnlSeguimientos.PerformLayout()
        Me.PnlListaSeguimientos.ResumeLayout(False)
        Me.PnlListaSeguimientos.PerformLayout()
        CType(Me.lstSeguimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAsignarProspecto.ResumeLayout(False)
        Me.pnlAsignarProspecto.PerformLayout()
        Me.KPIHolder.ResumeLayout(False)
        Me.panSeleccionarTipoKPI.ResumeLayout(False)
        Me.pnlCrearKpiProducto.ResumeLayout(False)
        Me.pnlCrearKpiProducto.PerformLayout()
        Me.pnlKpiProspectos.ResumeLayout(False)
        Me.pnlKpiProspectos.PerformLayout()
        Me.panKpiVentas.ResumeLayout(False)
        Me.panKpiVentas.PerformLayout()
        Me.TabConfiguracion.ResumeLayout(False)
        Me.pnlUpdateUserInfo.ResumeLayout(False)
        Me.pnlUpdateUserInfo.PerformLayout()
        Me.TabUsuarios.ResumeLayout(False)
        Me.pnlCreateRol.ResumeLayout(False)
        Me.pnlCreateRol.PerformLayout()
        Me.gboPermissionsRol.ResumeLayout(False)
        Me.gboPermissionsRol.PerformLayout()
        Me.grpPermisosWeb.ResumeLayout(False)
        Me.grpPermisosWeb.PerformLayout()
        Me.gboPorductsSectionRol.ResumeLayout(False)
        Me.gboPorductsSectionRol.PerformLayout()
        Me.pnlCreateUser.ResumeLayout(False)
        Me.pnlCreateUser.PerformLayout()
        Me.pnListUsers.ResumeLayout(False)
        Me.pnListUsers.PerformLayout()
        CType(Me.lstUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlListRols.ResumeLayout(False)
        Me.pnlListRols.PerformLayout()
        CType(Me.lstListRols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVentas.ResumeLayout(False)
        Me.pnlRegistrarVenta.ResumeLayout(False)
        Me.pnlRegistrarVenta.PerformLayout()
        Me.pnlConsultarVentas.ResumeLayout(False)
        Me.pnlConsultarVentas.PerformLayout()
        Me.grpConsultaIngresos.ResumeLayout(False)
        Me.grpConsultaIngresos.PerformLayout()
        CType(Me.ingresosConsulta_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsultaVentas.ResumeLayout(False)
        Me.grpConsultaVentas.PerformLayout()
        CType(Me.ventasConsulta_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlListarVentas.ResumeLayout(False)
        Me.pnlListarVentas.PerformLayout()
        CType(Me.dgListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Main As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabProductos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnCarrerasIcon As MetroFramework.Controls.MetroTile
    Friend WithEvents TabUsuarios As MetroFramework.Controls.MetroTabPage
    Friend WithEvents KPIHolder As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabReportes As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabProspectos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Eventos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabConfiguracion As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnActiIco As MetroFramework.Controls.MetroTile
    Friend WithEvents TabVentas As MetroFramework.Controls.MetroTabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PanelCrearEvento As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblFechaInicio As MetroFramework.Controls.MetroLabel
    Friend WithEvents dateEventos As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TxtnombreEventos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblLugar As MetroFramework.Controls.MetroLabel
    Friend WithEvents EventosLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents PanelListarEventos As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblEventos As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataListarEventos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCrearEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents dateFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblFechaFin As MetroFramework.Controls.MetroLabel
    Friend WithEvents panSeleccionarTipoKPI As MetroFramework.Controls.MetroPanel
    Friend WithEvents TileKpiVentas As MetroFramework.Controls.MetroTile
    Friend WithEvents TileKpiProductos As MetroFramework.Controls.MetroTile
    Friend WithEvents TileKpiProspecto As MetroFramework.Controls.MetroTile
    Friend WithEvents panKpiVentas As MetroFramework.Controls.MetroPanel
    Friend WithEvents checkBoxTotalVentas As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents crearKPIVentas As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkBoxMontoTotalVentas As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnCrearKpiVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarKpiVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlKpiProspectos As MetroFramework.Controls.MetroPanel
    Friend WithEvents checkboxTotalProspetosCliente As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkBoxTotalProspectos As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblCrearKpiProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelarKpiProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnGenerarKpiProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlCrearKpiProducto As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblCrearKpiProducto As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkBoxTotalProducto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnCancelarKpiProducto As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCrearKpiProducto As MetroFramework.Controls.MetroButton
    Friend WithEvents TextBoxResultadoKpiProductos As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxResultadosVentas As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxResultadosKpiProspectos As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents checkBoxTopProduto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PnlListaProspectos As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnAsignarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents lblListaProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCrearProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents lstProspectos As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnaIDProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaNombreProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaApellidosProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaNacimientoProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaProcedenciaProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTelefonoProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEmailProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEditarProspecto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PnlNuevoProspecto As MetroFramework.Controls.MetroPanel
    Friend WithEvents cbEventos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ckbEventoProspecto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblInteres As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbInteresesProspecto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnListarSeguimientos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevoSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFechaNacProspecto As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDireccionProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProcedenciaProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmailProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApellidosProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombreProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents tglEstaInteresado As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblInteresadoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProcedenciaProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDireccionProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents tglEstadoProspecto As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblTelefonoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEstadoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblApellidosProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFechaProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCorreoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNombreProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCrearProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblClienteProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents tglEsCliente As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblIdSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIdProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlAsignarProspecto As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnQuitarProspAsignado As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarAsignarProsp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarAsignarProsp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAsignarListaProsp As MetroFramework.Controls.MetroButton
    Friend WithEvents ltbProspAsignados As System.Windows.Forms.ListBox
    Friend WithEvents lblProspAsignados As MetroFramework.Controls.MetroLabel
    Friend WithEvents ltbProspectosSlt As System.Windows.Forms.ListBox
    Friend WithEvents ltbVendedoresSlt As System.Windows.Forms.ListBox
    Friend WithEvents lblProspectosSlt As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblVendedoresSlt As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAsignarProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents PnlListaSeguimientos As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnCancelarListaSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents lstSeguimientos As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnaIDSeguimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaFechaSeguimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaComentarioSeguimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEditarSeguimiento As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColumnaEliminarSeguimiento As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblListaSeguimientos As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlSeguimientos As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtComentarioSeguimiento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelarSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents lblComentarioSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFechaSeguimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblFechaSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCrearSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaActis_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents exportarActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents vovlerActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents listaActis_dg As System.Windows.Forms.DataGridView
    Friend WithEvents IdActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horarioActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaInicioActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents listaActis_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevoActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents registrarActi_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents fechaInicio_dp As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaInicioCurso As MetroFramework.Controls.MetroLabel
    Friend WithEvents cancelarAct_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents guardarAct_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents importarActis_lbl As MetroFramework.Controls.MetroLink
    Friend WithEvents minsFinActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaFinActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsFin5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIniActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaIniActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsIni5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents dia5Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia4Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia3Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia2Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia1Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents horaFin As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaIni As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia5_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia4Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia2Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia3Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia1Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoActi_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents costoActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nombreActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents codigoActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nombreActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents codigoActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horariosActi_grp As System.Windows.Forms.GroupBox
    Friend WithEvents lblCloseSession As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlListRols As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnBackRolsUsers As MetroFramework.Controls.MetroButton
    Friend WithEvents lblIdRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstListRols As System.Windows.Forms.DataGridView
    Friend WithEvents colIdListRols As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNameRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStateRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEditListRol As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblListOfRols As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNewRol As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlCreateRol As MetroFramework.Controls.MetroPanel
    Friend WithEvents gboPermissionsRol As System.Windows.Forms.GroupBox
    Friend WithEvents tgUsersRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblUsersRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents gboPorductsSectionRol As System.Windows.Forms.GroupBox
    Friend WithEvents lblActisRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCareersRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgCareersRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgActiRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblProductsSectionRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgConfigurationRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgReportsRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgKpiRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgEventsRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgProspectusRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgSalesRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblConfigurationRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblReportsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblKpiRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEventsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProspectusRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSalesRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPermissionsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgEnabledRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtRolName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelRol As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveRol As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEnabledRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCreateRolTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnListUsers As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblCreateUpdateUserId As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstUsers As System.Windows.Forms.DataGridView
    Friend WithEvents lblRolsSection As MetroFramework.Controls.MetroLink
    Friend WithEvents lblListOfUsersTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents colIdLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents identificationLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userNameLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userLastNameLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userPhoneLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userEmailLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userStateLstUsers As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userEditLstUsers As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlCreateUser As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblPasswordUserBackup As System.Windows.Forms.Label
    Friend WithEvents chkChangeUserPassword As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cboDateCreateUser As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblDateCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmailCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLastNameCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboRolCreateUser As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tgEnableCreateUser As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblRolCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEnabledCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPhoneCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPasswordCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNameCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPaswordCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhoneCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastNameCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCedulaCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCreateUserTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents tileChangeInformation As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlUpdateUserInfo As MetroFramework.Controls.MetroPanel
    Friend WithEvents tgChangePassUpdateUserInfo As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtPasswordUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCheckPasswordUpdate As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNewPassUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNewpassUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDateUpdateUserInfo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblDateUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmailUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLastNameUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhoneUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNameUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelUpdateUserInfo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveUpdateUserInfo As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPasswordUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhoneUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastNameUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIdUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblChangePasswordTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlRegistrarCarrera As MetroFramework.Controls.MetroPanel
    Friend WithEvents tipoCarrera_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents codigoCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTipoCarrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCodigoCarrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblImportarCarrera As MetroFramework.Controls.MetroLink
    Friend WithEvents nombreCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNombreActi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRegistrarCarrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCostoActi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHorarioActi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCostoCarrera As MetroFramework.Controls.MetroLabel
    Friend WithEvents costoCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardarCarrera As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarCarrera As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlListaCarreras As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnExportar_Carreras As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVolver_Carrera As MetroFramework.Controls.MetroButton
    Friend WithEvents listaCarreras_dg As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaCrreras As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNueva_Carrera As MetroFramework.Controls.MetroButton
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEvento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnConsultarVentasIcon As MetroFramework.Controls.MetroTile
    Friend WithEvents btnListarVentasIcon As MetroFramework.Controls.MetroTile
    Friend WithEvents btnRegistrarVentaIcon As MetroFramework.Controls.MetroTile
    Friend WithEvents pnlListarVentas As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnVolverListarVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents dgListaVentas As System.Windows.Forms.DataGridView
    Friend WithEvents lblListaVentas As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevaVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlRegistrarVenta As MetroFramework.Controls.MetroPanel
    Friend WithEvents cod_prod_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelarVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents lblCostoVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents costoVenta_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardarVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTipoVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProductoVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCodProductoVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRegistrarVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents productos_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents tipo_prodVenta_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMatriculaVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents matricula_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents totalVenta_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents id_carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo_carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editarCarrera As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colIdActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigoActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCostoActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHorarioActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicioActi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editarActi As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents idListarVentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editarVenta As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents pnlConsultarVentas As MetroFramework.Controls.MetroPanel
    Friend WithEvents periodos_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriodoConsultarVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents usuarioConsulta_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsuarioConsultarVenta As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblConsultarVentas As MetroFramework.Controls.MetroLabel
    Friend WithEvents grpConsultaIngresos As System.Windows.Forms.GroupBox
    Friend WithEvents grpConsultaVentas As System.Windows.Forms.GroupBox
    Friend WithEvents lblIngresos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblVentas As MetroFramework.Controls.MetroLabel
    Friend WithEvents ventasConsulta_dg As System.Windows.Forms.DataGridView
    Friend WithEvents ingresosConsulta_dg As System.Windows.Forms.DataGridView
    Friend WithEvents idConsultaVentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreUsuarioConsultaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadVentasConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodoConsultaVentas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreUsuarioIngresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngresosConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodoIngresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVolverConsultaVentas As MetroFramework.Controls.MetroButton
    Friend WithEvents lblImportarProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblImportEstudiantes As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblImportProfesores As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgEvaluacionesRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblEvaluations As MetroFramework.Controls.MetroLabel
    Friend WithEvents grpPermisosWeb As System.Windows.Forms.GroupBox
    Friend WithEvents lblPermisosWeb As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPregunntas As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgPreguntasRol As MetroFramework.Controls.MetroToggle
End Class
