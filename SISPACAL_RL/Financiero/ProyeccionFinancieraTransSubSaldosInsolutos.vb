Public Class ProyeccionFinancieraTransSubSaldosInsolutos

    Public Sub Cargar(ByVal CODTRANSPORT As Int32)
        Me.DS_SIFAG1.Clear()
        Me.PROYECCION_FINANCIERA_SALDO_INSOTableAdapter1.FillPorCodtransport(Me.DS_SIFAG1.PROYECCION_FINANCIERA_SALDO_INSO, CODTRANSPORT)
    End Sub
End Class