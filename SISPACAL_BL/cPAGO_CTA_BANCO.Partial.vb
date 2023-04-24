Partial Public Class cPAGO_CTA_BANCO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_CATORCENA As Int32, ByVal ID_TIPO_PLANILLA As Int32, ByVal ES_CONTRIBUYENTE As Int32, ByVal MOSTRAR_POR As Int32, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAGO_CTA_BANCO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_CATORCENA, ID_TIPO_PLANILLA, ES_CONTRIBUYENTE, MOSTRAR_POR, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
