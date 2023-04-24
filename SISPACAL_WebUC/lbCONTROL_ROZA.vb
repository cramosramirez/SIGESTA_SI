Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbCONTROL_ROZA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla CONTROL_ROZA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/11/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_CONTROL_ROZA"), ToolboxData("<{0}:lbCONTROL_ROZA runat=server></{0}:lbCONTROL_ROZA>")> _
Public Class lbCONTROL_ROZA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla CONTROL_ROZA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cCONTROL_ROZA
        Dim Lista As New ListaCONTROL_ROZA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DIAZAFRA"
        Me.DataValueField = "ID_CONTROL_ROZA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZAFRA .
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZAFRA(ByVal ID_ZAFRA As Int32)
        Dim miComponente As New cCONTROL_ROZA
        Dim Lista As New ListaCONTROL_ROZA

        Lista = miComponente.ObtenerListaPorZAFRA(ID_ZAFRA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DIAZAFRA"
        Me.DataValueField = "ID_CONTROL_ROZA"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LOTES .
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/11/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLOTES(ByVal ACCESLOTE As String)
        Dim miComponente As New cCONTROL_ROZA
        Dim Lista As New ListaCONTROL_ROZA

        Lista = miComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DIAZAFRA"
        Me.DataValueField = "ID_CONTROL_ROZA"

        Me.DataBind()

    End Sub

End Class
