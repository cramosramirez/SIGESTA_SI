Imports System.ComponentModel
Imports System.Web.UI

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL_WebUC
''' Class	 : WebUC.lbLABFAB_INFOVAR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista de Seleccion Web
''' de la tabla LABFAB_INFOVAR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
<DefaultProperty("ID_INFOVAR"), ToolboxData("<{0}:lbLABFAB_INFOVAR runat=server></{0}:lbLABFAB_INFOVAR>")> _
Public Class lbLABFAB_INFOVAR
    Inherits lbBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera el ListBox con los Datos de la Tabla LABFAB_INFOVAR.
    ''' </summary>
    ''' <remarks>
    ''' Si la tabla es de llave compuesta, recibe los parametros de la Tabla Padre
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        Dim miComponente As New cLABFAB_INFOVAR
        Dim Lista As New ListaLABFAB_INFOVAR

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_INFOVAR"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LABFAB_INFORME .
    ''' </summary>
    ''' <param name="ID_INFO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLABFAB_INFORME(ByVal ID_INFO As Int32)
        Dim miComponente As New cLABFAB_INFOVAR
        Dim Lista As New ListaLABFAB_INFOVAR

        Lista = miComponente.ObtenerListaPorLABFAB_INFORME(ID_INFO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_INFOVAR"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LABFAB_TIPOVAR .
    ''' </summary>
    ''' <param name="ID_TIPOVAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLABFAB_TIPOVAR(ByVal ID_TIPOVAR As Int32)
        Dim miComponente As New cLABFAB_INFOVAR
        Dim Lista As New ListaLABFAB_INFOVAR

        Lista = miComponente.ObtenerListaPorLABFAB_TIPOVAR(ID_TIPOVAR)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_INFOVAR"

        Me.DataBind()

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla LABFAB_CATEGORIA .
    ''' </summary>
    ''' <param name="ID_CATEG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorLABFAB_CATEGORIA(ByVal ID_CATEG As Int32)
        Dim miComponente As New cLABFAB_INFOVAR
        Dim Lista As New ListaLABFAB_INFOVAR

        Lista = miComponente.ObtenerListaPorLABFAB_CATEGORIA(ID_CATEG)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "ORDEN"
        Me.DataValueField = "ID_INFOVAR"

        Me.DataBind()

    End Sub

End Class
