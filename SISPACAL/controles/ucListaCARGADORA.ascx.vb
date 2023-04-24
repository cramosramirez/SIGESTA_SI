﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaCARGADORA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla CARGADORA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	07/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaCARGADORA
    Inherits ucListaBase
 
    Private mComponente As New cCARGADORA
    Public Event Seleccionado(ByVal ID_CARGADORA As Int32) 
    Public Event Editando(ByVal ID_CARGADORA As Int32) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property ORIGEN() As String
        Get
            If Me.hdfCARGADORA.Contains("Origen") Then
                Return Me.hdfCARGADORA.Contains("Origen")
            Else
                Return Nothing
            End If
            Return Me.hdfCARGADORA("Origen")
        End Get
        Set(ByVal Value As String)
            Me.hdfCARGADORA("Origen") = Value
        End Set
    End Property

    Public Property TamanoPagina() As Integer
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal Value As Integer)
            Me.dxgvLista.SettingsPager.PageSize = Value
        End Set
    End Property

    Public Property Filtro() As String
        Get
            Return Me.dxgvLista.FilterExpression
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.FilterExpression = Value
        End Set
    End Property

    Public WriteOnly Property SeleccionarFila() As Object
        Set(value As Object)
            Dim indice As Int32
            Me.dxgvLista.Selection.SelectRowByKey(value)
            indice = Me.dxgvLista.FindVisibleIndexByKeyValue(value)
            If dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly Then Me.dxgvLista.FocusedRowIndex = indice
        End Set
    End Property

    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.EnableCallBacks = False
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
            dxgvLista.SettingsBehavior.ProcessSelectionChangedOnServer = True
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property

    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property

    Public Sub QuitarSeleccion()
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.PageIndex = 0
    End Sub

    Public Sub QuitarFiltros()
        Me.dxgvLista.FilterExpression = ""
        Me.dxgvLista.PageIndex = 0
    End Sub

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerID_CARGADORA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CARGADORA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CARGADORA").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_CARGADORA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_CARGADORA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_CARGADORA").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREA").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_ACT").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ACT").Visible = Value
        End Set
    End Property

    Public Property VerES_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ES_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ES_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_CARGA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_CARGA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_CARGA").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_CARGADORA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_CARGADORA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_CARGADORA").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_SIN_TRIPULACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_SIN_TRIPULACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_SIN_TRIPULACION").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_CON_TRIPULACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_CON_TRIPULACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_CON_TRIPULACION").Visible = Value
        End Set
    End Property

    Public Property VerTARIFA_NORMAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TARIFA_NORMAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TARIFA_NORMAL").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_ALZA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ALZA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_ALZA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_CARGADORA() As String
        Get
            Return Me.dxgvLista.Columns("ID_CARGADORA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CARGADORA").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderES_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("ES_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_CARGA() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_CARGA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_CARGA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_CARGADORA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_CARGADORA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_CARGADORA").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_SIN_TRIPULACION() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_SIN_TRIPULACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_SIN_TRIPULACION").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_CON_TRIPULACION() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_CON_TRIPULACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_CON_TRIPULACION").Caption = Value
        End Set
    End Property

    Public Property HeaderTARIFA_NORMAL() As String
        Get
            Return Me.dxgvLista.Columns("TARIFA_NORMAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TARIFA_NORMAL").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_ALZA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_ALZA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_ALZA").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CARGADORA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CARGADORA
    ''' filtrado por la tabla PROVEEDOR_CARGA
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_CARGA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_CARGA(ByVal ID_PROVEEDOR_CARGA As Int32) As Integer
        Me.odsListaPorPROVEEDOR_CARGA.SelectParameters("ID_PROVEEDOR_CARGA").DefaultValue = ID_PROVEEDOR_CARGA.ToString()
        Me.odsListaPorPROVEEDOR_CARGA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_CARGA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_CARGA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_CARGA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_CARGA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_CARGA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CARGADORA
    ''' filtrado por la tabla TIPO_CARGADORA
    ''' </summary>
    ''' <param name="ID_TIPO_CARGADORA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_CARGADORA(ByVal ID_TIPO_CARGADORA As Int32) As Integer
        Me.odsListaPorTIPO_CARGADORA.SelectParameters("ID_TIPO_CARGADORA").DefaultValue = ID_TIPO_CARGADORA.ToString()
        Me.odsListaPorTIPO_CARGADORA.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPO_CARGADORA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_CARGADORA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_CARGADORA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_CARGADORA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_CARGADORA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla CARGADORA
    ''' filtrado por la tabla TIPOS_GENERALES
    ''' </summary>
    ''' <param name="ID_TIPO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPOS_GENERALES(ByVal ID_TIPO As Int32) As Integer
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("ID_TIPO").DefaultValue = ID_TIPO.ToString()
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPOS_GENERALES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPOS_GENERALES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPOS_GENERALES"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_CARGADORA")
                keyNames(i) = grid.GetRowValues(i, "NOMBRE")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        Me.dxgvLista.Columns("colEditar").Visible = Me.PermitirEditar OrElse Me.PermitirEditarInline
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.GridViewRowType.EditForm Then
            'Dim btnGuardar As DevExpress.Web.ASPxButton
            'Dim btnCancelar As DevExpress.Web.ASPxButton
            'btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            'btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            'btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            'Dim lblEmptyDataRow As DevExpress.Web.ASPxLabel
            'lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                'lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                'lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                'Dim lbSeleccionar As LinkButton
                'lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                'lbSeleccionar.Visible = True
                'lbSeleccionar.Text = Me.TextoSeleccionar
                'lbSeleccionar.CommandName = Me.ComandoSeleccionar
                'If lbSeleccionar.CommandName = "Check" Then
                '    lbSeleccionar.Visible = False
                'End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaCARGADORA
        Dim mLista As New listaCARGADORA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_CARGADORA")
            Dim lEntidad As New CARGADORA
            lEntidad.ID_CARGADORA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As CARGADORA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), CARGADORA)

            If Me.mComponente.EliminarCARGADORA(lEntidad.ID_CARGADORA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "TIPO_CARGADORA" AndAlso e.GetListSourceFieldValue("ID_TIPO_ALZA") IsNot Nothing Then
            e.Value = configuracion.TipoAlza(CInt(e.GetListSourceFieldValue("ID_TIPO_ALZA")))
        End If
    End Sub

    Protected Sub dxgvLista_SelectionChanged(sender As Object, e As System.EventArgs) Handles dxgvLista.SelectionChanged
        If dxgvLista.GetSelectedFieldValues("ID_CARGADORA").Count > 0 Then RaiseEvent Seleccionado(dxgvLista.GetSelectedFieldValues("ID_CARGADORA")(0).ToString())
    End Sub
End Class
