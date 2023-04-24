﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantDISTRIBUCION_DESCTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla DISTRIBUCION_DESCTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantDISTRIBUCION_DESCTO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DISTRIBUCION_DESCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaDISTRIBUCION_DESCTO1.Visible = True
        Me.UcVistaDetalleDISTRIBUCION_DESCTO1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DISTRIBUCION_DESCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaDISTRIBUCION_DESCTO1.Visible = False
        Me.UcVistaDetalleDISTRIBUCION_DESCTO1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla DISTRIBUCION_DESCTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarDISTRIBUCION_DESCTO()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarDISTRIBUCION_DESCTO() As Integer
        If Me.ucListaDISTRIBUCION_DESCTO1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleDISTRIBUCION_DESCTO1.LimpiarControles()
        Me.ucVistaDetalleDISTRIBUCION_DESCTO1.ID_DISTRIB_DESCTO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleDISTRIBUCION_DESCTO1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaDISTRIBUCION_DESCTO1_Editando(ByVal ID_DISTRIB_DESCTO As Int32) Handles ucListaDISTRIBUCION_DESCTO1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleDISTRIBUCION_DESCTO1.ID_DISTRIB_DESCTO = ID_DISTRIB_DESCTO
    End Sub

    Private Sub ucVistaDetalleDISTRIBUCION_DESCTO1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleDISTRIBUCION_DESCTO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
