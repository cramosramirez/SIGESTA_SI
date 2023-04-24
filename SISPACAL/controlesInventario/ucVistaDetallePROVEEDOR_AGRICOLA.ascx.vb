Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucVistaDetallePROVEEDOR_AGRICOLA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_AGRICOLA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/10/2014	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_AGRICOLA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROVEE As Int32
    Public Property ID_PROVEE() As Int32
        Get
            Return Me.txtID_PROVEE.Text
        End Get
        Set(ByVal Value As Int32)
            Me._ID_PROVEE = Value
            Me.txtID_PROVEE.Text = CStr(Value)
            If Me._ID_PROVEE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE() As String
        Get
            Return Me.txtNOMBRE.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE.Text = value.ToString()
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property NRC() As String
        Get
            Return Me.txtNRC.Text
        End Get
        Set(ByVal value As String)
            Me.txtNRC.Text = value.ToString()
        End Set
    End Property

    Public Property TIPO_CONTRIBUYENTE() As Int32
        Get
            If Me.txtTIPO_CONTRIBUYENTE.Value Is Nothing Then Return -1
            Return CInt(Me.txtTIPO_CONTRIBUYENTE.Value)
        End Get
        Set(ByVal value As Int32)
            Me.txtTIPO_CONTRIBUYENTE.Value = value
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
            Return Me.deFECHA_CREA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREA.Value = value
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
            Return Me.deFECHA_ACT.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ACT.Value = value
        End Set
    End Property

    Public Property ZAFRA() As String
        Get
            Return Me.txtZAFRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtZAFRA.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_PROVEE() As Boolean
        Get
            Return Me.trID_PROVEE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEE.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.trNOMBRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE.Visible = value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.trDUI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDUI.Visible = value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.trNIT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIT.Visible = value
        End Set
    End Property

    Public Property VerNRC() As Boolean
        Get
            Return Me.trNRC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNRC.Visible = value
        End Set
    End Property

    Public Property VerTIPO_CONTRIBUYENTE() As Boolean
        Get
            Return Me.trTIPO_CONTRIBUYENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_CONTRIBUYENTE.Visible = value
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

    Public Property VerZAFRA() As Boolean
        Get
            Return Me.trZAFRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZAFRA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROVEEDOR_AGRICOLA
    Private mEntidad As PROVEEDOR_AGRICOLA
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
        If Not Me.ViewState("ID_PROVEE") Is Nothing Then Me._ID_PROVEE = Me.ViewState("ID_PROVEE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla PROVEEDOR_AGRICOLA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROVEEDOR_AGRICOLA
        mEntidad.ID_PROVEE = ID_PROVEE
 
        If mComponente.ObtenerPROVEEDOR_AGRICOLA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROVEE.Text = mEntidad.ID_PROVEE.ToString()
        Me.txtNOMBRE.Text = mEntidad.NOMBRE
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtNRC.Text = mEntidad.NRC
        Me.txtTIPO_CONTRIBUYENTE.Value = mEntidad.TIPO_CONTRIBUYENTE
        Me.txtUSUARIO_CREA.Text = mEntidad.USUARIO_CREA
        Me.deFECHA_CREA.Value = mEntidad.FECHA_CREA
        Me.txtUSUARIO_ACT.Text = mEntidad.USUARIO_ACT
        Me.deFECHA_ACT.Value = mEntidad.FECHA_ACT
        Me.txtZAFRA.Text = mEntidad.ZAFRA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE.Enabled = edicion
        Me.txtDUI.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtNRC.Enabled = edicion
        Me.txtTIPO_CONTRIBUYENTE.Enabled = edicion
        Me.txtUSUARIO_CREA.Enabled = edicion
        Me.deFECHA_CREA.Enabled = edicion
        Me.txtUSUARIO_ACT.Enabled = edicion
        Me.deFECHA_ACT.Enabled = edicion
        Me.txtZAFRA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE.Text = ""
        Me.txtDUI.Text = ""
        Me.txtNIT.Text = ""
        Me.txtNRC.Text = ""
        Me.txtTIPO_CONTRIBUYENTE.Value = Nothing
        Me.txtUSUARIO_CREA.Text = ""
        Me.deFECHA_CREA.Value = Nothing
        Me.txtUSUARIO_ACT.Text = ""
        Me.deFECHA_ACT.Value = Nothing
        Me.txtZAFRA.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla PROVEEDOR_AGRICOLA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/10/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROVEEDOR_AGRICOLA
        If Me._nuevo Then
            mEntidad.ID_PROVEE = 0
        Else
            mEntidad.ID_PROVEE = CInt(Me.txtID_PROVEE.Text)
        End If
        mEntidad.NOMBRE = Me.txtNOMBRE.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.NRC = Me.txtNRC.Text
        mEntidad.TIPO_CONTRIBUYENTE = Me.txtTIPO_CONTRIBUYENTE.Value
        mEntidad.USUARIO_CREA = Me.txtUSUARIO_CREA.Text
        mEntidad.FECHA_CREA = Me.deFECHA_CREA.Value
        mEntidad.USUARIO_ACT = Me.txtUSUARIO_ACT.Text
        mEntidad.FECHA_ACT = Me.deFECHA_ACT.Value
        mEntidad.ZAFRA = Me.txtZAFRA.Text

        If mComponente.ActualizarPROVEEDOR_AGRICOLA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROVEE.Text = mEntidad.ID_PROVEE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
