﻿Imports SISPACAL.EL
Imports SISPACAL.BL

Public Class SaldosZafraTransportistas

    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODTRANSPORT As Integer)
        Me.DS_SIFAG1.Clear()
        Me.SaldoS_ZAFRA_TRANSPORTISTASTableAdapter1.FillPorCriterios(Me.DS_SIFAG1.SALDOS_ZAFRA_TRANSPORTISTAS, ID_ZAFRA, CODTRANSPORT)

        Dim lZafra As ZAFRA = (New cZAFRA).ObtenerZAFRA(ID_ZAFRA)
        If lZafra IsNot Nothing Then
            Me.lblZAFRA.Text = "ZAFRA " + lZafra.NOMBRE_ZAFRA
        End If
    End Sub
End Class