﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetalleTIPO_PROVEEDOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla TIPO_PROVEEDOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/01/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleTIPO_PROVEEDOR
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_TIPO_PROVEEDOR As Int32
    Public Property ID_TIPO_PROVEEDOR() As Int32
        Get
            Return Me.txtID_TIPO_PROVEEDOR.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_TIPO_PROVEEDOR = Value
            Me.txtID_TIPO_PROVEEDOR.Text = CStr(Value)
            If Me._ID_TIPO_PROVEEDOR > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_TIPO_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_TIPO_PROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_TIPO_PROVEEDOR.Text = value.ToString()
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

    Public Property VerID_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.trID_TIPO_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_TIPO_PROVEEDOR() As Boolean
        Get
            Return Me.trNOMBRE_TIPO_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_TIPO_PROVEEDOR.Visible = value
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
    Private mComponente As New cTIPO_PROVEEDOR
    Private mEntidad As TIPO_PROVEEDOR
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
        If Not Me.ViewState("ID_TIPO_PROVEEDOR") Is Nothing Then Me._ID_TIPO_PROVEEDOR = Me.ViewState("ID_TIPO_PROVEEDOR")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla TIPO_PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New TIPO_PROVEEDOR
        mEntidad.ID_TIPO_PROVEEDOR = ID_TIPO_PROVEEDOR
 
        If mComponente.ObtenerTIPO_PROVEEDOR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_TIPO_PROVEEDOR.Text = mEntidad.ID_TIPO_PROVEEDOR.ToString()
        Me.txtNOMBRE_TIPO_PROVEEDOR.Text = mEntidad.NOMBRE_TIPO_PROVEEDOR
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
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_TIPO_PROVEEDOR.Enabled = edicion
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
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_TIPO_PROVEEDOR.Text = ""
        Me.txtUSUARIO_CREA.Text = ""
        Me.txtFECHA_CREA.Text = ""
        Me.txtUSUARIO_ACT.Text = ""
        Me.txtFECHA_ACT.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla TIPO_PROVEEDOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/01/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New TIPO_PROVEEDOR
        If Me._nuevo Then
            mEntidad.ID_TIPO_PROVEEDOR = 0
        Else
            mEntidad.ID_TIPO_PROVEEDOR = CInt(Me.txtID_TIPO_PROVEEDOR.Text)
        End If
        mEntidad.NOMBRE_TIPO_PROVEEDOR = Me.txtNOMBRE_TIPO_PROVEEDOR.Text
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = System.DateTime.Parse(Me.txtFECHA_CREA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = System.DateTime.Parse(Me.txtFECHA_ACT.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarTIPO_PROVEEDOR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_TIPO_PROVEEDOR.Text = mEntidad.ID_TIPO_PROVEEDOR.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
