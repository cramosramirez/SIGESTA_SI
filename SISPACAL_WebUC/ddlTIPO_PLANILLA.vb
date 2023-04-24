Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlTIPO_PLANILLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla TIPO_PLANILLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_TIPO_PLANILLA"), ToolboxData("<{0}:ddlTIPO_PLANILLA runat=server></{0}:ddlTIPO_PLANILLA>")> _
Public Class ddlTIPO_PLANILLA
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cTIPO_PLANILLA
        Dim Lista As New ListaTIPO_PLANILLA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE_TIPO_PLANILLA"
        Me.DataValueField = "ID_TIPO_PLANILLA"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla TIPO_PLANILLA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
