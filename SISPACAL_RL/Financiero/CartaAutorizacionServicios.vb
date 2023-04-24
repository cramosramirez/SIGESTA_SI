Imports SISPACAL.BL
Imports SISPACAL.EL

Public Class CartaAutorizacionServicios
    Public Sub CargarDatos(ByVal ID_ZAFRA As Integer, ByVal CODIPROVEEDOR As String, ByVal ID_CATORCENA As Integer, ByVal ID_PLANILLA_BASE As Integer)
        Dim lCatorcena As CATORCENA_ZAFRA = (New cCATORCENA_ZAFRA).ObtenerCATORCENA_ZAFRA(ID_CATORCENA)
        DS_SIFAG1.Clear()
        INTERES_PROVEE_AGRICOLATableAdapter1.FillPorCriteriosJiboa(DS_SIFAG1.INTERES_PROVEE_AGRICOLA, CODIPROVEEDOR, ID_CATORCENA, ID_PLANILLA_BASE)


    End Sub
End Class