﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePLAN_SEMANAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PLAN_SEMANAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePLAN_SEMANAL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PLAN_SEMANAL As Int32
    Public Property ID_PLAN_SEMANAL() As Int32
        Get
            Return Me.txtID_PLAN_SEMANAL.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PLAN_SEMANAL = Value
            Me.txtID_PLAN_SEMANAL.Text = CStr(Value)
            If Me._ID_PLAN_SEMANAL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_PLAN_CATORCENA() As Int32
        Get
            Return Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue
        End Get
        Set(ByVal value As Int32)
            If Not Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.Items.FindByValue(value) Is Nothing Then
                Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NO_SEMANA() As Int32
        Get
            If Me.txtNO_SEMANA.Text ="" Then Return -1
            Return CInt(Me.txtNO_SEMANA.Text)
        End Get
        Set(ByVal value As Int32)
            Me.txtNO_SEMANA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_INICIO() As DateTime
        Get
            Return Me.txtFECHA_INICIO.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_INICIO.Text = value.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property FECHA_FIN() As DateTime
        Get
            Return Me.txtFECHA_FIN.Text
        End Get
        Set(ByVal value As DateTime)
            Me.txtFECHA_FIN.Text = value.ToString("dd/MM/yyyy")
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

    Public Property VerID_PLAN_SEMANAL() As Boolean
        Get
            Return Me.trID_PLAN_SEMANAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_SEMANAL.Visible = value
        End Set
    End Property

    Public Property VerID_PLAN_CATORCENA() As Boolean
        Get
            Return Me.trID_PLAN_CATORCENA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PLAN_CATORCENA.Visible = value
        End Set
    End Property

    Public Property VerNO_SEMANA() As Boolean
        Get
            Return Me.trNO_SEMANA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_SEMANA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.trFECHA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FIN.Visible = value
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
    Private mComponente As New cPLAN_SEMANAL
    Private mEntidad As PLAN_SEMANAL
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
        If Not Me.ViewState("ID_PLAN_SEMANAL") Is Nothing Then Me._ID_PLAN_SEMANAL = Me.ViewState("ID_PLAN_SEMANAL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PLAN_SEMANAL
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PLAN_SEMANAL
        mEntidad.ID_PLAN_SEMANAL = ID_PLAN_SEMANAL
 
        If mComponente.ObtenerPLAN_SEMANAL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PLAN_SEMANAL.Text = mEntidad.ID_PLAN_SEMANAL.ToString()
        'TODO: Definir ddlPLAN_CATORCENAID_PLAN_CATORCENA.RecuperarPorZafraActiva
        Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.Recuperar()
        Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue = mEntidad.ID_PLAN_CATORCENA
        Me.txtNO_SEMANA.Text = mEntidad.NO_SEMANA
        Me.txtFECHA_INICIO.Text = IIf(Not mEntidad.FECHA_INICIO = Nothing, Format(mEntidad.FECHA_INICIO, "dd/MM/yyyy"), "")
        Me.txtFECHA_FIN.Text = IIf(Not mEntidad.FECHA_FIN = Nothing, Format(mEntidad.FECHA_FIN, "dd/MM/yyyy"), "")
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
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.Enabled = edicion
        Me.txtNO_SEMANA.Enabled = edicion
        Me.txtFECHA_INICIO.Enabled = edicion
        Me.txtFECHA_FIN.Enabled = edicion
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
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.Recuperar()
        Me.txtNO_SEMANA.Text = ""
        Me.txtFECHA_INICIO.Text = ""
        Me.txtFECHA_FIN.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PLAN_SEMANAL
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New StringBuilder
        Dim fInicio As Date = Nothing
        Dim fFin As Date = Nothing
        Dim alDatos As New ArrayList
        mEntidad = New PLAN_SEMANAL

        If ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue Is Nothing OrElse ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue <= 0 Then
            sError.AppendLine(" * Seleccione la Catorcena.<br>")
        End If
        If Me.txtNO_SEMANA.Text.Trim = "" Then
            sError.AppendLine(" * Ingrese el numero de Semana.<br>")
        ElseIf Not IsNumeric(Me.txtNO_SEMANA.Text) Then
            sError.AppendLine(" * Numero de Semana invalido.<br>")
        End If
        If Not System.DateTime.TryParse(Me.txtFECHA_INICIO.Text, _
                    New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fInicio) Then
            sError.AppendLine(" * Fecha de inicio invalida.<br>")
        End If
        If Not System.DateTime.TryParse(Me.txtFECHA_FIN.Text, _
                   New System.Globalization.CultureInfo("fr-FR", True), System.Globalization.DateTimeStyles.NoCurrentDateDefault, fFin) Then
            sError.AppendLine(" * Fecha de fin invalida.<br>")
        End If
        If fInicio >= fFin Then
            sError.AppendLine(" * Fecha de inicio es mayor/igual a fecha fin.<br>")
        End If
        If sError.ToString.Length > 0 Then
            AsignarMensaje(sError.ToString, True)
            Return sError.ToString
        End If

        If Me._nuevo Then
            mEntidad.ID_PLAN_SEMANAL = 0
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREA = cFechaHora.ObtenerFechaHora
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        Else
            mEntidad = (New cPLAN_SEMANAL).ObtenerPLAN_SEMANAL(CInt(Me.txtID_PLAN_SEMANAL.Text))
            mEntidad.USUARIO_ACT = Me.ObtenerUsuario
            mEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
        End If
        mEntidad.ID_PLAN_CATORCENA = Me.ddlPLAN_CATORCENAID_PLAN_CATORCENA.SelectedValue
        mEntidad.NO_SEMANA = Convert.ToInt32(Me.txtNO_SEMANA.Text)
        mEntidad.FECHA_INICIO = fInicio
        mEntidad.FECHA_FIN = fFin

        If mComponente.ActualizarPLAN_SEMANAL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PLAN_SEMANAL.Text = mEntidad.ID_PLAN_SEMANAL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
