﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantLABFAB_ANALISISXDIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla LABFAB_ANALISISXDIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/11/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantLABFAB_ANALISISXDIA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla LABFAB_ANALISISXDIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaLABFAB_ANALISISXDIA1.Visible = True
        Me.UcVistaDetalleLABFAB_ANALISISXDIA1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla LABFAB_ANALISISXDIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaLABFAB_ANALISISXDIA1.Visible = False
        Me.UcVistaDetalleLABFAB_ANALISISXDIA1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla LABFAB_ANALISISXDIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/11/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarLABFAB_ANALISISXDIA()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarLABFAB_ANALISISXDIA() As Integer
        If Me.ucListaLABFAB_ANALISISXDIA1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleLABFAB_ANALISISXDIA1.LimpiarControles()
        Me.ucVistaDetalleLABFAB_ANALISISXDIA1.ID_ANALISISXDIA = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleLABFAB_ANALISISXDIA1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaLABFAB_ANALISIS1_Editando(ByVal ID_ANALISISXDIA As Int32) Handles ucListaLABFAB_ANALISISXDIA1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleLABFAB_ANALISISXDIA1.ID_ANALISISXDIA = ID_ANALISISXDIA
    End Sub

    Private Sub ucVistaDetalleLABFAB_ANALISISXDIA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleLABFAB_ANALISISXDIA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
