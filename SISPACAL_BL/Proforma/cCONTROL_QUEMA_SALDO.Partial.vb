Partial Public Class cCONTROL_QUEMA_SALDO

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_ZAFRA As Int32, _
                                            ByVal ACCESLOTE As String, _
                                            ByVal FECHA_HORA_QUEMA As Object, _
                                            ByVal QUEMA_PROGRAMADA As Int32, _
                                            ByVal QUEMA_NOPROG As Int32, _
                                            ByVal CANA_VERDE As Int32, _
                                            ByVal ES_PROYECCION As Int32, _
                                            ByVal CON_SALDO As Boolean, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO

        Try
            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, FECHA_HORA_QUEMA, QUEMA_PROGRAMADA, QUEMA_NOPROG, CANA_VERDE, ES_PROYECCION, CON_SALDO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerPS_CONTROL_QUEMA(ByVal ID_ZAFRA As Int32, ByVal ACCESLOTE As String) As listaCONTROL_QUEMA_SALDO
        Try

            Return mDb.ObtenerListaPorCriterios(ID_ZAFRA, ACCESLOTE, -1, -1, -1, -1, -1, False, "FECHA_HORA_QUEMA, ID_QUEMA_SALDO", "ASC")

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
                                            Optional ByVal asTipoOrden As String = "ASC") As listaCONTROL_QUEMA_SALDO

        Try
            Return mDb.ObtenerListaPorCriteriosLiquidacion(ID_ZAFRA, NO_CATORCENA, CODIPROVEE, CODISOCIO, NOMBRE_PROVEEDOR, NOMBRE_LOTE, ES_PROYECCION, TIPO_SALDO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
