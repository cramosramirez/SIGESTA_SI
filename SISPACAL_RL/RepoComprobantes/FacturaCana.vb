﻿Imports SISPACAL.BL
Imports SISPACAL.EL
Imports SISPACAL.EL.Enumeradores

Public Class FacturaCana

    Public Sub Cargar(ByVal ID_CATORCENA As Integer, ByVal ID_TIPO_PLANILLA As Integer, ByVal ID_TIPO_COMPROB As Integer, ByVal ES_CONTRIBUYENTE As Integer, ByVal ID_COMPROB_CONCE As Integer, Optional NO_DOCTO_INI As Integer = -1, Optional NO_DOCTO_FIN As Integer = -1)
        Me.DS_COMPROBANTES1.Clear()
        Me.REPO_COMPROBANTESTableAdapter1.FillPorCriterios(Me.DS_COMPROBANTES1.REPO_COMPROBANTES, ID_CATORCENA, ID_TIPO_PLANILLA, ID_TIPO_COMPROB, ID_COMPROB_CONCE, ES_CONTRIBUYENTE, NO_DOCTO_INI, NO_DOCTO_FIN)

        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        If lCatorcena IsNot Nothing Then
            Me.xrPeriodo.Text = "PERIODO DEL " + lCatorcena.FECHA_INICIO.ToString("dd/MM/yyyy") + " AL " + lCatorcena.FECHA_FIN.ToString("dd/MM/yyyy")
            Me.xrCorte.Text = "CORTE #" + lCatorcena.NO_CATORCENA.ToString
        End If
        If ID_TIPO_PLANILLA = TipoPlanilla.Cañeros Then
            Me.xrTitulo.Text = "LISTADO DE FACTURAS EMITIDAS NO CONTRIBUYENTE CAÑA"
        ElseIf ID_TIPO_PLANILLA = TipoPlanilla.Transportistas OrElse ID_TIPO_PLANILLA = TipoPlanilla.ComplementoTransportistas Then
            Me.xrTitulo.Text = "LISTADO DE FACTURAS EMITIDAS NO CONTRIBUYENTE TRANSPORTE"
        End If
    End Sub

End Class