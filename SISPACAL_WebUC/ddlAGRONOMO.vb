Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlAGRONOMO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla AGRONOMO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CODIAGRON"), ToolboxData("<{0}:ddlAGRONOMO runat=server></{0}:ddlAGRONOMO>")> _
Public Class ddlAGRONOMO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cAGRONOMO
        Dim Lista As New ListaAGRONOMO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "APELLIDO_AGRONOMO"
        Me.DataValueField = "CODIAGRON"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla AGRONOMO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla ZONAS .
    ''' </summary>
    ''' <param name="ZONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorZONAS(ByVal ZONA As String)
        Dim miComponente As New cAGRONOMO
        Dim Lista As New ListaAGRONOMO

        Lista = miComponente.ObtenerListaPorZONAS(ZONA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "APELLIDO_AGRONOMO"
        Me.DataValueField = "CODIAGRON"

        Me.DataBind()

    End Sub

End Class
