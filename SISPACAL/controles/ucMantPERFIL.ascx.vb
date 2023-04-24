﻿Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPERFIL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PERFIL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPERFIL
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PERFIL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
       Me.AsignarMensaje("", True, False)
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucListaPERFIL1.Visible = True
        Me.ucVistaDetallePERFIL1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PERFIL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucListaPERFIL1.Visible = False
        Me.UcVistaDetallePERFIL1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PERFIL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarPERFIL()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarPERFIL() As Integer
        If Me.ucListaPERFIL1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
            Me.InicializarLista()
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nuevo Perfil", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, IconoBarra.Cancelar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, IconoBarra.Guardar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub


    Protected Sub ucListaPERFIL1_Editando(ByVal ID_PERFIL As Int32) Handles ucListaPERFIL1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetallePERFIL1.ID_PERFIL = ID_PERFIL
    End Sub

    Private Sub ucVistaDetallePERFIL1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePERFIL1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Agregar"
                Me.InicializarDetalle()
                Me.ucVistaDetallePERFIL1.LimpiarControles()
                Me.ucVistaDetallePERFIL1.ID_PERFIL = 0

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetallePERFIL1.Actualizar()
                If sError <> "" Then
                    AsignarMensaje(sError, True, False)
                    Return
                End If
                AsignarMensaje("", True, False)
                Me.InicializarLista()
                Me.ucListaPERFIL1.DataBind()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
