Imports PresentasionWindowsForms.My.Resources

Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Login</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSignUpLogin_Click(sender As Object, e As EventArgs) Handles btnSignUpLogin.Click
        Dim user As UserModel = Users_controller.login(txtEmailLogin.Text, txtPasswordLogin.Text)
        If (Not user Is Nothing) Then
            Dim main As New FrmMain(user)
            If (user.rol.activo) Then
                If user.activo Then
                    For Each permiso As PermissionModel In user.rol.permisos
                        Select Case permiso.nombre
                            Case "actis"
                                main.btnActiIco.Visible = True
                            Case "carreras"
                                main.btnCarrerasIcon.Visible = True
                            Case "ventas"
                                main.Main.TabPages.Add(main.TabVentas)
                            Case "prospectos"
                                main.Main.TabPages.Add(main.TabProspectos)
                            Case "usuarios"
                                main.Main.TabPages.Add(main.TabUsuarios)
                            Case "eventos"
                                main.Main.TabPages.Add(main.Eventos)
                            Case "kpis"
                                main.Main.TabPages.Add(main.KPIHolder)
                            Case "reportes"
                                main.Main.TabPages.Add(main.TabReportes)
                            Case "configuracion"
                                main.Main.TabPages.Add(main.TabConfiguracion)
                        End Select
                        If ((main.btnActiIco.Visible) Or (main.btnCarrerasIcon.Visible)) Then
                            main.Main.TabPages.Add(main.TabProductos)
                        End If
                    Next
                    Me.Hide()
                    main.ShowDialog()
                    Me.Close()
                Else
                    ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.INACTIVE_USER)
                End If
            Else
                ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.INACTIVE_ROL)
            End If
        Else
            ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.USER_NOT_EXIST)
        End If
    End Sub
End Class