﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPLAN_COSECHA_DIARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PLAN_COSECHA_DIARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/03/2015	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPLAN_COSECHA_DIARIO
    Inherits ucListaBase
 
    Private mComponente As New cPLAN_COSECHA_DIARIO
    Public Event Seleccionado(ByVal ID_PLAN_COSECHA_DIARIO As Int32) 
    Public Event Editando(ByVal ID_PLAN_COSECHA_DIARIO As Int32) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

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

    Public Property VerticaScrollHeight() As Int32
        Get
            Return Me.dxgvLista.Settings.VerticalScrollableHeight
        End Get
        Set(ByVal Value As Int32)
            Me.dxgvLista.Settings.VerticalScrollableHeight = Value
        End Set
    End Property


    Public Property ScrollVisible() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Visible = False
                Me.dxgvLista.Settings.VerticalScrollBarMode = DevExpress.Web.ScrollBarMode.Auto
            Else
                Me.dxgvLista.SettingsPager.Visible = True
                Me.dxgvLista.Settings.VerticalScrollBarMode = DevExpress.Web.ScrollBarMode.Hidden
            End If
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

    Public Property PermitirEdicionBatch() As Boolean
        Get
            Return Me.dxgvLista.SettingsEditing.Mode
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.Batch
                Me.dxgvLista.SettingsEditing.BatchEditSettings.EditMode = DevExpress.Web.GridViewBatchEditMode.Cell
                Me.dxgvLista.SettingsEditing.BatchEditSettings.StartEditAction = DevExpress.Web.GridViewBatchStartEditAction.Click
            Else
                Me.dxgvLista.SettingsEditing.Mode = DevExpress.Web.GridViewEditingMode.EditForm
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

    Public Property VerID_PLAN_COSECHA_DIARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PLAN_COSECHA_DIARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PLAN_COSECHA_DIARIO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA").Visible = Value
        End Set
    End Property

    Public Property VerID_ZAFRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ZAFRA").Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACCESLOTE").Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ZONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ZONA").Visible = Value
        End Set
    End Property

    Public Property VerCODILOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODILOTE").Visible = Value
        End Set
    End Property

    Public Property VerNOMBLOTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBLOTE").Visible = Value
        End Set
    End Property

    Public Property VerCODIPROVEE() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIPROVEE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIPROVEE").Visible = Value
        End Set
    End Property

    Public Property VerCCODISOCIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CCODISOCIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CCODISOCIO").Visible = Value
        End Set
    End Property

    Public Property VerPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerROZA_PROYECTADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ROZA_PROYECTADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ROZA_PROYECTADA").Visible = Value
        End Set
    End Property

    Public Property VerAUTORIZADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("AUTORIZADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("AUTORIZADO").Visible = Value
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

    Public Property HeaderID_PLAN_COSECHA_DIARIO() As String
        Get
            Return Me.dxgvLista.Columns("ID_PLAN_COSECHA_DIARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PLAN_COSECHA_DIARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ZAFRA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ZAFRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ZAFRA").Caption = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.dxgvLista.Columns("ACCESLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACCESLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.dxgvLista.Columns("ZONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ZONA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODILOTE() As String
        Get
            Return Me.dxgvLista.Columns("CODILOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODILOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBLOTE() As String
        Get
            Return Me.dxgvLista.Columns("NOMBLOTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBLOTE").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIPROVEE() As String
        Get
            Return Me.dxgvLista.Columns("CODIPROVEE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIPROVEE").Caption = Value
        End Set
    End Property

    Public Property HeaderCCODISOCIO() As String
        Get
            Return Me.dxgvLista.Columns("CCODISOCIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CCODISOCIO").Caption = Value
        End Set
    End Property

    Public Property HeaderPROVEEDOR() As String
        Get
            Return Me.dxgvLista.Columns("PROVEEDOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROVEEDOR").Caption = Value
        End Set
    End Property

    Public Property HeaderROZA_PROYECTADA() As String
        Get
            Return Me.dxgvLista.Columns("ROZA_PROYECTADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ROZA_PROYECTADA").Caption = Value
        End Set
    End Property

    Public Property HeaderAUTORIZADO() As String
        Get
            Return Me.dxgvLista.Columns("AUTORIZADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("AUTORIZADO").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA_DIARIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorCriterios(ByVal ID_ZAFRA As Int32, _
                                             ByVal ZONA As String, _
                                             ByVal DIAZAFRA As Int32, _
                                             ByVal CODIPROVEE As String, _
                                             ByVal CODISOCIO As String, _
                                             ByVal NOMBRE_PROVEEDOR As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA
        Me.odsListaPorCriterios.SelectParameters("ZONA").DefaultValue = ZONA
        Me.odsListaPorCriterios.SelectParameters("DIAZAFRA").DefaultValue = DIAZAFRA
        Me.odsListaPorCriterios.SelectParameters("CODIPROVEE").DefaultValue = CODIPROVEE
        Me.odsListaPorCriterios.SelectParameters("CODISOCIO").DefaultValue = CODISOCIO
        Me.odsListaPorCriterios.SelectParameters("NOMBRE_PROVEEDOR").DefaultValue = NOMBRE_PROVEEDOR
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA_DIARIO
    ''' filtrado por la tabla ZAFRA
    ''' </summary>
    ''' <param name="ID_ZAFRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorZAFRA(ByVal ID_ZAFRA As Int32) As Integer
        Me.odsListaPorZAFRA.SelectParameters("ID_ZAFRA").DefaultValue = ID_ZAFRA.ToString()
        Me.odsListaPorZAFRA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorZAFRA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorZAFRA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorZAFRA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_COSECHA_DIARIO
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/03/2015	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Me.odsListaPorLOTES.SelectParameters("ACCESLOTE").DefaultValue = ACCESLOTE.ToString()
        Me.odsListaPorLOTES.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorLOTES.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorLOTES.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorLOTES.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorLOTES"
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
                keyValues(i) = grid.GetRowValues(i, "ID_PLAN_COSECHA_DIARIO")
                keyNames(i) = grid.GetRowValues(i, "FECHA")
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
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
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
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
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
            Dim btnAgregar As DevExpress.Web.ASPxButton
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
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
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

    Public Function DevolverSeleccionados() As listaPLAN_COSECHA_DIARIO
        Dim mLista As New listaPLAN_COSECHA_DIARIO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PLAN_COSECHA_DIARIO")
            Dim lEntidad As New PLAN_COSECHA_DIARIO
            lEntidad.ID_PLAN_COSECHA_DIARIO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PLAN_COSECHA_DIARIO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PLAN_COSECHA_DIARIO)

            If Me.mComponente.EliminarPLAN_COSECHA_DIARIO(lEntidad.ID_PLAN_COSECHA_DIARIO) <> 1 Then
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

End Class
