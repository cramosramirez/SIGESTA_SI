﻿Public Class ContratoEjecucionCensoTC_D

    Public Sub CargarDatos(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.CensoTableAdapter1.FillPorZona(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        Me.DisplayName = "CONTRATO VRS EJECUCION CENSO (MZ – TC)"
    End Sub
    Public Sub CargarCierreZafra(ByVal ID_CENSO As Integer, ByVal ZONA As String, ByVal SUB_ZONA As String, ByVal CODI_DEPTO As String, ByVal CODI_MUNI As String, ByVal CODI_CANTON As String)
        Me.CensoTableAdapter1.FillPorZonaCierreZafra(Me.DS_SIGESTA1.CENSO, ID_CENSO, ZONA, SUB_ZONA, CODI_DEPTO, CODI_MUNI, CODI_CANTON)
        Me.DisplayName = "CONTRATO VRS EJECUCION CENSO (MZ – TC)"
    End Sub
End Class