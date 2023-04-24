Partial Class DS_CATORCENA
    Partial Class LIQUIDACION_CANEROSDataTable

        Private Sub LIQUIDACION_CANEROSDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NO_ANTICIPO_LETRASColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

Namespace DS_CATORCENATableAdapters
    
    Partial Public Class RPT_COMPARATIVO_REND_LOTETableAdapter
        Public Sub SetCommandTimeOut(ByVal timeOut As Integer)
            For Each command As SqlCommand In Me.CommandCollection
                command.CommandTimeout = timeOut
            Next
        End Sub
    End Class
End Namespace
