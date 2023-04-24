Partial Public Class cCONTROL_ROZA_SALDO

    Public Function ObtenerListaPROVEEDOR_ROZA(ByVal ID_ROZA_SALDO As Int32) As String
        Try
            Return mDb.ObtenerListaPROVEEDOR_ROZA(ID_ROZA_SALDO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerHorasQuemaRozaTranscurridas(ByVal ID_ROZA_SALDO As Int32) As Dictionary(Of String, Int32)
        Try
            Return mDb.ObtenerHorasQuemaRozaTranscurridas(ID_ROZA_SALDO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                            ByVal ACCESLOTE As String, _
                                            ByVal ID_PROVEEDOR_ROZA As Int32, _
                                            ByVal ID_TIPO_CANA As Int32, _
                                            ByVal ID_TIPO_ROZA As Int32, _
                                            ByVal FECHA_HORA_QUEMA As String, _
                                            ByVal FECHA_HORA_ROZA As String, _
                                            ByVal QUEMA_PROGRAMADA As Int32, _
                                            ByVal QUEMA_NOPROG As Int32, _
                                            ByVal CANA_VERDE As Int32, _
                                            ByVal CODIGO_REF As String, _
                                            ByVal ID_REF As Int32, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal TIPO_SALDO As Int32, _
                                            ByVal ES_QUERQUEO As Int32, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA_SALDO
        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, ID_PROVEEDOR_ROZA, ID_TIPO_CANA, ID_TIPO_ROZA, FECHA_HORA_QUEMA, FECHA_HORA_ROZA, QUEMA_PROGRAMADA, QUEMA_NOPROG, CANA_VERDE, CODIGO_REF, ID_REF, ES_PROYECCION, TIPO_SALDO, ES_QUERQUEO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ByVal ID_ZAFRA As Int32, _
                                             ByVal ACCESLOTE As String) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerSaldoTipoQuemaPorZAFRA_LOTE(ID_ZAFRA, ACCESLOTE)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosLiquidacion(ByVal ID_ZAFRA As Int32, _
                                            ByVal NO_CATORCENA As Int32, _
                                            ByVal CODIPROVEE As String, _
                                            ByVal CODISOCIO As String, _
                                            ByVal NOMBRE_PROVEEDOR As String, _
                                            ByVal NOMBRE_LOTE As String, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal TIPO_SALDO As Int32, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_ROZA_SALDO
        Try
            Return mDb.ObtenerListaPorCriteriosLiquidacion(ID_ZAFRA, NO_CATORCENA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBRE_LOTE, ES_PROYECCION, TIPO_SALDO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
