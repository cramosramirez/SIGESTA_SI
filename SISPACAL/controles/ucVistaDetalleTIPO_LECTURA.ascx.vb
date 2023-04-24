﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleTIPO_LECTURA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla TIPO_LECTURA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleTIPO_LECTURA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_TIPO_LECTURA As Int32
    Public Property ID_TIPO_LECTURA() As Int32
        Get
            Return Me.txtID_TIPO_LECTURA.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_TIPO_LECTURA = Value
            Me.txtID_TIPO_LECTURA.Text = CStr(Value)
            If Me._ID_TIPO_LECTURA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_TIPO_LECTURA() As String
        Get
            Return Me.txtNOMBRE_TIPO_LECTURA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_TIPO_LECTURA.Text = value.ToString()
        End Set
    End Property

    Public Property ID_EQUIPO() As Int32
        Get
            Return Me.ddlEQUIPO_MEDICIONID_EQUIPO.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlEQUIPO_MEDICIONID_EQUIPO.Items.FindByValue(value) Is Nothing Then
                Me.ddlEQUIPO_MEDICIONID_EQUIPO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property USUARIO_CREA() As String
        Get
            Return Me.txtUSUARIO_CREA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREA() As DateTime
        Get
            Return Me.txtFECHA_CREA.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_CREA.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property USUARIO_ACT() As String
        Get
            Return Me.txtUSUARIO_ACT.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_ACT.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_ACT() As DateTime
        Get
            Return Me.txtFECHA_ACT.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_ACT.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property VerID_TIPO_LECTURA() As Boolean
        Get
            Return Me.trID_TIPO_LECTURA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_LECTURA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_TIPO_LECTURA() As Boolean
        Get
            Return Me.trNOMBRE_TIPO_LECTURA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_TIPO_LECTURA.Visible = value
        End Set
    End Property

    Public Property VerID_EQUIPO() As Boolean
        Get
            Return Me.trID_EQUIPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EQUIPO.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.trUSUARIO_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.trFECHA_CREA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.trUSUARIO_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_ACT.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.trFECHA_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACT.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cTIPO_LECTURA
    Private mEntidad As TIPO_LECTURA
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_TIPO_LECTURA") Is Nothing Then Me._ID_TIPO_LECTURA = Me.ViewState("ID_TIPO_LECTURA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla TIPO_LECTURA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New TIPO_LECTURA
        mEntidad.ID_TIPO_LECTURA = ID_TIPO_LECTURA
 
        If mComponente.ObtenerTIPO_LECTURA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_TIPO_LECTURA.Text = mEntidad.ID_TIPO_LECTURA.ToString()
        Me.txtNOMBRE_TIPO_LECTURA.Text = mEntidad.NOMBRE_TIPO_LECTURA
        Me.ddlEQUIPO_MEDICIONID_EQUIPO.Recuperar()
        Me.ddlEQUIPO_MEDICIONID_EQUIPO.SelectedValue = mEntidad.ID_EQUIPO
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.txtFECHA_CREA.Text = IIf(Not mEntidad.FECHA_CREA = Nothing, Format(mEntidad.FECHA_CREA, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.txtFECHA_ACT.Text = IIf(Not mEntidad.FECHA_ACT = Nothing, Format(mEntidad.FECHA_ACT, "dd/MM/yyyy"), "")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlEQUIPO_MEDICIONID_EQUIPO.Enabled = edicion
        Me.txtNOMBRE_TIPO_LECTURA.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.txtFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.txtFECHA_ACT.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlEQUIPO_MEDICIONID_EQUIPO.Recuperar()
        Me.txtNOMBRE_TIPO_LECTURA.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla TIPO_LECTURA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	18/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New TIPO_LECTURA
        If Me._nuevo Then
            mEntidad.ID_TIPO_LECTURA = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad.ID_TIPO_LECTURA = CInt(Me.txtID_TIPO_LECTURA.Text)
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.NOMBRE_TIPO_LECTURA = Me.txtNOMBRE_TIPO_LECTURA.Text
        mEntidad.ID_EQUIPO = Me.ddlEQUIPO_MEDICIONID_EQUIPO.SelectedValue

        If mComponente.ActualizarTIPO_LECTURA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_TIPO_LECTURA.Text = mEntidad.ID_TIPO_LECTURA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
