Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlUBICACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla UBICACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("CODIUBICACION"), ToolboxData("<{0}:ddlUBICACION runat=server></{0}:ddlUBICACION>")> _
Public Class ddlUBICACION
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cUBICACION
        Dim Lista As New ListaUBICACION

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DEPARTAMENTO"
        Me.DataValueField = "CODIUBICACION"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla UBICACION.
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
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla TARIFA .
    ''' </summary>
    ''' <param name="CODITARIFA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTARIFA(ByVal CODITARIFA As String)
        Dim miComponente As New cUBICACION
        Dim Lista As New ListaUBICACION

        Lista = miComponente.ObtenerListaPorTARIFA(CODITARIFA)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "DEPARTAMENTO"
        Me.DataValueField = "CODIUBICACION"

        Me.DataBind()

    End Sub

End Class
