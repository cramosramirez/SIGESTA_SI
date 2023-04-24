Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbMOTORISTA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla MOTORISTA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_MOTORISTA"), ToolboxData("<{0}:lbMOTORISTA runat=server></{0}:lbMOTORISTA>")> _
Public Class lbMOTORISTA
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla MOTORISTA.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cMOTORISTA
        Dim Lista As New ListaMOTORISTA

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NIT"
        Me.DataValueField = "ID_MOTORISTA"

        Me.DataBind()
    End Sub

End Class
