﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantENVIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ENVIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantENVIO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaENVIO1.Visible = True
        Me.UcVistaDetalleENVIO1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaENVIO1.Visible = False
        Me.UcVistaDetalleENVIO1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ENVIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarENVIO()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarENVIO() As Integer
        If Me.ucListaENVIO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleENVIO1.LimpiarControles()
        Me.ucVistaDetalleENVIO1.ID_ENVIO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleENVIO1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaENVIO1_Editando(ByVal ID_ENVIO As Int32) Handles ucListaENVIO1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleENVIO1.ID_ENVIO = ID_ENVIO
    End Sub

    Private Sub ucVistaDetalleENVIO1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleENVIO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
