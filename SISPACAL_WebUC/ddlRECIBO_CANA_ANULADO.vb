Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.ddlRECIBO_CANA_ANULADO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Web
''' de la tabla RECIBO_CANA_ANULADO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_RECIBO_CANA_ANUL"), ToolboxData("<{0}:ddlRECIBO_CANA_ANULADO runat=server></{0}:ddlRECIBO_CANA_ANULADO>")> _
Public Class ddlRECIBO_CANA_ANULADO
    Inherits ddlBase

    Private Sub RecuperarLista()
        Dim miComponente As New cRECIBO_CANA_ANULADO
        Dim Lista As New ListaRECIBO_CANA_ANULADO

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NUMRECIBO_CANA"
        Me.DataValueField = "ID_RECIBO_CANA_ANUL"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el DropDownList con los Datos de la Tabla RECIBO_CANA_ANULADO.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
