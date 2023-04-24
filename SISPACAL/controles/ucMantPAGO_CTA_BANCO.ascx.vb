Imports SISPACAL.BL
Imports SISPACAL.DL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores
Imports System.Data
Imports System.IO

''' -----------------------------------------------------------------------------
''' Project	 : SISPACAL
''' Class	 : ucMantPAGO_CTA_BANCO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PAGO_CTA_BANCO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/01/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPAGO_CTA_BANCO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"

    Public Property ES_REGISTRO_CCF As Boolean
        Get
            If Me.ViewState("ES_REGISTRO_CCF") IsNot Nothing Then
                Return Me.ViewState("ES_REGISTRO_CCF")
            Else
                Return True
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("ES_REGISTRO_CCF") = value
        End Set
    End Property

    Private Sub Inicializar()
        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZafraActiva
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, IconoBarra.Buscar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Exportar", "Exportar", False, IconoBarra.ExportarXls, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("Actualizar", "Actualizar cuentas y Monto a Pagar", False, IconoBarra.Actualizar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarArchivo", "Generar archivo", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CrearOpcion("GenerarArchivoFtoPlanilla", "Generar archivo en formato de planilla", False, IconoBarra.Generar, "", "", True)
        Me.ucBarraNavegacion1.CargarOpciones()
        If lZafra IsNot Nothing Then
            Me.cbxZAFRA.Value = lZafra.ID_ZAFRA
        End If
        Me.CargarCatorcenas()
        Me.cbxTIPO_PLANILLA.SelectedIndex = 0

        Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = ES_REGISTRO_CCF

        If ES_REGISTRO_CCF Then
            Me.lblTitulo.Text = "Registro de Comprobantes de Crédito Fiscal para Pago"
        Else
            Me.lblTitulo.Text = "Generacion de Pago a Cuenta Bancaria"
        End If
    End Sub

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla PAGO_CTA_BANCO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/01/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarPAGO_CTA_BANCO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarPAGO_CTA_BANCO() As Integer
        If Me.ucListaPAGO_CTA_BANCO1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub CargarCatorcenas()
        Dim lista As listaCATORCENA_ZAFRA

        If Me.cbxZAFRA.Value IsNot Nothing Then
            lista = (New cCATORCENA_ZAFRA).ObtenerListaPorZAFRA(Me.cbxZAFRA.Value, False, False, "CATORCENA", "DESC")
        Else
            lista = New listaCATORCENA_ZAFRA
        End If
        Me.cbxCATORCENA_ZAFRA.DataSource = lista
        Me.cbxCATORCENA_ZAFRA.DataBind()
        If Me.cbxCATORCENA_ZAFRA.Items.Count > 0 Then Me.cbxCATORCENA_ZAFRA.SelectedIndex = 0
    End Sub

    Protected Sub cbxZAFRA_ValueChanged(sender As Object, e As EventArgs) Handles cbxZAFRA.ValueChanged
        Me.CargarCatorcenas()
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Buscar"
                Me.Buscar()

            Case "Exportar"
                Me.ucListaPAGO_CTA_BANCO1.ExportarToXls(Me.cbxTIPO_PLANILLA.Text + " CORTE " + Me.cbxCATORCENA_ZAFRA.Text + " " + Me.cbxMOSTRAR_POR.Text)


            Case "Actualizar"
                Dim idCatorcena As Int32 = -2
                Dim idTipoPlanilla As Int32 = -2

                If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
                If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value

                Me.Buscar()
                Me.AsignarMensaje("La informacion de Cuentas Bancarias y Monto a Pagar se ha actualizado para los pagos no generados", False, True, True)

            Case "GenerarArchivoFtoPlanilla"
                If Me.rblTIPO_CONTRIBUYENTE.Value = -1 Then
                    AsignarMensaje("Para generar el archivo debe seleccionar solo un tipo de contribuyente", False, True, True)
                    Return
                End If

                Dim idCatorcena As Int32 = -2
                Dim idTipoPlanilla As Int32 = -2
                Dim iEsContibuyente As Int32 = -1
                Dim lstpagoCta As listaPAGO_CTA_BANCO
                Dim lPlanilla As PLANILLA

                If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
                If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
                If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
                    iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
                End If
                lstpagoCta = (New cPAGO_CTA_BANCO).ObtenerListaPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, -1, "APELLIDOS")


                Dim dt As New DataTable
                dt.Columns.Add("CODIGO", GetType(String))
                dt.Columns.Add("NOMBRE", GetType(String))
                dt.Columns.Add("VALOR_A_PAGAR", GetType(Decimal))

                If lstpagoCta IsNot Nothing AndAlso lstpagoCta.Count > 0 Then
                    For i As Integer = 0 To lstpagoCta.Count - 1

                        If lstpagoCta(i).ENTREGO_CCF AndAlso lstpagoCta(i).NUM_CUENTA <> Nothing AndAlso lstpagoCta(i).NUM_CUENTA <> "" Then
                            If lstpagoCta(i).ID_TIPO_PLANILLA = 2 Then
                                Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CInt(lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA))
                                If lTransportista IsNot Nothing Then
                                    lPlanilla = (New cPLANILLA).ObtenerPLANILLA(idCatorcena, lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA, lstpagoCta(i).ID_TIPO_PLANILLA)
                                    If lPlanilla IsNot Nothing Then
                                        dt.Rows.Add(lstpagoCta(i).CODIGO_SINFTO, Trim(lTransportista.APELLIDOS + " " + lTransportista.NOMBRES), lPlanilla.PAGO_NETO)
                                    End If
                                End If
                            Else
                                Dim lProductor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA)
                                If lProductor IsNot Nothing Then
                                    lPlanilla = (New cPLANILLA).ObtenerPLANILLA(idCatorcena, lstpagoCta(i).CODIPROVEEDOR_TRANSPORTISTA, lstpagoCta(i).ID_TIPO_PLANILLA)
                                    If lPlanilla IsNot Nothing Then
                                        dt.Rows.Add(lstpagoCta(i).CODIGO_SINFTO, Trim(lProductor.APELLIDOS + " " + lProductor.NOMBRES), lPlanilla.PAGO_NETO)
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
                Me.ExportToExcelFtoPlanilla(dt, "PagoCuentaFormatoPlanilla" & cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy hh.mm.ss") & ".xls")

            Case "GenerarArchivo"
                If Me.rblTIPO_CONTRIBUYENTE.Value = -1 Then
                    AsignarMensaje("Para generar el archivo debe seleccionar solo un tipo de contribuyente", False, True, True)
                    Return
                End If
                Me.GenerarArchivo()
        End Select
    End Sub

    

    Private Sub GenerarArchivo()
        Dim idCatorcena As Int32 = -2
        Dim idTipoPlanilla As Int32 = -2
        Dim iEsContibuyente As Int32 = -1
        Dim iMostrarPor As Int32 = -1
        Dim lstpagoCta As listaPAGO_CTA_BANCO
        Dim bPagoCuenta As New cPAGO_CTA_BANCO
        Dim ms As New MemoryStream
        Dim tw As TextWriter = New StreamWriter(ms)
        Dim contador As Integer = 0

        If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
        If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
        If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
            iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
        End If

        Me.ActualizarPlanilla(idCatorcena, idTipoPlanilla)
        lstpagoCta = bPagoCuenta.ObtenerListaPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, -1, "APELLIDOS")

        If lstpagoCta IsNot Nothing AndAlso lstpagoCta.Count > 0 Then
            For Each lEntidad As PAGO_CTA_BANCO In lstpagoCta
                If lEntidad.ENTREGO_CCF AndAlso lEntidad.NUM_CUENTA <> Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                    lEntidad.PAGO_GENERADO = True
                    lEntidad.FECHA_GENPAGO = cFechaHora.ObtenerFechaHora
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora
                    bPagoCuenta.ActualizarPAGO_CTA_BANCO(lEntidad)

                    If lEntidad.ID_TIPO_PLANILLA = 2 Then
                        Dim lTransportista As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(CInt(lEntidad.CODIPROVEEDOR_TRANSPORTISTA))
                        If lTransportista IsNot Nothing Then
                            tw.WriteLine(lTransportista.NUM_CUENTA + "," + lEntidad.MONTO_PAGO.ToString("#0.00") + ",," + Trim(lTransportista.APELLIDOS + " " + lTransportista.NOMBRES) + ",")
                            contador += 1
                        End If
                    Else
                        Dim lProductor As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lEntidad.CODIPROVEEDOR_TRANSPORTISTA)
                        If lProductor IsNot Nothing Then
                            tw.WriteLine(lProductor.NUM_CUENTA + "," + lEntidad.MONTO_PAGO.ToString("#0.00") + ",," + Trim(lProductor.APELLIDOS + " " + lProductor.NOMBRES) + ",")
                            contador += 1
                        End If
                    End If
                End If
            Next
        End If
        tw.Flush()
        Dim b As Byte() = ms.ToArray
        ms.Close()

        If contador > 0 Then
            Response.Clear()
            Response.ContentType = "application/force-download"
            Response.AddHeader("content-disposition", "attachment;filename=" + "ZAFRA " + Me.cbxZAFRA.Text.Replace("/", "-") + "  PAGO DE " + Me.cbxTIPO_PLANILLA.Text + " - " + Utilerias.NombreTipoContribuyente(rblTIPO_CONTRIBUYENTE.Value) + ".txt")
            Response.BinaryWrite(b)
            Response.End()
        Else
            AsignarMensaje("No existen registros marcados con entrega de ccf para los criterios seleccionados", False, True, True)
        End If
        
    End Sub

    Private Sub Buscar()
        Dim idCatorcena As Int32 = -2
        Dim idTipoPlanilla As Int32 = -2
        Dim iEsContibuyente As Int32 = -1
        Dim iMostrarPor As Int32 = -1

        If Me.cbxCATORCENA_ZAFRA.Text <> "" Then idCatorcena = Me.cbxCATORCENA_ZAFRA.Value
        If Me.cbxTIPO_PLANILLA.Text <> "" Then idTipoPlanilla = Me.cbxTIPO_PLANILLA.Value
        If Me.rblTIPO_CONTRIBUYENTE.SelectedItem IsNot Nothing Then
            iEsContibuyente = Me.rblTIPO_CONTRIBUYENTE.Value
        End If
        If Me.cbxMOSTRAR_POR.Text <> "" Then iMostrarPor = Me.cbxMOSTRAR_POR.Value

        Me.ActualizarPlanilla(idCatorcena, idTipoPlanilla)
        Me.ucListaPAGO_CTA_BANCO1.CargarDatosPorCriterios(idCatorcena, idTipoPlanilla, iEsContibuyente, iMostrarPor)

        Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = False
        Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
        Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = False

        If Me.cbxMOSTRAR_POR.Value = 0 Then
            Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = True
            Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
            Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = True

        ElseIf Me.cbxMOSTRAR_POR.Value = 1 Then
            Me.ucListaPAGO_CTA_BANCO1.EditarENTREGO_CCF = False
            Me.ucListaPAGO_CTA_BANCO1.EditarPAGO_GENERADO = False
            Me.ucListaPAGO_CTA_BANCO1.PermitirEditarInline = False
        End If

    End Sub

    Private Sub ActualizarPlanilla(ByVal ID_CATORCENA As Int32, ID_TIPO_PLANILLA As Int32)
        Dim lista As New listaPAGO_CTA_BANCO
        Dim bPagocta As New cPAGO_CTA_BANCO
        Dim lPagoCta As PAGO_CTA_BANCO
        Dim listaPlanilla As listaPLANILLA

        lista = bPagocta.ObtenerListaPorCriterios(ID_CATORCENA, ID_TIPO_PLANILLA, -1, -1)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Int32 = 0 To lista.Count - 1
                lPagoCta = New PAGO_CTA_BANCO
                lPagoCta = lista(i)

                If lPagoCta.NUM_CUENTA = "" Then
                    If lPagoCta.ID_TIPO_PLANILLA = TipoPlanilla.Cañeros Then
                        Dim lEntidad As PROVEEDOR = (New cPROVEEDOR).ObtenerPROVEEDOR(lPagoCta.CODIPROVEEDOR_TRANSPORTISTA)
                        If lEntidad IsNot Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                            'Actualizar cuenta y su tipo
                            lPagoCta.CODIBANCO = lEntidad.CODIBANCO
                            lPagoCta.NUM_CUENTA = lEntidad.NUM_CUENTA
                            lPagoCta.ES_CTA_CORRIENTE = lEntidad.ES_CTA_CORRIENTE
                        End If

                    ElseIf lPagoCta.ID_TIPO_PLANILLA = TipoPlanilla.Transportistas Then
                        Dim lEntidad As TRANSPORTISTA = (New cTRANSPORTISTA).ObtenerTRANSPORTISTA(lPagoCta.CODIPROVEEDOR_TRANSPORTISTA)
                        If lEntidad IsNot Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                            'Actualizar cuenta y su tipo
                            lPagoCta.CODIBANCO = lEntidad.CODIBANCO
                            lPagoCta.NUM_CUENTA = lEntidad.NUM_CUENTA
                            lPagoCta.ES_CTA_CORRIENTE = lEntidad.ES_CTA_CORRIENTE
                        End If
                    End If
                End If

                'Actualizar monto a pagar
                listaPlanilla = (New cPLANILLA).ObtenerListaPorCRITERIOS(ID_CATORCENA, ID_TIPO_PLANILLA, lPagoCta.CODIPROVEEDOR_TRANSPORTISTA, "")
                If listaPlanilla IsNot Nothing AndAlso listaPlanilla.Count > 0 Then
                    lPagoCta.MONTO_PAGO = listaPlanilla(0).PAGO_NETO
                End If

                If Not lPagoCta.PAGO_GENERADO Then
                    bPagocta.ActualizarPAGO_CTA_BANCO(lPagoCta)
                End If
            Next
        End If
    End Sub

    Protected Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim lista As listaPAGO_CTA_BANCO
        Dim bPagoCuenta As New cPAGO_CTA_BANCO
        Dim dt As New DS_CATORCENA.PAGO_CTA_BANCODataTable
        Dim adapter As New DS_CATORCENATableAdapters.PAGO_CTA_BANCOTableAdapter
        Dim idTipoPlanillas As Int32 = -1

        If rblTipoGeneracion.Value = 2 Then
            idTipoPlanillas = Me.cbxTIPO_PLANILLA.Value
        End If
        adapter.FillPorCriterios(dt, Me.cbxCATORCENA_ZAFRA.Value, idTipoPlanillas)

        'Marcar como generado los pagos
        lista = (New cPAGO_CTA_BANCO).ObtenerListaPorCriterios(Me.cbxCATORCENA_ZAFRA.Value, idTipoPlanillas, -1, -1)
        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For Each lEntidad As PAGO_CTA_BANCO In lista
                If lEntidad.ENTREGO_CCF AndAlso lEntidad.NUM_CUENTA <> Nothing AndAlso lEntidad.NUM_CUENTA <> "" Then
                    lEntidad.PAGO_GENERADO = True
                    lEntidad.FECHA_GENPAGO = cFechaHora.ObtenerFechaHora
                    lEntidad.USUARIO_ACT = Me.ObtenerUsuario
                    lEntidad.FECHA_ACT = cFechaHora.ObtenerFechaHora

                    bPagoCuenta.ActualizarPAGO_CTA_BANCO(lEntidad)
                End If
            Next
        End If

        Me.ExportToExcel(dt, "PagoCuenta" & cFechaHora.ObtenerFechaHora.ToString("dd/MM/yyyy hh.mm.ss") & ".csv")
    End Sub

    Sub ExportToExcel(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        Dim GridView1 As New GridView()
        GridView1.AllowPaging = False
        GridView1.DataSource = dt
        GridView1.DataBind()

        Dim csv As String = String.Empty

        For Each column As DataColumn In dt.Columns
            'Add the Header row for CSV file.
            csv += column.ColumnName + ","c
        Next

        'Add new line.
        csv += vbCr & vbLf

        For Each row As DataRow In dt.Rows
            For Each column As DataColumn In dt.Columns
                'Add the Data rows.
                csv += row(column.ColumnName).ToString().Replace(",", ";") + ","c
            Next

            'Add new line.
            csv += vbCr & vbLf
        Next

        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=" + nombreArchivo)
        Response.Charset = ""
        Response.ContentType = "application/text"
        Response.Output.Write(csv)
        Response.Flush()
        Response.End()
    End Sub

    Sub ExportToExcelFtoPlanilla(ByVal dt As DataTable, ByVal nombreArchivo As String)
        'Create a dummy GridView
        Dim GridView1 As New GridView()
        GridView1.AllowPaging = False
        GridView1.DataSource = dt
        GridView1.DataBind()

        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=" & nombreArchivo)
        Response.Charset = ""
        Response.ContentType = "application/vnd.ms-excel"
        Dim sw As New StringWriter()
        Dim hw As New HtmlTextWriter(sw)

        GridView1.RenderControl(hw)

        'style to format numbers to string
        Dim style As String = "<style> .textmode{mso-number-format:\@;}</style>"
        Response.Write(style)
        Response.Output.Write(sw.ToString())
        Response.Flush()
        Response.End()
    End Sub
  

End Class
