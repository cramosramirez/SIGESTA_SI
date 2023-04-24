﻿Imports SISPACAL.BL
Imports SISPACAL.EL
''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucListaPLAN_ENTREGA_CANA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PLAN_ENTREGA_CANA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPLAN_ENTREGA_CANA
    Inherits ucBase
 
    Private mComponente As New cPLAN_ENTREGA_CANA
    Public Event Seleccionado(ByVal ID_PLAN_ENTREGA_CANA As Int32) 
    Public Event Editando(ByVal ID_PLAN_ENTREGA_CANA As Int32) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.gvLista.ShowFooter
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.ShowFooter = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            Return Me.gvLista.AllowPaging
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.AllowPaging = Value
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
            Me.gvLista.Columns(0).Visible = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = True
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            Me.gvLista.Columns(Me.gvLista.Columns.Count - 1).Visible = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
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
            Return Me.gvLista.Columns(0).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(0).HeaderText = Value
        End Set
    End Property

    Public Property VerID_PLAN_ENTREGA_CANA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_PLAN_SEMANAL() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerACCESLOTE() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ACT() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerAREA_PROGRAMADA() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerTONEL_PROGRAMADA() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property HeaderID_PLAN_ENTREGA_CANA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PLAN_SEMANAL() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderACCESLOTE() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_ACT() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_ACT() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAREA_PROGRAMADA() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTONEL_PROGRAMADA() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_ENTREGA_CANA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lPLAN_ENTREGA_CANA As ListaPLAN_ENTREGA_CANA
        lPLAN_ENTREGA_CANA = Me.mComponente.ObtenerLista()
        If lPLAN_ENTREGA_CANA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLAN_ENTREGA_CANA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_ENTREGA_CANA
    ''' filtrado por la tabla PLAN_SEMANAL
    ''' </summary>
    ''' <param name="ID_PLAN_SEMANAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPLAN_SEMANAL(ByVal ID_PLAN_SEMANAL As Int32) As Integer
        Dim lPLAN_ENTREGA_CANA As ListaPLAN_ENTREGA_CANA
        lPLAN_ENTREGA_CANA = Me.mComponente.ObtenerListaPorPLAN_SEMANAL(ID_PLAN_SEMANAL)
        If lPLAN_ENTREGA_CANA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPLAN_SEMANAL") = True
        Me.ViewState("ID_PLAN_SEMANAL") = ID_PLAN_SEMANAL
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLAN_ENTREGA_CANA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PLAN_ENTREGA_CANA
    ''' filtrado por la tabla LOTES
    ''' </summary>
    ''' <param name="ACCESLOTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/11/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLOTES(ByVal ACCESLOTE As String) As Integer
        Dim lPLAN_ENTREGA_CANA As ListaPLAN_ENTREGA_CANA
        lPLAN_ENTREGA_CANA = Me.mComponente.ObtenerListaPorLOTES(ACCESLOTE)
        If lPLAN_ENTREGA_CANA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorLOTES") = True
        Me.ViewState("ACCESLOTE") = ACCESLOTE
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lPLAN_ENTREGA_CANA
        Me.gvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Private lDdlPLAN_SEMANALID_PLAN_SEMANAL As SISPACAL.WebUC.ddlPLAN_SEMANAL
    Private lDdlLOTESACCESLOTE As SISPACAL.WebUC.ddlLOTES

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('Â¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelID_PLAN_ENTREGA_CANA As Label
            mLabelID_PLAN_ENTREGA_CANA = e.Row.FindControl("Label_ID_PLAN_ENTREGA_CANA")
            mLabelID_PLAN_ENTREGA_CANA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_PLAN_SEMANAL Then
                Dim mDdlPLAN_SEMANALID_PLAN_SEMANAL As SISPACAL.WebUC.ddlPLAN_SEMANAL
                mDdlPLAN_SEMANALID_PLAN_SEMANAL = e.Row.FindControl("DdlPLAN_SEMANALID_PLAN_SEMANAL1")
                If lDdlPLAN_SEMANALID_PLAN_SEMANAL Is Nothing Then
                    lDdlPLAN_SEMANALID_PLAN_SEMANAL = New SISPACAL.WebUC.ddlPLAN_SEMANAL
                    lDdlPLAN_SEMANALID_PLAN_SEMANAL.Recuperar()
                End If
                Dim mPLAN_SEMANALID_PLAN_SEMANAL As String
                mPLAN_SEMANALID_PLAN_SEMANAL = CType(e.Row.FindControl("Label_ID_PLAN_SEMANAL1"), Label).Text
                Dim lItem As ListItem = lDdlPLAN_SEMANALID_PLAN_SEMANAL.Items.FindByValue(mPLAN_SEMANALID_PLAN_SEMANAL)
                If mPLAN_SEMANALID_PLAN_SEMANAL <> "" And Not lItem Is Nothing Then
                    mDdlPLAN_SEMANALID_PLAN_SEMANAL.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlPLAN_SEMANALID_PLAN_SEMANAL.SelectedValue = mPLAN_SEMANALID_PLAN_SEMANAL
                End If
            End If
            If Me.VerACCESLOTE Then
                Dim mDdlLOTESACCESLOTE As SISPACAL.WebUC.ddlLOTES
                mDdlLOTESACCESLOTE = e.Row.FindControl("DdlLOTESACCESLOTE1")
                If lDdlLOTESACCESLOTE Is Nothing Then
                    lDdlLOTESACCESLOTE = New SISPACAL.WebUC.ddlLOTES
                    lDdlLOTESACCESLOTE.Recuperar()
                End If
                Dim mLOTESACCESLOTE As String
                mLOTESACCESLOTE = CType(e.Row.FindControl("Label_ACCESLOTE1"), Label).Text
                Dim lItem As ListItem = lDdlLOTESACCESLOTE.Items.FindByValue(mLOTESACCESLOTE)
                If mLOTESACCESLOTE <> "" And Not lItem Is Nothing Then
                    mDdlLOTESACCESLOTE.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlLOTESACCESLOTE.SelectedValue = mLOTESACCESLOTE
                End If
            End If
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarPLAN_ENTREGA_CANA(CInt(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
        If Me.ViewState("PorPLAN_SEMANAL") Then
            Me.CargarDatosPorPLAN_SEMANAL(Me.ViewState("ID_PLAN_SEMANAL"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CInt(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorPLAN_SEMANAL") Then
            Me.CargarDatosPorPLAN_SEMANAL(Me.ViewState("ID_PLAN_SEMANAL"))
            Return
        End If
        If Me.ViewState("PorLOTES") Then
            Me.CargarDatosPorLOTES(Me.ViewState("ACCESLOTE"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As ListaPLAN_ENTREGA_CANA
        Dim mLista As New ListaPLAN_ENTREGA_CANA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New PLAN_ENTREGA_CANA
                mEntidad.ID_PLAN_ENTREGA_CANA = CInt(CType(mRow.FindControl("Label_ID_PLAN_ENTREGA_CANA"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
