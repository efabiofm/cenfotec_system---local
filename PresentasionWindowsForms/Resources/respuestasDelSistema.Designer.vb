﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class respuestasDelSistema
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PresentasionWindowsForms.respuestasDelSistema", GetType(respuestasDelSistema).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a No se pudo crear el rol!.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_ROL_ERROR() As String
            Get
                Return ResourceManager.GetString("CREATE_ROL_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Rol creado correctamente!.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_ROL_SUCCESS() As String
            Get
                Return ResourceManager.GetString("CREATE_ROL_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Hubo un error al crear el usuario.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_USER_ERROR() As String
            Get
                Return ResourceManager.GetString("CREATE_USER_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a El usuario ha sido creado exitosamente!.
        '''</summary>
        Friend Shared ReadOnly Property CREATE_USER_SUCCESS() As String
            Get
                Return ResourceManager.GetString("CREATE_USER_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a El usuario ha sido eliminado exitoxamente!.
        '''</summary>
        Friend Shared ReadOnly Property DELETE_USER_SUCCESS() As String
            Get
                Return ResourceManager.GetString("DELETE_USER_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a El usuario no existe en el sistema!.
        '''</summary>
        Friend Shared ReadOnly Property elUsuarioNoExiste() As String
            Get
                Return ResourceManager.GetString("elUsuarioNoExiste", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Tu rol se encuentra inactivo!.
        '''</summary>
        Friend Shared ReadOnly Property INACTIVE_ROL() As String
            Get
                Return ResourceManager.GetString("INACTIVE_ROL", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Tu usuario se encuentra inactivo en el sistema!.
        '''</summary>
        Friend Shared ReadOnly Property INACTIVE_USER() As String
            Get
                Return ResourceManager.GetString("INACTIVE_USER", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a No se pudieron cargar los datos!.
        '''</summary>
        Friend Shared ReadOnly Property POPULATE_FILLS_ERROR() As String
            Get
                Return ResourceManager.GetString("POPULATE_FILLS_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a No se ha podido actualizar el usuario!.
        '''</summary>
        Friend Shared ReadOnly Property UPDATE__USER_ERROR() As String
            Get
                Return ResourceManager.GetString("UPDATE__USER_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a No se ha podido actualizar el rol!.
        '''</summary>
        Friend Shared ReadOnly Property UPDATE_ROL_ERROR() As String
            Get
                Return ResourceManager.GetString("UPDATE_ROL_ERROR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Rol actualizado correctamente.
        '''</summary>
        Friend Shared ReadOnly Property UPDATE_ROL_SUCCESS() As String
            Get
                Return ResourceManager.GetString("UPDATE_ROL_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Usuario actualizado correctamente!.
        '''</summary>
        Friend Shared ReadOnly Property UPDATE_USER_SUCCESS() As String
            Get
                Return ResourceManager.GetString("UPDATE_USER_SUCCESS", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a Combinación de password y contraseña incorrectos.
        '''</summary>
        Friend Shared ReadOnly Property USER_NOT_EXIST() As String
            Get
                Return ResourceManager.GetString("USER_NOT_EXIST", resourceCulture)
            End Get
        End Property
    End Class
End Namespace